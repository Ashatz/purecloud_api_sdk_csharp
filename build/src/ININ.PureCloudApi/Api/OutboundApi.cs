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
    public interface IOutboundApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>string</returns>
        string DeleteAttemptlimitsAttemptlimitsId (string attemptLimitsId);

        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteAttemptlimitsAttemptlimitsIdWithHttpInfo (string attemptLimitsId);
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        string DeleteCallabletimesetsCallabletimesetId (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        string DeleteCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteCampaignsCampaignId (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCampaignsCampaignIdWithHttpInfo (string campaignId);
        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteCampaignsCampaignIdProgress (string campaignId);

        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCampaignsCampaignIdProgressWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string DeleteContactlistsContactlistId (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteContactlistsContactlistIdWithHttpInfo (string contactListId);
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
        string DeleteContactlistsContactlistIdContactsContactId (string contactListId, string contactId);

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
        ApiResponse<string> DeleteContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string DeleteDnclistsDnclistId (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDnclistsDnclistIdWithHttpInfo (string dncListId);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        string DeleteRulesetsRulesetId (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRulesetsRulesetIdWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesCampaignsCampaignId (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesSequencesSequenceId (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        string DeleteSequencesSequenceId (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSequencesSequenceIdWithHttpInfo (string sequenceId);
        /// <summary>
        /// Query attempt limits list
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
        /// <returns>AttemptLimitsEntityListing</returns>
        AttemptLimitsEntityListing GetAttemptlimits (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query attempt limits list
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
        /// <returns>ApiResponse of AttemptLimitsEntityListing</returns>
        ApiResponse<AttemptLimitsEntityListing> GetAttemptlimitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>AttemptLimits</returns>
        AttemptLimits GetAttemptlimitsAttemptlimitsId (string attemptLimitsId);

        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        ApiResponse<AttemptLimits> GetAttemptlimitsAttemptlimitsIdWithHttpInfo (string attemptLimitsId);
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
        CallableTimeSetEntityListing GetCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        ApiResponse<CallableTimeSetEntityListing> GetCallabletimesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet GetCallabletimesetsCallabletimesetId (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> GetCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId);
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
        ResponseSetEntityListing GetCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        ApiResponse<ResponseSetEntityListing> GetCallanalysisresponsesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        ResponseSet GetCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> GetCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId);
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
        CampaignEntityListing GetCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

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
        ApiResponse<CampaignEntityListing> GetCampaignsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign GetCampaignsCampaignId (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> GetCampaignsCampaignIdWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        CampaignDiagnostics GetCampaignsCampaignIdDiagnostics (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        ApiResponse<CampaignDiagnostics> GetCampaignsCampaignIdDiagnosticsWithHttpInfo (string campaignId);
        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignInteractions</returns>
        CampaignInteractions GetCampaignsCampaignIdInteractions (string campaignId);

        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignInteractions</returns>
        ApiResponse<CampaignInteractions> GetCampaignsCampaignIdInteractionsWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignProgress</returns>
        CampaignProgress GetCampaignsCampaignIdProgress (string campaignId);

        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignProgress</returns>
        ApiResponse<CampaignProgress> GetCampaignsCampaignIdProgressWithHttpInfo (string campaignId);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        CampaignStats GetCampaignsCampaignIdStats (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        ApiResponse<CampaignStats> GetCampaignsCampaignIdStatsWithHttpInfo (string campaignId);
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ContactListEntityListing</returns>
        ContactListEntityListing GetContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        ApiResponse<ContactListEntityListing> GetContactlistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        ContactList GetContactlistsContactlistId (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> GetContactlistsContactlistIdWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>DialerContact</returns>
        DialerContact GetContactlistsContactlistIdContactsContactId (string contactListId, string contactId);

        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of DialerContact</returns>
        ApiResponse<DialerContact> GetContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        ExportUri GetContactlistsContactlistIdExport (string contactListId, string download = null);

        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        ApiResponse<ExportUri> GetContactlistsContactlistIdExportWithHttpInfo (string contactListId, string download = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetContactlistsContactlistIdImportstatus (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetContactlistsContactlistIdImportstatusWithHttpInfo (string contactListId);
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>DncListEntityListing</returns>
        DncListEntityListing GetDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        ApiResponse<DncListEntityListing> GetDnclistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        DncList GetDnclistsDnclistId (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> GetDnclistsDnclistIdWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        ExportUri GetDnclistsDnclistIdExport (string dncListId, string download = null);

        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        ApiResponse<ExportUri> GetDnclistsDnclistIdExportWithHttpInfo (string dncListId, string download = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetDnclistsDnclistIdImportstatus (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetDnclistsDnclistIdImportstatusWithHttpInfo (string dncListId);
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
        RuleSetEntityListing GetRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        ApiResponse<RuleSetEntityListing> GetRulesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        RuleSet GetRulesetsRulesetId (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> GetRulesetsRulesetIdWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        List<CampaignSchedule> GetSchedulesCampaigns ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        ApiResponse<List<CampaignSchedule>> GetSchedulesCampaignsWithHttpInfo ();
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule GetSchedulesCampaignsCampaignId (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> GetSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId);
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        List<SequenceSchedule> GetSchedulesSequences ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        ApiResponse<List<SequenceSchedule>> GetSchedulesSequencesWithHttpInfo ();
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule GetSchedulesSequencesSequenceId (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> GetSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId);
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
        CampaignSequenceEntityListing GetSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        ApiResponse<CampaignSequenceEntityListing> GetSequencesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence GetSequencesSequenceId (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> GetSequencesSequenceIdWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping GetWrapupcodemappings ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> GetWrapupcodemappingsWithHttpInfo ();
        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        AttemptLimits PostAttemptlimits (AttemptLimits body);

        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        ApiResponse<AttemptLimits> PostAttemptlimitsWithHttpInfo (AttemptLimits body);
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>AuditSearchResult</returns>
        AuditSearchResult PostAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        ApiResponse<AuditSearchResult> PostAuditsWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PostCallabletimesets (CallableTimeSet body);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PostCallabletimesetsWithHttpInfo (CallableTimeSet body);
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet PostCallanalysisresponsesets (ResponseSet body);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> PostCallanalysisresponsesetsWithHttpInfo (ResponseSet body);
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign PostCampaigns (Campaign body);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> PostCampaignsWithHttpInfo (Campaign body);
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        ContactCallbackRequest PostCampaignsCampaignIdCallbackSchedule (string campaignId, ContactCallbackRequest body);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        ApiResponse<ContactCallbackRequest> PostCampaignsCampaignIdCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body);
        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>List&lt;CampaignProgress&gt;</returns>
        List<CampaignProgress> PostCampaignsProgress (List<string> body);

        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>ApiResponse of List&lt;CampaignProgress&gt;</returns>
        ApiResponse<List<CampaignProgress>> PostCampaignsProgressWithHttpInfo (List<string> body);
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList PostContactlists (ContactList body);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> PostContactlistsWithHttpInfo (ContactList body);
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>List&lt;DialerContact&gt;</returns>
        List<DialerContact> PostContactlistsContactlistIdContacts (string contactListId, List<DialerContact> body, bool? priority = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>ApiResponse of List&lt;DialerContact&gt;</returns>
        ApiResponse<List<DialerContact>> PostContactlistsContactlistIdContactsWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string PostContactlistsContactlistIdExport (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostContactlistsContactlistIdExportWithHttpInfo (string contactListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        void PostConversationsConversationIdDnc (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationsConversationIdDncWithHttpInfo (string conversationId);
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList PostDnclists (DncList body);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> PostDnclistsWithHttpInfo (DncList body);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string PostDnclistsDnclistIdExport (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostDnclistsDnclistIdExportWithHttpInfo (string dncListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns></returns>
        void PostDnclistsDnclistIdPhonenumbers (string dncListId, List<string> body);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostDnclistsDnclistIdPhonenumbersWithHttpInfo (string dncListId, List<string> body);
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet PostRulesets (RuleSet body);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> PostRulesetsWithHttpInfo (RuleSet body);
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence PostSequences (CampaignSequence body);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> PostSequencesWithHttpInfo (CampaignSequence body);
        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        AttemptLimits PutAttemptlimitsAttemptlimitsId (string attemptLimitsId, AttemptLimits body);

        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        ApiResponse<AttemptLimits> PutAttemptlimitsAttemptlimitsIdWithHttpInfo (string attemptLimitsId, AttemptLimits body);
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PutCallabletimesetsCallabletimesetId (string callableTimeSetId, CallableTimeSet body);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> PutCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId, CallableTimeSet body);
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        ResponseSet PutCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId, ResponseSet body);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> PutCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId, ResponseSet body);
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        Campaign PutCampaignsCampaignId (string campaignId, Campaign body);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> PutCampaignsCampaignIdWithHttpInfo (string campaignId, Campaign body);
        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>string</returns>
        string PutCampaignsCampaignIdAgentsUserId (string campaignId, string userId, Agent body);

        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PutCampaignsCampaignIdAgentsUserIdWithHttpInfo (string campaignId, string userId, Agent body);
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        ContactList PutContactlistsContactlistId (string contactListId, ContactList body);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        ApiResponse<ContactList> PutContactlistsContactlistIdWithHttpInfo (string contactListId, ContactList body);
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>DialerContact</returns>
        DialerContact PutContactlistsContactlistIdContactsContactId (string contactListId, string contactId, DialerContact body);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>ApiResponse of DialerContact</returns>
        ApiResponse<DialerContact> PutContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId, DialerContact body);
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        DncList PutDnclistsDnclistId (string dncListId, DncList body);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        ApiResponse<DncList> PutDnclistsDnclistIdWithHttpInfo (string dncListId, DncList body);
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        RuleSet PutRulesetsRulesetId (string ruleSetId, RuleSet body);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> PutRulesetsRulesetIdWithHttpInfo (string ruleSetId, RuleSet body);
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule PutSchedulesCampaignsCampaignId (string campaignId, CampaignSchedule body);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> PutSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId, CampaignSchedule body);
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule PutSchedulesSequencesSequenceId (string sequenceId, SequenceSchedule body);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> PutSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId, SequenceSchedule body);
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence PutSequencesSequenceId (string sequenceId, CampaignSequence body);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> PutSequencesSequenceIdWithHttpInfo (string sequenceId, CampaignSequence body);
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>WrapUpCodeMapping</returns>
        WrapUpCodeMapping PutWrapupcodemappings (WrapUpCodeMapping body);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        ApiResponse<WrapUpCodeMapping> PutWrapupcodemappingsWithHttpInfo (WrapUpCodeMapping body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteAttemptlimitsAttemptlimitsIdAsync (string attemptLimitsId);

        /// <summary>
        /// Delete attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo (string attemptLimitsId);
        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCampaignsCampaignIdProgressAsync (string campaignId);

        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignsCampaignIdProgressAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdAsync (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdAsyncWithHttpInfo (string contactListId);
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
        System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId);

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
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDnclistsDnclistIdAsync (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDnclistsDnclistIdAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRulesetsRulesetIdAsync (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Query attempt limits list
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
        /// <returns>Task of AttemptLimitsEntityListing</returns>
        System.Threading.Tasks.Task<AttemptLimitsEntityListing> GetAttemptlimitsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query attempt limits list
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
        /// <returns>Task of ApiResponse (AttemptLimitsEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimitsEntityListing>> GetAttemptlimitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of AttemptLimits</returns>
        System.Threading.Tasks.Task<AttemptLimits> GetAttemptlimitsAttemptlimitsIdAsync (string attemptLimitsId);

        /// <summary>
        /// Get attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> GetAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo (string attemptLimitsId);
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
        System.Threading.Tasks.Task<CallableTimeSetEntityListing> GetCallabletimesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> GetCallabletimesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> GetCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId);
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
        System.Threading.Tasks.Task<ResponseSetEntityListing> GetCallanalysisresponsesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> GetCallanalysisresponsesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> GetCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId);
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
        System.Threading.Tasks.Task<CampaignEntityListing> GetCampaignsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> GetCampaignsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> GetCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        System.Threading.Tasks.Task<CampaignDiagnostics> GetCampaignsCampaignIdDiagnosticsAsync (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetCampaignsCampaignIdDiagnosticsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignInteractions</returns>
        System.Threading.Tasks.Task<CampaignInteractions> GetCampaignsCampaignIdInteractionsAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign interactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignInteractions)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignInteractions>> GetCampaignsCampaignIdInteractionsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignProgress</returns>
        System.Threading.Tasks.Task<CampaignProgress> GetCampaignsCampaignIdProgressAsync (string campaignId);

        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignProgress)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignProgress>> GetCampaignsCampaignIdProgressAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        System.Threading.Tasks.Task<CampaignStats> GetCampaignsCampaignIdStatsAsync (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetCampaignsCampaignIdStatsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ContactListEntityListing</returns>
        System.Threading.Tasks.Task<ContactListEntityListing> GetContactlistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query a list of contact lists.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> GetContactlistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> GetContactlistsContactlistIdAsync (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get a dialer contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> GetContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of DialerContact</returns>
        System.Threading.Tasks.Task<DialerContact> GetContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId);

        /// <summary>
        /// Get a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerContact>> GetContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        System.Threading.Tasks.Task<ExportUri> GetContactlistsContactlistIdExportAsync (string contactListId, string download = null);

        /// <summary>
        /// Get the URI of a contact list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetContactlistsContactlistIdExportAsyncWithHttpInfo (string contactListId, string download = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetContactlistsContactlistIdImportstatusAsync (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetContactlistsContactlistIdImportstatusAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of DncListEntityListing</returns>
        System.Threading.Tasks.Task<DncListEntityListing> GetDnclistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Query dialer DNC lists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> GetDnclistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> GetDnclistsDnclistIdAsync (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);

        /// <summary>
        /// Get dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> GetDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);
        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        System.Threading.Tasks.Task<ExportUri> GetDnclistsDnclistIdExportAsync (string dncListId, string download = null);

        /// <summary>
        /// Get the URI of a DNC list export.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetDnclistsDnclistIdExportAsyncWithHttpInfo (string dncListId, string download = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetDnclistsDnclistIdImportstatusAsync (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetDnclistsDnclistIdImportstatusAsyncWithHttpInfo (string dncListId);
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
        System.Threading.Tasks.Task<RuleSetEntityListing> GetRulesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> GetRulesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> GetRulesetsRulesetIdAsync (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignSchedule>> GetSchedulesCampaignsAsync ();

        /// <summary>
        /// Query for a list of dialer campaign schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> GetSchedulesCampaignsAsyncWithHttpInfo ();
        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> GetSchedulesCampaignsCampaignIdAsync (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        System.Threading.Tasks.Task<List<SequenceSchedule>> GetSchedulesSequencesAsync ();

        /// <summary>
        /// Query for a list of dialer sequence schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> GetSchedulesSequencesAsyncWithHttpInfo ();
        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> GetSchedulesSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
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
        System.Threading.Tasks.Task<CampaignSequenceEntityListing> GetSequencesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> GetSequencesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null);
        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> GetSequencesSequenceIdAsync (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetSequencesSequenceIdAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> GetWrapupcodemappingsAsync ();

        /// <summary>
        /// Get the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> GetWrapupcodemappingsAsyncWithHttpInfo ();
        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        System.Threading.Tasks.Task<AttemptLimits> PostAttemptlimitsAsync (AttemptLimits body);

        /// <summary>
        /// Create attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PostAttemptlimitsAsyncWithHttpInfo (AttemptLimits body);
        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of AuditSearchResult</returns>
        System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);

        /// <summary>
        /// Retrieves audits for dialer.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null);
        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PostCallabletimesetsAsync (CallableTimeSet body);

        /// <summary>
        /// Create callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostCallabletimesetsAsyncWithHttpInfo (CallableTimeSet body);
        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> PostCallanalysisresponsesetsAsync (ResponseSet body);

        /// <summary>
        /// Create a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PostCallanalysisresponsesetsAsyncWithHttpInfo (ResponseSet body);
        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> PostCampaignsAsync (Campaign body);

        /// <summary>
        /// Create a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PostCampaignsAsyncWithHttpInfo (Campaign body);
        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        System.Threading.Tasks.Task<ContactCallbackRequest> PostCampaignsCampaignIdCallbackScheduleAsync (string campaignId, ContactCallbackRequest body);

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostCampaignsCampaignIdCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body);
        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of List&lt;CampaignProgress&gt;</returns>
        System.Threading.Tasks.Task<List<CampaignProgress>> PostCampaignsProgressAsync (List<string> body);

        /// <summary>
        /// Get progress for a list of campaigns
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of ApiResponse (List&lt;CampaignProgress&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CampaignProgress>>> PostCampaignsProgressAsyncWithHttpInfo (List<string> body);
        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> PostContactlistsAsync (ContactList body);

        /// <summary>
        /// Create a contact List.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PostContactlistsAsyncWithHttpInfo (ContactList body);
        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>Task of List&lt;DialerContact&gt;</returns>
        System.Threading.Tasks.Task<List<DialerContact>> PostContactlistsContactlistIdContactsAsync (string contactListId, List<DialerContact> body, bool? priority = null);

        /// <summary>
        /// Add contacts to a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DialerContact&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DialerContact>>> PostContactlistsContactlistIdContactsAsyncWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostContactlistsContactlistIdExportAsync (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostContactlistsContactlistIdExportAsyncWithHttpInfo (string contactListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationsConversationIdDncAsync (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsConversationIdDncAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> PostDnclistsAsync (DncList body);

        /// <summary>
        /// Create dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> PostDnclistsAsyncWithHttpInfo (DncList body);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostDnclistsDnclistIdExportAsync (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostDnclistsDnclistIdExportAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostDnclistsDnclistIdPhonenumbersAsync (string dncListId, List<string> body);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// Only Internal DNC lists may be appended to
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostDnclistsDnclistIdPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body);
        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> PostRulesetsAsync (RuleSet body);

        /// <summary>
        /// Create a Dialer Call Analysis Response Set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PostRulesetsAsyncWithHttpInfo (RuleSet body);
        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> PostSequencesAsync (CampaignSequence body);

        /// <summary>
        /// Create a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PostSequencesAsyncWithHttpInfo (CampaignSequence body);
        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        System.Threading.Tasks.Task<AttemptLimits> PutAttemptlimitsAttemptlimitsIdAsync (string attemptLimitsId, AttemptLimits body);

        /// <summary>
        /// Update attempt limits
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PutAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo (string attemptLimitsId, AttemptLimits body);
        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PutCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId, CallableTimeSet body);

        /// <summary>
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body);
        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> PutCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId, ResponseSet body);

        /// <summary>
        /// Update a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body);
        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> PutCampaignsCampaignIdAsync (string campaignId, Campaign body);

        /// <summary>
        /// Update a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PutCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, Campaign body);
        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PutCampaignsCampaignIdAgentsUserIdAsync (string campaignId, string userId, Agent body);

        /// <summary>
        /// Send notification that an agent&#39;s state changed 
        /// </summary>
        /// <remarks>
        /// New agent state.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PutCampaignsCampaignIdAgentsUserIdAsyncWithHttpInfo (string campaignId, string userId, Agent body);
        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        System.Threading.Tasks.Task<ContactList> PutContactlistsContactlistIdAsync (string contactListId, ContactList body);

        /// <summary>
        /// Update a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PutContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, ContactList body);
        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of DialerContact</returns>
        System.Threading.Tasks.Task<DialerContact> PutContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId, DialerContact body);

        /// <summary>
        /// Update a contact.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<DialerContact>> PutContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId, DialerContact body);
        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        System.Threading.Tasks.Task<DncList> PutDnclistsDnclistIdAsync (string dncListId, DncList body);

        /// <summary>
        /// Update dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DncList>> PutDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, DncList body);
        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> PutRulesetsRulesetIdAsync (string ruleSetId, RuleSet body);

        /// <summary>
        /// Update a RuleSet.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId, RuleSet body);
        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> PutSchedulesCampaignsCampaignIdAsync (string campaignId, CampaignSchedule body);

        /// <summary>
        /// Update a new campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, CampaignSchedule body);
        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> PutSchedulesSequencesSequenceIdAsync (string sequenceId, SequenceSchedule body);

        /// <summary>
        /// Update a new sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, SequenceSchedule body);
        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> PutSequencesSequenceIdAsync (string sequenceId, CampaignSequence body);

        /// <summary>
        /// Update a new campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, CampaignSequence body);
        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        System.Threading.Tasks.Task<WrapUpCodeMapping> PutWrapupcodemappingsAsync (WrapUpCodeMapping body);

        /// <summary>
        /// Update the Dialer wrap up code mapping.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> PutWrapupcodemappingsAsyncWithHttpInfo (WrapUpCodeMapping body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OutboundApi : IOutboundApi
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>string</returns>
        public string DeleteAttemptlimitsAttemptlimitsId (string attemptLimitsId)
        {
             ApiResponse<string> localVarResponse = DeleteAttemptlimitsAttemptlimitsIdWithHttpInfo(attemptLimitsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteAttemptlimitsAttemptlimitsIdWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->DeleteAttemptlimitsAttemptlimitsId");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttemptlimitsAttemptlimitsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttemptlimitsAttemptlimitsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteAttemptlimitsAttemptlimitsIdAsync (string attemptLimitsId)
        {
             ApiResponse<string> localVarResponse = await DeleteAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo(attemptLimitsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->DeleteAttemptlimitsAttemptlimitsId");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttemptlimitsAttemptlimitsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteAttemptlimitsAttemptlimitsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        public string DeleteCallabletimesetsCallabletimesetId (string callableTimeSetId)
        {
             ApiResponse<string> localVarResponse = DeleteCallabletimesetsCallabletimesetIdWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteCallabletimesetsCallabletimesetId");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId)
        {
             ApiResponse<string> localVarResponse = await DeleteCallabletimesetsCallabletimesetIdAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteCallabletimesetsCallabletimesetId");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimesetsCallabletimesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        public string DeleteCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId)
        {
             ApiResponse<string> localVarResponse = DeleteCallanalysisresponsesetsCallanalysissetIdWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteCallanalysisresponsesetsCallanalysissetId");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId)
        {
             ApiResponse<string> localVarResponse = await DeleteCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteCallanalysisresponsesetsCallanalysissetId");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        public string DeleteCampaignsCampaignId (string campaignId)
        {
             ApiResponse<string> localVarResponse = DeleteCampaignsCampaignIdWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await DeleteCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        public string DeleteCampaignsCampaignIdProgress (string campaignId)
        {
             ApiResponse<string> localVarResponse = DeleteCampaignsCampaignIdProgressWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCampaignsCampaignIdProgressWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignsCampaignIdProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignIdProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignIdProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteCampaignsCampaignIdProgressAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await DeleteCampaignsCampaignIdProgressAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignsCampaignIdProgressAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignsCampaignIdProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignIdProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignsCampaignIdProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        public string DeleteContactlistsContactlistId (string contactListId)
        {
             ApiResponse<string> localVarResponse = DeleteContactlistsContactlistIdWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteContactlistsContactlistIdWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistsContactlistId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdAsync (string contactListId)
        {
             ApiResponse<string> localVarResponse = await DeleteContactlistsContactlistIdAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistsContactlistId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>string</returns>
        public string DeleteContactlistsContactlistIdContactsContactId (string contactListId, string contactId)
        {
             ApiResponse<string> localVarResponse = DeleteContactlistsContactlistIdContactsContactIdWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId)
        {
             ApiResponse<string> localVarResponse = await DeleteContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->DeleteContactlistsContactlistIdContactsContactId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistsContactlistIdContactsContactId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        public string DeleteDnclistsDnclistId (string dncListId)
        {
             ApiResponse<string> localVarResponse = DeleteDnclistsDnclistIdWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDnclistsDnclistIdWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteDnclistsDnclistId");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclistsDnclistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclistsDnclistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteDnclistsDnclistIdAsync (string dncListId)
        {
             ApiResponse<string> localVarResponse = await DeleteDnclistsDnclistIdAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDnclistsDnclistIdAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteDnclistsDnclistId");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclistsDnclistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclistsDnclistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        public string DeleteRulesetsRulesetId (string ruleSetId)
        {
             ApiResponse<string> localVarResponse = DeleteRulesetsRulesetIdWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRulesetsRulesetIdWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteRulesetsRulesetId");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRulesetsRulesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRulesetsRulesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteRulesetsRulesetIdAsync (string ruleSetId)
        {
             ApiResponse<string> localVarResponse = await DeleteRulesetsRulesetIdAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteRulesetsRulesetId");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRulesetsRulesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRulesetsRulesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        public string DeleteSchedulesCampaignsCampaignId (string campaignId)
        {
             ApiResponse<string> localVarResponse = DeleteSchedulesCampaignsCampaignIdWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteSchedulesCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteSchedulesCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await DeleteSchedulesCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteSchedulesCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        public string DeleteSchedulesSequencesSequenceId (string sequenceId)
        {
             ApiResponse<string> localVarResponse = DeleteSchedulesSequencesSequenceIdWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSchedulesSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteSchedulesSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<string> localVarResponse = await DeleteSchedulesSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSchedulesSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        public string DeleteSequencesSequenceId (string sequenceId)
        {
             ApiResponse<string> localVarResponse = DeleteSequencesSequenceIdWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<string> localVarResponse = await DeleteSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>AttemptLimitsEntityListing</returns>
        public AttemptLimitsEntityListing GetAttemptlimits (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AttemptLimitsEntityListing> localVarResponse = GetAttemptlimitsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of AttemptLimitsEntityListing</returns>
        public ApiResponse< AttemptLimitsEntityListing > GetAttemptlimitsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimitsEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimitsEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimitsEntityListing)));
            
        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of AttemptLimitsEntityListing</returns>
        public async System.Threading.Tasks.Task<AttemptLimitsEntityListing> GetAttemptlimitsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<AttemptLimitsEntityListing> localVarResponse = await GetAttemptlimitsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query attempt limits list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (AttemptLimitsEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimitsEntityListing>> GetAttemptlimitsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimitsEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimitsEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimitsEntityListing)));
            
        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>AttemptLimits</returns>
        public AttemptLimits GetAttemptlimitsAttemptlimitsId (string attemptLimitsId)
        {
             ApiResponse<AttemptLimits> localVarResponse = GetAttemptlimitsAttemptlimitsIdWithHttpInfo(attemptLimitsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        public ApiResponse< AttemptLimits > GetAttemptlimitsAttemptlimitsIdWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->GetAttemptlimitsAttemptlimitsId");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimitsAttemptlimitsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimitsAttemptlimitsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of AttemptLimits</returns>
        public async System.Threading.Tasks.Task<AttemptLimits> GetAttemptlimitsAttemptlimitsIdAsync (string attemptLimitsId)
        {
             ApiResponse<AttemptLimits> localVarResponse = await GetAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo(attemptLimitsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> GetAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo (string attemptLimitsId)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->GetAttemptlimitsAttemptlimitsId");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimitsAttemptlimitsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAttemptlimitsAttemptlimitsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
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
        public CallableTimeSetEntityListing GetCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> localVarResponse = GetCallabletimesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< CallableTimeSetEntityListing > GetCallabletimesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CallableTimeSetEntityListing> GetCallabletimesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CallableTimeSetEntityListing> localVarResponse = await GetCallabletimesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSetEntityListing>> GetCallabletimesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSetEntityListing)));
            
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet GetCallabletimesetsCallabletimesetId (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = GetCallabletimesetsCallabletimesetIdWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > GetCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetCallabletimesetsCallabletimesetId");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CallableTimeSet> GetCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await GetCallabletimesetsCallabletimesetIdAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetCallabletimesetsCallabletimesetId");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimesetsCallabletimesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
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
        public ResponseSetEntityListing GetCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> localVarResponse = GetCallanalysisresponsesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< ResponseSetEntityListing > GetCallanalysisresponsesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ResponseSetEntityListing> GetCallanalysisresponsesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ResponseSetEntityListing> localVarResponse = await GetCallanalysisresponsesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSetEntityListing>> GetCallanalysisresponsesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSetEntityListing)));
            
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet GetCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = GetCallanalysisresponsesetsCallanalysissetIdWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > GetCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetCallanalysisresponsesetsCallanalysissetId");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ResponseSet> GetCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = await GetCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetCallanalysisresponsesetsCallanalysissetId");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
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
        public CampaignEntityListing GetCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> localVarResponse = GetCampaignsWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
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
        public ApiResponse< CampaignEntityListing > GetCampaignsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaigns: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignEntityListing> GetCampaignsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignEntityListing> localVarResponse = await GetCampaignsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<CampaignEntityListing>> GetCampaignsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaigns: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignEntityListing)));
            
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        public Campaign GetCampaignsCampaignId (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = GetCampaignsCampaignIdWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > GetCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Campaign> GetCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = await GetCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        public CampaignDiagnostics GetCampaignsCampaignIdDiagnostics (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = GetCampaignsCampaignIdDiagnosticsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        public ApiResponse< CampaignDiagnostics > GetCampaignsCampaignIdDiagnosticsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdDiagnostics");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/diagnostics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignDiagnostics> GetCampaignsCampaignIdDiagnosticsAsync (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = await GetCampaignsCampaignIdDiagnosticsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetCampaignsCampaignIdDiagnosticsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdDiagnostics");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/diagnostics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdDiagnostics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignDiagnostics)));
            
        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignInteractions</returns>
        public CampaignInteractions GetCampaignsCampaignIdInteractions (string campaignId)
        {
             ApiResponse<CampaignInteractions> localVarResponse = GetCampaignsCampaignIdInteractionsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignInteractions</returns>
        public ApiResponse< CampaignInteractions > GetCampaignsCampaignIdInteractionsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdInteractions");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/interactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdInteractions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdInteractions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignInteractions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignInteractions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignInteractions)));
            
        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignInteractions</returns>
        public async System.Threading.Tasks.Task<CampaignInteractions> GetCampaignsCampaignIdInteractionsAsync (string campaignId)
        {
             ApiResponse<CampaignInteractions> localVarResponse = await GetCampaignsCampaignIdInteractionsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer campaign interactions. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignInteractions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignInteractions>> GetCampaignsCampaignIdInteractionsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdInteractions");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/interactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdInteractions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdInteractions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignInteractions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignInteractions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignInteractions)));
            
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignProgress</returns>
        public CampaignProgress GetCampaignsCampaignIdProgress (string campaignId)
        {
             ApiResponse<CampaignProgress> localVarResponse = GetCampaignsCampaignIdProgressWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignProgress</returns>
        public ApiResponse< CampaignProgress > GetCampaignsCampaignIdProgressWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignProgress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignProgress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignProgress)));
            
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignProgress</returns>
        public async System.Threading.Tasks.Task<CampaignProgress> GetCampaignsCampaignIdProgressAsync (string campaignId)
        {
             ApiResponse<CampaignProgress> localVarResponse = await GetCampaignsCampaignIdProgressAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignProgress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignProgress>> GetCampaignsCampaignIdProgressAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdProgress");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignProgress>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignProgress) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignProgress)));
            
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        public CampaignStats GetCampaignsCampaignIdStats (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = GetCampaignsCampaignIdStatsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        public ApiResponse< CampaignStats > GetCampaignsCampaignIdStatsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdStats");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdStats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignStats> GetCampaignsCampaignIdStatsAsync (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = await GetCampaignsCampaignIdStatsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetCampaignsCampaignIdStatsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignsCampaignIdStats");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdStats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignsCampaignIdStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignStats)));
            
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ContactListEntityListing</returns>
        public ContactListEntityListing GetContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> localVarResponse = GetContactlistsWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>ApiResponse of ContactListEntityListing</returns>
        public ApiResponse< ContactListEntityListing > GetContactlistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListEntityListing)));
            
        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ContactListEntityListing</returns>
        public async System.Threading.Tasks.Task<ContactListEntityListing> GetContactlistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ContactListEntityListing> localVarResponse = await GetContactlistsAsyncWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query a list of contact lists. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Include import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional, default to a)</param>
        /// <returns>Task of ApiResponse (ContactListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListEntityListing>> GetContactlistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactListEntityListing)));
            
        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        public ContactList GetContactlistsContactlistId (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = GetContactlistsContactlistIdWithHttpInfo(contactListId, includeImportStatus, includeSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > GetContactlistsContactlistIdWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> GetContactlistsContactlistIdAsync (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = await GetContactlistsContactlistIdAsyncWithHttpInfo(contactListId, includeImportStatus, includeSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> GetContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>DialerContact</returns>
        public DialerContact GetContactlistsContactlistIdContactsContactId (string contactListId, string contactId)
        {
             ApiResponse<DialerContact> localVarResponse = GetContactlistsContactlistIdContactsContactIdWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of DialerContact</returns>
        public ApiResponse< DialerContact > GetContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetContactlistsContactlistIdContactsContactId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of DialerContact</returns>
        public async System.Threading.Tasks.Task<DialerContact> GetContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId)
        {
             ApiResponse<DialerContact> localVarResponse = await GetContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerContact>> GetContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetContactlistsContactlistIdContactsContactId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdContactsContactId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        public ExportUri GetContactlistsContactlistIdExport (string contactListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = GetContactlistsContactlistIdExportWithHttpInfo(contactListId, download);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        public ApiResponse< ExportUri > GetContactlistsContactlistIdExportWithHttpInfo (string contactListId, string download = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        public async System.Threading.Tasks.Task<ExportUri> GetContactlistsContactlistIdExportAsync (string contactListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = await GetContactlistsContactlistIdExportAsyncWithHttpInfo(contactListId, download);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetContactlistsContactlistIdExportAsyncWithHttpInfo (string contactListId, string download = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        public ImportStatus GetContactlistsContactlistIdImportstatus (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = GetContactlistsContactlistIdImportstatusWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetContactlistsContactlistIdImportstatusWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdImportstatus");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ImportStatus> GetContactlistsContactlistIdImportstatusAsync (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await GetContactlistsContactlistIdImportstatusAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetContactlistsContactlistIdImportstatusAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistsContactlistIdImportstatus");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistsContactlistIdImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>DncListEntityListing</returns>
        public DncListEntityListing GetDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> localVarResponse = GetDnclistsWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>ApiResponse of DncListEntityListing</returns>
        public ApiResponse< DncListEntityListing > GetDnclistsWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncListEntityListing)));
            
        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of DncListEntityListing</returns>
        public async System.Threading.Tasks.Task<DncListEntityListing> GetDnclistsAsync (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<DncListEntityListing> localVarResponse = await GetDnclistsAsyncWithHttpInfo(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query dialer DNC lists 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="filterType">Filter type (optional, default to PREFIX)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="sortBy">Sort by (optional)</param>
        /// <param name="sortOrder">Sort order (optional)</param>
        /// <returns>Task of ApiResponse (DncListEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncListEntityListing>> GetDnclistsAsyncWithHttpInfo (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncListEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncListEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncListEntityListing)));
            
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        public DncList GetDnclistsDnclistId (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = GetDnclistsDnclistIdWithHttpInfo(dncListId, includeImportStatus, includeSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > GetDnclistsDnclistIdWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistId");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> GetDnclistsDnclistIdAsync (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = await GetDnclistsDnclistIdAsyncWithHttpInfo(dncListId, includeImportStatus, includeSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> GetDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistId");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (includeImportStatus != null) localVarQueryParams.Add("includeImportStatus", Configuration.ApiClient.ParameterToString(includeImportStatus)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ExportUri</returns>
        public ExportUri GetDnclistsDnclistIdExport (string dncListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = GetDnclistsDnclistIdExportWithHttpInfo(dncListId, download);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        public ApiResponse< ExportUri > GetDnclistsDnclistIdExportWithHttpInfo (string dncListId, string download = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistIdExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ExportUri</returns>
        public async System.Threading.Tasks.Task<ExportUri> GetDnclistsDnclistIdExportAsync (string dncListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = await GetDnclistsDnclistIdExportAsyncWithHttpInfo(dncListId, download);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetDnclistsDnclistIdExportAsyncWithHttpInfo (string dncListId, string download = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistIdExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExportUri>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExportUri) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExportUri)));
            
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        public ImportStatus GetDnclistsDnclistIdImportstatus (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = GetDnclistsDnclistIdImportstatusWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetDnclistsDnclistIdImportstatusWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistIdImportstatus");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ImportStatus> GetDnclistsDnclistIdImportstatusAsync (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await GetDnclistsDnclistIdImportstatusAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetDnclistsDnclistIdImportstatusAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistsDnclistIdImportstatus");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/importstatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistsDnclistIdImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
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
        public RuleSetEntityListing GetRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> localVarResponse = GetRulesetsWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< RuleSetEntityListing > GetRulesetsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetRulesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<RuleSetEntityListing> GetRulesetsAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<RuleSetEntityListing> localVarResponse = await GetRulesetsAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<RuleSetEntityListing>> GetRulesetsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetRulesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSetEntityListing)));
            
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        public RuleSet GetRulesetsRulesetId (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = GetRulesetsRulesetIdWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > GetRulesetsRulesetIdWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetRulesetsRulesetId");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetRulesetsRulesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRulesetsRulesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<RuleSet> GetRulesetsRulesetIdAsync (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = await GetRulesetsRulesetIdAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetRulesetsRulesetId");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetRulesetsRulesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRulesetsRulesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CampaignSchedule&gt;</returns>
        public List<CampaignSchedule> GetSchedulesCampaigns ()
        {
             ApiResponse<List<CampaignSchedule>> localVarResponse = GetSchedulesCampaignsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CampaignSchedule&gt;</returns>
        public ApiResponse< List<CampaignSchedule> > GetSchedulesCampaignsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaigns: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CampaignSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignSchedule>> GetSchedulesCampaignsAsync ()
        {
             ApiResponse<List<CampaignSchedule>> localVarResponse = await GetSchedulesCampaignsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for a list of dialer campaign schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CampaignSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignSchedule>>> GetSchedulesCampaignsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaigns: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignSchedule>)));
            
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule GetSchedulesCampaignsCampaignId (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = GetSchedulesCampaignsCampaignIdWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > GetSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetSchedulesCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSchedule> GetSchedulesCampaignsCampaignIdAsync (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await GetSchedulesCampaignsCampaignIdAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetSchedulesCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;SequenceSchedule&gt;</returns>
        public List<SequenceSchedule> GetSchedulesSequences ()
        {
             ApiResponse<List<SequenceSchedule>> localVarResponse = GetSchedulesSequencesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;SequenceSchedule&gt;</returns>
        public ApiResponse< List<SequenceSchedule> > GetSchedulesSequencesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequences: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SequenceSchedule>)));
            
        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;SequenceSchedule&gt;</returns>
        public async System.Threading.Tasks.Task<List<SequenceSchedule>> GetSchedulesSequencesAsync ()
        {
             ApiResponse<List<SequenceSchedule>> localVarResponse = await GetSchedulesSequencesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for a list of dialer sequence schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;SequenceSchedule&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SequenceSchedule>>> GetSchedulesSequencesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/schedules/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequences: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<SequenceSchedule>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SequenceSchedule>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SequenceSchedule>)));
            
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule GetSchedulesSequencesSequenceId (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = GetSchedulesSequencesSequenceIdWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > GetSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSchedulesSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<SequenceSchedule> GetSchedulesSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await GetSchedulesSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSchedulesSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CampaignSequenceEntityListing GetSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> localVarResponse = GetSequencesWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public ApiResponse< CampaignSequenceEntityListing > GetSequencesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSequences: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSequenceEntityListing> GetSequencesAsync (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<CampaignSequenceEntityListing> localVarResponse = await GetSequencesAsyncWithHttpInfo(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequenceEntityListing>> GetSequencesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)
        {

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSequences: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequenceEntityListing)));
            
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence GetSequencesSequenceId (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = GetSequencesSequenceIdWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > GetSequencesSequenceIdWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSequence> GetSequencesSequenceIdAsync (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = await GetSequencesSequenceIdAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetSequencesSequenceIdAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping GetWrapupcodemappings ()
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = GetWrapupcodemappingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > GetWrapupcodemappingsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> GetWrapupcodemappingsAsync ()
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = await GetWrapupcodemappingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> GetWrapupcodemappingsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        public AttemptLimits PostAttemptlimits (AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = PostAttemptlimitsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        public ApiResponse< AttemptLimits > PostAttemptlimitsWithHttpInfo (AttemptLimits body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostAttemptlimits");

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostAttemptlimits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        public async System.Threading.Tasks.Task<AttemptLimits> PostAttemptlimitsAsync (AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = await PostAttemptlimitsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PostAttemptlimitsAsyncWithHttpInfo (AttemptLimits body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostAttemptlimits");

            var localVarPath = "/api/v2/outbound/attemptlimits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostAttemptlimits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAttemptlimits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>AuditSearchResult</returns>
        public AuditSearchResult PostAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = PostAuditsWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        public ApiResponse< AuditSearchResult > PostAuditsWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostAudits");

            var localVarPath = "/api/v2/outbound/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of AuditSearchResult</returns>
        public async System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = await PostAuditsAsyncWithHttpInfo(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves audits for dialer. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearch</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to entity.name)</param>
        /// <param name="sortOrder">Sort order (optional, default to ascending)</param>
        /// <param name="facetsOnly">Facets only (optional, default to false)</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostAudits");

            var localVarPath = "/api/v2/outbound/audits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PostCallabletimesets (CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PostCallabletimesetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PostCallabletimesetsWithHttpInfo (CallableTimeSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCallabletimesets");

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallabletimesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PostCallabletimesetsAsync (CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PostCallabletimesetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PostCallabletimesetsAsyncWithHttpInfo (CallableTimeSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCallabletimesets");

            var localVarPath = "/api/v2/outbound/callabletimesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallabletimesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallabletimesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet PostCallanalysisresponsesets (ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = PostCallanalysisresponsesetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PostCallanalysisresponsesetsWithHttpInfo (ResponseSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCallanalysisresponsesets");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> PostCallanalysisresponsesetsAsync (ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = await PostCallanalysisresponsesetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PostCallanalysisresponsesetsAsyncWithHttpInfo (ResponseSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCallanalysisresponsesets");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallanalysisresponsesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallanalysisresponsesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        public Campaign PostCampaigns (Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = PostCampaignsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PostCampaignsWithHttpInfo (Campaign body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaigns");

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaigns: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> PostCampaignsAsync (Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = await PostCampaignsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PostCampaignsAsyncWithHttpInfo (Campaign body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaigns");

            var localVarPath = "/api/v2/outbound/campaigns";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaigns: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaigns: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        public ContactCallbackRequest PostCampaignsCampaignIdCallbackSchedule (string campaignId, ContactCallbackRequest body)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = PostCampaignsCampaignIdCallbackScheduleWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        public ApiResponse< ContactCallbackRequest > PostCampaignsCampaignIdCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostCampaignsCampaignIdCallbackSchedule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaignsCampaignIdCallbackSchedule");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/callback/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        public async System.Threading.Tasks.Task<ContactCallbackRequest> PostCampaignsCampaignIdCallbackScheduleAsync (string campaignId, ContactCallbackRequest body)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = await PostCampaignsCampaignIdCallbackScheduleAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostCampaignsCampaignIdCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostCampaignsCampaignIdCallbackSchedule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaignsCampaignIdCallbackSchedule");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/callback/schedule";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsCampaignIdCallbackSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>List&lt;CampaignProgress&gt;</returns>
        public List<CampaignProgress> PostCampaignsProgress (List<string> body)
        {
             ApiResponse<List<CampaignProgress>> localVarResponse = PostCampaignsProgressWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>ApiResponse of List&lt;CampaignProgress&gt;</returns>
        public ApiResponse< List<CampaignProgress> > PostCampaignsProgressWithHttpInfo (List<string> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaignsProgress");

            var localVarPath = "/api/v2/outbound/campaigns/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignProgress>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignProgress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignProgress>)));
            
        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of List&lt;CampaignProgress&gt;</returns>
        public async System.Threading.Tasks.Task<List<CampaignProgress>> PostCampaignsProgressAsync (List<string> body)
        {
             ApiResponse<List<CampaignProgress>> localVarResponse = await PostCampaignsProgressAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get progress for a list of campaigns 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Campaign IDs</param>
        /// <returns>Task of ApiResponse (List&lt;CampaignProgress&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CampaignProgress>>> PostCampaignsProgressAsyncWithHttpInfo (List<string> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaignsProgress");

            var localVarPath = "/api/v2/outbound/campaigns/progress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignsProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CampaignProgress>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CampaignProgress>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CampaignProgress>)));
            
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        public ContactList PostContactlists (ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = PostContactlistsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PostContactlistsWithHttpInfo (ContactList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostContactlists");

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> PostContactlistsAsync (ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = await PostContactlistsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a contact List. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PostContactlistsAsyncWithHttpInfo (ContactList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostContactlists");

            var localVarPath = "/api/v2/outbound/contactlists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>List&lt;DialerContact&gt;</returns>
        public List<DialerContact> PostContactlistsContactlistIdContacts (string contactListId, List<DialerContact> body, bool? priority = null)
        {
             ApiResponse<List<DialerContact>> localVarResponse = PostContactlistsContactlistIdContactsWithHttpInfo(contactListId, body, priority);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>ApiResponse of List&lt;DialerContact&gt;</returns>
        public ApiResponse< List<DialerContact> > PostContactlistsContactlistIdContactsWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistsContactlistIdContacts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostContactlistsContactlistIdContacts");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdContacts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DialerContact>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DialerContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DialerContact>)));
            
        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>Task of List&lt;DialerContact&gt;</returns>
        public async System.Threading.Tasks.Task<List<DialerContact>> PostContactlistsContactlistIdContactsAsync (string contactListId, List<DialerContact> body, bool? priority = null)
        {
             ApiResponse<List<DialerContact>> localVarResponse = await PostContactlistsContactlistIdContactsAsyncWithHttpInfo(contactListId, body, priority);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;DialerContact&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DialerContact>>> PostContactlistsContactlistIdContactsAsyncWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistsContactlistIdContacts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostContactlistsContactlistIdContacts");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdContacts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<DialerContact>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DialerContact>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DialerContact>)));
            
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        public string PostContactlistsContactlistIdExport (string contactListId)
        {
             ApiResponse<string> localVarResponse = PostContactlistsContactlistIdExportWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostContactlistsContactlistIdExportWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistsContactlistIdExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> PostContactlistsContactlistIdExportAsync (string contactListId)
        {
             ApiResponse<string> localVarResponse = await PostContactlistsContactlistIdExportAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostContactlistsContactlistIdExportAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistsContactlistIdExport");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistsContactlistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        public void PostConversationsConversationIdDnc (string conversationId)
        {
             PostConversationsConversationIdDncWithHttpInfo(conversationId);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationsConversationIdDncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostConversationsConversationIdDnc");

            var localVarPath = "/api/v2/outbound/conversations/{conversationId}/dnc";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDnc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDnc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task PostConversationsConversationIdDncAsync (string conversationId)
        {
             await PostConversationsConversationIdDncAsyncWithHttpInfo(conversationId);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationsConversationIdDncAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostConversationsConversationIdDnc");

            var localVarPath = "/api/v2/outbound/conversations/{conversationId}/dnc";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDnc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDnc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        public DncList PostDnclists (DncList body)
        {
             ApiResponse<DncList> localVarResponse = PostDnclistsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PostDnclistsWithHttpInfo (DncList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostDnclists");

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> PostDnclistsAsync (DncList body)
        {
             ApiResponse<DncList> localVarResponse = await PostDnclistsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PostDnclistsAsyncWithHttpInfo (DncList body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostDnclists");

            var localVarPath = "/api/v2/outbound/dnclists";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclists: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclists: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        public string PostDnclistsDnclistIdExport (string dncListId)
        {
             ApiResponse<string> localVarResponse = PostDnclistsDnclistIdExportWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostDnclistsDnclistIdExportWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistsDnclistIdExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> PostDnclistsDnclistIdExportAsync (string dncListId)
        {
             ApiResponse<string> localVarResponse = await PostDnclistsDnclistIdExportAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostDnclistsDnclistIdExportAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistsDnclistIdExport");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns></returns>
        public void PostDnclistsDnclistIdPhonenumbers (string dncListId, List<string> body)
        {
             PostDnclistsDnclistIdPhonenumbersWithHttpInfo(dncListId, body);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostDnclistsDnclistIdPhonenumbersWithHttpInfo (string dncListId, List<string> body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistsDnclistIdPhonenumbers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostDnclistsDnclistIdPhonenumbers");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/phonenumbers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostDnclistsDnclistIdPhonenumbersAsync (string dncListId, List<string> body)
        {
             await PostDnclistsDnclistIdPhonenumbersAsyncWithHttpInfo(dncListId, body);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostDnclistsDnclistIdPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistsDnclistIdPhonenumbers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostDnclistsDnclistIdPhonenumbers");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}/phonenumbers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistsDnclistIdPhonenumbers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        public RuleSet PostRulesets (RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = PostRulesetsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PostRulesetsWithHttpInfo (RuleSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostRulesets");

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostRulesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> PostRulesetsAsync (RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = await PostRulesetsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Dialer Call Analysis Response Set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PostRulesetsAsyncWithHttpInfo (RuleSet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostRulesets");

            var localVarPath = "/api/v2/outbound/rulesets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostRulesets: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRulesets: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence PostSequences (CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = PostSequencesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PostSequencesWithHttpInfo (CampaignSequence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostSequences");

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostSequences: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> PostSequencesAsync (CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = await PostSequencesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PostSequencesAsyncWithHttpInfo (CampaignSequence body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostSequences");

            var localVarPath = "/api/v2/outbound/sequences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostSequences: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSequences: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>AttemptLimits</returns>
        public AttemptLimits PutAttemptlimitsAttemptlimitsId (string attemptLimitsId, AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = PutAttemptlimitsAttemptlimitsIdWithHttpInfo(attemptLimitsId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>ApiResponse of AttemptLimits</returns>
        public ApiResponse< AttemptLimits > PutAttemptlimitsAttemptlimitsIdWithHttpInfo (string attemptLimitsId, AttemptLimits body)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->PutAttemptlimitsAttemptlimitsId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutAttemptlimitsAttemptlimitsId");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutAttemptlimitsAttemptlimitsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAttemptlimitsAttemptlimitsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of AttemptLimits</returns>
        public async System.Threading.Tasks.Task<AttemptLimits> PutAttemptlimitsAttemptlimitsIdAsync (string attemptLimitsId, AttemptLimits body)
        {
             ApiResponse<AttemptLimits> localVarResponse = await PutAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo(attemptLimitsId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update attempt limits 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="attemptLimitsId">Attempt limits ID</param>
        /// <param name="body">AttemptLimits</param>
        /// <returns>Task of ApiResponse (AttemptLimits)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttemptLimits>> PutAttemptlimitsAttemptlimitsIdAsyncWithHttpInfo (string attemptLimitsId, AttemptLimits body)
        {
            // verify the required parameter 'attemptLimitsId' is set
            if (attemptLimitsId == null)
                throw new ApiException(400, "Missing required parameter 'attemptLimitsId' when calling OutboundApi->PutAttemptlimitsAttemptlimitsId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutAttemptlimitsAttemptlimitsId");

            var localVarPath = "/api/v2/outbound/attemptlimits/{attemptLimitsId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (attemptLimitsId != null) localVarPathParams.Add("attemptLimitsId", Configuration.ApiClient.ParameterToString(attemptLimitsId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutAttemptlimitsAttemptlimitsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutAttemptlimitsAttemptlimitsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttemptLimits>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttemptLimits) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttemptLimits)));
            
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PutCallabletimesetsCallabletimesetId (string callableTimeSetId, CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PutCallabletimesetsCallabletimesetIdWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PutCallabletimesetsCallabletimesetIdWithHttpInfo (string callableTimeSetId, CallableTimeSet body)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutCallabletimesetsCallabletimesetId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallabletimesetsCallabletimesetId");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        public async System.Threading.Tasks.Task<CallableTimeSet> PutCallabletimesetsCallabletimesetIdAsync (string callableTimeSetId, CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PutCallabletimesetsCallabletimesetIdAsyncWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutCallabletimesetsCallabletimesetIdAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutCallabletimesetsCallabletimesetId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallabletimesetsCallabletimesetId");

            var localVarPath = "/api/v2/outbound/callabletimesets/{callableTimeSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimesetsCallabletimesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallableTimeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallableTimeSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallableTimeSet)));
            
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet PutCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId, ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = PutCallanalysisresponsesetsCallanalysissetIdWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PutCallanalysisresponsesetsCallanalysissetIdWithHttpInfo (string callAnalysisSetId, ResponseSet body)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutCallanalysisresponsesetsCallanalysissetId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallanalysisresponsesetsCallanalysissetId");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ResponseSet</returns>
        public async System.Threading.Tasks.Task<ResponseSet> PutCallanalysisresponsesetsCallanalysissetIdAsync (string callAnalysisSetId, ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = await PutCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutCallanalysisresponsesetsCallanalysissetIdAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutCallanalysisresponsesetsCallanalysissetId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallanalysisresponsesetsCallanalysissetId");

            var localVarPath = "/api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponsesetsCallanalysissetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ResponseSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResponseSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseSet)));
            
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Campaign</returns>
        public Campaign PutCampaignsCampaignId (string campaignId, Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = PutCampaignsCampaignIdWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PutCampaignsCampaignIdWithHttpInfo (string campaignId, Campaign body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignsCampaignId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of Campaign</returns>
        public async System.Threading.Tasks.Task<Campaign> PutCampaignsCampaignIdAsync (string campaignId, Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = await PutCampaignsCampaignIdAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PutCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, Campaign body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignsCampaignId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Campaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Campaign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Campaign)));
            
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>string</returns>
        public string PutCampaignsCampaignIdAgentsUserId (string campaignId, string userId, Agent body)
        {
             ApiResponse<string> localVarResponse = PutCampaignsCampaignIdAgentsUserIdWithHttpInfo(campaignId, userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PutCampaignsCampaignIdAgentsUserIdWithHttpInfo (string campaignId, string userId, Agent body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/agents/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="body">agent</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PutCampaignsCampaignIdAgentsUserIdAsync (string campaignId, string userId, Agent body)
        {
             ApiResponse<string> localVarResponse = await PutCampaignsCampaignIdAgentsUserIdAsyncWithHttpInfo(campaignId, userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send notification that an agent&#39;s state changed  New agent state.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="userId">Agent&#39;s user ID</param>
        /// <param name="body">agent</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PutCampaignsCampaignIdAgentsUserIdAsyncWithHttpInfo (string campaignId, string userId, Agent body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaignsCampaignIdAgentsUserId");

            var localVarPath = "/api/v2/outbound/campaigns/{campaignId}/agents/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignsCampaignIdAgentsUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ContactList</returns>
        public ContactList PutContactlistsContactlistId (string contactListId, ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = PutContactlistsContactlistIdWithHttpInfo(contactListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PutContactlistsContactlistIdWithHttpInfo (string contactListId, ContactList body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistsContactlistId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlistsContactlistId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ContactList</returns>
        public async System.Threading.Tasks.Task<ContactList> PutContactlistsContactlistIdAsync (string contactListId, ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = await PutContactlistsContactlistIdAsyncWithHttpInfo(contactListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PutContactlistsContactlistIdAsyncWithHttpInfo (string contactListId, ContactList body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistsContactlistId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlistsContactlistId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactList)));
            
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>DialerContact</returns>
        public DialerContact PutContactlistsContactlistIdContactsContactId (string contactListId, string contactId, DialerContact body)
        {
             ApiResponse<DialerContact> localVarResponse = PutContactlistsContactlistIdContactsContactIdWithHttpInfo(contactListId, contactId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>ApiResponse of DialerContact</returns>
        public ApiResponse< DialerContact > PutContactlistsContactlistIdContactsContactIdWithHttpInfo (string contactListId, string contactId, DialerContact body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of DialerContact</returns>
        public async System.Threading.Tasks.Task<DialerContact> PutContactlistsContactlistIdContactsContactIdAsync (string contactListId, string contactId, DialerContact body)
        {
             ApiResponse<DialerContact> localVarResponse = await PutContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo(contactListId, contactId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <param name="body">Contact</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerContact>> PutContactlistsContactlistIdContactsContactIdAsyncWithHttpInfo (string contactListId, string contactId, DialerContact body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlistsContactlistIdContactsContactId");

            var localVarPath = "/api/v2/outbound/contactlists/{contactListId}/contacts/{contactId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistsContactlistIdContactsContactId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DialerContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DialerContact) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DialerContact)));
            
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>DncList</returns>
        public DncList PutDnclistsDnclistId (string dncListId, DncList body)
        {
             ApiResponse<DncList> localVarResponse = PutDnclistsDnclistIdWithHttpInfo(dncListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PutDnclistsDnclistIdWithHttpInfo (string dncListId, DncList body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutDnclistsDnclistId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutDnclistsDnclistId");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutDnclistsDnclistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDnclistsDnclistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of DncList</returns>
        public async System.Threading.Tasks.Task<DncList> PutDnclistsDnclistIdAsync (string dncListId, DncList body)
        {
             ApiResponse<DncList> localVarResponse = await PutDnclistsDnclistIdAsyncWithHttpInfo(dncListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PutDnclistsDnclistIdAsyncWithHttpInfo (string dncListId, DncList body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutDnclistsDnclistId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutDnclistsDnclistId");

            var localVarPath = "/api/v2/outbound/dnclists/{dncListId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutDnclistsDnclistId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDnclistsDnclistId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DncList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DncList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DncList)));
            
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>RuleSet</returns>
        public RuleSet PutRulesetsRulesetId (string ruleSetId, RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = PutRulesetsRulesetIdWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PutRulesetsRulesetIdWithHttpInfo (string ruleSetId, RuleSet body)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutRulesetsRulesetId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutRulesetsRulesetId");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRulesetsRulesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRulesetsRulesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of RuleSet</returns>
        public async System.Threading.Tasks.Task<RuleSet> PutRulesetsRulesetIdAsync (string ruleSetId, RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = await PutRulesetsRulesetIdAsyncWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutRulesetsRulesetIdAsyncWithHttpInfo (string ruleSetId, RuleSet body)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutRulesetsRulesetId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutRulesetsRulesetId");

            var localVarPath = "/api/v2/outbound/rulesets/{ruleSetId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRulesetsRulesetId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRulesetsRulesetId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule PutSchedulesCampaignsCampaignId (string campaignId, CampaignSchedule body)
        {
             ApiResponse<CampaignSchedule> localVarResponse = PutSchedulesCampaignsCampaignIdWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > PutSchedulesCampaignsCampaignIdWithHttpInfo (string campaignId, CampaignSchedule body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutSchedulesCampaignsCampaignId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of CampaignSchedule</returns>
        public async System.Threading.Tasks.Task<CampaignSchedule> PutSchedulesCampaignsCampaignIdAsync (string campaignId, CampaignSchedule body)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await PutSchedulesCampaignsCampaignIdAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutSchedulesCampaignsCampaignIdAsyncWithHttpInfo (string campaignId, CampaignSchedule body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutSchedulesCampaignsCampaignId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesCampaignsCampaignId");

            var localVarPath = "/api/v2/outbound/schedules/campaigns/{campaignId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaignsCampaignId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaignsCampaignId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule PutSchedulesSequencesSequenceId (string sequenceId, SequenceSchedule body)
        {
             ApiResponse<SequenceSchedule> localVarResponse = PutSchedulesSequencesSequenceIdWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > PutSchedulesSequencesSequenceIdWithHttpInfo (string sequenceId, SequenceSchedule body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSchedulesSequencesSequenceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of SequenceSchedule</returns>
        public async System.Threading.Tasks.Task<SequenceSchedule> PutSchedulesSequencesSequenceIdAsync (string sequenceId, SequenceSchedule body)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await PutSchedulesSequencesSequenceIdAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutSchedulesSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, SequenceSchedule body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSchedulesSequencesSequenceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/schedules/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence PutSequencesSequenceId (string sequenceId, CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = PutSequencesSequenceIdWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PutSequencesSequenceIdWithHttpInfo (string sequenceId, CampaignSequence body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSequencesSequenceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of CampaignSequence</returns>
        public async System.Threading.Tasks.Task<CampaignSequence> PutSequencesSequenceIdAsync (string sequenceId, CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = await PutSequencesSequenceIdAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutSequencesSequenceIdAsyncWithHttpInfo (string sequenceId, CampaignSequence body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSequencesSequenceId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSequencesSequenceId");

            var localVarPath = "/api/v2/outbound/sequences/{sequenceId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSequencesSequenceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSequencesSequenceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>WrapUpCodeMapping</returns>
        public WrapUpCodeMapping PutWrapupcodemappings (WrapUpCodeMapping body)
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = PutWrapupcodemappingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>ApiResponse of WrapUpCodeMapping</returns>
        public ApiResponse< WrapUpCodeMapping > PutWrapupcodemappingsWithHttpInfo (WrapUpCodeMapping body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutWrapupcodemappings");

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of WrapUpCodeMapping</returns>
        public async System.Threading.Tasks.Task<WrapUpCodeMapping> PutWrapupcodemappingsAsync (WrapUpCodeMapping body)
        {
             ApiResponse<WrapUpCodeMapping> localVarResponse = await PutWrapupcodemappingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Dialer wrap up code mapping. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">wrapUpCodeMapping</param>
        /// <returns>Task of ApiResponse (WrapUpCodeMapping)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapUpCodeMapping>> PutWrapupcodemappingsAsyncWithHttpInfo (WrapUpCodeMapping body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutWrapupcodemappings");

            var localVarPath = "/api/v2/outbound/wrapupcodemappings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodemappings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutWrapupcodemappings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapUpCodeMapping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapUpCodeMapping) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapUpCodeMapping)));
            
        }

    }
}
