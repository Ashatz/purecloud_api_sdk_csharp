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
        /// Test GetEmailDomainsRoutes
        /// </summary>
        [Test]
        public void GetEmailDomainsRoutesTest()
        {
            // TODO: add unit test for the method 'GetEmailDomainsRoutes'
            string domain = null; // TODO: replace null with proper value
            
            var response = instance.GetEmailDomainsRoutes(domain);
            Assert.IsInstanceOf<InboundRouteEntityListing> (response, "response is InboundRouteEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEmailDomainsRoutes
        /// </summary>
        [Test]
        public void PostEmailDomainsRoutesTest()
        {
            // TODO: add unit test for the method 'PostEmailDomainsRoutes'
            string domain = null; // TODO: replace null with proper value
            InboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PostEmailDomainsRoutes(domain, body);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute"); 
        }
        
        /// <summary>
        /// Test GetEmailDomainsRoutes_0
        /// </summary>
        [Test]
        public void GetEmailDomainsRoutes_0Test()
        {
            // TODO: add unit test for the method 'GetEmailDomainsRoutes_0'
            string domain = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetEmailDomainsRoutes_0(domain, id);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute"); 
        }
        
        /// <summary>
        /// Test PutEmailDomainsRoutes
        /// </summary>
        [Test]
        public void PutEmailDomainsRoutesTest()
        {
            // TODO: add unit test for the method 'PutEmailDomainsRoutes'
            string domain = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            InboundRoute body = null; // TODO: replace null with proper value
            
            var response = instance.PutEmailDomainsRoutes(domain, id, body);
            Assert.IsInstanceOf<InboundRoute> (response, "response is InboundRoute"); 
        }
        
        /// <summary>
        /// Test DeleteEmailDomainsRoutes
        /// </summary>
        [Test]
        public void DeleteEmailDomainsRoutesTest()
        {
            // TODO: add unit test for the method 'DeleteEmailDomainsRoutes'
            string domain = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEmailDomainsRoutes(domain, id);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test DeleteEmailDomains
        /// </summary>
        [Test]
        public void DeleteEmailDomainsTest()
        {
            // TODO: add unit test for the method 'DeleteEmailDomains'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.DeleteEmailDomains(id);
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
        /// Test GetQueue
        /// </summary>
        [Test]
        public void GetQueueTest()
        {
            // TODO: add unit test for the method 'GetQueue'
            string queueId = null; // TODO: replace null with proper value
            
            var response = instance.GetQueue(queueId);
            Assert.IsInstanceOf<Queue> (response, "response is Queue"); 
        }
        
        /// <summary>
        /// Test PutQueue
        /// </summary>
        [Test]
        public void PutQueueTest()
        {
            // TODO: add unit test for the method 'PutQueue'
            string queueId = null; // TODO: replace null with proper value
            Queue body = null; // TODO: replace null with proper value
            
            var response = instance.PutQueue(queueId, body);
            Assert.IsInstanceOf<Queue> (response, "response is Queue"); 
        }
        
        /// <summary>
        /// Test DeleteQueue
        /// </summary>
        [Test]
        public void DeleteQueueTest()
        {
            // TODO: add unit test for the method 'DeleteQueue'
            string queueId = null; // TODO: replace null with proper value
            bool? forceDelete = null; // TODO: replace null with proper value
            
            var response = instance.DeleteQueue(queueId, forceDelete);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetQueueMembers
        /// </summary>
        [Test]
        public void GetQueueMembersTest()
        {
            // TODO: add unit test for the method 'GetQueueMembers'
            string queueId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            string statusId = null; // TODO: replace null with proper value
            bool? joined = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetQueueMembers(queueId, pageSize, pageNumber, userId, statusId, joined, expand);
            Assert.IsInstanceOf<QueueMemberEntityListing> (response, "response is QueueMemberEntityListing"); 
        }
        
        /// <summary>
        /// Test PutQueueMember
        /// </summary>
        [Test]
        public void PutQueueMemberTest()
        {
            // TODO: add unit test for the method 'PutQueueMember'
            string queueId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            QueueMember body = null; // TODO: replace null with proper value
            
            var response = instance.PutQueueMember(queueId, memberId, body);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember"); 
        }
        
        /// <summary>
        /// Test GetQueueUsers
        /// </summary>
        [Test]
        public void GetQueueUsersTest()
        {
            // TODO: add unit test for the method 'GetQueueUsers'
            string queueId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            bool? directMembers = null; // TODO: replace null with proper value
            
            var response = instance.GetQueueUsers(queueId, pageSize, pageNumber, sortBy, expand, directMembers);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember"); 
        }
        
        /// <summary>
        /// Test PostQueueUsers
        /// </summary>
        [Test]
        public void PostQueueUsersTest()
        {
            // TODO: add unit test for the method 'PostQueueUsers'
            string queueId = null; // TODO: replace null with proper value
            List<QueueMember> body = null; // TODO: replace null with proper value
            bool? delete = null; // TODO: replace null with proper value
            
            var response = instance.PostQueueUsers(queueId, body, delete);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember"); 
        }
        
        /// <summary>
        /// Test PatchQueueUsers
        /// </summary>
        [Test]
        public void PatchQueueUsersTest()
        {
            // TODO: add unit test for the method 'PatchQueueUsers'
            string queueId = null; // TODO: replace null with proper value
            List<QueueMember> body = null; // TODO: replace null with proper value
            
            var response = instance.PatchQueueUsers(queueId, body);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember"); 
        }
        
        /// <summary>
        /// Test DeleteQueueUser
        /// </summary>
        [Test]
        public void DeleteQueueUserTest()
        {
            // TODO: add unit test for the method 'DeleteQueueUser'
            string queueId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteQueueUser(queueId, memberId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PatchQueueUser
        /// </summary>
        [Test]
        public void PatchQueueUserTest()
        {
            // TODO: add unit test for the method 'PatchQueueUser'
            string queueId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            QueueMember body = null; // TODO: replace null with proper value
            
            var response = instance.PatchQueueUser(queueId, memberId, body);
            Assert.IsInstanceOf<QueueMember> (response, "response is QueueMember"); 
        }
        
        /// <summary>
        /// Test GetQueueWrapupcodes
        /// </summary>
        [Test]
        public void GetQueueWrapupcodesTest()
        {
            // TODO: add unit test for the method 'GetQueueWrapupcodes'
            string queueId = null; // TODO: replace null with proper value
            string codeId = null; // TODO: replace null with proper value
            
            var response = instance.GetQueueWrapupcodes(queueId, codeId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test PostQueueWrapupcodes
        /// </summary>
        [Test]
        public void PostQueueWrapupcodesTest()
        {
            // TODO: add unit test for the method 'PostQueueWrapupcodes'
            string queueId = null; // TODO: replace null with proper value
            string codeId = null; // TODO: replace null with proper value
            List<WrapupCode> body = null; // TODO: replace null with proper value
            
            var response = instance.PostQueueWrapupcodes(queueId, codeId, body);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test DeleteQueueWrapupcode
        /// </summary>
        [Test]
        public void DeleteQueueWrapupcodeTest()
        {
            // TODO: add unit test for the method 'DeleteQueueWrapupcode'
            string queueId = null; // TODO: replace null with proper value
            string codeId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteQueueWrapupcode(queueId, codeId);
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
        /// Test GetWrapupcode
        /// </summary>
        [Test]
        public void GetWrapupcodeTest()
        {
            // TODO: add unit test for the method 'GetWrapupcode'
            string codeId = null; // TODO: replace null with proper value
            
            var response = instance.GetWrapupcode(codeId);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test PutWrapupcode
        /// </summary>
        [Test]
        public void PutWrapupcodeTest()
        {
            // TODO: add unit test for the method 'PutWrapupcode'
            string codeId = null; // TODO: replace null with proper value
            WrapupCode body = null; // TODO: replace null with proper value
            
            var response = instance.PutWrapupcode(codeId, body);
            Assert.IsInstanceOf<WrapupCode> (response, "response is WrapupCode"); 
        }
        
        /// <summary>
        /// Test DeleteWrapupcode
        /// </summary>
        [Test]
        public void DeleteWrapupcodeTest()
        {
            // TODO: add unit test for the method 'DeleteWrapupcode'
            string codeId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteWrapupcode(codeId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
    }

}
