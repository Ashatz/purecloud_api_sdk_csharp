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
    public interface IVoicemailApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy ConfigurationUservoicemailpoliciesUseridGet (string userId);
=======
        /// <returns>string</returns>
        string DeleteMessages ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> ConfigurationUservoicemailpoliciesUseridGetWithHttpInfo (string userId);
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy ConfigurationUservoicemailpoliciesUseridPatch (string userId, VoicemailUserPolicy body);
=======
        /// <returns>VoicemailMailboxInfo</returns>
        VoicemailMailboxInfo GetMailbox ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> ConfigurationUservoicemailpoliciesUseridPatchWithHttpInfo (string userId, VoicemailUserPolicy body);
        /// <summary>
        /// Get a policy
=======
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        ApiResponse<VoicemailMailboxInfo> GetMailboxWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy ConfigurationVoicemailpolicyGet ();

        /// <summary>
        /// Get a policy
=======
        /// <returns>VoicemailMessageEntityListing</returns>
        VoicemailMessageEntityListing GetMessages ();

        /// <summary>
        /// List voicemail messages
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> ConfigurationVoicemailpolicyGetWithHttpInfo ();
        /// <summary>
        /// Update a policy
=======
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        ApiResponse<VoicemailMessageEntityListing> GetMessagesWithHttpInfo ();
        /// <summary>
        /// Get message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy ConfigurationVoicemailpolicyPut (VoicemailOrganizationPolicy body = null);

        /// <summary>
        /// Update a policy
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage GetMessagesMessageId (string messageId);

        /// <summary>
        /// Get message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> ConfigurationVoicemailpolicyPutWithHttpInfo (VoicemailOrganizationPolicy body = null);
        /// <summary>
        /// Get mailbox information
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> GetMessagesMessageIdWithHttpInfo (string messageId);
        /// <summary>
        /// Get media playback URI for this message
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>VoicemailMailboxInfo</returns>
        VoicemailMailboxInfo VoicemailMailboxGet ();

        /// <summary>
        /// Get mailbox information
