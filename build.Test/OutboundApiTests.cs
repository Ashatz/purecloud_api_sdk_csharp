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
        /// Test GetCallabletimesetsCallabletimesetId
        /// </summary>
        [Test]
        public void GetCallabletimesetsCallabletimesetIdTest()
        {
            // TODO: add unit test for the method 'GetCallabletimesetsCallabletimesetId'
            string callableTimeSetId = null; // TODO: replace null with proper value
            
            var response = instance.GetCallabletimesetsCallabletimesetId(callableTimeSetId);
            Assert.IsInstanceOf<CallableTimeSet> (response, "response is CallableTimeSet"); 
        }
        
        /// <summary>
        /// Test PutCallabletimesetsCallabletimesetId
        /// </summary>
        [Test]
        public void PutCallabletimesetsCallabletimesetIdTest()
        {
            // TODO: add unit test for the method 'PutCallabletimesetsCallabletimesetId'
            string callableTimeSetId = null; // TODO: replace null with proper value
            CallableTimeSet body = null; // TODO: replace null with proper value
            
            var response = instance.PutCallabletimesetsCallabletimesetId(callableTimeSetId, body);
            Assert.IsInstanceOf<CallableTimeSet> (response, "response is CallableTimeSet"); 
        }
        
        /// <summary>
        /// Test DeleteCallabletimesetsCallabletimesetId
        /// </summary>
        [Test]
        public void DeleteCallabletimesetsCallabletimesetIdTest()
        {
            // TODO: add unit test for the method 'DeleteCallabletimesetsCallabletimesetId'
            string callableTimeSetId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCallabletimesetsCallabletimesetId(callableTimeSetId);
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
        /// Test GetCallanalysisresponsesetsCallanalysissetId
        /// </summary>
        [Test]
        public void GetCallanalysisresponsesetsCallanalysissetIdTest()
        {
            // TODO: add unit test for the method 'GetCallanalysisresponsesetsCallanalysissetId'
            string callAnalysisSetId = null; // TODO: replace null with proper value
            
            var response = instance.GetCallanalysisresponsesetsCallanalysissetId(callAnalysisSetId);
            Assert.IsInstanceOf<ResponseSet> (response, "response is ResponseSet"); 
        }
        
        /// <summary>
        /// Test PutCallanalysisresponsesetsCallanalysissetId
        /// </summary>
        [Test]
        public void PutCallanalysisresponsesetsCallanalysissetIdTest()
        {
            // TODO: add unit test for the method 'PutCallanalysisresponsesetsCallanalysissetId'
            string callAnalysisSetId = null; // TODO: replace null with proper value
            ResponseSet body = null; // TODO: replace null with proper value
            
            var response = instance.PutCallanalysisresponsesetsCallanalysissetId(callAnalysisSetId, body);
            Assert.IsInstanceOf<ResponseSet> (response, "response is ResponseSet"); 
        }
        
        /// <summary>
        /// Test DeleteCallanalysisresponsesetsCallanalysissetId
        /// </summary>
        [Test]
        public void DeleteCallanalysisresponsesetsCallanalysissetIdTest()
        {
            // TODO: add unit test for the method 'DeleteCallanalysisresponsesetsCallanalysissetId'
            string callAnalysisSetId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCallanalysisresponsesetsCallanalysissetId(callAnalysisSetId);
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
        /// Test GetCampaignsCampaignId
        /// </summary>
        [Test]
        public void GetCampaignsCampaignIdTest()
        {
            // TODO: add unit test for the method 'GetCampaignsCampaignId'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaignsCampaignId(campaignId);
            Assert.IsInstanceOf<Campaign> (response, "response is Campaign"); 
        }
        
        /// <summary>
        /// Test PutCampaignsCampaignId
        /// </summary>
        [Test]
        public void PutCampaignsCampaignIdTest()
        {
            // TODO: add unit test for the method 'PutCampaignsCampaignId'
            string campaignId = null; // TODO: replace null with proper value
            Campaign body = null; // TODO: replace null with proper value
            
            var response = instance.PutCampaignsCampaignId(campaignId, body);
            Assert.IsInstanceOf<Campaign> (response, "response is Campaign"); 
        }
        
        /// <summary>
        /// Test DeleteCampaignsCampaignId
        /// </summary>
        [Test]
        public void DeleteCampaignsCampaignIdTest()
        {
            // TODO: add unit test for the method 'DeleteCampaignsCampaignId'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCampaignsCampaignId(campaignId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PutCampaignsCampaignIdAgentsUserId
        /// </summary>
        [Test]
        public void PutCampaignsCampaignIdAgentsUserIdTest()
        {
            // TODO: add unit test for the method 'PutCampaignsCampaignIdAgentsUserId'
            string campaignId = null; // TODO: replace null with proper value
            string userId = null; // TODO: replace null with proper value
            Agent body = null; // TODO: replace null with proper value
            
            var response = instance.PutCampaignsCampaignIdAgentsUserId(campaignId, userId, body);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostCampaignsCampaignIdCallbackSchedule
        /// </summary>
        [Test]
        public void PostCampaignsCampaignIdCallbackScheduleTest()
        {
            // TODO: add unit test for the method 'PostCampaignsCampaignIdCallbackSchedule'
            string campaignId = null; // TODO: replace null with proper value
            ContactCallbackRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostCampaignsCampaignIdCallbackSchedule(campaignId, body);
            Assert.IsInstanceOf<ContactCallbackRequest> (response, "response is ContactCallbackRequest"); 
        }
        
        /// <summary>
        /// Test GetCampaignsCampaignIdDiagnostics
        /// </summary>
        [Test]
        public void GetCampaignsCampaignIdDiagnosticsTest()
        {
            // TODO: add unit test for the method 'GetCampaignsCampaignIdDiagnostics'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaignsCampaignIdDiagnostics(campaignId);
            Assert.IsInstanceOf<CampaignDiagnostics> (response, "response is CampaignDiagnostics"); 
        }
        
        /// <summary>
        /// Test GetCampaignsCampaignIdStats
        /// </summary>
        [Test]
        public void GetCampaignsCampaignIdStatsTest()
        {
            // TODO: add unit test for the method 'GetCampaignsCampaignIdStats'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetCampaignsCampaignIdStats(campaignId);
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
        /// Test GetContactlistsContactlistId
        /// </summary>
        [Test]
        public void GetContactlistsContactlistIdTest()
        {
            // TODO: add unit test for the method 'GetContactlistsContactlistId'
            string contactListId = null; // TODO: replace null with proper value
            bool? includeImportStatus = null; // TODO: replace null with proper value
            bool? importStatus = null; // TODO: replace null with proper value
            bool? includeSize = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistsContactlistId(contactListId, includeImportStatus, importStatus, includeSize);
            Assert.IsInstanceOf<ContactList> (response, "response is ContactList"); 
        }
        
        /// <summary>
        /// Test PutContactlistsContactlistId
        /// </summary>
        [Test]
        public void PutContactlistsContactlistIdTest()
        {
            // TODO: add unit test for the method 'PutContactlistsContactlistId'
            string contactListId = null; // TODO: replace null with proper value
            ContactList body = null; // TODO: replace null with proper value
            
            var response = instance.PutContactlistsContactlistId(contactListId, body);
            Assert.IsInstanceOf<ContactList> (response, "response is ContactList"); 
        }
        
        /// <summary>
        /// Test DeleteContactlistsContactlistId
        /// </summary>
        [Test]
        public void DeleteContactlistsContactlistIdTest()
        {
            // TODO: add unit test for the method 'DeleteContactlistsContactlistId'
            string contactListId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteContactlistsContactlistId(contactListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostContactlistsContactlistIdContacts
        /// </summary>
        [Test]
        public void PostContactlistsContactlistIdContactsTest()
        {
            // TODO: add unit test for the method 'PostContactlistsContactlistIdContacts'
            string contactListId = null; // TODO: replace null with proper value
            List<Contact> body = null; // TODO: replace null with proper value
            bool? priority = null; // TODO: replace null with proper value
            
            var response = instance.PostContactlistsContactlistIdContacts(contactListId, body, priority);
            Assert.IsInstanceOf<Contact> (response, "response is Contact"); 
        }
        
        /// <summary>
        /// Test GetContactlistsContactlistIdContactsContactId
        /// </summary>
        [Test]
        public void GetContactlistsContactlistIdContactsContactIdTest()
        {
            // TODO: add unit test for the method 'GetContactlistsContactlistIdContactsContactId'
            string contactListId = null; // TODO: replace null with proper value
            string contactId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistsContactlistIdContactsContactId(contactListId, contactId);
            Assert.IsInstanceOf<Contact> (response, "response is Contact"); 
        }
        
        /// <summary>
        /// Test PutContactlistsContactlistIdContactsContactId
        /// </summary>
        [Test]
        public void PutContactlistsContactlistIdContactsContactIdTest()
        {
            // TODO: add unit test for the method 'PutContactlistsContactlistIdContactsContactId'
            string contactListId = null; // TODO: replace null with proper value
            string contactId = null; // TODO: replace null with proper value
            Contact body = null; // TODO: replace null with proper value
            
            var response = instance.PutContactlistsContactlistIdContactsContactId(contactListId, contactId, body);
            Assert.IsInstanceOf<Contact> (response, "response is Contact"); 
        }
        
        /// <summary>
        /// Test DeleteContactlistsContactlistIdContactsContactId
        /// </summary>
        [Test]
        public void DeleteContactlistsContactlistIdContactsContactIdTest()
        {
            // TODO: add unit test for the method 'DeleteContactlistsContactlistIdContactsContactId'
            string contactListId = null; // TODO: replace null with proper value
            string contactId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteContactlistsContactlistIdContactsContactId(contactListId, contactId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostContactlistsContactlistIdExport
        /// </summary>
        [Test]
        public void PostContactlistsContactlistIdExportTest()
        {
            // TODO: add unit test for the method 'PostContactlistsContactlistIdExport'
            string contactListId = null; // TODO: replace null with proper value
            
            var response = instance.PostContactlistsContactlistIdExport(contactListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetContactlistsContactlistIdImportstatus
        /// </summary>
        [Test]
        public void GetContactlistsContactlistIdImportstatusTest()
        {
            // TODO: add unit test for the method 'GetContactlistsContactlistIdImportstatus'
            string contactListId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistsContactlistIdImportstatus(contactListId);
            Assert.IsInstanceOf<ImportStatus> (response, "response is ImportStatus"); 
        }
        
        /// <summary>
        /// Test GetContactlistsContactlistIdCampaignIdPenetrationrate
        /// </summary>
        [Test]
        public void GetContactlistsContactlistIdCampaignIdPenetrationrateTest()
        {
            // TODO: add unit test for the method 'GetContactlistsContactlistIdCampaignIdPenetrationrate'
            string contactListId = null; // TODO: replace null with proper value
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactlistsContactlistIdCampaignIdPenetrationrate(contactListId, campaignId);
            Assert.IsInstanceOf<PenetrationRate> (response, "response is PenetrationRate"); 
        }
        
        /// <summary>
        /// Test PostConversationsConversationIdDnc
        /// </summary>
        [Test]
        public void PostConversationsConversationIdDncTest()
        {
            // TODO: add unit test for the method 'PostConversationsConversationIdDnc'
            string conversationId = null; // TODO: replace null with proper value
            
            instance.PostConversationsConversationIdDnc(conversationId);
             
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
        /// Test GetDnclistsDnclistId
        /// </summary>
        [Test]
        public void GetDnclistsDnclistIdTest()
        {
            // TODO: add unit test for the method 'GetDnclistsDnclistId'
            string dncListId = null; // TODO: replace null with proper value
            bool? includeImportStatus = null; // TODO: replace null with proper value
            bool? importStatus = null; // TODO: replace null with proper value
            bool? includeSize = null; // TODO: replace null with proper value
            
            var response = instance.GetDnclistsDnclistId(dncListId, includeImportStatus, importStatus, includeSize);
            Assert.IsInstanceOf<DncList> (response, "response is DncList"); 
        }
        
        /// <summary>
        /// Test PutDnclistsDnclistId
        /// </summary>
        [Test]
        public void PutDnclistsDnclistIdTest()
        {
            // TODO: add unit test for the method 'PutDnclistsDnclistId'
            string dncListId = null; // TODO: replace null with proper value
            DncList body = null; // TODO: replace null with proper value
            
            var response = instance.PutDnclistsDnclistId(dncListId, body);
            Assert.IsInstanceOf<DncList> (response, "response is DncList"); 
        }
        
        /// <summary>
        /// Test DeleteDnclistsDnclistId
        /// </summary>
        [Test]
        public void DeleteDnclistsDnclistIdTest()
        {
            // TODO: add unit test for the method 'DeleteDnclistsDnclistId'
            string dncListId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteDnclistsDnclistId(dncListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostDnclistsDnclistIdExport
        /// </summary>
        [Test]
        public void PostDnclistsDnclistIdExportTest()
        {
            // TODO: add unit test for the method 'PostDnclistsDnclistIdExport'
            string dncListId = null; // TODO: replace null with proper value
            
            var response = instance.PostDnclistsDnclistIdExport(dncListId);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetDnclistsDnclistIdImportstatus
        /// </summary>
        [Test]
        public void GetDnclistsDnclistIdImportstatusTest()
        {
            // TODO: add unit test for the method 'GetDnclistsDnclistIdImportstatus'
            string dncListId = null; // TODO: replace null with proper value
            
            var response = instance.GetDnclistsDnclistIdImportstatus(dncListId);
            Assert.IsInstanceOf<ImportStatus> (response, "response is ImportStatus"); 
        }
        
        /// <summary>
        /// Test PostDnclistsDnclistIdPhonenumbers
        /// </summary>
        [Test]
        public void PostDnclistsDnclistIdPhonenumbersTest()
        {
            // TODO: add unit test for the method 'PostDnclistsDnclistIdPhonenumbers'
            string dncListId = null; // TODO: replace null with proper value
            List<string> body = null; // TODO: replace null with proper value
            
            instance.PostDnclistsDnclistIdPhonenumbers(dncListId, body);
             
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
        /// Test GetPreviewsPreviewId
        /// </summary>
        [Test]
        public void GetPreviewsPreviewIdTest()
        {
            // TODO: add unit test for the method 'GetPreviewsPreviewId'
            string previewId = null; // TODO: replace null with proper value
            
            var response = instance.GetPreviewsPreviewId(previewId);
            Assert.IsInstanceOf<Preview> (response, "response is Preview"); 
        }
        
        /// <summary>
        /// Test PostPreviewsPreviewIdDispositioncall
        /// </summary>
        [Test]
        public void PostPreviewsPreviewIdDispositioncallTest()
        {
            // TODO: add unit test for the method 'PostPreviewsPreviewIdDispositioncall'
            string previewId = null; // TODO: replace null with proper value
            DialerDispositionCallCommand body = null; // TODO: replace null with proper value
            
            var response = instance.PostPreviewsPreviewIdDispositioncall(previewId, body);
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test PostPreviewsPreviewIdPlacecall
        /// </summary>
        [Test]
        public void PostPreviewsPreviewIdPlacecallTest()
        {
            // TODO: add unit test for the method 'PostPreviewsPreviewIdPlacecall'
            string previewId = null; // TODO: replace null with proper value
            DialerPlaceCallCommand body = null; // TODO: replace null with proper value
            
            var response = instance.PostPreviewsPreviewIdPlacecall(previewId, body);
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
        /// Test GetRulesetsRulesetId
        /// </summary>
        [Test]
        public void GetRulesetsRulesetIdTest()
        {
            // TODO: add unit test for the method 'GetRulesetsRulesetId'
            string ruleSetId = null; // TODO: replace null with proper value
            
            var response = instance.GetRulesetsRulesetId(ruleSetId);
            Assert.IsInstanceOf<RuleSet> (response, "response is RuleSet"); 
        }
        
        /// <summary>
        /// Test PutRulesetsRulesetId
        /// </summary>
        [Test]
        public void PutRulesetsRulesetIdTest()
        {
            // TODO: add unit test for the method 'PutRulesetsRulesetId'
            string ruleSetId = null; // TODO: replace null with proper value
            RuleSet body = null; // TODO: replace null with proper value
            
            var response = instance.PutRulesetsRulesetId(ruleSetId, body);
            Assert.IsInstanceOf<RuleSet> (response, "response is RuleSet"); 
        }
        
        /// <summary>
        /// Test DeleteRulesetsRulesetId
        /// </summary>
        [Test]
        public void DeleteRulesetsRulesetIdTest()
        {
            // TODO: add unit test for the method 'DeleteRulesetsRulesetId'
            string ruleSetId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteRulesetsRulesetId(ruleSetId);
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
        /// Test GetSchedulesCampaignsCampaignId
        /// </summary>
        [Test]
        public void GetSchedulesCampaignsCampaignIdTest()
        {
            // TODO: add unit test for the method 'GetSchedulesCampaignsCampaignId'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulesCampaignsCampaignId(campaignId);
            Assert.IsInstanceOf<CampaignSchedule> (response, "response is CampaignSchedule"); 
        }
        
        /// <summary>
        /// Test PutSchedulesCampaignsCampaignId
        /// </summary>
        [Test]
        public void PutSchedulesCampaignsCampaignIdTest()
        {
            // TODO: add unit test for the method 'PutSchedulesCampaignsCampaignId'
            string campaignId = null; // TODO: replace null with proper value
            CampaignSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulesCampaignsCampaignId(campaignId, body);
            Assert.IsInstanceOf<CampaignSchedule> (response, "response is CampaignSchedule"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulesCampaignsCampaignId
        /// </summary>
        [Test]
        public void DeleteSchedulesCampaignsCampaignIdTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulesCampaignsCampaignId'
            string campaignId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulesCampaignsCampaignId(campaignId);
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
        /// Test GetSchedulesSequencesSequenceId
        /// </summary>
        [Test]
        public void GetSchedulesSequencesSequenceIdTest()
        {
            // TODO: add unit test for the method 'GetSchedulesSequencesSequenceId'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.GetSchedulesSequencesSequenceId(sequenceId);
            Assert.IsInstanceOf<SequenceSchedule> (response, "response is SequenceSchedule"); 
        }
        
        /// <summary>
        /// Test PutSchedulesSequencesSequenceId
        /// </summary>
        [Test]
        public void PutSchedulesSequencesSequenceIdTest()
        {
            // TODO: add unit test for the method 'PutSchedulesSequencesSequenceId'
            string sequenceId = null; // TODO: replace null with proper value
            SequenceSchedule body = null; // TODO: replace null with proper value
            
            var response = instance.PutSchedulesSequencesSequenceId(sequenceId, body);
            Assert.IsInstanceOf<SequenceSchedule> (response, "response is SequenceSchedule"); 
        }
        
        /// <summary>
        /// Test DeleteSchedulesSequencesSequenceId
        /// </summary>
        [Test]
        public void DeleteSchedulesSequencesSequenceIdTest()
        {
            // TODO: add unit test for the method 'DeleteSchedulesSequencesSequenceId'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSchedulesSequencesSequenceId(sequenceId);
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
        /// Test GetSequencesSequenceId
        /// </summary>
        [Test]
        public void GetSequencesSequenceIdTest()
        {
            // TODO: add unit test for the method 'GetSequencesSequenceId'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.GetSequencesSequenceId(sequenceId);
            Assert.IsInstanceOf<CampaignSequence> (response, "response is CampaignSequence"); 
        }
        
        /// <summary>
        /// Test PutSequencesSequenceId
        /// </summary>
        [Test]
        public void PutSequencesSequenceIdTest()
        {
            // TODO: add unit test for the method 'PutSequencesSequenceId'
            string sequenceId = null; // TODO: replace null with proper value
            CampaignSequence body = null; // TODO: replace null with proper value
            
            var response = instance.PutSequencesSequenceId(sequenceId, body);
            Assert.IsInstanceOf<CampaignSequence> (response, "response is CampaignSequence"); 
        }
        
        /// <summary>
        /// Test DeleteSequencesSequenceId
        /// </summary>
        [Test]
        public void DeleteSequencesSequenceIdTest()
        {
            // TODO: add unit test for the method 'DeleteSequencesSequenceId'
            string sequenceId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteSequencesSequenceId(sequenceId);
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
