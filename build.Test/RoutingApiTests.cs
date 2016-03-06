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
        /// Test GetEmailDomainsDomainRoutes
        /// </summary>
        [Test]
        public void GetEmailDomainsDomainRoutesTest()
        {
            // TODO: add unit test for the method 'GetEmailDomainsDomainRoutes'
            string domain = null; // TODO: replace null with proper value
            
            var response = instance.GetEmailDomainsDomainRoutes(domain);
            Assert.IsInstanceOf<InboundRouteEntityListing> (response, "response is InboundRouteEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEmailDomainsDomainRoutes
        /// </summary>
        [Test]
        public void PostEmailDomainsDomainRoutesTest()
        {
            // TODO: add unit test for the method 'PostEmailDomainsDomainRoutes'
            string domain = null; // TODO: replace null with proper value
            InboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PostEmailDomainsDomainRoutes(domain, body);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute"); 
        }
        
        /// <summary>
        /// Test GetEmailDomainsDomainRoutesId
        /// </summary>
        [Test]
        public void GetEmailDomainsDomainRoutesIdTest()
        {
            // TODO: add unit test for the method 'GetEmailDomainsDomainRoutesId'
            string domain = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetEmailDomainsDomainRoutesId(domain, id);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute"); 
        }
        
        /// <summary>
        /// Test PutEmailDomainsDomainRoutesId
        /// </summary>
        [Test]
        public void PutEmailDomainsDomainRoutesIdTest()
        {
            // TODO: add unit test for the method 'PutEmailDomainsDomainRoutesId'
            string domain = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            InboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PutEmailDomainsDomainRoutesId(domain, id, body);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute"); 
        }
        
        /// <summary>
        /// Test DeleteEmailDomainsDomainRoutesId
        /// </summary>
        [Test]
        public void DeleteEmailDomainsDomainRoutesIdTest()
        {
            // TODO: add unit test for the method 'DeleteEmailDomainsDomainRoutesId'
            string domain = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEmailDomainsDomainRoutesId(domain, id);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test DeleteEmailDomainsId
        /// </summary>
        [Test]
        public void DeleteEmailDomainsIdTest()
        {
            // TODO: add unit test for the method 'DeleteEmailDomainsId'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEmailDomainsId(id);
            Assert.IsInstanceOf<string> (response, "response is string"); 
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
        /// Test GetQueuesQueueIdMembers
        /// </summary>
        [Test]
        public void GetQueuesQueueIdMembersTest()
        {
            // TODO: add unit test for the method 'GetQueuesQueueIdMembers'
            string queueId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            string statusId = null; // TODO: replace null with proper value
            bool? joined = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetQueuesQueueIdMembers(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
            Assert.IsInstanceOf<QueueMemberEntityListing> (response, "response is QueueMemberEntityListing"); 
        }
        
        /// <summary>
        /// Test PutQueuesQueueIdMembersMemberId
        /// </summary>
        [Test]
        public void PutQueuesQueueIdMembersMemberIdTest()
        {
            // TODO: add unit test for the method 'PutQueuesQueueIdMembersMemberId'
            string queueId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            QueueMember body = null; // TODO: replace null with proper value
            
            var response = instance.PutQueuesQueueIdMembersMemberId(queueId, memberId, body);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember"); 
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
        /// Test GetSkills
        /// </summary>
        [Test]
        public void GetSkillsTest()
        {
            // TODO: add unit test for the method 'GetSkills'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.GetSkills(pageSize, pageNumber, sortBy, name);
            Assert.IsInstanceOf<SkillEntityListing> (response, "response is SkillEntityListing"); 
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
        
    }

}
