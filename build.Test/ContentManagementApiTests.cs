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
        /// Test PostContentmanagementAuditquery
        /// </summary>
        [Test]
        public void PostContentmanagementAuditqueryTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementAuditquery'
            ContentQueryRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementAuditquery(body);
            Assert.IsInstanceOf<QueryResults> (response, "response is QueryResults"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementDocuments
        /// </summary>
        [Test]
        public void GetContentmanagementDocumentsTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementDocuments'
            string workspaceId = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementDocuments(workspaceId, name, expand, pageSize, pageNumber, sortBy, sortOrder);
            Assert.IsInstanceOf<DocumentEntityListing> (response, "response is DocumentEntityListing"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementDocuments
        /// </summary>
        [Test]
        public void PostContentmanagementDocumentsTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementDocuments'
            DocumentUpload body = null; // TODO: replace null with proper value
            string copySource = null; // TODO: replace null with proper value
            string moveSource = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementDocuments(body, copySource, moveSource, _override);
            Assert.IsInstanceOf<Document> (response, "response is Document"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementDocument
        /// </summary>
        [Test]
        public void GetContentmanagementDocumentTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementDocument'
            string documentId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementDocument(documentId, expand);
            Assert.IsInstanceOf<Document> (response, "response is Document"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementDocument
        /// </summary>
        [Test]
        public void PostContentmanagementDocumentTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementDocument'
            string documentId = null; // TODO: replace null with proper value
            DocumentUpdate body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementDocument(documentId, body, expand, _override);
            Assert.IsInstanceOf<Document> (response, "response is Document"); 
        }
        
        /// <summary>
        /// Test DeleteContentmanagementDocument
        /// </summary>
        [Test]
        public void DeleteContentmanagementDocumentTest()
        {
            // TODO: add unit test for the method 'DeleteContentmanagementDocument'
            string documentId = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            instance.DeleteContentmanagementDocument(documentId, _override);
             
        }
        
        /// <summary>
        /// Test GetContentmanagementDocumentAudits
        /// </summary>
        [Test]
        public void GetContentmanagementDocumentAuditsTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementDocumentAudits'
            string documentId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string transactionFilter = null; // TODO: replace null with proper value
            string level = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementDocumentAudits(documentId, pageSize, pageNumber, transactionFilter, level, sortBy, sortOrder);
            Assert.IsInstanceOf<DocumentAuditEntityListing> (response, "response is DocumentAuditEntityListing"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementDocumentContent
        /// </summary>
        [Test]
        public void GetContentmanagementDocumentContentTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementDocumentContent'
            string documentId = null; // TODO: replace null with proper value
            string disposition = null; // TODO: replace null with proper value
            string contentType = null; // TODO: replace null with proper value
            
            instance.GetContentmanagementDocumentContent(documentId, disposition, contentType);
             
        }
        
        /// <summary>
        /// Test PostContentmanagementDocumentContent
        /// </summary>
        [Test]
        public void PostContentmanagementDocumentContentTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementDocumentContent'
            string documentId = null; // TODO: replace null with proper value
            ReplaceRequest body = null; // TODO: replace null with proper value
            bool? _override = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementDocumentContent(documentId, body, _override);
            Assert.IsInstanceOf<ReplaceResponse> (response, "response is ReplaceResponse"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementQuery
        /// </summary>
        [Test]
        public void GetContentmanagementQueryTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementQuery'
            string queryPhrase = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementQuery(queryPhrase, pageSize, pageNumber, sortBy, sortOrder, expand);
            Assert.IsInstanceOf<QueryResults> (response, "response is QueryResults"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementQuery
        /// </summary>
        [Test]
        public void PostContentmanagementQueryTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementQuery'
            QueryRequest body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementQuery(body, expand);
            Assert.IsInstanceOf<QueryResults> (response, "response is QueryResults"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementSecurityprofiles
        /// </summary>
        [Test]
        public void GetContentmanagementSecurityprofilesTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementSecurityprofiles'
            
            var response = instance.GetContentmanagementSecurityprofiles();
            Assert.IsInstanceOf<SecurityProfileEntityListing> (response, "response is SecurityProfileEntityListing"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementSecurityprofile
        /// </summary>
        [Test]
        public void GetContentmanagementSecurityprofileTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementSecurityprofile'
            string securityProfileId = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementSecurityprofile(securityProfileId);
            Assert.IsInstanceOf<SecurityProfile> (response, "response is SecurityProfile"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementShared
        /// </summary>
        [Test]
        public void GetContentmanagementSharedTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementShared'
            string sharedId = null; // TODO: replace null with proper value
            bool? redirect = null; // TODO: replace null with proper value
            string disposition = null; // TODO: replace null with proper value
            string contentType = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            instance.GetContentmanagementShared(sharedId, redirect, disposition, contentType, expand);
             
        }
        
        /// <summary>
        /// Test GetContentmanagementShares
        /// </summary>
        [Test]
        public void GetContentmanagementSharesTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementShares'
            string entityId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementShares(entityId, expand, pageSize, pageNumber);
            Assert.IsInstanceOf<ShareEntityListing> (response, "response is ShareEntityListing"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementShares
        /// </summary>
        [Test]
        public void PostContentmanagementSharesTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementShares'
            CreateShareRequest body = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementShares(body);
            Assert.IsInstanceOf<CreateShareResponse> (response, "response is CreateShareResponse"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementShare
        /// </summary>
        [Test]
        public void GetContentmanagementShareTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementShare'
            string shareId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementShare(shareId, expand);
            Assert.IsInstanceOf<Share> (response, "response is Share"); 
        }
        
        /// <summary>
        /// Test DeleteContentmanagementShare
        /// </summary>
        [Test]
        public void DeleteContentmanagementShareTest()
        {
            // TODO: add unit test for the method 'DeleteContentmanagementShare'
            string shareId = null; // TODO: replace null with proper value
            
            instance.DeleteContentmanagementShare(shareId);
             
        }
        
        /// <summary>
        /// Test GetContentmanagementStatus
        /// </summary>
        [Test]
        public void GetContentmanagementStatusTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementStatus'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementStatus(pageSize, pageNumber);
            Assert.IsInstanceOf<CommandStatusEntityListing> (response, "response is CommandStatusEntityListing"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementStatu
        /// </summary>
        [Test]
        public void GetContentmanagementStatuTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementStatu'
            string statusId = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementStatu(statusId);
            Assert.IsInstanceOf<CommandStatus> (response, "response is CommandStatus"); 
        }
        
        /// <summary>
        /// Test DeleteContentmanagementStatu
        /// </summary>
        [Test]
        public void DeleteContentmanagementStatuTest()
        {
            // TODO: add unit test for the method 'DeleteContentmanagementStatu'
            string statusId = null; // TODO: replace null with proper value
            
            instance.DeleteContentmanagementStatu(statusId);
             
        }
        
        /// <summary>
        /// Test GetContentmanagementWorkspaces
        /// </summary>
        [Test]
        public void GetContentmanagementWorkspacesTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementWorkspaces'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string access = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementWorkspaces(pageSize, pageNumber, access, expand);
            Assert.IsInstanceOf<WorkspaceEntityListing> (response, "response is WorkspaceEntityListing"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementWorkspaces
        /// </summary>
        [Test]
        public void PostContentmanagementWorkspacesTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementWorkspaces'
            WorkspaceCreate body = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementWorkspaces(body);
            Assert.IsInstanceOf<Workspace> (response, "response is Workspace"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementWorkspace
        /// </summary>
        [Test]
        public void GetContentmanagementWorkspaceTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementWorkspace'
            string workspaceId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementWorkspace(workspaceId, expand);
            Assert.IsInstanceOf<Workspace> (response, "response is Workspace"); 
        }
        
        /// <summary>
        /// Test PutContentmanagementWorkspace
        /// </summary>
        [Test]
        public void PutContentmanagementWorkspaceTest()
        {
            // TODO: add unit test for the method 'PutContentmanagementWorkspace'
            string workspaceId = null; // TODO: replace null with proper value
            Workspace body = null; // TODO: replace null with proper value
            
            var response = instance.PutContentmanagementWorkspace(workspaceId, body);
            Assert.IsInstanceOf<Workspace> (response, "response is Workspace"); 
        }
        
        /// <summary>
        /// Test DeleteContentmanagementWorkspace
        /// </summary>
        [Test]
        public void DeleteContentmanagementWorkspaceTest()
        {
            // TODO: add unit test for the method 'DeleteContentmanagementWorkspace'
            string workspaceId = null; // TODO: replace null with proper value
            string moveChildrenToWorkspaceId = null; // TODO: replace null with proper value
            
            instance.DeleteContentmanagementWorkspace(workspaceId, moveChildrenToWorkspaceId);
             
        }
        
        /// <summary>
        /// Test GetContentmanagementWorkspaceMembers
        /// </summary>
        [Test]
        public void GetContentmanagementWorkspaceMembersTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementWorkspaceMembers'
            string workspaceId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementWorkspaceMembers(workspaceId, pageSize, pageNumber, expand);
            Assert.IsInstanceOf<WorkspaceMemberEntityListing> (response, "response is WorkspaceMemberEntityListing"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementWorkspaceMember
        /// </summary>
        [Test]
        public void GetContentmanagementWorkspaceMemberTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementWorkspaceMember'
            string workspaceId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementWorkspaceMember(workspaceId, memberId, expand);
            Assert.IsInstanceOf<WorkspaceMember> (response, "response is WorkspaceMember"); 
        }
        
        /// <summary>
        /// Test PutContentmanagementWorkspaceMember
        /// </summary>
        [Test]
        public void PutContentmanagementWorkspaceMemberTest()
        {
            // TODO: add unit test for the method 'PutContentmanagementWorkspaceMember'
            string workspaceId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            WorkspaceMember body = null; // TODO: replace null with proper value
            
            var response = instance.PutContentmanagementWorkspaceMember(workspaceId, memberId, body);
            Assert.IsInstanceOf<WorkspaceMember> (response, "response is WorkspaceMember"); 
        }
        
        /// <summary>
        /// Test DeleteContentmanagementWorkspaceMember
        /// </summary>
        [Test]
        public void DeleteContentmanagementWorkspaceMemberTest()
        {
            // TODO: add unit test for the method 'DeleteContentmanagementWorkspaceMember'
            string workspaceId = null; // TODO: replace null with proper value
            string memberId = null; // TODO: replace null with proper value
            
            instance.DeleteContentmanagementWorkspaceMember(workspaceId, memberId);
             
        }
        
        /// <summary>
        /// Test GetContentmanagementWorkspaceTagvalues
        /// </summary>
        [Test]
        public void GetContentmanagementWorkspaceTagvaluesTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementWorkspaceTagvalues'
            string workspaceId = null; // TODO: replace null with proper value
            string value = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementWorkspaceTagvalues(workspaceId, value, pageSize, pageNumber, expand);
            Assert.IsInstanceOf<TagValueEntityListing> (response, "response is TagValueEntityListing"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementWorkspaceTagvalues
        /// </summary>
        [Test]
        public void PostContentmanagementWorkspaceTagvaluesTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementWorkspaceTagvalues'
            string workspaceId = null; // TODO: replace null with proper value
            TagValue body = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementWorkspaceTagvalues(workspaceId, body);
            Assert.IsInstanceOf<TagValue> (response, "response is TagValue"); 
        }
        
        /// <summary>
        /// Test PostContentmanagementWorkspaceTagvaluesQuery
        /// </summary>
        [Test]
        public void PostContentmanagementWorkspaceTagvaluesQueryTest()
        {
            // TODO: add unit test for the method 'PostContentmanagementWorkspaceTagvaluesQuery'
            string workspaceId = null; // TODO: replace null with proper value
            TagQueryRequest body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostContentmanagementWorkspaceTagvaluesQuery(workspaceId, body, expand);
            Assert.IsInstanceOf<TagValueEntityListing> (response, "response is TagValueEntityListing"); 
        }
        
        /// <summary>
        /// Test GetContentmanagementWorkspaceTagvalue
        /// </summary>
        [Test]
        public void GetContentmanagementWorkspaceTagvalueTest()
        {
            // TODO: add unit test for the method 'GetContentmanagementWorkspaceTagvalue'
            string workspaceId = null; // TODO: replace null with proper value
            string tagId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetContentmanagementWorkspaceTagvalue(workspaceId, tagId, expand);
            Assert.IsInstanceOf<TagValue> (response, "response is TagValue"); 
        }
        
        /// <summary>
        /// Test PutContentmanagementWorkspaceTagvalue
        /// </summary>
        [Test]
        public void PutContentmanagementWorkspaceTagvalueTest()
        {
            // TODO: add unit test for the method 'PutContentmanagementWorkspaceTagvalue'
            string workspaceId = null; // TODO: replace null with proper value
            string tagId = null; // TODO: replace null with proper value
            TagValue body = null; // TODO: replace null with proper value
            
            var response = instance.PutContentmanagementWorkspaceTagvalue(workspaceId, tagId, body);
            Assert.IsInstanceOf<TagValue> (response, "response is TagValue"); 
        }
        
        /// <summary>
        /// Test DeleteContentmanagementWorkspaceTagvalue
        /// </summary>
        [Test]
        public void DeleteContentmanagementWorkspaceTagvalueTest()
        {
            // TODO: add unit test for the method 'DeleteContentmanagementWorkspaceTagvalue'
            string workspaceId = null; // TODO: replace null with proper value
            string tagId = null; // TODO: replace null with proper value
            
            instance.DeleteContentmanagementWorkspaceTagvalue(workspaceId, tagId);
             
        }
        
    }

}
