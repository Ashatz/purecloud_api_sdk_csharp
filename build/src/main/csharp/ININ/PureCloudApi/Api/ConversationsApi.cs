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
    public interface IConversationsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>string</returns>
        string DeleteCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId);
  
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId);
        
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
        /// <returns>string</returns>
        string DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId (string emailId, string attachmentId);
  
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
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
        /// <param name="callbackId"></param>
        /// <returns>CallbackConversation</returns>
        CallbackConversation GetCallbacksCallbackId (string callbackId);
  
        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <returns>ApiResponse of CallbackConversation</returns>
        ApiResponse<CallbackConversation> GetCallbacksCallbackIdWithHttpInfo (string callbackId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetCallbacksCallbackIdParticipantsParticipantIdWrapup (string callbackId, string participantId, bool? provisional = null);
  
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupWithHttpInfo (string callbackId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes (string callbackId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callbackId, string participantId);
        
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
        /// <param name="callId"></param>
        /// <returns>CallConversation</returns>
        CallConversation GetCallsCallId (string callId);
  
        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <returns>ApiResponse of CallConversation</returns>
        ApiResponse<CallConversation> GetCallsCallIdWithHttpInfo (string callId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetCallsCallIdParticipantsParticipantIdWrapup (string callId, string participantId, bool? provisional = null);
  
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupWithHttpInfo (string callId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetCallsCallIdParticipantsParticipantIdWrapupcodes (string callId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callId, string participantId);
        
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
        /// <param name="chatId"></param>
        /// <returns>ChatConversation</returns>
        ChatConversation GetChatsChatId (string chatId);
  
        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <returns>ApiResponse of ChatConversation</returns>
        ApiResponse<ChatConversation> GetChatsChatIdWithHttpInfo (string chatId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetChatsChatIdParticipantsParticipantIdWrapup (string chatId, string participantId, bool? provisional = null);
  
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupWithHttpInfo (string chatId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetChatsChatIdParticipantsParticipantIdWrapupcodes (string chatId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string chatId, string participantId);
        
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
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
        /// <returns>WrapupCode</returns>
        WrapupCode GetConversationIdParticipantsParticipantIdWrapupcodes (string conversationId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>ConversationEntityListing</returns>
        ConversationEntityListing GetConversations (string communicationType = null);
  
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering</param>
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
        /// <param name="emailId"></param>
        /// <returns>EmailConversation</returns>
        EmailConversation GetEmailsEmailId (string emailId);
  
        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>ApiResponse of EmailConversation</returns>
        ApiResponse<EmailConversation> GetEmailsEmailIdWithHttpInfo (string emailId);
        
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing GetEmailsEmailIdMessages (string emailId);
  
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> GetEmailsEmailIdMessagesWithHttpInfo (string emailId);
        
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetEmailsEmailIdMessagesDraft (string emailId);
  
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetEmailsEmailIdMessagesDraftWithHttpInfo (string emailId);
        
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="messageId"></param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetEmailsEmailIdMessagesMessageId (string emailId, string messageId);
  
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="messageId"></param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetEmailsEmailIdMessagesMessageIdWithHttpInfo (string emailId, string messageId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetEmailsEmailIdParticipantsParticipantIdWrapup (string emailId, string participantId, bool? provisional = null);
  
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupWithHttpInfo (string emailId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetEmailsEmailIdParticipantsParticipantIdWrapupcodes (string emailId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string emailId, string participantId);
        
        /// <summary>
        /// Get recent video conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VideoConversationEntityListing</returns>
        VideoConversationEntityListing GetVideos ();
  
        /// <summary>
        /// Get recent video conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VideoConversationEntityListing</returns>
        ApiResponse<VideoConversationEntityListing> GetVideosWithHttpInfo ();
        
        /// <summary>
        /// Get video conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <returns>VideoConversation</returns>
        VideoConversation GetVideosVideoId (string videoId);
  
        /// <summary>
        /// Get video conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <returns>ApiResponse of VideoConversation</returns>
        ApiResponse<VideoConversation> GetVideosVideoIdWithHttpInfo (string videoId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetVideosVideoIdParticipantsParticipantIdWrapup (string videoId, string participantId, bool? provisional = null);
  
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetVideosVideoIdParticipantsParticipantIdWrapupWithHttpInfo (string videoId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetVideosVideoIdParticipantsParticipantIdWrapupcodes (string videoId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetVideosVideoIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string videoId, string participantId);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchCallbacksCallbackIdParticipantsParticipantId (string callbackId, string participantId, MediaParticipantRequest body = null);
  
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchCallbacksCallbackIdParticipantsParticipantIdAttributes (string callbackId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PatchCallsCallId (string callId, Conversation body = null);
  
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PatchCallsCallIdWithHttpInfo (string callId, Conversation body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchCallsCallIdParticipantsParticipantId (string callId, string participantId, MediaParticipantRequest body = null);
  
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdWithHttpInfo (string callId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchCallsCallIdParticipantsParticipantIdAttributes (string callId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdAttributesWithHttpInfo (string callId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse PatchCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransferUpdate body = null);
  
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">new speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> PatchCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchChatsChatIdParticipantsParticipantId (string chatId, string participantId, MediaParticipantRequest body = null);
  
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchChatsChatIdParticipantsParticipantIdAttributes (string chatId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdAttributesWithHttpInfo (string chatId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchConversationIdParticipantsParticipantId (string conversationId, string participantId, MediaParticipantRequest body = null);
  
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationIdParticipantsParticipantIdWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchConversationIdParticipantsParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchEmailsEmailIdParticipantsParticipantId (string emailId, string participantId, MediaParticipantRequest body = null);
  
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchEmailsEmailIdParticipantsParticipantIdAttributes (string emailId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdAttributesWithHttpInfo (string emailId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchVideosVideoIdParticipantsParticipantId (string videoId, string participantId, MediaParticipantRequest body = null);
  
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchVideosVideoIdParticipantsParticipantIdWithHttpInfo (string videoId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PatchVideosVideoIdParticipantsParticipantIdAttributes (string videoId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchVideosVideoIdParticipantsParticipantIdAttributesWithHttpInfo (string videoId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostCallbacksCallbackIdParticipantsParticipantIdReplace (string callbackId, string participantId, TransferRequest body = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCallbacksCallbackIdParticipantsParticipantIdReplaceWithHttpInfo (string callbackId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>CreateCallResponse</returns>
        CreateCallResponse PostCalls (CreateCallRequest body = null);
  
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of CreateCallResponse</returns>
        ApiResponse<CreateCallResponse> PostCallsWithHttpInfo (CreateCallRequest body = null);
        
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostCallsCallId (string callId, CallCommand body = null);
  
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostCallsCallIdWithHttpInfo (string callId, CallCommand body = null);
        
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostCallsCallIdParticipants (string callId, Conversation body = null);
  
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostCallsCallIdParticipantsWithHttpInfo (string callId, Conversation body = null);
        
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse PostCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransfer body = null);
  
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> PostCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransfer body = null);
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns></returns>
        void PostCallsCallIdParticipantsParticipantIdMonitor (string callId, string participantId);
  
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdMonitorWithHttpInfo (string callId, string participantId);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostCallsCallIdParticipantsParticipantIdReplace (string callId, string participantId, TransferRequest body = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdReplaceWithHttpInfo (string callId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostChatsChatIdParticipantsParticipantIdReplace (string chatId, string participantId, TransferRequest body = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostChatsChatIdParticipantsParticipantIdReplaceWithHttpInfo (string chatId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
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
        /// <param name="body"></param>
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
        /// <param name="body"></param>
        /// <returns></returns>
        void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, TransferRequest body = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostConversationsAggregatesQuery (AggregationQuery body = null);
  
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostConversationsAggregatesQueryWithHttpInfo (AggregationQuery body = null);
        
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
        PropertyIndexRequest PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body = null);
  
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
        ApiResponse<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body = null);
        
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>AnalyticsConversationQueryResponse</returns>
        AnalyticsConversationQueryResponse PostConversationsDetailsQuery (ConversationQuery body = null);
  
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>ApiResponse of AnalyticsConversationQueryResponse</returns>
        ApiResponse<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryWithHttpInfo (ConversationQuery body = null);
        
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PostEmailsEmailIdMessages (string emailId, EmailMessage body = null);
  
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PostEmailsEmailIdMessagesWithHttpInfo (string emailId, EmailMessage body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostEmailsEmailIdParticipantsParticipantIdReplace (string emailId, string participantId, TransferRequest body = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostEmailsEmailIdParticipantsParticipantIdReplaceWithHttpInfo (string emailId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse PostFaxes (FaxSendRequest body = null);
  
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> PostFaxesWithHttpInfo (FaxSendRequest body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostVideosVideoIdParticipantsParticipantIdReplace (string videoId, string participantId, TransferRequest body = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostVideosVideoIdParticipantsParticipantIdReplaceWithHttpInfo (string videoId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PutEmailsEmailIdMessagesDraft (string emailId, EmailMessage body = null);
  
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PutEmailsEmailIdMessagesDraftWithHttpInfo (string emailId, EmailMessage body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId);
        
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsync (string emailId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
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
        /// <param name="callbackId"></param>
        /// <returns>Task of CallbackConversation</returns>
        System.Threading.Tasks.Task<CallbackConversation> GetCallbacksCallbackIdAsync (string callbackId);

        /// <summary>
        /// Get callback conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetCallbacksCallbackIdAsyncWithHttpInfo (string callbackId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsync (string callbackId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callbackId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsync (string callbackId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callbackId, string participantId);
        
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
        /// <param name="callId"></param>
        /// <returns>Task of CallConversation</returns>
        System.Threading.Tasks.Task<CallConversation> GetCallsCallIdAsync (string callId);

        /// <summary>
        /// Get call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetCallsCallIdAsyncWithHttpInfo (string callId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupAsync (string callId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsync (string callId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callId, string participantId);
        
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
        /// <param name="chatId"></param>
        /// <returns>Task of ChatConversation</returns>
        System.Threading.Tasks.Task<ChatConversation> GetChatsChatIdAsync (string chatId);

        /// <summary>
        /// Get chat conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetChatsChatIdAsyncWithHttpInfo (string chatId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupAsync (string chatId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string chatId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsync (string chatId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string chatId, string participantId);
        
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
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
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ConversationEntityListing</returns>
        System.Threading.Tasks.Task<ConversationEntityListing> GetConversationsAsync (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering</param>
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
        /// <param name="emailId"></param>
        /// <returns>Task of EmailConversation</returns>
        System.Threading.Tasks.Task<EmailConversation> GetEmailsEmailIdAsync (string emailId);

        /// <summary>
        /// Get email conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetEmailsEmailIdAsyncWithHttpInfo (string emailId);
        
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> GetEmailsEmailIdMessagesAsync (string emailId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId);
        
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetEmailsEmailIdMessagesDraftAsync (string emailId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId);
        
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="messageId"></param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetEmailsEmailIdMessagesMessageIdAsync (string emailId, string messageId);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="messageId"></param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesMessageIdAsyncWithHttpInfo (string emailId, string messageId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupAsync (string emailId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string emailId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsync (string emailId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string emailId, string participantId);
        
        /// <summary>
        /// Get recent video conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VideoConversationEntityListing</returns>
        System.Threading.Tasks.Task<VideoConversationEntityListing> GetVideosAsync ();

        /// <summary>
        /// Get recent video conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VideoConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VideoConversationEntityListing>> GetVideosAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get video conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <returns>Task of VideoConversation</returns>
        System.Threading.Tasks.Task<VideoConversation> GetVideosVideoIdAsync (string videoId);

        /// <summary>
        /// Get video conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <returns>Task of ApiResponse (VideoConversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<VideoConversation>> GetVideosVideoIdAsyncWithHttpInfo (string videoId);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetVideosVideoIdParticipantsParticipantIdWrapupAsync (string videoId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetVideosVideoIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string videoId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetVideosVideoIdParticipantsParticipantIdWrapupcodesAsync (string videoId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetVideosVideoIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string videoId, string participantId);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAsync (string callbackId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAsyncWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsync (string callbackId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PatchCallsCallIdAsync (string callId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallsCallIdAsyncWithHttpInfo (string callId, Conversation body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAsync (string callId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAsyncWithHttpInfo (string callId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAttributesAsync (string callId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> PatchCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransferUpdate body = null);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAsync (string chatId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAsyncWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAttributesAsync (string chatId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string chatId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAsync (string conversationId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Update conversation participant.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAsync (string emailId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAsyncWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAttributesAsync (string emailId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string emailId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchVideosVideoIdParticipantsParticipantIdAsync (string videoId, string participantId, MediaParticipantRequest body = null);

        /// <summary>
        /// Update conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchVideosVideoIdParticipantsParticipantIdAsyncWithHttpInfo (string videoId, string participantId, MediaParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchVideosVideoIdParticipantsParticipantIdAttributesAsync (string videoId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchVideosVideoIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string videoId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsync (string callbackId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callbackId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of CreateCallResponse</returns>
        System.Threading.Tasks.Task<CreateCallResponse> PostCallsAsync (CreateCallRequest body = null);

        /// <summary>
        /// Create a call conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (CreateCallResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateCallResponse>> PostCallsAsyncWithHttpInfo (CreateCallRequest body = null);
        
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostCallsCallIdAsync (string callId, CallCommand body = null);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdAsyncWithHttpInfo (string callId, CallCommand body = null);
        
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostCallsCallIdParticipantsAsync (string callId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdParticipantsAsyncWithHttpInfo (string callId, Conversation body = null);
        
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> PostCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransfer body = null);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransfer body = null);
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdMonitorAsync (string callId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdMonitorAsyncWithHttpInfo (string callId, string participantId);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdReplaceAsync (string callId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostChatsChatIdParticipantsParticipantIdReplaceAsync (string chatId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsChatIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string chatId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Create a new callback for the specified participant on the conversation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
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
        /// <param name="body"></param>
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
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdReplaceAsync (string conversationId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostConversationsAggregatesQueryAsync (AggregationQuery body = null);

        /// <summary>
        /// Query for conversation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null);
        
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
        System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body = null);

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
        System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body = null);
        
        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of AnalyticsConversationQueryResponse</returns>
        System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryAsync (ConversationQuery body = null);

        /// <summary>
        /// Query for conversation details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param>
        /// <returns>Task of ApiResponse (AnalyticsConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body = null);
        
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PostEmailsEmailIdMessagesAsync (string emailId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId, EmailMessage body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostEmailsEmailIdParticipantsParticipantIdReplaceAsync (string emailId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEmailsEmailIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string emailId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> PostFaxesAsync (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostFaxesAsyncWithHttpInfo (FaxSendRequest body = null);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostVideosVideoIdParticipantsParticipantIdReplaceAsync (string videoId, string participantId, TransferRequest body = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostVideosVideoIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string videoId, string participantId, TransferRequest body = null);
        
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PutEmailsEmailIdMessagesDraftAsync (string emailId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId, EmailMessage body = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConversationsApi : IConversationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConversationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
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
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
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
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
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
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling DeleteCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling DeleteCallsCallIdParticipantsParticipantIdConsult");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="attachmentId"></param> 
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
        /// <param name="emailId"></param> 
        /// <param name="attachmentId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
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
        /// <param name="emailId"></param>
        /// <param name="attachmentId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo (string emailId, string attachmentId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
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
        /// <param name="callbackId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }

        
        /// <summary>
        /// Get callback conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
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
        /// <param name="callbackId"></param>
        /// <returns>Task of ApiResponse (CallbackConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallbackConversation>> GetCallbacksCallbackIdAsyncWithHttpInfo (string callbackId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null) throw new ApiException(400, "Missing required parameter 'callbackId' when calling GetCallbacksCallbackId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallbackConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallbackConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallbackConversation)));
            
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetCallbacksCallbackIdParticipantsParticipantIdWrapup (string callbackId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetCallbacksCallbackIdParticipantsParticipantIdWrapupWithHttpInfo(callbackId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetCallbacksCallbackIdParticipantsParticipantIdWrapupWithHttpInfo (string callbackId, string participantId, bool? provisional = null)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsync (string callbackId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(callbackId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callbackId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null) throw new ApiException(400, "Missing required parameter 'callbackId' when calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes (string callbackId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesWithHttpInfo(callbackId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callbackId, string participantId)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsync (string callbackId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(callbackId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callbackId, string participantId)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null) throw new ApiException(400, "Missing required parameter 'callbackId' when calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
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
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
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
        /// <param name="callId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }

        
        /// <summary>
        /// Get call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
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
        /// <param name="callId"></param>
        /// <returns>Task of ApiResponse (CallConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallConversation>> GetCallsCallIdAsyncWithHttpInfo (string callId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling GetCallsCallId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallConversation)));
            
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetCallsCallIdParticipantsParticipantIdWrapup (string callId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetCallsCallIdParticipantsParticipantIdWrapupWithHttpInfo(callId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetCallsCallIdParticipantsParticipantIdWrapupWithHttpInfo (string callId, string participantId, bool? provisional = null)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupAsync (string callId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetCallsCallIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(callId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string callId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling GetCallsCallIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetCallsCallIdParticipantsParticipantIdWrapup");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetCallsCallIdParticipantsParticipantIdWrapupcodes (string callId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetCallsCallIdParticipantsParticipantIdWrapupcodesWithHttpInfo(callId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetCallsCallIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string callId, string participantId)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsync (string callId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetCallsCallIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(callId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetCallsCallIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling GetCallsCallIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetCallsCallIdParticipantsParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
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
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
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
        /// <param name="chatId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }

        
        /// <summary>
        /// Get chat conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
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
        /// <param name="chatId"></param>
        /// <returns>Task of ApiResponse (ChatConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatConversation>> GetChatsChatIdAsyncWithHttpInfo (string chatId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null) throw new ApiException(400, "Missing required parameter 'chatId' when calling GetChatsChatId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChatConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChatConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChatConversation)));
            
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetChatsChatIdParticipantsParticipantIdWrapup (string chatId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetChatsChatIdParticipantsParticipantIdWrapupWithHttpInfo(chatId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetChatsChatIdParticipantsParticipantIdWrapupWithHttpInfo (string chatId, string participantId, bool? provisional = null)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupAsync (string chatId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetChatsChatIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(chatId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string chatId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null) throw new ApiException(400, "Missing required parameter 'chatId' when calling GetChatsChatIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetChatsChatIdParticipantsParticipantIdWrapup");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetChatsChatIdParticipantsParticipantIdWrapupcodes (string chatId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetChatsChatIdParticipantsParticipantIdWrapupcodesWithHttpInfo(chatId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetChatsChatIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string chatId, string participantId)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsync (string chatId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetChatsChatIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(chatId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetChatsChatIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string chatId, string participantId)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null) throw new ApiException(400, "Missing required parameter 'chatId' when calling GetChatsChatIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetChatsChatIdParticipantsParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
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
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationIdParticipantsParticipantIdWrapup");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>WrapupCode</returns>
        public WrapupCode GetConversationIdParticipantsParticipantIdWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationIdParticipantsParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering</param> 
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
        /// <param name="communicationType">Call or Chat communication filtering</param> 
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
        /// <param name="communicationType">Call or Chat communication filtering</param>
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
        /// <param name="communicationType">Call or Chat communication filtering</param>
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationsConversationIdDetails");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdDetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AnalyticsConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
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
        /// <param name="emailId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }

        
        /// <summary>
        /// Get email conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
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
        /// <param name="emailId"></param>
        /// <returns>Task of ApiResponse (EmailConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailConversation>> GetEmailsEmailIdAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling GetEmailsEmailId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailConversation)));
            
        }
        
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
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
        /// <param name="emailId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
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
        /// <param name="emailId"></param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling GetEmailsEmailIdMessages");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }
        
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
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
        /// <param name="emailId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
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
        /// <param name="emailId"></param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling GetEmailsEmailIdMessagesDraft");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="messageId"></param> 
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
        /// <param name="emailId"></param> 
        /// <param name="messageId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        
        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="messageId"></param>
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
        /// <param name="emailId"></param>
        /// <param name="messageId"></param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetEmailsEmailIdMessagesMessageIdAsyncWithHttpInfo (string emailId, string messageId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling GetEmailsEmailIdMessagesMessageId");
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling GetEmailsEmailIdMessagesMessageId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdMessagesMessageId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetEmailsEmailIdParticipantsParticipantIdWrapup (string emailId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetEmailsEmailIdParticipantsParticipantIdWrapupWithHttpInfo(emailId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetEmailsEmailIdParticipantsParticipantIdWrapupWithHttpInfo (string emailId, string participantId, bool? provisional = null)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupAsync (string emailId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetEmailsEmailIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(emailId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string emailId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling GetEmailsEmailIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetEmailsEmailIdParticipantsParticipantIdWrapup");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetEmailsEmailIdParticipantsParticipantIdWrapupcodes (string emailId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetEmailsEmailIdParticipantsParticipantIdWrapupcodesWithHttpInfo(emailId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetEmailsEmailIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string emailId, string participantId)
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsync (string emailId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(emailId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetEmailsEmailIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string emailId, string participantId)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get recent video conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VideoConversationEntityListing</returns>
        public VideoConversationEntityListing GetVideos ()
        {
             ApiResponse<VideoConversationEntityListing> localVarResponse = GetVideosWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent video conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VideoConversationEntityListing</returns>
        public ApiResponse< VideoConversationEntityListing > GetVideosWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v2/conversations/videos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VideoConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoConversationEntityListing)));
            
        }

        
        /// <summary>
        /// Get recent video conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VideoConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<VideoConversationEntityListing> GetVideosAsync ()
        {
             ApiResponse<VideoConversationEntityListing> localVarResponse = await GetVideosAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get recent video conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VideoConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VideoConversationEntityListing>> GetVideosAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v2/conversations/videos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideos: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideos: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VideoConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoConversationEntityListing)));
            
        }
        
        /// <summary>
        /// Get video conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <returns>VideoConversation</returns>
        public VideoConversation GetVideosVideoId (string videoId)
        {
             ApiResponse<VideoConversation> localVarResponse = GetVideosVideoIdWithHttpInfo(videoId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get video conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <returns>ApiResponse of VideoConversation</returns>
        public ApiResponse< VideoConversation > GetVideosVideoIdWithHttpInfo (string videoId)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling ConversationsApi->GetVideosVideoId");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VideoConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoConversation)));
            
        }

        
        /// <summary>
        /// Get video conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <returns>Task of VideoConversation</returns>
        public async System.Threading.Tasks.Task<VideoConversation> GetVideosVideoIdAsync (string videoId)
        {
             ApiResponse<VideoConversation> localVarResponse = await GetVideosVideoIdAsyncWithHttpInfo(videoId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get video conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <returns>Task of ApiResponse (VideoConversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VideoConversation>> GetVideosVideoIdAsyncWithHttpInfo (string videoId)
        {
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling GetVideosVideoId");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VideoConversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VideoConversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VideoConversation)));
            
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetVideosVideoIdParticipantsParticipantIdWrapup (string videoId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = GetVideosVideoIdParticipantsParticipantIdWrapupWithHttpInfo(videoId, participantId, provisional);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetVideosVideoIdParticipantsParticipantIdWrapupWithHttpInfo (string videoId, string participantId, bool? provisional = null)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling ConversationsApi->GetVideosVideoIdParticipantsParticipantIdWrapup");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetVideosVideoIdParticipantsParticipantIdWrapup");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/wrapup";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetVideosVideoIdParticipantsParticipantIdWrapupAsync (string videoId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetVideosVideoIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(videoId, participantId, provisional);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetVideosVideoIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string videoId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling GetVideosVideoIdParticipantsParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetVideosVideoIdParticipantsParticipantIdWrapup");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/wrapup";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapup: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapup: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetVideosVideoIdParticipantsParticipantIdWrapupcodes (string videoId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = GetVideosVideoIdParticipantsParticipantIdWrapupcodesWithHttpInfo(videoId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetVideosVideoIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string videoId, string participantId)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling ConversationsApi->GetVideosVideoIdParticipantsParticipantIdWrapupcodes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->GetVideosVideoIdParticipantsParticipantIdWrapupcodes");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/wrapupcodes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetVideosVideoIdParticipantsParticipantIdWrapupcodesAsync (string videoId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await GetVideosVideoIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(videoId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetVideosVideoIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string videoId, string participantId)
        {
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling GetVideosVideoIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetVideosVideoIdParticipantsParticipantIdWrapupcodes");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/wrapupcodes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVideosVideoIdParticipantsParticipantIdWrapupcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchCallbacksCallbackIdParticipantsParticipantId (string callbackId, string participantId, MediaParticipantRequest body = null)
        {
             PatchCallbacksCallbackIdParticipantsParticipantIdWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body = null)
        {
            
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAsync (string callbackId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchCallbacksCallbackIdParticipantsParticipantIdAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAsyncWithHttpInfo (string callbackId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null) throw new ApiException(400, "Missing required parameter 'callbackId' when calling PatchCallbacksCallbackIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchCallbacksCallbackIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchCallbacksCallbackIdParticipantsParticipantIdAttributes (string callbackId, string participantId, ParticipantAttributes body = null)
        {
             PatchCallbacksCallbackIdParticipantsParticipantIdAttributesWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsync (string callbackId, string participantId, ParticipantAttributes body = null)
        {
             await PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallbacksCallbackIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callbackId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null) throw new ApiException(400, "Missing required parameter 'callbackId' when calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="body">Conversation</param> 
        /// <returns>Conversation</returns>
        public Conversation PatchCallsCallId (string callId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = PatchCallsCallIdWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PatchCallsCallIdWithHttpInfo (string callId, Conversation body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        
        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PatchCallsCallIdAsync (string callId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = await PatchCallsCallIdAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PatchCallsCallIdAsyncWithHttpInfo (string callId, Conversation body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PatchCallsCallId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchCallsCallIdParticipantsParticipantId (string callId, string participantId, MediaParticipantRequest body = null)
        {
             PatchCallsCallIdParticipantsParticipantIdWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdWithHttpInfo (string callId, string participantId, MediaParticipantRequest body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAsync (string callId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchCallsCallIdParticipantsParticipantIdAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAsyncWithHttpInfo (string callId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PatchCallsCallIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchCallsCallIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchCallsCallIdParticipantsParticipantIdAttributes (string callId, string participantId, ParticipantAttributes body = null)
        {
             PatchCallsCallIdParticipantsParticipantIdAttributesWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchCallsCallIdParticipantsParticipantIdAttributesWithHttpInfo (string callId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchCallsCallIdParticipantsParticipantIdAttributesAsync (string callId, string participantId, ParticipantAttributes body = null)
        {
             await PatchCallsCallIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchCallsCallIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string callId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PatchCallsCallIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchCallsCallIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body">new speak to</param> 
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PatchCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PatchCallsCallIdParticipantsParticipantIdConsultWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body">new speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PatchCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchCallsCallIdParticipantsParticipantIdConsult");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        
        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PatchCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PatchCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PatchCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransferUpdate body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PatchCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchCallsCallIdParticipantsParticipantIdConsult");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }
        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchChatsChatIdParticipantsParticipantId (string chatId, string participantId, MediaParticipantRequest body = null)
        {
             PatchChatsChatIdParticipantsParticipantIdWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body = null)
        {
            
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAsync (string chatId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchChatsChatIdParticipantsParticipantIdAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAsyncWithHttpInfo (string chatId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null) throw new ApiException(400, "Missing required parameter 'chatId' when calling PatchChatsChatIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchChatsChatIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchChatsChatIdParticipantsParticipantIdAttributes (string chatId, string participantId, ParticipantAttributes body = null)
        {
             PatchChatsChatIdParticipantsParticipantIdAttributesWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchChatsChatIdParticipantsParticipantIdAttributesWithHttpInfo (string chatId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchChatsChatIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchChatsChatIdParticipantsParticipantIdAttributesAsync (string chatId, string participantId, ParticipantAttributes body = null)
        {
             await PatchChatsChatIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchChatsChatIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string chatId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null) throw new ApiException(400, "Missing required parameter 'chatId' when calling PatchChatsChatIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchChatsChatIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchChatsChatIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchConversationIdParticipantsParticipantId (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
             PatchConversationIdParticipantsParticipantIdWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationIdParticipantsParticipantIdWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAsync (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchConversationIdParticipantsParticipantIdAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Update conversation participant.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PatchConversationIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchConversationIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             PatchConversationIdParticipantsParticipantIdAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchConversationIdParticipantsParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchConversationIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchConversationIdParticipantsParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             await PatchConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PatchConversationIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchConversationIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchConversationIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchEmailsEmailIdParticipantsParticipantId (string emailId, string participantId, MediaParticipantRequest body = null)
        {
             PatchEmailsEmailIdParticipantsParticipantIdWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body = null)
        {
            
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAsync (string emailId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchEmailsEmailIdParticipantsParticipantIdAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAsyncWithHttpInfo (string emailId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling PatchEmailsEmailIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchEmailsEmailIdParticipantsParticipantId");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchEmailsEmailIdParticipantsParticipantIdAttributes (string emailId, string participantId, ParticipantAttributes body = null)
        {
             PatchEmailsEmailIdParticipantsParticipantIdAttributesWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchEmailsEmailIdParticipantsParticipantIdAttributesWithHttpInfo (string emailId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchEmailsEmailIdParticipantsParticipantIdAttributesAsync (string emailId, string participantId, ParticipantAttributes body = null)
        {
             await PatchEmailsEmailIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchEmailsEmailIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string emailId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchEmailsEmailIdParticipantsParticipantIdAttributes");
            
    
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchVideosVideoIdParticipantsParticipantId (string videoId, string participantId, MediaParticipantRequest body = null)
        {
             PatchVideosVideoIdParticipantsParticipantIdWithHttpInfo(videoId, participantId, body);
        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchVideosVideoIdParticipantsParticipantIdWithHttpInfo (string videoId, string participantId, MediaParticipantRequest body = null)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling ConversationsApi->PatchVideosVideoIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchVideosVideoIdParticipantsParticipantId");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchVideosVideoIdParticipantsParticipantIdAsync (string videoId, string participantId, MediaParticipantRequest body = null)
        {
             await PatchVideosVideoIdParticipantsParticipantIdAsyncWithHttpInfo(videoId, participantId, body);

        }

        /// <summary>
        /// Update conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchVideosVideoIdParticipantsParticipantIdAsyncWithHttpInfo (string videoId, string participantId, MediaParticipantRequest body = null)
        {
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling PatchVideosVideoIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchVideosVideoIdParticipantsParticipantId");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PatchVideosVideoIdParticipantsParticipantIdAttributes (string videoId, string participantId, ParticipantAttributes body = null)
        {
             PatchVideosVideoIdParticipantsParticipantIdAttributesWithHttpInfo(videoId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchVideosVideoIdParticipantsParticipantIdAttributesWithHttpInfo (string videoId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling ConversationsApi->PatchVideosVideoIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PatchVideosVideoIdParticipantsParticipantIdAttributes");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/attributes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchVideosVideoIdParticipantsParticipantIdAttributesAsync (string videoId, string participantId, ParticipantAttributes body = null)
        {
             await PatchVideosVideoIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(videoId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchVideosVideoIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string videoId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling PatchVideosVideoIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PatchVideosVideoIdParticipantsParticipantIdAttributes");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/attributes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantIdAttributes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchVideosVideoIdParticipantsParticipantIdAttributes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostCallbacksCallbackIdParticipantsParticipantIdReplace (string callbackId, string participantId, TransferRequest body = null)
        {
             PostCallbacksCallbackIdParticipantsParticipantIdReplaceWithHttpInfo(callbackId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallbacksCallbackIdParticipantsParticipantIdReplaceWithHttpInfo (string callbackId, string participantId, TransferRequest body = null)
        {
            
            // verify the required parameter 'callbackId' is set
            if (callbackId == null)
                throw new ApiException(400, "Missing required parameter 'callbackId' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsync (string callbackId, string participantId, TransferRequest body = null)
        {
             await PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(callbackId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callbackId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallbacksCallbackIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callbackId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'callbackId' is set
            if (callbackId == null) throw new ApiException(400, "Missing required parameter 'callbackId' when calling PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostCallbacksCallbackIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>CreateCallResponse</returns>
        public CreateCallResponse PostCalls (CreateCallRequest body = null)
        {
             ApiResponse<CreateCallResponse> localVarResponse = PostCallsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of CreateCallResponse</returns>
        public ApiResponse< CreateCallResponse > PostCallsWithHttpInfo (CreateCallRequest body = null)
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
        /// <param name="body"></param>
        /// <returns>Task of CreateCallResponse</returns>
        public async System.Threading.Tasks.Task<CreateCallResponse> PostCallsAsync (CreateCallRequest body = null)
        {
             ApiResponse<CreateCallResponse> localVarResponse = await PostCallsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a call conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (CreateCallResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateCallResponse>> PostCallsAsyncWithHttpInfo (CreateCallRequest body = null)
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
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalls: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreateCallResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateCallResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateCallResponse)));
            
        }
        
        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="body">Conversation</param> 
        /// <returns>Conversation</returns>
        public Conversation PostCallsCallId (string callId, CallCommand body = null)
        {
             ApiResponse<Conversation> localVarResponse = PostCallsCallIdWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostCallsCallIdWithHttpInfo (string callId, CallCommand body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        
        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostCallsCallIdAsync (string callId, CallCommand body = null)
        {
             ApiResponse<Conversation> localVarResponse = await PostCallsCallIdAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdAsyncWithHttpInfo (string callId, CallCommand body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PostCallsCallId");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="body">Conversation</param> 
        /// <returns>Conversation</returns>
        public Conversation PostCallsCallIdParticipants (string callId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = PostCallsCallIdParticipantsWithHttpInfo(callId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostCallsCallIdParticipantsWithHttpInfo (string callId, Conversation body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipants");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        
        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostCallsCallIdParticipantsAsync (string callId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = await PostCallsCallIdParticipantsAsyncWithHttpInfo(callId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostCallsCallIdParticipantsAsyncWithHttpInfo (string callId, Conversation body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PostCallsCallIdParticipants");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipants: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body">Destination address &amp; initial speak to</param> 
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse PostCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = PostCallsCallIdParticipantsParticipantIdConsultWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body">Destination address &amp; initial speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PostCallsCallIdParticipantsParticipantIdConsultWithHttpInfo (string callId, string participantId, ConsultTransfer body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdConsult");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        
        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PostCallsCallIdParticipantsParticipantIdConsultAsync (string callId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await PostCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo(callId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostCallsCallIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string callId, string participantId, ConsultTransfer body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PostCallsCallIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostCallsCallIdParticipantsParticipantIdConsult");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdConsult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <returns></returns>
        public void PostCallsCallIdParticipantsParticipantIdMonitor (string callId, string participantId)
        {
             PostCallsCallIdParticipantsParticipantIdMonitorWithHttpInfo(callId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
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
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdMonitorAsync (string callId, string participantId)
        {
             await PostCallsCallIdParticipantsParticipantIdMonitorAsyncWithHttpInfo(callId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdMonitorAsyncWithHttpInfo (string callId, string participantId)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PostCallsCallIdParticipantsParticipantIdMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostCallsCallIdParticipantsParticipantIdMonitor");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdMonitor: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostCallsCallIdParticipantsParticipantIdReplace (string callId, string participantId, TransferRequest body = null)
        {
             PostCallsCallIdParticipantsParticipantIdReplaceWithHttpInfo(callId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostCallsCallIdParticipantsParticipantIdReplaceWithHttpInfo (string callId, string participantId, TransferRequest body = null)
        {
            
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostCallsCallIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostCallsCallIdParticipantsParticipantIdReplaceAsync (string callId, string participantId, TransferRequest body = null)
        {
             await PostCallsCallIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(callId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostCallsCallIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string callId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'callId' is set
            if (callId == null) throw new ApiException(400, "Missing required parameter 'callId' when calling PostCallsCallIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostCallsCallIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCallsCallIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostChatsChatIdParticipantsParticipantIdReplace (string chatId, string participantId, TransferRequest body = null)
        {
             PostChatsChatIdParticipantsParticipantIdReplaceWithHttpInfo(chatId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostChatsChatIdParticipantsParticipantIdReplaceWithHttpInfo (string chatId, string participantId, TransferRequest body = null)
        {
            
            // verify the required parameter 'chatId' is set
            if (chatId == null)
                throw new ApiException(400, "Missing required parameter 'chatId' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostChatsChatIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostChatsChatIdParticipantsParticipantIdReplaceAsync (string chatId, string participantId, TransferRequest body = null)
        {
             await PostChatsChatIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(chatId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostChatsChatIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string chatId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'chatId' is set
            if (chatId == null) throw new ApiException(400, "Missing required parameter 'chatId' when calling PostChatsChatIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostChatsChatIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChatsChatIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="body"></param> 
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
        /// <param name="body"></param> 
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        /// <param name="body"></param>
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
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdCallbacksAsyncWithHttpInfo (string conversationId, string participantId, CreateCallbackCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdParticipantsParticipantIdCallbacks");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostConversationIdParticipantsParticipantIdCallbacks");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdCallbacks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, TransferRequest body = null)
        {
             PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, TransferRequest body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
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
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdReplaceAsync (string conversationId, string participantId, TransferRequest body = null)
        {
             await PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostConversationIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public AggregateQueryResponse PostConversationsAggregatesQuery (AggregationQuery body = null)
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
        public ApiResponse< AggregateQueryResponse > PostConversationsAggregatesQueryWithHttpInfo (AggregationQuery body = null)
        {
            
    
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
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostConversationsAggregatesQueryAsync (AggregationQuery body = null)
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
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostConversationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null)
        {
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
            
        }
        
        /// <summary>
        /// Index conversation properties 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversationId</param> 
        /// <param name="body">request</param> 
        /// <returns>PropertyIndexRequest</returns>
        public PropertyIndexRequest PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body = null)
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
        public ApiResponse< PropertyIndexRequest > PostConversationsConversationIdDetailsPropertiesWithHttpInfo (string conversationId, PropertyIndexRequest body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationsConversationIdDetailsProperties");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PropertyIndexRequest> PostConversationsConversationIdDetailsPropertiesAsync (string conversationId, PropertyIndexRequest body = null)
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
        public async System.Threading.Tasks.Task<ApiResponse<PropertyIndexRequest>> PostConversationsConversationIdDetailsPropertiesAsyncWithHttpInfo (string conversationId, PropertyIndexRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationsConversationIdDetailsProperties");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdDetailsProperties: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PropertyIndexRequest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PropertyIndexRequest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyIndexRequest)));
            
        }
        
        /// <summary>
        /// Query for conversation details 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query</param> 
        /// <returns>AnalyticsConversationQueryResponse</returns>
        public AnalyticsConversationQueryResponse PostConversationsDetailsQuery (ConversationQuery body = null)
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
        public ApiResponse< AnalyticsConversationQueryResponse > PostConversationsDetailsQueryWithHttpInfo (ConversationQuery body = null)
        {
            
    
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
        public async System.Threading.Tasks.Task<AnalyticsConversationQueryResponse> PostConversationsDetailsQueryAsync (ConversationQuery body = null)
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
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsConversationQueryResponse>> PostConversationsDetailsQueryAsyncWithHttpInfo (ConversationQuery body = null)
        {
            
    
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
        /// <param name="emailId"></param> 
        /// <param name="body">Reply</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage PostEmailsEmailIdMessages (string emailId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = PostEmailsEmailIdMessagesWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="body">Reply</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PostEmailsEmailIdMessagesWithHttpInfo (string emailId, EmailMessage body = null)
        {
            
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailsEmailIdMessages");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        
        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PostEmailsEmailIdMessagesAsync (string emailId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = await PostEmailsEmailIdMessagesAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostEmailsEmailIdMessagesAsyncWithHttpInfo (string emailId, EmailMessage body = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling PostEmailsEmailIdMessages");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdMessages: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostEmailsEmailIdParticipantsParticipantIdReplace (string emailId, string participantId, TransferRequest body = null)
        {
             PostEmailsEmailIdParticipantsParticipantIdReplaceWithHttpInfo(emailId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostEmailsEmailIdParticipantsParticipantIdReplaceWithHttpInfo (string emailId, string participantId, TransferRequest body = null)
        {
            
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostEmailsEmailIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostEmailsEmailIdParticipantsParticipantIdReplaceAsync (string emailId, string participantId, TransferRequest body = null)
        {
             await PostEmailsEmailIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(emailId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostEmailsEmailIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string emailId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling PostEmailsEmailIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostEmailsEmailIdParticipantsParticipantIdReplace");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEmailsEmailIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public FaxSendResponse PostFaxes (FaxSendRequest body = null)
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
        public ApiResponse< FaxSendResponse > PostFaxesWithHttpInfo (FaxSendRequest body = null)
        {
            
    
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
        public async System.Threading.Tasks.Task<FaxSendResponse> PostFaxesAsync (FaxSendRequest body = null)
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
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostFaxesAsyncWithHttpInfo (FaxSendRequest body = null)
        {
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFaxes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }
        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostVideosVideoIdParticipantsParticipantIdReplace (string videoId, string participantId, TransferRequest body = null)
        {
             PostVideosVideoIdParticipantsParticipantIdReplaceWithHttpInfo(videoId, participantId, body);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param> 
        /// <param name="participantId"></param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostVideosVideoIdParticipantsParticipantIdReplaceWithHttpInfo (string videoId, string participantId, TransferRequest body = null)
        {
            
            // verify the required parameter 'videoId' is set
            if (videoId == null)
                throw new ApiException(400, "Missing required parameter 'videoId' when calling ConversationsApi->PostVideosVideoIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostVideosVideoIdParticipantsParticipantIdReplace");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/replace";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostVideosVideoIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostVideosVideoIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostVideosVideoIdParticipantsParticipantIdReplaceAsync (string videoId, string participantId, TransferRequest body = null)
        {
             await PostVideosVideoIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(videoId, participantId, body);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId"></param>
        /// <param name="participantId"></param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostVideosVideoIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string videoId, string participantId, TransferRequest body = null)
        {
            // verify the required parameter 'videoId' is set
            if (videoId == null) throw new ApiException(400, "Missing required parameter 'videoId' when calling PostVideosVideoIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostVideosVideoIdParticipantsParticipantIdReplace");
            
    
            var localVarPath = "/api/v2/conversations/videos/{videoId}/participants/{participantId}/replace";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (videoId != null) localVarPathParams.Add("videoId", Configuration.ApiClient.ParameterToString(videoId)); // path parameter
            if (participantId != null) localVarPathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostVideosVideoIdParticipantsParticipantIdReplace: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostVideosVideoIdParticipantsParticipantIdReplace: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="body">Draft</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage PutEmailsEmailIdMessagesDraft (string emailId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = PutEmailsEmailIdMessagesDraftWithHttpInfo(emailId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param> 
        /// <param name="body">Draft</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PutEmailsEmailIdMessagesDraftWithHttpInfo (string emailId, EmailMessage body = null)
        {
            
            // verify the required parameter 'emailId' is set
            if (emailId == null)
                throw new ApiException(400, "Missing required parameter 'emailId' when calling ConversationsApi->PutEmailsEmailIdMessagesDraft");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        
        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> PutEmailsEmailIdMessagesDraftAsync (string emailId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = await PutEmailsEmailIdMessagesDraftAsyncWithHttpInfo(emailId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailId"></param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutEmailsEmailIdMessagesDraftAsyncWithHttpInfo (string emailId, EmailMessage body = null)
        {
            // verify the required parameter 'emailId' is set
            if (emailId == null) throw new ApiException(400, "Missing required parameter 'emailId' when calling PutEmailsEmailIdMessagesDraft");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEmailsEmailIdMessagesDraft: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }
        
    }
    
}
