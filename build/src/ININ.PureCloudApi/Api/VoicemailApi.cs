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
    public interface IVoicemailApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string DeleteMessages ();

        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMessagesWithHttpInfo ();
        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>string</returns>
        string DeleteMessagesMessageId (string messageId);

        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMessagesMessageIdWithHttpInfo (string messageId);
        /// <summary>
        /// Get the group&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>VoicemailMailboxInfo</returns>
        VoicemailMailboxInfo GetGroupsGroupIdMailbox (string groupId);

        /// <summary>
        /// Get the group&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        ApiResponse<VoicemailMailboxInfo> GetGroupsGroupIdMailboxWithHttpInfo (string groupId);
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>VoicemailMessageEntityListing</returns>
        VoicemailMessageEntityListing GetGroupsGroupIdMessages (string groupId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        ApiResponse<VoicemailMessageEntityListing> GetGroupsGroupIdMessagesWithHttpInfo (string groupId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>VoicemailGroupPolicy</returns>
        VoicemailGroupPolicy GetGroupsGroupIdPolicy (string groupId);

        /// <summary>
        /// Get a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>ApiResponse of VoicemailGroupPolicy</returns>
        ApiResponse<VoicemailGroupPolicy> GetGroupsGroupIdPolicyWithHttpInfo (string groupId);
        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailMailboxInfo</returns>
        VoicemailMailboxInfo GetMailbox ();

        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        ApiResponse<VoicemailMailboxInfo> GetMailboxWithHttpInfo ();
        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailMailboxInfo</returns>
        VoicemailMailboxInfo GetMeMailbox ();

        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        ApiResponse<VoicemailMailboxInfo> GetMeMailboxWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>VoicemailMessageEntityListing</returns>
        VoicemailMessageEntityListing GetMeMessages (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        ApiResponse<VoicemailMessageEntityListing> GetMeMessagesWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy GetMePolicy ();

        /// <summary>
        /// Get the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> GetMePolicyWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>VoicemailMessageEntityListing</returns>
        VoicemailMessageEntityListing GetMessages (string ids = null);

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        ApiResponse<VoicemailMessageEntityListing> GetMessagesWithHttpInfo (string ids = null);
        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage GetMessagesMessageId (string messageId);

        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> GetMessagesMessageIdWithHttpInfo (string messageId);
        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>VoicemailMediaInfo</returns>
        VoicemailMediaInfo GetMessagesMessageIdMedia (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        ApiResponse<VoicemailMediaInfo> GetMessagesMessageIdMediaWithHttpInfo (string messageId, string formatId = null);
        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy GetPolicy ();

        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> GetPolicyWithHttpInfo ();
        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>VoicemailsSearchResponse</returns>
        VoicemailsSearchResponse GetSearch (string q64, List<string> expand = null);

        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>ApiResponse of VoicemailsSearchResponse</returns>
        ApiResponse<VoicemailsSearchResponse> GetSearchWithHttpInfo (string q64, List<string> expand = null);
        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy GetUserpoliciesUserId (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> GetUserpoliciesUserIdWithHttpInfo (string userId);
        /// <summary>
        /// Update a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>VoicemailGroupPolicy</returns>
        VoicemailGroupPolicy PatchGroupsGroupIdPolicy (string groupId, VoicemailGroupPolicy body);

        /// <summary>
        /// Update a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailGroupPolicy</returns>
        ApiResponse<VoicemailGroupPolicy> PatchGroupsGroupIdPolicyWithHttpInfo (string groupId, VoicemailGroupPolicy body);
        /// <summary>
        /// Update the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy PatchMePolicy (VoicemailUserPolicy body);

        /// <summary>
        /// Update the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> PatchMePolicyWithHttpInfo (VoicemailUserPolicy body);
        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy PatchUserpoliciesUserId (string userId, VoicemailUserPolicy body);

        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> PatchUserpoliciesUserIdWithHttpInfo (string userId, VoicemailUserPolicy body);
        /// <summary>
        /// Copy a voicemail message to a user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage PostMessages (CopyVoicemailMessage body = null);

        /// <summary>
        /// Copy a voicemail message to a user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> PostMessagesWithHttpInfo (CopyVoicemailMessage body = null);
        /// <summary>
        /// Search voicemails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>VoicemailsSearchResponse</returns>
        VoicemailsSearchResponse PostSearch (VoicemailSearchRequest body);

        /// <summary>
        /// Search voicemails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of VoicemailsSearchResponse</returns>
        ApiResponse<VoicemailsSearchResponse> PostSearchWithHttpInfo (VoicemailSearchRequest body);
        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage PutMessagesMessageId (string messageId, VoicemailMessage body);

        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> PutMessagesMessageIdWithHttpInfo (string messageId, VoicemailMessage body);
        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy PutPolicy (VoicemailOrganizationPolicy body);

        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> PutPolicyWithHttpInfo (VoicemailOrganizationPolicy body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMessagesAsync ();

        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesAsyncWithHttpInfo ();
        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMessagesMessageIdAsync (string messageId);

        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesMessageIdAsyncWithHttpInfo (string messageId);
        /// <summary>
        /// Get the group&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        System.Threading.Tasks.Task<VoicemailMailboxInfo> GetGroupsGroupIdMailboxAsync (string groupId);

        /// <summary>
        /// Get the group&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetGroupsGroupIdMailboxAsyncWithHttpInfo (string groupId);
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetGroupsGroupIdMessagesAsync (string groupId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetGroupsGroupIdMessagesAsyncWithHttpInfo (string groupId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>Task of VoicemailGroupPolicy</returns>
        System.Threading.Tasks.Task<VoicemailGroupPolicy> GetGroupsGroupIdPolicyAsync (string groupId);

        /// <summary>
        /// Get a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>Task of ApiResponse (VoicemailGroupPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailGroupPolicy>> GetGroupsGroupIdPolicyAsyncWithHttpInfo (string groupId);
        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMailboxAsync ();

        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMailboxAsyncWithHttpInfo ();
        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMeMailboxAsync ();

        /// <summary>
        /// Get the current user&#39;s mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMeMailboxAsyncWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMeMessagesAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMeMessagesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> GetMePolicyAsync ();

        /// <summary>
        /// Get the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetMePolicyAsyncWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMessagesAsync (string ids = null);

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMessagesAsyncWithHttpInfo (string ids = null);
        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> GetMessagesMessageIdAsync (string messageId);

        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> GetMessagesMessageIdAsyncWithHttpInfo (string messageId);
        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        System.Threading.Tasks.Task<VoicemailMediaInfo> GetMessagesMessageIdMediaAsync (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> GetMessagesMessageIdMediaAsyncWithHttpInfo (string messageId, string formatId = null);
        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> GetPolicyAsync ();

        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> GetPolicyAsyncWithHttpInfo ();
        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of VoicemailsSearchResponse</returns>
        System.Threading.Tasks.Task<VoicemailsSearchResponse> GetSearchAsync (string q64, List<string> expand = null);

        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailsSearchResponse>> GetSearchAsyncWithHttpInfo (string q64, List<string> expand = null);
        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> GetUserpoliciesUserIdAsync (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetUserpoliciesUserIdAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Update a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailGroupPolicy</returns>
        System.Threading.Tasks.Task<VoicemailGroupPolicy> PatchGroupsGroupIdPolicyAsync (string groupId, VoicemailGroupPolicy body);

        /// <summary>
        /// Update a group&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailGroupPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailGroupPolicy>> PatchGroupsGroupIdPolicyAsyncWithHttpInfo (string groupId, VoicemailGroupPolicy body);
        /// <summary>
        /// Update the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> PatchMePolicyAsync (VoicemailUserPolicy body);

        /// <summary>
        /// Update the current user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchMePolicyAsyncWithHttpInfo (VoicemailUserPolicy body);
        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> PatchUserpoliciesUserIdAsync (string userId, VoicemailUserPolicy body);

        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchUserpoliciesUserIdAsyncWithHttpInfo (string userId, VoicemailUserPolicy body);
        /// <summary>
        /// Copy a voicemail message to a user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> PostMessagesAsync (CopyVoicemailMessage body = null);

        /// <summary>
        /// Copy a voicemail message to a user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PostMessagesAsyncWithHttpInfo (CopyVoicemailMessage body = null);
        /// <summary>
        /// Search voicemails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of VoicemailsSearchResponse</returns>
        System.Threading.Tasks.Task<VoicemailsSearchResponse> PostSearchAsync (VoicemailSearchRequest body);

        /// <summary>
        /// Search voicemails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailsSearchResponse>> PostSearchAsyncWithHttpInfo (VoicemailSearchRequest body);
        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> PutMessagesMessageIdAsync (string messageId, VoicemailMessage body);

        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PutMessagesMessageIdAsyncWithHttpInfo (string messageId, VoicemailMessage body);
        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> PutPolicyAsync (VoicemailOrganizationPolicy body);

        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> PutPolicyAsyncWithHttpInfo (VoicemailOrganizationPolicy body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VoicemailApi : IVoicemailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoicemailApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VoicemailApi(Configuration configuration = null)
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
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string DeleteMessages ()
        {
             ApiResponse<string> localVarResponse = DeleteMessagesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMessagesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMessagesAsync ()
        {
             ApiResponse<string> localVarResponse = await DeleteMessagesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>string</returns>
        public string DeleteMessagesMessageId (string messageId)
        {
             ApiResponse<string> localVarResponse = DeleteMessagesMessageIdWithHttpInfo(messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMessagesMessageIdWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->DeleteMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMessagesMessageIdAsync (string messageId)
        {
             ApiResponse<string> localVarResponse = await DeleteMessagesMessageIdAsyncWithHttpInfo(messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesMessageIdAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->DeleteMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get the group&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>VoicemailMailboxInfo</returns>
        public VoicemailMailboxInfo GetGroupsGroupIdMailbox (string groupId)
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = GetGroupsGroupIdMailboxWithHttpInfo(groupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the group&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        public ApiResponse< VoicemailMailboxInfo > GetGroupsGroupIdMailboxWithHttpInfo (string groupId)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->GetGroupsGroupIdMailbox");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/mailbox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMailbox: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
            
        }

        /// <summary>
        /// Get the group&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMailboxInfo> GetGroupsGroupIdMailboxAsync (string groupId)
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = await GetGroupsGroupIdMailboxAsyncWithHttpInfo(groupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the group&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">groupId</param>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetGroupsGroupIdMailboxAsyncWithHttpInfo (string groupId)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->GetGroupsGroupIdMailbox");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/mailbox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMailbox: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>VoicemailMessageEntityListing</returns>
        public VoicemailMessageEntityListing GetGroupsGroupIdMessages (string groupId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = GetGroupsGroupIdMessagesWithHttpInfo(groupId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        public ApiResponse< VoicemailMessageEntityListing > GetGroupsGroupIdMessagesWithHttpInfo (string groupId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->GetGroupsGroupIdMessages");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        public async System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetGroupsGroupIdMessagesAsync (string groupId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = await GetGroupsGroupIdMessagesAsyncWithHttpInfo(groupId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetGroupsGroupIdMessagesAsyncWithHttpInfo (string groupId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->GetGroupsGroupIdMessages");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
            
        }

        /// <summary>
        /// Get a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>VoicemailGroupPolicy</returns>
        public VoicemailGroupPolicy GetGroupsGroupIdPolicy (string groupId)
        {
             ApiResponse<VoicemailGroupPolicy> localVarResponse = GetGroupsGroupIdPolicyWithHttpInfo(groupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>ApiResponse of VoicemailGroupPolicy</returns>
        public ApiResponse< VoicemailGroupPolicy > GetGroupsGroupIdPolicyWithHttpInfo (string groupId)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->GetGroupsGroupIdPolicy");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailGroupPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailGroupPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailGroupPolicy)));
            
        }

        /// <summary>
        /// Get a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>Task of VoicemailGroupPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailGroupPolicy> GetGroupsGroupIdPolicyAsync (string groupId)
        {
             ApiResponse<VoicemailGroupPolicy> localVarResponse = await GetGroupsGroupIdPolicyAsyncWithHttpInfo(groupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <returns>Task of ApiResponse (VoicemailGroupPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailGroupPolicy>> GetGroupsGroupIdPolicyAsyncWithHttpInfo (string groupId)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->GetGroupsGroupIdPolicy");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGroupsGroupIdPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailGroupPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailGroupPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailGroupPolicy)));
            
        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailMailboxInfo</returns>
        public VoicemailMailboxInfo GetMailbox ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = GetMailboxWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        public ApiResponse< VoicemailMailboxInfo > GetMailboxWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/mailbox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
            
        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMailboxAsync ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = await GetMailboxAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMailboxAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/mailbox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
            
        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailMailboxInfo</returns>
        public VoicemailMailboxInfo GetMeMailbox ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = GetMeMailboxWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        public ApiResponse< VoicemailMailboxInfo > GetMeMailboxWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/me/mailbox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMailbox: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
            
        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMeMailboxAsync ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = await GetMeMailboxAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the current user&#39;s mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMeMailboxAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/me/mailbox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMailbox: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>VoicemailMessageEntityListing</returns>
        public VoicemailMessageEntityListing GetMeMessages (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = GetMeMessagesWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        public ApiResponse< VoicemailMessageEntityListing > GetMeMessagesWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/voicemail/me/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        public async System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMeMessagesAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = await GetMeMessagesAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMeMessagesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/voicemail/me/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMeMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
            
        }

        /// <summary>
        /// Get the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy GetMePolicy ()
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = GetMePolicyWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > GetMePolicyWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/me/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMePolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMePolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Get the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> GetMePolicyAsync ()
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await GetMePolicyAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetMePolicyAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/me/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMePolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMePolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>VoicemailMessageEntityListing</returns>
        public VoicemailMessageEntityListing GetMessages (string ids = null)
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = GetMessagesWithHttpInfo(ids);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        public ApiResponse< VoicemailMessageEntityListing > GetMessagesWithHttpInfo (string ids = null)
        {

            var localVarPath = "/api/v2/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        public async System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMessagesAsync (string ids = null)
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = await GetMessagesAsyncWithHttpInfo(ids);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">An optional comma separated list of VoicemailMessage ids (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMessagesAsyncWithHttpInfo (string ids = null)
        {

            var localVarPath = "/api/v2/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
            
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage GetMessagesMessageId (string messageId)
        {
             ApiResponse<VoicemailMessage> localVarResponse = GetMessagesMessageIdWithHttpInfo(messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > GetMessagesMessageIdWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
            
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> GetMessagesMessageIdAsync (string messageId)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await GetMessagesMessageIdAsyncWithHttpInfo(messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> GetMessagesMessageIdAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
            
        }

        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>VoicemailMediaInfo</returns>
        public VoicemailMediaInfo GetMessagesMessageIdMedia (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> localVarResponse = GetMessagesMessageIdMediaWithHttpInfo(messageId, formatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        public ApiResponse< VoicemailMediaInfo > GetMessagesMessageIdMediaWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageIdMedia");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}/media";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMediaInfo)));
            
        }

        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMediaInfo> GetMessagesMessageIdMediaAsync (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> localVarResponse = await GetMessagesMessageIdMediaAsyncWithHttpInfo(messageId, formatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> GetMessagesMessageIdMediaAsyncWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageIdMedia");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}/media";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMediaInfo)));
            
        }

        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy GetPolicy ()
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = GetPolicyWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > GetPolicyWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
            
        }

        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> GetPolicyAsync ()
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = await GetPolicyAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> GetPolicyAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
            
        }

        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>VoicemailsSearchResponse</returns>
        public VoicemailsSearchResponse GetSearch (string q64, List<string> expand = null)
        {
             ApiResponse<VoicemailsSearchResponse> localVarResponse = GetSearchWithHttpInfo(q64, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>ApiResponse of VoicemailsSearchResponse</returns>
        public ApiResponse< VoicemailsSearchResponse > GetSearchWithHttpInfo (string q64, List<string> expand = null)
        {
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling VoicemailApi->GetSearch");

            var localVarPath = "/api/v2/voicemail/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (VoicemailsSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)));
            
        }

        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of VoicemailsSearchResponse</returns>
        public async System.Threading.Tasks.Task<VoicemailsSearchResponse> GetSearchAsync (string q64, List<string> expand = null)
        {
             ApiResponse<VoicemailsSearchResponse> localVarResponse = await GetSearchAsyncWithHttpInfo(q64, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search voicemails using the q64 value returned from a previous search 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="q64">q64</param>
        /// <param name="expand">expand (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailsSearchResponse>> GetSearchAsyncWithHttpInfo (string q64, List<string> expand = null)
        {
            // verify the required parameter 'q64' is set
            if (q64 == null)
                throw new ApiException(400, "Missing required parameter 'q64' when calling VoicemailApi->GetSearch");

            var localVarPath = "/api/v2/voicemail/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (q64 != null) localVarQueryParams.Add("q64", Configuration.ApiClient.ParameterToString(q64)); // query parameter
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (VoicemailsSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)));
            
        }

        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy GetUserpoliciesUserId (string userId)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = GetUserpoliciesUserIdWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > GetUserpoliciesUserIdWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->GetUserpoliciesUserId");

            var localVarPath = "/api/v2/voicemail/userpolicies/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> GetUserpoliciesUserIdAsync (string userId)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await GetUserpoliciesUserIdAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetUserpoliciesUserIdAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->GetUserpoliciesUserId");

            var localVarPath = "/api/v2/voicemail/userpolicies/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Update a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>VoicemailGroupPolicy</returns>
        public VoicemailGroupPolicy PatchGroupsGroupIdPolicy (string groupId, VoicemailGroupPolicy body)
        {
             ApiResponse<VoicemailGroupPolicy> localVarResponse = PatchGroupsGroupIdPolicyWithHttpInfo(groupId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailGroupPolicy</returns>
        public ApiResponse< VoicemailGroupPolicy > PatchGroupsGroupIdPolicyWithHttpInfo (string groupId, VoicemailGroupPolicy body)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->PatchGroupsGroupIdPolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchGroupsGroupIdPolicy");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchGroupsGroupIdPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchGroupsGroupIdPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailGroupPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailGroupPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailGroupPolicy)));
            
        }

        /// <summary>
        /// Update a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailGroupPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailGroupPolicy> PatchGroupsGroupIdPolicyAsync (string groupId, VoicemailGroupPolicy body)
        {
             ApiResponse<VoicemailGroupPolicy> localVarResponse = await PatchGroupsGroupIdPolicyAsyncWithHttpInfo(groupId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a group&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId">Group ID</param>
        /// <param name="body">The group&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailGroupPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailGroupPolicy>> PatchGroupsGroupIdPolicyAsyncWithHttpInfo (string groupId, VoicemailGroupPolicy body)
        {
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling VoicemailApi->PatchGroupsGroupIdPolicy");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchGroupsGroupIdPolicy");

            var localVarPath = "/api/v2/voicemail/groups/{groupId}/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (groupId != null) localVarPathParams.Add("groupId", Configuration.ApiClient.ParameterToString(groupId)); // path parameter
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchGroupsGroupIdPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchGroupsGroupIdPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailGroupPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailGroupPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailGroupPolicy)));
            
        }

        /// <summary>
        /// Update the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy PatchMePolicy (VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = PatchMePolicyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > PatchMePolicyWithHttpInfo (VoicemailUserPolicy body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchMePolicy");

            var localVarPath = "/api/v2/voicemail/me/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMePolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMePolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Update the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> PatchMePolicyAsync (VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await PatchMePolicyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the current user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchMePolicyAsyncWithHttpInfo (VoicemailUserPolicy body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchMePolicy");

            var localVarPath = "/api/v2/voicemail/me/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMePolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMePolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy PatchUserpoliciesUserId (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = PatchUserpoliciesUserIdWithHttpInfo(userId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > PatchUserpoliciesUserIdWithHttpInfo (string userId, VoicemailUserPolicy body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->PatchUserpoliciesUserId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchUserpoliciesUserId");

            var localVarPath = "/api/v2/voicemail/userpolicies/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> PatchUserpoliciesUserIdAsync (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await PatchUserpoliciesUserIdAsyncWithHttpInfo(userId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchUserpoliciesUserIdAsyncWithHttpInfo (string userId, VoicemailUserPolicy body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->PatchUserpoliciesUserId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchUserpoliciesUserId");

            var localVarPath = "/api/v2/voicemail/userpolicies/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
            
        }

        /// <summary>
        /// Copy a voicemail message to a user or group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage PostMessages (CopyVoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> localVarResponse = PostMessagesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Copy a voicemail message to a user or group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > PostMessagesWithHttpInfo (CopyVoicemailMessage body = null)
        {

            var localVarPath = "/api/v2/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
            
        }

        /// <summary>
        /// Copy a voicemail message to a user or group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> PostMessagesAsync (CopyVoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await PostMessagesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Copy a voicemail message to a user or group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PostMessagesAsyncWithHttpInfo (CopyVoicemailMessage body = null)
        {

            var localVarPath = "/api/v2/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
            
        }

        /// <summary>
        /// Search voicemails 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>VoicemailsSearchResponse</returns>
        public VoicemailsSearchResponse PostSearch (VoicemailSearchRequest body)
        {
             ApiResponse<VoicemailsSearchResponse> localVarResponse = PostSearchWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search voicemails 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of VoicemailsSearchResponse</returns>
        public ApiResponse< VoicemailsSearchResponse > PostSearchWithHttpInfo (VoicemailSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PostSearch");

            var localVarPath = "/api/v2/voicemail/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (VoicemailsSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)));
            
        }

        /// <summary>
        /// Search voicemails 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of VoicemailsSearchResponse</returns>
        public async System.Threading.Tasks.Task<VoicemailsSearchResponse> PostSearchAsync (VoicemailSearchRequest body)
        {
             ApiResponse<VoicemailsSearchResponse> localVarResponse = await PostSearchAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search voicemails 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (VoicemailsSearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailsSearchResponse>> PostSearchAsyncWithHttpInfo (VoicemailSearchRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PostSearch");

            var localVarPath = "/api/v2/voicemail/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSearch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailsSearchResponse>(localVarStatusCode,
                localVarHeaders,
                (VoicemailsSearchResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailsSearchResponse)));
            
        }

        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage PutMessagesMessageId (string messageId, VoicemailMessage body)
        {
             ApiResponse<VoicemailMessage> localVarResponse = PutMessagesMessageIdWithHttpInfo(messageId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > PutMessagesMessageIdWithHttpInfo (string messageId, VoicemailMessage body)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->PutMessagesMessageId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PutMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
            
        }

        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> PutMessagesMessageIdAsync (string messageId, VoicemailMessage body)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await PutMessagesMessageIdAsyncWithHttpInfo(messageId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PutMessagesMessageIdAsyncWithHttpInfo (string messageId, VoicemailMessage body)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->PutMessagesMessageId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PutMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarHeaders,
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
            
        }

        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy PutPolicy (VoicemailOrganizationPolicy body)
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = PutPolicyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > PutPolicyWithHttpInfo (VoicemailOrganizationPolicy body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PutPolicy");

            var localVarPath = "/api/v2/voicemail/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
            
        }

        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> PutPolicyAsync (VoicemailOrganizationPolicy body)
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = await PutPolicyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> PutPolicyAsyncWithHttpInfo (VoicemailOrganizationPolicy body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PutPolicy");

            var localVarPath = "/api/v2/voicemail/policy";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarHeaders,
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
            
        }

    }
}
