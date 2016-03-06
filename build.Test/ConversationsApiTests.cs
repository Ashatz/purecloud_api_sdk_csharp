using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class ConversationsApiTests
    {
        private ConversationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ConversationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConversationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ConversationsApi> (instance, "instance is a ConversationsApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string communicationType = null; // TODO: replace null with proper value
            
            var response = instance.Get(communicationType);
            Assert.IsInstanceOf<ConversationEntityListing> (response, "response is ConversationEntityListing"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            string call = null; // TODO: replace null with proper value
            string callFrom = null; // TODO: replace null with proper value
            string callQueueId = null; // TODO: replace null with proper value
            string callUserId = null; // TODO: replace null with proper value
            int? priority = null; // TODO: replace null with proper value
            string languageId = null; // TODO: replace null with proper value
            List<string> skillIds = null; // TODO: replace null with proper value
            string body = null; // TODO: replace null with proper value
            
            var response = instance.Post(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
            Assert.IsInstanceOf<ConversationResponse> (response, "response is ConversationResponse"); 
        }
        
        /// <summary>
        /// Test PostFax
        /// </summary>
        [Test]
        public void PostFaxTest()
        {
            // TODO: add unit test for the method 'PostFax'
            FaxSendRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostFax(body);
            Assert.IsInstanceOf<FaxSendResponse> (response, "response is FaxSendResponse"); 
        }
        
        /// <summary>
        /// Test GetMaximumconferenceparties
        /// </summary>
        [Test]
        public void GetMaximumconferencepartiesTest()
        {
            // TODO: add unit test for the method 'GetMaximumconferenceparties'
            
            var response = instance.GetMaximumconferenceparties();
            Assert.IsInstanceOf<MaxParticipants> (response, "response is MaxParticipants"); 
        }
        
        /// <summary>
        /// Test PostQuery
        /// </summary>
        [Test]
        public void PostQueryTest()
        {
            // TODO: add unit test for the method 'PostQuery'
            ConversationHistoricalQueryRequestBody body = null; // TODO: replace null with proper value
            
            var response = instance.PostQuery(body);
            Assert.IsInstanceOf<ConversationQueryResponse> (response, "response is ConversationQueryResponse"); 
        }
        
        /// <summary>
        /// Test PostQueryAnchor
        /// </summary>
        [Test]
        public void PostQueryAnchorTest()
        {
            // TODO: add unit test for the method 'PostQueryAnchor'
            string anchor = null; // TODO: replace null with proper value
            ConversationHistoricalQueryRequestBody body = null; // TODO: replace null with proper value
            
            var response = instance.PostQueryAnchor(anchor, body);
            Assert.IsInstanceOf<ConversationQueryResponse> (response, "response is ConversationQueryResponse"); 
        }
        
        /// <summary>
        /// Test GetConversationId
        /// </summary>
        [Test]
        public void GetConversationIdTest()
        {
            // TODO: add unit test for the method 'GetConversationId'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationId(conversationId);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test PutConversationId
        /// </summary>
        [Test]
        public void PutConversationIdTest()
        {
            // TODO: add unit test for the method 'PutConversationId'
            string conversationId = null; // TODO: replace null with proper value
            Conversation body = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationId(conversationId, body);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test PostConversationIdCalls
        /// </summary>
        [Test]
        public void PostConversationIdCallsTest()
        {
            // TODO: add unit test for the method 'PostConversationIdCalls'
            string conversationId = null; // TODO: replace null with proper value
            CallCommand body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationIdCalls(conversationId, body);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test GetConversationIdMessages
        /// </summary>
        [Test]
        public void GetConversationIdMessagesTest()
        {
            // TODO: add unit test for the method 'GetConversationIdMessages'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdMessages(conversationId);
            Assert.IsInstanceOf<EmailMessageListing> (response, "response is EmailMessageListing"); 
        }
        
        /// <summary>
        /// Test PostConversationIdMessages
        /// </summary>
        [Test]
        public void PostConversationIdMessagesTest()
        {
            // TODO: add unit test for the method 'PostConversationIdMessages'
            string conversationId = null; // TODO: replace null with proper value
            EmailMessage body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationIdMessages(conversationId, body);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test GetConversationIdMessagesDraft
        /// </summary>
        [Test]
        public void GetConversationIdMessagesDraftTest()
        {
            // TODO: add unit test for the method 'GetConversationIdMessagesDraft'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdMessagesDraft(conversationId);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test PutConversationIdMessagesDraft
        /// </summary>
        [Test]
        public void PutConversationIdMessagesDraftTest()
        {
            // TODO: add unit test for the method 'PutConversationIdMessagesDraft'
            string conversationId = null; // TODO: replace null with proper value
            EmailMessage body = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationIdMessagesDraft(conversationId, body);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test DeleteConversationIdMessagesDraftAttachmentsAttachmentId
        /// </summary>
        [Test]
        public void DeleteConversationIdMessagesDraftAttachmentsAttachmentIdTest()
        {
            // TODO: add unit test for the method 'DeleteConversationIdMessagesDraftAttachmentsAttachmentId'
            string conversationId = null; // TODO: replace null with proper value
            string attachmentId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteConversationIdMessagesDraftAttachmentsAttachmentId(conversationId, attachmentId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetConversationIdMessagesId
        /// </summary>
        [Test]
        public void GetConversationIdMessagesIdTest()
        {
            // TODO: add unit test for the method 'GetConversationIdMessagesId'
            string conversationId = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdMessagesId(conversationId, id);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test PostConversationIdParticipants
        /// </summary>
        [Test]
        public void PostConversationIdParticipantsTest()
        {
            // TODO: add unit test for the method 'PostConversationIdParticipants'
            string conversationId = null; // TODO: replace null with proper value
            Conversation body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationIdParticipants(conversationId, body);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test PutConversationIdParticipantsParticipantId
        /// </summary>
        [Test]
        public void PutConversationIdParticipantsParticipantIdTest()
        {
            // TODO: add unit test for the method 'PutConversationIdParticipantsParticipantId'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ParticipantRequest body = null; // TODO: replace null with proper value
            
            instance.PutConversationIdParticipantsParticipantId(conversationId, participantId, body);
             
        }
        
        /// <summary>
        /// Test PutConversationIdParticipantsParticipantIdAttributes
        /// </summary>
        [Test]
        public void PutConversationIdParticipantsParticipantIdAttributesTest()
        {
            // TODO: add unit test for the method 'PutConversationIdParticipantsParticipantIdAttributes'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ParticipantAttributes body = null; // TODO: replace null with proper value
            
            instance.PutConversationIdParticipantsParticipantIdAttributes(conversationId, participantId, body);
             
        }
        
        /// <summary>
        /// Test PutConversationIdParticipantsParticipantIdConsult
        /// </summary>
        [Test]
        public void PutConversationIdParticipantsParticipantIdConsultTest()
        {
            // TODO: add unit test for the method 'PutConversationIdParticipantsParticipantIdConsult'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ConsultTransferUpdate body = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationIdParticipantsParticipantIdConsult(conversationId, participantId, body);
            Assert.IsInstanceOf<ConsultTransferResponse> (response, "response is ConsultTransferResponse"); 
        }
        
        /// <summary>
        /// Test PostConversationIdParticipantsParticipantIdConsult
        /// </summary>
        [Test]
        public void PostConversationIdParticipantsParticipantIdConsultTest()
        {
            // TODO: add unit test for the method 'PostConversationIdParticipantsParticipantIdConsult'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ConsultTransfer body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationIdParticipantsParticipantIdConsult(conversationId, participantId, body);
            Assert.IsInstanceOf<ConsultTransferResponse> (response, "response is ConsultTransferResponse"); 
        }
        
        /// <summary>
        /// Test DeleteConversationIdParticipantsParticipantIdConsult
        /// </summary>
        [Test]
        public void DeleteConversationIdParticipantsParticipantIdConsultTest()
        {
            // TODO: add unit test for the method 'DeleteConversationIdParticipantsParticipantIdConsult'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteConversationIdParticipantsParticipantIdConsult(conversationId, participantId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostConversationIdParticipantsParticipantIdMonitor
        /// </summary>
        [Test]
        public void PostConversationIdParticipantsParticipantIdMonitorTest()
        {
            // TODO: add unit test for the method 'PostConversationIdParticipantsParticipantIdMonitor'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            
            instance.PostConversationIdParticipantsParticipantIdMonitor(conversationId, participantId);
             
        }
        
        /// <summary>
        /// Test PostConversationIdParticipantsParticipantIdReplace
        /// </summary>
        [Test]
        public void PostConversationIdParticipantsParticipantIdReplaceTest()
        {
            // TODO: add unit test for the method 'PostConversationIdParticipantsParticipantIdReplace'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            string address = null; // TODO: replace null with proper value
            string username = null; // TODO: replace null with proper value
            string queueId = null; // TODO: replace null with proper value
            bool? voicemail = null; // TODO: replace null with proper value
            
            instance.PostConversationIdParticipantsParticipantIdReplace(conversationId, participantId, userId, address, username, queueId, voicemail);
             
        }
        
        /// <summary>
        /// Test GetConversationIdParticipantsParticipantIdWrapup
        /// </summary>
        [Test]
        public void GetConversationIdParticipantsParticipantIdWrapupTest()
        {
            // TODO: add unit test for the method 'GetConversationIdParticipantsParticipantIdWrapup'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            bool? provisional = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdParticipantsParticipantIdWrapup(conversationId, participantId, provisional);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test GetConversationIdParticipantsParticipantIdWrapupcodes
        /// </summary>
        [Test]
        public void GetConversationIdParticipantsParticipantIdWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetConversationIdParticipantsParticipantIdWrapupcodes'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdParticipantsParticipantIdWrapupcodes(conversationId, participantId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test GetConversationIdTags
        /// </summary>
        [Test]
        public void GetConversationIdTagsTest()
        {
            // TODO: add unit test for the method 'GetConversationIdTags'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdTags(conversationId);
            Assert.IsInstanceOf<Tag> (response, "response is Tag"); 
        }
        
        /// <summary>
        /// Test GetConversationIdWrapupcodes
        /// </summary>
        [Test]
        public void GetConversationIdWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetConversationIdWrapupcodes'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdWrapupcodes(conversationId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
    }

}
