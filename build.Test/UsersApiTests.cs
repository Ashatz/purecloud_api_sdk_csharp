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
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<UsersApi> (instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            List<string> id = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string role = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string username = null; // TODO: replace null with proper value
            List<string> skill = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
            Assert.IsInstanceOf<UsersEntityListing> (response, "response is UsersEntityListing"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            User body = null; // TODO: replace null with proper value
            
            var response = instance.Post(body);
            Assert.IsInstanceOf<User> (response, "response is User"); 
        }
        
        /// <summary>
        /// Test GetMe
        /// </summary>
        [Test]
        public void GetMeTest()
        {
            // TODO: add unit test for the method 'GetMe'
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetMe(expand);
            Assert.IsInstanceOf<User> (response, "response is User"); 
        }
        
        /// <summary>
        /// Test GetUserId
        /// </summary>
        [Test]
        public void GetUserIdTest()
        {
            // TODO: add unit test for the method 'GetUserId'
            string userId = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetUserId(userId, expand);
            Assert.IsInstanceOf<User> (response, "response is User"); 
        }
        
        /// <summary>
        /// Test PutUserId
        /// </summary>
        [Test]
        public void PutUserIdTest()
        {
            // TODO: add unit test for the method 'PutUserId'
            string userId = null; // TODO: replace null with proper value
            User body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserId(userId, body);
            Assert.IsInstanceOf<User> (response, "response is User"); 
        }
        
        /// <summary>
        /// Test GetUserIdCallforwarding
        /// </summary>
        [Test]
        public void GetUserIdCallforwardingTest()
        {
            // TODO: add unit test for the method 'GetUserIdCallforwarding'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdCallforwarding(userId);
            Assert.IsInstanceOf<CallForwarding> (response, "response is CallForwarding"); 
        }
        
        /// <summary>
        /// Test PutUserIdCallforwarding
        /// </summary>
        [Test]
        public void PutUserIdCallforwardingTest()
        {
            // TODO: add unit test for the method 'PutUserIdCallforwarding'
            string userId = null; // TODO: replace null with proper value
            CallForwarding body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserIdCallforwarding(userId, body);
            Assert.IsInstanceOf<CallForwarding> (response, "response is CallForwarding"); 
        }
        
        /// <summary>
        /// Test PatchUserIdCallforwarding
        /// </summary>
        [Test]
        public void PatchUserIdCallforwardingTest()
        {
            // TODO: add unit test for the method 'PatchUserIdCallforwarding'
            string userId = null; // TODO: replace null with proper value
            CallForwarding body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUserIdCallforwarding(userId, body);
            Assert.IsInstanceOf<CallForwarding> (response, "response is CallForwarding"); 
        }
        
        /// <summary>
        /// Test GetUserIdGeolocationsClientId
        /// </summary>
        [Test]
        public void GetUserIdGeolocationsClientIdTest()
        {
            // TODO: add unit test for the method 'GetUserIdGeolocationsClientId'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdGeolocationsClientId(userId, clientId);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation"); 
        }
        
        /// <summary>
        /// Test PatchUserIdGeolocationsClientId
        /// </summary>
        [Test]
        public void PatchUserIdGeolocationsClientIdTest()
        {
            // TODO: add unit test for the method 'PatchUserIdGeolocationsClientId'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            Geolocation body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUserIdGeolocationsClientId(userId, clientId, body);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation"); 
        }
        
        /// <summary>
        /// Test GetUserIdOutofoffice
        /// </summary>
        [Test]
        public void GetUserIdOutofofficeTest()
        {
            // TODO: add unit test for the method 'GetUserIdOutofoffice'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdOutofoffice(userId);
            Assert.IsInstanceOf<OutOfOffice> (response, "response is OutOfOffice"); 
        }
        
        /// <summary>
        /// Test PutUserIdOutofoffice
        /// </summary>
        [Test]
        public void PutUserIdOutofofficeTest()
        {
            // TODO: add unit test for the method 'PutUserIdOutofoffice'
            string userId = null; // TODO: replace null with proper value
            OutOfOffice body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserIdOutofoffice(userId, body);
            Assert.IsInstanceOf<OutOfOffice> (response, "response is OutOfOffice"); 
        }
        
        /// <summary>
        /// Test GetUserIdPrimarypresencesource
        /// </summary>
        [Test]
        public void GetUserIdPrimarypresencesourceTest()
        {
            // TODO: add unit test for the method 'GetUserIdPrimarypresencesource'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdPrimarypresencesource(userId);
            Assert.IsInstanceOf<PrimaryUserPresenceSource> (response, "response is PrimaryUserPresenceSource"); 
        }
        
        /// <summary>
        /// Test PutUserIdPrimarypresencesource
        /// </summary>
        [Test]
        public void PutUserIdPrimarypresencesourceTest()
        {
            // TODO: add unit test for the method 'PutUserIdPrimarypresencesource'
            string userId = null; // TODO: replace null with proper value
            PrimaryUserPresenceSource body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserIdPrimarypresencesource(userId, body);
            Assert.IsInstanceOf<PrimaryUserPresenceSource> (response, "response is PrimaryUserPresenceSource"); 
        }
        
        /// <summary>
        /// Test GetUserIdQueues
        /// </summary>
        [Test]
        public void GetUserIdQueuesTest()
        {
            // TODO: add unit test for the method 'GetUserIdQueues'
            string userId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdQueues(userId, pageSize, pageNumber);
            Assert.IsInstanceOf<UserQueueEntityListing> (response, "response is UserQueueEntityListing"); 
        }
        
        /// <summary>
        /// Test PatchUserIdQueues
        /// </summary>
        [Test]
        public void PatchUserIdQueuesTest()
        {
            // TODO: add unit test for the method 'PatchUserIdQueues'
            string userId = null; // TODO: replace null with proper value
            List<UserQueue> body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUserIdQueues(userId, body);
            Assert.IsInstanceOf<UserQueue> (response, "response is UserQueue"); 
        }
        
        /// <summary>
        /// Test PatchUserIdQueuesQueueId
        /// </summary>
        [Test]
        public void PatchUserIdQueuesQueueIdTest()
        {
            // TODO: add unit test for the method 'PatchUserIdQueuesQueueId'
            string queueId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            UserQueue body = null; // TODO: replace null with proper value
            
            var response = instance.PatchUserIdQueuesQueueId(queueId, userId, body);
            Assert.IsInstanceOf<UserQueue> (response, "response is UserQueue"); 
        }
        
        /// <summary>
        /// Test GetUserIdRoles
        /// </summary>
        [Test]
        public void GetUserIdRolesTest()
        {
            // TODO: add unit test for the method 'GetUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdRoles(userId);
            Assert.IsInstanceOf<List<DomainOrganizationRole>> (response, "response is List<DomainOrganizationRole>"); 
        }
        
        /// <summary>
        /// Test GetUserIdRoutingstatus
        /// </summary>
        [Test]
        public void GetUserIdRoutingstatusTest()
        {
            // TODO: add unit test for the method 'GetUserIdRoutingstatus'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdRoutingstatus(userId);
            Assert.IsInstanceOf<RoutingStatus> (response, "response is RoutingStatus"); 
        }
        
        /// <summary>
        /// Test PutUserIdRoutingstatus
        /// </summary>
        [Test]
        public void PutUserIdRoutingstatusTest()
        {
            // TODO: add unit test for the method 'PutUserIdRoutingstatus'
            string userId = null; // TODO: replace null with proper value
            RoutingStatus body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserIdRoutingstatus(userId, body);
            Assert.IsInstanceOf<RoutingStatus> (response, "response is RoutingStatus"); 
        }
        
        /// <summary>
        /// Test GetUserIdSkills
        /// </summary>
        [Test]
        public void GetUserIdSkillsTest()
        {
            // TODO: add unit test for the method 'GetUserIdSkills'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserIdSkills(userId);
            Assert.IsInstanceOf<UserSkillEntityListing> (response, "response is UserSkillEntityListing"); 
        }
        
    }

}
