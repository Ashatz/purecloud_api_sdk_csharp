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
        /// Test GetConfigurationUservoicemailpolicie
        /// </summary>
        [Test]
        public void GetConfigurationUservoicemailpolicieTest()
        {
            // TODO: add unit test for the method 'GetConfigurationUservoicemailpolicie'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetConfigurationUservoicemailpolicie(userId);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy"); 
        }
        
        /// <summary>
        /// Test PatchConfigurationUservoicemailpolicie
        /// </summary>
        [Test]
        public void PatchConfigurationUservoicemailpolicieTest()
        {
            // TODO: add unit test for the method 'PatchConfigurationUservoicemailpolicie'
            string userId = null; // TODO: replace null with proper value
            VoicemailUserPolicy body = null; // TODO: replace null with proper value
            
            var response = instance.PatchConfigurationUservoicemailpolicie(userId, body);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy"); 
        }
        
        /// <summary>
        /// Test GetConfigurationVoicemailpolicy
        /// </summary>
        [Test]
        public void GetConfigurationVoicemailpolicyTest()
        {
            // TODO: add unit test for the method 'GetConfigurationVoicemailpolicy'
            
            var response = instance.GetConfigurationVoicemailpolicy();
            Assert.IsInstanceOf<VoicemailOrganizationPolicy> (response, "response is VoicemailOrganizationPolicy"); 
        }
        
        /// <summary>
        /// Test PutConfigurationVoicemailpolicy
        /// </summary>
        [Test]
        public void PutConfigurationVoicemailpolicyTest()
        {
            // TODO: add unit test for the method 'PutConfigurationVoicemailpolicy'
            VoicemailOrganizationPolicy body = null; // TODO: replace null with proper value
            
            var response = instance.PutConfigurationVoicemailpolicy(body);
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
        /// Test GetMessage
        /// </summary>
        [Test]
        public void GetMessageTest()
        {
            // TODO: add unit test for the method 'GetMessage'
            string messageId = null; // TODO: replace null with proper value
            
            var response = instance.GetMessage(messageId);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage"); 
        }
        
        /// <summary>
        /// Test PutMessage
        /// </summary>
        [Test]
        public void PutMessageTest()
        {
            // TODO: add unit test for the method 'PutMessage'
            string messageId = null; // TODO: replace null with proper value
            VoicemailMessage body = null; // TODO: replace null with proper value
            
            var response = instance.PutMessage(messageId, body);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage"); 
        }
        
        /// <summary>
        /// Test DeleteMessage
        /// </summary>
        [Test]
        public void DeleteMessageTest()
        {
            // TODO: add unit test for the method 'DeleteMessage'
            string messageId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteMessage(messageId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetMessageMedia
        /// </summary>
        [Test]
        public void GetMessageMediaTest()
        {
            // TODO: add unit test for the method 'GetMessageMedia'
            string messageId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetMessageMedia(messageId, formatId);
            Assert.IsInstanceOf<VoicemailMediaInfo> (response, "response is VoicemailMediaInfo"); 
        }
        
    }

}
