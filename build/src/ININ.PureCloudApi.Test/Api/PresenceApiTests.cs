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
    /// <summary>
    ///  Class for testing PresenceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test DeletePresenceId
        /// </summary>
        [Test]
        public void DeletePresenceIdTest()
        {
            // TODO: add unit test for the method 'DeletePresenceId'
            string presenceId = null; // TODO: replace null with proper value
            instance.DeletePresenceId(presenceId);
            
        }
        
        /// <summary>
        /// Test GetPresenceId
        /// </summary>
        [Test]
        public void GetPresenceIdTest()
        {
            // TODO: add unit test for the method 'GetPresenceId'
            string presenceId = null; // TODO: replace null with proper value
            string localeCode = null; // TODO: replace null with proper value
            var response = instance.GetPresenceId(presenceId, localeCode);
            Assert.IsInstanceOf<OrganizationPresence> (response, "response is OrganizationPresence");
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
            string deleted = null; // TODO: replace null with proper value
            string localeCode = null; // TODO: replace null with proper value
            var response = instance.GetPresencedefinitions(pageNumber, pageSize, deleted, localeCode);
            Assert.IsInstanceOf<OrganizationPresenceEntityListing> (response, "response is OrganizationPresenceEntityListing");
        }
        
        /// <summary>
        /// Test GetSystempresences
        /// </summary>
        [Test]
        public void GetSystempresencesTest()
        {
            // TODO: add unit test for the method 'GetSystempresences'
            var response = instance.GetSystempresences();
            Assert.IsInstanceOf<List<SystemPresence>> (response, "response is List<SystemPresence>");
        }
        
        /// <summary>
        /// Test GetUserIdPresencesSourceId
        /// </summary>
        [Test]
        public void GetUserIdPresencesSourceIdTest()
        {
            // TODO: add unit test for the method 'GetUserIdPresencesSourceId'
            string userId = null; // TODO: replace null with proper value
            string sourceId = null; // TODO: replace null with proper value
            var response = instance.GetUserIdPresencesSourceId(userId, sourceId);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence");
        }
        
        /// <summary>
        /// Test PatchUserIdPresencesSourceId
        /// </summary>
        [Test]
        public void PatchUserIdPresencesSourceIdTest()
        {
            // TODO: add unit test for the method 'PatchUserIdPresencesSourceId'
            string userId = null; // TODO: replace null with proper value
            string sourceId = null; // TODO: replace null with proper value
            UserPresence body = null; // TODO: replace null with proper value
            var response = instance.PatchUserIdPresencesSourceId(userId, sourceId, body);
            Assert.IsInstanceOf<UserPresence> (response, "response is UserPresence");
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
        
    }

}
