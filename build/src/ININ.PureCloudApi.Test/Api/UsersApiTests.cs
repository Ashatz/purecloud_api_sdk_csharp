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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
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
        /// Test DeleteUserId
        /// </summary>
        [Test]
        public void DeleteUserIdTest()
        {
            // TODO: add unit test for the method 'DeleteUserId'
            string userId = null; // TODO: replace null with proper value
            var response = instance.DeleteUserId(userId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteUserIdRoles
        /// </summary>
        [Test]
        public void DeleteUserIdRolesTest()
        {
            // TODO: add unit test for the method 'DeleteUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            instance.DeleteUserIdRoles(userId);
            
        }
        
        /// <summary>
        /// Test DeleteUserIdRoutingskillsSkillId
        /// </summary>
        [Test]
        public void DeleteUserIdRoutingskillsSkillIdTest()
        {
            // TODO: add unit test for the method 'DeleteUserIdRoutingskillsSkillId'
            string userId = null; // TODO: replace null with proper value
            string skillId = null; // TODO: replace null with proper value
            var response = instance.DeleteUserIdRoutingskillsSkillId(userId, skillId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteUserIdStationAssociatedstation
        /// </summary>
        [Test]
        public void DeleteUserIdStationAssociatedstationTest()
        {
            // TODO: add unit test for the method 'DeleteUserIdStationAssociatedstation'
            string userId = null; // TODO: replace null with proper value
            instance.DeleteUserIdStationAssociatedstation(userId);
            
        }
        
        /// <summary>
        /// Test DeleteUserIdStationDefaultstation
        /// </summary>
        [Test]
        public void DeleteUserIdStationDefaultstationTest()
        {
            // TODO: add unit test for the method 'DeleteUserIdStationDefaultstation'
            string userId = null; // TODO: replace null with proper value
            instance.DeleteUserIdStationDefaultstation(userId);
            
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
            Assert.IsInstanceOf<UserMe> (response, "response is UserMe");
        }
        
        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Test]
        public void GetSearchTest()
        {
            // TODO: add unit test for the method 'GetSearch'
            string q64 = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            var response = instance.GetSearch(q64, expand);
            Assert.IsInstanceOf<UsersSearchResponse> (response, "response is UsersSearchResponse");
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
        /// Test GetUserIdRoles
        /// </summary>
        [Test]
        public void GetUserIdRolesTest()
        {
            // TODO: add unit test for the method 'GetUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            var response = instance.GetUserIdRoles(userId);
            Assert.IsInstanceOf<UserAuthorization> (response, "response is UserAuthorization");
        }
        
        /// <summary>
        /// Test GetUserIdRoutingskills
        /// </summary>
        [Test]
        public void GetUserIdRoutingskillsTest()
        {
            // TODO: add unit test for the method 'GetUserIdRoutingskills'
            string userId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            var response = instance.GetUserIdRoutingskills(userId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<UserSkillEntityListing> (response, "response is UserSkillEntityListing");
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
        /// Test GetUserIdStation
        /// </summary>
        [Test]
        public void GetUserIdStationTest()
        {
            // TODO: add unit test for the method 'GetUserIdStation'
            string userId = null; // TODO: replace null with proper value
            var response = instance.GetUserIdStation(userId);
            Assert.IsInstanceOf<UserStations> (response, "response is UserStations");
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
            string sortOrder = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            var response = instance.GetUsers(pageSize, pageNumber, id, sortOrder, expand);
            Assert.IsInstanceOf<UsersEntityListing> (response, "response is UsersEntityListing");
        }
        
        /// <summary>
        /// Test PatchUserId
        /// </summary>
        [Test]
        public void PatchUserIdTest()
        {
            // TODO: add unit test for the method 'PatchUserId'
            string userId = null; // TODO: replace null with proper value
            User body = null; // TODO: replace null with proper value
            var response = instance.PatchUserId(userId, body);
            Assert.IsInstanceOf<User> (response, "response is User");
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
        /// Test PostSearch
        /// </summary>
        [Test]
        public void PostSearchTest()
        {
            // TODO: add unit test for the method 'PostSearch'
            UserSearchRequest body = null; // TODO: replace null with proper value
            var response = instance.PostSearch(body);
            Assert.IsInstanceOf<UsersSearchResponse> (response, "response is UsersSearchResponse");
        }
        
        /// <summary>
        /// Test PostUserIdRoutingskills
        /// </summary>
        [Test]
        public void PostUserIdRoutingskillsTest()
        {
            // TODO: add unit test for the method 'PostUserIdRoutingskills'
            string userId = null; // TODO: replace null with proper value
            UserRoutingSkill body = null; // TODO: replace null with proper value
            var response = instance.PostUserIdRoutingskills(userId, body);
            Assert.IsInstanceOf<UserRoutingSkill> (response, "response is UserRoutingSkill");
        }
        
        /// <summary>
        /// Test PostUsers
        /// </summary>
        [Test]
        public void PostUsersTest()
        {
            // TODO: add unit test for the method 'PostUsers'
            CreateUser body = null; // TODO: replace null with proper value
            var response = instance.PostUsers(body);
            Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test PostUsersAggregatesQuery
        /// </summary>
        [Test]
        public void PostUsersAggregatesQueryTest()
        {
            // TODO: add unit test for the method 'PostUsersAggregatesQuery'
            AggregationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostUsersAggregatesQuery(body);
            Assert.IsInstanceOf<PresenceQueryResponse> (response, "response is PresenceQueryResponse");
        }
        
        /// <summary>
        /// Test PostUsersObservationsQuery
        /// </summary>
        [Test]
        public void PostUsersObservationsQueryTest()
        {
            // TODO: add unit test for the method 'PostUsersObservationsQuery'
            ObservationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostUsersObservationsQuery(body);
            Assert.IsInstanceOf<ObservationQueryResponse> (response, "response is ObservationQueryResponse");
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
        /// Test PutUserIdRoles
        /// </summary>
        [Test]
        public void PutUserIdRolesTest()
        {
            // TODO: add unit test for the method 'PutUserIdRoles'
            string userId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            var response = instance.PutUserIdRoles(userId, body);
            Assert.IsInstanceOf<UserAuthorization> (response, "response is UserAuthorization");
        }
        
        /// <summary>
        /// Test PutUserIdRoutingskillsSkillId
        /// </summary>
        [Test]
        public void PutUserIdRoutingskillsSkillIdTest()
        {
            // TODO: add unit test for the method 'PutUserIdRoutingskillsSkillId'
            string userId = null; // TODO: replace null with proper value
            string skillId = null; // TODO: replace null with proper value
            UserRoutingSkill body = null; // TODO: replace null with proper value
            var response = instance.PutUserIdRoutingskillsSkillId(userId, skillId, body);
            Assert.IsInstanceOf<UserRoutingSkill> (response, "response is UserRoutingSkill");
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
        /// Test PutUserIdStationAssociatedstationStationId
        /// </summary>
        [Test]
        public void PutUserIdStationAssociatedstationStationIdTest()
        {
            // TODO: add unit test for the method 'PutUserIdStationAssociatedstationStationId'
            string userId = null; // TODO: replace null with proper value
            string stationId = null; // TODO: replace null with proper value
            instance.PutUserIdStationAssociatedstationStationId(userId, stationId);
            
        }
        
        /// <summary>
        /// Test PutUserIdStationDefaultstationStationId
        /// </summary>
        [Test]
        public void PutUserIdStationDefaultstationStationIdTest()
        {
            // TODO: add unit test for the method 'PutUserIdStationDefaultstationStationId'
            string userId = null; // TODO: replace null with proper value
            string stationId = null; // TODO: replace null with proper value
            instance.PutUserIdStationDefaultstationStationId(userId, stationId);
            
        }
        
    }

}