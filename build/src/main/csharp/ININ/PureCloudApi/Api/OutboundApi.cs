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
    public interface IOutboundApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>AuditSearchResult</returns>
        AuditSearchResult OutboundAuditsPost (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        ApiResponse<AuditSearchResult> OutboundAuditsPostWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        string OutboundCallabletimesetsCallabletimesetidDelete (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCallabletimesetsCallabletimesetidDeleteWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet OutboundCallabletimesetsCallabletimesetidGet (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidGetWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet OutboundCallabletimesetsCallabletimesetidPut (string callableTimeSetId, CallableTimeSet body = null);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidPutWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null);
        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CallableTimeSetEntityListing</returns>
        CallableTimeSetEntityListing OutboundCallabletimesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CallableTimeSetEntityListing</returns>
        ApiResponse<CallableTimeSetEntityListing> OutboundCallabletimesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet OutboundCallabletimesetsPost (CallableTimeSet body = null);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> OutboundCallabletimesetsPostWithHttpInfo (CallableTimeSet body = null);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        string OutboundCallanalysisresponsesetsCallanalysissetidDelete (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCallanalysisresponsesetsCallanalysissetidDeleteWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidGet (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidGetWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ResponseSet</returns>
        ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidPut (string callAnalysisSetId, ResponseSet body = null);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidPutWithHttpInfo (string callAnalysisSetId, ResponseSet body = null);
        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ResponseSetEntityListing</returns>
        ResponseSetEntityListing OutboundCallanalysisresponsesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ResponseSetEntityListing</returns>
        ApiResponse<ResponseSetEntityListing> OutboundCallanalysisresponsesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ResponseSet</returns>
        ResponseSet OutboundCallanalysisresponsesetsPost (ResponseSet body = null);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> OutboundCallanalysisresponsesetsPostWithHttpInfo (ResponseSet body = null);
        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>string</returns>
        string OutboundCampaignsCampaignidAgentsUseridPut (string campaignId, string userId, Agent body = null);

        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCampaignsCampaignidAgentsUseridPutWithHttpInfo (string campaignId, string userId, Agent body = null);
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>ContactCallbackRequest</returns>
        ContactCallbackRequest OutboundCampaignsCampaignidCallbackSchedulePost (string campaignId, ContactCallbackRequest body = null);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        ApiResponse<ContactCallbackRequest> OutboundCampaignsCampaignidCallbackSchedulePostWithHttpInfo (string campaignId, ContactCallbackRequest body = null);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string OutboundCampaignsCampaignidDelete (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundCampaignsCampaignidDeleteWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        CampaignDiagnostics OutboundCampaignsCampaignidDiagnosticsGet (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        ApiResponse<CampaignDiagnostics> OutboundCampaignsCampaignidDiagnosticsGetWithHttpInfo (string campaignId);
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign OutboundCampaignsCampaignidGet (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> OutboundCampaignsCampaignidGetWithHttpInfo (string campaignId);
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Campaign</returns>
        Campaign OutboundCampaignsCampaignidPut (string campaignId, Campaign body = null);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> OutboundCampaignsCampaignidPutWithHttpInfo (string campaignId, Campaign body = null);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        CampaignStats OutboundCampaignsCampaignidStatsGet (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        ApiResponse<CampaignStats> OutboundCampaignsCampaignidStatsGetWithHttpInfo (string campaignId);
        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignEntityListing</returns>
        CampaignEntityListing OutboundCampaignsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignEntityListing</returns>
        ApiResponse<CampaignEntityListing> OutboundCampaignsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Campaign</returns>
        Campaign OutboundCampaignsPost (Campaign body = null);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> OutboundCampaignsPostWithHttpInfo (Campaign body = null);
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of PenetrationRate</returns>
        ApiResponse<PenetrationRate> OutboundContactlistsContactlistidCampaignidPenetrationrateGetWithHttpInfo (string contactListId, string campaignId);
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundContactlistsContactlistidContactsContactidDeleteWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> OutboundContactlistsContactlistidContactsContactidGetWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>Contact</returns>
        Contact OutboundContactlistsContactlistidContactsContactidPut (string contactListId, string contactId, Contact body = null);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> OutboundContactlistsContactlistidContactsContactidPutWithHttpInfo (string contactListId, string contactId, Contact body = null);
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>Contact</returns>
        Contact OutboundContactlistsContactlistidContactsPost (string contactListId, List<Contact> body = null, bool? priority = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>ApiResponse of Contact</returns>
        ApiResponse<Contact> OutboundContactlistsContactlistidContactsPostWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string OutboundContactlistsContactlistidDelete (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundContactlistsContactlistidDeleteWithHttpInfo (string contactListId);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string OutboundContactlistsContactlistidExportPost (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundContactlistsContactlistidExportPostWithHttpInfo (string contactListId);
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        ContactList OutboundContactlistsContactlistidGet (string contactListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> OutboundContactlistsContactlistidGetWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus OutboundContactlistsContactlistidImportstatusGet (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> OutboundContactlistsContactlistidImportstatusGetWithHttpInfo (string contactListId);
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ContactList</returns>
        ContactList OutboundContactlistsContactlistidPut (string contactListId, ContactList body = null);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> OutboundContactlistsContactlistidPutWithHttpInfo (string contactListId, ContactList body = null);
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ContactListEntityListing</returns>
        ContactListEntityListing OutboundContactlistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        ApiResponse<ContactListEntityListing> OutboundContactlistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>List&lt;PenetrationRate&gt;</returns>
        List<PenetrationRate> OutboundContactlistsPenetrationratesPost (List<PenetrationRateId> body = null);

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>ApiResponse of List&lt;PenetrationRate&gt;</returns>
        ApiResponse<List<PenetrationRate>> OutboundContactlistsPenetrationratesPostWithHttpInfo (List<PenetrationRateId> body = null);
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ContactList</returns>
        ContactList OutboundContactlistsPost (ContactList body = null);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> OutboundContactlistsPostWithHttpInfo (ContactList body = null);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        void OutboundConversationsConversationidDncPost (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OutboundConversationsConversationidDncPostWithHttpInfo (string conversationId);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string OutboundDnclistsDnclistidDelete (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundDnclistsDnclistidDeleteWithHttpInfo (string dncListId);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string OutboundDnclistsDnclistidExportPost (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundDnclistsDnclistidExportPostWithHttpInfo (string dncListId);
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        DncList OutboundDnclistsDnclistidGet (string dncListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> OutboundDnclistsDnclistidGetWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus OutboundDnclistsDnclistidImportstatusGet (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> OutboundDnclistsDnclistidImportstatusGetWithHttpInfo (string dncListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns></returns>
        void OutboundDnclistsDnclistidPhonenumbersPost (string dncListId, List<string> body = null);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> OutboundDnclistsDnclistidPhonenumbersPostWithHttpInfo (string dncListId, List<string> body = null);
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>DncList</returns>
        DncList OutboundDnclistsDnclistidPut (string dncListId, DncList body = null);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> OutboundDnclistsDnclistidPutWithHttpInfo (string dncListId, DncList body = null);
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>DncListEntityListing</returns>
        DncListEntityListing OutboundDnclistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        ApiResponse<DncListEntityListing> OutboundDnclistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>DncList</returns>
        DncList OutboundDnclistsPost (DncList body = null);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> OutboundDnclistsPostWithHttpInfo (DncList body = null);
        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Preview&gt;</returns>
        List<Preview> OutboundPreviewsGet ();

        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Preview&gt;</returns>
        ApiResponse<List<Preview>> OutboundPreviewsGetWithHttpInfo ();
        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>string</returns>
        string OutboundPreviewsPreviewidDispositioncallPost (string previewId, DialerDispositionCallCommand body = null);

        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundPreviewsPreviewidDispositioncallPostWithHttpInfo (string previewId, DialerDispositionCallCommand body = null);
        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>Preview</returns>
        Preview OutboundPreviewsPreviewidGet (string previewId);

        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>ApiResponse of Preview</returns>
        ApiResponse<Preview> OutboundPreviewsPreviewidGetWithHttpInfo (string previewId);
        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DialerCall</returns>
        DialerCall OutboundPreviewsPreviewidPlacecallPost (string previewId, DialerPlaceCallCommand body = null);

        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DialerCall</returns>
        ApiResponse<DialerCall> OutboundPreviewsPreviewidPlacecallPostWithHttpInfo (string previewId, DialerPlaceCallCommand body = null);
        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>RuleSetEntityListing</returns>
        RuleSetEntityListing OutboundRulesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of RuleSetEntityListing</returns>
        ApiResponse<RuleSetEntityListing> OutboundRulesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>RuleSet</returns>
        RuleSet OutboundRulesetsPost (RuleSet body = null);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> OutboundRulesetsPostWithHttpInfo (RuleSet body = null);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        string OutboundRulesetsRulesetidDelete (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundRulesetsRulesetidDeleteWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        RuleSet OutboundRulesetsRulesetidGet (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> OutboundRulesetsRulesetidGetWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>RuleSet</returns>
        RuleSet OutboundRulesetsRulesetidPut (string ruleSetId, RuleSet body = null);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> OutboundRulesetsRulesetidPutWithHttpInfo (string ruleSetId, RuleSet body = null);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string OutboundSchedulesCampaignsCampaignidDelete (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundSchedulesCampaignsCampaignidDeleteWithHttpInfo (string campaignId);
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule OutboundSchedulesCampaignsCampaignidGet (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> OutboundSchedulesCampaignsCampaignidGetWithHttpInfo (string campaignId);
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule OutboundSchedulesCampaignsCampaignidPut (string campaignId, CampaignSchedule body = null);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> OutboundSchedulesCampaignsCampaignidPutWithHttpInfo (string campaignId, CampaignSchedule body = null);
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        List<CampaignSchedule> OutboundSchedulesCampaignsGet ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        ApiResponse<List<CampaignSchedule>> OutboundSchedulesCampaignsGetWithHttpInfo ();
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        List<SequenceSchedule> OutboundSchedulesSequencesGet ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        ApiResponse<List<SequenceSchedule>> OutboundSchedulesSequencesGetWithHttpInfo ();
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        string OutboundSchedulesSequencesSequenceidDelete (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundSchedulesSequencesSequenceidDeleteWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule OutboundSchedulesSequencesSequenceidGet (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> OutboundSchedulesSequencesSequenceidGetWithHttpInfo (string sequenceId);
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule OutboundSchedulesSequencesSequenceidPut (string sequenceId, SequenceSchedule body = null);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> OutboundSchedulesSequencesSequenceidPutWithHttpInfo (string sequenceId, SequenceSchedule body = null);
        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignSequenceEntityListing</returns>
        CampaignSequenceEntityListing OutboundSequencesGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignSequenceEntityListing</returns>
        ApiResponse<CampaignSequenceEntityListing> OutboundSequencesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence OutboundSequencesPost (CampaignSequence body = null);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> OutboundSequencesPostWithHttpInfo (CampaignSequence body = null);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        string OutboundSequencesSequenceidDelete (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> OutboundSequencesSequenceidDeleteWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence OutboundSequencesSequenceidGet (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> OutboundSequencesSequenceidGetWithHttpInfo (string sequenceId);
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence OutboundSequencesSequenceidPut (string sequenceId, CampaignSequence body = null);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> OutboundSequencesSequenceidPutWithHttpInfo (string sequenceId, CampaignSequence body = null);
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping OutboundWrapupcodemappingsGet ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> OutboundWrapupcodemappingsGetWithHttpInfo ();
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping OutboundWrapupcodemappingsPut (WrapUpCodeMapping body = null);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> OutboundWrapupcodemappingsPutWithHttpInfo (WrapUpCodeMapping body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of AuditSearchResult</returns>
        System.Threading.Tasks.Task<AuditSearchResult> OutboundAuditsPostAsync (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> OutboundAuditsPostAsyncWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCallabletimesetsCallabletimesetidDeleteAsync (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallabletimesetsCallabletimesetidDeleteAsyncWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidGetAsync (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidGetAsyncWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidPutAsync (string callableTimeSetId, CallableTimeSet body = null);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidPutAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null);
        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CallableTimeSetEntityListing</returns>
        System.Threading.Tasks.Task<CallableTimeSetEntityListing> OutboundCallabletimesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query callable time set list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CallableTimeSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> OutboundCallabletimesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsPostAsync (CallableTimeSet body = null);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsPostAsyncWithHttpInfo (CallableTimeSet body = null);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsync (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsyncWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidGetAsync (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidGetAsyncWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidPutAsync (string callAnalysisSetId, ResponseSet body = null);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidPutAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body = null);
        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ResponseSetEntityListing</returns>
        System.Threading.Tasks.Task<ResponseSetEntityListing> OutboundCallanalysisresponsesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer call analysis response sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ResponseSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> OutboundCallanalysisresponsesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsPostAsync (ResponseSet body = null);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsPostAsyncWithHttpInfo (ResponseSet body = null);
        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidAgentsUseridPutAsync (string campaignId, string userId, Agent body = null);

        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidAgentsUseridPutAsyncWithHttpInfo (string campaignId, string userId, Agent body = null);
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        System.Threading.Tasks.Task<ContactCallbackRequest> OutboundCampaignsCampaignidCallbackSchedulePostAsync (string campaignId, ContactCallbackRequest body = null);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> OutboundCampaignsCampaignidCallbackSchedulePostAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body = null);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidDeleteAsync (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        System.Threading.Tasks.Task<CampaignDiagnostics> OutboundCampaignsCampaignidDiagnosticsGetAsync (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> OutboundCampaignsCampaignidDiagnosticsGetAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidGetAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidPutAsync (string campaignId, Campaign body = null);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, Campaign body = null);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        System.Threading.Tasks.Task<CampaignStats> OutboundCampaignsCampaignidStatsGetAsync (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignStats>> OutboundCampaignsCampaignidStatsGetAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignEntityListing</returns>
        System.Threading.Tasks.Task<CampaignEntityListing> OutboundCampaignsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaigns.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> OutboundCampaignsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> OutboundCampaignsPostAsync (Campaign body = null);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsPostAsyncWithHttpInfo (Campaign body = null);
        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate
        /// </summary>
        /// <remarks>
        /// Get dialer campaign&#39;s penetration rate.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (PenetrationRate)</returns>
        System.Threading.Tasks.Task<ApiResponse<PenetrationRate>> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsyncWithHttpInfo (string contactListId, string campaignId);
        /// <summary>
        /// Delete a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidContactsContactidDeleteAsyncWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidPutAsync (string contactListId, string contactId, Contact body = null);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidPutAsyncWithHttpInfo (string contactListId, string contactId, Contact body = null);
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>Task of Contact</returns>
        System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsPostAsync (string contactListId, List<Contact> body = null, bool? priority = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsPostAsyncWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidDeleteAsync (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidDeleteAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidExportPostAsync (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidExportPostAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidGetAsync (string contactListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer contactList.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidGetAsyncWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> OutboundContactlistsContactlistidImportstatusGetAsync (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundContactlistsContactlistidImportstatusGetAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidPutAsync (string contactListId, ContactList body = null);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidPutAsyncWithHttpInfo (string contactListId, ContactList body = null);
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ContactListEntityListing</returns>
        System.Threading.Tasks.Task<ContactListEntityListing> OutboundContactlistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> OutboundContactlistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>Task of List&lt;PenetrationRate&gt;</returns>
        System.Threading.Tasks.Task<List<PenetrationRate>> OutboundContactlistsPenetrationratesPostAsync (List<PenetrationRateId> body = null);

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PenetrationRate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PenetrationRate>>> OutboundContactlistsPenetrationratesPostAsyncWithHttpInfo (List<PenetrationRateId> body = null);
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> OutboundContactlistsPostAsync (ContactList body = null);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsPostAsyncWithHttpInfo (ContactList body = null);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OutboundConversationsConversationidDncPostAsync (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OutboundConversationsConversationidDncPostAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidDeleteAsync (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidDeleteAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidExportPostAsync (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidExportPostAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidGetAsync (string dncListId, bool? importStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidGetAsyncWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> OutboundDnclistsDnclistidImportstatusGetAsync (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundDnclistsDnclistidImportstatusGetAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task OutboundDnclistsDnclistidPhonenumbersPostAsync (string dncListId, List<string> body = null);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> OutboundDnclistsDnclistidPhonenumbersPostAsyncWithHttpInfo (string dncListId, List<string> body = null);
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidPutAsync (string dncListId, DncList body = null);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidPutAsyncWithHttpInfo (string dncListId, DncList body = null);
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of DncListEntityListing</returns>
        System.Threading.Tasks.Task<DncListEntityListing> OutboundDnclistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> OutboundDnclistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> OutboundDnclistsPostAsync (DncList body = null);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsPostAsyncWithHttpInfo (DncList body = null);
        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Preview&gt;</returns>
        System.Threading.Tasks.Task<List<Preview>> OutboundPreviewsGetAsync ();

        /// <summary>
        /// Get dialer preview for user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Preview&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Preview>>> OutboundPreviewsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundPreviewsPreviewidDispositioncallPostAsync (string previewId, DialerDispositionCallCommand body = null);

        /// <summary>
        /// Disposition preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundPreviewsPreviewidDispositioncallPostAsyncWithHttpInfo (string previewId, DialerDispositionCallCommand body = null);
        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of Preview</returns>
        System.Threading.Tasks.Task<Preview> OutboundPreviewsPreviewidGetAsync (string previewId);

        /// <summary>
        /// Get dialer preview
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of ApiResponse (Preview)</returns>
        System.Threading.Tasks.Task<ApiResponse<Preview>> OutboundPreviewsPreviewidGetAsyncWithHttpInfo (string previewId);
        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DialerCall</returns>
        System.Threading.Tasks.Task<DialerCall> OutboundPreviewsPreviewidPlacecallPostAsync (string previewId, DialerPlaceCallCommand body = null);

        /// <summary>
        /// place preview call
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DialerCall)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerCall>> OutboundPreviewsPreviewidPlacecallPostAsyncWithHttpInfo (string previewId, DialerPlaceCallCommand body = null);
        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of RuleSetEntityListing</returns>
        System.Threading.Tasks.Task<RuleSetEntityListing> OutboundRulesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of Rule Sets.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (RuleSetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> OutboundRulesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> OutboundRulesetsPostAsync (RuleSet body = null);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsPostAsyncWithHttpInfo (RuleSet body = null);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundRulesetsRulesetidDeleteAsync (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundRulesetsRulesetidDeleteAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidGetAsync (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidGetAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidPutAsync (string ruleSetId, RuleSet body = null);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidPutAsyncWithHttpInfo (string ruleSetId, RuleSet body = null);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundSchedulesCampaignsCampaignidDeleteAsync (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidGetAsync (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidPutAsync (string campaignId, CampaignSchedule body = null);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, CampaignSchedule body = null);
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignSchedule>> OutboundSchedulesCampaignsGetAsync ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> OutboundSchedulesCampaignsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<SequenceSchedule>> OutboundSchedulesSequencesGetAsync ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> OutboundSchedulesSequencesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundSchedulesSequencesSequenceidDeleteAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidGetAsync (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidPutAsync (string sequenceId, SequenceSchedule body = null);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, SequenceSchedule body = null);
        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignSequenceEntityListing</returns>
        System.Threading.Tasks.Task<CampaignSequenceEntityListing> OutboundSequencesGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of dialer campaign sequences.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignSequenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> OutboundSequencesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesPostAsync (CampaignSequence body = null);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesPostAsyncWithHttpInfo (CampaignSequence body = null);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> OutboundSequencesSequenceidDeleteAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> OutboundSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidGetAsync (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidPutAsync (string sequenceId, CampaignSequence body = null);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, CampaignSequence body = null);
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsGetAsync ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsPutAsync (WrapUpCodeMapping body = null);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsPutAsyncWithHttpInfo (WrapUpCodeMapping body = null);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>AuditSearchResult</returns>
        public AuditSearchResult OutboundAuditsPost (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = OutboundAuditsPostWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        public ApiResponse< AuditSearchResult > OutboundAuditsPostWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {

            var localVarPath = "/api/v1/outbound/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (facetsOnly != null) localVarQueryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundAuditsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundAuditsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of AuditSearchResult</returns>
        public async System.Threading.Tasks.Task<AuditSearchResult> OutboundAuditsPostAsync (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = await OutboundAuditsPostAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch (optional)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> OutboundAuditsPostAsyncWithHttpInfo (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {

            var localVarPath = "/api/v1/outbound/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (facetsOnly != null) localVarQueryParams.Add("facetsOnly", Configuration.ApiClient.ParameterToString(facetsOnly)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundAuditsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundAuditsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        public string OutboundCallabletimesetsCallabletimesetidDelete (string callableTimeSetId)
        {
             ApiResponse<string> localVarResponse = OutboundCallabletimesetsCallabletimesetidDeleteWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCallabletimesetsCallabletimesetidDeleteWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->OutboundCallabletimesetsCallabletimesetidDelete");

            var localVarPath = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCallabletimesetsCallabletimesetidDeleteAsync (string callableTimeSetId)
        {
             ApiResponse<string> localVarResponse = await OutboundCallabletimesetsCallabletimesetidDeleteAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallabletimesetsCallabletimesetidDeleteAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->OutboundCallabletimesetsCallabletimesetidDelete");

            var localVarPath = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet OutboundCallabletimesetsCallabletimesetidGet (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = OutboundCallabletimesetsCallabletimesetidGetWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > OutboundCallabletimesetsCallabletimesetidGetWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->OutboundCallabletimesetsCallabletimesetidGet");

            var localVarPath = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidGetAsync (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await OutboundCallabletimesetsCallabletimesetidGetAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidGetAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->OutboundCallabletimesetsCallabletimesetidGet");

            var localVarPath = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet OutboundCallabletimesetsCallabletimesetidPut (string callableTimeSetId, CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = OutboundCallabletimesetsCallabletimesetidPutWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > OutboundCallabletimesetsCallabletimesetidPutWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->OutboundCallabletimesetsCallabletimesetidPut");

            var localVarPath = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsCallabletimesetidPutAsync (string callableTimeSetId, CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await OutboundCallabletimesetsCallabletimesetidPutAsyncWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsCallabletimesetidPutAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body = null)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->OutboundCallabletimesetsCallabletimesetidPut");

            var localVarPath = "/api/v1/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callableTimeSetId != null) localVarPathParams.Add("callableTimeSetId", Configuration.ApiClient.ParameterToString(callableTimeSetId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsCallabletimesetidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CallableTimeSetEntityListing</returns>
        public CallableTimeSetEntityListing OutboundCallabletimesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> localVarResponse = OutboundCallabletimesetsGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CallableTimeSetEntityListing</returns>
        public ApiResponse< CallableTimeSetEntityListing > OutboundCallabletimesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSetEntityListing)));
            
        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CallableTimeSetEntityListing</returns>
        public async System.Threading.Tasks.Task<CallableTimeSetEntityListing> OutboundCallabletimesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> localVarResponse = await OutboundCallabletimesetsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query callable time set list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CallableTimeSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> OutboundCallabletimesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSetEntityListing)));
            
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet OutboundCallabletimesetsPost (CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = OutboundCallabletimesetsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > OutboundCallabletimesetsPostWithHttpInfo (CallableTimeSet body = null)
        {

            var localVarPath = "/api/v1/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> OutboundCallabletimesetsPostAsync (CallableTimeSet body = null)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await OutboundCallabletimesetsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet (optional)</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> OutboundCallabletimesetsPostAsyncWithHttpInfo (CallableTimeSet body = null)
        {

            var localVarPath = "/api/v1/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallabletimesetsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        public string OutboundCallanalysisresponsesetsCallanalysissetidDelete (string callAnalysisSetId)
        {
             ApiResponse<string> localVarResponse = OutboundCallanalysisresponsesetsCallanalysissetidDeleteWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCallanalysisresponsesetsCallanalysissetidDeleteWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->OutboundCallanalysisresponsesetsCallanalysissetidDelete");

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsync (string callAnalysisSetId)
        {
             ApiResponse<string> localVarResponse = await OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCallanalysisresponsesetsCallanalysissetidDeleteAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->OutboundCallanalysisresponsesetsCallanalysissetidDelete");

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidGet (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = OutboundCallanalysisresponsesetsCallanalysissetidGetWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > OutboundCallanalysisresponsesetsCallanalysissetidGetWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->OutboundCallanalysisresponsesetsCallanalysissetidGet");

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidGetAsync (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = await OutboundCallanalysisresponsesetsCallanalysissetidGetAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidGetAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->OutboundCallanalysisresponsesetsCallanalysissetidGet");

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet OutboundCallanalysisresponsesetsCallanalysissetidPut (string callAnalysisSetId, ResponseSet body = null)
        {
             ApiResponse<ResponseSet> localVarResponse = OutboundCallanalysisresponsesetsCallanalysissetidPutWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > OutboundCallanalysisresponsesetsCallanalysissetidPutWithHttpInfo (string callAnalysisSetId, ResponseSet body = null)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->OutboundCallanalysisresponsesetsCallanalysissetidPut");

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsCallanalysissetidPutAsync (string callAnalysisSetId, ResponseSet body = null)
        {
             ApiResponse<ResponseSet> localVarResponse = await OutboundCallanalysisresponsesetsCallanalysissetidPutAsyncWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsCallanalysissetidPutAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body = null)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->OutboundCallanalysisresponsesetsCallanalysissetidPut");

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callAnalysisSetId != null) localVarPathParams.Add("callAnalysisSetId", Configuration.ApiClient.ParameterToString(callAnalysisSetId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsCallanalysissetidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ResponseSetEntityListing</returns>
        public ResponseSetEntityListing OutboundCallanalysisresponsesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> localVarResponse = OutboundCallanalysisresponsesetsGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ResponseSetEntityListing</returns>
        public ApiResponse< ResponseSetEntityListing > OutboundCallanalysisresponsesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSetEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ResponseSetEntityListing</returns>
        public async System.Threading.Tasks.Task<ResponseSetEntityListing> OutboundCallanalysisresponsesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> localVarResponse = await OutboundCallanalysisresponsesetsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of dialer call analysis response sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ResponseSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> OutboundCallanalysisresponsesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSetEntityListing)));
            
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet OutboundCallanalysisresponsesetsPost (ResponseSet body = null)
        {
             ApiResponse<ResponseSet> localVarResponse = OutboundCallanalysisresponsesetsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > OutboundCallanalysisresponsesetsPostWithHttpInfo (ResponseSet body = null)
        {

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> OutboundCallanalysisresponsesetsPostAsync (ResponseSet body = null)
        {
             ApiResponse<ResponseSet> localVarResponse = await OutboundCallanalysisresponsesetsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet (optional)</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> OutboundCallanalysisresponsesetsPostAsyncWithHttpInfo (ResponseSet body = null)
        {

            var localVarPath = "/api/v1/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCallanalysisresponsesetsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>string</returns>
        public string OutboundCampaignsCampaignidAgentsUseridPut (string campaignId, string userId, Agent body = null)
        {
             ApiResponse<string> localVarResponse = OutboundCampaignsCampaignidAgentsUseridPutWithHttpInfo(campaignId, userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCampaignsCampaignidAgentsUseridPutWithHttpInfo (string campaignId, string userId, Agent body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidAgentsUseridPut");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->OutboundCampaignsCampaignidAgentsUseridPut");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/agents/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidAgentsUseridPutAsync (string campaignId, string userId, Agent body = null)
        {
             ApiResponse<string> localVarResponse = await OutboundCampaignsCampaignidAgentsUseridPutAsyncWithHttpInfo(campaignId, userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidAgentsUseridPutAsyncWithHttpInfo (string campaignId, string userId, Agent body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidAgentsUseridPut");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->OutboundCampaignsCampaignidAgentsUseridPut");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/agents/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidAgentsUseridPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>ContactCallbackRequest</returns>
        public ContactCallbackRequest OutboundCampaignsCampaignidCallbackSchedulePost (string campaignId, ContactCallbackRequest body = null)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = OutboundCampaignsCampaignidCallbackSchedulePostWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        public ApiResponse< ContactCallbackRequest > OutboundCampaignsCampaignidCallbackSchedulePostWithHttpInfo (string campaignId, ContactCallbackRequest body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidCallbackSchedulePost");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/callback/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        public async System.Threading.Tasks.Task<ContactCallbackRequest> OutboundCampaignsCampaignidCallbackSchedulePostAsync (string campaignId, ContactCallbackRequest body = null)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = await OutboundCampaignsCampaignidCallbackSchedulePostAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest (optional)</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> OutboundCampaignsCampaignidCallbackSchedulePostAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidCallbackSchedulePost");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/callback/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidCallbackSchedulePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        public string OutboundCampaignsCampaignidDelete (string campaignId)
        {
             ApiResponse<string> localVarResponse = OutboundCampaignsCampaignidDeleteWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundCampaignsCampaignidDeleteWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidDelete");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundCampaignsCampaignidDeleteAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await OutboundCampaignsCampaignidDeleteAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidDelete");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        public CampaignDiagnostics OutboundCampaignsCampaignidDiagnosticsGet (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = OutboundCampaignsCampaignidDiagnosticsGetWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        public ApiResponse< CampaignDiagnostics > OutboundCampaignsCampaignidDiagnosticsGetWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidDiagnosticsGet");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/diagnostics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignDiagnostics)));
            
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        public async System.Threading.Tasks.Task<CampaignDiagnostics> OutboundCampaignsCampaignidDiagnosticsGetAsync (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = await OutboundCampaignsCampaignidDiagnosticsGetAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> OutboundCampaignsCampaignidDiagnosticsGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidDiagnosticsGet");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/diagnostics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidDiagnosticsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignDiagnostics)));
            
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        public Campaign OutboundCampaignsCampaignidGet (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = OutboundCampaignsCampaignidGetWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > OutboundCampaignsCampaignidGetWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidGet");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidGetAsync (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = await OutboundCampaignsCampaignidGetAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidGet");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Campaign</returns>
        public Campaign OutboundCampaignsCampaignidPut (string campaignId, Campaign body = null)
        {
             ApiResponse<Campaign> localVarResponse = OutboundCampaignsCampaignidPutWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > OutboundCampaignsCampaignidPutWithHttpInfo (string campaignId, Campaign body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidPut");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> OutboundCampaignsCampaignidPutAsync (string campaignId, Campaign body = null)
        {
             ApiResponse<Campaign> localVarResponse = await OutboundCampaignsCampaignidPutAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, Campaign body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidPut");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        public CampaignStats OutboundCampaignsCampaignidStatsGet (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = OutboundCampaignsCampaignidStatsGetWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        public ApiResponse< CampaignStats > OutboundCampaignsCampaignidStatsGetWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidStatsGet");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignStats)));
            
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        public async System.Threading.Tasks.Task<CampaignStats> OutboundCampaignsCampaignidStatsGetAsync (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = await OutboundCampaignsCampaignidStatsGetAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignStats>> OutboundCampaignsCampaignidStatsGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundCampaignsCampaignidStatsGet");

            var localVarPath = "/api/v1/outbound/campaigns/{campaignId}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsCampaignidStatsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignStats)));
            
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignEntityListing</returns>
        public CampaignEntityListing OutboundCampaignsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> localVarResponse = OutboundCampaignsGetWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignEntityListing</returns>
        public ApiResponse< CampaignEntityListing > OutboundCampaignsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (contactListId != null) localVarQueryParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // query parameter
            if (dncListId != null) localVarQueryParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // query parameter
            if (distributionQueueId != null) localVarQueryParams.Add("distributionQueueId", Configuration.ApiClient.ParameterToString(distributionQueueId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (callAnalysisResponseSetId != null) localVarQueryParams.Add("callAnalysisResponseSetId", Configuration.ApiClient.ParameterToString(callAnalysisResponseSetId)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignEntityListing> OutboundCampaignsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> localVarResponse = await OutboundCampaignsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of dialer campaigns. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="contactListId">Contact List ID (optional)</param>
        /// <param name="dncListId">DNC list ID (optional)</param>
        /// <param name="distributionQueueId">Distribution queue ID (optional)</param>
        /// <param name="edgeGroupId">Edge group ID (optional)</param>
        /// <param name="callAnalysisResponseSetId">Call analysis response set ID (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> OutboundCampaignsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (contactListId != null) localVarQueryParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // query parameter
            if (dncListId != null) localVarQueryParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // query parameter
            if (distributionQueueId != null) localVarQueryParams.Add("distributionQueueId", Configuration.ApiClient.ParameterToString(distributionQueueId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroupId", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (callAnalysisResponseSetId != null) localVarQueryParams.Add("callAnalysisResponseSetId", Configuration.ApiClient.ParameterToString(callAnalysisResponseSetId)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignEntityListing)));
            
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Campaign</returns>
        public Campaign OutboundCampaignsPost (Campaign body = null)
        {
             ApiResponse<Campaign> localVarResponse = OutboundCampaignsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > OutboundCampaignsPostWithHttpInfo (Campaign body = null)
        {

            var localVarPath = "/api/v1/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> OutboundCampaignsPostAsync (Campaign body = null)
        {
             ApiResponse<Campaign> localVarResponse = await OutboundCampaignsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign (optional)</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> OutboundCampaignsPostAsyncWithHttpInfo (Campaign body = null)
        {

            var localVarPath = "/api/v1/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundCampaignsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>PenetrationRate</returns>
        public PenetrationRate OutboundContactlistsContactlistidCampaignidPenetrationrateGet (string contactListId, string campaignId)
        {
             ApiResponse<PenetrationRate> localVarResponse = OutboundContactlistsContactlistidCampaignidPenetrationrateGetWithHttpInfo(contactListId, campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of PenetrationRate</returns>
        public ApiResponse< PenetrationRate > OutboundContactlistsContactlistidCampaignidPenetrationrateGetWithHttpInfo (string contactListId, string campaignId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidCampaignidPenetrationrateGet");
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundContactlistsContactlistidCampaignidPenetrationrateGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PenetrationRate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PenetrationRate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PenetrationRate)));
            
        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of PenetrationRate</returns>
        public async System.Threading.Tasks.Task<PenetrationRate> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsync (string contactListId, string campaignId)
        {
             ApiResponse<PenetrationRate> localVarResponse = await OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsyncWithHttpInfo(contactListId, campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Dialer campaign&#39;s penetration rate Get dialer campaign&#39;s penetration rate.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (PenetrationRate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PenetrationRate>> OutboundContactlistsContactlistidCampaignidPenetrationrateGetAsyncWithHttpInfo (string contactListId, string campaignId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidCampaignidPenetrationrateGet");
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundContactlistsContactlistidCampaignidPenetrationrateGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PenetrationRate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PenetrationRate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PenetrationRate)));
            
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>string</returns>
        public string OutboundContactlistsContactlistidContactsContactidDelete (string contactListId, string contactId)
        {
             ApiResponse<string> localVarResponse = OutboundContactlistsContactlistidContactsContactidDeleteWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundContactlistsContactlistidContactsContactidDeleteWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidDelete");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidDelete");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidContactsContactidDeleteAsync (string contactListId, string contactId)
        {
             ApiResponse<string> localVarResponse = await OutboundContactlistsContactlistidContactsContactidDeleteAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidContactsContactidDeleteAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidDelete");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidDelete");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Contact</returns>
        public Contact OutboundContactlistsContactlistidContactsContactidGet (string contactListId, string contactId)
        {
             ApiResponse<Contact> localVarResponse = OutboundContactlistsContactlistidContactsContactidGetWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > OutboundContactlistsContactlistidContactsContactidGetWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidGet");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidGetAsync (string contactListId, string contactId)
        {
             ApiResponse<Contact> localVarResponse = await OutboundContactlistsContactlistidContactsContactidGetAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidGetAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidGet");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>Contact</returns>
        public Contact OutboundContactlistsContactlistidContactsContactidPut (string contactListId, string contactId, Contact body = null)
        {
             ApiResponse<Contact> localVarResponse = OutboundContactlistsContactlistidContactsContactidPutWithHttpInfo(contactListId, contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > OutboundContactlistsContactlistidContactsContactidPutWithHttpInfo (string contactListId, string contactId, Contact body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidPut");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidPut");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsContactidPutAsync (string contactListId, string contactId, Contact body = null)
        {
             ApiResponse<Contact> localVarResponse = await OutboundContactlistsContactlistidContactsContactidPutAsyncWithHttpInfo(contactListId, contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsContactidPutAsyncWithHttpInfo (string contactListId, string contactId, Contact body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidPut");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->OutboundContactlistsContactlistidContactsContactidPut");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (contactId != null) localVarPathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsContactidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>Contact</returns>
        public Contact OutboundContactlistsContactlistidContactsPost (string contactListId, List<Contact> body = null, bool? priority = null)
        {
             ApiResponse<Contact> localVarResponse = OutboundContactlistsContactlistidContactsPostWithHttpInfo(contactListId, body, priority);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>ApiResponse of Contact</returns>
        public ApiResponse< Contact > OutboundContactlistsContactlistidContactsPostWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsPost");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (priority != null) localVarQueryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>Task of Contact</returns>
        public async System.Threading.Tasks.Task<Contact> OutboundContactlistsContactlistidContactsPostAsync (string contactListId, List<Contact> body = null, bool? priority = null)
        {
             ApiResponse<Contact> localVarResponse = await OutboundContactlistsContactlistidContactsPostAsyncWithHttpInfo(contactListId, body, priority);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact (optional)</param>
        /// <param name="priority"> (optional)</param>
        /// <returns>Task of ApiResponse (Contact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Contact>> OutboundContactlistsContactlistidContactsPostAsyncWithHttpInfo (string contactListId, List<Contact> body = null, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidContactsPost");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (priority != null) localVarQueryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidContactsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Contact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Contact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Contact)));
            
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        public string OutboundContactlistsContactlistidDelete (string contactListId)
        {
             ApiResponse<string> localVarResponse = OutboundContactlistsContactlistidDeleteWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundContactlistsContactlistidDeleteWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidDelete");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidDeleteAsync (string contactListId)
        {
             ApiResponse<string> localVarResponse = await OutboundContactlistsContactlistidDeleteAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidDeleteAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidDelete");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        public string OutboundContactlistsContactlistidExportPost (string contactListId)
        {
             ApiResponse<string> localVarResponse = OutboundContactlistsContactlistidExportPostWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundContactlistsContactlistidExportPostWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidExportPost");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundContactlistsContactlistidExportPostAsync (string contactListId)
        {
             ApiResponse<string> localVarResponse = await OutboundContactlistsContactlistidExportPostAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundContactlistsContactlistidExportPostAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidExportPost");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidExportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        public ContactList OutboundContactlistsContactlistidGet (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = OutboundContactlistsContactlistidGetWithHttpInfo(contactListId, importStatus, includeSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > OutboundContactlistsContactlistidGetWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidGetAsync (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = await OutboundContactlistsContactlistidGetAsyncWithHttpInfo(contactListId, importStatus, includeSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer contactList. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidGetAsyncWithHttpInfo (string contactListId, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        public ImportStatus OutboundContactlistsContactlistidImportstatusGet (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = OutboundContactlistsContactlistidImportstatusGetWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > OutboundContactlistsContactlistidImportstatusGetWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidImportstatusGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> OutboundContactlistsContactlistidImportstatusGetAsync (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await OutboundContactlistsContactlistidImportstatusGetAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundContactlistsContactlistidImportstatusGetAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidImportstatusGet");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidImportstatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ContactList</returns>
        public ContactList OutboundContactlistsContactlistidPut (string contactListId, ContactList body = null)
        {
             ApiResponse<ContactList> localVarResponse = OutboundContactlistsContactlistidPutWithHttpInfo(contactListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > OutboundContactlistsContactlistidPutWithHttpInfo (string contactListId, ContactList body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidPut");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> OutboundContactlistsContactlistidPutAsync (string contactListId, ContactList body = null)
        {
             ApiResponse<ContactList> localVarResponse = await OutboundContactlistsContactlistidPutAsyncWithHttpInfo(contactListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsContactlistidPutAsyncWithHttpInfo (string contactListId, ContactList body = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->OutboundContactlistsContactlistidPut");

            var localVarPath = "/api/v1/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (contactListId != null) localVarPathParams.Add("contactListId", Configuration.ApiClient.ParameterToString(contactListId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsContactlistidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ContactListEntityListing</returns>
        public ContactListEntityListing OutboundContactlistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> localVarResponse = OutboundContactlistsGetWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        public ApiResponse< ContactListEntityListing > OutboundContactlistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListEntityListing)));
            
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ContactListEntityListing</returns>
        public async System.Threading.Tasks.Task<ContactListEntityListing> OutboundContactlistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> localVarResponse = await OutboundContactlistsGetAsyncWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> OutboundContactlistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListEntityListing)));
            
        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>List&lt;PenetrationRate&gt;</returns>
        public List<PenetrationRate> OutboundContactlistsPenetrationratesPost (List<PenetrationRateId> body = null)
        {
             ApiResponse<List<PenetrationRate>> localVarResponse = OutboundContactlistsPenetrationratesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>ApiResponse of List&lt;PenetrationRate&gt;</returns>
        public ApiResponse< List<PenetrationRate> > OutboundContactlistsPenetrationratesPostWithHttpInfo (List<PenetrationRateId> body = null)
        {

            var localVarPath = "/api/v1/outbound/contactlists/penetrationrates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<PenetrationRate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PenetrationRate>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PenetrationRate>)));
            
        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>Task of List&lt;PenetrationRate&gt;</returns>
        public async System.Threading.Tasks.Task<List<PenetrationRate>> OutboundContactlistsPenetrationratesPostAsync (List<PenetrationRateId> body = null)
        {
             ApiResponse<List<PenetrationRate>> localVarResponse = await OutboundContactlistsPenetrationratesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">PenetrationRateIdentifierList (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PenetrationRate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PenetrationRate>>> OutboundContactlistsPenetrationratesPostAsyncWithHttpInfo (List<PenetrationRateId> body = null)
        {

            var localVarPath = "/api/v1/outbound/contactlists/penetrationrates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPenetrationratesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<PenetrationRate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PenetrationRate>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PenetrationRate>)));
            
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ContactList</returns>
        public ContactList OutboundContactlistsPost (ContactList body = null)
        {
             ApiResponse<ContactList> localVarResponse = OutboundContactlistsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > OutboundContactlistsPostWithHttpInfo (ContactList body = null)
        {

            var localVarPath = "/api/v1/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> OutboundContactlistsPostAsync (ContactList body = null)
        {
             ApiResponse<ContactList> localVarResponse = await OutboundContactlistsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList (optional)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> OutboundContactlistsPostAsyncWithHttpInfo (ContactList body = null)
        {

            var localVarPath = "/api/v1/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundContactlistsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        public void OutboundConversationsConversationidDncPost (string conversationId)
        {
             OutboundConversationsConversationidDncPostWithHttpInfo(conversationId);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OutboundConversationsConversationidDncPostWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->OutboundConversationsConversationidDncPost");

            var localVarPath = "/api/v1/outbound/conversations/{conversationId}/dnc";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundConversationsConversationidDncPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundConversationsConversationidDncPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OutboundConversationsConversationidDncPostAsync (string conversationId)
        {
             await OutboundConversationsConversationidDncPostAsyncWithHttpInfo(conversationId);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OutboundConversationsConversationidDncPostAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->OutboundConversationsConversationidDncPost");

            var localVarPath = "/api/v1/outbound/conversations/{conversationId}/dnc";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundConversationsConversationidDncPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundConversationsConversationidDncPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        public string OutboundDnclistsDnclistidDelete (string dncListId)
        {
             ApiResponse<string> localVarResponse = OutboundDnclistsDnclistidDeleteWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundDnclistsDnclistidDeleteWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidDelete");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidDeleteAsync (string dncListId)
        {
             ApiResponse<string> localVarResponse = await OutboundDnclistsDnclistidDeleteAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidDeleteAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidDelete");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        public string OutboundDnclistsDnclistidExportPost (string dncListId)
        {
             ApiResponse<string> localVarResponse = OutboundDnclistsDnclistidExportPostWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundDnclistsDnclistidExportPostWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidExportPost");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundDnclistsDnclistidExportPostAsync (string dncListId)
        {
             ApiResponse<string> localVarResponse = await OutboundDnclistsDnclistidExportPostAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundDnclistsDnclistidExportPostAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidExportPost");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidExportPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        public DncList OutboundDnclistsDnclistidGet (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = OutboundDnclistsDnclistidGetWithHttpInfo(dncListId, importStatus, includeSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > OutboundDnclistsDnclistidGetWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidGet");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidGetAsync (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = await OutboundDnclistsDnclistidGetAsyncWithHttpInfo(dncListId, importStatus, includeSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidGetAsyncWithHttpInfo (string dncListId, bool? importStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidGet");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        public ImportStatus OutboundDnclistsDnclistidImportstatusGet (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = OutboundDnclistsDnclistidImportstatusGetWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > OutboundDnclistsDnclistidImportstatusGetWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidImportstatusGet");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        public async System.Threading.Tasks.Task<ImportStatus> OutboundDnclistsDnclistidImportstatusGetAsync (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await OutboundDnclistsDnclistidImportstatusGetAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> OutboundDnclistsDnclistidImportstatusGetAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidImportstatusGet");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidImportstatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns></returns>
        public void OutboundDnclistsDnclistidPhonenumbersPost (string dncListId, List<string> body = null)
        {
             OutboundDnclistsDnclistidPhonenumbersPostWithHttpInfo(dncListId, body);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> OutboundDnclistsDnclistidPhonenumbersPostWithHttpInfo (string dncListId, List<string> body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidPhonenumbersPost");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}/phonenumbers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task OutboundDnclistsDnclistidPhonenumbersPostAsync (string dncListId, List<string> body = null)
        {
             await OutboundDnclistsDnclistidPhonenumbersPostAsyncWithHttpInfo(dncListId, body);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> OutboundDnclistsDnclistidPhonenumbersPostAsyncWithHttpInfo (string dncListId, List<string> body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidPhonenumbersPost");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}/phonenumbers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPhonenumbersPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>DncList</returns>
        public DncList OutboundDnclistsDnclistidPut (string dncListId, DncList body = null)
        {
             ApiResponse<DncList> localVarResponse = OutboundDnclistsDnclistidPutWithHttpInfo(dncListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > OutboundDnclistsDnclistidPutWithHttpInfo (string dncListId, DncList body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidPut");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> OutboundDnclistsDnclistidPutAsync (string dncListId, DncList body = null)
        {
             ApiResponse<DncList> localVarResponse = await OutboundDnclistsDnclistidPutAsyncWithHttpInfo(dncListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsDnclistidPutAsyncWithHttpInfo (string dncListId, DncList body = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->OutboundDnclistsDnclistidPut");

            var localVarPath = "/api/v1/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (dncListId != null) localVarPathParams.Add("dncListId", Configuration.ApiClient.ParameterToString(dncListId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsDnclistidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>DncListEntityListing</returns>
        public DncListEntityListing OutboundDnclistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> localVarResponse = OutboundDnclistsGetWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        public ApiResponse< DncListEntityListing > OutboundDnclistsGetWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncListEntityListing)));
            
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of DncListEntityListing</returns>
        public async System.Threading.Tasks.Task<DncListEntityListing> OutboundDnclistsGetAsync (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> localVarResponse = await OutboundDnclistsGetAsyncWithHttpInfo(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="importStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> OutboundDnclistsGetAsyncWithHttpInfo (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (importStatus != null) localVarQueryParams.Add("importStatus", Configuration.ApiClient.ParameterToString(importStatus)); // query parameter
            if (includeSize != null) localVarQueryParams.Add("includeSize", Configuration.ApiClient.ParameterToString(includeSize)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncListEntityListing)));
            
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>DncList</returns>
        public DncList OutboundDnclistsPost (DncList body = null)
        {
             ApiResponse<DncList> localVarResponse = OutboundDnclistsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > OutboundDnclistsPostWithHttpInfo (DncList body = null)
        {

            var localVarPath = "/api/v1/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> OutboundDnclistsPostAsync (DncList body = null)
        {
             ApiResponse<DncList> localVarResponse = await OutboundDnclistsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList (optional)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> OutboundDnclistsPostAsyncWithHttpInfo (DncList body = null)
        {

            var localVarPath = "/api/v1/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundDnclistsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Preview&gt;</returns>
        public List<Preview> OutboundPreviewsGet ()
        {
             ApiResponse<List<Preview>> localVarResponse = OutboundPreviewsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Preview&gt;</returns>
        public ApiResponse< List<Preview> > OutboundPreviewsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/previews";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Preview>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Preview>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Preview>)));
            
        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Preview&gt;</returns>
        public async System.Threading.Tasks.Task<List<Preview>> OutboundPreviewsGetAsync ()
        {
             ApiResponse<List<Preview>> localVarResponse = await OutboundPreviewsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer preview for user 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Preview&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Preview>>> OutboundPreviewsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/previews";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Preview>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Preview>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Preview>)));
            
        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>string</returns>
        public string OutboundPreviewsPreviewidDispositioncallPost (string previewId, DialerDispositionCallCommand body = null)
        {
             ApiResponse<string> localVarResponse = OutboundPreviewsPreviewidDispositioncallPostWithHttpInfo(previewId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundPreviewsPreviewidDispositioncallPostWithHttpInfo (string previewId, DialerDispositionCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->OutboundPreviewsPreviewidDispositioncallPost");

            var localVarPath = "/api/v1/outbound/previews/{previewId}/dispositioncall";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (previewId != null) localVarPathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundPreviewsPreviewidDispositioncallPostAsync (string previewId, DialerDispositionCallCommand body = null)
        {
             ApiResponse<string> localVarResponse = await OutboundPreviewsPreviewidDispositioncallPostAsyncWithHttpInfo(previewId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Disposition preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundPreviewsPreviewidDispositioncallPostAsyncWithHttpInfo (string previewId, DialerDispositionCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->OutboundPreviewsPreviewidDispositioncallPost");

            var localVarPath = "/api/v1/outbound/previews/{previewId}/dispositioncall";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (previewId != null) localVarPathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidDispositioncallPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>Preview</returns>
        public Preview OutboundPreviewsPreviewidGet (string previewId)
        {
             ApiResponse<Preview> localVarResponse = OutboundPreviewsPreviewidGetWithHttpInfo(previewId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>ApiResponse of Preview</returns>
        public ApiResponse< Preview > OutboundPreviewsPreviewidGetWithHttpInfo (string previewId)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->OutboundPreviewsPreviewidGet");

            var localVarPath = "/api/v1/outbound/previews/{previewId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (previewId != null) localVarPathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Preview>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Preview) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Preview)));
            
        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of Preview</returns>
        public async System.Threading.Tasks.Task<Preview> OutboundPreviewsPreviewidGetAsync (string previewId)
        {
             ApiResponse<Preview> localVarResponse = await OutboundPreviewsPreviewidGetAsyncWithHttpInfo(previewId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer preview 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <returns>Task of ApiResponse (Preview)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Preview>> OutboundPreviewsPreviewidGetAsyncWithHttpInfo (string previewId)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->OutboundPreviewsPreviewidGet");

            var localVarPath = "/api/v1/outbound/previews/{previewId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (previewId != null) localVarPathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Preview>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Preview) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Preview)));
            
        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>DialerCall</returns>
        public DialerCall OutboundPreviewsPreviewidPlacecallPost (string previewId, DialerPlaceCallCommand body = null)
        {
             ApiResponse<DialerCall> localVarResponse = OutboundPreviewsPreviewidPlacecallPostWithHttpInfo(previewId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DialerCall</returns>
        public ApiResponse< DialerCall > OutboundPreviewsPreviewidPlacecallPostWithHttpInfo (string previewId, DialerPlaceCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->OutboundPreviewsPreviewidPlacecallPost");

            var localVarPath = "/api/v1/outbound/previews/{previewId}/placecall";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (previewId != null) localVarPathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerCall>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerCall) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerCall)));
            
        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DialerCall</returns>
        public async System.Threading.Tasks.Task<DialerCall> OutboundPreviewsPreviewidPlacecallPostAsync (string previewId, DialerPlaceCallCommand body = null)
        {
             ApiResponse<DialerCall> localVarResponse = await OutboundPreviewsPreviewidPlacecallPostAsyncWithHttpInfo(previewId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// place preview call 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="previewId">preview ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DialerCall)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerCall>> OutboundPreviewsPreviewidPlacecallPostAsyncWithHttpInfo (string previewId, DialerPlaceCallCommand body = null)
        {
            // verify the required parameter 'previewId' is set
            if (previewId == null)
                throw new ApiException(400, "Missing required parameter 'previewId' when calling OutboundApi->OutboundPreviewsPreviewidPlacecallPost");

            var localVarPath = "/api/v1/outbound/previews/{previewId}/placecall";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (previewId != null) localVarPathParams.Add("previewId", Configuration.ApiClient.ParameterToString(previewId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundPreviewsPreviewidPlacecallPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerCall>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerCall) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerCall)));
            
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>RuleSetEntityListing</returns>
        public RuleSetEntityListing OutboundRulesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> localVarResponse = OutboundRulesetsGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of RuleSetEntityListing</returns>
        public ApiResponse< RuleSetEntityListing > OutboundRulesetsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSetEntityListing)));
            
        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of RuleSetEntityListing</returns>
        public async System.Threading.Tasks.Task<RuleSetEntityListing> OutboundRulesetsGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> localVarResponse = await OutboundRulesetsGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of Rule Sets. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (RuleSetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> OutboundRulesetsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSetEntityListing)));
            
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>RuleSet</returns>
        public RuleSet OutboundRulesetsPost (RuleSet body = null)
        {
             ApiResponse<RuleSet> localVarResponse = OutboundRulesetsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > OutboundRulesetsPostWithHttpInfo (RuleSet body = null)
        {

            var localVarPath = "/api/v1/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> OutboundRulesetsPostAsync (RuleSet body = null)
        {
             ApiResponse<RuleSet> localVarResponse = await OutboundRulesetsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsPostAsyncWithHttpInfo (RuleSet body = null)
        {

            var localVarPath = "/api/v1/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        public string OutboundRulesetsRulesetidDelete (string ruleSetId)
        {
             ApiResponse<string> localVarResponse = OutboundRulesetsRulesetidDeleteWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundRulesetsRulesetidDeleteWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->OutboundRulesetsRulesetidDelete");

            var localVarPath = "/api/v1/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundRulesetsRulesetidDeleteAsync (string ruleSetId)
        {
             ApiResponse<string> localVarResponse = await OutboundRulesetsRulesetidDeleteAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundRulesetsRulesetidDeleteAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->OutboundRulesetsRulesetidDelete");

            var localVarPath = "/api/v1/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        public RuleSet OutboundRulesetsRulesetidGet (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = OutboundRulesetsRulesetidGetWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > OutboundRulesetsRulesetidGetWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->OutboundRulesetsRulesetidGet");

            var localVarPath = "/api/v1/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidGetAsync (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = await OutboundRulesetsRulesetidGetAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidGetAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->OutboundRulesetsRulesetidGet");

            var localVarPath = "/api/v1/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>RuleSet</returns>
        public RuleSet OutboundRulesetsRulesetidPut (string ruleSetId, RuleSet body = null)
        {
             ApiResponse<RuleSet> localVarResponse = OutboundRulesetsRulesetidPutWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > OutboundRulesetsRulesetidPutWithHttpInfo (string ruleSetId, RuleSet body = null)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->OutboundRulesetsRulesetidPut");

            var localVarPath = "/api/v1/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> OutboundRulesetsRulesetidPutAsync (string ruleSetId, RuleSet body = null)
        {
             ApiResponse<RuleSet> localVarResponse = await OutboundRulesetsRulesetidPutAsyncWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet (optional)</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> OutboundRulesetsRulesetidPutAsyncWithHttpInfo (string ruleSetId, RuleSet body = null)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->OutboundRulesetsRulesetidPut");

            var localVarPath = "/api/v1/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ruleSetId != null) localVarPathParams.Add("ruleSetId", Configuration.ApiClient.ParameterToString(ruleSetId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundRulesetsRulesetidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        public string OutboundSchedulesCampaignsCampaignidDelete (string campaignId)
        {
             ApiResponse<string> localVarResponse = OutboundSchedulesCampaignsCampaignidDeleteWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundSchedulesCampaignsCampaignidDeleteWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundSchedulesCampaignsCampaignidDelete");

            var localVarPath = "/api/v1/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundSchedulesCampaignsCampaignidDeleteAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await OutboundSchedulesCampaignsCampaignidDeleteAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesCampaignsCampaignidDeleteAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundSchedulesCampaignsCampaignidDelete");

            var localVarPath = "/api/v1/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule OutboundSchedulesCampaignsCampaignidGet (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = OutboundSchedulesCampaignsCampaignidGetWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > OutboundSchedulesCampaignsCampaignidGetWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundSchedulesCampaignsCampaignidGet");

            var localVarPath = "/api/v1/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidGetAsync (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await OutboundSchedulesCampaignsCampaignidGetAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidGetAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundSchedulesCampaignsCampaignidGet");

            var localVarPath = "/api/v1/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule OutboundSchedulesCampaignsCampaignidPut (string campaignId, CampaignSchedule body = null)
        {
             ApiResponse<CampaignSchedule> localVarResponse = OutboundSchedulesCampaignsCampaignidPutWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > OutboundSchedulesCampaignsCampaignidPutWithHttpInfo (string campaignId, CampaignSchedule body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundSchedulesCampaignsCampaignidPut");

            var localVarPath = "/api/v1/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> OutboundSchedulesCampaignsCampaignidPutAsync (string campaignId, CampaignSchedule body = null)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await OutboundSchedulesCampaignsCampaignidPutAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule (optional)</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> OutboundSchedulesCampaignsCampaignidPutAsyncWithHttpInfo (string campaignId, CampaignSchedule body = null)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->OutboundSchedulesCampaignsCampaignidPut");

            var localVarPath = "/api/v1/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (campaignId != null) localVarPathParams.Add("campaignId", Configuration.ApiClient.ParameterToString(campaignId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsCampaignidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        public List<CampaignSchedule> OutboundSchedulesCampaignsGet ()
        {
             ApiResponse<List<CampaignSchedule>> localVarResponse = OutboundSchedulesCampaignsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        public ApiResponse< List<CampaignSchedule> > OutboundSchedulesCampaignsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/schedules/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignSchedule>> OutboundSchedulesCampaignsGetAsync ()
        {
             ApiResponse<List<CampaignSchedule>> localVarResponse = await OutboundSchedulesCampaignsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> OutboundSchedulesCampaignsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/schedules/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesCampaignsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        public List<SequenceSchedule> OutboundSchedulesSequencesGet ()
        {
             ApiResponse<List<SequenceSchedule>> localVarResponse = OutboundSchedulesSequencesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        public ApiResponse< List<SequenceSchedule> > OutboundSchedulesSequencesGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/schedules/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SequenceSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<SequenceSchedule>> OutboundSchedulesSequencesGetAsync ()
        {
             ApiResponse<List<SequenceSchedule>> localVarResponse = await OutboundSchedulesSequencesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> OutboundSchedulesSequencesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/schedules/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SequenceSchedule>)));
            
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        public string OutboundSchedulesSequencesSequenceidDelete (string sequenceId)
        {
             ApiResponse<string> localVarResponse = OutboundSchedulesSequencesSequenceidDeleteWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundSchedulesSequencesSequenceidDeleteWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSchedulesSequencesSequenceidDelete");

            var localVarPath = "/api/v1/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundSchedulesSequencesSequenceidDeleteAsync (string sequenceId)
        {
             ApiResponse<string> localVarResponse = await OutboundSchedulesSequencesSequenceidDeleteAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundSchedulesSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSchedulesSequencesSequenceidDelete");

            var localVarPath = "/api/v1/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule OutboundSchedulesSequencesSequenceidGet (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = OutboundSchedulesSequencesSequenceidGetWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > OutboundSchedulesSequencesSequenceidGetWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSchedulesSequencesSequenceidGet");

            var localVarPath = "/api/v1/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidGetAsync (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await OutboundSchedulesSequencesSequenceidGetAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSchedulesSequencesSequenceidGet");

            var localVarPath = "/api/v1/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule OutboundSchedulesSequencesSequenceidPut (string sequenceId, SequenceSchedule body = null)
        {
             ApiResponse<SequenceSchedule> localVarResponse = OutboundSchedulesSequencesSequenceidPutWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > OutboundSchedulesSequencesSequenceidPutWithHttpInfo (string sequenceId, SequenceSchedule body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSchedulesSequencesSequenceidPut");

            var localVarPath = "/api/v1/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> OutboundSchedulesSequencesSequenceidPutAsync (string sequenceId, SequenceSchedule body = null)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await OutboundSchedulesSequencesSequenceidPutAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule (optional)</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> OutboundSchedulesSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, SequenceSchedule body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSchedulesSequencesSequenceidPut");

            var localVarPath = "/api/v1/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSchedulesSequencesSequenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>CampaignSequenceEntityListing</returns>
        public CampaignSequenceEntityListing OutboundSequencesGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> localVarResponse = OutboundSequencesGetWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of CampaignSequenceEntityListing</returns>
        public ApiResponse< CampaignSequenceEntityListing > OutboundSequencesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequenceEntityListing)));
            
        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of CampaignSequenceEntityListing</returns>
        public async System.Threading.Tasks.Task<CampaignSequenceEntityListing> OutboundSequencesGetAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> localVarResponse = await OutboundSequencesGetAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of dialer campaign sequences. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (CampaignSequenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> OutboundSequencesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v1/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (filterType != null) localVarQueryParams.Add("filterType", Configuration.ApiClient.ParameterToString(filterType)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequenceEntityListing)));
            
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence OutboundSequencesPost (CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> localVarResponse = OutboundSequencesPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > OutboundSequencesPostWithHttpInfo (CampaignSequence body = null)
        {

            var localVarPath = "/api/v1/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesPostAsync (CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> localVarResponse = await OutboundSequencesPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesPostAsyncWithHttpInfo (CampaignSequence body = null)
        {

            var localVarPath = "/api/v1/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        public string OutboundSequencesSequenceidDelete (string sequenceId)
        {
             ApiResponse<string> localVarResponse = OutboundSequencesSequenceidDeleteWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > OutboundSequencesSequenceidDeleteWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSequencesSequenceidDelete");

            var localVarPath = "/api/v1/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> OutboundSequencesSequenceidDeleteAsync (string sequenceId)
        {
             ApiResponse<string> localVarResponse = await OutboundSequencesSequenceidDeleteAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> OutboundSequencesSequenceidDeleteAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSequencesSequenceidDelete");

            var localVarPath = "/api/v1/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence OutboundSequencesSequenceidGet (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = OutboundSequencesSequenceidGetWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > OutboundSequencesSequenceidGetWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSequencesSequenceidGet");

            var localVarPath = "/api/v1/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidGetAsync (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = await OutboundSequencesSequenceidGetAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidGetAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSequencesSequenceidGet");

            var localVarPath = "/api/v1/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence OutboundSequencesSequenceidPut (string sequenceId, CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> localVarResponse = OutboundSequencesSequenceidPutWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > OutboundSequencesSequenceidPutWithHttpInfo (string sequenceId, CampaignSequence body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSequencesSequenceidPut");

            var localVarPath = "/api/v1/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> OutboundSequencesSequenceidPutAsync (string sequenceId, CampaignSequence body = null)
        {
             ApiResponse<CampaignSequence> localVarResponse = await OutboundSequencesSequenceidPutAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization (optional)</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> OutboundSequencesSequenceidPutAsyncWithHttpInfo (string sequenceId, CampaignSequence body = null)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->OutboundSequencesSequenceidPut");

            var localVarPath = "/api/v1/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sequenceId != null) localVarPathParams.Add("sequenceId", Configuration.ApiClient.ParameterToString(sequenceId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundSequencesSequenceidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping OutboundWrapupcodemappingsGet ()
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = OutboundWrapupcodemappingsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > OutboundWrapupcodemappingsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsGetAsync ()
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = await OutboundWrapupcodemappingsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping OutboundWrapupcodemappingsPut (WrapUpCodeMapping body = null)
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = OutboundWrapupcodemappingsPutWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > OutboundWrapupcodemappingsPutWithHttpInfo (WrapUpCodeMapping body = null)
        {

            var localVarPath = "/api/v1/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> OutboundWrapupcodemappingsPutAsync (WrapUpCodeMapping body = null)
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = await OutboundWrapupcodemappingsPutAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping (optional)</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> OutboundWrapupcodemappingsPutAsyncWithHttpInfo (WrapUpCodeMapping body = null)
        {

            var localVarPath = "/api/v1/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OutboundWrapupcodemappingsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

    }
}
