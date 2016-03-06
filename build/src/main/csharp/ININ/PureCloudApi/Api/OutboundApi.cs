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
        AuditSearchResult PostAudits (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
  
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
        ApiResponse<AuditSearchResult> PostAuditsWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

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
        System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

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
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        
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
        CallableTimeSetEntityListing GetCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<CallableTimeSetEntityListing> GetCallabletimesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<CallableTimeSetEntityListing> GetCallabletimesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> GetCallabletimesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PostCallabletimesets (CallableTimeSet body = null);
  
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PostCallabletimesetsWithHttpInfo (CallableTimeSet body = null);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PostCallabletimesetsAsync (CallableTimeSet body = null);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostCallabletimesetsAsyncWithHttpInfo (CallableTimeSet body = null);
        
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet GetCallabletimesetsCallabletimesetId (string callableTimeSetId);
  
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> GetCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> GetCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId);
        
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PutCallabletimesetsCallabletimesetId (string callableTimeSetId, CallableTimeSet body = null);
  
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PutCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PutCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId, CallableTimeSet body = null);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null);
        
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        string DeleteCallabletimesetsCallabletimesetId (string callableTimeSetId);
  
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId);
        
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
        ResponseSetEntityListing GetCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<ResponseSetEntityListing> GetCallanalysisresponsesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ResponseSetEntityListing> GetCallanalysisresponsesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> GetCallanalysisresponsesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet PostCallanalysisresponsesets (ResponseSet body = null);
  
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> PostCallanalysisresponsesetsWithHttpInfo (ResponseSet body = null);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> PostCallanalysisresponsesetsAsync (ResponseSet body = null);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PostCallanalysisresponsesetsAsyncWithHttpInfo (ResponseSet body = null);
        
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        ResponseSet GetCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId);
  
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> GetCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> GetCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId);
        
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet PutCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId, ResponseSet body = null);
  
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> PutCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId, ResponseSet body = null);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> PutCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId, ResponseSet body = null);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body = null);
        
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        string DeleteCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId);
  
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId);
        
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
        CampaignEntityListing GetCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<CampaignEntityListing> GetCampaignsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<CampaignEntityListing> GetCampaignsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> GetCampaignsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign PostCampaigns (Campaign body = null);
  
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> PostCampaignsWithHttpInfo (Campaign body = null);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> PostCampaignsAsync (Campaign body = null);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PostCampaignsAsyncWithHttpInfo (Campaign body = null);
        
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign GetCampaignsCampaignId (string campaignId);
  
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> GetCampaignsCampaignIdWithHttpInfo (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> GetCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign PutCampaignsCampaignId (string campaignId, Campaign body = null);
  
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> PutCampaignsCampaignIdWithHttpInfo (string campaignId, Campaign body = null);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> PutCampaignsCampaignIdAsync (string campaignId, Campaign body = null);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PutCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, Campaign body = null);
        
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteCampaignsCampaignId (string campaignId);
  
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCampaignsCampaignIdWithHttpInfo (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        
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
        string PutCampaignsCampaignIdAgentsUserId (string campaignId, string userId, Agent body = null);
  
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
        ApiResponse<string> PutCampaignsCampaignIdAgentsUserIdWithHttpInfo (string campaignId, string userId, Agent body = null);

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
        System.Threading.Tasks.Task<string> PutCampaignsCampaignIdAgentsUserIdAsync (string campaignId, string userId, Agent body = null);

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
        System.Threading.Tasks.Task<ApiResponse<string>> PutCampaignsCampaignIdAgentsUserIdAsyncWithHttpInfo (string campaignId, string userId, Agent body = null);
        
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        ContactCallbackRequest PostCampaignsCampaignIdCallbackSchedule (string campaignId, ContactCallbackRequest body = null);
  
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        ApiResponse<ContactCallbackRequest> PostCampaignsCampaignIdCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body = null);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        System.Threading.Tasks.Task<ContactCallbackRequest> PostCampaignsCampaignIdCallbackScheduleAsync (string campaignId, ContactCallbackRequest body = null);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostCampaignsCampaignIdCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body = null);
        
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        CampaignDiagnostics GetCampaignsCampaignIdDiagnostics (string campaignId);
  
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        ApiResponse<CampaignDiagnostics> GetCampaignsCampaignIdDiagnosticsWithHttpInfo (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        System.Threading.Tasks.Task<CampaignDiagnostics> GetCampaignsCampaignIdDiagnosticsAsync (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetCampaignsCampaignIdDiagnosticsAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        CampaignStats GetCampaignsCampaignIdStats (string campaignId);
  
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        ApiResponse<CampaignStats> GetCampaignsCampaignIdStatsWithHttpInfo (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        System.Threading.Tasks.Task<CampaignStats> GetCampaignsCampaignIdStatsAsync (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetCampaignsCampaignIdStatsAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Include import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ContactListEntityListing</returns>
        ContactListEntityListing GetContactlists (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Include import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        ApiResponse<ContactListEntityListing> GetContactlistsWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Include import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListEntityListing</returns>
        System.Threading.Tasks.Task<ContactListEntityListing> GetContactlistsAsync (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Include import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> GetContactlistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList PostContactlists (ContactList body = null);
  
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> PostContactlistsWithHttpInfo (ContactList body = null);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> PostContactlistsAsync (ContactList body = null);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PostContactlistsAsyncWithHttpInfo (ContactList body = null);
        
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>List&lt;PenetrationRate&gt;</returns>
        List<PenetrationRate> PostContactlistsPenetrationrates (List<PenetrationRateId> body = null);
  
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>ApiResponse of List&lt;PenetrationRate&gt;</returns>
        ApiResponse<List<PenetrationRate>> PostContactlistsPenetrationratesWithHttpInfo (List<PenetrationRateId> body = null);

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of List&lt;PenetrationRate&gt;</returns>
        System.Threading.Tasks.Task<List<PenetrationRate>> PostContactlistsPenetrationratesAsync (List<PenetrationRateId> body = null);

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of ApiResponse (List&lt;PenetrationRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PenetrationRate>>> PostContactlistsPenetrationratesAsyncWithHttpInfo (List<PenetrationRateId> body = null);
        
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>ContactList</returns>
        ContactList GetContactlistsContactlistId (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);
  
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> GetContactlistsContactlistIdWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> GetContactlistsContactlistIdAsync (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> GetContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);
        
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList PutContactlistsContactlistId (string contactListId, ContactList body = null);
  
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> PutContactlistsContactlistIdWithHttpInfo (string contactListId, ContactList body = null);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> PutContactlistsContactlistIdAsync (string contactListId, ContactList body = null);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PutContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, ContactList body = null);
        
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string DeleteContactlistsContactlistId (string contactListId);
  
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteContactlistsContactlistIdWithHttpInfo (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdAsync (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdAsyncWithHttpInfo (string contactListId);
        
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
        Contact PostContactlistsContactlistIdContacts (string contactListId, List<Contact> body = null, bool? priority = null);
  
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
        ApiResponse<Contact> PostContactlistsContactlistIdContactsWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null);

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
        System.Threading.Tasks.Task<Contact> PostContactlistsContactlistIdContactsAsync (string contactListId, List<Contact> body = null, bool? priority = null);

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
        System.Threading.Tasks.Task<ApiResponse<Contact>> PostContactlistsContactlistIdContactsAsyncWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null);
        
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Contact</returns>
        Contact GetContactlistsContactlistIdContactsContactId (string contactListId, string contactId);
  
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> GetContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> GetContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> GetContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId);
        
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
        Contact PutContactlistsContactlistIdContactsContactId (string contactListId, string contactId, Contact body = null);
  
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
        ApiResponse<Contact> PutContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId, Contact body = null);

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
        System.Threading.Tasks.Task<Contact> PutContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId, Contact body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Contact>> PutContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId, Contact body = null);
        
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>string</returns>
        string DeleteContactlistsContactlistIdContactsContactId (string contactListId, string contactId);
  
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId);

        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId);

        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId);
        
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string PostContactlistsContactlistIdExport (string contactListId);
  
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostContactlistsContactlistIdExportWithHttpInfo (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostContactlistsContactlistIdExportAsync (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostContactlistsContactlistIdExportAsyncWithHttpInfo (string contactListId);
        
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetContactlistsContactlistIdImportstatus (string contactListId);
  
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetContactlistsContactlistIdImportstatusWithHttpInfo (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetContactlistsContactlistIdImportstatusAsync (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetContactlistsContactlistIdImportstatusAsyncWithHttpInfo (string contactListId);
        
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>PenetrationRate</returns>
        PenetrationRate GetContactlistsContactlistIdCampaignIdPenetrationrate (string contactListId, string campaignId);
  
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of PenetrationRate</returns>
        ApiResponse<PenetrationRate> GetContactlistsContactlistIdCampaignIdPenetrationrateWithHttpInfo (string contactListId, string campaignId);

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of PenetrationRate</returns>
        System.Threading.Tasks.Task<PenetrationRate> GetContactlistsContactlistIdCampaignIdPenetrationrateAsync (string contactListId, string campaignId);

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (PenetrationRate)</returns>
        System.Threading.Tasks.Task<ApiResponse<PenetrationRate>> GetContactlistsContactlistIdCampaignIdPenetrationrateAsyncWithHttpInfo (string contactListId, string campaignId);
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        void PostConversationsConversationIdDnc (string conversationId);
  
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsConversationIdDncWithHttpInfo (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsConversationIdDncAsync (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsConversationIdDncAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>DncListEntityListing</returns>
        DncListEntityListing GetDnclists (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        ApiResponse<DncListEntityListing> GetDnclistsWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of DncListEntityListing</returns>
        System.Threading.Tasks.Task<DncListEntityListing> GetDnclistsAsync (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> GetDnclistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList PostDnclists (DncList body = null);
  
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> PostDnclistsWithHttpInfo (DncList body = null);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> PostDnclistsAsync (DncList body = null);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> PostDnclistsAsyncWithHttpInfo (DncList body = null);
        
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>DncList</returns>
        DncList GetDnclistsDnclistId (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);
  
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> GetDnclistsDnclistIdWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> GetDnclistsDnclistIdAsync (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> GetDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null);
        
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList PutDnclistsDnclistId (string dncListId, DncList body = null);
  
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> PutDnclistsDnclistIdWithHttpInfo (string dncListId, DncList body = null);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> PutDnclistsDnclistIdAsync (string dncListId, DncList body = null);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> PutDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, DncList body = null);
        
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string DeleteDnclistsDnclistId (string dncListId);
  
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDnclistsDnclistIdWithHttpInfo (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDnclistsDnclistIdAsync (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDnclistsDnclistIdAsyncWithHttpInfo (string dncListId);
        
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string PostDnclistsDnclistIdExport (string dncListId);
  
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostDnclistsDnclistIdExportWithHttpInfo (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostDnclistsDnclistIdExportAsync (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostDnclistsDnclistIdExportAsyncWithHttpInfo (string dncListId);
        
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetDnclistsDnclistIdImportstatus (string dncListId);
  
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetDnclistsDnclistIdImportstatusWithHttpInfo (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetDnclistsDnclistIdImportstatusAsync (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetDnclistsDnclistIdImportstatusAsyncWithHttpInfo (string dncListId);
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns></returns>
        void PostDnclistsDnclistIdPhonenumbers (string dncListId, List<string> body = null);
  
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostDnclistsDnclistIdPhonenumbersWithHttpInfo (string dncListId, List<string> body = null);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostDnclistsDnclistIdPhonenumbersAsync (string dncListId, List<string> body = null);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostDnclistsDnclistIdPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body = null);
        
        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;Preview&gt;</returns>
        List<Preview> GetPreviews ();
  
        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;Preview&gt;</returns>
        ApiResponse<List<Preview>> GetPreviewsWithHttpInfo ();

        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;Preview&gt;</returns>
        System.Threading.Tasks.Task<List<Preview>> GetPreviewsAsync ();

        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;Preview&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Preview>>> GetPreviewsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>Preview</returns>
        Preview GetPreviewsPreviewId (string previewId);
  
        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>ApiResponse of Preview</returns>
        ApiResponse<Preview> GetPreviewsPreviewIdWithHttpInfo (string previewId);

        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of Preview</returns>
        System.Threading.Tasks.Task<Preview> GetPreviewsPreviewIdAsync (string previewId);

        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of ApiResponse (Preview)</returns>
        System.Threading.Tasks.Task<ApiResponse<Preview>> GetPreviewsPreviewIdAsyncWithHttpInfo (string previewId);
        
        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string PostPreviewsPreviewIdDispositioncall (string previewId, DialerDispositionCallCommand body = null);
  
        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostPreviewsPreviewIdDispositioncallWithHttpInfo (string previewId, DialerDispositionCallCommand body = null);

        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostPreviewsPreviewIdDispositioncallAsync (string previewId, DialerDispositionCallCommand body = null);

        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostPreviewsPreviewIdDispositioncallAsyncWithHttpInfo (string previewId, DialerDispositionCallCommand body = null);
        
        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>DialerCall</returns>
        DialerCall PostPreviewsPreviewIdPlacecall (string previewId, DialerPlaceCallCommand body = null);
  
        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DialerCall</returns>
        ApiResponse<DialerCall> PostPreviewsPreviewIdPlacecallWithHttpInfo (string previewId, DialerPlaceCallCommand body = null);

        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DialerCall</returns>
        System.Threading.Tasks.Task<DialerCall> PostPreviewsPreviewIdPlacecallAsync (string previewId, DialerPlaceCallCommand body = null);

        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DialerCall)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerCall>> PostPreviewsPreviewIdPlacecallAsyncWithHttpInfo (string previewId, DialerPlaceCallCommand body = null);
        
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
        RuleSetEntityListing GetRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<RuleSetEntityListing> GetRulesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<RuleSetEntityListing> GetRulesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> GetRulesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet PostRulesets (RuleSet body = null);
  
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> PostRulesetsWithHttpInfo (RuleSet body = null);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> PostRulesetsAsync (RuleSet body = null);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PostRulesetsAsyncWithHttpInfo (RuleSet body = null);
        
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        RuleSet GetRulesetsRulesetId (string ruleSetId);
  
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> GetRulesetsRulesetIdWithHttpInfo (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> GetRulesetsRulesetIdAsync (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId);
        
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet PutRulesetsRulesetId (string ruleSetId, RuleSet body = null);
  
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> PutRulesetsRulesetIdWithHttpInfo (string ruleSetId, RuleSet body = null);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> PutRulesetsRulesetIdAsync (string ruleSetId, RuleSet body = null);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId, RuleSet body = null);
        
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        string DeleteRulesetsRulesetId (string ruleSetId);
  
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRulesetsRulesetIdWithHttpInfo (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRulesetsRulesetIdAsync (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId);
        
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        List<CampaignSchedule> GetSchedulesCampaigns ();
  
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        ApiResponse<List<CampaignSchedule>> GetSchedulesCampaignsWithHttpInfo ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignSchedule>> GetSchedulesCampaignsAsync ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> GetSchedulesCampaignsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule GetSchedulesCampaignsCampaignId (string campaignId);
  
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> GetSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> GetSchedulesCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule PutSchedulesCampaignsCampaignId (string campaignId, CampaignSchedule body = null);
  
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> PutSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId, CampaignSchedule body = null);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> PutSchedulesCampaignsCampaignIdAsync (string campaignId, CampaignSchedule body = null);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, CampaignSchedule body = null);
        
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesCampaignsCampaignId (string campaignId);
  
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        List<SequenceSchedule> GetSchedulesSequences ();
  
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        ApiResponse<List<SequenceSchedule>> GetSchedulesSequencesWithHttpInfo ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<SequenceSchedule>> GetSchedulesSequencesAsync ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> GetSchedulesSequencesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule GetSchedulesSequencesSequenceId (string sequenceId);
  
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> GetSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> GetSchedulesSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule PutSchedulesSequencesSequenceId (string sequenceId, SequenceSchedule body = null);
  
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> PutSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId, SequenceSchedule body = null);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> PutSchedulesSequencesSequenceIdAsync (string sequenceId, SequenceSchedule body = null);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, SequenceSchedule body = null);
        
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesSequencesSequenceId (string sequenceId);
  
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        
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
        CampaignSequenceEntityListing GetSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<CampaignSequenceEntityListing> GetSequencesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<CampaignSequenceEntityListing> GetSequencesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> GetSequencesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence PostSequences (CampaignSequence body = null);
  
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> PostSequencesWithHttpInfo (CampaignSequence body = null);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> PostSequencesAsync (CampaignSequence body = null);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PostSequencesAsyncWithHttpInfo (CampaignSequence body = null);
        
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence GetSequencesSequenceId (string sequenceId);
  
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> GetSequencesSequenceIdWithHttpInfo (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> GetSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence PutSequencesSequenceId (string sequenceId, CampaignSequence body = null);
  
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> PutSequencesSequenceIdWithHttpInfo (string sequenceId, CampaignSequence body = null);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> PutSequencesSequenceIdAsync (string sequenceId, CampaignSequence body = null);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, CampaignSequence body = null);
        
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        string DeleteSequencesSequenceId (string sequenceId);
  
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSequencesSequenceIdWithHttpInfo (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping GetWrapupcodemappings ();
  
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> GetWrapupcodemappingsWithHttpInfo ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> GetWrapupcodemappingsAsync ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> GetWrapupcodemappingsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping PutWrapupcodemappings (WrapUpCodeMapping body = null);
  
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> PutWrapupcodemappingsWithHttpInfo (WrapUpCodeMapping body = null);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> PutWrapupcodemappingsAsync (WrapUpCodeMapping body = null);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> PutWrapupcodemappingsAsyncWithHttpInfo (WrapUpCodeMapping body = null);
        
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
        public AuditSearchResult PostAudits (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> response = PostAuditsWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
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
        public ApiResponse< AuditSearchResult > PostAuditsWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            
    
            var path_ = "/api/v1/outbound/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            if (facetsOnly != null) queryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> response = await PostAuditsAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
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
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            
    
            var path_ = "/api/v1/outbound/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            if (facetsOnly != null) queryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.ErrorMessage, response.ErrorMessage);

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
        public CallableTimeSetEntityListing GetCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> response = GetCallabletimesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< CallableTimeSetEntityListing > GetCallabletimesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallabletimesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallabletimesets: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CallableTimeSetEntityListing> GetCallabletimesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> response = await GetCallabletimesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> GetCallabletimesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallabletimesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallabletimesets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSetEntityListing)));
            
        }
        
        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PostCallabletimesets (CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = PostCallabletimesetsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PostCallabletimesetsWithHttpInfo (CallableTimeSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostCallabletimesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCallabletimesets: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PostCallabletimesetsAsync (CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = await PostCallabletimesetsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostCallabletimesetsAsyncWithHttpInfo (CallableTimeSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callabletimesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostCallabletimesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCallabletimesets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet GetCallabletimesetsCallabletimesetId (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> response = GetCallabletimesetsCallabletimesetIdWithHttpInfo(callableTimeSetId);
             return response.Data;
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > GetCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId)
        {
            
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetCallabletimesetsCallabletimesetId");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
    
        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> GetCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> response = await GetCallabletimesetsCallabletimesetIdAsyncWithHttpInfo(callableTimeSetId);
             return response.Data;

        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling GetCallabletimesetsCallabletimesetId");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + response.ErrorMessage, response.ErrorMessage);

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
        public CallableTimeSet PutCallabletimesetsCallabletimesetId (string callableTimeSetId, CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = PutCallabletimesetsCallabletimesetIdWithHttpInfo(callableTimeSetId, body);
             return response.Data;
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <param name="body">DialerCallableTimeSet</param> 
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PutCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null)
        {
            
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutCallabletimesetsCallabletimesetId");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (callableTimeSetId != null) pathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CallableTimeSet> PutCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId, CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> response = await PutCallabletimesetsCallabletimesetIdAsyncWithHttpInfo(callableTimeSetId, body);
             return response.Data;

        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling PutCallabletimesetsCallabletimesetId");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(response, typeof(CallableTimeSet)));
            
        }
        
        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>string</returns>
        public string DeleteCallabletimesetsCallabletimesetId (string callableTimeSetId)
        {
             ApiResponse<string> response = DeleteCallabletimesetsCallabletimesetIdWithHttpInfo(callableTimeSetId);
             return response.Data;
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId)
        {
            
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteCallabletimesetsCallabletimesetId");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId)
        {
             ApiResponse<string> response = await DeleteCallabletimesetsCallabletimesetIdAsyncWithHttpInfo(callableTimeSetId);
             return response.Data;

        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null) throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling DeleteCallabletimesetsCallabletimesetId");
            
    
            var path_ = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ResponseSetEntityListing GetCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> response = GetCallanalysisresponsesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< ResponseSetEntityListing > GetCallanalysisresponsesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesets: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ResponseSetEntityListing> GetCallanalysisresponsesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> response = await GetCallanalysisresponsesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> GetCallanalysisresponsesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ResponseSetEntityListing)));
            
        }
        
        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param> 
        /// <returns>ResponseSet</returns>
        public ResponseSet PostCallanalysisresponsesets (ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = PostCallanalysisresponsesetsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param> 
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PostCallanalysisresponsesetsWithHttpInfo (ResponseSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostCallanalysisresponsesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCallanalysisresponsesets: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
    
        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> PostCallanalysisresponsesetsAsync (ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = await PostCallanalysisresponsesetsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PostCallanalysisresponsesetsAsyncWithHttpInfo (ResponseSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostCallanalysisresponsesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCallanalysisresponsesets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
        
        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>ResponseSet</returns>
        public ResponseSet GetCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> response = GetCallanalysisresponsesetsCallanalysissetIdWithHttpInfo(callAnalysisSetId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > GetCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId)
        {
            
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetCallanalysisresponsesetsCallanalysissetId");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
    
        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> GetCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> response = await GetCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo(callAnalysisSetId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling GetCallanalysisresponsesetsCallanalysissetId");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ResponseSet PutCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId, ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = PutCallanalysisresponsesetsCallanalysissetIdWithHttpInfo(callAnalysisSetId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <param name="body">ResponseSet</param> 
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PutCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId, ResponseSet body = null)
        {
            
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutCallanalysisresponsesetsCallanalysissetId");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (callAnalysisSetId != null) pathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ResponseSet> PutCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId, ResponseSet body = null)
        {
             ApiResponse<ResponseSet> response = await PutCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo(callAnalysisSetId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body = null)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling PutCallanalysisresponsesetsCallanalysissetId");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResponseSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(response, typeof(ResponseSet)));
            
        }
        
        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>string</returns>
        public string DeleteCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId)
        {
             ApiResponse<string> response = DeleteCallanalysisresponsesetsCallanalysissetIdWithHttpInfo(callAnalysisSetId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId)
        {
            
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteCallanalysisresponsesetsCallanalysissetId");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId)
        {
             ApiResponse<string> response = await DeleteCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo(callAnalysisSetId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null) throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling DeleteCallanalysisresponsesetsCallanalysissetId");
            
    
            var path_ = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + response.ErrorMessage, response.ErrorMessage);

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
        public CampaignEntityListing GetCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> response = GetCampaignsWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
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
        public ApiResponse< CampaignEntityListing > GetCampaignsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaigns: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaigns: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CampaignEntityListing> GetCampaignsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> response = await GetCampaignsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> GetCampaignsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaigns: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaigns: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CampaignEntityListing)));
            
        }
        
        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param> 
        /// <returns>Campaign</returns>
        public Campaign PostCampaigns (Campaign body = null)
        {
             ApiResponse<Campaign> response = PostCampaignsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param> 
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PostCampaignsWithHttpInfo (Campaign body = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostCampaigns: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCampaigns: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
    
        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> PostCampaignsAsync (Campaign body = null)
        {
             ApiResponse<Campaign> response = await PostCampaignsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PostCampaignsAsyncWithHttpInfo (Campaign body = null)
        {
            
    
            var path_ = "/api/v1/outbound/campaigns";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostCampaigns: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCampaigns: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
        
        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>Campaign</returns>
        public Campaign GetCampaignsCampaignId (string campaignId)
        {
             ApiResponse<Campaign> response = GetCampaignsCampaignIdWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > GetCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
    
        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> GetCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<Campaign> response = await GetCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling GetCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Campaign PutCampaignsCampaignId (string campaignId, Campaign body = null)
        {
             ApiResponse<Campaign> response = PutCampaignsCampaignIdWithHttpInfo(campaignId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">Campaign</param> 
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PutCampaignsCampaignIdWithHttpInfo (string campaignId, Campaign body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Campaign> PutCampaignsCampaignIdAsync (string campaignId, Campaign body = null)
        {
             ApiResponse<Campaign> response = await PutCampaignsCampaignIdAsyncWithHttpInfo(campaignId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PutCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, Campaign body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling PutCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Campaign>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(response, typeof(Campaign)));
            
        }
        
        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>string</returns>
        public string DeleteCampaignsCampaignId (string campaignId)
        {
             ApiResponse<string> response = DeleteCampaignsCampaignIdWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<string> response = await DeleteCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling DeleteCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);

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
        public string PutCampaignsCampaignIdAgentsUserId (string campaignId, string userId, Agent body = null)
        {
             ApiResponse<string> response = PutCampaignsCampaignIdAgentsUserIdWithHttpInfo(campaignId, userId, body);
             return response.Data;
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed New agent state.
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="userId">Agent&#39;s user ID</param> 
        /// <param name="body">agent</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PutCampaignsCampaignIdAgentsUserIdWithHttpInfo (string campaignId, string userId, Agent body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/agents/{userId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> PutCampaignsCampaignIdAgentsUserIdAsync (string campaignId, string userId, Agent body = null)
        {
             ApiResponse<string> response = await PutCampaignsCampaignIdAgentsUserIdAsyncWithHttpInfo(campaignId, userId, body);
             return response.Data;

        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed New agent state.
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PutCampaignsCampaignIdAgentsUserIdAsyncWithHttpInfo (string campaignId, string userId, Agent body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling PutCampaignsCampaignIdAgentsUserId");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PutCampaignsCampaignIdAgentsUserId");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/agents/{userId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ContactCallbackRequest PostCampaignsCampaignIdCallbackSchedule (string campaignId, ContactCallbackRequest body = null)
        {
             ApiResponse<ContactCallbackRequest> response = PostCampaignsCampaignIdCallbackScheduleWithHttpInfo(campaignId, body);
             return response.Data;
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">ContactCallbackRequest</param> 
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        public ApiResponse< ContactCallbackRequest > PostCampaignsCampaignIdCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostCampaignsCampaignIdCallbackSchedule");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/callback/schedule";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ContactCallbackRequest> PostCampaignsCampaignIdCallbackScheduleAsync (string campaignId, ContactCallbackRequest body = null)
        {
             ApiResponse<ContactCallbackRequest> response = await PostCampaignsCampaignIdCallbackScheduleAsyncWithHttpInfo(campaignId, body);
             return response.Data;

        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostCampaignsCampaignIdCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling PostCampaignsCampaignIdCallbackSchedule");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/callback/schedule";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(response, typeof(ContactCallbackRequest)));
            
        }
        
        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>CampaignDiagnostics</returns>
        public CampaignDiagnostics GetCampaignsCampaignIdDiagnostics (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> response = GetCampaignsCampaignIdDiagnosticsWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        public ApiResponse< CampaignDiagnostics > GetCampaignsCampaignIdDiagnosticsWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdDiagnostics");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/diagnostics";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignDiagnostics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(response, typeof(CampaignDiagnostics)));
            
        }
    
        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        public async System.Threading.Tasks.Task<CampaignDiagnostics> GetCampaignsCampaignIdDiagnosticsAsync (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> response = await GetCampaignsCampaignIdDiagnosticsAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetCampaignsCampaignIdDiagnosticsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling GetCampaignsCampaignIdDiagnostics");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/diagnostics";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(response, typeof(CampaignDiagnostics)));
            
        }
        
        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>CampaignStats</returns>
        public CampaignStats GetCampaignsCampaignIdStats (string campaignId)
        {
             ApiResponse<CampaignStats> response = GetCampaignsCampaignIdStatsWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of CampaignStats</returns>
        public ApiResponse< CampaignStats > GetCampaignsCampaignIdStatsWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdStats");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/stats";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdStats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignStats>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(response, typeof(CampaignStats)));
            
        }
    
        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        public async System.Threading.Tasks.Task<CampaignStats> GetCampaignsCampaignIdStatsAsync (string campaignId)
        {
             ApiResponse<CampaignStats> response = await GetCampaignsCampaignIdStatsAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetCampaignsCampaignIdStatsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling GetCampaignsCampaignIdStats");
            
    
            var path_ = "/api/v1/outbound/campaigns/{campaignId}/stats";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdStats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCampaignsCampaignIdStats: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignStats>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(response, typeof(CampaignStats)));
            
        }
        
        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="includeImportStatus">Include import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ContactListEntityListing</returns>
        public ContactListEntityListing GetContactlists (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> response = GetContactlistsWithHttpInfo(includeImportStatus, importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="includeImportStatus">Include import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        public ApiResponse< ContactListEntityListing > GetContactlistsWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlists: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListEntityListing)));
            
        }
    
        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="includeImportStatus">Include import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListEntityListing</returns>
        public async System.Threading.Tasks.Task<ContactListEntityListing> GetContactlistsAsync (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> response = await GetContactlistsAsyncWithHttpInfo(includeImportStatus, importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <param name="includeImportStatus">Include import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> GetContactlistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlists: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListEntityListing)));
            
        }
        
        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param> 
        /// <returns>ContactList</returns>
        public ContactList PostContactlists (ContactList body = null)
        {
             ApiResponse<ContactList> response = PostContactlistsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param> 
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PostContactlistsWithHttpInfo (ContactList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostContactlists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlists: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
    
        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> PostContactlistsAsync (ContactList body = null)
        {
             ApiResponse<ContactList> response = await PostContactlistsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PostContactlistsAsyncWithHttpInfo (ContactList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostContactlists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlists: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
        
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param> 
        /// <returns>List&lt;PenetrationRate&gt;</returns>
        public List<PenetrationRate> PostContactlistsPenetrationrates (List<PenetrationRateId> body = null)
        {
             ApiResponse<List<PenetrationRate>> response = PostContactlistsPenetrationratesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param> 
        /// <returns>ApiResponse of List&lt;PenetrationRate&gt;</returns>
        public ApiResponse< List<PenetrationRate> > PostContactlistsPenetrationratesWithHttpInfo (List<PenetrationRateId> body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists/penetrationrates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostContactlistsPenetrationrates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlistsPenetrationrates: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<PenetrationRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PenetrationRate>) Configuration.ApiClient.Deserialize(response, typeof(List<PenetrationRate>)));
            
        }
    
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of List&lt;PenetrationRate&gt;</returns>
        public async System.Threading.Tasks.Task<List<PenetrationRate>> PostContactlistsPenetrationratesAsync (List<PenetrationRateId> body = null)
        {
             ApiResponse<List<PenetrationRate>> response = await PostContactlistsPenetrationratesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <param name="body">PenetrationRateIdentifierList</param>
        /// <returns>Task of ApiResponse (List&lt;PenetrationRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PenetrationRate>>> PostContactlistsPenetrationratesAsyncWithHttpInfo (List<PenetrationRateId> body = null)
        {
            
    
            var path_ = "/api/v1/outbound/contactlists/penetrationrates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostContactlistsPenetrationrates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlistsPenetrationrates: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<PenetrationRate>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PenetrationRate>) Configuration.ApiClient.Deserialize(response, typeof(List<PenetrationRate>)));
            
        }
        
        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="includeImportStatus">Import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>ContactList</returns>
        public ContactList GetContactlistsContactlistId (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> response = GetContactlistsContactlistIdWithHttpInfo(contactListId, includeImportStatus, importStatus, includeSize);
             return response.Data;
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="includeImportStatus">Import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > GetContactlistsContactlistIdWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
    
        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> GetContactlistsContactlistIdAsync (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> response = await GetContactlistsContactlistIdAsyncWithHttpInfo(contactListId, includeImportStatus, importStatus, includeSize);
             return response.Data;

        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> GetContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling GetContactlistsContactlistId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistId: " + response.ErrorMessage, response.ErrorMessage);

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
        public ContactList PutContactlistsContactlistId (string contactListId, ContactList body = null)
        {
             ApiResponse<ContactList> response = PutContactlistsContactlistIdWithHttpInfo(contactListId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="body">ContactList</param> 
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PutContactlistsContactlistIdWithHttpInfo (string contactListId, ContactList body = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistsContactlistId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ContactList> PutContactlistsContactlistIdAsync (string contactListId, ContactList body = null)
        {
             ApiResponse<ContactList> response = await PutContactlistsContactlistIdAsyncWithHttpInfo(contactListId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PutContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, ContactList body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling PutContactlistsContactlistId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(response, typeof(ContactList)));
            
        }
        
        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>string</returns>
        public string DeleteContactlistsContactlistId (string contactListId)
        {
             ApiResponse<string> response = DeleteContactlistsContactlistIdWithHttpInfo(contactListId);
             return response.Data;
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteContactlistsContactlistIdWithHttpInfo (string contactListId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistsContactlistId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdAsync (string contactListId)
        {
             ApiResponse<string> response = await DeleteContactlistsContactlistIdAsyncWithHttpInfo(contactListId);
             return response.Data;

        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling DeleteContactlistsContactlistId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Contact PostContactlistsContactlistIdContacts (string contactListId, List<Contact> body = null, bool? priority = null)
        {
             ApiResponse<Contact> response = PostContactlistsContactlistIdContactsWithHttpInfo(contactListId, body, priority);
             return response.Data;
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="body">Contact</param> 
        /// <param name="priority"></param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > PostContactlistsContactlistIdContactsWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistsContactlistIdContacts");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            
            if (priority != null) queryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Contact> PostContactlistsContactlistIdContactsAsync (string contactListId, List<Contact> body = null, bool? priority = null)
        {
             ApiResponse<Contact> response = await PostContactlistsContactlistIdContactsAsyncWithHttpInfo(contactListId, body, priority);
             return response.Data;

        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority"></param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> PostContactlistsContactlistIdContactsAsyncWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling PostContactlistsContactlistIdContacts");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdContacts: " + response.ErrorMessage, response.ErrorMessage);

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
        public Contact GetContactlistsContactlistIdContactsContactId (string contactListId, string contactId)
        {
             ApiResponse<Contact> response = GetContactlistsContactlistIdContactsContactIdWithHttpInfo(contactListId, contactId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > GetContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdContactsContactId");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetContactlistsContactlistIdContactsContactId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Contact> GetContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId)
        {
             ApiResponse<Contact> response = await GetContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo(contactListId, contactId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> GetContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling GetContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetContactlistsContactlistIdContactsContactId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Contact PutContactlistsContactlistIdContactsContactId (string contactListId, string contactId, Contact body = null)
        {
             ApiResponse<Contact> response = PutContactlistsContactlistIdContactsContactIdWithHttpInfo(contactListId, contactId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <param name="body">Contact</param> 
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > PutContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId, Contact body = null)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactListId != null) pathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Contact> PutContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId, Contact body = null)
        {
             ApiResponse<Contact> response = await PutContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo(contactListId, contactId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> PutContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId, Contact body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling PutContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PutContactlistsContactlistIdContactsContactId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteContactlistsContactlistIdContactsContactId (string contactListId, string contactId)
        {
             ApiResponse<string> response = DeleteContactlistsContactlistIdContactsContactIdWithHttpInfo(contactListId, contactId);
             return response.Data;
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param> 
        /// <param name="contactId">Contact ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistsContactlistIdContactsContactId");
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->DeleteContactlistsContactlistIdContactsContactId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId)
        {
             ApiResponse<string> response = await DeleteContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo(contactListId, contactId);
             return response.Data;

        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling DeleteContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling DeleteContactlistsContactlistIdContactsContactId");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>string</returns>
        public string PostContactlistsContactlistIdExport (string contactListId)
        {
             ApiResponse<string> response = PostContactlistsContactlistIdExportWithHttpInfo(contactListId);
             return response.Data;
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostContactlistsContactlistIdExportWithHttpInfo (string contactListId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistsContactlistIdExport");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/export";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdExport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdExport: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostContactlistsContactlistIdExportAsync (string contactListId)
        {
             ApiResponse<string> response = await PostContactlistsContactlistIdExportAsyncWithHttpInfo(contactListId);
             return response.Data;

        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostContactlistsContactlistIdExportAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling PostContactlistsContactlistIdExport");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/export";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdExport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactlistsContactlistIdExport: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ImportStatus</returns>
        public ImportStatus GetContactlistsContactlistIdImportstatus (string contactListId)
        {
             ApiResponse<ImportStatus> response = GetContactlistsContactlistIdImportstatusWithHttpInfo(contactListId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetContactlistsContactlistIdImportstatusWithHttpInfo (string contactListId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdImportstatus");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/importstatus";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ImportStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(response, typeof(ImportStatus)));
            
        }
    
        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> GetContactlistsContactlistIdImportstatusAsync (string contactListId)
        {
             ApiResponse<ImportStatus> response = await GetContactlistsContactlistIdImportstatusAsyncWithHttpInfo(contactListId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetContactlistsContactlistIdImportstatusAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling GetContactlistsContactlistIdImportstatus");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/importstatus";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + response.ErrorMessage, response.ErrorMessage);

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
        public PenetrationRate GetContactlistsContactlistIdCampaignIdPenetrationrate (string contactListId, string campaignId)
        {
             ApiResponse<PenetrationRate> response = GetContactlistsContactlistIdCampaignIdPenetrationrateWithHttpInfo(contactListId, campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param> 
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of PenetrationRate</returns>
        public ApiResponse< PenetrationRate > GetContactlistsContactlistIdCampaignIdPenetrationrateWithHttpInfo (string contactListId, string campaignId)
        {
            
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdCampaignIdPenetrationrate");
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetContactlistsContactlistIdCampaignIdPenetrationrate");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdCampaignIdPenetrationrate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdCampaignIdPenetrationrate: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PenetrationRate> GetContactlistsContactlistIdCampaignIdPenetrationrateAsync (string contactListId, string campaignId)
        {
             ApiResponse<PenetrationRate> response = await GetContactlistsContactlistIdCampaignIdPenetrationrateAsyncWithHttpInfo(contactListId, campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (PenetrationRate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PenetrationRate>> GetContactlistsContactlistIdCampaignIdPenetrationrateAsyncWithHttpInfo (string contactListId, string campaignId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null) throw new ApiException(400, "Missing required parameter 'contactListId' when calling GetContactlistsContactlistIdCampaignIdPenetrationrate");
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling GetContactlistsContactlistIdCampaignIdPenetrationrate");
            
    
            var path_ = "/api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdCampaignIdPenetrationrate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactlistsContactlistIdCampaignIdPenetrationrate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PenetrationRate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PenetrationRate) Configuration.ApiClient.Deserialize(response, typeof(PenetrationRate)));
            
        }
        
        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <returns></returns>
        public void PostConversationsConversationIdDnc (string conversationId)
        {
             PostConversationsConversationIdDncWithHttpInfo(conversationId);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsConversationIdDncWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostConversationsConversationIdDnc");
            
    
            var path_ = "/api/v1/outbound/conversations/{conversationId}/dnc";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdDnc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdDnc: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationsConversationIdDncAsync (string conversationId)
        {
             await PostConversationsConversationIdDncAsyncWithHttpInfo(conversationId);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsConversationIdDncAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationsConversationIdDnc");
            
    
            var path_ = "/api/v1/outbound/conversations/{conversationId}/dnc";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdDnc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdDnc: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="includeImportStatus">Import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>DncListEntityListing</returns>
        public DncListEntityListing GetDnclists (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> response = GetDnclistsWithHttpInfo(includeImportStatus, importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="includeImportStatus">Import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="filterType">Filter type</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of DncListEntityListing</returns>
        public ApiResponse< DncListEntityListing > GetDnclistsWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDnclists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDnclists: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DncListEntityListing)));
            
        }
    
        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of DncListEntityListing</returns>
        public async System.Threading.Tasks.Task<DncListEntityListing> GetDnclistsAsync (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> response = await GetDnclistsAsyncWithHttpInfo(includeImportStatus, importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="filterType">Filter type</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> GetDnclistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDnclists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDnclists: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DncListEntityListing)));
            
        }
        
        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param> 
        /// <returns>DncList</returns>
        public DncList PostDnclists (DncList body = null)
        {
             ApiResponse<DncList> response = PostDnclistsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param> 
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PostDnclistsWithHttpInfo (DncList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostDnclists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDnclists: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
    
        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> PostDnclistsAsync (DncList body = null)
        {
             ApiResponse<DncList> response = await PostDnclistsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PostDnclistsAsyncWithHttpInfo (DncList body = null)
        {
            
    
            var path_ = "/api/v1/outbound/dnclists";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostDnclists: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDnclists: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
        
        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="includeImportStatus">Import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>DncList</returns>
        public DncList GetDnclistsDnclistId (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> response = GetDnclistsDnclistIdWithHttpInfo(dncListId, includeImportStatus, importStatus, includeSize);
             return response.Data;
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="includeImportStatus">Import status</param> 
        /// <param name="importStatus">Import status</param> 
        /// <param name="includeSize">Include size</param> 
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > GetDnclistsDnclistIdWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistId");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
    
        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> GetDnclistsDnclistIdAsync (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> response = await GetDnclistsDnclistIdAsyncWithHttpInfo(dncListId, includeImportStatus, importStatus, includeSize);
             return response.Data;

        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status</param>
        /// <param name="importStatus">Import status</param>
        /// <param name="includeSize">Include size</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> GetDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling GetDnclistsDnclistId");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            if (includeImportStatus != null) queryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
            if (importStatus != null) queryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) queryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistId: " + response.ErrorMessage, response.ErrorMessage);

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
        public DncList PutDnclistsDnclistId (string dncListId, DncList body = null)
        {
             ApiResponse<DncList> response = PutDnclistsDnclistIdWithHttpInfo(dncListId, body);
             return response.Data;
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="body">DncList</param> 
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PutDnclistsDnclistIdWithHttpInfo (string dncListId, DncList body = null)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutDnclistsDnclistId");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutDnclistsDnclistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDnclistsDnclistId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DncList> PutDnclistsDnclistIdAsync (string dncListId, DncList body = null)
        {
             ApiResponse<DncList> response = await PutDnclistsDnclistIdAsyncWithHttpInfo(dncListId, body);
             return response.Data;

        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PutDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, DncList body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling PutDnclistsDnclistId");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutDnclistsDnclistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutDnclistsDnclistId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DncList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(response, typeof(DncList)));
            
        }
        
        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>string</returns>
        public string DeleteDnclistsDnclistId (string dncListId)
        {
             ApiResponse<string> response = DeleteDnclistsDnclistIdWithHttpInfo(dncListId);
             return response.Data;
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDnclistsDnclistIdWithHttpInfo (string dncListId)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteDnclistsDnclistId");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDnclistsDnclistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDnclistsDnclistId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteDnclistsDnclistIdAsync (string dncListId)
        {
             ApiResponse<string> response = await DeleteDnclistsDnclistIdAsyncWithHttpInfo(dncListId);
             return response.Data;

        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDnclistsDnclistIdAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling DeleteDnclistsDnclistId");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDnclistsDnclistId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDnclistsDnclistId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>string</returns>
        public string PostDnclistsDnclistIdExport (string dncListId)
        {
             ApiResponse<string> response = PostDnclistsDnclistIdExportWithHttpInfo(dncListId);
             return response.Data;
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostDnclistsDnclistIdExportWithHttpInfo (string dncListId)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistsDnclistIdExport");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/export";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdExport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdExport: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostDnclistsDnclistIdExportAsync (string dncListId)
        {
             ApiResponse<string> response = await PostDnclistsDnclistIdExportAsyncWithHttpInfo(dncListId);
             return response.Data;

        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostDnclistsDnclistIdExportAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling PostDnclistsDnclistIdExport");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/export";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdExport: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdExport: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ImportStatus</returns>
        public ImportStatus GetDnclistsDnclistIdImportstatus (string dncListId)
        {
             ApiResponse<ImportStatus> response = GetDnclistsDnclistIdImportstatusWithHttpInfo(dncListId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetDnclistsDnclistIdImportstatusWithHttpInfo (string dncListId)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistIdImportstatus");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/importstatus";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ImportStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(response, typeof(ImportStatus)));
            
        }
    
        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> GetDnclistsDnclistIdImportstatusAsync (string dncListId)
        {
             ApiResponse<ImportStatus> response = await GetDnclistsDnclistIdImportstatusAsyncWithHttpInfo(dncListId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetDnclistsDnclistIdImportstatusAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling GetDnclistsDnclistIdImportstatus");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/importstatus";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + response.ErrorMessage, response.ErrorMessage);

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
        public void PostDnclistsDnclistIdPhonenumbers (string dncListId, List<string> body = null)
        {
             PostDnclistsDnclistIdPhonenumbersWithHttpInfo(dncListId, body);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param> 
        /// <param name="body">DNC Phone Numbers</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostDnclistsDnclistIdPhonenumbersWithHttpInfo (string dncListId, List<string> body = null)
        {
            
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistsDnclistIdPhonenumbers");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/phonenumbers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (dncListId != null) pathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PostDnclistsDnclistIdPhonenumbersAsync (string dncListId, List<string> body = null)
        {
             await PostDnclistsDnclistIdPhonenumbersAsyncWithHttpInfo(dncListId, body);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostDnclistsDnclistIdPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null) throw new ApiException(400, "Missing required parameter 'dncListId' when calling PostDnclistsDnclistIdPhonenumbers");
            
    
            var path_ = "/api/v1/outbound/dnclists/{dncListId}/phonenumbers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>List&lt;Preview&gt;</returns>
        public List<Preview> GetPreviews ()
        {
             ApiResponse<List<Preview>> response = GetPreviewsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>ApiResponse of List&lt;Preview&gt;</returns>
        public ApiResponse< List<Preview> > GetPreviewsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/previews";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetPreviews: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPreviews: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Preview>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Preview>) Configuration.ApiClient.Deserialize(response, typeof(List<Preview>)));
            
        }
    
        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>Task of List&lt;Preview&gt;</returns>
        public async System.Threading.Tasks.Task<List<Preview>> GetPreviewsAsync ()
        {
             ApiResponse<List<Preview>> response = await GetPreviewsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;Preview&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Preview>>> GetPreviewsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/previews";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetPreviews: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPreviews: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Preview>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Preview>) Configuration.ApiClient.Deserialize(response, typeof(List<Preview>)));
            
        }
        
        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <returns>Preview</returns>
        public Preview GetPreviewsPreviewId (string previewId)
        {
             ApiResponse<Preview> response = GetPreviewsPreviewIdWithHttpInfo(previewId);
             return response.Data;
        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <returns>ApiResponse of Preview</returns>
        public ApiResponse< Preview > GetPreviewsPreviewIdWithHttpInfo (string previewId)
        {
            
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->GetPreviewsPreviewId");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetPreviewsPreviewId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPreviewsPreviewId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Preview>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Preview) Configuration.ApiClient.Deserialize(response, typeof(Preview)));
            
        }
    
        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of Preview</returns>
        public async System.Threading.Tasks.Task<Preview> GetPreviewsPreviewIdAsync (string previewId)
        {
             ApiResponse<Preview> response = await GetPreviewsPreviewIdAsyncWithHttpInfo(previewId);
             return response.Data;

        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of ApiResponse (Preview)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Preview>> GetPreviewsPreviewIdAsyncWithHttpInfo (string previewId)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling GetPreviewsPreviewId");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetPreviewsPreviewId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPreviewsPreviewId: " + response.ErrorMessage, response.ErrorMessage);

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
        public string PostPreviewsPreviewIdDispositioncall (string previewId, DialerDispositionCallCommand body = null)
        {
             ApiResponse<string> response = PostPreviewsPreviewIdDispositioncallWithHttpInfo(previewId, body);
             return response.Data;
        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostPreviewsPreviewIdDispositioncallWithHttpInfo (string previewId, DialerDispositionCallCommand body = null)
        {
            
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->PostPreviewsPreviewIdDispositioncall");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/dispositioncall";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdDispositioncall: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdDispositioncall: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> PostPreviewsPreviewIdDispositioncallAsync (string previewId, DialerDispositionCallCommand body = null)
        {
             ApiResponse<string> response = await PostPreviewsPreviewIdDispositioncallAsyncWithHttpInfo(previewId, body);
             return response.Data;

        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostPreviewsPreviewIdDispositioncallAsyncWithHttpInfo (string previewId, DialerDispositionCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling PostPreviewsPreviewIdDispositioncall");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/dispositioncall";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdDispositioncall: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdDispositioncall: " + response.ErrorMessage, response.ErrorMessage);

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
        public DialerCall PostPreviewsPreviewIdPlacecall (string previewId, DialerPlaceCallCommand body = null)
        {
             ApiResponse<DialerCall> response = PostPreviewsPreviewIdPlacecallWithHttpInfo(previewId, body);
             return response.Data;
        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DialerCall</returns>
        public ApiResponse< DialerCall > PostPreviewsPreviewIdPlacecallWithHttpInfo (string previewId, DialerPlaceCallCommand body = null)
        {
            
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->PostPreviewsPreviewIdPlacecall");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/placecall";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (previewId != null) pathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdPlacecall: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdPlacecall: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<DialerCall> PostPreviewsPreviewIdPlacecallAsync (string previewId, DialerPlaceCallCommand body = null)
        {
             ApiResponse<DialerCall> response = await PostPreviewsPreviewIdPlacecallAsyncWithHttpInfo(previewId, body);
             return response.Data;

        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DialerCall)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerCall>> PostPreviewsPreviewIdPlacecallAsyncWithHttpInfo (string previewId, DialerPlaceCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null) throw new ApiException(400, "Missing required parameter 'previewId' when calling PostPreviewsPreviewIdPlacecall");
            
    
            var path_ = "/api/v1/outbound/previews/{previewId}/placecall";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdPlacecall: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPreviewsPreviewIdPlacecall: " + response.ErrorMessage, response.ErrorMessage);

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
        public RuleSetEntityListing GetRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> response = GetRulesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< RuleSetEntityListing > GetRulesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRulesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRulesets: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<RuleSetEntityListing> GetRulesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> response = await GetRulesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> GetRulesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRulesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRulesets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(RuleSetEntityListing)));
            
        }
        
        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param> 
        /// <returns>RuleSet</returns>
        public RuleSet PostRulesets (RuleSet body = null)
        {
             ApiResponse<RuleSet> response = PostRulesetsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param> 
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PostRulesetsWithHttpInfo (RuleSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostRulesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRulesets: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
    
        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> PostRulesetsAsync (RuleSet body = null)
        {
             ApiResponse<RuleSet> response = await PostRulesetsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PostRulesetsAsyncWithHttpInfo (RuleSet body = null)
        {
            
    
            var path_ = "/api/v1/outbound/rulesets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostRulesets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRulesets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
        
        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>RuleSet</returns>
        public RuleSet GetRulesetsRulesetId (string ruleSetId)
        {
             ApiResponse<RuleSet> response = GetRulesetsRulesetIdWithHttpInfo(ruleSetId);
             return response.Data;
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > GetRulesetsRulesetIdWithHttpInfo (string ruleSetId)
        {
            
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetRulesetsRulesetId");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRulesetsRulesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRulesetsRulesetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
    
        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> GetRulesetsRulesetIdAsync (string ruleSetId)
        {
             ApiResponse<RuleSet> response = await GetRulesetsRulesetIdAsyncWithHttpInfo(ruleSetId);
             return response.Data;

        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling GetRulesetsRulesetId");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRulesetsRulesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRulesetsRulesetId: " + response.ErrorMessage, response.ErrorMessage);

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
        public RuleSet PutRulesetsRulesetId (string ruleSetId, RuleSet body = null)
        {
             ApiResponse<RuleSet> response = PutRulesetsRulesetIdWithHttpInfo(ruleSetId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <param name="body">RuleSet</param> 
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PutRulesetsRulesetIdWithHttpInfo (string ruleSetId, RuleSet body = null)
        {
            
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutRulesetsRulesetId");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (ruleSetId != null) pathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutRulesetsRulesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRulesetsRulesetId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<RuleSet> PutRulesetsRulesetIdAsync (string ruleSetId, RuleSet body = null)
        {
             ApiResponse<RuleSet> response = await PutRulesetsRulesetIdAsyncWithHttpInfo(ruleSetId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId, RuleSet body = null)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling PutRulesetsRulesetId");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutRulesetsRulesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRulesetsRulesetId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RuleSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(response, typeof(RuleSet)));
            
        }
        
        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>string</returns>
        public string DeleteRulesetsRulesetId (string ruleSetId)
        {
             ApiResponse<string> response = DeleteRulesetsRulesetIdWithHttpInfo(ruleSetId);
             return response.Data;
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRulesetsRulesetIdWithHttpInfo (string ruleSetId)
        {
            
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteRulesetsRulesetId");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRulesetsRulesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRulesetsRulesetId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRulesetsRulesetIdAsync (string ruleSetId)
        {
             ApiResponse<string> response = await DeleteRulesetsRulesetIdAsyncWithHttpInfo(ruleSetId);
             return response.Data;

        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null) throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling DeleteRulesetsRulesetId");
            
    
            var path_ = "/api/v1/outbound/rulesets/{ruleSetId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRulesetsRulesetId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRulesetsRulesetId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        public List<CampaignSchedule> GetSchedulesCampaigns ()
        {
             ApiResponse<List<CampaignSchedule>> response = GetSchedulesCampaignsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        public ApiResponse< List<CampaignSchedule> > GetSchedulesCampaignsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaigns: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaigns: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<CampaignSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<CampaignSchedule>)));
            
        }
    
        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignSchedule>> GetSchedulesCampaignsAsync ()
        {
             ApiResponse<List<CampaignSchedule>> response = await GetSchedulesCampaignsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> GetSchedulesCampaignsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaigns: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaigns: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<CampaignSchedule>)));
            
        }
        
        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule GetSchedulesCampaignsCampaignId (string campaignId)
        {
             ApiResponse<CampaignSchedule> response = GetSchedulesCampaignsCampaignIdWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > GetSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetSchedulesCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(response, typeof(CampaignSchedule)));
            
        }
    
        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> GetSchedulesCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<CampaignSchedule> response = await GetSchedulesCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling GetSchedulesCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);

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
        public CampaignSchedule PutSchedulesCampaignsCampaignId (string campaignId, CampaignSchedule body = null)
        {
             ApiResponse<CampaignSchedule> response = PutSchedulesCampaignsCampaignIdWithHttpInfo(campaignId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <param name="body">CampaignSchedule</param> 
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > PutSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId, CampaignSchedule body = null)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutSchedulesCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (campaignId != null) pathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSchedulesCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulesCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CampaignSchedule> PutSchedulesCampaignsCampaignIdAsync (string campaignId, CampaignSchedule body = null)
        {
             ApiResponse<CampaignSchedule> response = await PutSchedulesCampaignsCampaignIdAsyncWithHttpInfo(campaignId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, CampaignSchedule body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling PutSchedulesCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutSchedulesCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulesCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(response, typeof(CampaignSchedule)));
            
        }
        
        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulesCampaignsCampaignId (string campaignId)
        {
             ApiResponse<string> response = DeleteSchedulesCampaignsCampaignIdWithHttpInfo(campaignId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteSchedulesCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulesCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<string> response = await DeleteSchedulesCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null) throw new ApiException(400, "Missing required parameter 'campaignId' when calling DeleteSchedulesCampaignsCampaignId");
            
    
            var path_ = "/api/v1/outbound/schedules/campaigns/{campaignId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        public List<SequenceSchedule> GetSchedulesSequences ()
        {
             ApiResponse<List<SequenceSchedule>> response = GetSchedulesSequencesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        public ApiResponse< List<SequenceSchedule> > GetSchedulesSequencesWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/sequences";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetSchedulesSequences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesSequences: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<SequenceSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<SequenceSchedule>)));
            
        }
    
        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<SequenceSchedule>> GetSchedulesSequencesAsync ()
        {
             ApiResponse<List<SequenceSchedule>> response = await GetSchedulesSequencesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> GetSchedulesSequencesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/schedules/sequences";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetSchedulesSequences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesSequences: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(response, typeof(List<SequenceSchedule>)));
            
        }
        
        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule GetSchedulesSequencesSequenceId (string sequenceId)
        {
             ApiResponse<SequenceSchedule> response = GetSchedulesSequencesSequenceIdWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > GetSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSchedulesSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchedulesSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SequenceSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(response, typeof(SequenceSchedule)));
            
        }
    
        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> GetSchedulesSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<SequenceSchedule> response = await GetSchedulesSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling GetSchedulesSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSchedulesSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public SequenceSchedule PutSchedulesSequencesSequenceId (string sequenceId, SequenceSchedule body = null)
        {
             ApiResponse<SequenceSchedule> response = PutSchedulesSequencesSequenceIdWithHttpInfo(sequenceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <param name="body">SequenceSchedule</param> 
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > PutSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId, SequenceSchedule body = null)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSchedulesSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSchedulesSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulesSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SequenceSchedule> PutSchedulesSequencesSequenceIdAsync (string sequenceId, SequenceSchedule body = null)
        {
             ApiResponse<SequenceSchedule> response = await PutSchedulesSequencesSequenceIdAsyncWithHttpInfo(sequenceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, SequenceSchedule body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling PutSchedulesSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutSchedulesSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulesSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(response, typeof(SequenceSchedule)));
            
        }
        
        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulesSequencesSequenceId (string sequenceId)
        {
             ApiResponse<string> response = DeleteSchedulesSequencesSequenceIdWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSchedulesSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulesSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<string> response = await DeleteSchedulesSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling DeleteSchedulesSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/schedules/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public CampaignSequenceEntityListing GetSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> response = GetSequencesWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< CampaignSequenceEntityListing > GetSequencesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSequences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSequences: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CampaignSequenceEntityListing> GetSequencesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> response = await GetSequencesAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> GetSequencesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSequences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSequences: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequenceEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>CampaignSequence</returns>
        public CampaignSequence PostSequences (CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = PostSequencesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PostSequencesWithHttpInfo (CampaignSequence body = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostSequences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSequences: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
    
        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> PostSequencesAsync (CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = await PostSequencesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PostSequencesAsyncWithHttpInfo (CampaignSequence body = null)
        {
            
    
            var path_ = "/api/v1/outbound/sequences";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PostSequences: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSequences: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
        
        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>CampaignSequence</returns>
        public CampaignSequence GetSequencesSequenceId (string sequenceId)
        {
             ApiResponse<CampaignSequence> response = GetSequencesSequenceIdWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > GetSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
    
        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> GetSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<CampaignSequence> response = await GetSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling GetSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);

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
        public CampaignSequence PutSequencesSequenceId (string sequenceId, CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = PutSequencesSequenceIdWithHttpInfo(sequenceId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PutSequencesSequenceIdWithHttpInfo (string sequenceId, CampaignSequence body = null)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (sequenceId != null) pathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<CampaignSequence> PutSequencesSequenceIdAsync (string sequenceId, CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> response = await PutSequencesSequenceIdAsyncWithHttpInfo(sequenceId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, CampaignSequence body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling PutSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CampaignSequence>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(response, typeof(CampaignSequence)));
            
        }
        
        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>string</returns>
        public string DeleteSequencesSequenceId (string sequenceId)
        {
             ApiResponse<string> response = DeleteSequencesSequenceIdWithHttpInfo(sequenceId);
             return response.Data;
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<string> response = await DeleteSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return response.Data;

        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null) throw new ApiException(400, "Missing required parameter 'sequenceId' when calling DeleteSequencesSequenceId");
            
    
            var path_ = "/api/v1/outbound/sequences/{sequenceId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSequencesSequenceId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSequencesSequenceId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping GetWrapupcodemappings ()
        {
             ApiResponse<WrapUpCodeMapping> response = GetWrapupcodemappingsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > GetWrapupcodemappingsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetWrapupcodemappings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWrapupcodemappings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
    
        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> GetWrapupcodemappingsAsync ()
        {
             ApiResponse<WrapUpCodeMapping> response = await GetWrapupcodemappingsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> GetWrapupcodemappingsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling GetWrapupcodemappings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetWrapupcodemappings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
        
        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param> 
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping PutWrapupcodemappings (WrapUpCodeMapping body = null)
        {
             ApiResponse<WrapUpCodeMapping> response = PutWrapupcodemappingsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param> 
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > PutWrapupcodemappingsWithHttpInfo (WrapUpCodeMapping body = null)
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PutWrapupcodemappings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWrapupcodemappings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
    
        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> PutWrapupcodemappingsAsync (WrapUpCodeMapping body = null)
        {
             ApiResponse<WrapUpCodeMapping> response = await PutWrapupcodemappingsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> PutWrapupcodemappingsAsyncWithHttpInfo (WrapUpCodeMapping body = null)
        {
            
    
            var path_ = "/api/v1/outbound/wrapupcodemappings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (statusCode, "Error calling PutWrapupcodemappings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutWrapupcodemappings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(response, typeof(WrapUpCodeMapping)));
            
        }
        
    }
    
}
