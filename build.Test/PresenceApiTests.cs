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
    public class PresenceApiTests
    {
        private PresenceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new PresenceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PresenceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<PresenceApi> (instance, "instance is a PresenceApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageNumber, pageSize);
            Assert.IsInstanceOf<OrganizationPresenceEntityListing> (response, "response is OrganizationPresenceEntityListing"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            OrganizationPresence body = null; // TODO: replace null with proper value
            
            var response = instance.Post(body);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test GetPresenceId
        /// </summary>
        [Test]
        public void GetPresenceIdTest()
        {
            // TODO: add unit test for the method 'GetPresenceId'
            string presenceId = null; // TODO: replace null with proper value
            
            var response = instance.GetPresenceId(presenceId);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test PutPresenceId
        /// </summary>
        [Test]
        public void PutPresenceIdTest()
        {
            // TODO: add unit test for the method 'PutPresenceId'
            string presenceId = null; // TODO: replace null with proper value
            OrganizationPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PutPresenceId(presenceId, body);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test DeletePresenceId
        /// </summary>
        [Test]
        public void DeletePresenceIdTest()
        {
            // TODO: add unit test for the method 'DeletePresenceId'
            string presenceId = null; // TODO: replace null with proper value
            
            var response = instance.DeletePresenceId(presenceId);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test GetUserIdPresences
        /// </summary>
        [Test]
        public void GetUserIdPresencesTest()
        {
            // TODO: add unit test for the method 'GetUserIdPresences'
            string userId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdPresences(userId, pageNumber, pageSize);
            Assert.IsInstanceOf<UserPresenceEntityListing> (response, "response is UserPresenceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetUserIdPresencesSource
        /// </summary>
        [Test]
        public void GetUserIdPresencesSourceTest()
        {
            // TODO: add unit test for the method 'GetUserIdPresencesSource'
            string userId = null; // TODO: replace null with proper value
            string source = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdPresencesSource(userId, source);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
        /// <summary>
        /// Test PutUserIdPresencesSource
        /// </summary>
        [Test]
        public void PutUserIdPresencesSourceTest()
        {
            // TODO: add unit test for the method 'PutUserIdPresencesSource'
            string userId = null; // TODO: replace null with proper value
            string source = null; // TODO: replace null with proper value
            UserPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserIdPresencesSource(userId, source, body);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
        /// <summary>
        /// Test PatchUserIdPresencesSource
        /// </summary>
        [Test]
        public void PatchUserIdPresencesSourceTest()
        {
            // TODO: add unit test for the method 'PatchUserIdPresencesSource'
            string userId = null; // TODO: replace null with proper value
            string source = null; // TODO: replace null with proper value
            UserPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUserIdPresencesSource(userId, source, body);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
        /// <summary>
        /// Test GetUserIdPrimarypresence
        /// </summary>
        [Test]
        public void GetUserIdPrimarypresenceTest()
        {
            // TODO: add unit test for the method 'GetUserIdPrimarypresence'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdPrimarypresence(userId);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
    }

}
