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
    public class ContentManagementApiTests
    {
        private ContentManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ContentManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ContentManagementApi> (instance, "instance is a ContentManagementApi");
        }

        
        /// <summary>
        /// Test PostAuditquery
        /// </summary>
        [Test]
        public void PostAuditqueryTest()
        {
            // TODO: add unit test for the method 'PostAuditquery'
            ContentQueryRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostAuditquery(body);
            Assert.IsInstanceOf<QueryResults> (response, "response is QueryResults"); 
        }
        
        /// <summary>
        /// Test GetDocuments
        /// </summary>
        [Test]
        public void GetDocumentsTest()
        {
            // TODO: add unit test for the method 'GetDocuments'
            string workspaceId = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetDocuments(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
            Assert.IsInstanceOf<DocumentEntityListing> (response, "response is DocumentEntityListing"); 
        }
        
        /// <summary>
        /// Test PostDocuments
        /// </summary>
        [Test]
        public void PostDocumentsTest()
        {
            // TODO: add unit test for the method 'PostDocuments'
            DocumentUpload body = null; // TODO: replace null with proper value
            string copySource = null; // TODO: replace null with proper value
            string moveSource = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            var response = instance.PostDocuments(body, copySource, moveSource, _override);
            Assert.IsInstanceOf<Document> (response, "response is Document"); 
        }
        
        /// <summary>
        /// Test GetDocumentsDocumentId
        /// </summary>
        [Test]
        public void GetDocumentsDocumentIdTest()
        {
            // TODO: add unit test for the method 'GetDocumentsDocumentId'
            string documentId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetDocumentsDocumentId(documentId, expand);
            Assert.IsInstanceOf<Document> (response, "response is Document"); 
        }
        
        /// <summary>
        /// Test PostDocumentsDocumentId
        /// </summary>
        [Test]
        public void PostDocumentsDocumentIdTest()
        {
            // TODO: add unit test for the method 'PostDocumentsDocumentId'
            string documentId = null; // TODO: replace null with proper value
            DocumentUpdate body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            var response = instance.PostDocumentsDocumentId(documentId, body, expand, _override);
            Assert.IsInstanceOf<Document> (response, "response is Document"); 
        }
        
        /// <summary>
        /// Test DeleteDocumentsDocumentId
        /// </summary>
        [Test]
        public void DeleteDocumentsDocumentIdTest()
        {
            // TODO: add unit test for the method 'DeleteDocumentsDocumentId'
            string documentId = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            instance.DeleteDocumentsDocumentId(documentId, _override);
             
        }
        
        /// <summary>
        /// Test GetDocumentsDocumentIdAudits
        /// </summary>
        [Test]
        public void GetDocumentsDocumentIdAuditsTest()
        {
            // TODO: add unit test for the method 'GetDocumentsDocumentIdAudits'
            string documentId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string transactionFilter = null; // TODO: replace null with proper value
            string level = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetDocumentsDocumentIdAudits(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
            Assert.IsInstanceOf<DocumentAuditEntityListing> (response, "response is DocumentAuditEntityListing"); 
        }
        
        /// <summary>
        /// Test GetDocumentsDocumentIdContent
        /// </summary>
        [Test]
        public void GetDocumentsDocumentIdContentTest()
        {
            // TODO: add unit test for the method 'GetDocumentsDocumentIdContent'
            string documentId = null; // TODO: replace null with proper value
            string disposition = null; // TODO: replace null with proper value
            string contentType = null; // TODO: replace null with proper value
            
            instance.GetDocumentsDocumentIdContent(documentId, disposition, contentType);
             
        }
        
        /// <summary>
        /// Test PostDocumentsDocumentIdContent
        /// </summary>
        [Test]
        public void PostDocumentsDocumentIdContentTest()
        {
            // TODO: add unit test for the method 'PostDocumentsDocumentIdContent'
            string documentId = null; // TODO: replace null with proper value
            ReplaceRequest body = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            var response = instance.PostDocumentsDocumentIdContent(documentId, body, _override);
            Assert.IsInstanceOf<ReplaceResponse> (response, "response is ReplaceResponse"); 
        }
        
        /// <summary>
        /// Test GetQuery
        /// </summary>
        [Test]
        public void GetQueryTest()
        {
            // TODO: add unit test for the method 'GetQuery'
            string queryPhrase = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetQuery(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
            Assert.IsInstanceOf<QueryResults> (response, "response is QueryResults"); 
        }
        
        /// <summary>
        /// Test PostQuery
        /// </summary>
        [Test]
        public void PostQueryTest()
        {
            // TODO: add unit test for the method 'PostQuery'
            QueryRequest body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostQuery(body, expand);
            Assert.IsInstanceOf<QueryResults> (response, "response is QueryResults"); 
        }
        
        /// <summary>
        /// Test GetSecurityprofiles
        /// </summary>
        [Test]
        public void GetSecurityprofilesTest()
        {
            // TODO: add unit test for the method 'GetSecurityprofiles'
            
            var response = instance.GetSecurityprofiles();
            Assert.IsInstanceOf<SecurityProfileEntityListing> (response, "response is SecurityProfileEntityListing"); 
        }
        
        /// <summary>
        /// Test GetSecurityprofilesSecurityprofileId
        /// </summary>
        [Test]
        public void GetSecurityprofilesSecurityprofileIdTest()
        {
            // TODO: add unit test for the method 'GetSecurityprofilesSecurityprofileId'
            string securityProfileId = null; // TODO: replace null with proper value
            
            var response = instance.GetSecurityprofilesSecurityprofileId(securityProfileId);
            Assert.IsInstanceOf<SecurityProfile> (response, "response is SecurityProfile"); 
        }
        
        /// <summary>
        /// Test GetSharedSharedId
        /// </summary>
        [Test]
        public void GetSharedSharedIdTest()
        {
            // TODO: add unit test for the method 'GetSharedSharedId'
            string sharedId = null; // TODO: replace null with proper value
            bool? redirect = null; // TODO: replace null with proper value
            string disposition = null; // TODO: replace null with proper value
            string contentType = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            instance.GetSharedSharedId(sharedId, redirect, disposition, contentType, expand);
             
        }
        
        /// <summary>
        /// Test GetShares
        /// </summary>
        [Test]
        public void GetSharesTest()
        {
            // TODO: add unit test for the method 'GetShares'
            string entityId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetShares(entityId, expand, pageSize, pageNumber);
            Assert.IsInstanceOf<ShareEntityListing> (response, "response is ShareEntityListing"); 
        }
        
        /// <summary>
        /// Test PostShares
        /// </summary>
        [Test]
        public void PostSharesTest()
        {
            // TODO: add unit test for the method 'PostShares'
            CreateShareRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostShares(body);
            Assert.IsInstanceOf<CreateShareResponse> (response, "response is CreateShareResponse"); 
        }
        
        /// <summary>
        /// Test GetSharesShareId
        /// </summary>
        [Test]
        public void GetSharesShareIdTest()
        {
            // TODO: add unit test for the method 'GetSharesShareId'
            string shareId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetSharesShareId(shareId, expand);
            Assert.IsInstanceOf<Share> (response, "response is Share"); 
        }
        
        /// <summary>
        /// Test DeleteSharesShareId
        /// </summary>
        [Test]
        public void DeleteSharesShareIdTest()
        {
            // TODO: add unit test for the method 'DeleteSharesShareId'
            string shareId = null; // TODO: replace null with proper value
            
            instance.DeleteSharesShareId(shareId);
             
        }
        
        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Test]
        public void GetStatusTest()
        {
            // TODO: add unit test for the method 'GetStatus'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetStatus(pageSize, pageNumber);
            Assert.IsInstanceOf<CommandStatusEntityListing> (response, "response is CommandStatusEntityListing"); 
        }
        
        /// <summary>
        /// Test GetStatusStatusId
        /// </summary>
        [Test]
        public void GetStatusStatusIdTest()
        {
            // TODO: add unit test for the method 'GetStatusStatusId'
            string statusId = null; // TODO: replace null with proper value
            
            var response = instance.GetStatusStatusId(statusId);
            Assert.IsInstanceOf<CommandStatus> (response, "response is CommandStatus"); 
        }
        
        /// <summary>
        /// Test DeleteStatusStatusId
        /// </summary>
        [Test]
        public void DeleteStatusStatusIdTest()
        {
            // TODO: add unit test for the method 'DeleteStatusStatusId'
            string statusId = null; // TODO: replace null with proper value
            
            instance.DeleteStatusStatusId(statusId);
             
        }
        
        /// <summary>
        /// Test GetWorkspaces
        /// </summary>
        [Test]
        public void GetWorkspacesTest()
        {
            // TODO: add unit test for the method 'GetWorkspaces'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string access = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetWorkspaces(pageSize, pageNumber, access, expand);
            Assert.IsInstanceOf<WorkspaceEntityListing> (response, "response is WorkspaceEntityListing"); 
        }
        
        /// <summary>
        /// Test PostWorkspaces
        /// </summary>
        [Test]
        public void PostWorkspacesTest()
        {
            // TODO: add unit test for the method 'PostWorkspaces'
            WorkspaceCreate body = null; // TODO: replace null with proper value
            
            var response = instance.PostWorkspaces(body);
            Assert.IsInstanceOf<Workspace> (response, "response is Workspace"); 
        }
        
        /// <summary>
        /// Test GetWorkspacesWorkspaceId
        /// </summary>
        [Test]
        public void GetWorkspacesWorkspaceIdTest()
        {
            // TODO: add unit test for the method 'GetWorkspacesWorkspaceId'
            string workspaceId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetWorkspacesWorkspaceId(workspaceId, expand);
            Assert.IsInstanceOf<Workspace> (response, "response is Workspace"); 
        }
        
        /// <summary>
        /// Test PutWorkspacesWorkspaceId
        /// </summary>
        [Test]
        public void PutWorkspacesWorkspaceIdTest()
        {
            // TODO: add unit test for the method 'PutWorkspacesWorkspaceId'
            string workspaceId = null; // TODO: replace null with proper value
            Workspace body = null; // TODO: replace null with proper value
            
            var response = instance.PutWorkspacesWorkspaceId(workspaceId, body);
            Assert.IsInstanceOf<Workspace> (response, "response is Workspace"); 
        }
        
        /// <summary>
        /// Test DeleteWorkspacesWorkspaceId
        /// </summary>
        [Test]
        public void DeleteWorkspacesWorkspaceIdTest()
        {
            // TODO: add unit test for the method 'DeleteWorkspacesWorkspaceId'
            string workspaceId = null; // TODO: replace null with proper value
            string moveChildrenToWorkspaceId = null; // TODO: replace null with proper value
            
            instance.DeleteWorkspacesWorkspaceId(workspaceId, moveChildrenToWorkspaceId);
             
        }
        
        /// <summary>
        /// Test GetWorkspacesWorkspaceIdMembers
        /// </summary>
        [Test]
        public void GetWorkspacesWorkspaceIdMembersTest()
        {
            // TODO: add unit test for the method 'GetWorkspacesWorkspaceIdMembers'
            string workspaceId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetWorkspacesWorkspaceIdMembers(workspaceId, pageSize, pageNumber, expand);
            Assert.IsInstanceOf<WorkspaceMemberEntityListing> (response, "response is WorkspaceMemberEntityListing"); 
        }
        
        /// <summary>
        /// Test GetWorkspacesWorkspaceIdMembersMemberId
        /// </summary>
        [Test]
        public void GetWorkspacesWorkspaceIdMembersMemberIdTest()
        {
            // TODO: add unit test for the method 'GetWorkspacesWorkspaceIdMembersMemberId'
            string workspaceId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetWorkspacesWorkspaceIdMembersMemberId(workspaceId, memberId, expand);
            Assert.IsInstanceOf<WorkspaceMember> (response, "response is WorkspaceMember"); 
        }
        
        /// <summary>
        /// Test PutWorkspacesWorkspaceIdMembersMemberId
        /// </summary>
        [Test]
        public void PutWorkspacesWorkspaceIdMembersMemberIdTest()
        {
            // TODO: add unit test for the method 'PutWorkspacesWorkspaceIdMembersMemberId'
            string workspaceId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            WorkspaceMember body = null; // TODO: replace null with proper value
            
            var response = instance.PutWorkspacesWorkspaceIdMembersMemberId(workspaceId, memberId, body);
            Assert.IsInstanceOf<WorkspaceMember> (response, "response is WorkspaceMember"); 
        }
        
        /// <summary>
        /// Test DeleteWorkspacesWorkspaceIdMembersMemberId
        /// </summary>
        [Test]
        public void DeleteWorkspacesWorkspaceIdMembersMemberIdTest()
        {
            // TODO: add unit test for the method 'DeleteWorkspacesWorkspaceIdMembersMemberId'
            string workspaceId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            
            instance.DeleteWorkspacesWorkspaceIdMembersMemberId(workspaceId, memberId);
             
        }
        
        /// <summary>
        /// Test GetWorkspacesWorkspaceIdTagvalues
        /// </summary>
        [Test]
        public void GetWorkspacesWorkspaceIdTagvaluesTest()
        {
            // TODO: add unit test for the method 'GetWorkspacesWorkspaceIdTagvalues'
            string workspaceId = null; // TODO: replace null with proper value
            string value = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetWorkspacesWorkspaceIdTagvalues(workspaceId, value, pageSize, pageNumber, expand);
            Assert.IsInstanceOf<TagValueEntityListing> (response, "response is TagValueEntityListing"); 
        }
        
        /// <summary>
        /// Test PostWorkspacesWorkspaceIdTagvalues
        /// </summary>
        [Test]
        public void PostWorkspacesWorkspaceIdTagvaluesTest()
        {
            // TODO: add unit test for the method 'PostWorkspacesWorkspaceIdTagvalues'
            string workspaceId = null; // TODO: replace null with proper value
            TagValue body = null; // TODO: replace null with proper value
            
            var response = instance.PostWorkspacesWorkspaceIdTagvalues(workspaceId, body);
            Assert.IsInstanceOf<TagValue> (response, "response is TagValue"); 
        }
        
        /// <summary>
        /// Test PostWorkspacesWorkspaceIdTagvaluesQuery
        /// </summary>
        [Test]
        public void PostWorkspacesWorkspaceIdTagvaluesQueryTest()
        {
            // TODO: add unit test for the method 'PostWorkspacesWorkspaceIdTagvaluesQuery'
            string workspaceId = null; // TODO: replace null with proper value
            TagQueryRequest body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostWorkspacesWorkspaceIdTagvaluesQuery(workspaceId, body, expand);
            Assert.IsInstanceOf<TagValueEntityListing> (response, "response is TagValueEntityListing"); 
        }
        
        /// <summary>
        /// Test GetWorkspacesWorkspaceIdTagvaluesTagId
        /// </summary>
        [Test]
        public void GetWorkspacesWorkspaceIdTagvaluesTagIdTest()
        {
            // TODO: add unit test for the method 'GetWorkspacesWorkspaceIdTagvaluesTagId'
            string workspaceId = null; // TODO: replace null with proper value
            string tagId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetWorkspacesWorkspaceIdTagvaluesTagId(workspaceId, tagId, expand);
            Assert.IsInstanceOf<TagValue> (response, "response is TagValue"); 
        }
        
        /// <summary>
        /// Test PutWorkspacesWorkspaceIdTagvaluesTagId
        /// </summary>
        [Test]
        public void PutWorkspacesWorkspaceIdTagvaluesTagIdTest()
        {
            // TODO: add unit test for the method 'PutWorkspacesWorkspaceIdTagvaluesTagId'
            string workspaceId = null; // TODO: replace null with proper value
            string tagId = null; // TODO: replace null with proper value
            TagValue body = null; // TODO: replace null with proper value
            
            var response = instance.PutWorkspacesWorkspaceIdTagvaluesTagId(workspaceId, tagId, body);
            Assert.IsInstanceOf<TagValue> (response, "response is TagValue"); 
        }
        
        /// <summary>
        /// Test DeleteWorkspacesWorkspaceIdTagvaluesTagId
        /// </summary>
        [Test]
        public void DeleteWorkspacesWorkspaceIdTagvaluesTagIdTest()
        {
            // TODO: add unit test for the method 'DeleteWorkspacesWorkspaceIdTagvaluesTagId'
            string workspaceId = null; // TODO: replace null with proper value
            string tagId = null; // TODO: replace null with proper value
            
            instance.DeleteWorkspacesWorkspaceIdTagvaluesTagId(workspaceId, tagId);
             
        }
        
    }

}
