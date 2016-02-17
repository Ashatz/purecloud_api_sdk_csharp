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
        /// Test GetConversations
        /// </summary>
        [Test]
        public void GetConversationsTest()
        {
            // TODO: add unit test for the method 'GetConversations'
            string communicationType = null; // TODO: replace null with proper value
            
            var response = instance.GetConversations(communicationType);
            Assert.IsInstanceOf<ConversationEntityListing> (response, "response is ConversationEntityListing"); 
        }
        
        /// <summary>
        /// Test PostConversations
        /// </summary>
        [Test]
        public void PostConversationsTest()
        {
            // TODO: add unit test for the method 'PostConversations'
            string call = null; // TODO: replace null with proper value
            string callFrom = null; // TODO: replace null with proper value
            string callQueueId = null; // TODO: replace null with proper value
            string callUserId = null; // TODO: replace null with proper value
            int? priority = null; // TODO: replace null with proper value
            string languageId = null; // TODO: replace null with proper value
            List<string> skillIds = null; // TODO: replace null with proper value
            string body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversations(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
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
        /// Test PostQuery_0
        /// </summary>
        [Test]
        public void PostQuery_0Test()
        {
            // TODO: add unit test for the method 'PostQuery_0'
            string anchor = null; // TODO: replace null with proper value
            ConversationHistoricalQueryRequestBody body = null; // TODO: replace null with proper value
            
            var response = instance.PostQuery_0(anchor, body);
            Assert.IsInstanceOf<ConversationQueryResponse> (response, "response is ConversationQueryResponse"); 
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.Get(conversationId);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test Put
        /// </summary>
        [Test]
        public void PutTest()
        {
            // TODO: add unit test for the method 'Put'
            string conversationId = null; // TODO: replace null with proper value
            Conversation body = null; // TODO: replace null with proper value
            
            var response = instance.Put(conversationId, body);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test GetMessages
        /// </summary>
        [Test]
        public void GetMessagesTest()
        {
            // TODO: add unit test for the method 'GetMessages'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetMessages(conversationId);
            Assert.IsInstanceOf<EmailMessageListing> (response, "response is EmailMessageListing"); 
        }
        
        /// <summary>
        /// Test PostMessages
        /// </summary>
        [Test]
        public void PostMessagesTest()
        {
            // TODO: add unit test for the method 'PostMessages'
            string conversationId = null; // TODO: replace null with proper value
            EmailMessage body = null; // TODO: replace null with proper value
            
            var response = instance.PostMessages(conversationId, body);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test GetMessagesDraft
        /// </summary>
        [Test]
        public void GetMessagesDraftTest()
        {
            // TODO: add unit test for the method 'GetMessagesDraft'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetMessagesDraft(conversationId);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test PutMessagesDraft
        /// </summary>
        [Test]
        public void PutMessagesDraftTest()
        {
            // TODO: add unit test for the method 'PutMessagesDraft'
            string conversationId = null; // TODO: replace null with proper value
            EmailMessage body = null; // TODO: replace null with proper value
            
            var response = instance.PutMessagesDraft(conversationId, body);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test DeleteMessagesDraftAttachment
        /// </summary>
        [Test]
        public void DeleteMessagesDraftAttachmentTest()
        {
            // TODO: add unit test for the method 'DeleteMessagesDraftAttachment'
            string conversationId = null; // TODO: replace null with proper value
            string attachmentId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteMessagesDraftAttachment(conversationId, attachmentId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetMessages_0
        /// </summary>
        [Test]
        public void GetMessages_0Test()
        {
            // TODO: add unit test for the method 'GetMessages_0'
            string conversationId = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetMessages_0(conversationId, id);
            Assert.IsInstanceOf<EmailMessage> (response, "response is EmailMessage"); 
        }
        
        /// <summary>
        /// Test PostParticipants
        /// </summary>
        [Test]
        public void PostParticipantsTest()
        {
            // TODO: add unit test for the method 'PostParticipants'
            string conversationId = null; // TODO: replace null with proper value
            Conversation body = null; // TODO: replace null with proper value
            
            var response = instance.PostParticipants(conversationId, body);
            Assert.IsInstanceOf<Conversation> (response, "response is Conversation"); 
        }
        
        /// <summary>
        /// Test PutParticipant
        /// </summary>
        [Test]
        public void PutParticipantTest()
        {
            // TODO: add unit test for the method 'PutParticipant'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ParticipantRequest body = null; // TODO: replace null with proper value
            
            instance.PutParticipant(conversationId, participantId, body);
             
        }
        
        /// <summary>
        /// Test PutParticipantAttributes
        /// </summary>
        [Test]
        public void PutParticipantAttributesTest()
        {
            // TODO: add unit test for the method 'PutParticipantAttributes'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ParticipantAttributes body = null; // TODO: replace null with proper value
            
            instance.PutParticipantAttributes(conversationId, participantId, body);
             
        }
        
        /// <summary>
        /// Test PutParticipantConsult
        /// </summary>
        [Test]
        public void PutParticipantConsultTest()
        {
            // TODO: add unit test for the method 'PutParticipantConsult'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ConsultTransferUpdate body = null; // TODO: replace null with proper value
            
            var response = instance.PutParticipantConsult(conversationId, participantId, body);
            Assert.IsInstanceOf<ConsultTransferResponse> (response, "response is ConsultTransferResponse"); 
        }
        
        /// <summary>
        /// Test PostParticipantConsult
        /// </summary>
        [Test]
        public void PostParticipantConsultTest()
        {
            // TODO: add unit test for the method 'PostParticipantConsult'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            ConsultTransfer body = null; // TODO: replace null with proper value
            
            var response = instance.PostParticipantConsult(conversationId, participantId, body);
            Assert.IsInstanceOf<ConsultTransferResponse> (response, "response is ConsultTransferResponse"); 
        }
        
        /// <summary>
        /// Test DeleteParticipantConsult
        /// </summary>
        [Test]
        public void DeleteParticipantConsultTest()
        {
            // TODO: add unit test for the method 'DeleteParticipantConsult'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteParticipantConsult(conversationId, participantId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostParticipantMonitor
        /// </summary>
        [Test]
        public void PostParticipantMonitorTest()
        {
            // TODO: add unit test for the method 'PostParticipantMonitor'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            
            instance.PostParticipantMonitor(conversationId, participantId);
             
        }
        
        /// <summary>
        /// Test PostParticipantReplace
        /// </summary>
        [Test]
        public void PostParticipantReplaceTest()
        {
            // TODO: add unit test for the method 'PostParticipantReplace'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            string address = null; // TODO: replace null with proper value
            string username = null; // TODO: replace null with proper value
            string queueId = null; // TODO: replace null with proper value
            bool? voicemail = null; // TODO: replace null with proper value
            
            instance.PostParticipantReplace(conversationId, participantId, userId, address, username, queueId, voicemail);
             
        }
        
        /// <summary>
        /// Test GetParticipantWrapup
        /// </summary>
        [Test]
        public void GetParticipantWrapupTest()
        {
            // TODO: add unit test for the method 'GetParticipantWrapup'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            bool? provisional = null; // TODO: replace null with proper value
            
            var response = instance.GetParticipantWrapup(conversationId, participantId, provisional);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test GetParticipantWrapupcodes
        /// </summary>
        [Test]
        public void GetParticipantWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetParticipantWrapupcodes'
            string conversationId = null; // TODO: replace null with proper value
            string participantId = null; // TODO: replace null with proper value
            
            var response = instance.GetParticipantWrapupcodes(conversationId, participantId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test GetTags
        /// </summary>
        [Test]
        public void GetTagsTest()
        {
            // TODO: add unit test for the method 'GetTags'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetTags(conversationId);
            Assert.IsInstanceOf<Tag> (response, "response is Tag"); 
        }
        
        /// <summary>
        /// Test GetWrapupcodes
        /// </summary>
        [Test]
        public void GetWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetWrapupcodes'
            string conversationId = null; // TODO: replace null with proper value
            
            var response = instance.GetWrapupcodes(conversationId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
    }

}
