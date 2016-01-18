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
    public interface IConversationsApi
    {
        
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>ConversationEntityListing</returns>
        ConversationEntityListing ConversationsGet (string communicationType = null);
  
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        ApiResponse<ConversationEntityListing> ConversationsGetWithHttpInfo (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ConversationEntityListing</returns>
        System.Threading.Tasks.Task<ConversationEntityListing> ConversationsGetAsync (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> ConversationsGetAsyncWithHttpInfo (string communicationType = null);
        
        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="call">Phone number to call</param>
        /// <param name="callFrom">Queue id to place the call from</param>
        /// <param name="callQueueId">Queue id to call</param>
        /// <param name="callUserId">User id to call (this will call the default number)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue</param>
        /// <param name="languageId">Language id to use for routing when calling a queue</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param>
        /// <param name="body"></param>
        /// <returns>ConversationResponse</returns>
        ConversationResponse ConversationsPost (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
  
        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="call">Phone number to call</param>
        /// <param name="callFrom">Queue id to place the call from</param>
        /// <param name="callQueueId">Queue id to call</param>
        /// <param name="callUserId">User id to call (this will call the default number)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue</param>
        /// <param name="languageId">Language id to use for routing when calling a queue</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ConversationResponse</returns>
        ApiResponse<ConversationResponse> ConversationsPostWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="call">Phone number to call</param>
        /// <param name="callFrom">Queue id to place the call from</param>
        /// <param name="callQueueId">Queue id to call</param>
        /// <param name="callUserId">User id to call (this will call the default number)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue</param>
        /// <param name="languageId">Language id to use for routing when calling a queue</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param>
        /// <param name="body"></param>
        /// <returns>Task of ConversationResponse</returns>
        System.Threading.Tasks.Task<ConversationResponse> ConversationsPostAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="call">Phone number to call</param>
        /// <param name="callFrom">Queue id to place the call from</param>
        /// <param name="callQueueId">Queue id to call</param>
        /// <param name="callUserId">User id to call (this will call the default number)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue</param>
        /// <param name="languageId">Language id to use for routing when calling a queue</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ConversationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> ConversationsPostAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
        
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse ConversationsFaxPost (FaxSendRequest body = null);
  
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> ConversationsFaxPostWithHttpInfo (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> ConversationsFaxPostAsync (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> ConversationsFaxPostAsyncWithHttpInfo (FaxSendRequest body = null);
        
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>MaxParticipants</returns>
        MaxParticipants ConversationsMaximumconferencepartiesGet ();
  
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of MaxParticipants</returns>
        ApiResponse<MaxParticipants> ConversationsMaximumconferencepartiesGetWithHttpInfo ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of MaxParticipants</returns>
        System.Threading.Tasks.Task<MaxParticipants> ConversationsMaximumconferencepartiesGetAsync ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> ConversationsMaximumconferencepartiesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse ConversationsQueryPost (ConversationHistoricalQueryRequestBody body = null);
  
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> ConversationsQueryPostWithHttpInfo (ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryPostAsync (ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryPostAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body = null);
        
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"></param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse ConversationsQueryAnchorPost (string anchor, ConversationHistoricalQueryRequestBody body = null);
  
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> ConversationsQueryAnchorPostWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"></param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryAnchorPostAsync (string anchor, ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryAnchorPostAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null);
        
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation ConversationsConversationidGet (string conversationId);
  
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> ConversationsConversationidGetWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> ConversationsConversationidGetAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidGetAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation ConversationsConversationidPut (string conversationId, Conversation body = null);
  
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> ConversationsConversationidPutWithHttpInfo (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> ConversationsConversationidPutAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidPutAsyncWithHttpInfo (string conversationId, Conversation body = null);
        
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing ConversationsConversationidMessagesGet (string conversationId);
  
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> ConversationsConversationidMessagesGetWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> ConversationsConversationidMessagesGetAsync (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> ConversationsConversationidMessagesGetAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesPost (string conversationId, EmailMessage body = null);
  
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesPostWithHttpInfo (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesPostAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesPostAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesDraftGet (string conversationId);
  
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesDraftGetWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftGetAsync (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftGetAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesDraftPut (string conversationId, EmailMessage body = null);
  
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesDraftPutWithHttpInfo (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftPutAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftPutAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>string</returns>
        string ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete (string conversationId, string attachmentId);
  
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteWithHttpInfo (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsync (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsyncWithHttpInfo (string conversationId, string attachmentId);
        
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesIdGet (string conversationId, string id);
  
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesIdGetWithHttpInfo (string conversationId, string id);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesIdGetAsync (string conversationId, string id);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesIdGetAsyncWithHttpInfo (string conversationId, string id);
        
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation ConversationsConversationidParticipantsPost (string conversationId, Conversation body = null);
  
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> ConversationsConversationidParticipantsPostWithHttpInfo (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> ConversationsConversationidParticipantsPostAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidParticipantsPostAsyncWithHttpInfo (string conversationId, Conversation body = null);
        
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidPut (string conversationId, string participantId, ParticipantRequest body = null);
  
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidPutWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidPutAsync (string conversationId, string participantId, ParticipantRequest body = null);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);
        
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidAttributesPut (string conversationId, string participantId, ParticipantAttributes body = null);
  
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidAttributesPutWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidAttributesPutAsync (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidAttributesPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPut (string conversationId, string participantId, ConsultTransferUpdate body = null);
  
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPutWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPutAsync (string conversationId, string participantId, ConsultTransferUpdate body = null);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPutAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);
        
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPost (string conversationId, string participantId, ConsultTransfer body = null);
  
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPostWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPostAsync (string conversationId, string participantId, ConsultTransfer body = null);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPostAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);
        
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>string</returns>
        string ConversationsConversationidParticipantsParticipantidConsultDelete (string conversationId, string participantId);
  
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConversationsConversationidParticipantsParticipantidConsultDeleteWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ConversationsConversationidParticipantsParticipantidConsultDeleteAsync (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidParticipantsParticipantidConsultDeleteAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidMonitorPost (string conversationId, string participantId);
  
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidMonitorPostWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidMonitorPostAsync (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidMonitorPostAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param>
        /// <param name="address">The address that will be used to contact the new participant</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param>
        /// <param name="queueId">The id of the queue that will replace this participant.</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidReplacePost (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
  
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param>
        /// <param name="address">The address that will be used to contact the new participant</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param>
        /// <param name="queueId">The id of the queue that will replace this participant.</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidReplacePostWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param>
        /// <param name="address">The address that will be used to contact the new participant</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param>
        /// <param name="queueId">The id of the queue that will replace this participant.</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidReplacePostAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param>
        /// <param name="address">The address that will be used to contact the new participant</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param>
        /// <param name="queueId">The id of the queue that will replace this participant.</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidReplacePostAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
        
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>WrapupCode</returns>
        WrapupCode ConversationsConversationidParticipantsParticipantidWrapupGet (string conversationId, string participantId, bool? provisional = null);
  
        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupGetWithHttpInfo (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupGetAsync (string conversationId, string participantId, bool? provisional = null);

        /// <summary>
        /// Get the wrap-up for this conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupGetAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode ConversationsConversationidParticipantsParticipantidWrapupcodesGet (string conversationId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupcodesGetWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Tag</returns>
        Tag ConversationsConversationidTagsGet (string conversationId);
  
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Tag</returns>
        ApiResponse<Tag> ConversationsConversationidTagsGetWithHttpInfo (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        System.Threading.Tasks.Task<Tag> ConversationsConversationidTagsGetAsync (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tag>> ConversationsConversationidTagsGetAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode ConversationsConversationidWrapupcodesGet (string conversationId);
  
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> ConversationsConversationidWrapupcodesGetWithHttpInfo (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidWrapupcodesGetAsync (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidWrapupcodesGetAsyncWithHttpInfo (string conversationId);
        
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
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param> 
        /// <returns>ConversationEntityListing</returns>
        public ConversationEntityListing ConversationsGet (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> response = ConversationsGetWithHttpInfo(communicationType);
             return response.Data;
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param> 
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        public ApiResponse< ConversationEntityListing > ConversationsGetWithHttpInfo (string communicationType = null)
        {
            
    
            var path_ = "/api/v1/conversations";
    
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
            
            if (communicationType != null) queryParams.Add("communicationType", Configuration.ApiClient.ParameterToString(communicationType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConversationEntityListing)));
            
        }
    
        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<ConversationEntityListing> ConversationsGetAsync (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> response = await ConversationsGetAsyncWithHttpInfo(communicationType);
             return response.Data;

        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> ConversationsGetAsyncWithHttpInfo (string communicationType = null)
        {
            
    
            var path_ = "/api/v1/conversations";
    
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
            
            if (communicationType != null) queryParams.Add("communicationType", Configuration.ApiClient.ParameterToString(communicationType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConversationEntityListing)));
            
        }
        
        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <param name="call">Phone number to call</param> 
        /// <param name="callFrom">Queue id to place the call from</param> 
        /// <param name="callQueueId">Queue id to call</param> 
        /// <param name="callUserId">User id to call (this will call the default number)</param> 
        /// <param name="priority">Priority level to use for routing when calling a queue</param> 
        /// <param name="languageId">Language id to use for routing when calling a queue</param> 
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param> 
        /// <param name="body"></param> 
        /// <returns>ConversationResponse</returns>
        public ConversationResponse ConversationsPost (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> response = ConversationsPostWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
             return response.Data;
        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <param name="call">Phone number to call</param> 
        /// <param name="callFrom">Queue id to place the call from</param> 
        /// <param name="callQueueId">Queue id to call</param> 
        /// <param name="callUserId">User id to call (this will call the default number)</param> 
        /// <param name="priority">Priority level to use for routing when calling a queue</param> 
        /// <param name="languageId">Language id to use for routing when calling a queue</param> 
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ConversationResponse</returns>
        public ApiResponse< ConversationResponse > ConversationsPostWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
            
    
            var path_ = "/api/v1/conversations";
    
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
            
            if (call != null) queryParams.Add("call", Configuration.ApiClient.ParameterToString(call)); // query parameter
            if (callFrom != null) queryParams.Add("callFrom", Configuration.ApiClient.ParameterToString(callFrom)); // query parameter
            if (callQueueId != null) queryParams.Add("callQueueId", Configuration.ApiClient.ParameterToString(callQueueId)); // query parameter
            if (callUserId != null) queryParams.Add("callUserId", Configuration.ApiClient.ParameterToString(callUserId)); // query parameter
            if (priority != null) queryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            if (languageId != null) queryParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // query parameter
            if (skillIds != null) queryParams.Add("skillIds", Configuration.ApiClient.ParameterToString(skillIds)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationResponse)));
            
        }
    
        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <param name="call">Phone number to call</param>
        /// <param name="callFrom">Queue id to place the call from</param>
        /// <param name="callQueueId">Queue id to call</param>
        /// <param name="callUserId">User id to call (this will call the default number)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue</param>
        /// <param name="languageId">Language id to use for routing when calling a queue</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param>
        /// <param name="body"></param>
        /// <returns>Task of ConversationResponse</returns>
        public async System.Threading.Tasks.Task<ConversationResponse> ConversationsPostAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> response = await ConversationsPostAsyncWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
             return response.Data;

        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <param name="call">Phone number to call</param>
        /// <param name="callFrom">Queue id to place the call from</param>
        /// <param name="callQueueId">Queue id to call</param>
        /// <param name="callUserId">User id to call (this will call the default number)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue</param>
        /// <param name="languageId">Language id to use for routing when calling a queue</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ConversationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> ConversationsPostAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
            
    
            var path_ = "/api/v1/conversations";
    
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
            
            if (call != null) queryParams.Add("call", Configuration.ApiClient.ParameterToString(call)); // query parameter
            if (callFrom != null) queryParams.Add("callFrom", Configuration.ApiClient.ParameterToString(callFrom)); // query parameter
            if (callQueueId != null) queryParams.Add("callQueueId", Configuration.ApiClient.ParameterToString(callQueueId)); // query parameter
            if (callUserId != null) queryParams.Add("callUserId", Configuration.ApiClient.ParameterToString(callUserId)); // query parameter
            if (priority != null) queryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            if (languageId != null) queryParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // query parameter
            if (skillIds != null) queryParams.Add("skillIds", Configuration.ApiClient.ParameterToString(skillIds)); // query parameter
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationResponse)));
            
        }
        
        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param> 
        /// <returns>FaxSendResponse</returns>
        public FaxSendResponse ConversationsFaxPost (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> response = ConversationsFaxPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param> 
        /// <returns>ApiResponse of FaxSendResponse</returns>
        public ApiResponse< FaxSendResponse > ConversationsFaxPostWithHttpInfo (FaxSendRequest body = null)
        {
            
    
            var path_ = "/api/v1/conversations/fax";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsFaxPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsFaxPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxSendResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(response, typeof(FaxSendResponse)));
            
        }
    
        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        public async System.Threading.Tasks.Task<FaxSendResponse> ConversationsFaxPostAsync (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> response = await ConversationsFaxPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> ConversationsFaxPostAsyncWithHttpInfo (FaxSendRequest body = null)
        {
            
    
            var path_ = "/api/v1/conversations/fax";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsFaxPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsFaxPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(response, typeof(FaxSendResponse)));
            
        }
        
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>MaxParticipants</returns>
        public MaxParticipants ConversationsMaximumconferencepartiesGet ()
        {
             ApiResponse<MaxParticipants> response = ConversationsMaximumconferencepartiesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>ApiResponse of MaxParticipants</returns>
        public ApiResponse< MaxParticipants > ConversationsMaximumconferencepartiesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/conversations/maximumconferenceparties";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<MaxParticipants>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(response, typeof(MaxParticipants)));
            
        }
    
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>Task of MaxParticipants</returns>
        public async System.Threading.Tasks.Task<MaxParticipants> ConversationsMaximumconferencepartiesGetAsync ()
        {
             ApiResponse<MaxParticipants> response = await ConversationsMaximumconferencepartiesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> ConversationsMaximumconferencepartiesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/conversations/maximumconferenceparties";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<MaxParticipants>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(response, typeof(MaxParticipants)));
            
        }
        
        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ConversationQueryResponse</returns>
        public ConversationQueryResponse ConversationsQueryPost (ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> response = ConversationsQueryPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > ConversationsQueryPostWithHttpInfo (ConversationHistoricalQueryRequestBody body = null)
        {
            
    
            var path_ = "/api/v1/conversations/query";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsQueryPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
    
        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryPostAsync (ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> response = await ConversationsQueryPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryPostAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body = null)
        {
            
    
            var path_ = "/api/v1/conversations/query";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsQueryPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsQueryPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
        
        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">Anchor</param> 
        /// <param name="body"></param> 
        /// <returns>ConversationQueryResponse</returns>
        public ConversationQueryResponse ConversationsQueryAnchorPost (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> response = ConversationsQueryAnchorPostWithHttpInfo(anchor, body);
             return response.Data;
        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">Anchor</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > ConversationsQueryAnchorPostWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
            
            // verify the required parameter 'anchor' is set
            if (anchor == null) throw new ApiException(400, "Missing required parameter 'anchor' when calling ConversationsQueryAnchorPost");
            
    
            var path_ = "/api/v1/conversations/query/{anchor}";
    
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
            if (anchor != null) pathParams.Add("anchor", Configuration.ApiClient.ParameterToString(anchor)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsQueryAnchorPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsQueryAnchorPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
    
        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"></param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryAnchorPostAsync (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> response = await ConversationsQueryAnchorPostAsyncWithHttpInfo(anchor, body);
             return response.Data;

        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryAnchorPostAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
            // verify the required parameter 'anchor' is set
            if (anchor == null) throw new ApiException(400, "Missing required parameter 'anchor' when calling ConversationsQueryAnchorPost");
            
    
            var path_ = "/api/v1/conversations/query/{anchor}";
    
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
            if (anchor != null) pathParams.Add("anchor", Configuration.ApiClient.ParameterToString(anchor)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsQueryAnchorPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsQueryAnchorPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
        
        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>Conversation</returns>
        public Conversation ConversationsConversationidGet (string conversationId)
        {
             ApiResponse<Conversation> response = ConversationsConversationidGetWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > ConversationsConversationidGetWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
    
        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> ConversationsConversationidGetAsync (string conversationId)
        {
             ApiResponse<Conversation> response = await ConversationsConversationidGetAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>Conversation</returns>
        public Conversation ConversationsConversationidPut (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = ConversationsConversationidPutWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > ConversationsConversationidPutWithHttpInfo (string conversationId, Conversation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
    
        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> ConversationsConversationidPutAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = await ConversationsConversationidPutAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidPutAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing ConversationsConversationidMessagesGet (string conversationId)
        {
             ApiResponse<EmailMessageListing> response = ConversationsConversationidMessagesGetWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > ConversationsConversationidMessagesGetWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessageListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(response, typeof(EmailMessageListing)));
            
        }
    
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> ConversationsConversationidMessagesGetAsync (string conversationId)
        {
             ApiResponse<EmailMessageListing> response = await ConversationsConversationidMessagesGetAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> ConversationsConversationidMessagesGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(response, typeof(EmailMessageListing)));
            
        }
        
        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Reply</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesPost (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = ConversationsConversationidMessagesPostWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Reply</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesPostWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
    
        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesPostAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = await ConversationsConversationidMessagesPostAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesPostAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesDraftGet (string conversationId)
        {
             ApiResponse<EmailMessage> response = ConversationsConversationidMessagesDraftGetWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesDraftGetWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesDraftGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
    
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftGetAsync (string conversationId)
        {
             ApiResponse<EmailMessage> response = await ConversationsConversationidMessagesDraftGetAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesDraftGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Draft</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesDraftPut (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = ConversationsConversationidMessagesDraftPutWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Draft</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesDraftPutWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesDraftPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
    
        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftPutAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = await ConversationsConversationidMessagesDraftPutAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftPutAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesDraftPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="attachmentId">attachment ID</param> 
        /// <returns>string</returns>
        public string ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete (string conversationId, string attachmentId)
        {
             ApiResponse<string> response = ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteWithHttpInfo(conversationId, attachmentId);
             return response.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="attachmentId">attachment ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteWithHttpInfo (string conversationId, string attachmentId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId}";
    
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
            if (attachmentId != null) pathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsync (string conversationId, string attachmentId)
        {
             ApiResponse<string> response = await ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsyncWithHttpInfo(conversationId, attachmentId);
             return response.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsyncWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId}";
    
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
            if (attachmentId != null) pathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="id">message ID</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesIdGet (string conversationId, string id)
        {
             ApiResponse<EmailMessage> response = ConversationsConversationidMessagesIdGetWithHttpInfo(conversationId, id);
             return response.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="id">message ID</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesIdGetWithHttpInfo (string conversationId, string id)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesIdGet");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConversationsConversationidMessagesIdGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
    
        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesIdGetAsync (string conversationId, string id)
        {
             ApiResponse<EmailMessage> response = await ConversationsConversationidMessagesIdGetAsyncWithHttpInfo(conversationId, id);
             return response.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesIdGetAsyncWithHttpInfo (string conversationId, string id)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidMessagesIdGet");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConversationsConversationidMessagesIdGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/{id}";
    
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
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidMessagesIdGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>Conversation</returns>
        public Conversation ConversationsConversationidParticipantsPost (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = ConversationsConversationidParticipantsPostWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > ConversationsConversationidParticipantsPostWithHttpInfo (string conversationId, Conversation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
    
        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> ConversationsConversationidParticipantsPostAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = await ConversationsConversationidParticipantsPostAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidParticipantsPostAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants";
    
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidPut (string conversationId, string participantId, ParticipantRequest body = null)
        {
             ConversationsConversationidParticipantsParticipantidPutWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidPutWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidPut");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidPutAsync (string conversationId, string participantId, ParticipantRequest body = null)
        {
             await ConversationsConversationidParticipantsParticipantidPutAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidAttributesPut (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             ConversationsConversationidParticipantsParticipantidAttributesPutWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidAttributesPutWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidAttributesPut");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidAttributesPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/attributes";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidAttributesPutAsync (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             await ConversationsConversationidParticipantsParticipantidAttributesPutAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidAttributesPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidAttributesPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidAttributesPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/attributes";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">new speak to</param> 
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPut (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> response = ConversationsConversationidParticipantsParticipantidConsultPutWithHttpInfo(conversationId, participantId, body);
             return response.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">new speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > ConversationsConversationidParticipantsParticipantidConsultPutWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidConsultPut");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidConsultPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsultTransferResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultTransferResponse)));
            
        }
    
        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPutAsync (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> response = await ConversationsConversationidParticipantsParticipantidConsultPutAsyncWithHttpInfo(conversationId, participantId, body);
             return response.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPutAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidConsultPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidConsultPut");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultTransferResponse)));
            
        }
        
        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">Destination address &amp; initial speak to</param> 
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPost (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> response = ConversationsConversationidParticipantsParticipantidConsultPostWithHttpInfo(conversationId, participantId, body);
             return response.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">Destination address &amp; initial speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > ConversationsConversationidParticipantsParticipantidConsultPostWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidConsultPost");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidConsultPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsultTransferResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultTransferResponse)));
            
        }
    
        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPostAsync (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> response = await ConversationsConversationidParticipantsParticipantidConsultPostAsyncWithHttpInfo(conversationId, participantId, body);
             return response.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPostAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidConsultPost");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidConsultPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(response, typeof(ConsultTransferResponse)));
            
        }
        
        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <returns>string</returns>
        public string ConversationsConversationidParticipantsParticipantidConsultDelete (string conversationId, string participantId)
        {
             ApiResponse<string> response = ConversationsConversationidParticipantsParticipantidConsultDeleteWithHttpInfo(conversationId, participantId);
             return response.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConversationsConversationidParticipantsParticipantidConsultDeleteWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidConsultDelete");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidConsultDelete");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConversationsConversationidParticipantsParticipantidConsultDeleteAsync (string conversationId, string participantId)
        {
             ApiResponse<string> response = await ConversationsConversationidParticipantsParticipantidConsultDeleteAsyncWithHttpInfo(conversationId, participantId);
             return response.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidParticipantsParticipantidConsultDeleteAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidConsultDelete");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidConsultDelete");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidMonitorPost (string conversationId, string participantId)
        {
             ConversationsConversationidParticipantsParticipantidMonitorPostWithHttpInfo(conversationId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidMonitorPostWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidMonitorPost");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidMonitorPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/monitor";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidMonitorPostAsync (string conversationId, string participantId)
        {
             await ConversationsConversationidParticipantsParticipantidMonitorPostAsyncWithHttpInfo(conversationId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidMonitorPostAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidMonitorPost");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidMonitorPost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/monitor";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param> 
        /// <param name="address">The address that will be used to contact the new participant</param> 
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param> 
        /// <param name="queueId">The id of the queue that will replace this participant.</param> 
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param> 
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidReplacePost (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             ConversationsConversationidParticipantsParticipantidReplacePostWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param> 
        /// <param name="address">The address that will be used to contact the new participant</param> 
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param> 
        /// <param name="queueId">The id of the queue that will replace this participant.</param> 
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidReplacePostWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidReplacePost");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidReplacePost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/replace";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            if (userId != null) queryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (address != null) queryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (username != null) queryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (queueId != null) queryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (voicemail != null) queryParams.Add("voicemail", Configuration.ApiClient.ParameterToString(voicemail)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param>
        /// <param name="address">The address that will be used to contact the new participant</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param>
        /// <param name="queueId">The id of the queue that will replace this participant.</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidReplacePostAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             await ConversationsConversationidParticipantsParticipantidReplacePostAsyncWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat.</param>
        /// <param name="address">The address that will be used to contact the new participant</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank.</param>
        /// <param name="queueId">The id of the queue that will replace this participant.</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidReplacePostAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidReplacePost");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidReplacePost");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/replace";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            if (userId != null) queryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (address != null) queryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (username != null) queryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (queueId != null) queryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (voicemail != null) queryParams.Add("voicemail", Configuration.ApiClient.ParameterToString(voicemail)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode ConversationsConversationidParticipantsParticipantidWrapupGet (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> response = ConversationsConversationidParticipantsParticipantidWrapupGetWithHttpInfo(conversationId, participantId, provisional);
             return response.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > ConversationsConversationidParticipantsParticipantidWrapupGetWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidWrapupGet");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidWrapupGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapup";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            if (provisional != null) queryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupGetAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> response = await ConversationsConversationidParticipantsParticipantidWrapupGetAsyncWithHttpInfo(conversationId, participantId, provisional);
             return response.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupGetAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidWrapupGet");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidWrapupGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapup";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            if (provisional != null) queryParams.Add("provisional", Configuration.ApiClient.ParameterToString(provisional)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode ConversationsConversationidParticipantsParticipantidWrapupcodesGet (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> response = ConversationsConversationidParticipantsParticipantidWrapupcodesGetWithHttpInfo(conversationId, participantId);
             return response.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > ConversationsConversationidParticipantsParticipantidWrapupcodesGetWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsync (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> response = await ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsyncWithHttpInfo(conversationId, participantId);
             return response.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
    
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
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>Tag</returns>
        public Tag ConversationsConversationidTagsGet (string conversationId)
        {
             ApiResponse<Tag> response = ConversationsConversationidTagsGetWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of Tag</returns>
        public ApiResponse< Tag > ConversationsConversationidTagsGetWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidTagsGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/tags";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidTagsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidTagsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(response, typeof(Tag)));
            
        }
    
        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        public async System.Threading.Tasks.Task<Tag> ConversationsConversationidTagsGetAsync (string conversationId)
        {
             ApiResponse<Tag> response = await ConversationsConversationidTagsGetAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tag>> ConversationsConversationidTagsGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidTagsGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/tags";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidTagsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidTagsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(response, typeof(Tag)));
            
        }
        
        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode ConversationsConversationidWrapupcodesGet (string conversationId)
        {
             ApiResponse<WrapupCode> response = ConversationsConversationidWrapupcodesGetWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > ConversationsConversationidWrapupcodesGetWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidWrapupcodesGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/wrapupcodes";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidWrapupcodesGetAsync (string conversationId)
        {
             ApiResponse<WrapupCode> response = await ConversationsConversationidWrapupcodesGetAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidWrapupcodesGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsConversationidWrapupcodesGet");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/wrapupcodes";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
    }
    
}
