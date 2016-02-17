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
    public class OutboundApiTests
    {
        private OutboundApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new OutboundApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OutboundApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<OutboundApi> (instance, "instance is a OutboundApi");
        }

        
        /// <summary>
        /// Test PostAudits
        /// </summary>
        [Test]
        public void PostAuditsTest()
        {
            // TODO: add unit test for the method 'PostAudits'
            DialerAuditRequest body = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            bool? facetsOnly = null; // TODO: replace null with proper value
            
            var response = instance.PostAudits(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
            Assert.IsInstanceOf<AuditSearchResult> (response, "response is AuditSearchResult"); 
        }
        
        /// <summary>
        /// Test GetCallabletimesets
        /// </summary>
        [Test]
        public void GetCallabletimesetsTest()
        {
            // TODO: add unit test for the method 'GetCallabletimesets'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetCallabletimesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
            Assert.IsInstanceOf<CallableTimeSetEntityListing> (response, "response is CallableTimeSetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostCallabletimesets
        /// </summary>
        [Test]
        public void PostCallabletimesetsTest()
        {
            // TODO: add unit test for the method 'PostCallabletimesets'
            CallableTimeSet body = null; // TODO: replace null with proper value
            
            var response = instance.PostCallabletimesets(body);
            Assert.IsInstanceOf<CallableTimeSet> (response, "response is CallableTimeSet"); 
        }
        
        /// <summary>
        /// Test GetCallabletimeset
        /// </summary>
        [Test]
        public void GetCallabletimesetTest()
        {
            // TODO: add unit test for the method 'GetCallabletimeset'
            string callableTimeSetId = null; // TODO: replace null with proper value
            
            var response = instance.GetCallabletimeset(callableTimeSetId);
            Assert.IsInstanceOf<CallableTimeSet> (response, "response is CallableTimeSet"); 
        }
        
        /// <summary>
        /// Test PutCallabletimeset
        /// </summary>
        [Test]
        public void PutCallabletimesetTest()
        {
            // TODO: add unit test for the method 'PutCallabletimeset'
            string callableTimeSetId = null; // TODO: replace null with proper value
            CallableTimeSet body = null; // TODO: replace null with proper value
            
            var response = instance.PutCallabletimeset(callableTimeSetId, body);
            Assert.IsInstanceOf<CallableTimeSet> (response, "response is CallableTimeSet"); 
        }
        
        /// <summary>
        /// Test DeleteCallabletimeset
        /// </summary>
        [Test]
        public void DeleteCallabletimesetTest()
        {
            // TODO: add unit test for the method 'DeleteCallabletimeset'
            string callableTimeSetId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCallabletimeset(callableTimeSetId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetCallanalysisresponsesets
        /// </summary>
        [Test]
        public void GetCallanalysisresponsesetsTest()
        {
            // TODO: add unit test for the method 'GetCallanalysisresponsesets'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetCallanalysisresponsesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
            Assert.IsInstanceOf<ResponseSetEntityListing> (response, "response is ResponseSetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostCallanalysisresponsesets
        /// </summary>
        [Test]
        public void PostCallanalysisresponsesetsTest()
        {
            // TODO: add unit test for the method 'PostCallanalysisresponsesets'
            ResponseSet body = null; // TODO: replace null with proper value
            
            var response = instance.PostCallanalysisresponsesets(body);
            Assert.IsInstanceOf<ResponseSet> (response, "response is ResponseSet"); 
        }
        
        /// <summary>
        /// Test GetCallanalysisresponseset
        /// </summary>
        [Test]
        public void GetCallanalysisresponsesetTest()
        {
            // TODO: add unit test for the method 'GetCallanalysisresponseset'
            string callAnalysisSetId = null; // TODO: replace null with proper value
            
            var response = instance.GetCallanalysisresponseset(callAnalysisSetId);
            Assert.IsInstanceOf<ResponseSet> (response, "response is ResponseSet"); 
        }
        
        /// <summary>
        /// Test PutCallanalysisresponseset
        /// </summary>
        [Test]
        public void PutCallanalysisresponsesetTest()
        {
            // TODO: add unit test for the method 'PutCallanalysisresponseset'
            string callAnalysisSetId = null; // TODO: replace null with proper value
            ResponseSet body = null; // TODO: replace null with proper value
            
            var response = instance.PutCallanalysisresponseset(callAnalysisSetId, body);
            Assert.IsInstanceOf<ResponseSet> (response, "response is ResponseSet"); 
        }
        
        /// <summary>
        /// Test DeleteCallanalysisresponseset
        /// </summary>
        [Test]
        public void DeleteCallanalysisresponsesetTest()
        {
            // TODO: add unit test for the method 'DeleteCallanalysisresponseset'
            string callAnalysisSetId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCallanalysisresponseset(callAnalysisSetId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetCampaigns
        /// </summary>
        [Test]
        public void GetCampaignsTest()
        {
            // TODO: add unit test for the method 'GetCampaigns'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string contactListId = null; // TODO: replace null with proper value
            string dncListId = null; // TODO: replace null with proper value
            string distributionQueueId = null; // TODO: replace null with proper value
            string edgeGroupId = null; // TODO: replace null with proper value
            string callAnalysisResponseSetId = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaigns(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
            Assert.IsInstanceOf<CampaignEntityListing> (response, "response is CampaignEntityListing"); 
        }
        
        /// <summary>
        /// Test PostCampaigns
        /// </summary>
        [Test]
        public void PostCampaignsTest()
        {
            // TODO: add unit test for the method 'PostCampaigns'
            Campaign body = null; // TODO: replace null with proper value
            
            var response = instance.PostCampaigns(body);
            Assert.IsInstanceOf<Campaign> (response, "response is Campaign"); 
        }
        
        /// <summary>
        /// Test GetCampaign
        /// </summary>
        [Test]
        public void GetCampaignTest()
        {
            // TODO: add unit test for the method 'GetCampaign'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaign(campaignId);
            Assert.IsInstanceOf<Campaign> (response, "response is Campaign"); 
        }
        
        /// <summary>
        /// Test PutCampaign
        /// </summary>
        [Test]
        public void PutCampaignTest()
        {
            // TODO: add unit test for the method 'PutCampaign'
            string campaignId = null; // TODO: replace null with proper value
            Campaign body = null; // TODO: replace null with proper value
            
            var response = instance.PutCampaign(campaignId, body);
            Assert.IsInstanceOf<Campaign> (response, "response is Campaign"); 
        }
        
        /// <summary>
        /// Test DeleteCampaign
        /// </summary>
        [Test]
        public void DeleteCampaignTest()
        {
            // TODO: add unit test for the method 'DeleteCampaign'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCampaign(campaignId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PutCampaignAgent
        /// </summary>
        [Test]
        public void PutCampaignAgentTest()
        {
            // TODO: add unit test for the method 'PutCampaignAgent'
            string campaignId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            Agent body = null; // TODO: replace null with proper value
            
            var response = instance.PutCampaignAgent(campaignId, userId, body);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostCampaignCallbackSchedule
        /// </summary>
        [Test]
        public void PostCampaignCallbackScheduleTest()
        {
            // TODO: add unit test for the method 'PostCampaignCallbackSchedule'
            string campaignId = null; // TODO: replace null with proper value
            ContactCallbackRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostCampaignCallbackSchedule(campaignId, body);
            Assert.IsInstanceOf<ContactCallbackRequest> (response, "response is ContactCallbackRequest"); 
        }
        
        /// <summary>
        /// Test GetCampaignDiagnostics
        /// </summary>
        [Test]
        public void GetCampaignDiagnosticsTest()
        {
            // TODO: add unit test for the method 'GetCampaignDiagnostics'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaignDiagnostics(campaignId);
            Assert.IsInstanceOf<CampaignDiagnostics> (response, "response is CampaignDiagnostics"); 
        }
        
        /// <summary>
        /// Test GetCampaignStats
        /// </summary>
        [Test]
        public void GetCampaignStatsTest()
        {
            // TODO: add unit test for the method 'GetCampaignStats'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaignStats(campaignId);
            Assert.IsInstanceOf<CampaignStats> (response, "response is CampaignStats"); 
        }
        
        /// <summary>
        /// Test GetContactlists
        /// </summary>
        [Test]
        public void GetContactlistsTest()
        {
            // TODO: add unit test for the method 'GetContactlists'
            bool? includeImportStatus = null; // TODO: replace null with proper value
            bool? importStatus = null; // TODO: replace null with proper value
            bool? includeSize = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlists(includeImportStatus, importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
            Assert.IsInstanceOf<ContactListEntityListing> (response, "response is ContactListEntityListing"); 
        }
        
        /// <summary>
        /// Test PostContactlists
        /// </summary>
        [Test]
        public void PostContactlistsTest()
        {
            // TODO: add unit test for the method 'PostContactlists'
            ContactList body = null; // TODO: replace null with proper value
            
            var response = instance.PostContactlists(body);
            Assert.IsInstanceOf<ContactList> (response, "response is ContactList"); 
        }
        
        /// <summary>
        /// Test PostContactlistsPenetrationrates
        /// </summary>
        [Test]
        public void PostContactlistsPenetrationratesTest()
        {
            // TODO: add unit test for the method 'PostContactlistsPenetrationrates'
            List<PenetrationRateId> body = null; // TODO: replace null with proper value
            
            var response = instance.PostContactlistsPenetrationrates(body);
            Assert.IsInstanceOf<List<PenetrationRate>> (response, "response is List<PenetrationRate>"); 
        }
        
        /// <summary>
        /// Test GetContactlist
        /// </summary>
        [Test]
        public void GetContactlistTest()
        {
            // TODO: add unit test for the method 'GetContactlist'
            string contactListId = null; // TODO: replace null with proper value
            bool? includeImportStatus = null; // TODO: replace null with proper value
            bool? importStatus = null; // TODO: replace null with proper value
            bool? includeSize = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlist(contactListId, includeImportStatus, importStatus, includeSize);
            Assert.IsInstanceOf<ContactList> (response, "response is ContactList"); 
        }
        
        /// <summary>
        /// Test PutContactlist
        /// </summary>
        [Test]
        public void PutContactlistTest()
        {
            // TODO: add unit test for the method 'PutContactlist'
            string contactListId = null; // TODO: replace null with proper value
            ContactList body = null; // TODO: replace null with proper value
            
            var response = instance.PutContactlist(contactListId, body);
            Assert.IsInstanceOf<ContactList> (response, "response is ContactList"); 
        }
        
        /// <summary>
        /// Test DeleteContactlist
        /// </summary>
        [Test]
        public void DeleteContactlistTest()
        {
            // TODO: add unit test for the method 'DeleteContactlist'
            string contactListId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteContactlist(contactListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostContactlistContacts
        /// </summary>
        [Test]
        public void PostContactlistContactsTest()
        {
            // TODO: add unit test for the method 'PostContactlistContacts'
            string contactListId = null; // TODO: replace null with proper value
            List<Contact> body = null; // TODO: replace null with proper value
            bool? priority = null; // TODO: replace null with proper value
            
            var response = instance.PostContactlistContacts(contactListId, body, priority);
            Assert.IsInstanceOf<Contact> (response, "response is Contact"); 
        }
        
        /// <summary>
        /// Test GetContactlistContact
        /// </summary>
        [Test]
        public void GetContactlistContactTest()
        {
            // TODO: add unit test for the method 'GetContactlistContact'
            string contactListId = null; // TODO: replace null with proper value
            string contactId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistContact(contactListId, contactId);
            Assert.IsInstanceOf<Contact> (response, "response is Contact"); 
        }
        
        /// <summary>
        /// Test PutContactlistContact
        /// </summary>
        [Test]
        public void PutContactlistContactTest()
        {
            // TODO: add unit test for the method 'PutContactlistContact'
            string contactListId = null; // TODO: replace null with proper value
            string contactId = null; // TODO: replace null with proper value
            Contact body = null; // TODO: replace null with proper value
            
            var response = instance.PutContactlistContact(contactListId, contactId, body);
            Assert.IsInstanceOf<Contact> (response, "response is Contact"); 
        }
        
        /// <summary>
        /// Test DeleteContactlistContact
        /// </summary>
        [Test]
        public void DeleteContactlistContactTest()
        {
            // TODO: add unit test for the method 'DeleteContactlistContact'
            string contactListId = null; // TODO: replace null with proper value
            string contactId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteContactlistContact(contactListId, contactId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostContactlistExport
        /// </summary>
        [Test]
        public void PostContactlistExportTest()
        {
            // TODO: add unit test for the method 'PostContactlistExport'
            string contactListId = null; // TODO: replace null with proper value
            
            var response = instance.PostContactlistExport(contactListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetContactlistImportstatus
        /// </summary>
        [Test]
        public void GetContactlistImportstatusTest()
        {
            // TODO: add unit test for the method 'GetContactlistImportstatus'
            string contactListId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistImportstatus(contactListId);
            Assert.IsInstanceOf<ImportStatus> (response, "response is ImportStatus"); 
        }
        
        /// <summary>
        /// Test GetContactlistPenetrationrate
        /// </summary>
        [Test]
        public void GetContactlistPenetrationrateTest()
        {
            // TODO: add unit test for the method 'GetContactlistPenetrationrate'
            string contactListId = null; // TODO: replace null with proper value
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistPenetrationrate(contactListId, campaignId);
            Assert.IsInstanceOf<PenetrationRate> (response, "response is PenetrationRate"); 
        }
        
        /// <summary>
        /// Test PostConversationDnc
        /// </summary>
        [Test]
        public void PostConversationDncTest()
        {
            // TODO: add unit test for the method 'PostConversationDnc'
            string conversationId = null; // TODO: replace null with proper value
            
            instance.PostConversationDnc(conversationId);
             
        }
        
        /// <summary>
        /// Test GetDnclists
        /// </summary>
        [Test]
        public void GetDnclistsTest()
        {
            // TODO: add unit test for the method 'GetDnclists'
            bool? includeImportStatus = null; // TODO: replace null with proper value
            bool? importStatus = null; // TODO: replace null with proper value
            bool? includeSize = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetDnclists(includeImportStatus, importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
            Assert.IsInstanceOf<DncListEntityListing> (response, "response is DncListEntityListing"); 
        }
        
        /// <summary>
        /// Test PostDnclists
        /// </summary>
        [Test]
        public void PostDnclistsTest()
        {
            // TODO: add unit test for the method 'PostDnclists'
            DncList body = null; // TODO: replace null with proper value
            
            var response = instance.PostDnclists(body);
            Assert.IsInstanceOf<DncList> (response, "response is DncList"); 
        }
        
        /// <summary>
        /// Test GetDnclist
        /// </summary>
        [Test]
        public void GetDnclistTest()
        {
            // TODO: add unit test for the method 'GetDnclist'
            string dncListId = null; // TODO: replace null with proper value
            bool? includeImportStatus = null; // TODO: replace null with proper value
            bool? importStatus = null; // TODO: replace null with proper value
            bool? includeSize = null; // TODO: replace null with proper value
            
            var response = instance.GetDnclist(dncListId, includeImportStatus, importStatus, includeSize);
            Assert.IsInstanceOf<DncList> (response, "response is DncList"); 
        }
        
        /// <summary>
        /// Test PutDnclist
        /// </summary>
        [Test]
        public void PutDnclistTest()
        {
            // TODO: add unit test for the method 'PutDnclist'
            string dncListId = null; // TODO: replace null with proper value
            DncList body = null; // TODO: replace null with proper value
            
            var response = instance.PutDnclist(dncListId, body);
            Assert.IsInstanceOf<DncList> (response, "response is DncList"); 
        }
        
        /// <summary>
        /// Test DeleteDnclist
        /// </summary>
        [Test]
        public void DeleteDnclistTest()
        {
            // TODO: add unit test for the method 'DeleteDnclist'
            string dncListId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteDnclist(dncListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostDnclistExport
        /// </summary>
        [Test]
        public void PostDnclistExportTest()
        {
            // TODO: add unit test for the method 'PostDnclistExport'
            string dncListId = null; // TODO: replace null with proper value
            
            var response = instance.PostDnclistExport(dncListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetDnclistImportstatus
        /// </summary>
        [Test]
        public void GetDnclistImportstatusTest()
        {
            // TODO: add unit test for the method 'GetDnclistImportstatus'
            string dncListId = null; // TODO: replace null with proper value
            
            var response = instance.GetDnclistImportstatus(dncListId);
            Assert.IsInstanceOf<ImportStatus> (response, "response is ImportStatus"); 
        }
        
        /// <summary>
        /// Test PostDnclistPhonenumbers
        /// </summary>
        [Test]
        public void PostDnclistPhonenumbersTest()
        {
            // TODO: add unit test for the method 'PostDnclistPhonenumbers'
            string dncListId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            
            instance.PostDnclistPhonenumbers(dncListId, body);
             
        }
        
        /// <summary>
        /// Test GetPreviews
        /// </summary>
        [Test]
        public void GetPreviewsTest()
        {
            // TODO: add unit test for the method 'GetPreviews'
            
            var response = instance.GetPreviews();
            Assert.IsInstanceOf<List<Preview>> (response, "response is List<Preview>"); 
        }
        
        /// <summary>
        /// Test GetPreview
        /// </summary>
        [Test]
        public void GetPreviewTest()
        {
            // TODO: add unit test for the method 'GetPreview'
            string previewId = null; // TODO: replace null with proper value
            
            var response = instance.GetPreview(previewId);
            Assert.IsInstanceOf<Preview> (response, "response is Preview"); 
        }
        
        /// <summary>
        /// Test PostPreviewDispositioncall
        /// </summary>
        [Test]
        public void PostPreviewDispositioncallTest()
        {
            // TODO: add unit test for the method 'PostPreviewDispositioncall'
            string previewId = null; // TODO: replace null with proper value
            DialerDispositionCallCommand body = null; // TODO: replace null with proper value
            
            var response = instance.PostPreviewDispositioncall(previewId, body);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostPreviewPlacecall
        /// </summary>
        [Test]
        public void PostPreviewPlacecallTest()
        {
            // TODO: add unit test for the method 'PostPreviewPlacecall'
            string previewId = null; // TODO: replace null with proper value
            DialerPlaceCallCommand body = null; // TODO: replace null with proper value
            
            var response = instance.PostPreviewPlacecall(previewId, body);
            Assert.IsInstanceOf<DialerCall> (response, "response is DialerCall"); 
        }
        
        /// <summary>
        /// Test GetRulesets
        /// </summary>
        [Test]
        public void GetRulesetsTest()
        {
            // TODO: add unit test for the method 'GetRulesets'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetRulesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
            Assert.IsInstanceOf<RuleSetEntityListing> (response, "response is RuleSetEntityListing"); 
        }
        
        /// <summary>
        /// Test PostRulesets
        /// </summary>
        [Test]
        public void PostRulesetsTest()
        {
            // TODO: add unit test for the method 'PostRulesets'
            RuleSet body = null; // TODO: replace null with proper value
            
            var response = instance.PostRulesets(body);
            Assert.IsInstanceOf<RuleSet> (response, "response is RuleSet"); 
        }
        
        /// <summary>
        /// Test GetRuleset
        /// </summary>
        [Test]
        public void GetRulesetTest()
        {
            // TODO: add unit test for the method 'GetRuleset'
            string ruleSetId = null; // TODO: replace null with proper value
            
            var response = instance.GetRuleset(ruleSetId);
            Assert.IsInstanceOf<RuleSet> (response, "response is RuleSet"); 
        }
        
        /// <summary>
        /// Test PutRuleset
        /// </summary>
        [Test]
        public void PutRulesetTest()
        {
            // TODO: add unit test for the method 'PutRuleset'
            string ruleSetId = null; // TODO: replace null with proper value
            RuleSet body = null; // TODO: replace null with proper value
            
            var response = instance.PutRuleset(ruleSetId, body);
            Assert.IsInstanceOf<RuleSet> (response, "response is RuleSet"); 
        }
        
        /// <summary>
        /// Test DeleteRuleset
        /// </summary>
        [Test]
        public void DeleteRulesetTest()
        {
            // TODO: add unit test for the method 'DeleteRuleset'
            string ruleSetId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteRuleset(ruleSetId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSchedulesCampaigns
        /// </summary>
        [Test]
        public void GetSchedulesCampaignsTest()
        {
            // TODO: add unit test for the method 'GetSchedulesCampaigns'
            
            var response = instance.GetSchedulesCampaigns();
            Assert.IsInstanceOf<List<CampaignSchedule>> (response, "response is List<CampaignSchedule>"); 
        }
        
        /// <summary>
        /// Test GetSchedulesCampaign
        /// </summary>
        [Test]
        public void GetSchedulesCampaignTest()
        {
            // TODO: add unit test for the method 'GetSchedulesCampaign'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulesCampaign(campaignId);
            Assert.IsInstanceOf<CampaignSchedule> (response, "response is CampaignSchedule"); 
        }
        
        /// <summary>
        /// Test PutSchedulesCampaign
        /// </summary>
        [Test]
        public void PutSchedulesCampaignTest()
        {
            // TODO: add unit test for the method 'PutSchedulesCampaign'
            string campaignId = null; // TODO: replace null with proper value
            CampaignSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulesCampaign(campaignId, body);
            Assert.IsInstanceOf<CampaignSchedule> (response, "response is CampaignSchedule"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulesCampaign
        /// </summary>
        [Test]
        public void DeleteSchedulesCampaignTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulesCampaign'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulesCampaign(campaignId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSchedulesSequences
        /// </summary>
        [Test]
        public void GetSchedulesSequencesTest()
        {
            // TODO: add unit test for the method 'GetSchedulesSequences'
            
            var response = instance.GetSchedulesSequences();
            Assert.IsInstanceOf<List<SequenceSchedule>> (response, "response is List<SequenceSchedule>"); 
        }
        
        /// <summary>
        /// Test GetSchedulesSequence
        /// </summary>
        [Test]
        public void GetSchedulesSequenceTest()
        {
            // TODO: add unit test for the method 'GetSchedulesSequence'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulesSequence(sequenceId);
            Assert.IsInstanceOf<SequenceSchedule> (response, "response is SequenceSchedule"); 
        }
        
        /// <summary>
        /// Test PutSchedulesSequence
        /// </summary>
        [Test]
        public void PutSchedulesSequenceTest()
        {
            // TODO: add unit test for the method 'PutSchedulesSequence'
            string sequenceId = null; // TODO: replace null with proper value
            SequenceSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulesSequence(sequenceId, body);
            Assert.IsInstanceOf<SequenceSchedule> (response, "response is SequenceSchedule"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulesSequence
        /// </summary>
        [Test]
        public void DeleteSchedulesSequenceTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulesSequence'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulesSequence(sequenceId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetSequences
        /// </summary>
        [Test]
        public void GetSequencesTest()
        {
            // TODO: add unit test for the method 'GetSequences'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string filterType = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetSequences(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
            Assert.IsInstanceOf<CampaignSequenceEntityListing> (response, "response is CampaignSequenceEntityListing"); 
        }
        
        /// <summary>
        /// Test PostSequences
        /// </summary>
        [Test]
        public void PostSequencesTest()
        {
            // TODO: add unit test for the method 'PostSequences'
            CampaignSequence body = null; // TODO: replace null with proper value
            
            var response = instance.PostSequences(body);
            Assert.IsInstanceOf<CampaignSequence> (response, "response is CampaignSequence"); 
        }
        
        /// <summary>
        /// Test GetSequence
        /// </summary>
        [Test]
        public void GetSequenceTest()
        {
            // TODO: add unit test for the method 'GetSequence'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.GetSequence(sequenceId);
            Assert.IsInstanceOf<CampaignSequence> (response, "response is CampaignSequence"); 
        }
        
        /// <summary>
        /// Test PutSequence
        /// </summary>
        [Test]
        public void PutSequenceTest()
        {
            // TODO: add unit test for the method 'PutSequence'
            string sequenceId = null; // TODO: replace null with proper value
            CampaignSequence body = null; // TODO: replace null with proper value
            
            var response = instance.PutSequence(sequenceId, body);
            Assert.IsInstanceOf<CampaignSequence> (response, "response is CampaignSequence"); 
        }
        
        /// <summary>
        /// Test DeleteSequence
        /// </summary>
        [Test]
        public void DeleteSequenceTest()
        {
            // TODO: add unit test for the method 'DeleteSequence'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSequence(sequenceId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetWrapupcodemappings
        /// </summary>
        [Test]
        public void GetWrapupcodemappingsTest()
        {
            // TODO: add unit test for the method 'GetWrapupcodemappings'
            
            var response = instance.GetWrapupcodemappings();
            Assert.IsInstanceOf<WrapUpCodeMapping> (response, "response is WrapUpCodeMapping"); 
        }
        
        /// <summary>
        /// Test PutWrapupcodemappings
        /// </summary>
        [Test]
        public void PutWrapupcodemappingsTest()
        {
            // TODO: add unit test for the method 'PutWrapupcodemappings'
            WrapUpCodeMapping body = null; // TODO: replace null with proper value
            
            var response = instance.PutWrapupcodemappings(body);
            Assert.IsInstanceOf<WrapUpCodeMapping> (response, "response is WrapUpCodeMapping"); 
        }
        
    }

}
