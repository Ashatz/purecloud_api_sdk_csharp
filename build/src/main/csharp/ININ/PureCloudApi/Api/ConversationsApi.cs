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
        ConversationResponse Post (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
  
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
        ApiResponse<ConversationResponse> PostWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

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
        System.Threading.Tasks.Task<ConversationResponse> PostAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

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
        System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> PostAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
        
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse PostFax (FaxSendRequest body = null);
  
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> PostFaxWithHttpInfo (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> PostFaxAsync (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostFaxAsyncWithHttpInfo (FaxSendRequest body = null);
        
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
        ConversationQueryResponse PostQuery (ConversationHistoricalQueryRequestBody body);
  
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> PostQueryWithHttpInfo (ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> PostQueryAsync (ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> PostQueryAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body);
        
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse PostQueryAnchor (string anchor, ConversationHistoricalQueryRequestBody body);
  
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> PostQueryAnchorWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> PostQueryAnchorAsync (string anchor, ConversationHistoricalQueryRequestBody body);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> PostQueryAnchorAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body);
        
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation GetConversationId (string conversationId);
  
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> GetConversationIdWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> GetConversationIdAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationIdAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PutConversationId (string conversationId, Conversation body = null);
  
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PutConversationIdWithHttpInfo (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PutConversationIdAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PutConversationIdAsyncWithHttpInfo (string conversationId, Conversation body = null);
        
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostConversationIdCalls (string conversationId, CallCommand body = null);
  
        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostConversationIdCallsWithHttpInfo (string conversationId, CallCommand body = null);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostConversationIdCallsAsync (string conversationId, CallCommand body = null);

        /// <summary>
        /// Add a new call to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationIdCallsAsyncWithHttpInfo (string conversationId, CallCommand body = null);
        
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing GetConversationIdMessages (string conversationId);
  
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> GetConversationIdMessagesWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> GetConversationIdMessagesAsync (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetConversationIdMessagesAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PostConversationIdMessages (string conversationId, EmailMessage body = null);
  
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PostConversationIdMessagesWithHttpInfo (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PostConversationIdMessagesAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostConversationIdMessagesAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetConversationIdMessagesDraft (string conversationId);
  
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetConversationIdMessagesDraftWithHttpInfo (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetConversationIdMessagesDraftAsync (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationIdMessagesDraftAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>EmailMessage</returns>
        EmailMessage PutConversationIdMessagesDraft (string conversationId, EmailMessage body = null);
  
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> PutConversationIdMessagesDraftWithHttpInfo (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> PutConversationIdMessagesDraftAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutConversationIdMessagesDraftAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>string</returns>
        string DeleteConversationIdMessagesDraftAttachmentsAttachmentId (string conversationId, string attachmentId);
  
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteConversationIdMessagesDraftAttachmentsAttachmentIdWithHttpInfo (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteConversationIdMessagesDraftAttachmentsAttachmentIdAsync (string conversationId, string attachmentId);

        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo (string conversationId, string attachmentId);
        
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage GetConversationIdMessagesId (string conversationId, string id);
  
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> GetConversationIdMessagesIdWithHttpInfo (string conversationId, string id);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> GetConversationIdMessagesIdAsync (string conversationId, string id);

        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationIdMessagesIdAsyncWithHttpInfo (string conversationId, string id);
        
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Conversation</returns>
        Conversation PostConversationIdParticipants (string conversationId, Conversation body = null);
  
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> PostConversationIdParticipantsWithHttpInfo (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> PostConversationIdParticipantsAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationIdParticipantsAsyncWithHttpInfo (string conversationId, Conversation body = null);
        
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
        void PutConversationIdParticipantsParticipantId (string conversationId, string participantId, ParticipantRequest body = null);
  
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
        ApiResponse<Object> PutConversationIdParticipantsParticipantIdWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);

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
        System.Threading.Tasks.Task PutConversationIdParticipantsParticipantIdAsync (string conversationId, string participantId, ParticipantRequest body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PutConversationIdParticipantsParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);
        
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
        void PutConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null);
  
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
        ApiResponse<Object> PutConversationIdParticipantsParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);

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
        System.Threading.Tasks.Task PutConversationIdParticipantsParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PutConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        
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
        ConsultTransferResponse PutConversationIdParticipantsParticipantIdConsult (string conversationId, string participantId, ConsultTransferUpdate body = null);
  
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
        ApiResponse<ConsultTransferResponse> PutConversationIdParticipantsParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);

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
        System.Threading.Tasks.Task<ConsultTransferResponse> PutConversationIdParticipantsParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransferUpdate body = null);

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
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PutConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);
        
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
        ConsultTransferResponse PostConversationIdParticipantsParticipantIdConsult (string conversationId, string participantId, ConsultTransfer body = null);
  
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
        ApiResponse<ConsultTransferResponse> PostConversationIdParticipantsParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);

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
        System.Threading.Tasks.Task<ConsultTransferResponse> PostConversationIdParticipantsParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransfer body = null);

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
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);
        
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>string</returns>
        string DeleteConversationIdParticipantsParticipantIdConsult (string conversationId, string participantId);
  
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteConversationIdParticipantsParticipantIdConsultWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteConversationIdParticipantsParticipantIdConsultAsync (string conversationId, string participantId);

        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns></returns>
        void PostConversationIdParticipantsParticipantIdMonitor (string conversationId, string participantId);
  
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostConversationIdParticipantsParticipantIdMonitorWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdMonitorAsync (string conversationId, string participantId);

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdMonitorAsyncWithHttpInfo (string conversationId, string participantId);
        
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
        void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
  
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
        ApiResponse<Object> PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

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
        System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdReplaceAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
        
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
        WrapupCode GetConversationIdParticipantsParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null);
  
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
        ApiResponse<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupWithHttpInfo (string conversationId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupAsync (string conversationId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
        
        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo (string conversationId, string participantId);

        /// <summary>
        /// Get list of wrapup codes for this conversation participant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId);
        
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Tag</returns>
        Tag GetConversationIdTags (string conversationId);
  
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Tag</returns>
        ApiResponse<Tag> GetConversationIdTagsWithHttpInfo (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        System.Threading.Tasks.Task<Tag> GetConversationIdTagsAsync (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tag>> GetConversationIdTagsAsyncWithHttpInfo (string conversationId);
        
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode GetConversationIdWrapupcodes (string conversationId);
  
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> GetConversationIdWrapupcodesWithHttpInfo (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> GetConversationIdWrapupcodesAsync (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdWrapupcodesAsyncWithHttpInfo (string conversationId);
        
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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public ConversationResponse Post (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> response = PostWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
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
        public ApiResponse< ConversationResponse > PostWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
            
    
            var path_ = "/api/v1/conversations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Post: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConversationResponse> PostAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> response = await PostAsyncWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> PostAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
            
    
            var path_ = "/api/v1/conversations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Post: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationResponse)));
            
        }
        
        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param> 
        /// <returns>FaxSendResponse</returns>
        public FaxSendResponse PostFax (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> response = PostFaxWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param> 
        /// <returns>ApiResponse of FaxSendResponse</returns>
        public ApiResponse< FaxSendResponse > PostFaxWithHttpInfo (FaxSendRequest body = null)
        {
            
    
            var path_ = "/api/v1/conversations/fax";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostFax: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFax: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FaxSendResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(response, typeof(FaxSendResponse)));
            
        }
    
        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param>
        /// <returns>Task of FaxSendResponse</returns>
        public async System.Threading.Tasks.Task<FaxSendResponse> PostFaxAsync (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> response = await PostFaxAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <param name="body">Fax</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> PostFaxAsyncWithHttpInfo (FaxSendRequest body = null)
        {
            
    
            var path_ = "/api/v1/conversations/fax";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostFax: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFax: " + response.ErrorMessage, response.ErrorMessage);

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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public ConversationQueryResponse PostQuery (ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = PostQueryWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param> 
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > PostQueryWithHttpInfo (ConversationHistoricalQueryRequestBody body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostQuery");
            
    
            var path_ = "/api/v1/conversations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
    
        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> PostQueryAsync (ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = await PostQueryAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> PostQueryAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostQuery");
            
    
            var path_ = "/api/v1/conversations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQuery: " + response.ErrorMessage, response.ErrorMessage);

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
        public ConversationQueryResponse PostQueryAnchor (string anchor, ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = PostQueryAnchorWithHttpInfo(anchor, body);
             return response.Data;
        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param> 
        /// <param name="body">Query parameters</param> 
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > PostQueryAnchorWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body)
        {
            
            // verify the required parameter 'anchor' is set
            if (anchor == null)
                throw new ApiException(400, "Missing required parameter 'anchor' when calling ConversationsApi->PostQueryAnchor");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ConversationsApi->PostQueryAnchor");
            
    
            var path_ = "/api/v1/conversations/query/{anchor}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (anchor != null) pathParams.Add("anchor", Configuration.ApiClient.ParameterToString(anchor)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQueryAnchor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueryAnchor: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConversationQueryResponse> PostQueryAnchorAsync (string anchor, ConversationHistoricalQueryRequestBody body)
        {
             ApiResponse<ConversationQueryResponse> response = await PostQueryAnchorAsyncWithHttpInfo(anchor, body);
             return response.Data;

        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <param name="anchor">A point in time within the interval for the query that bounds the query. In the form of YYYYMMDDHHmmssSSSZX where YYYY is the 4-digit year, MM is the 2-digit month, DD is the 2-digit day-of-month, HH is the 2-digit hour-of-day (00-23), mm is the 2-digit minute, ss is the 2-digit second, SSS is the 3-digit millisecond, Z is the UTC offset expressed as &#39;Z&#39;, &#39;+nnnn&#39;, &#39;-nnnn&#39;, &#39;+nn:nn&#39;, &#39;-nn:nn&#39;, and X is either &#39;A&#39; (for the anchor point being at the earliest point in the query) or &#39;D&#39; (for the anchor point being the latest point in the query</param>
        /// <param name="body">Query parameters</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> PostQueryAnchorAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body)
        {
            // verify the required parameter 'anchor' is set
            if (anchor == null) throw new ApiException(400, "Missing required parameter 'anchor' when calling PostQueryAnchor");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostQueryAnchor");
            
    
            var path_ = "/api/v1/conversations/query/{anchor}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostQueryAnchor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostQueryAnchor: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(response, typeof(ConversationQueryResponse)));
            
        }
        
        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>Conversation</returns>
        public Conversation GetConversationId (string conversationId)
        {
             ApiResponse<Conversation> response = GetConversationIdWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > GetConversationIdWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
    
        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> GetConversationIdAsync (string conversationId)
        {
             ApiResponse<Conversation> response = await GetConversationIdAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> GetConversationIdAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Conversation PutConversationId (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = PutConversationIdWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PutConversationIdWithHttpInfo (string conversationId, Conversation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Conversation> PutConversationIdAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = await PutConversationIdAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PutConversationIdAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>Conversation</returns>
        public Conversation PostConversationIdCalls (string conversationId, CallCommand body = null)
        {
             ApiResponse<Conversation> response = PostConversationIdCallsWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostConversationIdCallsWithHttpInfo (string conversationId, CallCommand body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdCalls");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/calls";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdCalls: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdCalls: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
    
        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> PostConversationIdCallsAsync (string conversationId, CallCommand body = null)
        {
             ApiResponse<Conversation> response = await PostConversationIdCallsAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Add a new call to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationIdCallsAsyncWithHttpInfo (string conversationId, CallCommand body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdCalls");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/calls";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdCalls: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdCalls: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Conversation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(response, typeof(Conversation)));
            
        }
        
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing GetConversationIdMessages (string conversationId)
        {
             ApiResponse<EmailMessageListing> response = GetConversationIdMessagesWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > GetConversationIdMessagesWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdMessages");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessageListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(response, typeof(EmailMessageListing)));
            
        }
    
        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> GetConversationIdMessagesAsync (string conversationId)
        {
             ApiResponse<EmailMessageListing> response = await GetConversationIdMessagesAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> GetConversationIdMessagesAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdMessages");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessages: " + response.ErrorMessage, response.ErrorMessage);

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
        public EmailMessage PostConversationIdMessages (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = PostConversationIdMessagesWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Reply</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PostConversationIdMessagesWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdMessages");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdMessages: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EmailMessage> PostConversationIdMessagesAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = await PostConversationIdMessagesAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PostConversationIdMessagesAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdMessages");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdMessages: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
        
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>EmailMessage</returns>
        public EmailMessage GetConversationIdMessagesDraft (string conversationId)
        {
             ApiResponse<EmailMessage> response = GetConversationIdMessagesDraftWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetConversationIdMessagesDraftWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdMessagesDraft");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(response, typeof(EmailMessage)));
            
        }
    
        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> GetConversationIdMessagesDraftAsync (string conversationId)
        {
             ApiResponse<EmailMessage> response = await GetConversationIdMessagesDraftAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationIdMessagesDraftAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdMessagesDraft");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);

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
        public EmailMessage PutConversationIdMessagesDraft (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = PutConversationIdMessagesDraftWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Draft</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > PutConversationIdMessagesDraftWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationIdMessagesDraft");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EmailMessage> PutConversationIdMessagesDraftAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> response = await PutConversationIdMessagesDraftAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> PutConversationIdMessagesDraftAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationIdMessagesDraft");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdMessagesDraft: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdMessagesDraft: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteConversationIdMessagesDraftAttachmentsAttachmentId (string conversationId, string attachmentId)
        {
             ApiResponse<string> response = DeleteConversationIdMessagesDraftAttachmentsAttachmentIdWithHttpInfo(conversationId, attachmentId);
             return response.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="attachmentId">attachment ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteConversationIdMessagesDraftAttachmentsAttachmentIdWithHttpInfo (string conversationId, string attachmentId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationIdMessagesDraftAttachmentsAttachmentId");
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->DeleteConversationIdMessagesDraftAttachmentsAttachmentId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdMessagesDraftAttachmentsAttachmentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdMessagesDraftAttachmentsAttachmentId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteConversationIdMessagesDraftAttachmentsAttachmentIdAsync (string conversationId, string attachmentId)
        {
             ApiResponse<string> response = await DeleteConversationIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo(conversationId, attachmentId);
             return response.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationIdMessagesDraftAttachmentsAttachmentIdAsyncWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationIdMessagesDraftAttachmentsAttachmentId");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling DeleteConversationIdMessagesDraftAttachmentsAttachmentId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdMessagesDraftAttachmentsAttachmentId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdMessagesDraftAttachmentsAttachmentId: " + response.ErrorMessage, response.ErrorMessage);

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
        public EmailMessage GetConversationIdMessagesId (string conversationId, string id)
        {
             ApiResponse<EmailMessage> response = GetConversationIdMessagesIdWithHttpInfo(conversationId, id);
             return response.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="id">message ID</param> 
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > GetConversationIdMessagesIdWithHttpInfo (string conversationId, string id)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdMessagesId");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ConversationsApi->GetConversationIdMessagesId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EmailMessage> GetConversationIdMessagesIdAsync (string conversationId, string id)
        {
             ApiResponse<EmailMessage> response = await GetConversationIdMessagesIdAsyncWithHttpInfo(conversationId, id);
             return response.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> GetConversationIdMessagesIdAsyncWithHttpInfo (string conversationId, string id)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdMessagesId");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetConversationIdMessagesId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/messages/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdMessagesId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Conversation PostConversationIdParticipants (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = PostConversationIdParticipantsWithHttpInfo(conversationId, body);
             return response.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="body">Conversation</param> 
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > PostConversationIdParticipantsWithHttpInfo (string conversationId, Conversation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipants");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipants: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipants: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Conversation> PostConversationIdParticipantsAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> response = await PostConversationIdParticipantsAsyncWithHttpInfo(conversationId, body);
             return response.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> PostConversationIdParticipantsAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdParticipants");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipants: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipants: " + response.ErrorMessage, response.ErrorMessage);

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
        public void PutConversationIdParticipantsParticipantId (string conversationId, string participantId, ParticipantRequest body = null)
        {
             PutConversationIdParticipantsParticipantIdWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutConversationIdParticipantsParticipantIdWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationIdParticipantsParticipantId");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PutConversationIdParticipantsParticipantId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PutConversationIdParticipantsParticipantIdAsync (string conversationId, string participantId, ParticipantRequest body = null)
        {
             await PutConversationIdParticipantsParticipantIdAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutConversationIdParticipantsParticipantIdAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationIdParticipantsParticipantId");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PutConversationIdParticipantsParticipantId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public void PutConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             PutConversationIdParticipantsParticipantIdAttributesWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutConversationIdParticipantsParticipantIdAttributesWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationIdParticipantsParticipantIdAttributes");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PutConversationIdParticipantsParticipantIdAttributes");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/attributes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PutConversationIdParticipantsParticipantIdAttributesAsync (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             await PutConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutConversationIdParticipantsParticipantIdAttributesAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationIdParticipantsParticipantIdAttributes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PutConversationIdParticipantsParticipantIdAttributes");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/attributes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdAttributes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdAttributes: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ConsultTransferResponse PutConversationIdParticipantsParticipantIdConsult (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> response = PutConversationIdParticipantsParticipantIdConsultWithHttpInfo(conversationId, participantId, body);
             return response.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">new speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PutConversationIdParticipantsParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PutConversationIdParticipantsParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PutConversationIdParticipantsParticipantIdConsult");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PutConversationIdParticipantsParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> response = await PutConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo(conversationId, participantId, body);
             return response.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PutConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PutConversationIdParticipantsParticipantIdConsult");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdParticipantsParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);

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
        public ConsultTransferResponse PostConversationIdParticipantsParticipantIdConsult (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> response = PostConversationIdParticipantsParticipantIdConsultWithHttpInfo(conversationId, participantId, body);
             return response.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <param name="body">Destination address &amp; initial speak to</param> 
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > PostConversationIdParticipantsParticipantIdConsultWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdConsult");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (participantId != null) pathParams.Add("participantId", Configuration.ApiClient.ParameterToString(participantId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ConsultTransferResponse> PostConversationIdParticipantsParticipantIdConsultAsync (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> response = await PostConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo(conversationId, participantId, body);
             return response.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> PostConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostConversationIdParticipantsParticipantIdConsult");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteConversationIdParticipantsParticipantIdConsult (string conversationId, string participantId)
        {
             ApiResponse<string> response = DeleteConversationIdParticipantsParticipantIdConsultWithHttpInfo(conversationId, participantId);
             return response.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">The object of the transfer</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteConversationIdParticipantsParticipantIdConsultWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdConsult");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->DeleteConversationIdParticipantsParticipantIdConsult");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdParticipantsParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdParticipantsParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteConversationIdParticipantsParticipantIdConsultAsync (string conversationId, string participantId)
        {
             ApiResponse<string> response = await DeleteConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo(conversationId, participantId);
             return response.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteConversationIdParticipantsParticipantIdConsultAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationIdParticipantsParticipantIdConsult");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling DeleteConversationIdParticipantsParticipantIdConsult");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdParticipantsParticipantIdConsult: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdParticipantsParticipantIdConsult: " + response.ErrorMessage, response.ErrorMessage);

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
        public void PostConversationIdParticipantsParticipantIdMonitor (string conversationId, string participantId)
        {
             PostConversationIdParticipantsParticipantIdMonitorWithHttpInfo(conversationId, participantId);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <param name="participantId">participant ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostConversationIdParticipantsParticipantIdMonitorWithHttpInfo (string conversationId, string participantId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdMonitor");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdMonitor");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/monitor";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdMonitor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdMonitor: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdMonitorAsync (string conversationId, string participantId)
        {
             await PostConversationIdParticipantsParticipantIdMonitorAsyncWithHttpInfo(conversationId, participantId);

        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdMonitorAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdParticipantsParticipantIdMonitor");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostConversationIdParticipantsParticipantIdMonitor");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/monitor";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdMonitor: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdMonitor: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);
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
        public ApiResponse<Object> PostConversationIdParticipantsParticipantIdReplaceWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->PostConversationIdParticipantsParticipantIdReplace");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/replace";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PostConversationIdParticipantsParticipantIdReplaceAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             await PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);

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
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostConversationIdParticipantsParticipantIdReplaceAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdParticipantsParticipantIdReplace");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling PostConversationIdParticipantsParticipantIdReplace");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/replace";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdParticipantsParticipantIdReplace: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public WrapupCode GetConversationIdParticipantsParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> response = GetConversationIdParticipantsParticipantIdWrapupWithHttpInfo(conversationId, participantId, provisional);
             return response.Data;
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
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
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapup";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> response = await GetConversationIdParticipantsParticipantIdWrapupAsyncWithHttpInfo(conversationId, participantId, provisional);
             return response.Data;

        }

        /// <summary>
        /// Get the wrap-up for this conversation participant. 
        /// </summary>
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
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapup";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapup: " + response.ErrorMessage, response.ErrorMessage);

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
        public WrapupCode GetConversationIdParticipantsParticipantIdWrapupcodes (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> response = GetConversationIdParticipantsParticipantIdWrapupcodesWithHttpInfo(conversationId, participantId);
             return response.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
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
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationIdParticipantsParticipantIdWrapupcodesAsync (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> response = await GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo(conversationId, participantId);
             return response.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdParticipantsParticipantIdWrapupcodesAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdParticipantsParticipantIdWrapupcodes");
            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling GetConversationIdParticipantsParticipantIdWrapupcodes");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdParticipantsParticipantIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>Tag</returns>
        public Tag GetConversationIdTags (string conversationId)
        {
             ApiResponse<Tag> response = GetConversationIdTagsWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of Tag</returns>
        public ApiResponse< Tag > GetConversationIdTagsWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdTags");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/tags";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdTags: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdTags: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(response, typeof(Tag)));
            
        }
    
        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        public async System.Threading.Tasks.Task<Tag> GetConversationIdTagsAsync (string conversationId)
        {
             ApiResponse<Tag> response = await GetConversationIdTagsAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tag>> GetConversationIdTagsAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdTags");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/tags";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdTags: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdTags: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tag>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(response, typeof(Tag)));
            
        }
        
        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>WrapupCode</returns>
        public WrapupCode GetConversationIdWrapupcodes (string conversationId)
        {
             ApiResponse<WrapupCode> response = GetConversationIdWrapupcodesWithHttpInfo(conversationId);
             return response.Data;
        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param> 
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > GetConversationIdWrapupcodesWithHttpInfo (string conversationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->GetConversationIdWrapupcodes");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/wrapupcodes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
    
        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> GetConversationIdWrapupcodesAsync (string conversationId)
        {
             ApiResponse<WrapupCode> response = await GetConversationIdWrapupcodesAsyncWithHttpInfo(conversationId);
             return response.Data;

        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> GetConversationIdWrapupcodesAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdWrapupcodes");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/wrapupcodes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdWrapupcodes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdWrapupcodes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<WrapupCode>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(response, typeof(WrapupCode)));
            
        }
        
    }
    
}
