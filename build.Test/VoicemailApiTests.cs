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
    public class VoicemailApiTests
    {
        private VoicemailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new VoicemailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoicemailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<VoicemailApi> (instance, "instance is a VoicemailApi");
        }

        
        /// <summary>
        /// Test GetUservoicemailpoliciesUserId
        /// </summary>
        [Test]
        public void GetUservoicemailpoliciesUserIdTest()
        {
            // TODO: add unit test for the method 'GetUservoicemailpoliciesUserId'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUservoicemailpoliciesUserId(userId);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy"); 
        }
        
        /// <summary>
        /// Test PatchUservoicemailpoliciesUserId
        /// </summary>
        [Test]
        public void PatchUservoicemailpoliciesUserIdTest()
        {
            // TODO: add unit test for the method 'PatchUservoicemailpoliciesUserId'
            string userId = null; // TODO: replace null with proper value
            VoicemailUserPolicy body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUservoicemailpoliciesUserId(userId, body);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy"); 
        }
        
        /// <summary>
        /// Test GetVoicemailpolicy
        /// </summary>
        [Test]
        public void GetVoicemailpolicyTest()
        {
            // TODO: add unit test for the method 'GetVoicemailpolicy'
            
            var response = instance.GetVoicemailpolicy();
            Assert.IsInstanceOf<VoicemailOrganizationPolicy> (response, "response is VoicemailOrganizationPolicy"); 
        }
        
        /// <summary>
        /// Test PutVoicemailpolicy
        /// </summary>
        [Test]
        public void PutVoicemailpolicyTest()
        {
            // TODO: add unit test for the method 'PutVoicemailpolicy'
            VoicemailOrganizationPolicy body = null; // TODO: replace null with proper value
            
            var response = instance.PutVoicemailpolicy(body);
            Assert.IsInstanceOf<VoicemailOrganizationPolicy> (response, "response is VoicemailOrganizationPolicy"); 
        }
        
        /// <summary>
        /// Test GetMailbox
        /// </summary>
        [Test]
        public void GetMailboxTest()
        {
            // TODO: add unit test for the method 'GetMailbox'
            
            var response = instance.GetMailbox();
            Assert.IsInstanceOf<VoicemailMailboxInfo> (response, "response is VoicemailMailboxInfo"); 
        }
        
        /// <summary>
        /// Test GetMessages
        /// </summary>
        [Test]
        public void GetMessagesTest()
        {
            // TODO: add unit test for the method 'GetMessages'
            
            var response = instance.GetMessages();
            Assert.IsInstanceOf<VoicemailMessageEntityListing> (response, "response is VoicemailMessageEntityListing"); 
        }
        
        /// <summary>
        /// Test DeleteMessages
        /// </summary>
        [Test]
        public void DeleteMessagesTest()
        {
            // TODO: add unit test for the method 'DeleteMessages'
            
            var response = instance.DeleteMessages();
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetMessagesMessageId
        /// </summary>
        [Test]
        public void GetMessagesMessageIdTest()
        {
            // TODO: add unit test for the method 'GetMessagesMessageId'
            string messageId = null; // TODO: replace null with proper value
            
            var response = instance.GetMessagesMessageId(messageId);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage"); 
        }
        
        /// <summary>
        /// Test PutMessagesMessageId
        /// </summary>
        [Test]
        public void PutMessagesMessageIdTest()
        {
            // TODO: add unit test for the method 'PutMessagesMessageId'
            string messageId = null; // TODO: replace null with proper value
            VoicemailMessage body = null; // TODO: replace null with proper value
            
            var response = instance.PutMessagesMessageId(messageId, body);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage"); 
        }
        
        /// <summary>
        /// Test DeleteMessagesMessageId
        /// </summary>
        [Test]
        public void DeleteMessagesMessageIdTest()
        {
            // TODO: add unit test for the method 'DeleteMessagesMessageId'
            string messageId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteMessagesMessageId(messageId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetMessagesMessageIdMedia
        /// </summary>
        [Test]
        public void GetMessagesMessageIdMediaTest()
        {
            // TODO: add unit test for the method 'GetMessagesMessageIdMedia'
            string messageId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetMessagesMessageIdMedia(messageId, formatId);
            Assert.IsInstanceOf<VoicemailMediaInfo> (response, "response is VoicemailMediaInfo"); 
        }
        
    }

}
