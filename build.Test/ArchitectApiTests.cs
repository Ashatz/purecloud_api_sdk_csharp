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
    public class ArchitectApiTests
    {
        private ArchitectApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ArchitectApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ArchitectApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ArchitectApi> (instance, "instance is a ArchitectApi");
        }

        
        /// <summary>
        /// Test PostAudits
        /// </summary>
        [Test]
        public void PostAuditsTest()
        {
            // TODO: add unit test for the method 'PostAudits'
            CommonAuditRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostAudits(body);
            Assert.IsInstanceOf<AuditSearchResult> (response, "response is AuditSearchResult"); 
        }
        
        /// <summary>
        /// Test GetIvrs
        /// </summary>
        [Test]
        public void GetIvrsTest()
        {
            // TODO: add unit test for the method 'GetIvrs'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetIvrs(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<IVREntityListing> (response, "response is IVREntityListing"); 
        }
        
        /// <summary>
        /// Test PostIvrs
        /// </summary>
        [Test]
        public void PostIvrsTest()
        {
            // TODO: add unit test for the method 'PostIvrs'
            IVR body = null; // TODO: replace null with proper value
            
            var response = instance.PostIvrs(body);
            Assert.IsInstanceOf<IVR> (response, "response is IVR"); 
        }
        
        /// <summary>
        /// Test PostIvrsActionsPublish
        /// </summary>
        [Test]
        public void PostIvrsActionsPublishTest()
        {
            // TODO: add unit test for the method 'PostIvrsActionsPublish'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.PostIvrsActionsPublish(id);
            Assert.IsInstanceOf<IVR> (response, "response is IVR"); 
        }
        
        /// <summary>
        /// Test GetIvrsIvrId
        /// </summary>
        [Test]
        public void GetIvrsIvrIdTest()
        {
            // TODO: add unit test for the method 'GetIvrsIvrId'
            string ivrId = null; // TODO: replace null with proper value
            
            var response = instance.GetIvrsIvrId(ivrId);
            Assert.IsInstanceOf<IVR> (response, "response is IVR"); 
        }
        
        /// <summary>
        /// Test PutIvrsIvrId
        /// </summary>
        [Test]
        public void PutIvrsIvrIdTest()
        {
            // TODO: add unit test for the method 'PutIvrsIvrId'
            string ivrId = null; // TODO: replace null with proper value
            IVR body = null; // TODO: replace null with proper value
            
            var response = instance.PutIvrsIvrId(ivrId, body);
            Assert.IsInstanceOf<IVR> (response, "response is IVR"); 
        }
        
        /// <summary>
        /// Test DeleteIvrsIvrId
        /// </summary>
        [Test]
        public void DeleteIvrsIvrIdTest()
        {
            // TODO: add unit test for the method 'DeleteIvrsIvrId'
            string ivrId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteIvrsIvrId(ivrId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetPrompts
        /// </summary>
        [Test]
        public void GetPromptsTest()
        {
            // TODO: add unit test for the method 'GetPrompts'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string description = null; // TODO: replace null with proper value
            string nameOrDescription = null; // TODO: replace null with proper value
            
            var response = instance.GetPrompts(pageNumber, pageSize, name, description, nameOrDescription);
            Assert.IsInstanceOf<PromptEntityListing> (response, "response is PromptEntityListing"); 
        }
        
        /// <summary>
        /// Test PostPrompts
        /// </summary>
        [Test]
        public void PostPromptsTest()
        {
            // TODO: add unit test for the method 'PostPrompts'
            Prompt body = null; // TODO: replace null with proper value
            
            var response = instance.PostPrompts(body);
            Assert.IsInstanceOf<Prompt> (response, "response is Prompt"); 
        }
        
        /// <summary>
        /// Test DeletePrompts
        /// </summary>
        [Test]
        public void DeletePromptsTest()
        {
            // TODO: add unit test for the method 'DeletePrompts'
            List<string> id = null; // TODO: replace null with proper value
            bool? ignoreDependencies = null; // TODO: replace null with proper value
            
            instance.DeletePrompts(id, ignoreDependencies);
             
        }
        
        /// <summary>
        /// Test GetPromptsPromptId
        /// </summary>
        [Test]
        public void GetPromptsPromptIdTest()
        {
            // TODO: add unit test for the method 'GetPromptsPromptId'
            string promptId = null; // TODO: replace null with proper value
            
            var response = instance.GetPromptsPromptId(promptId);
            Assert.IsInstanceOf<Prompt> (response, "response is Prompt"); 
        }
        
        /// <summary>
        /// Test PutPromptsPromptId
        /// </summary>
        [Test]
        public void PutPromptsPromptIdTest()
        {
            // TODO: add unit test for the method 'PutPromptsPromptId'
            string promptId = null; // TODO: replace null with proper value
            Prompt body = null; // TODO: replace null with proper value
            
            var response = instance.PutPromptsPromptId(promptId, body);
            Assert.IsInstanceOf<Prompt> (response, "response is Prompt"); 
        }
        
        /// <summary>
        /// Test DeletePromptsPromptId
        /// </summary>
        [Test]
        public void DeletePromptsPromptIdTest()
        {
            // TODO: add unit test for the method 'DeletePromptsPromptId'
            string promptId = null; // TODO: replace null with proper value
            
            instance.DeletePromptsPromptId(promptId);
             
        }
        
        /// <summary>
        /// Test GetPromptsPromptIdResources
        /// </summary>
        [Test]
        public void GetPromptsPromptIdResourcesTest()
        {
            // TODO: add unit test for the method 'GetPromptsPromptIdResources'
            string promptId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetPromptsPromptIdResources(promptId, pageNumber, pageSize);
            Assert.IsInstanceOf<PromptAssetEntityListing> (response, "response is PromptAssetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostPromptsPromptIdResources
        /// </summary>
        [Test]
        public void PostPromptsPromptIdResourcesTest()
        {
            // TODO: add unit test for the method 'PostPromptsPromptIdResources'
            string promptId = null; // TODO: replace null with proper value
            PromptAsset body = null; // TODO: replace null with proper value
            
            var response = instance.PostPromptsPromptIdResources(promptId, body);
            Assert.IsInstanceOf<PromptAsset> (response, "response is PromptAsset"); 
        }
        
        /// <summary>
        /// Test GetPromptsPromptIdResourcesLanguage
        /// </summary>
        [Test]
        public void GetPromptsPromptIdResourcesLanguageTest()
        {
            // TODO: add unit test for the method 'GetPromptsPromptIdResourcesLanguage'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            var response = instance.GetPromptsPromptIdResourcesLanguage(promptId, language);
            Assert.IsInstanceOf<PromptAsset> (response, "response is PromptAsset"); 
        }
        
        /// <summary>
        /// Test PutPromptsPromptIdResourcesLanguage
        /// </summary>
        [Test]
        public void PutPromptsPromptIdResourcesLanguageTest()
        {
            // TODO: add unit test for the method 'PutPromptsPromptIdResourcesLanguage'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            PromptAsset body = null; // TODO: replace null with proper value
            
            var response = instance.PutPromptsPromptIdResourcesLanguage(promptId, language, body);
            Assert.IsInstanceOf<PromptAsset> (response, "response is PromptAsset"); 
        }
        
        /// <summary>
        /// Test DeletePromptsPromptIdResourcesLanguage
        /// </summary>
        [Test]
        public void DeletePromptsPromptIdResourcesLanguageTest()
        {
            // TODO: add unit test for the method 'DeletePromptsPromptIdResourcesLanguage'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            instance.DeletePromptsPromptIdResourcesLanguage(promptId, language);
             
        }
        
        /// <summary>
        /// Test GetSchedulegroups
        /// </summary>
        [Test]
        public void GetSchedulegroupsTest()
        {
            // TODO: add unit test for the method 'GetSchedulegroups'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulegroups(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<ScheduleGroupEntityListing> (response, "response is ScheduleGroupEntityListing"); 
        }
        
        /// <summary>
        /// Test PostSchedulegroups
        /// </summary>
        [Test]
        public void PostSchedulegroupsTest()
        {
            // TODO: add unit test for the method 'PostSchedulegroups'
            ScheduleGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PostSchedulegroups(body);
            Assert.IsInstanceOf<ScheduleGroup> (response, "response is ScheduleGroup"); 
        }
        
        /// <summary>
        /// Test GetSchedulegroupsSchedulegroupId
        /// </summary>
        [Test]
        public void GetSchedulegroupsSchedulegroupIdTest()
        {
            // TODO: add unit test for the method 'GetSchedulegroupsSchedulegroupId'
            string scheduleGroupId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulegroupsSchedulegroupId(scheduleGroupId);
            Assert.IsInstanceOf<ScheduleGroup> (response, "response is ScheduleGroup"); 
        }
        
        /// <summary>
        /// Test PutSchedulegroupsSchedulegroupId
        /// </summary>
        [Test]
        public void PutSchedulegroupsSchedulegroupIdTest()
        {
            // TODO: add unit test for the method 'PutSchedulegroupsSchedulegroupId'
            string scheduleGroupId = null; // TODO: replace null with proper value
            ScheduleGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulegroupsSchedulegroupId(scheduleGroupId, body);
            Assert.IsInstanceOf<ScheduleGroup> (response, "response is ScheduleGroup"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulegroupsSchedulegroupId
        /// </summary>
        [Test]
        public void DeleteSchedulegroupsSchedulegroupIdTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulegroupsSchedulegroupId'
            string scheduleGroupId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulegroupsSchedulegroupId(scheduleGroupId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSchedules
        /// </summary>
        [Test]
        public void GetSchedulesTest()
        {
            // TODO: add unit test for the method 'GetSchedules'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedules(pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<ScheduleEntityListing> (response, "response is ScheduleEntityListing"); 
        }
        
        /// <summary>
        /// Test PostSchedules
        /// </summary>
        [Test]
        public void PostSchedulesTest()
        {
            // TODO: add unit test for the method 'PostSchedules'
            Schedule body = null; // TODO: replace null with proper value
            
            var response = instance.PostSchedules(body);
            Assert.IsInstanceOf<Schedule> (response, "response is Schedule"); 
        }
        
        /// <summary>
        /// Test GetSchedulesScheduleId
        /// </summary>
        [Test]
        public void GetSchedulesScheduleIdTest()
        {
            // TODO: add unit test for the method 'GetSchedulesScheduleId'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulesScheduleId(scheduleId);
            Assert.IsInstanceOf<Schedule> (response, "response is Schedule"); 
        }
        
        /// <summary>
        /// Test PutSchedulesScheduleId
        /// </summary>
        [Test]
        public void PutSchedulesScheduleIdTest()
        {
            // TODO: add unit test for the method 'PutSchedulesScheduleId'
            string scheduleId = null; // TODO: replace null with proper value
            Schedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulesScheduleId(scheduleId, body);
            Assert.IsInstanceOf<Schedule> (response, "response is Schedule"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulesScheduleId
        /// </summary>
        [Test]
        public void DeleteSchedulesScheduleIdTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulesScheduleId'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulesScheduleId(scheduleId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSystemprompts
        /// </summary>
        [Test]
        public void GetSystempromptsTest()
        {
            // TODO: add unit test for the method 'GetSystemprompts'
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string description = null; // TODO: replace null with proper value
            string nameOrDescription = null; // TODO: replace null with proper value
            
            var response = instance.GetSystemprompts(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
            Assert.IsInstanceOf<SystemPromptEntityListing> (response, "response is SystemPromptEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSystempromptsPromptId
        /// </summary>
        [Test]
        public void GetSystempromptsPromptIdTest()
        {
            // TODO: add unit test for the method 'GetSystempromptsPromptId'
            string promptId = null; // TODO: replace null with proper value
            
            var response = instance.GetSystempromptsPromptId(promptId);
            Assert.IsInstanceOf<SystemPrompt> (response, "response is SystemPrompt"); 
        }
        
        /// <summary>
        /// Test GetSystempromptsPromptIdResources
        /// </summary>
        [Test]
        public void GetSystempromptsPromptIdResourcesTest()
        {
            // TODO: add unit test for the method 'GetSystempromptsPromptIdResources'
            string promptId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetSystempromptsPromptIdResources(promptId, pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<SystemPromptAssetEntityListing> (response, "response is SystemPromptAssetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostSystempromptsPromptIdResources
        /// </summary>
        [Test]
        public void PostSystempromptsPromptIdResourcesTest()
        {
            // TODO: add unit test for the method 'PostSystempromptsPromptIdResources'
            string promptId = null; // TODO: replace null with proper value
            SystemPromptAsset body = null; // TODO: replace null with proper value
            
            var response = instance.PostSystempromptsPromptIdResources(promptId, body);
            Assert.IsInstanceOf<SystemPromptAsset> (response, "response is SystemPromptAsset"); 
        }
        
        /// <summary>
        /// Test GetSystempromptsPromptIdResourcesLanguage
        /// </summary>
        [Test]
        public void GetSystempromptsPromptIdResourcesLanguageTest()
        {
            // TODO: add unit test for the method 'GetSystempromptsPromptIdResourcesLanguage'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            var response = instance.GetSystempromptsPromptIdResourcesLanguage(promptId, language);
            Assert.IsInstanceOf<SystemPromptAsset> (response, "response is SystemPromptAsset"); 
        }
        
        /// <summary>
        /// Test DeleteSystempromptsPromptIdResourcesLanguage
        /// </summary>
        [Test]
        public void DeleteSystempromptsPromptIdResourcesLanguageTest()
        {
            // TODO: add unit test for the method 'DeleteSystempromptsPromptIdResourcesLanguage'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSystempromptsPromptIdResourcesLanguage(promptId, language);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string type = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            List<string> id = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string description = null; // TODO: replace null with proper value
            string nameOrDescription = null; // TODO: replace null with proper value
            string publishVersionId = null; // TODO: replace null with proper value
            string editableBy = null; // TODO: replace null with proper value
            string lockedBy = null; // TODO: replace null with proper value
            bool? deleted = null; // TODO: replace null with proper value
            
            var response = instance.Get(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
            Assert.IsInstanceOf<FlowEntityListing> (response, "response is FlowEntityListing"); 
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO: add unit test for the method 'Post'
            Flow body = null; // TODO: replace null with proper value
            
            var response = instance.Post(body);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO: add unit test for the method 'Delete'
            List<string> id = null; // TODO: replace null with proper value
            bool? ignoreDependencies = null; // TODO: replace null with proper value
            
            instance.Delete(id, ignoreDependencies);
             
        }
        
        /// <summary>
        /// Test PostActionsCheckin
        /// </summary>
        [Test]
        public void PostActionsCheckinTest()
        {
            // TODO: add unit test for the method 'PostActionsCheckin'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostActionsCheckin(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PostActionsCheckout
        /// </summary>
        [Test]
        public void PostActionsCheckoutTest()
        {
            // TODO: add unit test for the method 'PostActionsCheckout'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostActionsCheckout(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PostActionsDeactivate
        /// </summary>
        [Test]
        public void PostActionsDeactivateTest()
        {
            // TODO: add unit test for the method 'PostActionsDeactivate'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostActionsDeactivate(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PostActionsDebug
        /// </summary>
        [Test]
        public void PostActionsDebugTest()
        {
            // TODO: add unit test for the method 'PostActionsDebug'
            string version = null; // TODO: replace null with proper value
            string flow = null; // TODO: replace null with proper value
            
            instance.PostActionsDebug(version, flow);
             
        }
        
        /// <summary>
        /// Test PostActionsRevert
        /// </summary>
        [Test]
        public void PostActionsRevertTest()
        {
            // TODO: add unit test for the method 'PostActionsRevert'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostActionsRevert(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test GetFlowId
        /// </summary>
        [Test]
        public void GetFlowIdTest()
        {
            // TODO: add unit test for the method 'GetFlowId'
            string flowId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowId(flowId, deleted);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PutFlowId
        /// </summary>
        [Test]
        public void PutFlowIdTest()
        {
            // TODO: add unit test for the method 'PutFlowId'
            string flowId = null; // TODO: replace null with proper value
            Flow body = null; // TODO: replace null with proper value
            
            var response = instance.PutFlowId(flowId, body);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test DeleteFlowId
        /// </summary>
        [Test]
        public void DeleteFlowIdTest()
        {
            // TODO: add unit test for the method 'DeleteFlowId'
            string flowId = null; // TODO: replace null with proper value
            
            instance.DeleteFlowId(flowId);
             
        }
        
        /// <summary>
        /// Test GetFlowIdLatestconfiguration
        /// </summary>
        [Test]
        public void GetFlowIdLatestconfigurationTest()
        {
            // TODO: add unit test for the method 'GetFlowIdLatestconfiguration'
            string flowId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowIdLatestconfiguration(flowId, deleted);
            Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200"); 
        }
        
        /// <summary>
        /// Test GetFlowIdPublishedresultsId
        /// </summary>
        [Test]
        public void GetFlowIdPublishedresultsIdTest()
        {
            // TODO: add unit test for the method 'GetFlowIdPublishedresultsId'
            string flowId = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowIdPublishedresultsId(flowId, id);
            Assert.IsInstanceOf<PublishedResult> (response, "response is PublishedResult"); 
        }
        
        /// <summary>
        /// Test GetFlowIdVersions
        /// </summary>
        [Test]
        public void GetFlowIdVersionsTest()
        {
            // TODO: add unit test for the method 'GetFlowIdVersions'
            string flowId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowIdVersions(flowId, pageNumber, pageSize, deleted);
            Assert.IsInstanceOf<FlowVersionEntityListing> (response, "response is FlowVersionEntityListing"); 
        }
        
        /// <summary>
        /// Test PostFlowIdVersions
        /// </summary>
        [Test]
        public void PostFlowIdVersionsTest()
        {
            // TODO: add unit test for the method 'PostFlowIdVersions'
            string flowId = null; // TODO: replace null with proper value
            Body2 body = null; // TODO: replace null with proper value
            
            var response = instance.PostFlowIdVersions(flowId, body);
            Assert.IsInstanceOf<FlowVersion> (response, "response is FlowVersion"); 
        }
        
        /// <summary>
        /// Test GetFlowIdVersionsVersionId
        /// </summary>
        [Test]
        public void GetFlowIdVersionsVersionIdTest()
        {
            // TODO: add unit test for the method 'GetFlowIdVersionsVersionId'
            string flowId = null; // TODO: replace null with proper value
            string versionId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowIdVersionsVersionId(flowId, versionId, deleted);
            Assert.IsInstanceOf<FlowVersion> (response, "response is FlowVersion"); 
        }
        
        /// <summary>
        /// Test GetFlowIdVersionsVersionIdConfiguration
        /// </summary>
        [Test]
        public void GetFlowIdVersionsVersionIdConfigurationTest()
        {
            // TODO: add unit test for the method 'GetFlowIdVersionsVersionIdConfiguration'
            string flowId = null; // TODO: replace null with proper value
            string versionId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowIdVersionsVersionIdConfiguration(flowId, versionId, deleted);
            Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200"); 
        }
        
    }

}
