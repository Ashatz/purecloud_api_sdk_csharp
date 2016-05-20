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
    ///  Class for testing RoutingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RoutingApiTests
    {
        private RoutingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RoutingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RoutingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<RoutingApi> (instance, "instance is a RoutingApi");
        }

        
        /// <summary>
        /// Test DeleteEmailDomainsDomainId
        /// </summary>
        [Test]
        public void DeleteEmailDomainsDomainIdTest()
        {
            // TODO: add unit test for the method 'DeleteEmailDomainsDomainId'
            string domainId = null; // TODO: replace null with proper value
            var response = instance.DeleteEmailDomainsDomainId(domainId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteEmailDomainsDomainnameRoutesRouteId
        /// </summary>
        [Test]
        public void DeleteEmailDomainsDomainnameRoutesRouteIdTest()
        {
            // TODO: add unit test for the method 'DeleteEmailDomainsDomainnameRoutesRouteId'
            string domainName = null; // TODO: replace null with proper value
            string routeId = null; // TODO: replace null with proper value
            var response = instance.DeleteEmailDomainsDomainnameRoutesRouteId(domainName, routeId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteQueuesQueueId
        /// </summary>
        [Test]
        public void DeleteQueuesQueueIdTest()
        {
            // TODO: add unit test for the method 'DeleteQueuesQueueId'
            string queueId = null; // TODO: replace null with proper value
            bool? forceDelete = null; // TODO: replace null with proper value
            var response = instance.DeleteQueuesQueueId(queueId, forceDelete);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteQueuesQueueIdUsersMemberId
        /// </summary>
        [Test]
        public void DeleteQueuesQueueIdUsersMemberIdTest()
        {
            // TODO: add unit test for the method 'DeleteQueuesQueueIdUsersMemberId'
            string queueId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            var response = instance.DeleteQueuesQueueIdUsersMemberId(queueId, memberId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteQueuesQueueIdWrapupcodesCodeId
        /// </summary>
        [Test]
        public void DeleteQueuesQueueIdWrapupcodesCodeIdTest()
        {
            // TODO: add unit test for the method 'DeleteQueuesQueueIdWrapupcodesCodeId'
            string queueId = null; // TODO: replace null with proper value
            string codeId = null; // TODO: replace null with proper value
            var response = instance.DeleteQueuesQueueIdWrapupcodesCodeId(queueId, codeId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteSkillsSkillId
        /// </summary>
        [Test]
        public void DeleteSkillsSkillIdTest()
        {
            // TODO: add unit test for the method 'DeleteSkillsSkillId'
            string skillId = null; // TODO: replace null with proper value
            var response = instance.DeleteSkillsSkillId(skillId);
            Assert.IsInstanceOf<string> (response, "response is string");
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
        /// Test DeleteUtilization
        /// </summary>
        [Test]
        public void DeleteUtilizationTest()
        {
            // TODO: add unit test for the method 'DeleteUtilization'
            var response = instance.DeleteUtilization();
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteWrapupcodesCodeId
        /// </summary>
        [Test]
        public void DeleteWrapupcodesCodeIdTest()
        {
            // TODO: add unit test for the method 'DeleteWrapupcodesCodeId'
            string codeId = null; // TODO: replace null with proper value
            var response = instance.DeleteWrapupcodesCodeId(codeId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetEmailDomains
        /// </summary>
        [Test]
        public void GetEmailDomainsTest()
        {
            // TODO: add unit test for the method 'GetEmailDomains'
            var response = instance.GetEmailDomains();
            Assert.IsInstanceOf<InboundDomainEntityListing> (response, "response is InboundDomainEntityListing");
        }
        
        /// <summary>
        /// Test GetEmailDomainsDomainnameRoutes
        /// </summary>
        [Test]
        public void GetEmailDomainsDomainnameRoutesTest()
        {
            // TODO: add unit test for the method 'GetEmailDomainsDomainnameRoutes'
            string domainName = null; // TODO: replace null with proper value
            var response = instance.GetEmailDomainsDomainnameRoutes(domainName);
            Assert.IsInstanceOf<InboundRouteEntityListing> (response, "response is InboundRouteEntityListing");
        }
        
        /// <summary>
        /// Test GetEmailDomainsDomainnameRoutesRouteId
        /// </summary>
        [Test]
        public void GetEmailDomainsDomainnameRoutesRouteIdTest()
        {
            // TODO: add unit test for the method 'GetEmailDomainsDomainnameRoutesRouteId'
            string domainName = null; // TODO: replace null with proper value
            string routeId = null; // TODO: replace null with proper value
            var response = instance.GetEmailDomainsDomainnameRoutesRouteId(domainName, routeId);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute");
        }
        
        /// <summary>
        /// Test GetEmailSetup
        /// </summary>
        [Test]
        public void GetEmailSetupTest()
        {
            // TODO: add unit test for the method 'GetEmailSetup'
            var response = instance.GetEmailSetup();
            Assert.IsInstanceOf<EmailSetup> (response, "response is EmailSetup");
        }
        
        /// <summary>
        /// Test GetQueues
        /// </summary>
        [Test]
        public void GetQueuesTest()
        {
            // TODO: add unit test for the method 'GetQueues'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            bool? active = null; // TODO: replace null with proper value
            var response = instance.GetQueues(pageSize, pageNumber, sortBy, name, active);
            Assert.IsInstanceOf<QueueEntityListing> (response, "response is QueueEntityListing");
        }
        
        /// <summary>
        /// Test GetQueuesQueueId
        /// </summary>
        [Test]
        public void GetQueuesQueueIdTest()
        {
            // TODO: add unit test for the method 'GetQueuesQueueId'
            string queueId = null; // TODO: replace null with proper value
            var response = instance.GetQueuesQueueId(queueId);
            Assert.IsInstanceOf<Queue> (response, "response is Queue");
        }
        
        /// <summary>
        /// Test GetQueuesQueueIdEstimatedwaittime
        /// </summary>
        [Test]
        public void GetQueuesQueueIdEstimatedwaittimeTest()
        {
            // TODO: add unit test for the method 'GetQueuesQueueIdEstimatedwaittime'
            string queueId = null; // TODO: replace null with proper value
            string conversationId = null; // TODO: replace null with proper value
            var response = instance.GetQueuesQueueIdEstimatedwaittime(queueId, conversationId);
            Assert.IsInstanceOf<EstimatedWaitTimePredictions> (response, "response is EstimatedWaitTimePredictions");
        }
        
        /// <summary>
        /// Test GetQueuesQueueIdUsers
        /// </summary>
        [Test]
        public void GetQueuesQueueIdUsersTest()
        {
            // TODO: add unit test for the method 'GetQueuesQueueIdUsers'
            string queueId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            bool? directMembers = null; // TODO: replace null with proper value
            var response = instance.GetQueuesQueueIdUsers(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember");
        }
        
        /// <summary>
        /// Test GetQueuesQueueIdWrapupcodes
        /// </summary>
        [Test]
        public void GetQueuesQueueIdWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetQueuesQueueIdWrapupcodes'
            string queueId = null; // TODO: replace null with proper value
            string codeId = null; // TODO: replace null with proper value
            var response = instance.GetQueuesQueueIdWrapupcodes(queueId, codeId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode");
        }
        
        /// <summary>
        /// Test GetSkills
        /// </summary>
        [Test]
        public void GetSkillsTest()
        {
            // TODO: add unit test for the method 'GetSkills'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetSkills(pageSize, pageNumber);
            Assert.IsInstanceOf<SkillEntityListing> (response, "response is SkillEntityListing");
        }
        
        /// <summary>
        /// Test GetSkillsSkillId
        /// </summary>
        [Test]
        public void GetSkillsSkillIdTest()
        {
            // TODO: add unit test for the method 'GetSkillsSkillId'
            string skillId = null; // TODO: replace null with proper value
            var response = instance.GetSkillsSkillId(skillId);
            Assert.IsInstanceOf<RoutingSkill> (response, "response is RoutingSkill");
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
        /// Test GetUtilization
        /// </summary>
        [Test]
        public void GetUtilizationTest()
        {
            // TODO: add unit test for the method 'GetUtilization'
            var response = instance.GetUtilization();
            Assert.IsInstanceOf<Utilization> (response, "response is Utilization");
        }
        
        /// <summary>
        /// Test GetWrapupcodes
        /// </summary>
        [Test]
        public void GetWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetWrapupcodes'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            var response = instance.GetWrapupcodes(pageSize, pageNumber, sortBy);
            Assert.IsInstanceOf<WrapupCodeEntityListing> (response, "response is WrapupCodeEntityListing");
        }
        
        /// <summary>
        /// Test GetWrapupcodesCodeId
        /// </summary>
        [Test]
        public void GetWrapupcodesCodeIdTest()
        {
            // TODO: add unit test for the method 'GetWrapupcodesCodeId'
            string codeId = null; // TODO: replace null with proper value
            var response = instance.GetWrapupcodesCodeId(codeId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode");
        }
        
        /// <summary>
        /// Test PatchQueuesQueueIdUsers
        /// </summary>
        [Test]
        public void PatchQueuesQueueIdUsersTest()
        {
            // TODO: add unit test for the method 'PatchQueuesQueueIdUsers'
            string queueId = null; // TODO: replace null with proper value
            List<QueueMember> body = null; // TODO: replace null with proper value
            var response = instance.PatchQueuesQueueIdUsers(queueId, body);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember");
        }
        
        /// <summary>
        /// Test PatchQueuesQueueIdUsersMemberId
        /// </summary>
        [Test]
        public void PatchQueuesQueueIdUsersMemberIdTest()
        {
            // TODO: add unit test for the method 'PatchQueuesQueueIdUsersMemberId'
            string queueId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            QueueMember body = null; // TODO: replace null with proper value
            var response = instance.PatchQueuesQueueIdUsersMemberId(queueId, memberId, body);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember");
        }
        
        /// <summary>
        /// Test PostEmailDomains
        /// </summary>
        [Test]
        public void PostEmailDomainsTest()
        {
            // TODO: add unit test for the method 'PostEmailDomains'
            InboundDomain body = null; // TODO: replace null with proper value
            var response = instance.PostEmailDomains(body);
            Assert.IsInstanceOf<InboundDomain> (response, "response is InboundDomain");
        }
        
        /// <summary>
        /// Test PostEmailDomainsDomainnameRoutes
        /// </summary>
        [Test]
        public void PostEmailDomainsDomainnameRoutesTest()
        {
            // TODO: add unit test for the method 'PostEmailDomainsDomainnameRoutes'
            string domainName = null; // TODO: replace null with proper value
            InboundRoute body = null; // TODO: replace null with proper value
            var response = instance.PostEmailDomainsDomainnameRoutes(domainName, body);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute");
        }
        
        /// <summary>
        /// Test PostQueues
        /// </summary>
        [Test]
        public void PostQueuesTest()
        {
            // TODO: add unit test for the method 'PostQueues'
            Queue body = null; // TODO: replace null with proper value
            var response = instance.PostQueues(body);
            Assert.IsInstanceOf<Queue> (response, "response is Queue");
        }
        
        /// <summary>
        /// Test PostQueuesObservationsQuery
        /// </summary>
        [Test]
        public void PostQueuesObservationsQueryTest()
        {
            // TODO: add unit test for the method 'PostQueuesObservationsQuery'
            ObservationQuery body = null; // TODO: replace null with proper value
            var response = instance.PostQueuesObservationsQuery(body);
            Assert.IsInstanceOf<ObservationQueryResponse> (response, "response is ObservationQueryResponse");
        }
        
        /// <summary>
        /// Test PostQueuesQueueIdUsers
        /// </summary>
        [Test]
        public void PostQueuesQueueIdUsersTest()
        {
            // TODO: add unit test for the method 'PostQueuesQueueIdUsers'
            string queueId = null; // TODO: replace null with proper value
            List<QueueMember> body = null; // TODO: replace null with proper value
            bool? delete = null; // TODO: replace null with proper value
            var response = instance.PostQueuesQueueIdUsers(queueId, body, delete);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember");
        }
        
        /// <summary>
        /// Test PostQueuesQueueIdWrapupcodes
        /// </summary>
        [Test]
        public void PostQueuesQueueIdWrapupcodesTest()
        {
            // TODO: add unit test for the method 'PostQueuesQueueIdWrapupcodes'
            string queueId = null; // TODO: replace null with proper value
            string codeId = null; // TODO: replace null with proper value
            List<WrapupCode> body = null; // TODO: replace null with proper value
            var response = instance.PostQueuesQueueIdWrapupcodes(queueId, codeId, body);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode");
        }
        
        /// <summary>
        /// Test PostSkills
        /// </summary>
        [Test]
        public void PostSkillsTest()
        {
            // TODO: add unit test for the method 'PostSkills'
            RoutingSkill body = null; // TODO: replace null with proper value
            var response = instance.PostSkills(body);
            Assert.IsInstanceOf<RoutingSkill> (response, "response is RoutingSkill");
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
        /// Test PostWrapupcodes
        /// </summary>
        [Test]
        public void PostWrapupcodesTest()
        {
            // TODO: add unit test for the method 'PostWrapupcodes'
            WrapupCode body = null; // TODO: replace null with proper value
            var response = instance.PostWrapupcodes(body);
            Assert.IsInstanceOf<CallableTimeSet> (response, "response is CallableTimeSet");
        }
        
        /// <summary>
        /// Test PutEmailDomainsDomainnameRoutesRouteId
        /// </summary>
        [Test]
        public void PutEmailDomainsDomainnameRoutesRouteIdTest()
        {
            // TODO: add unit test for the method 'PutEmailDomainsDomainnameRoutesRouteId'
            string domainName = null; // TODO: replace null with proper value
            string routeId = null; // TODO: replace null with proper value
            InboundRoute body = null; // TODO: replace null with proper value
            var response = instance.PutEmailDomainsDomainnameRoutesRouteId(domainName, routeId, body);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute");
        }
        
        /// <summary>
        /// Test PutQueuesQueueId
        /// </summary>
        [Test]
        public void PutQueuesQueueIdTest()
        {
            // TODO: add unit test for the method 'PutQueuesQueueId'
            string queueId = null; // TODO: replace null with proper value
            Queue body = null; // TODO: replace null with proper value
            var response = instance.PutQueuesQueueId(queueId, body);
            Assert.IsInstanceOf<Queue> (response, "response is Queue");
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
        /// Test PutUtilization
        /// </summary>
        [Test]
        public void PutUtilizationTest()
        {
            // TODO: add unit test for the method 'PutUtilization'
            Utilization body = null; // TODO: replace null with proper value
            var response = instance.PutUtilization(body);
            Assert.IsInstanceOf<Utilization> (response, "response is Utilization");
        }
        
        /// <summary>
        /// Test PutWrapupcodesCodeId
        /// </summary>
        [Test]
        public void PutWrapupcodesCodeIdTest()
        {
            // TODO: add unit test for the method 'PutWrapupcodesCodeId'
            string codeId = null; // TODO: replace null with proper value
            WrapupCode body = null; // TODO: replace null with proper value
            var response = instance.PutWrapupcodesCodeId(codeId, body);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode");
        }
        
    }

}