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
    public interface IConversationsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        Conversation ConversationsConversationidGet (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> ConversationsConversationidGetWithHttpInfo (string conversationId);
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteWithHttpInfo (string conversationId, string attachmentId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesDraftGet (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesDraftGetWithHttpInfo (string conversationId);
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesDraftPut (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesDraftPutWithHttpInfo (string conversationId, EmailMessage body = null);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessageListing</returns>
        EmailMessageListing ConversationsConversationidMessagesGet (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        ApiResponse<EmailMessageListing> ConversationsConversationidMessagesGetWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesIdGetWithHttpInfo (string conversationId, string id);
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>EmailMessage</returns>
        EmailMessage ConversationsConversationidMessagesPost (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        ApiResponse<EmailMessage> ConversationsConversationidMessagesPostWithHttpInfo (string conversationId, EmailMessage body = null);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidAttributesPut (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidAttributesPutWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ConversationsConversationidParticipantsParticipantidConsultDeleteWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPost (string conversationId, string participantId, ConsultTransfer body = null);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPostWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>ConsultTransferResponse</returns>
        ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPut (string conversationId, string participantId, ConsultTransferUpdate body = null);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        ApiResponse<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPutWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidMonitorPostWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidPut (string conversationId, string participantId, ParticipantRequest body = null);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidPutWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns></returns>
        void ConversationsConversationidParticipantsParticipantidReplacePost (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidParticipantsParticipantidReplacePostWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
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
        WrapupCode ConversationsConversationidParticipantsParticipantidWrapupGet (string conversationId, string participantId, bool? provisional = null);

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
        ApiResponse<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupGetWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
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
        WrapupCode ConversationsConversationidParticipantsParticipantidWrapupcodesGet (string conversationId, string participantId);

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
        ApiResponse<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupcodesGetWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Conversation</returns>
        Conversation ConversationsConversationidParticipantsPost (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> ConversationsConversationidParticipantsPostWithHttpInfo (string conversationId, Conversation body = null);
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Conversation</returns>
        Conversation ConversationsConversationidPut (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>ApiResponse of Conversation</returns>
        ApiResponse<Conversation> ConversationsConversationidPutWithHttpInfo (string conversationId, Conversation body = null);
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Tag</returns>
        Tag ConversationsConversationidTagsGet (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Tag</returns>
        ApiResponse<Tag> ConversationsConversationidTagsGetWithHttpInfo (string conversationId);
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>WrapupCode</returns>
        WrapupCode ConversationsConversationidWrapupcodesGet (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        ApiResponse<WrapupCode> ConversationsConversationidWrapupcodesGetWithHttpInfo (string conversationId);
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>FaxSendResponse</returns>
        FaxSendResponse ConversationsFaxPost (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        ApiResponse<FaxSendResponse> ConversationsFaxPostWithHttpInfo (FaxSendRequest body = null);
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ConversationEntityListing</returns>
        ConversationEntityListing ConversationsGet (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        ApiResponse<ConversationEntityListing> ConversationsGetWithHttpInfo (string communicationType = null);
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MaxParticipants</returns>
        MaxParticipants ConversationsMaximumconferencepartiesGet ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MaxParticipants</returns>
        ApiResponse<MaxParticipants> ConversationsMaximumconferencepartiesGetWithHttpInfo ();
        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ConversationResponse</returns>
        ConversationResponse ConversationsPost (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ConversationResponse</returns>
        ApiResponse<ConversationResponse> ConversationsPostWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse ConversationsQueryAnchorPost (string anchor, ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> ConversationsQueryAnchorPostWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null);
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ConversationQueryResponse</returns>
        ConversationQueryResponse ConversationsQueryPost (ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        ApiResponse<ConversationQueryResponse> ConversationsQueryPostWithHttpInfo (ConversationHistoricalQueryRequestBody body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> ConversationsConversationidGetAsync (string conversationId);

        /// <summary>
        /// Get conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidGetAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Delete attachment from draft
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsyncWithHttpInfo (string conversationId, string attachmentId);
        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftGetAsync (string conversationId);

        /// <summary>
        /// Get conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftGetAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftPutAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Update conversation draft reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftPutAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        System.Threading.Tasks.Task<EmailMessageListing> ConversationsConversationidMessagesGetAsync (string conversationId);

        /// <summary>
        /// Get conversation messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> ConversationsConversationidMessagesGetAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get conversation message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesIdGetAsyncWithHttpInfo (string conversationId, string id);
        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>Task of EmailMessage</returns>
        System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesPostAsync (string conversationId, EmailMessage body = null);

        /// <summary>
        /// Send an email reply
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesPostAsyncWithHttpInfo (string conversationId, EmailMessage body = null);
        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidAttributesPutAsync (string conversationId, string participantId, ParticipantAttributes body = null);

        /// <summary>
        /// Update the attributes on a conversation participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidAttributesPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null);
        /// <summary>
        /// Cancel the transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidParticipantsParticipantidConsultDeleteAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPostAsync (string conversationId, string participantId, ConsultTransfer body = null);

        /// <summary>
        /// Initiate and update consult transfer
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPostAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null);
        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPutAsync (string conversationId, string participantId, ConsultTransferUpdate body = null);

        /// <summary>
        /// Change who can speak
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPutAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null);
        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidMonitorPostAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidPutAsync (string conversationId, string participantId, ParticipantRequest body = null);

        /// <summary>
        /// Update a participant.
        /// </summary>
        /// <remarks>
        /// Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null);
        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidReplacePostAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);

        /// <summary>
        /// Replace this participant with the specified user and/or address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidReplacePostAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null);
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
        System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupGetAsync (string conversationId, string participantId, bool? provisional = null);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupGetAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null);
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
        System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsync (string conversationId, string participantId);

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
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsyncWithHttpInfo (string conversationId, string participantId);
        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> ConversationsConversationidParticipantsPostAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Add participants to a conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidParticipantsPostAsyncWithHttpInfo (string conversationId, Conversation body = null);
        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of Conversation</returns>
        System.Threading.Tasks.Task<Conversation> ConversationsConversationidPutAsync (string conversationId, Conversation body = null);

        /// <summary>
        /// Update conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidPutAsyncWithHttpInfo (string conversationId, Conversation body = null);
        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        System.Threading.Tasks.Task<Tag> ConversationsConversationidTagsGetAsync (string conversationId);

        /// <summary>
        /// Get possible tags for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tag>> ConversationsConversationidTagsGetAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidWrapupcodesGetAsync (string conversationId);

        /// <summary>
        /// Get possible wrap-up codes for Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidWrapupcodesGetAsyncWithHttpInfo (string conversationId);
        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>Task of FaxSendResponse</returns>
        System.Threading.Tasks.Task<FaxSendResponse> ConversationsFaxPostAsync (FaxSendRequest body = null);

        /// <summary>
        /// Create Fax Conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> ConversationsFaxPostAsyncWithHttpInfo (FaxSendRequest body = null);
        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ConversationEntityListing</returns>
        System.Threading.Tasks.Task<ConversationEntityListing> ConversationsGetAsync (string communicationType = null);

        /// <summary>
        /// Get conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> ConversationsGetAsyncWithHttpInfo (string communicationType = null);
        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MaxParticipants</returns>
        System.Threading.Tasks.Task<MaxParticipants> ConversationsMaximumconferencepartiesGetAsync ();

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> ConversationsMaximumconferencepartiesGetAsyncWithHttpInfo ();
        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ConversationResponse</returns>
        System.Threading.Tasks.Task<ConversationResponse> ConversationsPostAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);

        /// <summary>
        /// Create conversation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> ConversationsPostAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null);
        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryAnchorPostAsync (string anchor, ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations with a date/time anchor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryAnchorPostAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null);
        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryPostAsync (ConversationHistoricalQueryRequestBody body = null);

        /// <summary>
        /// Query historical conversations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryPostAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body = null);
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
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Conversation</returns>
        public Conversation ConversationsConversationidGet (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = ConversationsConversationidGetWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > ConversationsConversationidGetWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidGet");

            var localVarPath = "/api/v1/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Conversation> ConversationsConversationidGetAsync (string conversationId)
        {
             ApiResponse<Conversation> localVarResponse = await ConversationsConversationidGetAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidGet");

            var localVarPath = "/api/v1/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>string</returns>
        public string ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete (string conversationId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteWithHttpInfo(conversationId, attachmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsync (string conversationId, string attachmentId)
        {
             ApiResponse<string> localVarResponse = await ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsyncWithHttpInfo(conversationId, attachmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete attachment from draft 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="attachmentId">attachment ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteAsyncWithHttpInfo (string conversationId, string attachmentId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling ConversationsApi->ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesDraftGet (string conversationId)
        {
             ApiResponse<EmailMessage> localVarResponse = ConversationsConversationidMessagesDraftGetWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesDraftGetWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesDraftGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftGetAsync (string conversationId)
        {
             ApiResponse<EmailMessage> localVarResponse = await ConversationsConversationidMessagesDraftGetAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesDraftGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesDraftPut (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = ConversationsConversationidMessagesDraftPutWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesDraftPutWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesDraftPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesDraftPutAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = await ConversationsConversationidMessagesDraftPutAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation draft reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Draft (optional)</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesDraftPutAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesDraftPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/draft";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesDraftPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>EmailMessageListing</returns>
        public EmailMessageListing ConversationsConversationidMessagesGet (string conversationId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = ConversationsConversationidMessagesGetWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of EmailMessageListing</returns>
        public ApiResponse< EmailMessageListing > ConversationsConversationidMessagesGetWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of EmailMessageListing</returns>
        public async System.Threading.Tasks.Task<EmailMessageListing> ConversationsConversationidMessagesGetAsync (string conversationId)
        {
             ApiResponse<EmailMessageListing> localVarResponse = await ConversationsConversationidMessagesGetAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation messages 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (EmailMessageListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessageListing>> ConversationsConversationidMessagesGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessageListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessageListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessageListing)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesIdGet (string conversationId, string id)
        {
             ApiResponse<EmailMessage> localVarResponse = ConversationsConversationidMessagesIdGetWithHttpInfo(conversationId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesIdGetWithHttpInfo (string conversationId, string id)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesIdGet");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ConversationsApi->ConversationsConversationidMessagesIdGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesIdGetAsync (string conversationId, string id)
        {
             ApiResponse<EmailMessage> localVarResponse = await ConversationsConversationidMessagesIdGetAsyncWithHttpInfo(conversationId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversation message 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="id">message ID</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesIdGetAsyncWithHttpInfo (string conversationId, string id)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesIdGet");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ConversationsApi->ConversationsConversationidMessagesIdGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>EmailMessage</returns>
        public EmailMessage ConversationsConversationidMessagesPost (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = ConversationsConversationidMessagesPostWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>ApiResponse of EmailMessage</returns>
        public ApiResponse< EmailMessage > ConversationsConversationidMessagesPostWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>Task of EmailMessage</returns>
        public async System.Threading.Tasks.Task<EmailMessage> ConversationsConversationidMessagesPostAsync (string conversationId, EmailMessage body = null)
        {
             ApiResponse<EmailMessage> localVarResponse = await ConversationsConversationidMessagesPostAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send an email reply 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Reply (optional)</param>
        /// <returns>Task of ApiResponse (EmailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailMessage>> ConversationsConversationidMessagesPostAsyncWithHttpInfo (string conversationId, EmailMessage body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidMessagesPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/messages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidMessagesPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailMessage)));
            
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidAttributesPut (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             ConversationsConversationidParticipantsParticipantidAttributesPutWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidAttributesPutWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidAttributesPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidAttributesPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidAttributesPutAsync (string conversationId, string participantId, ParticipantAttributes body = null)
        {
             await ConversationsConversationidParticipantsParticipantidAttributesPutAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update the attributes on a conversation participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidAttributesPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantAttributes body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidAttributesPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidAttributesPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/attributes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidAttributesPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>string</returns>
        public string ConversationsConversationidParticipantsParticipantidConsultDelete (string conversationId, string participantId)
        {
             ApiResponse<string> localVarResponse = ConversationsConversationidParticipantsParticipantidConsultDeleteWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ConversationsConversationidParticipantsParticipantidConsultDeleteWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultDelete");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultDelete");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ConversationsConversationidParticipantsParticipantidConsultDeleteAsync (string conversationId, string participantId)
        {
             ApiResponse<string> localVarResponse = await ConversationsConversationidParticipantsParticipantidConsultDeleteAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancel the transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ConversationsConversationidParticipantsParticipantidConsultDeleteAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultDelete");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultDelete");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPost (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = ConversationsConversationidParticipantsParticipantidConsultPostWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > ConversationsConversationidParticipantsParticipantidConsultPostWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPost");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPostAsync (string conversationId, string participantId, ConsultTransfer body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await ConversationsConversationidParticipantsParticipantidConsultPostAsyncWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Initiate and update consult transfer 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">Destination address &amp; initial speak to (optional)</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPostAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransfer body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPost");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>ConsultTransferResponse</returns>
        public ConsultTransferResponse ConversationsConversationidParticipantsParticipantidConsultPut (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = ConversationsConversationidParticipantsParticipantidConsultPutWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>ApiResponse of ConsultTransferResponse</returns>
        public ApiResponse< ConsultTransferResponse > ConversationsConversationidParticipantsParticipantidConsultPutWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>Task of ConsultTransferResponse</returns>
        public async System.Threading.Tasks.Task<ConsultTransferResponse> ConversationsConversationidParticipantsParticipantidConsultPutAsync (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
             ApiResponse<ConsultTransferResponse> localVarResponse = await ConversationsConversationidParticipantsParticipantidConsultPutAsyncWithHttpInfo(conversationId, participantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change who can speak 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">The object of the transfer</param>
        /// <param name="body">new speak to (optional)</param>
        /// <returns>Task of ApiResponse (ConsultTransferResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsultTransferResponse>> ConversationsConversationidParticipantsParticipantidConsultPutAsyncWithHttpInfo (string conversationId, string participantId, ConsultTransferUpdate body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidConsultPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/consult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidConsultPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConsultTransferResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsultTransferResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConsultTransferResponse)));
            
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidMonitorPostWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidMonitorPost");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidMonitorPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/monitor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Listen in on the conversation from the point of view of a given participant. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidMonitorPostAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidMonitorPost");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidMonitorPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/monitor";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidMonitorPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidPut (string conversationId, string participantId, ParticipantRequest body = null)
        {
             ConversationsConversationidParticipantsParticipantidPutWithHttpInfo(conversationId, participantId, body);
        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidPutWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidPutAsync (string conversationId, string participantId, ParticipantRequest body = null)
        {
             await ConversationsConversationidParticipantsParticipantidPutAsyncWithHttpInfo(conversationId, participantId, body);

        }

        /// <summary>
        /// Update a participant. Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidPutAsyncWithHttpInfo (string conversationId, string participantId, ParticipantRequest body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidPut");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns></returns>
        public void ConversationsConversationidParticipantsParticipantidReplacePost (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             ConversationsConversationidParticipantsParticipantidReplacePostWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);
        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidParticipantsParticipantidReplacePostWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidReplacePost");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidReplacePost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (username != null) localVarQueryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (queueId != null) localVarQueryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (voicemail != null) localVarQueryParams.Add("voicemail", Configuration.ApiClient.ParameterToString(voicemail)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidParticipantsParticipantidReplacePostAsync (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
             await ConversationsConversationidParticipantsParticipantidReplacePostAsyncWithHttpInfo(conversationId, participantId, userId, address, username, queueId, voicemail);

        }

        /// <summary>
        /// Replace this participant with the specified user and/or address 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="userId">The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional)</param>
        /// <param name="address">The address that will be used to contact the new participant (optional)</param>
        /// <param name="username">The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional)</param>
        /// <param name="queueId">The id of the queue that will replace this participant. (optional)</param>
        /// <param name="voicemail">Indicates this participant will be replaced by the voicemail inbox of the participant. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidParticipantsParticipantidReplacePostAsyncWithHttpInfo (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidReplacePost");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidReplacePost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (userId != null) localVarQueryParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // query parameter
            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (username != null) localVarQueryParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // query parameter
            if (queueId != null) localVarQueryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (voicemail != null) localVarQueryParams.Add("voicemail", Configuration.ApiClient.ParameterToString(voicemail)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidReplacePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get the wrap-up for this conversation participant.  
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <param name="provisional">Indicates if the wrap-up code is provisional. (optional, default to false)</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode ConversationsConversationidParticipantsParticipantidWrapupGet (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = ConversationsConversationidParticipantsParticipantidWrapupGetWithHttpInfo(conversationId, participantId, provisional);
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
        public ApiResponse< WrapupCode > ConversationsConversationidParticipantsParticipantidWrapupGetWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupGet");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupGetAsync (string conversationId, string participantId, bool? provisional = null)
        {
             ApiResponse<WrapupCode> localVarResponse = await ConversationsConversationidParticipantsParticipantidWrapupGetAsyncWithHttpInfo(conversationId, participantId, provisional);
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
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupGetAsyncWithHttpInfo (string conversationId, string participantId, bool? provisional = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupGet");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapup";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public WrapupCode ConversationsConversationidParticipantsParticipantidWrapupcodesGet (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = ConversationsConversationidParticipantsParticipantidWrapupcodesGetWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > ConversationsConversationidParticipantsParticipantidWrapupcodesGetWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupcodesGet");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupcodesGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsync (string conversationId, string participantId)
        {
             ApiResponse<WrapupCode> localVarResponse = await ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsyncWithHttpInfo(conversationId, participantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of wrapup codes for this conversation participant 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="participantId">participant ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidParticipantsParticipantidWrapupcodesGetAsyncWithHttpInfo (string conversationId, string participantId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupcodesGet");
            // verify the required parameter 'participantId' is set
            if (participantId == null)
                throw new ApiException(400, "Missing required parameter 'participantId' when calling ConversationsApi->ConversationsConversationidParticipantsParticipantidWrapupcodesGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Conversation</returns>
        public Conversation ConversationsConversationidParticipantsPost (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = ConversationsConversationidParticipantsPostWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > ConversationsConversationidParticipantsPostWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> ConversationsConversationidParticipantsPostAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = await ConversationsConversationidParticipantsPostAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add participants to a conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidParticipantsPostAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidParticipantsPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/participants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidParticipantsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Conversation</returns>
        public Conversation ConversationsConversationidPut (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = ConversationsConversationidPutWithHttpInfo(conversationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>ApiResponse of Conversation</returns>
        public ApiResponse< Conversation > ConversationsConversationidPutWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of Conversation</returns>
        public async System.Threading.Tasks.Task<Conversation> ConversationsConversationidPutAsync (string conversationId, Conversation body = null)
        {
             ApiResponse<Conversation> localVarResponse = await ConversationsConversationidPutAsyncWithHttpInfo(conversationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <param name="body">Conversation (optional)</param>
        /// <returns>Task of ApiResponse (Conversation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Conversation>> ConversationsConversationidPutAsyncWithHttpInfo (string conversationId, Conversation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Conversation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Conversation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Conversation)));
            
        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Tag</returns>
        public Tag ConversationsConversationidTagsGet (string conversationId)
        {
             ApiResponse<Tag> localVarResponse = ConversationsConversationidTagsGetWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of Tag</returns>
        public ApiResponse< Tag > ConversationsConversationidTagsGetWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidTagsGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidTagsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidTagsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Tag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Tag)));
            
        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of Tag</returns>
        public async System.Threading.Tasks.Task<Tag> ConversationsConversationidTagsGetAsync (string conversationId)
        {
             ApiResponse<Tag> localVarResponse = await ConversationsConversationidTagsGetAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get possible tags for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (Tag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tag>> ConversationsConversationidTagsGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidTagsGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidTagsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidTagsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Tag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Tag)));
            
        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>WrapupCode</returns>
        public WrapupCode ConversationsConversationidWrapupcodesGet (string conversationId)
        {
             ApiResponse<WrapupCode> localVarResponse = ConversationsConversationidWrapupcodesGetWithHttpInfo(conversationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>ApiResponse of WrapupCode</returns>
        public ApiResponse< WrapupCode > ConversationsConversationidWrapupcodesGetWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidWrapupcodesGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of WrapupCode</returns>
        public async System.Threading.Tasks.Task<WrapupCode> ConversationsConversationidWrapupcodesGetAsync (string conversationId)
        {
             ApiResponse<WrapupCode> localVarResponse = await ConversationsConversationidWrapupcodesGetAsyncWithHttpInfo(conversationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get possible wrap-up codes for Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">conversation ID</param>
        /// <returns>Task of ApiResponse (WrapupCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WrapupCode>> ConversationsConversationidWrapupcodesGetAsyncWithHttpInfo (string conversationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling ConversationsApi->ConversationsConversationidWrapupcodesGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/wrapupcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidWrapupcodesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WrapupCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WrapupCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WrapupCode)));
            
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>FaxSendResponse</returns>
        public FaxSendResponse ConversationsFaxPost (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> localVarResponse = ConversationsFaxPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>ApiResponse of FaxSendResponse</returns>
        public ApiResponse< FaxSendResponse > ConversationsFaxPostWithHttpInfo (FaxSendRequest body = null)
        {

            var localVarPath = "/api/v1/conversations/fax";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsFaxPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsFaxPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>Task of FaxSendResponse</returns>
        public async System.Threading.Tasks.Task<FaxSendResponse> ConversationsFaxPostAsync (FaxSendRequest body = null)
        {
             ApiResponse<FaxSendResponse> localVarResponse = await ConversationsFaxPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Fax Conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Fax (optional)</param>
        /// <returns>Task of ApiResponse (FaxSendResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FaxSendResponse>> ConversationsFaxPostAsyncWithHttpInfo (FaxSendRequest body = null)
        {

            var localVarPath = "/api/v1/conversations/fax";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsFaxPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsFaxPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FaxSendResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FaxSendResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FaxSendResponse)));
            
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ConversationEntityListing</returns>
        public ConversationEntityListing ConversationsGet (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> localVarResponse = ConversationsGetWithHttpInfo(communicationType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>ApiResponse of ConversationEntityListing</returns>
        public ApiResponse< ConversationEntityListing > ConversationsGetWithHttpInfo (string communicationType = null)
        {

            var localVarPath = "/api/v1/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<ConversationEntityListing> ConversationsGetAsync (string communicationType = null)
        {
             ApiResponse<ConversationEntityListing> localVarResponse = await ConversationsGetAsyncWithHttpInfo(communicationType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="communicationType">Call or Chat communication filtering (optional)</param>
        /// <returns>Task of ApiResponse (ConversationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationEntityListing>> ConversationsGetAsyncWithHttpInfo (string communicationType = null)
        {

            var localVarPath = "/api/v1/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationEntityListing)));
            
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>MaxParticipants</returns>
        public MaxParticipants ConversationsMaximumconferencepartiesGet ()
        {
             ApiResponse<MaxParticipants> localVarResponse = ConversationsMaximumconferencepartiesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of MaxParticipants</returns>
        public ApiResponse< MaxParticipants > ConversationsMaximumconferencepartiesGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/conversations/maximumconferenceparties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of MaxParticipants</returns>
        public async System.Threading.Tasks.Task<MaxParticipants> ConversationsMaximumconferencepartiesGetAsync ()
        {
             ApiResponse<MaxParticipants> localVarResponse = await ConversationsMaximumconferencepartiesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the maximum number of participants that this user can have on a conference 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (MaxParticipants)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MaxParticipants>> ConversationsMaximumconferencepartiesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/conversations/maximumconferenceparties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsMaximumconferencepartiesGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MaxParticipants>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MaxParticipants) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MaxParticipants)));
            
        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ConversationResponse</returns>
        public ConversationResponse ConversationsPost (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> localVarResponse = ConversationsPostWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ConversationResponse</returns>
        public ApiResponse< ConversationResponse > ConversationsPostWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {

            var localVarPath = "/api/v1/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (call != null) localVarQueryParams.Add("call", Configuration.ApiClient.ParameterToString(call)); // query parameter
            if (callFrom != null) localVarQueryParams.Add("callFrom", Configuration.ApiClient.ParameterToString(callFrom)); // query parameter
            if (callQueueId != null) localVarQueryParams.Add("callQueueId", Configuration.ApiClient.ParameterToString(callQueueId)); // query parameter
            if (callUserId != null) localVarQueryParams.Add("callUserId", Configuration.ApiClient.ParameterToString(callUserId)); // query parameter
            if (priority != null) localVarQueryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            if (languageId != null) localVarQueryParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // query parameter
            if (skillIds != null) localVarQueryParams.Add("skillIds", Configuration.ApiClient.ParameterToString(skillIds)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationResponse)));
            
        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ConversationResponse</returns>
        public async System.Threading.Tasks.Task<ConversationResponse> ConversationsPostAsync (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {
             ApiResponse<ConversationResponse> localVarResponse = await ConversationsPostAsyncWithHttpInfo(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create conversation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="call">Phone number to call (optional)</param>
        /// <param name="callFrom">Queue id to place the call from (optional)</param>
        /// <param name="callQueueId">Queue id to call (optional)</param>
        /// <param name="callUserId">User id to call (this will call the default number) (optional)</param>
        /// <param name="priority">Priority level to use for routing when calling a queue (optional)</param>
        /// <param name="languageId">Language id to use for routing when calling a queue (optional)</param>
        /// <param name="skillIds">Skill ids to use for routing when calling a queue (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationResponse>> ConversationsPostAsyncWithHttpInfo (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)
        {

            var localVarPath = "/api/v1/conversations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (call != null) localVarQueryParams.Add("call", Configuration.ApiClient.ParameterToString(call)); // query parameter
            if (callFrom != null) localVarQueryParams.Add("callFrom", Configuration.ApiClient.ParameterToString(callFrom)); // query parameter
            if (callQueueId != null) localVarQueryParams.Add("callQueueId", Configuration.ApiClient.ParameterToString(callQueueId)); // query parameter
            if (callUserId != null) localVarQueryParams.Add("callUserId", Configuration.ApiClient.ParameterToString(callUserId)); // query parameter
            if (priority != null) localVarQueryParams.Add("priority", Configuration.ApiClient.ParameterToString(priority)); // query parameter
            if (languageId != null) localVarQueryParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // query parameter
            if (skillIds != null) localVarQueryParams.Add("skillIds", Configuration.ApiClient.ParameterToString(skillIds)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationResponse)));
            
        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ConversationQueryResponse</returns>
        public ConversationQueryResponse ConversationsQueryAnchorPost (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> localVarResponse = ConversationsQueryAnchorPostWithHttpInfo(anchor, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > ConversationsQueryAnchorPostWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
            // verify the required parameter 'anchor' is set
            if (anchor == null)
                throw new ApiException(400, "Missing required parameter 'anchor' when calling ConversationsApi->ConversationsQueryAnchorPost");

            var localVarPath = "/api/v1/conversations/query/{anchor}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (anchor != null) localVarPathParams.Add("anchor", Configuration.ApiClient.ParameterToString(anchor)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryAnchorPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryAnchorPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationQueryResponse)));
            
        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryAnchorPostAsync (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> localVarResponse = await ConversationsQueryAnchorPostAsyncWithHttpInfo(anchor, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query historical conversations with a date/time anchor 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="anchor">Anchor</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryAnchorPostAsyncWithHttpInfo (string anchor, ConversationHistoricalQueryRequestBody body = null)
        {
            // verify the required parameter 'anchor' is set
            if (anchor == null)
                throw new ApiException(400, "Missing required parameter 'anchor' when calling ConversationsApi->ConversationsQueryAnchorPost");

            var localVarPath = "/api/v1/conversations/query/{anchor}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (anchor != null) localVarPathParams.Add("anchor", Configuration.ApiClient.ParameterToString(anchor)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryAnchorPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryAnchorPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationQueryResponse)));
            
        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ConversationQueryResponse</returns>
        public ConversationQueryResponse ConversationsQueryPost (ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> localVarResponse = ConversationsQueryPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ConversationQueryResponse</returns>
        public ApiResponse< ConversationQueryResponse > ConversationsQueryPostWithHttpInfo (ConversationHistoricalQueryRequestBody body = null)
        {

            var localVarPath = "/api/v1/conversations/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationQueryResponse)));
            
        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ConversationQueryResponse</returns>
        public async System.Threading.Tasks.Task<ConversationQueryResponse> ConversationsQueryPostAsync (ConversationHistoricalQueryRequestBody body = null)
        {
             ApiResponse<ConversationQueryResponse> localVarResponse = await ConversationsQueryPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query historical conversations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationQueryResponse>> ConversationsQueryPostAsyncWithHttpInfo (ConversationHistoricalQueryRequestBody body = null)
        {

            var localVarPath = "/api/v1/conversations/query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ConversationQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationQueryResponse)));
            
        }

    }
}
