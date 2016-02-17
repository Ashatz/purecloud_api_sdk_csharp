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
        ConversationEntityListing Get (string communicationType = null);
  
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        ApiResponse<ConversationEntityListing> GetWithHttpInfo (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ConversationEntityListing</returns>
        System.Threading.Tasks.Task<ConversationEntityListing> GetAsync (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> GetAsyncWithHttpInfo (string communicationType = null);
        
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
        ConversationResponse Create (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
  
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
        ApiResponse<ConversationResponse> CreateWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

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
        System.Threading.Tasks.Task<ConversationResponse> CreateAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

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
        System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> CreateAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
        
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse CreateFax (FaxSendRequest body = null);
  
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> CreateFaxWithHttpInfo (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> CreateFaxAsync (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> CreateFaxAsyncWithHttpInfo (FaxSendRequest body = null);
        
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>MaxParticipants</returns>
        MaxParticipants GetMaximumconferenceparties ();
  
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of MaxParticipants</returns>
        ApiResponse<MaxParticipants> GetMaximumconferencepartiesWithHttpInfo ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of MaxParticipants</returns>
        System.Threading.Tasks.Task<MaxParticipants> GetMaximumconferencepartiesAsync ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> GetMaximumconferencepartiesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse CreateQuery (ConversationHistoricalQueryRequestBody body);
  
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> CreateQueryWithHttpInfo (ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> CreateQueryAsync (ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> CreateQueryAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body);
        
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse CreateQueryAnchor (string anchor, ConversationHistoricalQueryRequestBody body);
  
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> CreateQueryAnchorWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> CreateQueryAnchorAsync (string anchor, ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> CreateQueryAnchorAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body);
        
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation GetConversation (string conversationId);
  
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> GetConversationWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> GetConversationAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation UpdateConversation (string conversationId, Conversation body = null);
  
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> UpdateConversationWithHttpInfo (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> UpdateConversationAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> UpdateConversationAsyncWithHttpInfo (string conversationId, Conversation body = null);
        
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing GetConversationMessages (string conversationId);
  
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> GetConversationMessagesWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> GetConversationMessagesAsync (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetConversationMessagesAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        EmailMessage CreateConversationMessages (string conversationId, EmailMessage body = null);
  
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> CreateConversationMessagesWithHttpInfo (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> CreateConversationMessagesAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> CreateConversationMessagesAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetConversationMessagesDraft (string conversationId);
  
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetConversationMessagesDraftWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetConversationMessagesDraftAsync (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationMessagesDraftAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        EmailMessage UpdateConversationMessagesDraft (string conversationId, EmailMessage body = null);
  
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> UpdateConversationMessagesDraftWithHttpInfo (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> UpdateConversationMessagesDraftAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> UpdateConversationMessagesDraftAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>string</returns>
        string DeleteConversationMessagesDraftAttachmentsByAttachmentId (string conversationId, string attachmentId);
  
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteConversationMessagesDraftAttachmentsByAttachmentIdWithHttpInfo (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteConversationMessagesDraftAttachmentsByAttachmentIdAsync (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationMessagesDraftAttachmentsByAttachmentIdAsyncWithHttpInfo (string conversationId, string attachmentId);
        
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetConversationMessagesById (string conversationId, string id);
  
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetConversationMessagesByIdWithHttpInfo (string conversationId, string id);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetConversationMessagesByIdAsync (string conversationId, string id);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationMessagesByIdAsyncWithHttpInfo (string conversationId, string id);
        
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation CreateConversationParticipants (string conversationId, Conversation body = null);
  
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> CreateConversationParticipantsWithHttpInfo (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> CreateConversationParticipantsAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> CreateConversationParticipantsAsyncWithHttpInfo (string conversationId, Conversation body = null);
        
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
        void UpdateConversationParticipantsByParticipantId (string conversationId, string participantId, ParticipantRequest body = null);
  
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
        ApiResponse<Object> UpdateConversationParticipantsByParticipantIdWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);

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
        System.Threading.Tasks.Task UpdateConversationParticipantsByParticipantIdAsync (string conversationId, string participantId, ParticipantRequest body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateConversationParticipantsByParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);
        
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
        void UpdateConversationParticipantsByParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null);
  
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
        ApiResponse<Object> UpdateConversationParticipantsByParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);

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
        System.Threading.Tasks.Task UpdateConversationParticipantsByParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateConversationParticipantsByParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        
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
        ConsultTransferResponse UpdateConversationParticipantsByParticipantIdConsult (string conversationId, string participantId, ConsultTransferUpdate body = null);
  
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
        ApiResponse<ConsultTransferResponse> UpdateConversationParticipantsByParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);

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
        System.Threading.Tasks.Task<ConsultTransferResponse> UpdateConversationParticipantsByParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransferUpdate body = null);

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
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> UpdateConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);
        
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
        ConsultTransferResponse CreateConversationParticipantsByParticipantIdConsult (string conversationId, string participantId, ConsultTransfer body = null);
  
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
        ApiResponse<ConsultTransferResponse> CreateConversationParticipantsByParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);

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
        System.Threading.Tasks.Task<ConsultTransferResponse> CreateConversationParticipantsByParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransfer body = null);

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
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> CreateConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);
        
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>string</returns>
        string DeleteConversationParticipantsByParticipantIdConsult (string conversationId, string participantId);
  
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteConversationParticipantsByParticipantIdConsultWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteConversationParticipantsByParticipantIdConsultAsync (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns></returns>
        void CreateConversationParticipantsByParticipantIdMonitor (string conversationId, string participantId);
  
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateConversationParticipantsByParticipantIdMonitorWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateConversationParticipantsByParticipantIdMonitorAsync (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateConversationParticipantsByParticipantIdMonitorAsyncWithHttpInfo (string conversationId, string participantId);
        
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
        void CreateConversationParticipantsByParticipantIdReplace (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
  
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
        ApiResponse<Object> CreateConversationParticipantsByParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

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
        System.Threading.Tasks.Task CreateConversationParticipantsByParticipantIdReplaceAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateConversationParticipantsByParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
        
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
        WrapupCode GetConversationParticipantsByParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null);
  
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
        ApiResponse<WrapupCode> GetConversationParticipantsByParticipantIdWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantsByParticipantIdWrapupAsync (string conversationId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantsByParticipantIdWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetConversationParticipantsByParticipantIdWrapupcodes (string conversationId, string participantId);
  
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationParticipantsByParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantsByParticipantIdWrapupcodesAsync (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantsByParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Tag</returns>
        Tag GetConversationTags (string conversationId);
  
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Tag</returns>
        ApiResponse<Tag> GetConversationTagsWithHttpInfo (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        System.Threading.Tasks.Task<Tag> GetConversationTagsAsync (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tag>> GetConversationTagsAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetConversationWrapupcodes (string conversationId);
  
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationWrapupcodesWithHttpInfo (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetConversationWrapupcodesAsync (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationWrapupcodesAsyncWithHttpInfo (string conversationId);
        
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
        public ConversationEntityListing Get (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> response = GetWithHttpInfo(communicationType);
             return response.Data;
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param> 
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        public ApiResponse< ConversationEntityListing > GetWithHttpInfo (string communicationType = null)
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConversationEntityListing)));
            
        }
    
        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ConversationEntityListing</returns>
        public async System.Threading.Tasks.Task<ConversationEntityListing> GetAsync (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> response = await GetAsyncWithHttpInfo(communicationType);
             return response.Data;

        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <param name="communicationType">Call or Chat communication filtering</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> GetAsyncWithHttpInfo (string communicationType = null)
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

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
        public ConversationResponse Create (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> response = CreateWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
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
        public ApiResponse< ConversationResponse > CreateWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
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
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConversationResponse> CreateAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> response = await CreateAsyncWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> CreateAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
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
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationResponse)));
            
        }
        
        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param> 
        /// <returns>FaxSendResponse</returns>
        public FaxSendResponse CreateFax (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> response = CreateFaxWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param> 
        /// <returns>ApiResponse of FaxSendResponse</returns>
        public ApiResponse< FaxSendResponse > CreateFaxWithHttpInfo (FaxSendRequest body = null)
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
                throw new ApiException (statusCode, "Error calling CreateFax: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateFax: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxSendResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(response, typeof(FaxSendResponse)));
            
        }
    
        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        public async System.Threading.Tasks.Task<FaxSendResponse> CreateFaxAsync (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> response = await CreateFaxAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> CreateFaxAsyncWithHttpInfo (FaxSendRequest body = null)
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
                throw new ApiException (statusCode, "Error calling CreateFax: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateFax: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(response, typeof(FaxSendResponse)));
            
        }
        
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>MaxParticipants</returns>
        public MaxParticipants GetMaximumconferenceparties ()
        {
             ApiResponse<MaxParticipants> response = GetMaximumconferencepartiesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>ApiResponse of MaxParticipants</returns>
        public ApiResponse< MaxParticipants > GetMaximumconferencepartiesWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling GetMaximumconferenceparties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMaximumconferenceparties: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<MaxParticipants>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(response, typeof(MaxParticipants)));
            
        }
    
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>Task of MaxParticipants</returns>
        public async System.Threading.Tasks.Task<MaxParticipants> GetMaximumconferencepartiesAsync ()
        {
             ApiResponse<MaxParticipants> response = await GetMaximumconferencepartiesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> GetMaximumconferencepartiesAsyncWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling GetMaximumconferenceparties: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMaximumconferenceparties: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<MaxParticipants>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(response, typeof(MaxParticipants)));
            
        }
        
        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param> 
        /// <returns>ConversationQueryResponse</returns>
        public ConversationQueryResponse CreateQuery (ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = CreateQueryWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param> 
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > CreateQueryWithHttpInfo (ConversationHistoricalQueryRequestBody body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateQuery");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
    
        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> CreateQueryAsync (ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = await CreateQueryAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> CreateQueryAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateQuery");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
        
        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param> 
        /// <param name="body">Query parameters</param> 
        /// <returns>ConversationQueryResponse</returns>
        public ConversationQueryResponse CreateQueryAnchor (string anchor, ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = CreateQueryAnchorWithHttpInfo(anchor, body);
             return response.Data;
        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param> 
        /// <param name="body">Query parameters</param> 
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > CreateQueryAnchorWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body)
        {
            
            // verify the required parameter 'anchor' is set
            if (anchor == null) throw new ApiException(400, "Missing required parameter 'anchor' when calling CreateQueryAnchor");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateQueryAnchor");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateQueryAnchor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateQueryAnchor: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
    
        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> CreateQueryAnchorAsync (string anchor, ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = await CreateQueryAnchorAsyncWithHttpInfo(anchor, body);
             return response.Data;

        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> CreateQueryAnchorAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body)
        {
            // verify the required parameter 'anchor' is set
            if (anchor == null) throw new ApiException(400, "Missing required parameter 'anchor' when calling CreateQueryAnchor");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateQueryAnchor");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateQueryAnchor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateQueryAnchor: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
        
        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>Conversation</returns>
        public Conversation GetConversation (string conversationId)
        {
             ApiResponse<Conversation> response = GetConversationWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > GetConversationWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversation");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversation: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
    
        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> GetConversationAsync (string conversationId)
        {
             ApiResponse<Conversation> response = await GetConversationAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversation");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversation: " + response.ErrorMessage, response.ErrorMessage);

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
        public Conversation UpdateConversation (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = UpdateConversationWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > UpdateConversationWithHttpInfo (string conversationId, Conversation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversation");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversation: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Conversation> UpdateConversationAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = await UpdateConversationAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> UpdateConversationAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversation");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversation: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing GetConversationMessages (string conversationId)
        {
             ApiResponse<EmailMessageListing> response = GetConversationMessagesWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > GetConversationMessagesWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationMessages");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessageListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(response, typeof(EmailMessageListing)));
            
        }
    
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> GetConversationMessagesAsync (string conversationId)
        {
             ApiResponse<EmailMessageListing> response = await GetConversationMessagesAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetConversationMessagesAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationMessages");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationMessages: " + response.ErrorMessage, response.ErrorMessage);

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
        public EmailMessage CreateConversationMessages (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = CreateConversationMessagesWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Reply</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > CreateConversationMessagesWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationMessages");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationMessages: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EmailMessage> CreateConversationMessagesAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = await CreateConversationMessagesAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> CreateConversationMessagesAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationMessages");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationMessages: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage GetConversationMessagesDraft (string conversationId)
        {
             ApiResponse<EmailMessage> response = GetConversationMessagesDraftWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetConversationMessagesDraftWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationMessagesDraft");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
    
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetConversationMessagesDraftAsync (string conversationId)
        {
             ApiResponse<EmailMessage> response = await GetConversationMessagesDraftAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationMessagesDraftAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationMessagesDraft");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);

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
        public EmailMessage UpdateConversationMessagesDraft (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = UpdateConversationMessagesDraftWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Draft</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > UpdateConversationMessagesDraftWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationMessagesDraft");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EmailMessage> UpdateConversationMessagesDraftAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = await UpdateConversationMessagesDraftAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> UpdateConversationMessagesDraftAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationMessagesDraft");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteConversationMessagesDraftAttachmentsByAttachmentId (string conversationId, string attachmentId)
        {
             ApiResponse<string> response = DeleteConversationMessagesDraftAttachmentsByAttachmentIdWithHttpInfo(conversationId, attachmentId);
             return response.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="attachmentId">attachment ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteConversationMessagesDraftAttachmentsByAttachmentIdWithHttpInfo (string conversationId, string attachmentId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationMessagesDraftAttachmentsByAttachmentId");
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling DeleteConversationMessagesDraftAttachmentsByAttachmentId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteConversationMessagesDraftAttachmentsByAttachmentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationMessagesDraftAttachmentsByAttachmentId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteConversationMessagesDraftAttachmentsByAttachmentIdAsync (string conversationId, string attachmentId)
        {
             ApiResponse<string> response = await DeleteConversationMessagesDraftAttachmentsByAttachmentIdAsyncWithHttpInfo(conversationId, attachmentId);
             return response.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationMessagesDraftAttachmentsByAttachmentIdAsyncWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationMessagesDraftAttachmentsByAttachmentId");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling DeleteConversationMessagesDraftAttachmentsByAttachmentId");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteConversationMessagesDraftAttachmentsByAttachmentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationMessagesDraftAttachmentsByAttachmentId: " + response.ErrorMessage, response.ErrorMessage);

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
        public EmailMessage GetConversationMessagesById (string conversationId, string id)
        {
             ApiResponse<EmailMessage> response = GetConversationMessagesByIdWithHttpInfo(conversationId, id);
             return response.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="id">message ID</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetConversationMessagesByIdWithHttpInfo (string conversationId, string id)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationMessagesById");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetConversationMessagesById");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationMessagesById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationMessagesById: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EmailMessage> GetConversationMessagesByIdAsync (string conversationId, string id)
        {
             ApiResponse<EmailMessage> response = await GetConversationMessagesByIdAsyncWithHttpInfo(conversationId, id);
             return response.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationMessagesByIdAsyncWithHttpInfo (string conversationId, string id)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationMessagesById");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetConversationMessagesById");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationMessagesById: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationMessagesById: " + response.ErrorMessage, response.ErrorMessage);

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
        public Conversation CreateConversationParticipants (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = CreateConversationParticipantsWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > CreateConversationParticipantsWithHttpInfo (string conversationId, Conversation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipants");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipants: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipants: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Conversation> CreateConversationParticipantsAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = await CreateConversationParticipantsAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> CreateConversationParticipantsAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipants");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipants: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipants: " + response.ErrorMessage, response.ErrorMessage);

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
        public void UpdateConversationParticipantsByParticipantId (string conversationId, string participantId, ParticipantRequest body = null)
        {
             UpdateConversationParticipantsByParticipantIdWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateConversationParticipantsByParticipantIdWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationParticipantsByParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling UpdateConversationParticipantsByParticipantId");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task UpdateConversationParticipantsByParticipantIdAsync (string conversationId, string participantId, ParticipantRequest body = null)
        {
             await UpdateConversationParticipantsByParticipantIdAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateConversationParticipantsByParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationParticipantsByParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling UpdateConversationParticipantsByParticipantId");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public void UpdateConversationParticipantsByParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             UpdateConversationParticipantsByParticipantIdAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateConversationParticipantsByParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationParticipantsByParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling UpdateConversationParticipantsByParticipantIdAttributes");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task UpdateConversationParticipantsByParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             await UpdateConversationParticipantsByParticipantIdAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateConversationParticipantsByParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationParticipantsByParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling UpdateConversationParticipantsByParticipantIdAttributes");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdAttributes: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ConsultTransferResponse UpdateConversationParticipantsByParticipantIdConsult (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> response = UpdateConversationParticipantsByParticipantIdConsultWithHttpInfo(conversationId, participantId, body);
             return response.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">new speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > UpdateConversationParticipantsByParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationParticipantsByParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling UpdateConversationParticipantsByParticipantIdConsult");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConsultTransferResponse> UpdateConversationParticipantsByParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> response = await UpdateConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo(conversationId, participantId, body);
             return response.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> UpdateConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationParticipantsByParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling UpdateConversationParticipantsByParticipantIdConsult");
            
    
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
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationParticipantsByParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);

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
        public ConsultTransferResponse CreateConversationParticipantsByParticipantIdConsult (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> response = CreateConversationParticipantsByParticipantIdConsultWithHttpInfo(conversationId, participantId, body);
             return response.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">Destination address &amp; initial speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > CreateConversationParticipantsByParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipantsByParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling CreateConversationParticipantsByParticipantIdConsult");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConsultTransferResponse> CreateConversationParticipantsByParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> response = await CreateConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo(conversationId, participantId, body);
             return response.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> CreateConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipantsByParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling CreateConversationParticipantsByParticipantIdConsult");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteConversationParticipantsByParticipantIdConsult (string conversationId, string participantId)
        {
             ApiResponse<string> response = DeleteConversationParticipantsByParticipantIdConsultWithHttpInfo(conversationId, participantId);
             return response.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteConversationParticipantsByParticipantIdConsultWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationParticipantsByParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling DeleteConversationParticipantsByParticipantIdConsult");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteConversationParticipantsByParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationParticipantsByParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteConversationParticipantsByParticipantIdConsultAsync (string conversationId, string participantId)
        {
             ApiResponse<string> response = await DeleteConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo(conversationId, participantId);
             return response.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationParticipantsByParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationParticipantsByParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling DeleteConversationParticipantsByParticipantIdConsult");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteConversationParticipantsByParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationParticipantsByParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);

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
        public void CreateConversationParticipantsByParticipantIdMonitor (string conversationId, string participantId)
        {
             CreateConversationParticipantsByParticipantIdMonitorWithHttpInfo(conversationId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateConversationParticipantsByParticipantIdMonitorWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipantsByParticipantIdMonitor");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling CreateConversationParticipantsByParticipantIdMonitor");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdMonitor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdMonitor: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task CreateConversationParticipantsByParticipantIdMonitorAsync (string conversationId, string participantId)
        {
             await CreateConversationParticipantsByParticipantIdMonitorAsyncWithHttpInfo(conversationId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateConversationParticipantsByParticipantIdMonitorAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipantsByParticipantIdMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling CreateConversationParticipantsByParticipantIdMonitor");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdMonitor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdMonitor: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public void CreateConversationParticipantsByParticipantIdReplace (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             CreateConversationParticipantsByParticipantIdReplaceWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);
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
        public ApiResponse<Object> CreateConversationParticipantsByParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipantsByParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling CreateConversationParticipantsByParticipantIdReplace");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdReplace: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdReplace: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task CreateConversationParticipantsByParticipantIdReplaceAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             await CreateConversationParticipantsByParticipantIdReplaceAsyncWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);

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
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateConversationParticipantsByParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationParticipantsByParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling CreateConversationParticipantsByParticipantIdReplace");
            
    
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
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdReplace: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationParticipantsByParticipantIdReplace: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public WrapupCode GetConversationParticipantsByParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> response = GetConversationParticipantsByParticipantIdWrapupWithHttpInfo(conversationId, participantId, provisional);
             return response.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationParticipantsByParticipantIdWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationParticipantsByParticipantIdWrapup");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationParticipantsByParticipantIdWrapup");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapup: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantsByParticipantIdWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> response = await GetConversationParticipantsByParticipantIdWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return response.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional.</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantsByParticipantIdWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationParticipantsByParticipantIdWrapup");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationParticipantsByParticipantIdWrapup");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapup: " + response.ErrorMessage, response.ErrorMessage);

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
        public WrapupCode GetConversationParticipantsByParticipantIdWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> response = GetConversationParticipantsByParticipantIdWrapupcodesWithHttpInfo(conversationId, participantId);
             return response.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationParticipantsByParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationParticipantsByParticipantIdWrapupcodes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationParticipantsByParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationParticipantsByParticipantIdWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> response = await GetConversationParticipantsByParticipantIdWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return response.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationParticipantsByParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationParticipantsByParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationParticipantsByParticipantIdWrapupcodes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationParticipantsByParticipantIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>Tag</returns>
        public Tag GetConversationTags (string conversationId)
        {
             ApiResponse<Tag> response = GetConversationTagsWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of Tag</returns>
        public ApiResponse< Tag > GetConversationTagsWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationTags");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationTags: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationTags: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(response, typeof(Tag)));
            
        }
    
        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        public async System.Threading.Tasks.Task<Tag> GetConversationTagsAsync (string conversationId)
        {
             ApiResponse<Tag> response = await GetConversationTagsAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tag>> GetConversationTagsAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationTags");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationTags: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationTags: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(response, typeof(Tag)));
            
        }
        
        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetConversationWrapupcodes (string conversationId)
        {
             ApiResponse<WrapupCode> response = GetConversationWrapupcodesWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationWrapupcodesWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationWrapupcodes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationWrapupcodesAsync (string conversationId)
        {
             ApiResponse<WrapupCode> response = await GetConversationWrapupcodesAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationWrapupcodesAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationWrapupcodes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetConversationWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
    }
    
}
