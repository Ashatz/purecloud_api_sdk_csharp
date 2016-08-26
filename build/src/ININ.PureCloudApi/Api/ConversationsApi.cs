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
        string DeleteCallParticipantConsult (string callId, string participantId);

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
        ApiResponse<string> DeleteCallParticipantConsultWithHttpInfo (string callId, string participantId);
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
        void DeleteConversationParticipantCodesAddCommunicationCode (string conversationId, string participantId, string addCommunicationCode);

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
        ApiResponse<Object> DeleteConversationParticipantCodesAddCommunicationCodeWithHttpInfo (string conversationId, string participantId, string addCommunicationCode);
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
        string DeleteEmailMessagesDraftAttachment (string emailId, string attachmentId);

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
        ApiResponse<string> DeleteEmailMessagesDraftAttachmentWithHttpInfo (string emailId, string attachmentId);
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>CallConversation</returns>
        CallConversation GetCall (string callId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>ApiResponse of CallConversation</returns>
        ApiResponse<CallConversation> GetCallWithHttpInfo (string callId);
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
        Wrapup GetCallParticipantWrapup (string callId, string participantId, bool? provisional = null);

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
        ApiResponse<Wrapup> GetCallParticipantWrapupWithHttpInfo (string callId, string participantId, bool? provisional = null);
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
        List<WrapupCode> GetCallParticipantWrapupcodes (string callId, string participantId);

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
        ApiResponse<List<WrapupCode>> GetCallParticipantWrapupcodesWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>CallbackConversation</returns>
        CallbackConversation GetCallback (string callbackId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        ApiResponse<CallbackConversation> GetCallbackWithHttpInfo (string callbackId);
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
        Wrapup GetCallbackParticipantWrapup (string callbackId, string participantId, bool? provisional = null);

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
        ApiResponse<Wrapup> GetCallbackParticipantWrapupWithHttpInfo (string callbackId, string participantId, bool? provisional = null);
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
        List<WrapupCode> GetCallbackParticipantWrapupcodes (string callbackId, string participantId);

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
        ApiResponse<List<WrapupCode>> GetCallbackParticipantWrapupcodesWithHttpInfo (string callbackId, string participantId);
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
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ChatConversation</returns>
        ChatConversation GetChat (string chatId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        ApiResponse<ChatConversation> GetChatWithHttpInfo (string chatId);
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
        Wrapup GetChatParticipantWrapup (string chatId, string participantId, bool? provisional = null);

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
        ApiResponse<Wrapup> GetChatParticipantWrapupWithHttpInfo (string chatId, string participantId, bool? provisional = null);
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
        List<WrapupCode> GetChatParticipantWrapupcodes (string chatId, string participantId);

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
        ApiResponse<List<WrapupCode>> GetChatParticipantWrapupcodesWithHttpInfo (string chatId, string participantId);
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
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation GetConversation (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> GetConversationWithHttpInfo (string conversationId);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        AnalyticsConversation GetConversationDetails (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        ApiResponse<AnalyticsConversation> GetConversationDetailsWithHttpInfo (string conversationId);
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
        WrapupCode GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null);

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
        ApiResponse<WrapupCode> GetConversationParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
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
        List<WrapupCode> GetConversationParticipantWrapupcodes (string conversationId, string participantId);

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
        ApiResponse<List<WrapupCode>> GetConversationParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId);
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
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailConversation</returns>
        EmailConversation GetEmail (string emailId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        ApiResponse<EmailConversation> GetEmailWithHttpInfo (string emailId);
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
        EmailMessage GetEmailMessage (string emailId, string messageId);

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
        ApiResponse<EmailMessage> GetEmailMessageWithHttpInfo (string emailId, string messageId);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing GetEmailMessages (string emailId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> GetEmailMessagesWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetEmailMessagesDraft (string emailId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetEmailMessagesDraftWithHttpInfo (string emailId);
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
        Wrapup GetEmailParticipantWrapup (string emailId, string participantId, bool? provisional = null);

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
        ApiResponse<Wrapup> GetEmailParticipantWrapupWithHttpInfo (string emailId, string participantId, bool? provisional = null);
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
        List<WrapupCode> GetEmailParticipantWrapupcodes (string emailId, string participantId);

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
        ApiResponse<List<WrapupCode>> GetEmailParticipantWrapupcodesWithHttpInfo (string emailId, string participantId);
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
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchCall (string callId, Conversation body);

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
        ApiResponse<Conversation> PatchCallWithHttpInfo (string callId, Conversation body);
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
        void PatchCallParticipant (string callId, string participantId, MediaParticipantRequest body);

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
        ApiResponse<Object> PatchCallParticipantWithHttpInfo (string callId, string participantId, MediaParticipantRequest body);
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
        void PatchCallParticipantAttributes (string callId, string participantId, ParticipantAttributes body);

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
        ApiResponse<Object> PatchCallParticipantAttributesWithHttpInfo (string callId, string participantId, ParticipantAttributes body);
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
        /// <returns></returns>
        void PatchCallParticipantCommunication (string callId, string participantId, string communicationId, MediaParticipantRequest body);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallParticipantCommunicationWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body);
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
        ConsultTransferResponse PatchCallParticipantConsult (string callId, string participantId, ConsultTransferUpdate body);

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
        ApiResponse<ConsultTransferResponse> PatchCallParticipantConsultWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body);
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
        Conversation PatchCallback (string callbackId, Conversation body);

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
        ApiResponse<Conversation> PatchCallbackWithHttpInfo (string callbackId, Conversation body);
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
        void PatchCallbackParticipant (string callbackId, string participantId, MediaParticipantRequest body);

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
        ApiResponse<Object> PatchCallbackParticipantWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body);
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
        void PatchCallbackParticipantAttributes (string callbackId, string participantId, ParticipantAttributes body);

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
        ApiResponse<Object> PatchCallbackParticipantAttributesWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body);
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
        /// <returns></returns>
        void PatchCallbackParticipantCommunication (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallbackParticipantCommunicationWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);
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
        Conversation PatchChat (string chatId, Conversation body);

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
        ApiResponse<Conversation> PatchChatWithHttpInfo (string chatId, Conversation body);
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
        void PatchChatParticipant (string chatId, string participantId, MediaParticipantRequest body);

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
        ApiResponse<Object> PatchChatParticipantWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body);
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
        void PatchChatParticipantAttributes (string chatId, string participantId, ParticipantAttributes body);

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
        ApiResponse<Object> PatchChatParticipantAttributesWithHttpInfo (string chatId, string participantId, ParticipantAttributes body);
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
        /// <returns></returns>
        void PatchChatParticipantCommunication (string chatId, string participantId, string communicationId, MediaParticipantRequest body);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchChatParticipantCommunicationWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body);
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
        void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body);

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
        ApiResponse<Object> PatchConversationParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
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
        void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body);

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
        ApiResponse<Object> PatchConversationParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
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
        Conversation PatchEmail (string emailId, Conversation body);

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
        ApiResponse<Conversation> PatchEmailWithHttpInfo (string emailId, Conversation body);
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
        void PatchEmailParticipant (string emailId, string participantId, MediaParticipantRequest body);

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
        ApiResponse<Object> PatchEmailParticipantWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body);
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
        void PatchEmailParticipantAttributes (string emailId, string participantId, ParticipantAttributes body);

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
        ApiResponse<Object> PatchEmailParticipantAttributesWithHttpInfo (string emailId, string participantId, ParticipantAttributes body);
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
        Conversation PostCall (string callId, CallCommand body);

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
        ApiResponse<Conversation> PostCallWithHttpInfo (string callId, CallCommand body);
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
        ConsultTransferResponse PostCallParticipantConsult (string callId, string participantId, ConsultTransfer body);

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
        ApiResponse<ConsultTransferResponse> PostCallParticipantConsultWithHttpInfo (string callId, string participantId, ConsultTransfer body);
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
        void PostCallParticipantMonitor (string callId, string participantId);

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
        ApiResponse<Object> PostCallParticipantMonitorWithHttpInfo (string callId, string participantId);
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
        void PostCallParticipantReplace (string callId, string participantId, TransferRequest body);

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
        ApiResponse<Object> PostCallParticipantReplaceWithHttpInfo (string callId, string participantId, TransferRequest body);
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
        Conversation PostCallParticipants (string callId, Conversation body);

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
        ApiResponse<Conversation> PostCallParticipantsWithHttpInfo (string callId, Conversation body);
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
        void PostCallbackParticipantReplace (string callbackId, string participantId, TransferRequest body);

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
        ApiResponse<Object> PostCallbackParticipantReplaceWithHttpInfo (string callbackId, string participantId, TransferRequest body);
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
        void PostChatParticipantReplace (string chatId, string participantId, TransferRequest body);

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
        ApiResponse<Object> PostChatParticipantReplaceWithHttpInfo (string chatId, string participantId, TransferRequest body);
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
        PropertyIndexRequest PostConversationDetailsProperties (string conversationId, PropertyIndexRequest body);

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
        ApiResponse<PropertyIndexRequest> PostConversationDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body);
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
        void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null);

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
        ApiResponse<Object> PostConversationParticipantCallbacksWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null);
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
        void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body);

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
        ApiResponse<Object> PostConversationParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body);
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
        EmailMessage PostEmailMessages (string emailId, EmailMessage body);

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
        ApiResponse<EmailMessage> PostEmailMessagesWithHttpInfo (string emailId, EmailMessage body);
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
        void PostEmailParticipantReplace (string emailId, string participantId, TransferRequest body);

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
        ApiResponse<Object> PostEmailParticipantReplaceWithHttpInfo (string emailId, string participantId, TransferRequest body);
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
        EmailMessage PutEmailMessagesDraft (string emailId, EmailMessage body);

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
        ApiResponse<EmailMessage> PutEmailMessagesDraftWithHttpInfo (string emailId, EmailMessage body);
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
        System.Threading.Tasks.Task<string> DeleteCallParticipantConsultAsync (string callId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallParticipantConsultAsyncWithHttpInfo (string callId, string participantId);
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
        System.Threading.Tasks.Task DeleteConversationParticipantCodesAddCommunicationCodeAsync (string conversationId, string participantId, string addCommunicationCode);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationParticipantCodesAddCommunicationCodeAsyncWithHttpInfo (string conversationId, string participantId, string addCommunicationCode);
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
        System.Threading.Tasks.Task<string> DeleteEmailMessagesDraftAttachmentAsync (string emailId, string attachmentId);

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
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailMessagesDraftAttachmentAsyncWithHttpInfo (string emailId, string attachmentId);
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of CallConversation</returns>
        System.Threading.Tasks.Task<CallConversation> GetCallAsync (string callId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetCallAsyncWithHttpInfo (string callId);
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
        System.Threading.Tasks.Task<Wrapup> GetCallParticipantWrapupAsync (string callId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallParticipantWrapupAsyncWithHttpInfo (string callId, string participantId, bool? provisional = null);
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
        System.Threading.Tasks.Task<List<WrapupCode>> GetCallParticipantWrapupcodesAsync (string callId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallParticipantWrapupcodesAsyncWithHttpInfo (string callId, string participantId);
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of CallbackConversation</returns>
        System.Threading.Tasks.Task<CallbackConversation> GetCallbackAsync (string callbackId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetCallbackAsyncWithHttpInfo (string callbackId);
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
        System.Threading.Tasks.Task<Wrapup> GetCallbackParticipantWrapupAsync (string callbackId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallbackParticipantWrapupAsyncWithHttpInfo (string callbackId, string participantId, bool? provisional = null);
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
        System.Threading.Tasks.Task<List<WrapupCode>> GetCallbackParticipantWrapupcodesAsync (string callbackId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallbackParticipantWrapupcodesAsyncWithHttpInfo (string callbackId, string participantId);
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
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ChatConversation</returns>
        System.Threading.Tasks.Task<ChatConversation> GetChatAsync (string chatId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetChatAsyncWithHttpInfo (string chatId);
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
        System.Threading.Tasks.Task<Wrapup> GetChatParticipantWrapupAsync (string chatId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetChatParticipantWrapupAsyncWithHttpInfo (string chatId, string participantId, bool? provisional = null);
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
        System.Threading.Tasks.Task<List<WrapupCode>> GetChatParticipantWrapupcodesAsync (string chatId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetChatParticipantWrapupcodesAsyncWithHttpInfo (string chatId, string participantId);
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
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> GetConversationAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        System.Threading.Tasks.Task<AnalyticsConversation> GetConversationDetailsAsync (string conversationId);

        /// <summary>
        /// Get a conversation by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetConversationDetailsAsyncWithHttpInfo (string conversationId);
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
        System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
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
        System.Threading.Tasks.Task<List<WrapupCode>> GetConversationParticipantWrapupcodesAsync (string conversationId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
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
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailConversation</returns>
        System.Threading.Tasks.Task<EmailConversation> GetEmailAsync (string emailId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetEmailAsyncWithHttpInfo (string emailId);
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
        System.Threading.Tasks.Task<EmailMessage> GetEmailMessageAsync (string emailId, string messageId);

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
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailMessageAsyncWithHttpInfo (string emailId, string messageId);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> GetEmailMessagesAsync (string emailId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetEmailMessagesAsyncWithHttpInfo (string emailId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetEmailMessagesDraftAsync (string emailId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailMessagesDraftAsyncWithHttpInfo (string emailId);
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
        System.Threading.Tasks.Task<Wrapup> GetEmailParticipantWrapupAsync (string emailId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetEmailParticipantWrapupAsyncWithHttpInfo (string emailId, string participantId, bool? provisional = null);
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
        System.Threading.Tasks.Task<List<WrapupCode>> GetEmailParticipantWrapupcodesAsync (string emailId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetEmailParticipantWrapupcodesAsyncWithHttpInfo (string emailId, string participantId);
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
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchCallAsync (string callId, Conversation body);

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
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallAsyncWithHttpInfo (string callId, Conversation body);
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
        System.Threading.Tasks.Task PatchCallParticipantAsync (string callId, string participantId, MediaParticipantRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallParticipantAsyncWithHttpInfo (string callId, string participantId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task PatchCallParticipantAttributesAsync (string callId, string participantId, ParticipantAttributes body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallParticipantAttributesAsyncWithHttpInfo (string callId, string participantId, ParticipantAttributes body);
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallParticipantCommunicationAsync (string callId, string participantId, string communicationId, MediaParticipantRequest body);

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
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallParticipantCommunicationAsyncWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task<ConsultTransferResponse> PatchCallParticipantConsultAsync (string callId, string participantId, ConsultTransferUpdate body);

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
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchCallParticipantConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body);
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
        System.Threading.Tasks.Task<Conversation> PatchCallbackAsync (string callbackId, Conversation body);

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
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallbackAsyncWithHttpInfo (string callbackId, Conversation body);
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
        System.Threading.Tasks.Task PatchCallbackParticipantAsync (string callbackId, string participantId, MediaParticipantRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbackParticipantAsyncWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task PatchCallbackParticipantAttributesAsync (string callbackId, string participantId, ParticipantAttributes body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbackParticipantAttributesAsyncWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body);
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallbackParticipantCommunicationAsync (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);

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
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbackParticipantCommunicationAsyncWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task<Conversation> PatchChatAsync (string chatId, Conversation body);

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
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchChatAsyncWithHttpInfo (string chatId, Conversation body);
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
        System.Threading.Tasks.Task PatchChatParticipantAsync (string chatId, string participantId, MediaParticipantRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatParticipantAsyncWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task PatchChatParticipantAttributesAsync (string chatId, string participantId, ParticipantAttributes body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatParticipantAttributesAsyncWithHttpInfo (string chatId, string participantId, ParticipantAttributes body);
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
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchChatParticipantCommunicationAsync (string chatId, string participantId, string communicationId, MediaParticipantRequest body);

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
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatParticipantCommunicationAsyncWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task PatchConversationParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task PatchConversationParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body);
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
        System.Threading.Tasks.Task<Conversation> PatchEmailAsync (string emailId, Conversation body);

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
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchEmailAsyncWithHttpInfo (string emailId, Conversation body);
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
        System.Threading.Tasks.Task PatchEmailParticipantAsync (string emailId, string participantId, MediaParticipantRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailParticipantAsyncWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body);
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
        System.Threading.Tasks.Task PatchEmailParticipantAttributesAsync (string emailId, string participantId, ParticipantAttributes body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailParticipantAttributesAsyncWithHttpInfo (string emailId, string participantId, ParticipantAttributes body);
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
        System.Threading.Tasks.Task<Conversation> PostCallAsync (string callId, CallCommand body);

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
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallAsyncWithHttpInfo (string callId, CallCommand body);
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
        System.Threading.Tasks.Task<ConsultTransferResponse> PostCallParticipantConsultAsync (string callId, string participantId, ConsultTransfer body);

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
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostCallParticipantConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransfer body);
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
        System.Threading.Tasks.Task PostCallParticipantMonitorAsync (string callId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallParticipantMonitorAsyncWithHttpInfo (string callId, string participantId);
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
        System.Threading.Tasks.Task PostCallParticipantReplaceAsync (string callId, string participantId, TransferRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallParticipantReplaceAsyncWithHttpInfo (string callId, string participantId, TransferRequest body);
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
        System.Threading.Tasks.Task<Conversation> PostCallParticipantsAsync (string callId, Conversation body);

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
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallParticipantsAsyncWithHttpInfo (string callId, Conversation body);
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
        System.Threading.Tasks.Task PostCallbackParticipantReplaceAsync (string callbackId, string participantId, TransferRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallbackParticipantReplaceAsyncWithHttpInfo (string callbackId, string participantId, TransferRequest body);
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
        System.Threading.Tasks.Task PostChatParticipantReplaceAsync (string chatId, string participantId, TransferRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostChatParticipantReplaceAsyncWithHttpInfo (string chatId, string participantId, TransferRequest body);
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
        System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body);
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
        System.Threading.Tasks.Task PostConversationParticipantCallbacksAsync (string conversationId, string participantId, CreateCallbackCommand body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null);
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
        System.Threading.Tasks.Task PostConversationParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body);
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
        System.Threading.Tasks.Task<EmailMessage> PostEmailMessagesAsync (string emailId, EmailMessage body);

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
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostEmailMessagesAsyncWithHttpInfo (string emailId, EmailMessage body);
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
        System.Threading.Tasks.Task PostEmailParticipantReplaceAsync (string emailId, string participantId, TransferRequest body);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEmailParticipantReplaceAsyncWithHttpInfo (string emailId, string participantId, TransferRequest body);
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
        System.Threading.Tasks.Task<EmailMessage> PutEmailMessagesDraftAsync (string emailId, EmailMessage body);

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
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutEmailMessagesDraftAsyncWithHttpInfo (string emailId, EmailMessage body);
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
        public string DeleteCallParticipantConsult (string callId, string participantId)
        {
             ApiResponse<string> localVarResponse = DeleteCallParticipantConsultWithHttpInfo(callId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteCallParticipantConsultWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->DeleteCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteCallParticipantConsult");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteCallParticipantConsultAsync (string callId, string participantId)
        {
             ApiResponse<string> localVarResponse = await DeleteCallParticipantConsultAsyncWithHttpInfo(callId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallParticipantConsultAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->DeleteCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteCallParticipantConsult");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void DeleteConversationParticipantCodesAddCommunicationCode (string conversationId, string participantId, string addCommunicationCode)
        {
             DeleteConversationParticipantCodesAddCommunicationCodeWithHttpInfo(conversationId, participantId, addCommunicationCode);
        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationParticipantCodesAddCommunicationCodeWithHttpInfo (string conversationId, string participantId, string addCommunicationCode)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationParticipantCodesAddCommunicationCode");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationParticipantCodesAddCommunicationCode");
            // verify the required parameter 'addCommunicationCode' is set
            if (addCommunicationCode == null)
                throw new ApiException(400, "Missing required parameter 'addCommunicationCode' when calling ConversationsApi->DeleteConversationParticipantCodesAddCommunicationCode");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCodesAddCommunicationCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCodesAddCommunicationCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task DeleteConversationParticipantCodesAddCommunicationCodeAsync (string conversationId, string participantId, string addCommunicationCode)
        {
             await DeleteConversationParticipantCodesAddCommunicationCodeAsyncWithHttpInfo(conversationId, participantId, addCommunicationCode);

        }

        /// <summary>
        /// Delete a code used to add a communication to this participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="addCommunicationCode">addCommunicationCode</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationParticipantCodesAddCommunicationCodeAsyncWithHttpInfo (string conversationId, string participantId, string addCommunicationCode)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationParticipantCodesAddCommunicationCode");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationParticipantCodesAddCommunicationCode");
            // verify the required parameter 'addCommunicationCode' is set
            if (addCommunicationCode == null)
                throw new ApiException(400, "Missing required parameter 'addCommunicationCode' when calling ConversationsApi->DeleteConversationParticipantCodesAddCommunicationCode");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCodesAddCommunicationCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationParticipantCodesAddCommunicationCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>string</returns>
        public string DeleteEmailMessagesDraftAttachment (string emailId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = DeleteEmailMessagesDraftAttachmentWithHttpInfo(emailId, attachmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEmailMessagesDraftAttachmentWithHttpInfo (string emailId, string attachmentId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->DeleteEmailMessagesDraftAttachment");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteEmailMessagesDraftAttachment");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailMessagesDraftAttachment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailMessagesDraftAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEmailMessagesDraftAttachmentAsync (string emailId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = await DeleteEmailMessagesDraftAttachmentAsyncWithHttpInfo(emailId, attachmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="attachmentId">attachmentId</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailMessagesDraftAttachmentAsyncWithHttpInfo (string emailId, string attachmentId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->DeleteEmailMessagesDraftAttachment");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteEmailMessagesDraftAttachment");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailMessagesDraftAttachment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailMessagesDraftAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>CallConversation</returns>
        public CallConversation GetCall (string callId)
        {
             ApiResponse<CallConversation> localVarResponse = GetCallWithHttpInfo(callId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>ApiResponse of CallConversation</returns>
        public ApiResponse< CallConversation > GetCallWithHttpInfo (string callId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCall");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of CallConversation</returns>
        public async System.Threading.Tasks.Task<CallConversation> GetCallAsync (string callId)
        {
             ApiResponse<CallConversation> localVarResponse = await GetCallAsyncWithHttpInfo(callId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetCallAsyncWithHttpInfo (string callId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCall");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public Wrapup GetCallParticipantWrapup (string callId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetCallParticipantWrapupWithHttpInfo(callId, participantId, provisional);
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
        public ApiResponse< Wrapup > GetCallParticipantWrapupWithHttpInfo (string callId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<Wrapup> GetCallParticipantWrapupAsync (string callId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetCallParticipantWrapupAsyncWithHttpInfo(callId, participantId, provisional);
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
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallParticipantWrapupAsyncWithHttpInfo (string callId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetCallParticipantWrapupcodes (string callId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetCallParticipantWrapupcodesWithHttpInfo(callId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetCallParticipantWrapupcodesWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetCallParticipantWrapupcodesAsync (string callId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetCallParticipantWrapupcodesAsyncWithHttpInfo(callId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallParticipantWrapupcodesAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->GetCallParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>CallbackConversation</returns>
        public CallbackConversation GetCallback (string callbackId)
        {
             ApiResponse<CallbackConversation> localVarResponse = GetCallbackWithHttpInfo(callbackId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        public ApiResponse< CallbackConversation > GetCallbackWithHttpInfo (string callbackId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallback");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallback: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of CallbackConversation</returns>
        public async System.Threading.Tasks.Task<CallbackConversation> GetCallbackAsync (string callbackId)
        {
             ApiResponse<CallbackConversation> localVarResponse = await GetCallbackAsyncWithHttpInfo(callbackId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetCallbackAsyncWithHttpInfo (string callbackId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallback");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallback: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public Wrapup GetCallbackParticipantWrapup (string callbackId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetCallbackParticipantWrapupWithHttpInfo(callbackId, participantId, provisional);
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
        public ApiResponse< Wrapup > GetCallbackParticipantWrapupWithHttpInfo (string callbackId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbackParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbackParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<Wrapup> GetCallbackParticipantWrapupAsync (string callbackId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetCallbackParticipantWrapupAsyncWithHttpInfo(callbackId, participantId, provisional);
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
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetCallbackParticipantWrapupAsyncWithHttpInfo (string callbackId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbackParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbackParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetCallbackParticipantWrapupcodes (string callbackId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetCallbackParticipantWrapupcodesWithHttpInfo(callbackId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetCallbackParticipantWrapupcodesWithHttpInfo (string callbackId, string participantId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbackParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbackParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetCallbackParticipantWrapupcodesAsync (string callbackId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetCallbackParticipantWrapupcodesAsyncWithHttpInfo(callbackId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetCallbackParticipantWrapupcodesAsyncWithHttpInfo (string callbackId, string participantId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->GetCallbackParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetCallbackParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbackParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallbackConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversationEntityListing)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversationEntityListing)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsHistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsMaximumconferenceparties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ChatConversation</returns>
        public ChatConversation GetChat (string chatId)
        {
             ApiResponse<ChatConversation> localVarResponse = GetChatWithHttpInfo(chatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>ApiResponse of ChatConversation</returns>
        public ApiResponse< ChatConversation > GetChatWithHttpInfo (string chatId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChat");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChat: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ChatConversation</returns>
        public async System.Threading.Tasks.Task<ChatConversation> GetChatAsync (string chatId)
        {
             ApiResponse<ChatConversation> localVarResponse = await GetChatAsyncWithHttpInfo(chatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetChatAsyncWithHttpInfo (string chatId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChat");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChat: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public Wrapup GetChatParticipantWrapup (string chatId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetChatParticipantWrapupWithHttpInfo(chatId, participantId, provisional);
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
        public ApiResponse< Wrapup > GetChatParticipantWrapupWithHttpInfo (string chatId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<Wrapup> GetChatParticipantWrapupAsync (string chatId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetChatParticipantWrapupAsyncWithHttpInfo(chatId, participantId, provisional);
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
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetChatParticipantWrapupAsyncWithHttpInfo (string chatId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetChatParticipantWrapupcodes (string chatId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetChatParticipantWrapupcodesWithHttpInfo(chatId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetChatParticipantWrapupcodesWithHttpInfo (string chatId, string participantId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetChatParticipantWrapupcodesAsync (string chatId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetChatParticipantWrapupcodesAsyncWithHttpInfo(chatId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetChatParticipantWrapupcodesAsyncWithHttpInfo (string chatId, string participantId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->GetChatParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetChatParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChats: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChatConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversationEntityListing)));
            
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        public Conversation GetConversation (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = GetConversationWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > GetConversationWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversation");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> GetConversationAsync (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = await GetConversationAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversation");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>AnalyticsConversation</returns>
        public AnalyticsConversation GetConversationDetails (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = GetConversationDetailsWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>ApiResponse of AnalyticsConversation</returns>
        public ApiResponse< AnalyticsConversation > GetConversationDetailsWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationDetails");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationDetails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
            
        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of AnalyticsConversation</returns>
        public async System.Threading.Tasks.Task<AnalyticsConversation> GetConversationDetailsAsync (string conversationId)
        {
             ApiResponse<AnalyticsConversation> localVarResponse = await GetConversationDetailsAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a conversation by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <returns>Task of ApiResponse (AnalyticsConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversation>> GetConversationDetailsAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationDetails");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationDetails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversation)));
            
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetConversationParticipantWrapupWithHttpInfo(conversationId, participantId, provisional);
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
        public ApiResponse< WrapupCode > GetConversationParticipantWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetConversationParticipantWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
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
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetConversationParticipantWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetConversationParticipantWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetConversationParticipantWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetConversationParticipantWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetConversationParticipantWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetConversationParticipantWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetConversationParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationEntityListing)));
            
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailConversation</returns>
        public EmailConversation GetEmail (string emailId)
        {
             ApiResponse<EmailConversation> localVarResponse = GetEmailWithHttpInfo(emailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailConversation</returns>
        public ApiResponse< EmailConversation > GetEmailWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmail");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailConversation</returns>
        public async System.Threading.Tasks.Task<EmailConversation> GetEmailAsync (string emailId)
        {
             ApiResponse<EmailConversation> localVarResponse = await GetEmailAsyncWithHttpInfo(emailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetEmailAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmail");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage GetEmailMessage (string emailId, string messageId)
        {
             ApiResponse<EmailMessage> localVarResponse = GetEmailMessageWithHttpInfo(emailId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetEmailMessageWithHttpInfo (string emailId, string messageId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ConversationsApi->GetEmailMessage");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetEmailMessageAsync (string emailId, string messageId)
        {
             ApiResponse<EmailMessage> localVarResponse = await GetEmailMessageAsyncWithHttpInfo(emailId, messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="messageId">messageId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailMessageAsyncWithHttpInfo (string emailId, string messageId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailMessage");
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ConversationsApi->GetEmailMessage");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing GetEmailMessages (string emailId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = GetEmailMessagesWithHttpInfo(emailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > GetEmailMessagesWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailMessages");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> GetEmailMessagesAsync (string emailId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = await GetEmailMessagesAsyncWithHttpInfo(emailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetEmailMessagesAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailMessages");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage GetEmailMessagesDraft (string emailId)
        {
             ApiResponse<EmailMessage> localVarResponse = GetEmailMessagesDraftWithHttpInfo(emailId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetEmailMessagesDraftWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailMessagesDraft");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetEmailMessagesDraftAsync (string emailId)
        {
             ApiResponse<EmailMessage> localVarResponse = await GetEmailMessagesDraftAsyncWithHttpInfo(emailId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailMessagesDraftAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailMessagesDraft");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public Wrapup GetEmailParticipantWrapup (string emailId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = GetEmailParticipantWrapupWithHttpInfo(emailId, participantId, provisional);
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
        public ApiResponse< Wrapup > GetEmailParticipantWrapupWithHttpInfo (string emailId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<Wrapup> GetEmailParticipantWrapupAsync (string emailId, string participantId, bool? provisional = null)
        {
             ApiResponse<Wrapup> localVarResponse = await GetEmailParticipantWrapupAsyncWithHttpInfo(emailId, participantId, provisional);
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
        public async System.Threading.Tasks.Task<ApiResponse<Wrapup>> GetEmailParticipantWrapupAsyncWithHttpInfo (string emailId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailParticipantWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailParticipantWrapup");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Wrapup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Wrapup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Wrapup)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>List&lt;WrapupCode&gt;</returns>
        public List<WrapupCode> GetEmailParticipantWrapupcodes (string emailId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = GetEmailParticipantWrapupcodesWithHttpInfo(emailId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of List&lt;WrapupCode&gt;</returns>
        public ApiResponse< List<WrapupCode> > GetEmailParticipantWrapupcodesWithHttpInfo (string emailId, string participantId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of List&lt;WrapupCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<WrapupCode>> GetEmailParticipantWrapupcodesAsync (string emailId, string participantId)
        {
             ApiResponse<List<WrapupCode>> localVarResponse = await GetEmailParticipantWrapupcodesAsyncWithHttpInfo(emailId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse (List&lt;WrapupCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WrapupCode>>> GetEmailParticipantWrapupcodesAsyncWithHttpInfo (string emailId, string participantId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->GetEmailParticipantWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetEmailParticipantWrapupcodes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailParticipantWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WrapupCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WrapupCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WrapupCode>)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversationEntityListing)));
            
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchCall (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchCallWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchCallWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCall");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchCallAsync (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchCallAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallAsyncWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCall");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchCallParticipant (string callId, string participantId, MediaParticipantRequest body)
        {
             PatchCallParticipantWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallParticipantWithHttpInfo (string callId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchCallParticipantAsync (string callId, string participantId, MediaParticipantRequest body)
        {
             await PatchCallParticipantAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallParticipantAsyncWithHttpInfo (string callId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchCallParticipantAttributes (string callId, string participantId, ParticipantAttributes body)
        {
             PatchCallParticipantAttributesWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallParticipantAttributesWithHttpInfo (string callId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchCallParticipantAttributesAsync (string callId, string participantId, ParticipantAttributes body)
        {
             await PatchCallParticipantAttributesAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallParticipantAttributesAsyncWithHttpInfo (string callId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// <returns></returns>
        public void PatchCallParticipantCommunication (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             PatchCallParticipantCommunicationWithHttpInfo(callId, participantId, communicationId, body);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallParticipantCommunicationWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipantCommunication");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallParticipantCommunicationAsync (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             await PatchCallParticipantCommunicationAsyncWithHttpInfo(callId, participantId, communicationId, body);

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallParticipantCommunicationAsyncWithHttpInfo (string callId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipantCommunication");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PatchCallParticipantConsult (string callId, string participantId, ConsultTransferUpdate body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PatchCallParticipantConsultWithHttpInfo(callId, participantId, body);
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
        public ApiResponse< ConsultTransferResponse > PatchCallParticipantConsultWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipantConsult");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PatchCallParticipantConsultAsync (string callId, string participantId, ConsultTransferUpdate body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PatchCallParticipantConsultAsyncWithHttpInfo(callId, participantId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchCallParticipantConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallParticipantConsult");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchCallback (string callbackId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchCallbackWithHttpInfo(callbackId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchCallbackWithHttpInfo (string callbackId, Conversation body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallback");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallback");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallback: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchCallbackAsync (string callbackId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchCallbackAsyncWithHttpInfo(callbackId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallbackAsyncWithHttpInfo (string callbackId, Conversation body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallback");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallback");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallback: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallback: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchCallbackParticipant (string callbackId, string participantId, MediaParticipantRequest body)
        {
             PatchCallbackParticipantWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbackParticipantWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbackParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbackParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbackParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchCallbackParticipantAsync (string callbackId, string participantId, MediaParticipantRequest body)
        {
             await PatchCallbackParticipantAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbackParticipantAsyncWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbackParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbackParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbackParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchCallbackParticipantAttributes (string callbackId, string participantId, ParticipantAttributes body)
        {
             PatchCallbackParticipantAttributesWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbackParticipantAttributesWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbackParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbackParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbackParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchCallbackParticipantAttributesAsync (string callbackId, string participantId, ParticipantAttributes body)
        {
             await PatchCallbackParticipantAttributesAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbackParticipantAttributesAsyncWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbackParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbackParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbackParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// <returns></returns>
        public void PatchCallbackParticipantCommunication (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             PatchCallbackParticipantCommunicationWithHttpInfo(callbackId, participantId, communicationId, body);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbackParticipantCommunicationWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbackParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbackParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallbackParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbackParticipantCommunication");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallbackParticipantCommunicationAsync (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             await PatchCallbackParticipantCommunicationAsyncWithHttpInfo(callbackId, participantId, communicationId, body);

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbackParticipantCommunicationAsyncWithHttpInfo (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbackParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbackParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchCallbackParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchCallbackParticipantCommunication");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbackParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchChat (string chatId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchChatWithHttpInfo(chatId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchChatWithHttpInfo (string chatId, Conversation body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChat");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChat");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChat: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchChatAsync (string chatId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchChatAsyncWithHttpInfo(chatId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchChatAsyncWithHttpInfo (string chatId, Conversation body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChat");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChat");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChat: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChat: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchChatParticipant (string chatId, string participantId, MediaParticipantRequest body)
        {
             PatchChatParticipantWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatParticipantWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchChatParticipantAsync (string chatId, string participantId, MediaParticipantRequest body)
        {
             await PatchChatParticipantAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatParticipantAsyncWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchChatParticipantAttributes (string chatId, string participantId, ParticipantAttributes body)
        {
             PatchChatParticipantAttributesWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatParticipantAttributesWithHttpInfo (string chatId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchChatParticipantAttributesAsync (string chatId, string participantId, ParticipantAttributes body)
        {
             await PatchChatParticipantAttributesAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatParticipantAttributesAsyncWithHttpInfo (string chatId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// <returns></returns>
        public void PatchChatParticipantCommunication (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             PatchChatParticipantCommunicationWithHttpInfo(chatId, participantId, communicationId, body);
        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatParticipantCommunicationWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchChatParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatParticipantCommunication");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchChatParticipantCommunicationAsync (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
             await PatchChatParticipantCommunicationAsyncWithHttpInfo(chatId, participantId, communicationId, body);

        }

        /// <summary>
        /// Update conversation participant&#39;s communication by disconnecting it. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="communicationId">communicationId</param>
        /// <param name="body">Participant</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatParticipantCommunicationAsyncWithHttpInfo (string chatId, string participantId, string communicationId, MediaParticipantRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatParticipantCommunication");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatParticipantCommunication");
            // verify the required parameter 'communicationId' is set
            if (communicationId == null)
                throw new ApiException(400, "Missing required parameter 'communicationId' when calling ConversationsApi->PatchChatParticipantCommunication");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchChatParticipantCommunication");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantCommunication: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatParticipantCommunication: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns></returns>
        public void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)
        {
             PatchConversationParticipantWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationParticipantWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchConversationParticipantAsync (string conversationId, string participantId, MediaParticipantRequest body)
        {
             await PatchConversationParticipantAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)
        {
             PatchConversationParticipantAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationParticipantAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchConversationParticipantAttributesAsync (string conversationId, string participantId, ParticipantAttributes body)
        {
             await PatchConversationParticipantAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationParticipantAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchConversationParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PatchEmail (string emailId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PatchEmailWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchEmailWithHttpInfo (string emailId, Conversation body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmail");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmail");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchEmailAsync (string emailId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PatchEmailAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a conversation by disconnecting all of the participants 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchEmailAsyncWithHttpInfo (string emailId, Conversation body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmail");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmail");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchEmailParticipant (string emailId, string participantId, MediaParticipantRequest body)
        {
             PatchEmailParticipantWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchEmailParticipantWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchEmailParticipantAsync (string emailId, string participantId, MediaParticipantRequest body)
        {
             await PatchEmailParticipantAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Update request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailParticipantAsyncWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailParticipant");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailParticipant");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailParticipant");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipant: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipant: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PatchEmailParticipantAttributes (string emailId, string participantId, ParticipantAttributes body)
        {
             PatchEmailParticipantAttributesWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchEmailParticipantAttributesWithHttpInfo (string emailId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PatchEmailParticipantAttributesAsync (string emailId, string participantId, ParticipantAttributes body)
        {
             await PatchEmailParticipantAttributesAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Participant attributes</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailParticipantAttributesAsyncWithHttpInfo (string emailId, string participantId, ParticipantAttributes body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailParticipantAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailParticipantAttributes");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PatchEmailParticipantAttributes");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipantAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailParticipantAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PostCall (string callId, CallCommand body)
        {
             ApiResponse<Conversation> localVarResponse = PostCallWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostCallWithHttpInfo (string callId, CallCommand body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCall");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostCallAsync (string callId, CallCommand body)
        {
             ApiResponse<Conversation> localVarResponse = await PostCallAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallAsyncWithHttpInfo (string callId, CallCommand body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCall");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCall");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public ConsultTransferResponse PostCallParticipantConsult (string callId, string participantId, ConsultTransfer body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PostCallParticipantConsultWithHttpInfo(callId, participantId, body);
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
        public ApiResponse< ConsultTransferResponse > PostCallParticipantConsultWithHttpInfo (string callId, string participantId, ConsultTransfer body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallParticipantConsult");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PostCallParticipantConsultAsync (string callId, string participantId, ConsultTransfer body)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PostCallParticipantConsultAsyncWithHttpInfo(callId, participantId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostCallParticipantConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransfer body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipantConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallParticipantConsult");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallParticipantConsult");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns></returns>
        public void PostCallParticipantMonitor (string callId, string participantId)
        {
             PostCallParticipantMonitorWithHttpInfo(callId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallParticipantMonitorWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipantMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallParticipantMonitor");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantMonitor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallParticipantMonitorAsync (string callId, string participantId)
        {
             await PostCallParticipantMonitorAsyncWithHttpInfo(callId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallParticipantMonitorAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipantMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallParticipantMonitor");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantMonitor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PostCallParticipantReplace (string callId, string participantId, TransferRequest body)
        {
             PostCallParticipantReplaceWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallParticipantReplaceWithHttpInfo (string callId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PostCallParticipantReplaceAsync (string callId, string participantId, TransferRequest body)
        {
             await PostCallParticipantReplaceAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallParticipantReplaceAsyncWithHttpInfo (string callId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        public Conversation PostCallParticipants (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = PostCallParticipantsWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostCallParticipantsWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipants");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallParticipants");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostCallParticipantsAsync (string callId, Conversation body)
        {
             ApiResponse<Conversation> localVarResponse = await PostCallParticipantsAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">callId</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallParticipantsAsyncWithHttpInfo (string callId, Conversation body)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallParticipants");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallParticipants");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostCallbackParticipantReplace (string callbackId, string participantId, TransferRequest body)
        {
             PostCallbackParticipantReplaceWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallbackParticipantReplaceWithHttpInfo (string callbackId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PostCallbackParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallbackParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallbackParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbackParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbackParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PostCallbackParticipantReplaceAsync (string callbackId, string participantId, TransferRequest body)
        {
             await PostCallbackParticipantReplaceAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId">callbackId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallbackParticipantReplaceAsyncWithHttpInfo (string callbackId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PostCallbackParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallbackParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostCallbackParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbackParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbackParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallbackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallbackResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCallbackResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallbackResponse)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCallResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallResponse)));
            
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns></returns>
        public void PostChatParticipantReplace (string chatId, string participantId, TransferRequest body)
        {
             PostChatParticipantReplaceWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostChatParticipantReplaceWithHttpInfo (string chatId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PostChatParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostChatParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostChatParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PostChatParticipantReplaceAsync (string chatId, string participantId, TransferRequest body)
        {
             await PostChatParticipantReplaceAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">chatId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostChatParticipantReplaceAsyncWithHttpInfo (string chatId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PostChatParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostChatParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostChatParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostChatParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>PropertyIndexRequest</returns>
        public PropertyIndexRequest PostConversationDetailsProperties (string conversationId, PropertyIndexRequest body)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = PostConversationDetailsPropertiesWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>ApiResponse of PropertyIndexRequest</returns>
        public ApiResponse< PropertyIndexRequest > PostConversationDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationDetailsProperties");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationDetailsProperties");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDetailsProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of PropertyIndexRequest</returns>
        public async System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body)
        {
             ApiResponse<PropertyIndexRequest> localVarResponse = await PostConversationDetailsPropertiesAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param>
        /// <param name="body">request</param>
        /// <returns>Task of ApiResponse (PropertyIndexRequest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationDetailsProperties");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationDetailsProperties");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDetailsProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
             PostConversationParticipantCallbacksWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationParticipantCallbacksWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantCallbacks");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PostConversationParticipantCallbacksAsync (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
             await PostConversationParticipantCallbacksAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Create a new callback for the specified participant on the conversation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantCallbacks");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)
        {
             PostConversationParticipantReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationParticipantReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PostConversationParticipantReplaceAsync (string conversationId, string participantId, TransferRequest body)
        {
             await PostConversationParticipantReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationParticipantReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostConversationParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsDetailsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsConversationQueryResponse)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage PostEmailMessages (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = PostEmailMessagesWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PostEmailMessagesWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailMessages");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PostEmailMessagesAsync (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = await PostEmailMessagesAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostEmailMessagesAsyncWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailMessages");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailMessages");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public void PostEmailParticipantReplace (string emailId, string participantId, TransferRequest body)
        {
             PostEmailParticipantReplaceWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostEmailParticipantReplaceWithHttpInfo (string emailId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostEmailParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        public async System.Threading.Tasks.Task PostEmailParticipantReplaceAsync (string emailId, string participantId, TransferRequest body)
        {
             await PostEmailParticipantReplaceAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="participantId">participantId</param>
        /// <param name="body">Transfer request</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostEmailParticipantReplaceAsyncWithHttpInfo (string emailId, string participantId, TransferRequest body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailParticipantReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostEmailParticipantReplace");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostEmailParticipantReplace");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailParticipantReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailParticipantReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage PutEmailMessagesDraft (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = PutEmailMessagesDraftWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PutEmailMessagesDraftWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PutEmailMessagesDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PutEmailMessagesDraft");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PutEmailMessagesDraftAsync (string emailId, EmailMessage body)
        {
             ApiResponse<EmailMessage> localVarResponse = await PutEmailMessagesDraftAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId">emailId</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutEmailMessagesDraftAsyncWithHttpInfo (string emailId, EmailMessage body)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PutEmailMessagesDraft");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PutEmailMessagesDraft");

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

    }
}
