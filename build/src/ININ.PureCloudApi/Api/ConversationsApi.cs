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
    public interface IConversationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>string</returns>
        string DeleteCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns></returns>
        void DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode (string conversationId, string participantId, string addCommunicationCode);

        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeWithHttpInfo (string conversationId, string participantId, string addCommunicationCode);
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>string</returns>
        string DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId (string emailId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdWithHttpInfo (string emailId, string attachmentId);
        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallbackConversationEntityListing</returns>
        CallbackConversationEntityListing GetCallbacks ();

        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallbackConversationEntityListing</returns>
        ApiResponse<CallbackConversationEntityListing> GetCallbacksWithHttpInfo ();
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>CallbackConversation</returns>
        CallbackConversation GetCallbacksCallbackId (string callbackId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        ApiResponse<CallbackConversation> GetCallbacksCallbackIdWithHttpInfo (string callbackId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetCallbacksCallbackIdParticipantsParticipantIdWrapup (string callbackId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetCallbacksCallbackIdParticipantsParticipantIdWrapupWithHttpInfo (string callbackId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes (string callbackId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callbackId, string participantId);
        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallConversationEntityListing</returns>
        CallConversationEntityListing GetCalls ();

        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        ApiResponse<CallConversationEntityListing> GetCallsWithHttpInfo ();
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>CallConversation</returns>
        CallConversation GetCallsCallId (string callId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>ApiResponse of CallConversation</returns>
        ApiResponse<CallConversation> GetCallsCallIdWithHttpInfo (string callId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetCallsCallIdParticipantsParticipantIdWrapup (string callId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetCallsCallIdParticipantsParticipantIdWrapupWithHttpInfo (string callId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupcodes (string callId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>CallConversationEntityListing</returns>
        CallConversationEntityListing GetCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null);

        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        ApiResponse<CallConversationEntityListing> GetCallsHistoryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null);
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MaxParticipants</returns>
        MaxParticipants GetCallsMaximumconferenceparties ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MaxParticipants</returns>
        ApiResponse<MaxParticipants> GetCallsMaximumconferencepartiesWithHttpInfo ();
        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatConversationEntityListing</returns>
        ChatConversationEntityListing GetChats ();

        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatConversationEntityListing</returns>
        ApiResponse<ChatConversationEntityListing> GetChatsWithHttpInfo ();
        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ChatConversation</returns>
        ChatConversation GetChatsChatId (string chatId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        ApiResponse<ChatConversation> GetChatsChatIdWithHttpInfo (string chatId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetChatsChatIdParticipantsParticipantIdWrapup (string chatId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetChatsChatIdParticipantsParticipantIdWrapupWithHttpInfo (string chatId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupcodes (string chatId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string chatId, string participantId);
        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CobrowseConversationEntityListing</returns>
        CobrowseConversationEntityListing GetCobrowsesessions ();

        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CobrowseConversationEntityListing</returns>
        ApiResponse<CobrowseConversationEntityListing> GetCobrowsesessionsWithHttpInfo ();
        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>CobrowseConversation</returns>
        CobrowseConversation GetCobrowsesessionsCobrowseId (string cobrowseId);

        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>ApiResponse of CobrowseConversation</returns>
        ApiResponse<CobrowseConversation> GetCobrowsesessionsCobrowseIdWithHttpInfo (string cobrowseId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup (string cobrowseId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupWithHttpInfo (string cobrowseId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes (string cobrowseId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string cobrowseId, string participantId);
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation GetConversationId (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> GetConversationIdWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetConversationIdParticipantsParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodes (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ConversationEntityListing</returns>
        ConversationEntityListing GetConversations (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        ApiResponse<ConversationEntityListing> GetConversationsWithHttpInfo (string communicationType = null);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        AnalyticsConversation GetConversationsConversationIdDetails (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        ApiResponse<AnalyticsConversation> GetConversationsConversationIdDetailsWithHttpInfo (string conversationId);
        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailConversationEntityListing</returns>
        EmailConversationEntityListing GetEmails ();

        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailConversationEntityListing</returns>
        ApiResponse<EmailConversationEntityListing> GetEmailsWithHttpInfo ();
        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailConversation</returns>
        EmailConversation GetEmailsEmailId (string emailId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        ApiResponse<EmailConversation> GetEmailsEmailIdWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing GetEmailsEmailIdMessages (string emailId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> GetEmailsEmailIdMessagesWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetEmailsEmailIdMessagesDraft (string emailId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetEmailsEmailIdMessagesDraftWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetEmailsEmailIdMessagesMessageId (string emailId, string messageId);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetEmailsEmailIdMessagesMessageIdWithHttpInfo (string emailId, string messageId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        Wrapup GetEmailsEmailIdParticipantsParticipantIdWrapup (string emailId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        ApiResponse<Wrapup> GetEmailsEmailIdParticipantsParticipantIdWrapupWithHttpInfo (string emailId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        List<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupcodes (string emailId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        ApiResponse<List<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string emailId, string participantId);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchCallbacksCallbackId (string callbackId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchCallbacksCallbackIdWithHttpInfo (string callbackId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns></returns>
        void PatchCallbacksCallbackIdParticipantsParticipantId (string callbackId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns></returns>
        void PatchCallbacksCallbackIdParticipantsParticipantIdAttributes (string callbackId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchCallsCallId (string callId, Conversation body);

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchCallsCallIdWithHttpInfo (string callId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns></returns>
        void PatchCallsCallIdParticipantsParticipantId (string callId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdWithHttpInfo (string callId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchCallsCallIdParticipantsParticipantIdAttributes (string callId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdAttributesWithHttpInfo (string callId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId (string callId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse PatchCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransferUpdate body);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> PatchCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchChatsChatId (string chatId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchChatsChatIdWithHttpInfo (string chatId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        void PatchChatsChatIdParticipantsParticipantId (string chatId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchChatsChatIdParticipantsParticipantIdAttributes (string chatId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdAttributesWithHttpInfo (string chatId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId (string chatId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchCobrowsesessionsCobrowseId (string cobrowseId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchCobrowsesessionsCobrowseIdWithHttpInfo (string cobrowseId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchCobrowsesessionsCobrowseIdParticipantsParticipantId (string cobrowseId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdWithHttpInfo (string cobrowseId, string participantId, MediaParticipantRequest body = null);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes (string cobrowseId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesWithHttpInfo (string cobrowseId, string participantId, ParticipantAttributes body = null);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        void PatchConversationIdParticipantsParticipantId (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationIdParticipantsParticipantIdWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationIdParticipantsParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchEmailsEmailId (string emailId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchEmailsEmailIdWithHttpInfo (string emailId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        void PatchEmailsEmailIdParticipantsParticipantId (string emailId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        void PatchEmailsEmailIdParticipantsParticipantIdAttributes (string emailId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdAttributesWithHttpInfo (string emailId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        Empty PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId (string emailId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        ApiResponse<Empty> PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string emailId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>CreateCallbackResponse</returns>
        CreateCallbackResponse PostCallbacks (CreateCallbackCommand body);

        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>ApiResponse of CreateCallbackResponse</returns>
        ApiResponse<CreateCallbackResponse> PostCallbacksWithHttpInfo (CreateCallbackCommand body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostCallbacksCallbackIdParticipantsParticipantIdReplace (string callbackId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCallbacksCallbackIdParticipantsParticipantIdReplaceWithHttpInfo (string callbackId, string participantId, TransferRequest body);
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>CreateCallResponse</returns>
        CreateCallResponse PostCalls (CreateCallRequest body);

        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>ApiResponse of CreateCallResponse</returns>
        ApiResponse<CreateCallResponse> PostCallsWithHttpInfo (CreateCallRequest body);
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostCallsCallId (string callId, CallCommand body);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostCallsCallIdWithHttpInfo (string callId, CallCommand body);
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostCallsCallIdParticipants (string callId, Conversation body);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostCallsCallIdParticipantsWithHttpInfo (string callId, Conversation body);
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse PostCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransfer body);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> PostCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransfer body);
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns></returns>
        void PostCallsCallIdParticipantsParticipantIdMonitor (string callId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdMonitorWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostCallsCallIdParticipantsParticipantIdReplace (string callId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdReplaceWithHttpInfo (string callId, string participantId, TransferRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostChatsChatIdParticipantsParticipantIdReplace (string chatId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostChatsChatIdParticipantsParticipantIdReplaceWithHttpInfo (string chatId, string participantId, TransferRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace (string cobrowseId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceWithHttpInfo (string cobrowseId, string participantId, TransferRequest body = null);
        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PostConversationIdParticipantsParticipantIdCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null);

        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationIdParticipantsParticipantIdCallbacksWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostConversationsAggregatesQuery (AggregationQuery body);

        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostConversationsAggregatesQueryWithHttpInfo (AggregationQuery body);
        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>PropertyIndexRequest</returns>
        PropertyIndexRequest PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body);

        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        ApiResponse<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body);
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        AnalyticsConversationQueryResponse PostConversationsDetailsQuery (ConversationQuery body);

        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        ApiResponse<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryWithHttpInfo (ConversationQuery body);
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PostEmailsEmailIdMessages (string emailId, EmailMessage body);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PostEmailsEmailIdMessagesWithHttpInfo (string emailId, EmailMessage body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        void PostEmailsEmailIdParticipantsParticipantIdReplace (string emailId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostEmailsEmailIdParticipantsParticipantIdReplaceWithHttpInfo (string emailId, string participantId, TransferRequest body);
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse PostFaxes (FaxSendRequest body);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> PostFaxesWithHttpInfo (FaxSendRequest body);
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PutEmailsEmailIdMessagesDraft (string emailId, EmailMessage body);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PutEmailsEmailIdMessagesDraftWithHttpInfo (string emailId, EmailMessage body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeAsync (string conversationId, string participantId, string addCommunicationCode);

        /// <summary>
        /// Delete a code used to add a communication to this participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeAsyncWithHttpInfo (string conversationId, string participantId, string addCommunicationCode);
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsync (string emailId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo (string emailId, string attachmentId);
        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallbackConversationEntityListing</returns>
        System.Threading.Tasks.Task<CallbackConversationEntityListing> GetCallbacksAsync ();

        /// <summary>
        /// Get callback conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallbackConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallbackConversationEntityListing>> GetCallbacksAsyncWithHttpInfo ();
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of CallbackConversation</returns>
        System.Threading.Tasks.Task<CallbackConversation> GetCallbacksCallbackIdAsync (string callbackId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetCallbacksCallbackIdAsyncWithHttpInfo (string callbackId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsync (string callbackId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callbackId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsync (string callbackId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callbackId, string participantId);
        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallConversationEntityListing</returns>
        System.Threading.Tasks.Task<CallConversationEntityListing> GetCallsAsync ();

        /// <summary>
        /// Get recent conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetCallsAsyncWithHttpInfo ();
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of CallConversation</returns>
        System.Threading.Tasks.Task<CallConversation> GetCallsCallIdAsync (string callId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetCallsCallIdAsyncWithHttpInfo (string callId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetCallsCallIdParticipantsParticipantIdWrapupAsync (string callId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallsCallIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsync (string callId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of CallConversationEntityListing</returns>
        System.Threading.Tasks.Task<CallConversationEntityListing> GetCallsHistoryAsync (int? pageSize = null, int? pageNumber = null, string interval = null);

        /// <summary>
        /// Get call history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetCallsHistoryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null);
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MaxParticipants</returns>
        System.Threading.Tasks.Task<MaxParticipants> GetCallsMaximumconferencepartiesAsync ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> GetCallsMaximumconferencepartiesAsyncWithHttpInfo ();
        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatConversationEntityListing</returns>
        System.Threading.Tasks.Task<ChatConversationEntityListing> GetChatsAsync ();

        /// <summary>
        /// Get recent chat conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversationEntityListing>> GetChatsAsyncWithHttpInfo ();
        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ChatConversation</returns>
        System.Threading.Tasks.Task<ChatConversation> GetChatsChatIdAsync (string chatId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetChatsChatIdAsyncWithHttpInfo (string chatId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetChatsChatIdParticipantsParticipantIdWrapupAsync (string chatId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetChatsChatIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string chatId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsync (string chatId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string chatId, string participantId);
        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CobrowseConversationEntityListing</returns>
        System.Threading.Tasks.Task<CobrowseConversationEntityListing> GetCobrowsesessionsAsync ();

        /// <summary>
        /// Get recent cobrowse conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CobrowseConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CobrowseConversationEntityListing>> GetCobrowsesessionsAsyncWithHttpInfo ();
        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>Task of CobrowseConversation</returns>
        System.Threading.Tasks.Task<CobrowseConversation> GetCobrowsesessionsCobrowseIdAsync (string cobrowseId);

        /// <summary>
        /// Get cobrowse conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>Task of ApiResponse (CobrowseConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CobrowseConversation>> GetCobrowsesessionsCobrowseIdAsyncWithHttpInfo (string cobrowseId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupAsync (string cobrowseId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string cobrowseId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesAsync (string cobrowseId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string cobrowseId, string participantId);
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> GetConversationIdAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationIdAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ConversationEntityListing</returns>
        System.Threading.Tasks.Task<ConversationEntityListing> GetConversationsAsync (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> GetConversationsAsyncWithHttpInfo (string communicationType = null);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        System.Threading.Tasks.Task<AnalyticsConversation> GetConversationsConversationIdDetailsAsync (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetConversationsConversationIdDetailsAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailConversationEntityListing</returns>
        System.Threading.Tasks.Task<EmailConversationEntityListing> GetEmailsAsync ();

        /// <summary>
        /// Get recent email conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversationEntityListing>> GetEmailsAsyncWithHttpInfo ();
        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailConversation</returns>
        System.Threading.Tasks.Task<EmailConversation> GetEmailsEmailIdAsync (string emailId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetEmailsEmailIdAsyncWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> GetEmailsEmailIdMessagesAsync (string emailId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetEmailsEmailIdMessagesDraftAsync (string emailId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetEmailsEmailIdMessagesMessageIdAsync (string emailId, string messageId);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesMessageIdAsyncWithHttpInfo (string emailId, string messageId);
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        System.Threading.Tasks.Task<Wrapup> GetEmailsEmailIdParticipantsParticipantIdWrapupAsync (string emailId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetEmailsEmailIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string emailId, string participantId, bool? provisional = null);
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        System.Threading.Tasks.Task<List<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsync (string emailId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string emailId, string participantId);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchCallbacksCallbackIdAsync (string callbackId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallbacksCallbackIdAsyncWithHttpInfo (string callbackId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAsync (string callbackId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAsyncWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsync (string callbackId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchCallsCallIdAsync (string callId, Conversation body);

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallsCallIdAsyncWithHttpInfo (string callId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAsync (string callId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAsyncWithHttpInfo (string callId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAttributesAsync (string callId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string callId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> PatchCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransferUpdate body);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchChatsChatIdAsync (string chatId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchChatsChatIdAsyncWithHttpInfo (string chatId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAsync (string chatId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAsyncWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAttributesAsync (string chatId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string chatId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string chatId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchCobrowsesessionsCobrowseIdAsync (string cobrowseId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCobrowsesessionsCobrowseIdAsyncWithHttpInfo (string cobrowseId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAsync (string cobrowseId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAsyncWithHttpInfo (string cobrowseId, string participantId, MediaParticipantRequest body = null);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesAsync (string cobrowseId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string cobrowseId, string participantId, ParticipantAttributes body = null);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAsync (string conversationId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchEmailsEmailIdAsync (string emailId, Conversation body);

        /// <summary>
        /// Update a conversation by disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchEmailsEmailIdAsyncWithHttpInfo (string emailId, Conversation body);
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAsync (string emailId, string participantId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAsyncWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAttributesAsync (string emailId, string participantId, ParticipantAttributes body);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string emailId, string participantId, ParticipantAttributes body);
        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        System.Threading.Tasks.Task<Empty> PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string emailId, string participantId, string communicationId, MediaParticipantRequest body);

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        System.Threading.Tasks.Task<ApiResponse<Empty>> PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string emailId, string participantId, string communicationId, MediaParticipantRequest body);
        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of CreateCallbackResponse</returns>
        System.Threading.Tasks.Task<CreateCallbackResponse> PostCallbacksAsync (CreateCallbackCommand body);

        /// <summary>
        /// Create a Callback
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of ApiResponse (CreateCallbackResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCallbackResponse>> PostCallbacksAsyncWithHttpInfo (CreateCallbackCommand body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsync (string callbackId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callbackId, string participantId, TransferRequest body);
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of CreateCallResponse</returns>
        System.Threading.Tasks.Task<CreateCallResponse> PostCallsAsync (CreateCallRequest body);

        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of ApiResponse (CreateCallResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCallResponse>> PostCallsAsyncWithHttpInfo (CreateCallRequest body);
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostCallsCallIdAsync (string callId, CallCommand body);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdAsyncWithHttpInfo (string callId, CallCommand body);
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostCallsCallIdParticipantsAsync (string callId, Conversation body);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdParticipantsAsyncWithHttpInfo (string callId, Conversation body);
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> PostCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransfer body);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransfer body);
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdMonitorAsync (string callId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdMonitorAsyncWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdReplaceAsync (string callId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callId, string participantId, TransferRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostChatsChatIdParticipantsParticipantIdReplaceAsync (string chatId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsChatIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string chatId, string participantId, TransferRequest body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceAsync (string cobrowseId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string cobrowseId, string participantId, TransferRequest body = null);
        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdCallbacksAsync (string conversationId, string participantId, CreateCallbackCommand body = null);

        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdReplaceAsync (string conversationId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostConversationsAggregatesQueryAsync (AggregationQuery body);

        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body);
        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body);

        /// <summary>
        /// Index conversation properties
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body);
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryAsync (ConversationQuery body);

        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body);
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PostEmailsEmailIdMessagesAsync (string emailId, EmailMessage body);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId, EmailMessage body);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostEmailsEmailIdParticipantsParticipantIdReplaceAsync (string emailId, string participantId, TransferRequest body);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEmailsEmailIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string emailId, string participantId, TransferRequest body);
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> PostFaxesAsync (FaxSendRequest body);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostFaxesAsyncWithHttpInfo (FaxSendRequest body);
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PutEmailsEmailIdMessagesDraftAsync (string emailId, EmailMessage body);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId, EmailMessage body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConversationsApi : IConversationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConversationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConversationsApi(Configuration configuration = null)
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
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>string</returns>
        public string DeleteCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId)
        {
             ApiResponse<string> localVarResponse = DeleteCallsCallIdParticipantsParticipantIdConsultWithHttpInfo(callId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->DeleteCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteCallsCallIdParticipantsParticipantIdConsult");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId)
        {
             ApiResponse<string> localVarResponse = await DeleteCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo(callId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->DeleteCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteCallsCallIdParticipantsParticipantIdConsult");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns></returns>
        public void DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode (string conversationId, string participantId, string addCommunicationCode)
        {
             DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeWithHttpInfo(conversationId, participantId, addCommunicationCode);
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeWithHttpInfo (string conversationId, string participantId, string addCommunicationCode)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode");
            // verify the required parameter 'addCommunicationCode' is set
            if (addCommunicationCode == null)
                throw new ApiException(400, "Missing required parameter 'addCommunicationCode' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (addCommunicationCode != null) localVarPathParams.Add("addCommunicationCode", Configuration.ApiClient.ParameterToString(addCommunicationCode)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeAsync (string conversationId, string participantId, string addCommunicationCode)
        {
             await DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeAsyncWithHttpInfo(conversationId, participantId, addCommunicationCode);

        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcodeAsyncWithHttpInfo (string conversationId, string participantId, string addCommunicationCode)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode");
            // verify the required parameter 'addCommunicationCode' is set
            if (addCommunicationCode == null)
                throw new ApiException(400, "Missing required parameter 'addCommunicationCode' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (addCommunicationCode != null) localVarPathParams.Add("addCommunicationCode", Configuration.ApiClient.ParameterToString(addCommunicationCode)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdParticipantsParticipantIdCodesAddcommunicationcode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>string</returns>
        public string DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId (string emailId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdWithHttpInfo(emailId, attachmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdWithHttpInfo (string emailId, string attachmentId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/draft/attachments/{attachmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (attachmentId != null) localVarPathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsync (string emailId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = await DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo(emailId, attachmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo (string emailId, string attachmentId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/draft/attachments/{attachmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (attachmentId != null) localVarPathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarHeaders,
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallbackConversationEntityListing</returns>
        public CallbackConversationEntityListing GetCallbacks ()
        {
             ApiResponse<CallbackConversationEntityListing> localVarResponse = GetCallbacksWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallbackConversationEntityListing</returns>
        public ApiResponse< CallbackConversationEntityListing > GetCallbacksWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversationEntityListing)));
            
        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallbackConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CallbackConversationEntityListing> GetCallbacksAsync ()
        {
             ApiResponse<CallbackConversationEntityListing> localVarResponse = await GetCallbacksAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callback conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallbackConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallbackConversationEntityListing>> GetCallbacksAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversationEntityListing)));
            
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>CallbackConversation</returns>
        public CallbackConversation GetCallbacksCallbackId (string callbackId)
        {
             ApiResponse<CallbackConversation> localVarResponse = GetCallbacksCallbackIdWithHttpInfo(callbackId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        public ApiResponse< CallbackConversation > GetCallbacksCallbackIdWithHttpInfo (string callbackId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbacksCallbackId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of CallbackConversation</returns>
        public async System.Threading.Tasks.Task<CallbackConversation> GetCallbacksCallbackIdAsync (string callbackId)
        {
             ApiResponse<CallbackConversation> localVarResponse = await GetCallbacksCallbackIdAsyncWithHttpInfo(callbackId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetCallbacksCallbackIdAsyncWithHttpInfo (string callbackId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbacksCallbackId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarHeaders,
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetCallbacksCallbackIdParticipantsParticipantIdWrapup (string callbackId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetCallbacksCallbackIdParticipantsParticipantIdWrapupWithHttpInfo(callbackId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetCallbacksCallbackIdParticipantsParticipantIdWrapupWithHttpInfo (string callbackId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsync (string callbackId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(callbackId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callbackId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes (string callbackId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesWithHttpInfo(callbackId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callbackId, string participantId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsync (string callbackId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(callbackId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callbackId, string participantId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CallConversationEntityListing</returns>
        public CallConversationEntityListing GetCalls ()
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = GetCallsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        public ApiResponse< CallConversationEntityListing > GetCallsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CallConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CallConversationEntityListing> GetCallsAsync ()
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = await GetCallsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetCallsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>CallConversation</returns>
        public CallConversation GetCallsCallId (string callId)
        {
             ApiResponse<CallConversation> localVarResponse = GetCallsCallIdWithHttpInfo(callId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>ApiResponse of CallConversation</returns>
        public ApiResponse< CallConversation > GetCallsCallIdWithHttpInfo (string callId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallsCallId");

            var localVarPath = "/api/v2/conversations/calls/{callId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarHeaders,
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of CallConversation</returns>
        public async System.Threading.Tasks.Task<CallConversation> GetCallsCallIdAsync (string callId)
        {
             ApiResponse<CallConversation> localVarResponse = await GetCallsCallIdAsyncWithHttpInfo(callId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetCallsCallIdAsyncWithHttpInfo (string callId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallsCallId");

            var localVarPath = "/api/v2/conversations/calls/{callId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarHeaders,
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetCallsCallIdParticipantsParticipantIdWrapup (string callId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetCallsCallIdParticipantsParticipantIdWrapupWithHttpInfo(callId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetCallsCallIdParticipantsParticipantIdWrapupWithHttpInfo (string callId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetCallsCallIdParticipantsParticipantIdWrapupAsync (string callId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetCallsCallIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(callId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallsCallIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupcodes (string callId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetCallsCallIdParticipantsParticipantIdWrapupcodesWithHttpInfo(callId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetCallsCallIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsync (string callId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetCallsCallIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(callId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallsCallIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>CallConversationEntityListing</returns>
        public CallConversationEntityListing GetCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null)
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = GetCallsHistoryWithHttpInfo(pageSize, pageNumber, interval);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>ApiResponse of CallConversationEntityListing</returns>
        public ApiResponse< CallConversationEntityListing > GetCallsHistoryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null)
        {

            var localVarPath = "/api/v2/conversations/calls/history";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of CallConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CallConversationEntityListing> GetCallsHistoryAsync (int? pageSize = null, int? pageNumber = null, string interval = null)
        {
             ApiResponse<CallConversationEntityListing> localVarResponse = await GetCallsHistoryAsyncWithHttpInfo(pageSize, pageNumber, interval);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get call history 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="interval">Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; (optional)</param>
        /// <returns>Task of ApiResponse (CallConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversationEntityListing>> GetCallsHistoryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string interval = null)
        {

            var localVarPath = "/api/v2/conversations/calls/history";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (interval != null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MaxParticipants</returns>
        public MaxParticipants GetCallsMaximumconferenceparties ()
        {
             ApiResponse<MaxParticipants> localVarResponse = GetCallsMaximumconferencepartiesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MaxParticipants</returns>
        public ApiResponse< MaxParticipants > GetCallsMaximumconferencepartiesWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls/maximumconferenceparties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarHeaders,
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MaxParticipants</returns>
        public async System.Threading.Tasks.Task<MaxParticipants> GetCallsMaximumconferencepartiesAsync ()
        {
             ApiResponse<MaxParticipants> localVarResponse = await GetCallsMaximumconferencepartiesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> GetCallsMaximumconferencepartiesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/calls/maximumconferenceparties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarHeaders,
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChatConversationEntityListing</returns>
        public ChatConversationEntityListing GetChats ()
        {
             ApiResponse<ChatConversationEntityListing> localVarResponse = GetChatsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChatConversationEntityListing</returns>
        public ApiResponse< ChatConversationEntityListing > GetChatsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/chats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChatConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<ChatConversationEntityListing> GetChatsAsync ()
        {
             ApiResponse<ChatConversationEntityListing> localVarResponse = await GetChatsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent chat conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChatConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversationEntityListing>> GetChatsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/chats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ChatConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversationEntityListing)));
            
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ChatConversation</returns>
        public ChatConversation GetChatsChatId (string chatId)
        {
             ApiResponse<ChatConversation> localVarResponse = GetChatsChatIdWithHttpInfo(chatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        public ApiResponse< ChatConversation > GetChatsChatIdWithHttpInfo (string chatId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatsChatId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarHeaders,
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ChatConversation</returns>
        public async System.Threading.Tasks.Task<ChatConversation> GetChatsChatIdAsync (string chatId)
        {
             ApiResponse<ChatConversation> localVarResponse = await GetChatsChatIdAsyncWithHttpInfo(chatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetChatsChatIdAsyncWithHttpInfo (string chatId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatsChatId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarHeaders,
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetChatsChatIdParticipantsParticipantIdWrapup (string chatId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetChatsChatIdParticipantsParticipantIdWrapupWithHttpInfo(chatId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetChatsChatIdParticipantsParticipantIdWrapupWithHttpInfo (string chatId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetChatsChatIdParticipantsParticipantIdWrapupAsync (string chatId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetChatsChatIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(chatId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetChatsChatIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string chatId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupcodes (string chatId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetChatsChatIdParticipantsParticipantIdWrapupcodesWithHttpInfo(chatId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetChatsChatIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string chatId, string participantId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsync (string chatId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetChatsChatIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(chatId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string chatId, string participantId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatsChatIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CobrowseConversationEntityListing</returns>
        public CobrowseConversationEntityListing GetCobrowsesessions ()
        {
             ApiResponse<CobrowseConversationEntityListing> localVarResponse = GetCobrowsesessionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CobrowseConversationEntityListing</returns>
        public ApiResponse< CobrowseConversationEntityListing > GetCobrowsesessionsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/cobrowsesessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CobrowseConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<CobrowseConversationEntityListing> GetCobrowsesessionsAsync ()
        {
             ApiResponse<CobrowseConversationEntityListing> localVarResponse = await GetCobrowsesessionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent cobrowse conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CobrowseConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CobrowseConversationEntityListing>> GetCobrowsesessionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/cobrowsesessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversationEntityListing)));
            
        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>CobrowseConversation</returns>
        public CobrowseConversation GetCobrowsesessionsCobrowseId (string cobrowseId)
        {
             ApiResponse<CobrowseConversation> localVarResponse = GetCobrowsesessionsCobrowseIdWithHttpInfo(cobrowseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>ApiResponse of CobrowseConversation</returns>
        public ApiResponse< CobrowseConversation > GetCobrowsesessionsCobrowseIdWithHttpInfo (string cobrowseId)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->GetCobrowsesessionsCobrowseId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversation>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversation)));
            
        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>Task of CobrowseConversation</returns>
        public async System.Threading.Tasks.Task<CobrowseConversation> GetCobrowsesessionsCobrowseIdAsync (string cobrowseId)
        {
             ApiResponse<CobrowseConversation> localVarResponse = await GetCobrowsesessionsCobrowseIdAsyncWithHttpInfo(cobrowseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get cobrowse conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <returns>Task of ApiResponse (CobrowseConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CobrowseConversation>> GetCobrowsesessionsCobrowseIdAsyncWithHttpInfo (string cobrowseId)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->GetCobrowsesessionsCobrowseId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CobrowseConversation>(localVarStatusCode,
                localVarHeaders,
                (CobrowseConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CobrowseConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup (string cobrowseId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupWithHttpInfo(cobrowseId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupWithHttpInfo (string cobrowseId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupAsync (string cobrowseId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(cobrowseId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string cobrowseId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes (string cobrowseId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesWithHttpInfo(cobrowseId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string cobrowseId, string participantId)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesAsync (string cobrowseId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(cobrowseId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string cobrowseId, string participantId)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCobrowsesessionsCobrowseIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        public Conversation GetConversationId (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = GetConversationIdWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > GetConversationIdWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationId");

            var localVarPath = "/api/v2/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> GetConversationIdAsync (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = await GetConversationIdAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationIdAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationId");

            var localVarPath = "/api/v2/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode GetConversationIdParticipantsParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetConversationIdParticipantsParticipantIdWrapupWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationIdParticipantsParticipantIdWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarHeaders,
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetConversationIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarHeaders,
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ConversationEntityListing</returns>
        public ConversationEntityListing GetConversations (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> localVarResponse = GetConversationsWithHttpInfo(communicationType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        public ApiResponse< ConversationEntityListing > GetConversationsWithHttpInfo (string communicationType = null)
        {

            var localVarPath = "/api/v2/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (communicationType != null) localVarQueryParams.Add("communicationType", Configuration.ApiClient.ParameterToString(communicationType)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationEntityListing)));
            
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<ConversationEntityListing> GetConversationsAsync (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> localVarResponse = await GetConversationsAsyncWithHttpInfo(communicationType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> GetConversationsAsyncWithHttpInfo (string communicationType = null)
        {

            var localVarPath = "/api/v2/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (communicationType != null) localVarQueryParams.Add("communicationType", Configuration.ApiClient.ParameterToString(communicationType)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationEntityListing)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        public AnalyticsConversation GetConversationsConversationIdDetails (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = GetConversationsConversationIdDetailsWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        public ApiResponse< AnalyticsConversation > GetConversationsConversationIdDetailsWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsConversationIdDetails");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversation> GetConversationsConversationIdDetailsAsync (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = await GetConversationsConversationIdDetailsAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetConversationsConversationIdDetailsAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationsConversationIdDetails");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
            
        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EmailConversationEntityListing</returns>
        public EmailConversationEntityListing GetEmails ()
        {
             ApiResponse<EmailConversationEntityListing> localVarResponse = GetEmailsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EmailConversationEntityListing</returns>
        public ApiResponse< EmailConversationEntityListing > GetEmailsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/emails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EmailConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversationEntityListing)));
            
        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EmailConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<EmailConversationEntityListing> GetEmailsAsync ()
        {
             ApiResponse<EmailConversationEntityListing> localVarResponse = await GetEmailsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent email conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EmailConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversationEntityListing>> GetEmailsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/conversations/emails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (EmailConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversationEntityListing)));
            
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailConversation</returns>
        public EmailConversation GetEmailsEmailId (string emailId)
        {
             ApiResponse<EmailConversation> localVarResponse = GetEmailsEmailIdWithHttpInfo(emailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        public ApiResponse< EmailConversation > GetEmailsEmailIdWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarHeaders,
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailConversation</returns>
        public async System.Threading.Tasks.Task<EmailConversation> GetEmailsEmailIdAsync (string emailId)
        {
             ApiResponse<EmailConversation> localVarResponse = await GetEmailsEmailIdAsyncWithHttpInfo(emailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetEmailsEmailIdAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarHeaders,
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing GetEmailsEmailIdMessages (string emailId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = GetEmailsEmailIdMessagesWithHttpInfo(emailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > GetEmailsEmailIdMessagesWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdMessages");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarHeaders,
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> GetEmailsEmailIdMessagesAsync (string emailId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = await GetEmailsEmailIdMessagesAsyncWithHttpInfo(emailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdMessages");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarHeaders,
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage GetEmailsEmailIdMessagesDraft (string emailId)
        {
             ApiResponse<EmailMessage> localVarResponse = GetEmailsEmailIdMessagesDraftWithHttpInfo(emailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetEmailsEmailIdMessagesDraftWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetEmailsEmailIdMessagesDraftAsync (string emailId)
        {
             ApiResponse<EmailMessage> localVarResponse = await GetEmailsEmailIdMessagesDraftAsyncWithHttpInfo(emailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage GetEmailsEmailIdMessagesMessageId (string emailId, string messageId)
        {
             ApiResponse<EmailMessage> localVarResponse = GetEmailsEmailIdMessagesMessageIdWithHttpInfo(emailId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetEmailsEmailIdMessagesMessageIdWithHttpInfo (string emailId, string messageId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdMessagesMessageId");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ConversationsApi->GetEmailsEmailIdMessagesMessageId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetEmailsEmailIdMessagesMessageIdAsync (string emailId, string messageId)
        {
             ApiResponse<EmailMessage> localVarResponse = await GetEmailsEmailIdMessagesMessageIdAsyncWithHttpInfo(emailId, messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesMessageIdAsyncWithHttpInfo (string emailId, string messageId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdMessagesMessageId");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ConversationsApi->GetEmailsEmailIdMessagesMessageId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/{messageId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Wrapup</returns>
        public Wrapup GetEmailsEmailIdParticipantsParticipantIdWrapup (string emailId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetEmailsEmailIdParticipantsParticipantIdWrapupWithHttpInfo(emailId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>ApiResponse of Wrapup</returns>
        public ApiResponse< Wrapup > GetEmailsEmailIdParticipantsParticipantIdWrapupWithHttpInfo (string emailId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of Wrapup</returns>
        public async System.Threading.Tasks.Task<Wrapup> GetEmailsEmailIdParticipantsParticipantIdWrapupAsync (string emailId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetEmailsEmailIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(emailId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (Wrapup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetEmailsEmailIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string emailId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapup");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (provisional != null) localVarQueryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarHeaders,
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupcodes (string emailId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetEmailsEmailIdParticipantsParticipantIdWrapupcodesWithHttpInfo(emailId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetEmailsEmailIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string emailId, string participantId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsync (string emailId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(emailId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string emailId, string participantId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailsEmailIdParticipantsParticipantIdWrapupcodes");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarHeaders,
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchCallbacksCallbackId (string callbackId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchCallbacksCallbackIdWithHttpInfo(callbackId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchCallbacksCallbackIdWithHttpInfo (string callbackId, Conversation body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchCallbacksCallbackIdAsync (string callbackId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchCallbacksCallbackIdAsyncWithHttpInfo(callbackId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallbacksCallbackIdAsyncWithHttpInfo (string callbackId, Conversation body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns></returns>
        public void PatchCallbacksCallbackIdParticipantsParticipantId (string callbackId, string participantId, MediaParticipantRequest body)
        {
             PatchCallbacksCallbackIdParticipantsParticipantIdWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAsync (string callbackId, string participantId, MediaParticipantRequest body)
        {
             await PatchCallbacksCallbackIdParticipantsParticipantIdAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAsyncWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns></returns>
        public void PatchCallbacksCallbackIdParticipantsParticipantIdAttributes (string callbackId, string participantId, ParticipantAttributes body)
        {
             PatchCallbacksCallbackIdParticipantsParticipantIdAttributesWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsync (string callbackId, string participantId, ParticipantAttributes body)
        {
             await PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo(callbackId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo(callbackId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchCallsCallId (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchCallsCallIdWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchCallsCallIdWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallId");

            var localVarPath = "/api/v2/conversations/calls/{callId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchCallsCallIdAsync (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchCallsCallIdAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallsCallIdAsyncWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallId");

            var localVarPath = "/api/v2/conversations/calls/{callId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns></returns>
        public void PatchCallsCallIdParticipantsParticipantId (string callId, string participantId, MediaParticipantRequest body)
        {
             PatchCallsCallIdParticipantsParticipantIdWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdWithHttpInfo (string callId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAsync (string callId, string participantId, MediaParticipantRequest body)
        {
             await PatchCallsCallIdParticipantsParticipantIdAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAsyncWithHttpInfo (string callId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchCallsCallIdParticipantsParticipantIdAttributes (string callId, string participantId, ParticipantAttributes body)
        {
             PatchCallsCallIdParticipantsParticipantIdAttributesWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdAttributesWithHttpInfo (string callId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAttributesAsync (string callId, string participantId, ParticipantAttributes body)
        {
             await PatchCallsCallIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo(callId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo(callId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PatchCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransferUpdate body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PatchCallsCallIdParticipantsParticipantIdConsultWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PatchCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PatchCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransferUpdate body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PatchCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchChatsChatId (string chatId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchChatsChatIdWithHttpInfo(chatId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchChatsChatIdWithHttpInfo (string chatId, Conversation body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchChatsChatIdAsync (string chatId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchChatsChatIdAsyncWithHttpInfo(chatId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchChatsChatIdAsyncWithHttpInfo (string chatId, Conversation body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchChatsChatIdParticipantsParticipantId (string chatId, string participantId, MediaParticipantRequest body)
        {
             PatchChatsChatIdParticipantsParticipantIdWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAsync (string chatId, string participantId, MediaParticipantRequest body)
        {
             await PatchChatsChatIdParticipantsParticipantIdAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAsyncWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchChatsChatIdParticipantsParticipantIdAttributes (string chatId, string participantId, ParticipantAttributes body)
        {
             PatchChatsChatIdParticipantsParticipantIdAttributesWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdAttributesWithHttpInfo (string chatId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAttributesAsync (string chatId, string participantId, ParticipantAttributes body)
        {
             await PatchChatsChatIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string chatId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo(chatId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo(chatId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchCobrowsesessionsCobrowseId (string cobrowseId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchCobrowsesessionsCobrowseIdWithHttpInfo(cobrowseId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchCobrowsesessionsCobrowseIdWithHttpInfo (string cobrowseId, Conversation body)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCobrowsesessionsCobrowseId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchCobrowsesessionsCobrowseIdAsync (string cobrowseId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchCobrowsesessionsCobrowseIdAsyncWithHttpInfo(cobrowseId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCobrowsesessionsCobrowseIdAsyncWithHttpInfo (string cobrowseId, Conversation body)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCobrowsesessionsCobrowseId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchCobrowsesessionsCobrowseIdParticipantsParticipantId (string cobrowseId, string participantId, MediaParticipantRequest body = null)
        {
             PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdWithHttpInfo(cobrowseId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdWithHttpInfo (string cobrowseId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAsync (string cobrowseId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAsyncWithHttpInfo(cobrowseId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAsyncWithHttpInfo (string cobrowseId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes (string cobrowseId, string participantId, ParticipantAttributes body = null)
        {
             PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesWithHttpInfo(cobrowseId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesWithHttpInfo (string cobrowseId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesAsync (string cobrowseId, string participantId, ParticipantAttributes body = null)
        {
             await PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(cobrowseId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string cobrowseId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo(cobrowseId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo(cobrowseId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string cobrowseId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCobrowsesessionsCobrowseIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchConversationIdParticipantsParticipantId (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationIdParticipantsParticipantIdWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationIdParticipantsParticipantIdWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationIdParticipantsParticipantIdAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationIdParticipantsParticipantIdAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationIdParticipantsParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchEmailsEmailId (string emailId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchEmailsEmailIdWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchEmailsEmailIdWithHttpInfo (string emailId, Conversation body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchEmailsEmailIdAsync (string emailId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchEmailsEmailIdAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchEmailsEmailIdAsyncWithHttpInfo (string emailId, Conversation body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchEmailsEmailIdParticipantsParticipantId (string emailId, string participantId, MediaParticipantRequest body)
        {
             PatchEmailsEmailIdParticipantsParticipantIdWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAsync (string emailId, string participantId, MediaParticipantRequest body)
        {
             await PatchEmailsEmailIdParticipantsParticipantIdAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAsyncWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns></returns>
        public void PatchEmailsEmailIdParticipantsParticipantIdAttributes (string emailId, string participantId, ParticipantAttributes body)
        {
             PatchEmailsEmailIdParticipantsParticipantIdAttributesWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdAttributesWithHttpInfo (string emailId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAttributesAsync (string emailId, string participantId, ParticipantAttributes body)
        {
             await PatchEmailsEmailIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string emailId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Empty</returns>
        public Empty PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId (string emailId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo(emailId, participantId, communicationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Empty</returns>
        public ApiResponse< Empty > PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdWithHttpInfo (string emailId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of Empty</returns>
        public async System.Threading.Tasks.Task<Empty> PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdAsync (string emailId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             ApiResponse<Empty> localVarResponse = await PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo(emailId, participantId, communicationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse (Empty)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Empty>> PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationIdAsyncWithHttpInfo (string emailId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/communications/{communicationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            if (communicationId != null) localVarPathParams.Add("communicationId", Configuration.ApiClient.ParameterToString(communicationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdCommunicationsCommunicationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Empty>(localVarStatusCode,
                localVarHeaders,
                (Empty) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Empty)));
            
        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>CreateCallbackResponse</returns>
        public CreateCallbackResponse PostCallbacks (CreateCallbackCommand body)
        {
             ApiResponse<CreateCallbackResponse> localVarResponse = PostCallbacksWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>ApiResponse of CreateCallbackResponse</returns>
        public ApiResponse< CreateCallbackResponse > PostCallbacksWithHttpInfo (CreateCallbackCommand body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallbacks");

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallbackResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallbackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallbackResponse)));
            
        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of CreateCallbackResponse</returns>
        public async System.Threading.Tasks.Task<CreateCallbackResponse> PostCallbacksAsync (CreateCallbackCommand body)
        {
             ApiResponse<CreateCallbackResponse> localVarResponse = await PostCallbacksAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Callback 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Callback</param>
        /// <returns>Task of ApiResponse (CreateCallbackResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCallbackResponse>> PostCallbacksAsyncWithHttpInfo (CreateCallbackCommand body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallbacks");

            var localVarPath = "/api/v2/conversations/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallbackResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallbackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallbackResponse)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostCallbacksCallbackIdParticipantsParticipantIdReplace (string callbackId, string participantId, TransferRequest body)
        {
             PostCallbacksCallbackIdParticipantsParticipantIdReplaceWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallbacksCallbackIdParticipantsParticipantIdReplaceWithHttpInfo (string callbackId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsync (string callbackId, string participantId, TransferRequest body)
        {
             await PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callbackId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callbackId != null) localVarPathParams.Add("callbackId", Configuration.ApiClient.ParameterToString(callbackId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>CreateCallResponse</returns>
        public CreateCallResponse PostCalls (CreateCallRequest body)
        {
             ApiResponse<CreateCallResponse> localVarResponse = PostCallsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>ApiResponse of CreateCallResponse</returns>
        public ApiResponse< CreateCallResponse > PostCallsWithHttpInfo (CreateCallRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCalls");

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallResponse)));
            
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of CreateCallResponse</returns>
        public async System.Threading.Tasks.Task<CreateCallResponse> PostCallsAsync (CreateCallRequest body)
        {
             ApiResponse<CreateCallResponse> localVarResponse = await PostCallsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Call request</param>
        /// <returns>Task of ApiResponse (CreateCallResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCallResponse>> PostCallsAsyncWithHttpInfo (CreateCallRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCalls");

            var localVarPath = "/api/v2/conversations/calls";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarHeaders,
                (CreateCallResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallResponse)));
            
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PostCallsCallId (string callId, CallCommand body)
        {
             ApiResponse<Conversation> localVarResponse = PostCallsCallIdWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostCallsCallIdWithHttpInfo (string callId, CallCommand body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallId");

            var localVarPath = "/api/v2/conversations/calls/{callId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostCallsCallIdAsync (string callId, CallCommand body)
        {
             ApiResponse<Conversation> localVarResponse = await PostCallsCallIdAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdAsyncWithHttpInfo (string callId, CallCommand body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallId");

            var localVarPath = "/api/v2/conversations/calls/{callId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PostCallsCallIdParticipants (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PostCallsCallIdParticipantsWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostCallsCallIdParticipantsWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipants");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallIdParticipants");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostCallsCallIdParticipantsAsync (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PostCallsCallIdParticipantsAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdParticipantsAsyncWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipants");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallIdParticipants");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarHeaders,
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PostCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransfer body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PostCallsCallIdParticipantsParticipantIdConsultWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PostCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransfer body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PostCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransfer body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PostCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransfer body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarHeaders,
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns></returns>
        public void PostCallsCallIdParticipantsParticipantIdMonitor (string callId, string participantId)
        {
             PostCallsCallIdParticipantsParticipantIdMonitorWithHttpInfo(callId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdMonitorWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdMonitor");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/monitor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdMonitorAsync (string callId, string participantId)
        {
             await PostCallsCallIdParticipantsParticipantIdMonitorAsyncWithHttpInfo(callId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdMonitorAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdMonitor");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/monitor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostCallsCallIdParticipantsParticipantIdReplace (string callId, string participantId, TransferRequest body)
        {
             PostCallsCallIdParticipantsParticipantIdReplaceWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdReplaceWithHttpInfo (string callId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdReplaceAsync (string callId, string participantId, TransferRequest body)
        {
             await PostCallsCallIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/calls/{callId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (callId != null) localVarPathParams.Add("callId", Configuration.ApiClient.ParameterToString(callId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostChatsChatIdParticipantsParticipantIdReplace (string chatId, string participantId, TransferRequest body)
        {
             PostChatsChatIdParticipantsParticipantIdReplaceWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostChatsChatIdParticipantsParticipantIdReplaceWithHttpInfo (string chatId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostChatsChatIdParticipantsParticipantIdReplaceAsync (string chatId, string participantId, TransferRequest body)
        {
             await PostChatsChatIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsChatIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string chatId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/chats/{chatId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chatId != null) localVarPathParams.Add("chatId", Configuration.ApiClient.ParameterToString(chatId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace (string cobrowseId, string participantId, TransferRequest body = null)
        {
             PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceWithHttpInfo(cobrowseId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceWithHttpInfo (string cobrowseId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceAsync (string cobrowseId, string participantId, TransferRequest body = null)
        {
             await PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(cobrowseId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cobrowseId">cobrowseId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string cobrowseId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'cobrowseId' is set
            if (cobrowseId == null)
                throw new ApiException(400, "Missing required parameter 'cobrowseId' when calling ConversationsApi->PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/cobrowsesessions/{cobrowseId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (cobrowseId != null) localVarPathParams.Add("cobrowseId", Configuration.ApiClient.ParameterToString(cobrowseId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCobrowsesessionsCobrowseIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PostConversationIdParticipantsParticipantIdCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
             PostConversationIdParticipantsParticipantIdCallbacksWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationIdParticipantsParticipantIdCallbacksWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdCallbacks");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdCallbacksAsync (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
             await PostConversationIdParticipantsParticipantIdCallbacksAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdCallbacks");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/callbacks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        public AggregateQueryResponse PostConversationsAggregatesQuery (AggregationQuery body)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = PostConversationsAggregatesQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        public ApiResponse< AggregateQueryResponse > PostConversationsAggregatesQueryWithHttpInfo (AggregationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsAggregatesQuery");

            var localVarPath = "/api/v2/analytics/conversations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostConversationsAggregatesQueryAsync (AggregationQuery body)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = await PostConversationsAggregatesQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for conversation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsAggregatesQuery");

            var localVarPath = "/api/v2/analytics/conversations/aggregates/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>PropertyIndexRequest</returns>
        public PropertyIndexRequest PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = PostConversationsConversationIdDetailsPropertiesWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        public ApiResponse< PropertyIndexRequest > PostConversationsConversationIdDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsConversationIdDetailsProperties");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsConversationIdDetailsProperties");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarHeaders,
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        public async System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = await PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsConversationIdDetailsProperties");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsConversationIdDetailsProperties");

            var localVarPath = "/api/v2/analytics/conversations/{conversationId}/details/properties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarHeaders,
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        public AnalyticsConversationQueryResponse PostConversationsDetailsQuery (ConversationQuery body)
        {
             ApiResponse<AnalyticsConversationQueryResponse> localVarResponse = PostConversationsDetailsQueryWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        public ApiResponse< AnalyticsConversationQueryResponse > PostConversationsDetailsQueryWithHttpInfo (ConversationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsDetailsQuery");

            var localVarPath = "/api/v2/analytics/conversations/details/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
            
        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryAsync (ConversationQuery body)
        {
             ApiResponse<AnalyticsConversationQueryResponse> localVarResponse = await PostConversationsDetailsQueryAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationsDetailsQuery");

            var localVarPath = "/api/v2/analytics/conversations/details/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarHeaders,
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage PostEmailsEmailIdMessages (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = PostEmailsEmailIdMessagesWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PostEmailsEmailIdMessagesWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailsEmailIdMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailsEmailIdMessages");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PostEmailsEmailIdMessagesAsync (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = await PostEmailsEmailIdMessagesAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailsEmailIdMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailsEmailIdMessages");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostEmailsEmailIdParticipantsParticipantIdReplace (string emailId, string participantId, TransferRequest body)
        {
             PostEmailsEmailIdParticipantsParticipantIdReplaceWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostEmailsEmailIdParticipantsParticipantIdReplaceWithHttpInfo (string emailId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostEmailsEmailIdParticipantsParticipantIdReplaceAsync (string emailId, string participantId, TransferRequest body)
        {
             await PostEmailsEmailIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostEmailsEmailIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string emailId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        public FaxSendResponse PostFaxes (FaxSendRequest body)
        {
             ApiResponse<FaxSendResponse> localVarResponse = PostFaxesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        public ApiResponse< FaxSendResponse > PostFaxesWithHttpInfo (FaxSendRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostFaxes");

            var localVarPath = "/api/v2/conversations/faxes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarHeaders,
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        public async System.Threading.Tasks.Task<FaxSendResponse> PostFaxesAsync (FaxSendRequest body)
        {
             ApiResponse<FaxSendResponse> localVarResponse = await PostFaxesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostFaxesAsyncWithHttpInfo (FaxSendRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostFaxes");

            var localVarPath = "/api/v2/conversations/faxes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarHeaders,
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage PutEmailsEmailIdMessagesDraft (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = PutEmailsEmailIdMessagesDraftWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PutEmailsEmailIdMessagesDraftWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PutEmailsEmailIdMessagesDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PutEmailsEmailIdMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PutEmailsEmailIdMessagesDraftAsync (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = await PutEmailsEmailIdMessagesDraftAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PutEmailsEmailIdMessagesDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PutEmailsEmailIdMessagesDraft");

            var localVarPath = "/api/v2/conversations/emails/{emailId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (emailId != null) localVarPathParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarHeaders,
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

    }
}
