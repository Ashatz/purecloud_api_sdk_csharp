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
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        string DeleteCallabletimeset (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallabletimesetWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>string</returns>
        string DeleteCallanalysisresponseset (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteCampaign (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteCampaignProgress (string campaignId);

        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCampaignProgressWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string DeleteContactlist (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteContactlistWithHttpInfo (string contactListId);
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
        string DeleteContactlistContact (string contactListId, string contactId);

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
        ApiResponse<string> DeleteContactlistContactWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string DeleteDnclist (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDnclistWithHttpInfo (string dncListId);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>string</returns>
        string DeleteRuleset (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRulesetWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesCampaign (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesSequence (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesSequenceWithHttpInfo (string sequenceId);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>string</returns>
        string DeleteSequence (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSequenceWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet GetCallabletimeset (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        ApiResponse<CallableTimeSet> GetCallabletimesetWithHttpInfo (string callableTimeSetId);
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
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        ResponseSet GetCallanalysisresponseset (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        ApiResponse<ResponseSet> GetCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId);
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
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        Campaign GetCampaign (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        ApiResponse<Campaign> GetCampaignWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignDiagnostics</returns>
        CampaignDiagnostics GetCampaignDiagnostics (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        ApiResponse<CampaignDiagnostics> GetCampaignDiagnosticsWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignProgress</returns>
        CampaignProgress GetCampaignProgress (string campaignId);

        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignProgress</returns>
        ApiResponse<CampaignProgress> GetCampaignProgressWithHttpInfo (string campaignId);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignStats</returns>
        CampaignStats GetCampaignStats (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        ApiResponse<CampaignStats> GetCampaignStatsWithHttpInfo (string campaignId);
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
        ContactList GetContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);

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
        ApiResponse<ContactList> GetContactlistWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);
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
        DialerContact GetContactlistContact (string contactListId, string contactId);

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
        ApiResponse<DialerContact> GetContactlistContactWithHttpInfo (string contactListId, string contactId);
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
        ExportUri GetContactlistExport (string contactListId, string download = null);

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
        ApiResponse<ExportUri> GetContactlistExportWithHttpInfo (string contactListId, string download = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetContactlistImportstatus (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetContactlistImportstatusWithHttpInfo (string contactListId);
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
        DncList GetDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);

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
        ApiResponse<DncList> GetDnclistWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);
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
        ExportUri GetDnclistExport (string dncListId, string download = null);

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
        ApiResponse<ExportUri> GetDnclistExportWithHttpInfo (string dncListId, string download = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ImportStatus</returns>
        ImportStatus GetDnclistImportstatus (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        ApiResponse<ImportStatus> GetDnclistImportstatusWithHttpInfo (string dncListId);
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
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        RuleSet GetRuleset (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        ApiResponse<RuleSet> GetRulesetWithHttpInfo (string ruleSetId);
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
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        CampaignSchedule GetSchedulesCampaign (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        ApiResponse<CampaignSchedule> GetSchedulesCampaignWithHttpInfo (string campaignId);
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
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        SequenceSchedule GetSchedulesSequence (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        ApiResponse<SequenceSchedule> GetSchedulesSequenceWithHttpInfo (string sequenceId);
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
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        CampaignSequence GetSequence (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        ApiResponse<CampaignSequence> GetSequenceWithHttpInfo (string sequenceId);
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
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        ContactCallbackRequest PostCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body);

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
        ApiResponse<ContactCallbackRequest> PostCampaignCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body);
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
        List<DialerContact> PostContactlistContacts (string contactListId, List<DialerContact> body, bool? priority = null);

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
        ApiResponse<List<DialerContact>> PostContactlistContactsWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>string</returns>
        string PostContactlistExport (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostContactlistExportWithHttpInfo (string contactListId);
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
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        void PostConversationDnc (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationDncWithHttpInfo (string conversationId);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        string PostDnclistExport (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostDnclistExportWithHttpInfo (string dncListId);
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
        void PostDnclistPhonenumbers (string dncListId, List<string> body);

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
        ApiResponse<Object> PostDnclistPhonenumbersWithHttpInfo (string dncListId, List<string> body);
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
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        CallableTimeSet PutCallabletimeset (string callableTimeSetId, CallableTimeSet body);

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
        ApiResponse<CallableTimeSet> PutCallabletimesetWithHttpInfo (string callableTimeSetId, CallableTimeSet body);
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
        ResponseSet PutCallanalysisresponseset (string callAnalysisSetId, ResponseSet body);

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
        ApiResponse<ResponseSet> PutCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId, ResponseSet body);
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
        Campaign PutCampaign (string campaignId, Campaign body);

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
        ApiResponse<Campaign> PutCampaignWithHttpInfo (string campaignId, Campaign body);
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
        string PutCampaignAgent (string campaignId, string userId, Agent body);

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
        ApiResponse<string> PutCampaignAgentWithHttpInfo (string campaignId, string userId, Agent body);
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
        ContactList PutContactlist (string contactListId, ContactList body);

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
        ApiResponse<ContactList> PutContactlistWithHttpInfo (string contactListId, ContactList body);
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
        DialerContact PutContactlistContact (string contactListId, string contactId, DialerContact body);

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
        ApiResponse<DialerContact> PutContactlistContactWithHttpInfo (string contactListId, string contactId, DialerContact body);
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
        DncList PutDnclist (string dncListId, DncList body);

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
        ApiResponse<DncList> PutDnclistWithHttpInfo (string dncListId, DncList body);
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
        RuleSet PutRuleset (string ruleSetId, RuleSet body);

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
        ApiResponse<RuleSet> PutRulesetWithHttpInfo (string ruleSetId, RuleSet body);
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
        CampaignSchedule PutSchedulesCampaign (string campaignId, CampaignSchedule body);

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
        ApiResponse<CampaignSchedule> PutSchedulesCampaignWithHttpInfo (string campaignId, CampaignSchedule body);
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
        SequenceSchedule PutSchedulesSequence (string sequenceId, SequenceSchedule body);

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
        ApiResponse<SequenceSchedule> PutSchedulesSequenceWithHttpInfo (string sequenceId, SequenceSchedule body);
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
        CampaignSequence PutSequence (string sequenceId, CampaignSequence body);

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
        ApiResponse<CampaignSequence> PutSequenceWithHttpInfo (string sequenceId, CampaignSequence body);
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
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallabletimesetAsync (string callableTimeSetId);

        /// <summary>
        /// Delete callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallabletimesetAsyncWithHttpInfo (string callableTimeSetId);
        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallanalysisresponsesetAsync (string callAnalysisSetId);

        /// <summary>
        /// Delete a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId);
        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCampaignAsync (string campaignId);

        /// <summary>
        /// Delete a campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCampaignProgressAsync (string campaignId);

        /// <summary>
        /// Reset campaign progress and recycle the campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignProgressAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteContactlistAsync (string contactListId);

        /// <summary>
        /// Delete a contact list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistAsyncWithHttpInfo (string contactListId);
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
        System.Threading.Tasks.Task<string> DeleteContactlistContactAsync (string contactListId, string contactId);

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
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistContactAsyncWithHttpInfo (string contactListId, string contactId);
        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDnclistAsync (string dncListId);

        /// <summary>
        /// Delete dialer DNC list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDnclistAsyncWithHttpInfo (string dncListId);
        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRulesetAsync (string ruleSetId);

        /// <summary>
        /// Delete a Rule set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRulesetAsyncWithHttpInfo (string ruleSetId);
        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesCampaignAsync (string campaignId);

        /// <summary>
        /// Delete a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesSequenceAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesSequenceAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSequenceAsync (string sequenceId);

        /// <summary>
        /// Delete a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSequenceAsyncWithHttpInfo (string sequenceId);
        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> GetCallabletimesetAsync (string callableTimeSetId);

        /// <summary>
        /// Get callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetCallabletimesetAsyncWithHttpInfo (string callableTimeSetId);
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
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ResponseSet</returns>
        System.Threading.Tasks.Task<ResponseSet> GetCallanalysisresponsesetAsync (string callAnalysisSetId);

        /// <summary>
        /// Get a dialer call analysis response set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId);
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
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of Campaign</returns>
        System.Threading.Tasks.Task<Campaign> GetCampaignAsync (string campaignId);

        /// <summary>
        /// Get dialer campaign.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignDiagnostics</returns>
        System.Threading.Tasks.Task<CampaignDiagnostics> GetCampaignDiagnosticsAsync (string campaignId);

        /// <summary>
        /// Get campaign diagnostics
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetCampaignDiagnosticsAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignProgress</returns>
        System.Threading.Tasks.Task<CampaignProgress> GetCampaignProgressAsync (string campaignId);

        /// <summary>
        /// Get campaign progress
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignProgress)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignProgress>> GetCampaignProgressAsyncWithHttpInfo (string campaignId);
        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignStats</returns>
        System.Threading.Tasks.Task<CampaignStats> GetCampaignStatsAsync (string campaignId);

        /// <summary>
        /// Get statistics about a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetCampaignStatsAsyncWithHttpInfo (string campaignId);
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
        System.Threading.Tasks.Task<ContactList> GetContactlistAsync (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<ContactList>> GetContactlistAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null);
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
        System.Threading.Tasks.Task<DialerContact> GetContactlistContactAsync (string contactListId, string contactId);

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
        System.Threading.Tasks.Task<ApiResponse<DialerContact>> GetContactlistContactAsyncWithHttpInfo (string contactListId, string contactId);
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
        System.Threading.Tasks.Task<ExportUri> GetContactlistExportAsync (string contactListId, string download = null);

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
        System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetContactlistExportAsyncWithHttpInfo (string contactListId, string download = null);
        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetContactlistImportstatusAsync (string contactListId);

        /// <summary>
        /// Get dialer contactList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetContactlistImportstatusAsyncWithHttpInfo (string contactListId);
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
        System.Threading.Tasks.Task<DncList> GetDnclistAsync (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<DncList>> GetDnclistAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null);
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
        System.Threading.Tasks.Task<ExportUri> GetDnclistExportAsync (string dncListId, string download = null);

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
        System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetDnclistExportAsyncWithHttpInfo (string dncListId, string download = null);
        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ImportStatus</returns>
        System.Threading.Tasks.Task<ImportStatus> GetDnclistImportstatusAsync (string dncListId);

        /// <summary>
        /// Get dialer dncList import status.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetDnclistImportstatusAsyncWithHttpInfo (string dncListId);
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
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of RuleSet</returns>
        System.Threading.Tasks.Task<RuleSet> GetRulesetAsync (string ruleSetId);

        /// <summary>
        /// Get a Rule Set by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetRulesetAsyncWithHttpInfo (string ruleSetId);
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
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of CampaignSchedule</returns>
        System.Threading.Tasks.Task<CampaignSchedule> GetSchedulesCampaignAsync (string campaignId);

        /// <summary>
        /// Get a dialer campaign schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetSchedulesCampaignAsyncWithHttpInfo (string campaignId);
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
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of SequenceSchedule</returns>
        System.Threading.Tasks.Task<SequenceSchedule> GetSchedulesSequenceAsync (string sequenceId);

        /// <summary>
        /// Get a dialer sequence schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetSchedulesSequenceAsyncWithHttpInfo (string sequenceId);
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
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of CampaignSequence</returns>
        System.Threading.Tasks.Task<CampaignSequence> GetSequenceAsync (string sequenceId);

        /// <summary>
        /// Get a dialer campaign sequence.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetSequenceAsyncWithHttpInfo (string sequenceId);
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
        /// Schedule a Callback for a Dialer Campaign
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ContactCallbackRequest</returns>
        System.Threading.Tasks.Task<ContactCallbackRequest> PostCampaignCallbackScheduleAsync (string campaignId, ContactCallbackRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostCampaignCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body);
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
        System.Threading.Tasks.Task<List<DialerContact>> PostContactlistContactsAsync (string contactListId, List<DialerContact> body, bool? priority = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<DialerContact>>> PostContactlistContactsAsyncWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null);
        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostContactlistExportAsync (string contactListId);

        /// <summary>
        /// Initiate the export of a contact list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostContactlistExportAsyncWithHttpInfo (string contactListId);
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
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationDncAsync (string conversationId);

        /// <summary>
        /// Add phone numbers to a Dialer DNC list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationDncAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostDnclistExportAsync (string dncListId);

        /// <summary>
        /// Initiate the export of a dnc list.
        /// </summary>
        /// <remarks>
        /// Returns 200 if received OK.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostDnclistExportAsyncWithHttpInfo (string dncListId);
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
        System.Threading.Tasks.Task PostDnclistPhonenumbersAsync (string dncListId, List<string> body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostDnclistPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body);
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
        /// Update callable time set
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of CallableTimeSet</returns>
        System.Threading.Tasks.Task<CallableTimeSet> PutCallabletimesetAsync (string callableTimeSetId, CallableTimeSet body);

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
        System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutCallabletimesetAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body);
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
        System.Threading.Tasks.Task<ResponseSet> PutCallanalysisresponsesetAsync (string callAnalysisSetId, ResponseSet body);

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
        System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body);
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
        System.Threading.Tasks.Task<Campaign> PutCampaignAsync (string campaignId, Campaign body);

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
        System.Threading.Tasks.Task<ApiResponse<Campaign>> PutCampaignAsyncWithHttpInfo (string campaignId, Campaign body);
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
        System.Threading.Tasks.Task<string> PutCampaignAgentAsync (string campaignId, string userId, Agent body);

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
        System.Threading.Tasks.Task<ApiResponse<string>> PutCampaignAgentAsyncWithHttpInfo (string campaignId, string userId, Agent body);
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
        System.Threading.Tasks.Task<ContactList> PutContactlistAsync (string contactListId, ContactList body);

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
        System.Threading.Tasks.Task<ApiResponse<ContactList>> PutContactlistAsyncWithHttpInfo (string contactListId, ContactList body);
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
        System.Threading.Tasks.Task<DialerContact> PutContactlistContactAsync (string contactListId, string contactId, DialerContact body);

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
        System.Threading.Tasks.Task<ApiResponse<DialerContact>> PutContactlistContactAsyncWithHttpInfo (string contactListId, string contactId, DialerContact body);
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
        System.Threading.Tasks.Task<DncList> PutDnclistAsync (string dncListId, DncList body);

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
        System.Threading.Tasks.Task<ApiResponse<DncList>> PutDnclistAsyncWithHttpInfo (string dncListId, DncList body);
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
        System.Threading.Tasks.Task<RuleSet> PutRulesetAsync (string ruleSetId, RuleSet body);

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
        System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutRulesetAsyncWithHttpInfo (string ruleSetId, RuleSet body);
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
        System.Threading.Tasks.Task<CampaignSchedule> PutSchedulesCampaignAsync (string campaignId, CampaignSchedule body);

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
        System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutSchedulesCampaignAsyncWithHttpInfo (string campaignId, CampaignSchedule body);
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
        System.Threading.Tasks.Task<SequenceSchedule> PutSchedulesSequenceAsync (string sequenceId, SequenceSchedule body);

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
        System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutSchedulesSequenceAsyncWithHttpInfo (string sequenceId, SequenceSchedule body);
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
        System.Threading.Tasks.Task<CampaignSequence> PutSequenceAsync (string sequenceId, CampaignSequence body);

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
        System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutSequenceAsyncWithHttpInfo (string sequenceId, CampaignSequence body);
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
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>string</returns>
        public string DeleteCallabletimeset (string callableTimeSetId)
        {
             ApiResponse<string> localVarResponse = DeleteCallabletimesetWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallabletimesetWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteCallabletimeset");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimeset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCallabletimesetAsync (string callableTimeSetId)
        {
             ApiResponse<string> localVarResponse = await DeleteCallabletimesetAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallabletimesetAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->DeleteCallabletimeset");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimeset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteCallanalysisresponseset (string callAnalysisSetId)
        {
             ApiResponse<string> localVarResponse = DeleteCallanalysisresponsesetWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteCallanalysisresponseset");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCallanalysisresponsesetAsync (string callAnalysisSetId)
        {
             ApiResponse<string> localVarResponse = await DeleteCallanalysisresponsesetAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->DeleteCallanalysisresponseset");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteCampaign (string campaignId)
        {
             ApiResponse<string> localVarResponse = DeleteCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCampaignAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await DeleteCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteCampaignProgress (string campaignId)
        {
             ApiResponse<string> localVarResponse = DeleteCampaignProgressWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCampaignProgressWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignProgress");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteCampaignProgressAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await DeleteCampaignProgressAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reset campaign progress and recycle the campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCampaignProgressAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteCampaignProgress");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteContactlist (string contactListId)
        {
             ApiResponse<string> localVarResponse = DeleteContactlistWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteContactlistWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlist");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteContactlistAsync (string contactListId)
        {
             ApiResponse<string> localVarResponse = await DeleteContactlistAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlist");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteContactlistContact (string contactListId, string contactId)
        {
             ApiResponse<string> localVarResponse = DeleteContactlistContactWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteContactlistContactWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->DeleteContactlistContact");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteContactlistContactAsync (string contactListId, string contactId)
        {
             ApiResponse<string> localVarResponse = await DeleteContactlistContactAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContactlistContactAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->DeleteContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->DeleteContactlistContact");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteDnclist (string dncListId)
        {
             ApiResponse<string> localVarResponse = DeleteDnclistWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDnclistWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteDnclist");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteDnclistAsync (string dncListId)
        {
             ApiResponse<string> localVarResponse = await DeleteDnclistAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDnclistAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->DeleteDnclist");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteRuleset (string ruleSetId)
        {
             ApiResponse<string> localVarResponse = DeleteRulesetWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRulesetWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteRuleset");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRuleset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteRulesetAsync (string ruleSetId)
        {
             ApiResponse<string> localVarResponse = await DeleteRulesetAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Rule set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRulesetAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->DeleteRuleset");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteRuleset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteSchedulesCampaign (string campaignId)
        {
             ApiResponse<string> localVarResponse = DeleteSchedulesCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteSchedulesCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteSchedulesCampaignAsync (string campaignId)
        {
             ApiResponse<string> localVarResponse = await DeleteSchedulesCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->DeleteSchedulesCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteSchedulesSequence (string sequenceId)
        {
             ApiResponse<string> localVarResponse = DeleteSchedulesSequenceWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSchedulesSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteSchedulesSequenceAsync (string sequenceId)
        {
             ApiResponse<string> localVarResponse = await DeleteSchedulesSequenceAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSchedulesSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string DeleteSequence (string sequenceId)
        {
             ApiResponse<string> localVarResponse = DeleteSequenceWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> DeleteSequenceAsync (string sequenceId)
        {
             ApiResponse<string> localVarResponse = await DeleteSequenceAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->DeleteSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CallableTimeSet GetCallabletimeset (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = GetCallabletimesetWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > GetCallabletimesetWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetCallabletimeset");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimeset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CallableTimeSet> GetCallabletimesetAsync (string callableTimeSetId)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await GetCallabletimesetAsyncWithHttpInfo(callableTimeSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> GetCallabletimesetAsyncWithHttpInfo (string callableTimeSetId)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->GetCallabletimeset");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimeset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ResponseSet</returns>
        public ResponseSet GetCallanalysisresponseset (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = GetCallanalysisresponsesetWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > GetCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetCallanalysisresponseset");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ResponseSet> GetCallanalysisresponsesetAsync (string callAnalysisSetId)
        {
             ApiResponse<ResponseSet> localVarResponse = await GetCallanalysisresponsesetAsyncWithHttpInfo(callAnalysisSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> GetCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->GetCallanalysisresponseset");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Campaign</returns>
        public Campaign GetCampaign (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = GetCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > GetCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Campaign> GetCampaignAsync (string campaignId)
        {
             ApiResponse<Campaign> localVarResponse = await GetCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> GetCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CampaignDiagnostics GetCampaignDiagnostics (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = GetCampaignDiagnosticsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignDiagnostics</returns>
        public ApiResponse< CampaignDiagnostics > GetCampaignDiagnosticsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignDiagnostics");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignDiagnostics: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignDiagnostics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignDiagnostics> GetCampaignDiagnosticsAsync (string campaignId)
        {
             ApiResponse<CampaignDiagnostics> localVarResponse = await GetCampaignDiagnosticsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign diagnostics 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignDiagnostics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignDiagnostics>> GetCampaignDiagnosticsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignDiagnostics");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignDiagnostics: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignDiagnostics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignDiagnostics>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignDiagnostics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignDiagnostics)));
            
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignProgress</returns>
        public CampaignProgress GetCampaignProgress (string campaignId)
        {
             ApiResponse<CampaignProgress> localVarResponse = GetCampaignProgressWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignProgress</returns>
        public ApiResponse< CampaignProgress > GetCampaignProgressWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignProgress");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignProgress> GetCampaignProgressAsync (string campaignId)
        {
             ApiResponse<CampaignProgress> localVarResponse = await GetCampaignProgressAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get campaign progress 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignProgress)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignProgress>> GetCampaignProgressAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignProgress");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignProgress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignProgress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CampaignStats GetCampaignStats (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = GetCampaignStatsWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignStats</returns>
        public ApiResponse< CampaignStats > GetCampaignStatsWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignStats");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignStats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignStats> GetCampaignStatsAsync (string campaignId)
        {
             ApiResponse<CampaignStats> localVarResponse = await GetCampaignStatsAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get statistics about a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignStats>> GetCampaignStatsAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetCampaignStats");

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
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignStats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCampaignStats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// Get a dialer contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>ContactList</returns>
        public ContactList GetContactlist (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = GetContactlistWithHttpInfo(contactListId, includeImportStatus, includeSize);
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
        public ApiResponse< ContactList > GetContactlistWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlist");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ContactList> GetContactlistAsync (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<ContactList> localVarResponse = await GetContactlistAsyncWithHttpInfo(contactListId, includeImportStatus, includeSize);
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
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> GetContactlistAsyncWithHttpInfo (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlist");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public DialerContact GetContactlistContact (string contactListId, string contactId)
        {
             ApiResponse<DialerContact> localVarResponse = GetContactlistContactWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>ApiResponse of DialerContact</returns>
        public ApiResponse< DialerContact > GetContactlistContactWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetContactlistContact");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DialerContact> GetContactlistContactAsync (string contactListId, string contactId)
        {
             ApiResponse<DialerContact> localVarResponse = await GetContactlistContactAsyncWithHttpInfo(contactListId, contactId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a contact. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="contactId">Contact ID</param>
        /// <returns>Task of ApiResponse (DialerContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DialerContact>> GetContactlistContactAsyncWithHttpInfo (string contactListId, string contactId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->GetContactlistContact");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public ExportUri GetContactlistExport (string contactListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = GetContactlistExportWithHttpInfo(contactListId, download);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        public ApiResponse< ExportUri > GetContactlistExportWithHttpInfo (string contactListId, string download = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ExportUri> GetContactlistExportAsync (string contactListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = await GetContactlistExportAsyncWithHttpInfo(contactListId, download);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URI of a contact list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetContactlistExportAsyncWithHttpInfo (string contactListId, string download = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public ImportStatus GetContactlistImportstatus (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = GetContactlistImportstatusWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetContactlistImportstatusWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistImportstatus");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ImportStatus> GetContactlistImportstatusAsync (string contactListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await GetContactlistImportstatusAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer contactList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetContactlistImportstatusAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->GetContactlistImportstatus");

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
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetContactlistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ImportStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImportStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImportStatus)));
            
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
        /// Get dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="includeImportStatus">Import status (optional, default to false)</param>
        /// <param name="includeSize">Include size (optional, default to false)</param>
        /// <returns>DncList</returns>
        public DncList GetDnclist (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = GetDnclistWithHttpInfo(dncListId, includeImportStatus, includeSize);
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
        public ApiResponse< DncList > GetDnclistWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclist");

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DncList> GetDnclistAsync (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
             ApiResponse<DncList> localVarResponse = await GetDnclistAsyncWithHttpInfo(dncListId, includeImportStatus, includeSize);
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
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> GetDnclistAsyncWithHttpInfo (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclist");

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public ExportUri GetDnclistExport (string dncListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = GetDnclistExportWithHttpInfo(dncListId, download);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>ApiResponse of ExportUri</returns>
        public ApiResponse< ExportUri > GetDnclistExportWithHttpInfo (string dncListId, string download = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ExportUri> GetDnclistExportAsync (string dncListId, string download = null)
        {
             ApiResponse<ExportUri> localVarResponse = await GetDnclistExportAsyncWithHttpInfo(dncListId, download);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the URI of a DNC list export. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="download">Redirect to download uri (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ExportUri)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExportUri>> GetDnclistExportAsyncWithHttpInfo (string dncListId, string download = null)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public ImportStatus GetDnclistImportstatus (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = GetDnclistImportstatusWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of ImportStatus</returns>
        public ApiResponse< ImportStatus > GetDnclistImportstatusWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistImportstatus");

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ImportStatus> GetDnclistImportstatusAsync (string dncListId)
        {
             ApiResponse<ImportStatus> localVarResponse = await GetDnclistImportstatusAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get dialer dncList import status. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (ImportStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImportStatus>> GetDnclistImportstatusAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->GetDnclistImportstatus");

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
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistImportstatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDnclistImportstatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>RuleSet</returns>
        public RuleSet GetRuleset (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = GetRulesetWithHttpInfo(ruleSetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > GetRulesetWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetRuleset");

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
                throw new ApiException (localVarStatusCode, "Error calling GetRuleset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<RuleSet> GetRulesetAsync (string ruleSetId)
        {
             ApiResponse<RuleSet> localVarResponse = await GetRulesetAsyncWithHttpInfo(ruleSetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Rule Set by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> GetRulesetAsyncWithHttpInfo (string ruleSetId)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->GetRuleset");

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
                throw new ApiException (localVarStatusCode, "Error calling GetRuleset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RuleSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RuleSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RuleSet)));
            
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
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>CampaignSchedule</returns>
        public CampaignSchedule GetSchedulesCampaign (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = GetSchedulesCampaignWithHttpInfo(campaignId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > GetSchedulesCampaignWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetSchedulesCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSchedule> GetSchedulesCampaignAsync (string campaignId)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await GetSchedulesCampaignAsyncWithHttpInfo(campaignId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> GetSchedulesCampaignAsyncWithHttpInfo (string campaignId)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->GetSchedulesCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSchedule)));
            
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
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>SequenceSchedule</returns>
        public SequenceSchedule GetSchedulesSequence (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = GetSchedulesSequenceWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > GetSchedulesSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSchedulesSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<SequenceSchedule> GetSchedulesSequenceAsync (string sequenceId)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await GetSchedulesSequenceAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> GetSchedulesSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSchedulesSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SequenceSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SequenceSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SequenceSchedule)));
            
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
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>CampaignSequence</returns>
        public CampaignSequence GetSequence (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = GetSequenceWithHttpInfo(sequenceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > GetSequenceWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling GetSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSequence> GetSequenceAsync (string sequenceId)
        {
             ApiResponse<CampaignSequence> localVarResponse = await GetSequenceAsyncWithHttpInfo(sequenceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a dialer campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> GetSequenceAsyncWithHttpInfo (string sequenceId)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->GetSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling GetSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CampaignSequence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CampaignSequence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignSequence)));
            
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
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ContactCallbackRequest</returns>
        public ContactCallbackRequest PostCampaignCallbackSchedule (string campaignId, ContactCallbackRequest body)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = PostCampaignCallbackScheduleWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>ApiResponse of ContactCallbackRequest</returns>
        public ApiResponse< ContactCallbackRequest > PostCampaignCallbackScheduleWithHttpInfo (string campaignId, ContactCallbackRequest body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostCampaignCallbackSchedule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaignCallbackSchedule");

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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignCallbackSchedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignCallbackSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ContactCallbackRequest> PostCampaignCallbackScheduleAsync (string campaignId, ContactCallbackRequest body)
        {
             ApiResponse<ContactCallbackRequest> localVarResponse = await PostCampaignCallbackScheduleAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Schedule a Callback for a Dialer Campaign 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">ContactCallbackRequest</param>
        /// <returns>Task of ApiResponse (ContactCallbackRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCallbackRequest>> PostCampaignCallbackScheduleAsyncWithHttpInfo (string campaignId, ContactCallbackRequest body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PostCampaignCallbackSchedule");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostCampaignCallbackSchedule");

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
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignCallbackSchedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCampaignCallbackSchedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContactCallbackRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactCallbackRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCallbackRequest)));
            
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
        /// Add contacts to a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">Contact List ID</param>
        /// <param name="body">Contact</param>
        /// <param name="priority">Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional)</param>
        /// <returns>List&lt;DialerContact&gt;</returns>
        public List<DialerContact> PostContactlistContacts (string contactListId, List<DialerContact> body, bool? priority = null)
        {
             ApiResponse<List<DialerContact>> localVarResponse = PostContactlistContactsWithHttpInfo(contactListId, body, priority);
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
        public ApiResponse< List<DialerContact> > PostContactlistContactsWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistContacts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostContactlistContacts");

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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistContacts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<List<DialerContact>> PostContactlistContactsAsync (string contactListId, List<DialerContact> body, bool? priority = null)
        {
             ApiResponse<List<DialerContact>> localVarResponse = await PostContactlistContactsAsyncWithHttpInfo(contactListId, body, priority);
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
        public async System.Threading.Tasks.Task<ApiResponse<List<DialerContact>>> PostContactlistContactsAsyncWithHttpInfo (string contactListId, List<DialerContact> body, bool? priority = null)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistContacts");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostContactlistContacts");

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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistContacts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistContacts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string PostContactlistExport (string contactListId)
        {
             ApiResponse<string> localVarResponse = PostContactlistExportWithHttpInfo(contactListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostContactlistExportWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> PostContactlistExportAsync (string contactListId)
        {
             ApiResponse<string> localVarResponse = await PostContactlistExportAsyncWithHttpInfo(contactListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a contact list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostContactlistExportAsyncWithHttpInfo (string contactListId)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PostContactlistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostContactlistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
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
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns></returns>
        public void PostConversationDnc (string conversationId)
        {
             PostConversationDncWithHttpInfo(conversationId);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationDncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostConversationDnc");

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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDnc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDnc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task PostConversationDncAsync (string conversationId)
        {
             await PostConversationDncAsyncWithHttpInfo(conversationId);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationDncAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling OutboundApi->PostConversationDnc");

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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDnc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDnc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>string</returns>
        public string PostDnclistExport (string dncListId)
        {
             ApiResponse<string> localVarResponse = PostDnclistExportWithHttpInfo(dncListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostDnclistExportWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> PostDnclistExportAsync (string dncListId)
        {
             ApiResponse<string> localVarResponse = await PostDnclistExportAsyncWithHttpInfo(dncListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate the export of a dnc list. Returns 200 if received OK.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostDnclistExportAsyncWithHttpInfo (string dncListId)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistExport");

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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistExport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistExport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public void PostDnclistPhonenumbers (string dncListId, List<string> body)
        {
             PostDnclistPhonenumbersWithHttpInfo(dncListId, body);
        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostDnclistPhonenumbersWithHttpInfo (string dncListId, List<string> body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistPhonenumbers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostDnclistPhonenumbers");

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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistPhonenumbers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistPhonenumbers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task PostDnclistPhonenumbersAsync (string dncListId, List<string> body)
        {
             await PostDnclistPhonenumbersAsyncWithHttpInfo(dncListId, body);

        }

        /// <summary>
        /// Add phone numbers to a Dialer DNC list. Only Internal DNC lists may be appended to
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DNC Phone Numbers</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostDnclistPhonenumbersAsyncWithHttpInfo (string dncListId, List<string> body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PostDnclistPhonenumbers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PostDnclistPhonenumbers");

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
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistPhonenumbers: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDnclistPhonenumbers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>CallableTimeSet</returns>
        public CallableTimeSet PutCallabletimeset (string callableTimeSetId, CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = PutCallabletimesetWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>ApiResponse of CallableTimeSet</returns>
        public ApiResponse< CallableTimeSet > PutCallabletimesetWithHttpInfo (string callableTimeSetId, CallableTimeSet body)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutCallabletimeset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallabletimeset");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimeset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CallableTimeSet> PutCallabletimesetAsync (string callableTimeSetId, CallableTimeSet body)
        {
             ApiResponse<CallableTimeSet> localVarResponse = await PutCallabletimesetAsyncWithHttpInfo(callableTimeSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update callable time set 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callableTimeSetId">Callable Time Set ID</param>
        /// <param name="body">DialerCallableTimeSet</param>
        /// <returns>Task of ApiResponse (CallableTimeSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallableTimeSet>> PutCallabletimesetAsyncWithHttpInfo (string callableTimeSetId, CallableTimeSet body)
        {
            // verify the required parameter 'callableTimeSetId' is set
            if (callableTimeSetId == null)
                throw new ApiException(400, "Missing required parameter 'callableTimeSetId' when calling OutboundApi->PutCallabletimeset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallabletimeset");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimeset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallabletimeset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public ResponseSet PutCallanalysisresponseset (string callAnalysisSetId, ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = PutCallanalysisresponsesetWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>ApiResponse of ResponseSet</returns>
        public ApiResponse< ResponseSet > PutCallanalysisresponsesetWithHttpInfo (string callAnalysisSetId, ResponseSet body)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutCallanalysisresponseset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallanalysisresponseset");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ResponseSet> PutCallanalysisresponsesetAsync (string callAnalysisSetId, ResponseSet body)
        {
             ApiResponse<ResponseSet> localVarResponse = await PutCallanalysisresponsesetAsyncWithHttpInfo(callAnalysisSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a dialer call analysis response set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callAnalysisSetId">Call Analysis Response Set ID</param>
        /// <param name="body">ResponseSet</param>
        /// <returns>Task of ApiResponse (ResponseSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResponseSet>> PutCallanalysisresponsesetAsyncWithHttpInfo (string callAnalysisSetId, ResponseSet body)
        {
            // verify the required parameter 'callAnalysisSetId' is set
            if (callAnalysisSetId == null)
                throw new ApiException(400, "Missing required parameter 'callAnalysisSetId' when calling OutboundApi->PutCallanalysisresponseset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCallanalysisresponseset");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponseset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCallanalysisresponseset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public Campaign PutCampaign (string campaignId, Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = PutCampaignWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>ApiResponse of Campaign</returns>
        public ApiResponse< Campaign > PutCampaignWithHttpInfo (string campaignId, Campaign body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Campaign> PutCampaignAsync (string campaignId, Campaign body)
        {
             ApiResponse<Campaign> localVarResponse = await PutCampaignAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a campaign. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">Campaign</param>
        /// <returns>Task of ApiResponse (Campaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Campaign>> PutCampaignAsyncWithHttpInfo (string campaignId, Campaign body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public string PutCampaignAgent (string campaignId, string userId, Agent body)
        {
             ApiResponse<string> localVarResponse = PutCampaignAgentWithHttpInfo(campaignId, userId, body);
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
        public ApiResponse< string > PutCampaignAgentWithHttpInfo (string campaignId, string userId, Agent body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignAgent");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutCampaignAgent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaignAgent");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignAgent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<string> PutCampaignAgentAsync (string campaignId, string userId, Agent body)
        {
             ApiResponse<string> localVarResponse = await PutCampaignAgentAsyncWithHttpInfo(campaignId, userId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<string>> PutCampaignAgentAsyncWithHttpInfo (string campaignId, string userId, Agent body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutCampaignAgent");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling OutboundApi->PutCampaignAgent");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutCampaignAgent");

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
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignAgent: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCampaignAgent: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public ContactList PutContactlist (string contactListId, ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = PutContactlistWithHttpInfo(contactListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>ApiResponse of ContactList</returns>
        public ApiResponse< ContactList > PutContactlistWithHttpInfo (string contactListId, ContactList body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlist");

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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ContactList> PutContactlistAsync (string contactListId, ContactList body)
        {
             ApiResponse<ContactList> localVarResponse = await PutContactlistAsyncWithHttpInfo(contactListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a contact list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactListId">ContactList ID</param>
        /// <param name="body">ContactList</param>
        /// <returns>Task of ApiResponse (ContactList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactList>> PutContactlistAsyncWithHttpInfo (string contactListId, ContactList body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlist");

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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public DialerContact PutContactlistContact (string contactListId, string contactId, DialerContact body)
        {
             ApiResponse<DialerContact> localVarResponse = PutContactlistContactWithHttpInfo(contactListId, contactId, body);
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
        public ApiResponse< DialerContact > PutContactlistContactWithHttpInfo (string contactListId, string contactId, DialerContact body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutContactlistContact");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlistContact");

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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DialerContact> PutContactlistContactAsync (string contactListId, string contactId, DialerContact body)
        {
             ApiResponse<DialerContact> localVarResponse = await PutContactlistContactAsyncWithHttpInfo(contactListId, contactId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<DialerContact>> PutContactlistContactAsyncWithHttpInfo (string contactListId, string contactId, DialerContact body)
        {
            // verify the required parameter 'contactListId' is set
            if (contactListId == null)
                throw new ApiException(400, "Missing required parameter 'contactListId' when calling OutboundApi->PutContactlistContact");
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling OutboundApi->PutContactlistContact");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutContactlistContact");

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
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistContact: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutContactlistContact: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public DncList PutDnclist (string dncListId, DncList body)
        {
             ApiResponse<DncList> localVarResponse = PutDnclistWithHttpInfo(dncListId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>ApiResponse of DncList</returns>
        public ApiResponse< DncList > PutDnclistWithHttpInfo (string dncListId, DncList body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutDnclist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutDnclist");

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
                throw new ApiException (localVarStatusCode, "Error calling PutDnclist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<DncList> PutDnclistAsync (string dncListId, DncList body)
        {
             ApiResponse<DncList> localVarResponse = await PutDnclistAsyncWithHttpInfo(dncListId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update dialer DNC list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dncListId">DncList ID</param>
        /// <param name="body">DncList</param>
        /// <returns>Task of ApiResponse (DncList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DncList>> PutDnclistAsyncWithHttpInfo (string dncListId, DncList body)
        {
            // verify the required parameter 'dncListId' is set
            if (dncListId == null)
                throw new ApiException(400, "Missing required parameter 'dncListId' when calling OutboundApi->PutDnclist");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutDnclist");

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
                throw new ApiException (localVarStatusCode, "Error calling PutDnclist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDnclist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public RuleSet PutRuleset (string ruleSetId, RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = PutRulesetWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>ApiResponse of RuleSet</returns>
        public ApiResponse< RuleSet > PutRulesetWithHttpInfo (string ruleSetId, RuleSet body)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutRuleset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutRuleset");

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
                throw new ApiException (localVarStatusCode, "Error calling PutRuleset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<RuleSet> PutRulesetAsync (string ruleSetId, RuleSet body)
        {
             ApiResponse<RuleSet> localVarResponse = await PutRulesetAsyncWithHttpInfo(ruleSetId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a RuleSet. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleSetId">Rule Set ID</param>
        /// <param name="body">RuleSet</param>
        /// <returns>Task of ApiResponse (RuleSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RuleSet>> PutRulesetAsyncWithHttpInfo (string ruleSetId, RuleSet body)
        {
            // verify the required parameter 'ruleSetId' is set
            if (ruleSetId == null)
                throw new ApiException(400, "Missing required parameter 'ruleSetId' when calling OutboundApi->PutRuleset");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutRuleset");

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
                throw new ApiException (localVarStatusCode, "Error calling PutRuleset: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRuleset: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CampaignSchedule PutSchedulesCampaign (string campaignId, CampaignSchedule body)
        {
             ApiResponse<CampaignSchedule> localVarResponse = PutSchedulesCampaignWithHttpInfo(campaignId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>ApiResponse of CampaignSchedule</returns>
        public ApiResponse< CampaignSchedule > PutSchedulesCampaignWithHttpInfo (string campaignId, CampaignSchedule body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutSchedulesCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSchedule> PutSchedulesCampaignAsync (string campaignId, CampaignSchedule body)
        {
             ApiResponse<CampaignSchedule> localVarResponse = await PutSchedulesCampaignAsyncWithHttpInfo(campaignId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignId">Campaign ID</param>
        /// <param name="body">CampaignSchedule</param>
        /// <returns>Task of ApiResponse (CampaignSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSchedule>> PutSchedulesCampaignAsyncWithHttpInfo (string campaignId, CampaignSchedule body)
        {
            // verify the required parameter 'campaignId' is set
            if (campaignId == null)
                throw new ApiException(400, "Missing required parameter 'campaignId' when calling OutboundApi->PutSchedulesCampaign");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesCampaign");

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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaign: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesCampaign: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public SequenceSchedule PutSchedulesSequence (string sequenceId, SequenceSchedule body)
        {
             ApiResponse<SequenceSchedule> localVarResponse = PutSchedulesSequenceWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>ApiResponse of SequenceSchedule</returns>
        public ApiResponse< SequenceSchedule > PutSchedulesSequenceWithHttpInfo (string sequenceId, SequenceSchedule body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSchedulesSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<SequenceSchedule> PutSchedulesSequenceAsync (string sequenceId, SequenceSchedule body)
        {
             ApiResponse<SequenceSchedule> localVarResponse = await PutSchedulesSequenceAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new sequence schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Sequence ID</param>
        /// <param name="body">SequenceSchedule</param>
        /// <returns>Task of ApiResponse (SequenceSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SequenceSchedule>> PutSchedulesSequenceAsyncWithHttpInfo (string sequenceId, SequenceSchedule body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSchedulesSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSchedulesSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public CampaignSequence PutSequence (string sequenceId, CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = PutSequenceWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of CampaignSequence</returns>
        public ApiResponse< CampaignSequence > PutSequenceWithHttpInfo (string sequenceId, CampaignSequence body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling PutSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<CampaignSequence> PutSequenceAsync (string sequenceId, CampaignSequence body)
        {
             ApiResponse<CampaignSequence> localVarResponse = await PutSequenceAsyncWithHttpInfo(sequenceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a new campaign sequence. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sequenceId">Campaign Sequence ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (CampaignSequence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignSequence>> PutSequenceAsyncWithHttpInfo (string sequenceId, CampaignSequence body)
        {
            // verify the required parameter 'sequenceId' is set
            if (sequenceId == null)
                throw new ApiException(400, "Missing required parameter 'sequenceId' when calling OutboundApi->PutSequence");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OutboundApi->PutSequence");

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
                throw new ApiException (localVarStatusCode, "Error calling PutSequence: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSequence: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
