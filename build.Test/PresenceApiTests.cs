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
        /// Test GetPresencedefinitions
        /// </summary>
        [Test]
        public void GetPresencedefinitionsTest()
        {
            // TODO: add unit test for the method 'GetPresencedefinitions'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetPresencedefinitions(pageNumber, pageSize);
            Assert.IsInstanceOf<OrganizationPresenceEntityListing> (response, "response is OrganizationPresenceEntityListing"); 
        }
        
        /// <summary>
        /// Test PostPresencedefinitions
        /// </summary>
        [Test]
        public void PostPresencedefinitionsTest()
        {
            // TODO: add unit test for the method 'PostPresencedefinitions'
            OrganizationPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PostPresencedefinitions(body);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test GetPresencedefinition
        /// </summary>
        [Test]
        public void GetPresencedefinitionTest()
        {
            // TODO: add unit test for the method 'GetPresencedefinition'
            string presenceId = null; // TODO: replace null with proper value
            
            var response = instance.GetPresencedefinition(presenceId);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test PutPresencedefinition
        /// </summary>
        [Test]
        public void PutPresencedefinitionTest()
        {
            // TODO: add unit test for the method 'PutPresencedefinition'
            string presenceId = null; // TODO: replace null with proper value
            OrganizationPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PutPresencedefinition(presenceId, body);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test DeletePresencedefinition
        /// </summary>
        [Test]
        public void DeletePresencedefinitionTest()
        {
            // TODO: add unit test for the method 'DeletePresencedefinition'
            string presenceId = null; // TODO: replace null with proper value
            
            var response = instance.DeletePresencedefinition(presenceId);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence"); 
        }
        
        /// <summary>
        /// Test GetUserPresences
        /// </summary>
        [Test]
        public void GetUserPresencesTest()
        {
            // TODO: add unit test for the method 'GetUserPresences'
            string userId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetUserPresences(userId, pageNumber, pageSize);
            Assert.IsInstanceOf<UserPresenceEntityListing> (response, "response is UserPresenceEntityListing"); 
        }
        
        /// <summary>
        /// Test GetUserPresences_0
        /// </summary>
        [Test]
        public void GetUserPresences_0Test()
        {
            // TODO: add unit test for the method 'GetUserPresences_0'
            string userId = null; // TODO: replace null with proper value
            string source = null; // TODO: replace null with proper value
            
            var response = instance.GetUserPresences_0(userId, source);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
        /// <summary>
        /// Test PutUserPresences
        /// </summary>
        [Test]
        public void PutUserPresencesTest()
        {
            // TODO: add unit test for the method 'PutUserPresences'
            string userId = null; // TODO: replace null with proper value
            string source = null; // TODO: replace null with proper value
            UserPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserPresences(userId, source, body);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
        /// <summary>
        /// Test PatchUserPresences
        /// </summary>
        [Test]
        public void PatchUserPresencesTest()
        {
            // TODO: add unit test for the method 'PatchUserPresences'
            string userId = null; // TODO: replace null with proper value
            string source = null; // TODO: replace null with proper value
            UserPresence body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUserPresences(userId, source, body);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
        /// <summary>
        /// Test GetUserPrimarypresence
        /// </summary>
        [Test]
        public void GetUserPrimarypresenceTest()
        {
            // TODO: add unit test for the method 'GetUserPrimarypresence'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserPrimarypresence(userId);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence"); 
        }
        
    }

}
