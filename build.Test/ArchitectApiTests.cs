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
        /// Test GetIvr
        /// </summary>
        [Test]
        public void GetIvrTest()
        {
            // TODO: add unit test for the method 'GetIvr'
            string ivrId = null; // TODO: replace null with proper value
            
            var response = instance.GetIvr(ivrId);
            Assert.IsInstanceOf<IVR> (response, "response is IVR"); 
        }
        
        /// <summary>
        /// Test PutIvr
        /// </summary>
        [Test]
        public void PutIvrTest()
        {
            // TODO: add unit test for the method 'PutIvr'
            string ivrId = null; // TODO: replace null with proper value
            IVR body = null; // TODO: replace null with proper value
            
            var response = instance.PutIvr(ivrId, body);
            Assert.IsInstanceOf<IVR> (response, "response is IVR"); 
        }
        
        /// <summary>
        /// Test DeleteIvr
        /// </summary>
        [Test]
        public void DeleteIvrTest()
        {
            // TODO: add unit test for the method 'DeleteIvr'
            string ivrId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteIvr(ivrId);
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
        /// Test GetPrompt
        /// </summary>
        [Test]
        public void GetPromptTest()
        {
            // TODO: add unit test for the method 'GetPrompt'
            string promptId = null; // TODO: replace null with proper value
            
            var response = instance.GetPrompt(promptId);
            Assert.IsInstanceOf<Prompt> (response, "response is Prompt"); 
        }
        
        /// <summary>
        /// Test PutPrompt
        /// </summary>
        [Test]
        public void PutPromptTest()
        {
            // TODO: add unit test for the method 'PutPrompt'
            string promptId = null; // TODO: replace null with proper value
            Prompt body = null; // TODO: replace null with proper value
            
            var response = instance.PutPrompt(promptId, body);
            Assert.IsInstanceOf<Prompt> (response, "response is Prompt"); 
        }
        
        /// <summary>
        /// Test DeletePrompt
        /// </summary>
        [Test]
        public void DeletePromptTest()
        {
            // TODO: add unit test for the method 'DeletePrompt'
            string promptId = null; // TODO: replace null with proper value
            
            instance.DeletePrompt(promptId);
             
        }
        
        /// <summary>
        /// Test GetPromptResources
        /// </summary>
        [Test]
        public void GetPromptResourcesTest()
        {
            // TODO: add unit test for the method 'GetPromptResources'
            string promptId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            
            var response = instance.GetPromptResources(promptId, pageNumber, pageSize);
            Assert.IsInstanceOf<PromptAssetEntityListing> (response, "response is PromptAssetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostPromptResources
        /// </summary>
        [Test]
        public void PostPromptResourcesTest()
        {
            // TODO: add unit test for the method 'PostPromptResources'
            string promptId = null; // TODO: replace null with proper value
            PromptAsset body = null; // TODO: replace null with proper value
            
            var response = instance.PostPromptResources(promptId, body);
            Assert.IsInstanceOf<PromptAsset> (response, "response is PromptAsset"); 
        }
        
        /// <summary>
        /// Test GetPromptResources_0
        /// </summary>
        [Test]
        public void GetPromptResources_0Test()
        {
            // TODO: add unit test for the method 'GetPromptResources_0'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            var response = instance.GetPromptResources_0(promptId, language);
            Assert.IsInstanceOf<PromptAsset> (response, "response is PromptAsset"); 
        }
        
        /// <summary>
        /// Test PutPromptResources
        /// </summary>
        [Test]
        public void PutPromptResourcesTest()
        {
            // TODO: add unit test for the method 'PutPromptResources'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            PromptAsset body = null; // TODO: replace null with proper value
            
            var response = instance.PutPromptResources(promptId, language, body);
            Assert.IsInstanceOf<PromptAsset> (response, "response is PromptAsset"); 
        }
        
        /// <summary>
        /// Test DeletePromptResources
        /// </summary>
        [Test]
        public void DeletePromptResourcesTest()
        {
            // TODO: add unit test for the method 'DeletePromptResources'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            instance.DeletePromptResources(promptId, language);
             
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
        /// Test GetSchedulegroup
        /// </summary>
        [Test]
        public void GetSchedulegroupTest()
        {
            // TODO: add unit test for the method 'GetSchedulegroup'
            string scheduleGroupId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulegroup(scheduleGroupId);
            Assert.IsInstanceOf<ScheduleGroup> (response, "response is ScheduleGroup"); 
        }
        
        /// <summary>
        /// Test PutSchedulegroup
        /// </summary>
        [Test]
        public void PutSchedulegroupTest()
        {
            // TODO: add unit test for the method 'PutSchedulegroup'
            string scheduleGroupId = null; // TODO: replace null with proper value
            ScheduleGroup body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulegroup(scheduleGroupId, body);
            Assert.IsInstanceOf<ScheduleGroup> (response, "response is ScheduleGroup"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulegroup
        /// </summary>
        [Test]
        public void DeleteSchedulegroupTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulegroup'
            string scheduleGroupId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulegroup(scheduleGroupId);
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
        /// Test GetSchedule
        /// </summary>
        [Test]
        public void GetScheduleTest()
        {
            // TODO: add unit test for the method 'GetSchedule'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedule(scheduleId);
            Assert.IsInstanceOf<Schedule> (response, "response is Schedule"); 
        }
        
        /// <summary>
        /// Test PutSchedule
        /// </summary>
        [Test]
        public void PutScheduleTest()
        {
            // TODO: add unit test for the method 'PutSchedule'
            string scheduleId = null; // TODO: replace null with proper value
            Schedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedule(scheduleId, body);
            Assert.IsInstanceOf<Schedule> (response, "response is Schedule"); 
        }
        
        /// <summary>
        /// Test DeleteSchedule
        /// </summary>
        [Test]
        public void DeleteScheduleTest()
        {
            // TODO: add unit test for the method 'DeleteSchedule'
            string scheduleId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedule(scheduleId);
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
        /// Test GetSystemprompt
        /// </summary>
        [Test]
        public void GetSystempromptTest()
        {
            // TODO: add unit test for the method 'GetSystemprompt'
            string promptId = null; // TODO: replace null with proper value
            
            var response = instance.GetSystemprompt(promptId);
            Assert.IsInstanceOf<SystemPrompt> (response, "response is SystemPrompt"); 
        }
        
        /// <summary>
        /// Test GetSystempromptResources
        /// </summary>
        [Test]
        public void GetSystempromptResourcesTest()
        {
            // TODO: add unit test for the method 'GetSystempromptResources'
            string promptId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetSystempromptResources(promptId, pageNumber, pageSize, sortBy, sortOrder);
            Assert.IsInstanceOf<SystemPromptAssetEntityListing> (response, "response is SystemPromptAssetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostSystempromptResources
        /// </summary>
        [Test]
        public void PostSystempromptResourcesTest()
        {
            // TODO: add unit test for the method 'PostSystempromptResources'
            string promptId = null; // TODO: replace null with proper value
            SystemPromptAsset body = null; // TODO: replace null with proper value
            
            var response = instance.PostSystempromptResources(promptId, body);
            Assert.IsInstanceOf<SystemPromptAsset> (response, "response is SystemPromptAsset"); 
        }
        
        /// <summary>
        /// Test GetSystempromptResources_0
        /// </summary>
        [Test]
        public void GetSystempromptResources_0Test()
        {
            // TODO: add unit test for the method 'GetSystempromptResources_0'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            var response = instance.GetSystempromptResources_0(promptId, language);
            Assert.IsInstanceOf<SystemPromptAsset> (response, "response is SystemPromptAsset"); 
        }
        
        /// <summary>
        /// Test DeleteSystempromptResources
        /// </summary>
        [Test]
        public void DeleteSystempromptResourcesTest()
        {
            // TODO: add unit test for the method 'DeleteSystempromptResources'
            string promptId = null; // TODO: replace null with proper value
            string language = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSystempromptResources(promptId, language);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetFlows
        /// </summary>
        [Test]
        public void GetFlowsTest()
        {
            // TODO: add unit test for the method 'GetFlows'
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
            
            var response = instance.GetFlows(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
            Assert.IsInstanceOf<FlowEntityListing> (response, "response is FlowEntityListing"); 
        }
        
        /// <summary>
        /// Test PostFlows
        /// </summary>
        [Test]
        public void PostFlowsTest()
        {
            // TODO: add unit test for the method 'PostFlows'
            Flow body = null; // TODO: replace null with proper value
            
            var response = instance.PostFlows(body);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test DeleteFlows
        /// </summary>
        [Test]
        public void DeleteFlowsTest()
        {
            // TODO: add unit test for the method 'DeleteFlows'
            List<string> id = null; // TODO: replace null with proper value
            bool? ignoreDependencies = null; // TODO: replace null with proper value
            
            instance.DeleteFlows(id, ignoreDependencies);
             
        }
        
        /// <summary>
        /// Test PostFlowsActionsCheckin
        /// </summary>
        [Test]
        public void PostFlowsActionsCheckinTest()
        {
            // TODO: add unit test for the method 'PostFlowsActionsCheckin'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostFlowsActionsCheckin(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PostFlowsActionsCheckout
        /// </summary>
        [Test]
        public void PostFlowsActionsCheckoutTest()
        {
            // TODO: add unit test for the method 'PostFlowsActionsCheckout'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostFlowsActionsCheckout(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PostFlowsActionsDeactivate
        /// </summary>
        [Test]
        public void PostFlowsActionsDeactivateTest()
        {
            // TODO: add unit test for the method 'PostFlowsActionsDeactivate'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostFlowsActionsDeactivate(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PostFlowsActionsDebug
        /// </summary>
        [Test]
        public void PostFlowsActionsDebugTest()
        {
            // TODO: add unit test for the method 'PostFlowsActionsDebug'
            string version = null; // TODO: replace null with proper value
            string flow = null; // TODO: replace null with proper value
            
            instance.PostFlowsActionsDebug(version, flow);
             
        }
        
        /// <summary>
        /// Test PostFlowsActionsRevert
        /// </summary>
        [Test]
        public void PostFlowsActionsRevertTest()
        {
            // TODO: add unit test for the method 'PostFlowsActionsRevert'
            string flow = null; // TODO: replace null with proper value
            
            var response = instance.PostFlowsActionsRevert(flow);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test GetFlow
        /// </summary>
        [Test]
        public void GetFlowTest()
        {
            // TODO: add unit test for the method 'GetFlow'
            string flowId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlow(flowId, deleted);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test PutFlow
        /// </summary>
        [Test]
        public void PutFlowTest()
        {
            // TODO: add unit test for the method 'PutFlow'
            string flowId = null; // TODO: replace null with proper value
            Flow body = null; // TODO: replace null with proper value
            
            var response = instance.PutFlow(flowId, body);
            Assert.IsInstanceOf<Flow> (response, "response is Flow"); 
        }
        
        /// <summary>
        /// Test DeleteFlow
        /// </summary>
        [Test]
        public void DeleteFlowTest()
        {
            // TODO: add unit test for the method 'DeleteFlow'
            string flowId = null; // TODO: replace null with proper value
            
            instance.DeleteFlow(flowId);
             
        }
        
        /// <summary>
        /// Test GetFlowLatestconfiguration
        /// </summary>
        [Test]
        public void GetFlowLatestconfigurationTest()
        {
            // TODO: add unit test for the method 'GetFlowLatestconfiguration'
            string flowId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowLatestconfiguration(flowId, deleted);
            Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200"); 
        }
        
        /// <summary>
        /// Test GetFlowPublishedresults
        /// </summary>
        [Test]
        public void GetFlowPublishedresultsTest()
        {
            // TODO: add unit test for the method 'GetFlowPublishedresults'
            string flowId = null; // TODO: replace null with proper value
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowPublishedresults(flowId, id);
            Assert.IsInstanceOf<PublishedResult> (response, "response is PublishedResult"); 
        }
        
        /// <summary>
        /// Test GetFlowVersions
        /// </summary>
        [Test]
        public void GetFlowVersionsTest()
        {
            // TODO: add unit test for the method 'GetFlowVersions'
            string flowId = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowVersions(flowId, pageNumber, pageSize, deleted);
            Assert.IsInstanceOf<FlowVersionEntityListing> (response, "response is FlowVersionEntityListing"); 
        }
        
        /// <summary>
        /// Test PostFlowVersions
        /// </summary>
        [Test]
        public void PostFlowVersionsTest()
        {
            // TODO: add unit test for the method 'PostFlowVersions'
            string flowId = null; // TODO: replace null with proper value
            Body2 body = null; // TODO: replace null with proper value
            
            var response = instance.PostFlowVersions(flowId, body);
            Assert.IsInstanceOf<FlowVersion> (response, "response is FlowVersion"); 
        }
        
        /// <summary>
        /// Test GetFlowVersion
        /// </summary>
        [Test]
        public void GetFlowVersionTest()
        {
            // TODO: add unit test for the method 'GetFlowVersion'
            string flowId = null; // TODO: replace null with proper value
            string versionId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowVersion(flowId, versionId, deleted);
            Assert.IsInstanceOf<FlowVersion> (response, "response is FlowVersion"); 
        }
        
        /// <summary>
        /// Test GetFlowVersionConfiguration
        /// </summary>
        [Test]
        public void GetFlowVersionConfigurationTest()
        {
            // TODO: add unit test for the method 'GetFlowVersionConfiguration'
            string flowId = null; // TODO: replace null with proper value
            string versionId = null; // TODO: replace null with proper value
            string deleted = null; // TODO: replace null with proper value
            
            var response = instance.GetFlowVersionConfiguration(flowId, versionId, deleted);
            Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200"); 
        }
        
    }

}
