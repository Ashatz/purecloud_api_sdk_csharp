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
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO: add unit test for the method 'GetUsers'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            List<string> id = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string role = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string username = null; // TODO: replace null with proper value
            List<string> skill = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetUsers(pageSize, pageNumber, id, sortBy, role, name, username, skill, expand);
            Assert.IsInstanceOf<UsersEntityListing> (response, "response is UsersEntityListing"); 
        }
        
        /// <summary>
        /// Test PostUsers
        /// </summary>
        [Test]
        public void PostUsersTest()
        {
            // TODO: add unit test for the method 'PostUsers'
            User body = null; // TODO: replace null with proper value
            
            var response = instance.PostUsers(body);
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
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string userId = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.Get(userId, expand);
            Assert.IsInstanceOf<User> (response, "response is User"); 
        }
        
        /// <summary>
        /// Test Put
        /// </summary>
        [Test]
        public void PutTest()
        {
            // TODO: add unit test for the method 'Put'
            string userId = null; // TODO: replace null with proper value
            User body = null; // TODO: replace null with proper value
            
            var response = instance.Put(userId, body);
            Assert.IsInstanceOf<User> (response, "response is User"); 
        }
        
        /// <summary>
        /// Test GetCallforwarding
        /// </summary>
        [Test]
        public void GetCallforwardingTest()
        {
            // TODO: add unit test for the method 'GetCallforwarding'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetCallforwarding(userId);
            Assert.IsInstanceOf<CallForwarding> (response, "response is CallForwarding"); 
        }
        
        /// <summary>
        /// Test PutCallforwarding
        /// </summary>
        [Test]
        public void PutCallforwardingTest()
        {
            // TODO: add unit test for the method 'PutCallforwarding'
            string userId = null; // TODO: replace null with proper value
            CallForwarding body = null; // TODO: replace null with proper value
            
            var response = instance.PutCallforwarding(userId, body);
            Assert.IsInstanceOf<CallForwarding> (response, "response is CallForwarding"); 
        }
        
        /// <summary>
        /// Test PatchCallforwarding
        /// </summary>
        [Test]
        public void PatchCallforwardingTest()
        {
            // TODO: add unit test for the method 'PatchCallforwarding'
            string userId = null; // TODO: replace null with proper value
            CallForwarding body = null; // TODO: replace null with proper value
            
            var response = instance.PatchCallforwarding(userId, body);
            Assert.IsInstanceOf<CallForwarding> (response, "response is CallForwarding"); 
        }
        
        /// <summary>
        /// Test GetGeolocation
        /// </summary>
        [Test]
        public void GetGeolocationTest()
        {
            // TODO: add unit test for the method 'GetGeolocation'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            
            var response = instance.GetGeolocation(userId, clientId);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation"); 
        }
        
        /// <summary>
        /// Test PatchGeolocation
        /// </summary>
        [Test]
        public void PatchGeolocationTest()
        {
            // TODO: add unit test for the method 'PatchGeolocation'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            Geolocation body = null; // TODO: replace null with proper value
            
            var response = instance.PatchGeolocation(userId, clientId, body);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation"); 
        }
        
        /// <summary>
        /// Test GetOutofoffice
        /// </summary>
        [Test]
        public void GetOutofofficeTest()
        {
            // TODO: add unit test for the method 'GetOutofoffice'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetOutofoffice(userId);
            Assert.IsInstanceOf<OutOfOffice> (response, "response is OutOfOffice"); 
        }
        
        /// <summary>
        /// Test PutOutofoffice
        /// </summary>
        [Test]
        public void PutOutofofficeTest()
        {
            // TODO: add unit test for the method 'PutOutofoffice'
            string userId = null; // TODO: replace null with proper value
            OutOfOffice body = null; // TODO: replace null with proper value
            
            var response = instance.PutOutofoffice(userId, body);
            Assert.IsInstanceOf<OutOfOffice> (response, "response is OutOfOffice"); 
        }
        
        /// <summary>
        /// Test GetPrimarypresencesource
        /// </summary>
        [Test]
        public void GetPrimarypresencesourceTest()
        {
            // TODO: add unit test for the method 'GetPrimarypresencesource'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetPrimarypresencesource(userId);
            Assert.IsInstanceOf<PrimaryUserPresenceSource> (response, "response is PrimaryUserPresenceSource"); 
        }
        
        /// <summary>
        /// Test PutPrimarypresencesource
        /// </summary>
        [Test]
        public void PutPrimarypresencesourceTest()
        {
            // TODO: add unit test for the method 'PutPrimarypresencesource'
            string userId = null; // TODO: replace null with proper value
            PrimaryUserPresenceSource body = null; // TODO: replace null with proper value
            
            var response = instance.PutPrimarypresencesource(userId, body);
            Assert.IsInstanceOf<PrimaryUserPresenceSource> (response, "response is PrimaryUserPresenceSource"); 
        }
        
        /// <summary>
        /// Test GetQueues
        /// </summary>
        [Test]
        public void GetQueuesTest()
        {
            // TODO: add unit test for the method 'GetQueues'
            string userId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetQueues(userId, pageSize, pageNumber);
            Assert.IsInstanceOf<UserQueueEntityListing> (response, "response is UserQueueEntityListing"); 
        }
        
        /// <summary>
        /// Test PatchQueues
        /// </summary>
        [Test]
        public void PatchQueuesTest()
        {
            // TODO: add unit test for the method 'PatchQueues'
            string userId = null; // TODO: replace null with proper value
            List<UserQueue> body = null; // TODO: replace null with proper value
            
            var response = instance.PatchQueues(userId, body);
            Assert.IsInstanceOf<UserQueue> (response, "response is UserQueue"); 
        }
        
        /// <summary>
        /// Test PatchQueue
        /// </summary>
        [Test]
        public void PatchQueueTest()
        {
            // TODO: add unit test for the method 'PatchQueue'
            string queueId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            UserQueue body = null; // TODO: replace null with proper value
            
            var response = instance.PatchQueue(queueId, userId, body);
            Assert.IsInstanceOf<UserQueue> (response, "response is UserQueue"); 
        }
        
        /// <summary>
        /// Test GetRoles
        /// </summary>
        [Test]
        public void GetRolesTest()
        {
            // TODO: add unit test for the method 'GetRoles'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetRoles(userId);
            Assert.IsInstanceOf<List<DomainOrganizationRole>> (response, "response is List<DomainOrganizationRole>"); 
        }
        
        /// <summary>
        /// Test GetRoutingstatus
        /// </summary>
        [Test]
        public void GetRoutingstatusTest()
        {
            // TODO: add unit test for the method 'GetRoutingstatus'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetRoutingstatus(userId);
            Assert.IsInstanceOf<RoutingStatus> (response, "response is RoutingStatus"); 
        }
        
        /// <summary>
        /// Test PutRoutingstatus
        /// </summary>
        [Test]
        public void PutRoutingstatusTest()
        {
            // TODO: add unit test for the method 'PutRoutingstatus'
            string userId = null; // TODO: replace null with proper value
            RoutingStatus body = null; // TODO: replace null with proper value
            
            var response = instance.PutRoutingstatus(userId, body);
            Assert.IsInstanceOf<RoutingStatus> (response, "response is RoutingStatus"); 
        }
        
        /// <summary>
        /// Test GetSkills
        /// </summary>
        [Test]
        public void GetSkillsTest()
        {
            // TODO: add unit test for the method 'GetSkills'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetSkills(userId);
            Assert.IsInstanceOf<UserSkillEntityListing> (response, "response is UserSkillEntityListing"); 
        }
        
    }

}
