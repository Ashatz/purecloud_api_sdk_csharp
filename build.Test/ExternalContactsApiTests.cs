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
    public class ExternalContactsApiTests
    {
        private ExternalContactsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ExternalContactsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalContactsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ExternalContactsApi> (instance, "instance is a ExternalContactsApi");
        }

        
        /// <summary>
        /// Test GetContacts
        /// </summary>
        [Test]
        public void GetContactsTest()
        {
            // TODO: add unit test for the method 'GetContacts'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string q = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetContacts(pageSize, pageNumber, q, sortOrder);
            Assert.IsInstanceOf<ContactListing> (response, "response is ContactListing"); 
        }
        
        /// <summary>
        /// Test PostContacts
        /// </summary>
        [Test]
        public void PostContactsTest()
        {
            // TODO: add unit test for the method 'PostContacts'
            ExternalContact body = null; // TODO: replace null with proper value
            
            var response = instance.PostContacts(body);
            Assert.IsInstanceOf<ExternalContact> (response, "response is ExternalContact"); 
        }
        
        /// <summary>
        /// Test GetContactsContactId
        /// </summary>
        [Test]
        public void GetContactsContactIdTest()
        {
            // TODO: add unit test for the method 'GetContactsContactId'
            string contactId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactsContactId(contactId);
            Assert.IsInstanceOf<ExternalContact> (response, "response is ExternalContact"); 
        }
        
        /// <summary>
        /// Test PutContactsContactId
        /// </summary>
        [Test]
        public void PutContactsContactIdTest()
        {
            // TODO: add unit test for the method 'PutContactsContactId'
            string contactId = null; // TODO: replace null with proper value
            ExternalContact body = null; // TODO: replace null with proper value
            
            var response = instance.PutContactsContactId(contactId, body);
            Assert.IsInstanceOf<ExternalContact> (response, "response is ExternalContact"); 
        }
        
        /// <summary>
        /// Test DeleteContactsContactId
        /// </summary>
        [Test]
        public void DeleteContactsContactIdTest()
        {
            // TODO: add unit test for the method 'DeleteContactsContactId'
            string contactId = null; // TODO: replace null with proper value
            
            instance.DeleteContactsContactId(contactId);
             
        }
        
        /// <summary>
        /// Test GetContactsContactIdNotes
        /// </summary>
        [Test]
        public void GetContactsContactIdNotesTest()
        {
            // TODO: add unit test for the method 'GetContactsContactIdNotes'
            string contactId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetContactsContactIdNotes(contactId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<NoteListing> (response, "response is NoteListing"); 
        }
        
        /// <summary>
        /// Test PostContactsContactIdNotes
        /// </summary>
        [Test]
        public void PostContactsContactIdNotesTest()
        {
            // TODO: add unit test for the method 'PostContactsContactIdNotes'
            string contactId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PostContactsContactIdNotes(contactId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test GetContactsContactIdNotesNoteId
        /// </summary>
        [Test]
        public void GetContactsContactIdNotesNoteIdTest()
        {
            // TODO: add unit test for the method 'GetContactsContactIdNotesNoteId'
            string contactId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            var response = instance.GetContactsContactIdNotesNoteId(contactId, noteId);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test PutContactsContactIdNotesNoteId
        /// </summary>
        [Test]
        public void PutContactsContactIdNotesNoteIdTest()
        {
            // TODO: add unit test for the method 'PutContactsContactIdNotesNoteId'
            string contactId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PutContactsContactIdNotesNoteId(contactId, noteId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test DeleteContactsContactIdNotesNoteId
        /// </summary>
        [Test]
        public void DeleteContactsContactIdNotesNoteIdTest()
        {
            // TODO: add unit test for the method 'DeleteContactsContactIdNotesNoteId'
            string contactId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            instance.DeleteContactsContactIdNotesNoteId(contactId, noteId);
             
        }
        
        /// <summary>
        /// Test GetOrganizations
        /// </summary>
        [Test]
        public void GetOrganizationsTest()
        {
            // TODO: add unit test for the method 'GetOrganizations'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string q = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizations(pageSize, pageNumber, q, sortOrder);
            Assert.IsInstanceOf<ExternalOrganizationListing> (response, "response is ExternalOrganizationListing"); 
        }
        
        /// <summary>
        /// Test PostOrganizations
        /// </summary>
        [Test]
        public void PostOrganizationsTest()
        {
            // TODO: add unit test for the method 'PostOrganizations'
            ExternalOrganization body = null; // TODO: replace null with proper value
            
            var response = instance.PostOrganizations(body);
            Assert.IsInstanceOf<ExternalOrganization> (response, "response is ExternalOrganization"); 
        }
        
        /// <summary>
        /// Test GetOrganizationsExternalorganizationId
        /// </summary>
        [Test]
        public void GetOrganizationsExternalorganizationIdTest()
        {
            // TODO: add unit test for the method 'GetOrganizationsExternalorganizationId'
            string externalOrganizationId = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizationsExternalorganizationId(externalOrganizationId);
            Assert.IsInstanceOf<ExternalOrganization> (response, "response is ExternalOrganization"); 
        }
        
        /// <summary>
        /// Test PutOrganizationsExternalorganizationId
        /// </summary>
        [Test]
        public void PutOrganizationsExternalorganizationIdTest()
        {
            // TODO: add unit test for the method 'PutOrganizationsExternalorganizationId'
            string externalOrganizationId = null; // TODO: replace null with proper value
            ExternalOrganization body = null; // TODO: replace null with proper value
            
            var response = instance.PutOrganizationsExternalorganizationId(externalOrganizationId, body);
            Assert.IsInstanceOf<ExternalOrganization> (response, "response is ExternalOrganization"); 
        }
        
        /// <summary>
        /// Test DeleteOrganizationsExternalorganizationId
        /// </summary>
        [Test]
        public void DeleteOrganizationsExternalorganizationIdTest()
        {
            // TODO: add unit test for the method 'DeleteOrganizationsExternalorganizationId'
            string externalOrganizationId = null; // TODO: replace null with proper value
            
            instance.DeleteOrganizationsExternalorganizationId(externalOrganizationId);
             
        }
        
        /// <summary>
        /// Test GetOrganizationsExternalorganizationIdContacts
        /// </summary>
        [Test]
        public void GetOrganizationsExternalorganizationIdContactsTest()
        {
            // TODO: add unit test for the method 'GetOrganizationsExternalorganizationIdContacts'
            string externalOrganizationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string q = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizationsExternalorganizationIdContacts(externalOrganizationId, pageSize, pageNumber, q, sortOrder);
            Assert.IsInstanceOf<ContactListing> (response, "response is ContactListing"); 
        }
        
        /// <summary>
        /// Test GetOrganizationsExternalorganizationIdNotes
        /// </summary>
        [Test]
        public void GetOrganizationsExternalorganizationIdNotesTest()
        {
            // TODO: add unit test for the method 'GetOrganizationsExternalorganizationIdNotes'
            string externalOrganizationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizationsExternalorganizationIdNotes(externalOrganizationId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<NoteListing> (response, "response is NoteListing"); 
        }
        
        /// <summary>
        /// Test PostOrganizationsExternalorganizationIdNotes
        /// </summary>
        [Test]
        public void PostOrganizationsExternalorganizationIdNotesTest()
        {
            // TODO: add unit test for the method 'PostOrganizationsExternalorganizationIdNotes'
            string externalOrganizationId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PostOrganizationsExternalorganizationIdNotes(externalOrganizationId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test GetOrganizationsExternalorganizationIdNotesNoteId
        /// </summary>
        [Test]
        public void GetOrganizationsExternalorganizationIdNotesNoteIdTest()
        {
            // TODO: add unit test for the method 'GetOrganizationsExternalorganizationIdNotesNoteId'
            string externalOrganizationId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizationsExternalorganizationIdNotesNoteId(externalOrganizationId, noteId);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test PutOrganizationsExternalorganizationIdNotesNoteId
        /// </summary>
        [Test]
        public void PutOrganizationsExternalorganizationIdNotesNoteIdTest()
        {
            // TODO: add unit test for the method 'PutOrganizationsExternalorganizationIdNotesNoteId'
            string externalOrganizationId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PutOrganizationsExternalorganizationIdNotesNoteId(externalOrganizationId, noteId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test DeleteOrganizationsExternalorganizationIdNotesNoteId
        /// </summary>
        [Test]
        public void DeleteOrganizationsExternalorganizationIdNotesNoteIdTest()
        {
            // TODO: add unit test for the method 'DeleteOrganizationsExternalorganizationIdNotesNoteId'
            string externalOrganizationId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            instance.DeleteOrganizationsExternalorganizationIdNotesNoteId(externalOrganizationId, noteId);
             
        }
        
        /// <summary>
        /// Test GetOrganizationsExternalorganizationIdRelationships
        /// </summary>
        [Test]
        public void GetOrganizationsExternalorganizationIdRelationshipsTest()
        {
            // TODO: add unit test for the method 'GetOrganizationsExternalorganizationIdRelationships'
            string externalOrganizationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetOrganizationsExternalorganizationIdRelationships(externalOrganizationId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<RelationshipListing> (response, "response is RelationshipListing"); 
        }
        
        /// <summary>
        /// Test PostRelationships
        /// </summary>
        [Test]
        public void PostRelationshipsTest()
        {
            // TODO: add unit test for the method 'PostRelationships'
            Relationship body = null; // TODO: replace null with proper value
            
            var response = instance.PostRelationships(body);
            Assert.IsInstanceOf<Relationship> (response, "response is Relationship"); 
        }
        
        /// <summary>
        /// Test GetRelationshipsRelationshipId
        /// </summary>
        [Test]
        public void GetRelationshipsRelationshipIdTest()
        {
            // TODO: add unit test for the method 'GetRelationshipsRelationshipId'
            string relationshipId = null; // TODO: replace null with proper value
            
            var response = instance.GetRelationshipsRelationshipId(relationshipId);
            Assert.IsInstanceOf<Relationship> (response, "response is Relationship"); 
        }
        
        /// <summary>
        /// Test PutRelationshipsRelationshipId
        /// </summary>
        [Test]
        public void PutRelationshipsRelationshipIdTest()
        {
            // TODO: add unit test for the method 'PutRelationshipsRelationshipId'
            string relationshipId = null; // TODO: replace null with proper value
            Relationship body = null; // TODO: replace null with proper value
            
            var response = instance.PutRelationshipsRelationshipId(relationshipId, body);
            Assert.IsInstanceOf<Relationship> (response, "response is Relationship"); 
        }
        
        /// <summary>
        /// Test DeleteRelationshipsRelationshipId
        /// </summary>
        [Test]
        public void DeleteRelationshipsRelationshipIdTest()
        {
            // TODO: add unit test for the method 'DeleteRelationshipsRelationshipId'
            string relationshipId = null; // TODO: replace null with proper value
            
            instance.DeleteRelationshipsRelationshipId(relationshipId);
             
        }
        
    }

}