=======
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>VoicemailMediaInfo</returns>
        VoicemailMediaInfo GetMessagesMessageIdMedia (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        ApiResponse<VoicemailMailboxInfo> VoicemailMailboxGetWithHttpInfo ();
        /// <summary>
        /// Delete all voicemail messages
=======
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        ApiResponse<VoicemailMediaInfo> GetMessagesMessageIdMediaWithHttpInfo (string messageId, string formatId = null);
        /// <summary>
        /// Get a policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>string</returns>
        string VoicemailMessagesDelete ();

        /// <summary>
        /// Delete all voicemail messages
=======
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy GetPolicy ();

        /// <summary>
        /// Get a policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VoicemailMessagesDeleteWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
=======
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> GetPolicyWithHttpInfo ();
        /// <summary>
        /// Get a user&#39;s voicemail policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>VoicemailMessageEntityListing</returns>
        VoicemailMessageEntityListing VoicemailMessagesGet ();

        /// <summary>
        /// List voicemail messages
=======
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy GetUserpoliciesUserId (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        ApiResponse<VoicemailMessageEntityListing> VoicemailMessagesGetWithHttpInfo ();
        /// <summary>
        /// Delete a message.
=======
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> GetUserpoliciesUserIdWithHttpInfo (string userId);
        /// <summary>
        /// Update a user&#39;s voicemail policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <returns>string</returns>
        string VoicemailMessagesMessageidDelete (string messageId);

        /// <summary>
        /// Delete a message.
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy PatchUserpoliciesUserId (string userId, VoicemailUserPolicy body);

        /// <summary>
        /// Update a user&#39;s voicemail policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VoicemailMessagesMessageidDeleteWithHttpInfo (string messageId);
        /// <summary>
        /// Get message.
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> PatchUserpoliciesUserIdWithHttpInfo (string userId, VoicemailUserPolicy body);
        /// <summary>
        /// Update a message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
<<<<<<< HEAD
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage VoicemailMessagesMessageidGet (string messageId);

        /// <summary>
        /// Get message.
=======
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage PutMessagesMessageId (string messageId, VoicemailMessage body = null);

        /// <summary>
        /// Update a message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
<<<<<<< HEAD
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> VoicemailMessagesMessageidGetWithHttpInfo (string messageId);
        /// <summary>
        /// Get media playback URI for this message
=======
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> PutMessagesMessageIdWithHttpInfo (string messageId, VoicemailMessage body = null);
        /// <summary>
        /// Update a policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>VoicemailMediaInfo</returns>
        VoicemailMediaInfo VoicemailMessagesMessageidMediaGet (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
=======
        /// <param name="body">Policy (optional)</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy PutPolicy (VoicemailOrganizationPolicy body = null);

        /// <summary>
        /// Update a policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        ApiResponse<VoicemailMediaInfo> VoicemailMessagesMessageidMediaGetWithHttpInfo (string messageId, string formatId = null);
        /// <summary>
        /// Update a message.
=======
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> PutPolicyWithHttpInfo (VoicemailOrganizationPolicy body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete all voicemail messages
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage VoicemailMessagesMessageidPut (string messageId, VoicemailMessage body = null);

        /// <summary>
        /// Update a message.
=======
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMessagesAsync ();

        /// <summary>
        /// Delete all voicemail messages
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> VoicemailMessagesMessageidPutWithHttpInfo (string messageId, VoicemailMessage body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a user&#39;s voicemail policy
=======
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesAsyncWithHttpInfo ();
        /// <summary>
        /// Delete a message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> ConfigurationUservoicemailpoliciesUseridGetAsync (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMessagesMessageIdAsync (string messageId);

        /// <summary>
        /// Delete a message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> ConfigurationUservoicemailpoliciesUseridGetAsyncWithHttpInfo (string userId);
        /// <summary>
        /// Update a user&#39;s voicemail policy
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesMessageIdAsyncWithHttpInfo (string messageId);
        /// <summary>
        /// Get mailbox information
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> ConfigurationUservoicemailpoliciesUseridPatchAsync (string userId, VoicemailUserPolicy body);

        /// <summary>
        /// Update a user&#39;s voicemail policy
=======
        /// <returns>Task of VoicemailMailboxInfo</returns>
        System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMailboxAsync ();

        /// <summary>
        /// Get mailbox information
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> ConfigurationUservoicemailpoliciesUseridPatchAsyncWithHttpInfo (string userId, VoicemailUserPolicy body);
        /// <summary>
        /// Get a policy
=======
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMailboxAsyncWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> ConfigurationVoicemailpolicyGetAsync ();

        /// <summary>
        /// Get a policy
=======
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMessagesAsync ();

        /// <summary>
        /// List voicemail messages
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> ConfigurationVoicemailpolicyGetAsyncWithHttpInfo ();
=======
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMessagesAsyncWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> ConfigurationVoicemailpolicyPutAsync (VoicemailOrganizationPolicy body = null);
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> GetMessagesMessageIdAsync (string messageId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> ConfigurationVoicemailpolicyPutAsyncWithHttpInfo (VoicemailOrganizationPolicy body = null);
        /// <summary>
        /// Get mailbox information
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> GetMessagesMessageIdAsyncWithHttpInfo (string messageId);
        /// <summary>
        /// Get media playback URI for this message
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of VoicemailMailboxInfo</returns>
        System.Threading.Tasks.Task<VoicemailMailboxInfo> VoicemailMailboxGetAsync ();

        /// <summary>
        /// Get mailbox information
=======
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        System.Threading.Tasks.Task<VoicemailMediaInfo> GetMessagesMessageIdMediaAsync (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> VoicemailMailboxGetAsyncWithHttpInfo ();
        /// <summary>
        /// Delete all voicemail messages
=======
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> GetMessagesMessageIdMediaAsyncWithHttpInfo (string messageId, string formatId = null);
        /// <summary>
        /// Get a policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VoicemailMessagesDeleteAsync ();

        /// <summary>
        /// Delete all voicemail messages
=======
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> GetPolicyAsync ();

        /// <summary>
        /// Get a policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VoicemailMessagesDeleteAsyncWithHttpInfo ();
        /// <summary>
        /// List voicemail messages
=======
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> GetPolicyAsyncWithHttpInfo ();
        /// <summary>
        /// Get a user&#39;s voicemail policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        System.Threading.Tasks.Task<VoicemailMessageEntityListing> VoicemailMessagesGetAsync ();

        /// <summary>
        /// List voicemail messages
=======
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> GetUserpoliciesUserIdAsync (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> VoicemailMessagesGetAsyncWithHttpInfo ();
=======
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetUserpoliciesUserIdAsyncWithHttpInfo (string userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VoicemailMessagesMessageidDeleteAsync (string messageId);
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> PatchUserpoliciesUserIdAsync (string userId, VoicemailUserPolicy body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VoicemailMessagesMessageidDeleteAsyncWithHttpInfo (string messageId);
        /// <summary>
        /// Get message.
=======
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchUserpoliciesUserIdAsyncWithHttpInfo (string userId, VoicemailUserPolicy body);
        /// <summary>
        /// Update a message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
<<<<<<< HEAD
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> VoicemailMessagesMessageidGetAsync (string messageId);

        /// <summary>
        /// Get message.
=======
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> PutMessagesMessageIdAsync (string messageId, VoicemailMessage body = null);

        /// <summary>
        /// Update a message.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> VoicemailMessagesMessageidGetAsyncWithHttpInfo (string messageId);
=======
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PutMessagesMessageIdAsyncWithHttpInfo (string messageId, VoicemailMessage body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        System.Threading.Tasks.Task<VoicemailMediaInfo> VoicemailMessagesMessageidMediaGetAsync (string messageId, string formatId = null);
=======
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> PutPolicyAsync (VoicemailOrganizationPolicy body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> VoicemailMessagesMessageidMediaGetAsyncWithHttpInfo (string messageId, string formatId = null);
        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> VoicemailMessagesMessageidPutAsync (string messageId, VoicemailMessage body = null);

        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> VoicemailMessagesMessageidPutAsyncWithHttpInfo (string messageId, VoicemailMessage body = null);
=======
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> PutPolicyAsyncWithHttpInfo (VoicemailOrganizationPolicy body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoicemailApi : IVoicemailApi
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
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy ConfigurationUservoicemailpoliciesUseridGet (string userId)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = ConfigurationUservoicemailpoliciesUseridGetWithHttpInfo(userId);
=======
        /// <returns>string</returns>
        public string DeleteMessages ()
        {
             ApiResponse<string> localVarResponse = DeleteMessagesWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > ConfigurationUservoicemailpoliciesUseridGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->ConfigurationUservoicemailpoliciesUseridGet");

            var localVarPath = "/api/v1/configuration/uservoicemailpolicies/{userId}";
=======
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMessagesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/messages";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> ConfigurationUservoicemailpoliciesUseridGetAsync (string userId)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await ConfigurationUservoicemailpoliciesUseridGetAsyncWithHttpInfo(userId);
=======
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMessagesAsync ()
        {
             ApiResponse<string> localVarResponse = await DeleteMessagesAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> ConfigurationUservoicemailpoliciesUseridGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->ConfigurationUservoicemailpoliciesUseridGet");

            var localVarPath = "/api/v1/configuration/uservoicemailpolicies/{userId}";
=======
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/messages";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy ConfigurationUservoicemailpoliciesUseridPatch (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = ConfigurationUservoicemailpoliciesUseridPatchWithHttpInfo(userId, body);
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>string</returns>
        public string DeleteMessagesMessageId (string messageId)
        {
             ApiResponse<string> localVarResponse = DeleteMessagesMessageIdWithHttpInfo(messageId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > ConfigurationUservoicemailpoliciesUseridPatchWithHttpInfo (string userId, VoicemailUserPolicy body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->ConfigurationUservoicemailpoliciesUseridPatch");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->ConfigurationUservoicemailpoliciesUseridPatch");

            var localVarPath = "/api/v1/configuration/uservoicemailpolicies/{userId}";
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMessagesMessageIdWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->DeleteMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
<<<<<<< HEAD
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> ConfigurationUservoicemailpoliciesUseridPatchAsync (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await ConfigurationUservoicemailpoliciesUseridPatchAsyncWithHttpInfo(userId, body);
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMessagesMessageIdAsync (string messageId)
        {
             ApiResponse<string> localVarResponse = await DeleteMessagesMessageIdAsyncWithHttpInfo(messageId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> ConfigurationUservoicemailpoliciesUseridPatchAsyncWithHttpInfo (string userId, VoicemailUserPolicy body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->ConfigurationUservoicemailpoliciesUseridPatch");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->ConfigurationUservoicemailpoliciesUseridPatch");

            var localVarPath = "/api/v1/configuration/uservoicemailpolicies/{userId}";
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesMessageIdAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->DeleteMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridPatch: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationUservoicemailpoliciesUseridPatch: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy ConfigurationVoicemailpolicyGet ()
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = ConfigurationVoicemailpolicyGetWithHttpInfo();
=======
        /// <returns>VoicemailMailboxInfo</returns>
        public VoicemailMailboxInfo GetMailbox ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = GetMailboxWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > ConfigurationVoicemailpolicyGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/voicemailpolicy";
=======
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        public ApiResponse< VoicemailMailboxInfo > GetMailboxWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/mailbox";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> ConfigurationVoicemailpolicyGetAsync ()
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = await ConfigurationVoicemailpolicyGetAsyncWithHttpInfo();
=======
        /// <returns>Task of VoicemailMailboxInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMailboxAsync ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = await GetMailboxAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> ConfigurationVoicemailpolicyGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/configuration/voicemailpolicy";
=======
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMailboxAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/mailbox";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMailbox: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy ConfigurationVoicemailpolicyPut (VoicemailOrganizationPolicy body = null)
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = ConfigurationVoicemailpolicyPutWithHttpInfo(body);
=======
        /// <returns>VoicemailMessageEntityListing</returns>
        public VoicemailMessageEntityListing GetMessages ()
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = GetMessagesWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > ConfigurationVoicemailpolicyPutWithHttpInfo (VoicemailOrganizationPolicy body = null)
        {

            var localVarPath = "/api/v1/configuration/voicemailpolicy";
=======
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        public ApiResponse< VoicemailMessageEntityListing > GetMessagesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/messages";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> ConfigurationVoicemailpolicyPutAsync (VoicemailOrganizationPolicy body = null)
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = await ConfigurationVoicemailpolicyPutAsyncWithHttpInfo(body);
=======
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        public async System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMessagesAsync ()
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = await GetMessagesAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> ConfigurationVoicemailpolicyPutAsyncWithHttpInfo (VoicemailOrganizationPolicy body = null)
        {

            var localVarPath = "/api/v1/configuration/voicemailpolicy";
=======
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMessagesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/messages";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfigurationVoicemailpolicyPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>VoicemailMailboxInfo</returns>
        public VoicemailMailboxInfo VoicemailMailboxGet ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = VoicemailMailboxGetWithHttpInfo();
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage GetMessagesMessageId (string messageId)
        {
             ApiResponse<VoicemailMessage> localVarResponse = GetMessagesMessageIdWithHttpInfo(messageId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        public ApiResponse< VoicemailMailboxInfo > VoicemailMailboxGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/voicemail/mailbox";
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > GetMessagesMessageIdWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMailboxGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMailboxGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of VoicemailMailboxInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMailboxInfo> VoicemailMailboxGetAsync ()
        {
             ApiResponse<VoicemailMailboxInfo> localVarResponse = await VoicemailMailboxGetAsyncWithHttpInfo();
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> GetMessagesMessageIdAsync (string messageId)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await GetMessagesMessageIdAsyncWithHttpInfo(messageId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> VoicemailMailboxGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/voicemail/mailbox";
=======
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> GetMessagesMessageIdAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMailboxGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMailboxGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMailboxInfo)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string VoicemailMessagesDelete ()
        {
             ApiResponse<string> localVarResponse = VoicemailMessagesDeleteWithHttpInfo();
=======
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>VoicemailMediaInfo</returns>
        public VoicemailMediaInfo GetMessagesMessageIdMedia (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> localVarResponse = GetMessagesMessageIdMediaWithHttpInfo(messageId, formatId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > VoicemailMessagesDeleteWithHttpInfo ()
        {

            var localVarPath = "/api/v1/voicemail/messages";
=======
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        public ApiResponse< VoicemailMediaInfo > GetMessagesMessageIdMediaWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageIdMedia");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}/media";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMediaInfo)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VoicemailMessagesDeleteAsync ()
        {
             ApiResponse<string> localVarResponse = await VoicemailMessagesDeleteAsyncWithHttpInfo();
=======
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMediaInfo> GetMessagesMessageIdMediaAsync (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> localVarResponse = await GetMessagesMessageIdMediaAsyncWithHttpInfo(messageId, formatId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete all voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> VoicemailMessagesDeleteAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/voicemail/messages";
=======
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired media format (WEBM, WAV) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> GetMessagesMessageIdMediaAsyncWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageIdMedia");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}/media";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMessagesMessageIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMediaInfo)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailMessageEntityListing</returns>
        public VoicemailMessageEntityListing VoicemailMessagesGet ()
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = VoicemailMessagesGetWithHttpInfo();
=======
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy GetPolicy ()
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = GetPolicyWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        public ApiResponse< VoicemailMessageEntityListing > VoicemailMessagesGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/voicemail/messages";
=======
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > GetPolicyWithHttpInfo ()
        {

            var localVarPath = "/api/v2/voicemail/policy";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        public async System.Threading.Tasks.Task<VoicemailMessageEntityListing> VoicemailMessagesGetAsync ()
        {
             ApiResponse<VoicemailMessageEntityListing> localVarResponse = await VoicemailMessagesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> VoicemailMessagesGetAsyncWithHttpInfo ()
        {
=======
        /// Get a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> GetPolicyAsync ()
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = await GetPolicyAsyncWithHttpInfo();
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            var localVarPath = "/api/v1/voicemail/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

<<<<<<< HEAD
=======
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

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessageEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>string</returns>
        public string VoicemailMessagesMessageidDelete (string messageId)
        {
             ApiResponse<string> localVarResponse = VoicemailMessagesMessageidDeleteWithHttpInfo(messageId);
=======
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy GetUserpoliciesUserId (string userId)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = GetUserpoliciesUserIdWithHttpInfo(userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > VoicemailMessagesMessageidDeleteWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidDelete");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VoicemailMessagesMessageidDeleteAsync (string messageId)
        {
             ApiResponse<string> localVarResponse = await VoicemailMessagesMessageidDeleteAsyncWithHttpInfo(messageId);
=======
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> GetUserpoliciesUserIdAsync (string userId)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await GetUserpoliciesUserIdAsyncWithHttpInfo(userId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> VoicemailMessagesMessageidDeleteAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidDelete");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage VoicemailMessagesMessageidGet (string messageId)
        {
             ApiResponse<VoicemailMessage> localVarResponse = VoicemailMessagesMessageidGetWithHttpInfo(messageId);
=======
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy PatchUserpoliciesUserId (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = PatchUserpoliciesUserIdWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > VoicemailMessagesMessageidGetWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidGet");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> VoicemailMessagesMessageidGetAsync (string messageId)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await VoicemailMessagesMessageidGetAsyncWithHttpInfo(messageId);
=======
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> PatchUserpoliciesUserIdAsync (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> localVarResponse = await PatchUserpoliciesUserIdAsyncWithHttpInfo(userId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> VoicemailMessagesMessageidGetAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidGet");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}";
=======
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
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
=======
            if (userId != null) localVarPathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchUserpoliciesUserId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailUserPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>VoicemailMediaInfo</returns>
        public VoicemailMediaInfo VoicemailMessagesMessageidMediaGet (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> localVarResponse = VoicemailMessagesMessageidMediaGetWithHttpInfo(messageId, formatId);
=======
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage PutMessagesMessageId (string messageId, VoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> localVarResponse = PutMessagesMessageIdWithHttpInfo(messageId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        public ApiResponse< VoicemailMediaInfo > VoicemailMessagesMessageidMediaGetWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidMediaGet");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}/media";
=======
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > PutMessagesMessageIdWithHttpInfo (string messageId, VoicemailMessage body = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->PutMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
<<<<<<< HEAD
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidMediaGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidMediaGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMediaInfo)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMediaInfo> VoicemailMessagesMessageidMediaGetAsync (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> localVarResponse = await VoicemailMessagesMessageidMediaGetAsyncWithHttpInfo(messageId, formatId);
=======
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> PutMessagesMessageIdAsync (string messageId, VoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await PutMessagesMessageIdAsyncWithHttpInfo(messageId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get media playback URI for this message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> VoicemailMessagesMessageidMediaGetAsyncWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidMediaGet");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}/media";
=======
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PutMessagesMessageIdAsyncWithHttpInfo (string messageId, VoicemailMessage body = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->PutMessagesMessageId");

            var localVarPath = "/api/v2/voicemail/messages/{messageId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
<<<<<<< HEAD
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidMediaGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidMediaGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMediaInfo)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage VoicemailMessagesMessageidPut (string messageId, VoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> localVarResponse = VoicemailMessagesMessageidPutWithHttpInfo(messageId, body);
=======
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy PutPolicy (VoicemailOrganizationPolicy body = null)
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = PutPolicyWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > VoicemailMessagesMessageidPutWithHttpInfo (string messageId, VoicemailMessage body = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidPut");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}";
=======
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > PutPolicyWithHttpInfo (VoicemailOrganizationPolicy body = null)
        {

            var localVarPath = "/api/v2/voicemail/policy";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> VoicemailMessagesMessageidPutAsync (string messageId, VoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> localVarResponse = await VoicemailMessagesMessageidPutAsyncWithHttpInfo(messageId, body);
=======
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> PutPolicyAsync (VoicemailOrganizationPolicy body = null)
        {
             ApiResponse<VoicemailOrganizationPolicy> localVarResponse = await PutPolicyAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update a message. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> VoicemailMessagesMessageidPutAsyncWithHttpInfo (string messageId, VoicemailMessage body = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->VoicemailMessagesMessageidPut");

            var localVarPath = "/api/v1/voicemail/messages/{messageId}";
=======
        /// Update a policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy (optional)</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> PutPolicyAsyncWithHttpInfo (VoicemailOrganizationPolicy body = null)
        {

            var localVarPath = "/api/v2/voicemail/policy";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VoicemailMessagesMessageidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailMessage)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPolicy: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VoicemailOrganizationPolicy)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
