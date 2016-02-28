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
        /// Test GetExternalcontactsContacts
        /// </summary>
        [Test]
        public void GetExternalcontactsContactsTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsContacts'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string q = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsContacts(pageSize, pageNumber, q, sortOrder);
            Assert.IsInstanceOf<ContactListing> (response, "response is ContactListing"); 
        }
        
        /// <summary>
        /// Test PostExternalcontactsContacts
        /// </summary>
        [Test]
        public void PostExternalcontactsContactsTest()
        {
            // TODO: add unit test for the method 'PostExternalcontactsContacts'
            ExternalContact body = null; // TODO: replace null with proper value
            
            var response = instance.PostExternalcontactsContacts(body);
            Assert.IsInstanceOf<ExternalContact> (response, "response is ExternalContact"); 
        }
        
        /// <summary>
        /// Test GetExternalcontactsContact
        /// </summary>
        [Test]
        public void GetExternalcontactsContactTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsContact'
            string contactId = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsContact(contactId);
            Assert.IsInstanceOf<ExternalContact> (response, "response is ExternalContact"); 
        }
        
        /// <summary>
        /// Test PutExternalcontactsContact
        /// </summary>
        [Test]
        public void PutExternalcontactsContactTest()
        {
            // TODO: add unit test for the method 'PutExternalcontactsContact'
            string contactId = null; // TODO: replace null with proper value
            ExternalContact body = null; // TODO: replace null with proper value
            
            var response = instance.PutExternalcontactsContact(contactId, body);
            Assert.IsInstanceOf<ExternalContact> (response, "response is ExternalContact"); 
        }
        
        /// <summary>
        /// Test DeleteExternalcontactsContact
        /// </summary>
        [Test]
        public void DeleteExternalcontactsContactTest()
        {
            // TODO: add unit test for the method 'DeleteExternalcontactsContact'
            string contactId = null; // TODO: replace null with proper value
            
            instance.DeleteExternalcontactsContact(contactId);
             
        }
        
        /// <summary>
        /// Test GetExternalcontactsContactNotes
        /// </summary>
        [Test]
        public void GetExternalcontactsContactNotesTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsContactNotes'
            string contactId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsContactNotes(contactId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<NoteListing> (response, "response is NoteListing"); 
        }
        
        /// <summary>
        /// Test PostExternalcontactsContactNotes
        /// </summary>
        [Test]
        public void PostExternalcontactsContactNotesTest()
        {
            // TODO: add unit test for the method 'PostExternalcontactsContactNotes'
            string contactId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PostExternalcontactsContactNotes(contactId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test GetExternalcontactsContactNote
        /// </summary>
        [Test]
        public void GetExternalcontactsContactNoteTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsContactNote'
            string contactId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsContactNote(contactId, noteId);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test PutExternalcontactsContactNote
        /// </summary>
        [Test]
        public void PutExternalcontactsContactNoteTest()
        {
            // TODO: add unit test for the method 'PutExternalcontactsContactNote'
            string contactId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PutExternalcontactsContactNote(contactId, noteId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test DeleteExternalcontactsContactNote
        /// </summary>
        [Test]
        public void DeleteExternalcontactsContactNoteTest()
        {
            // TODO: add unit test for the method 'DeleteExternalcontactsContactNote'
            string contactId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            instance.DeleteExternalcontactsContactNote(contactId, noteId);
             
        }
        
        /// <summary>
        /// Test GetExternalcontactsOrganizations
        /// </summary>
        [Test]
        public void GetExternalcontactsOrganizationsTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsOrganizations'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string q = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsOrganizations(pageSize, pageNumber, q, sortOrder);
            Assert.IsInstanceOf<ExternalOrganizationListing> (response, "response is ExternalOrganizationListing"); 
        }
        
        /// <summary>
        /// Test PostExternalcontactsOrganizations
        /// </summary>
        [Test]
        public void PostExternalcontactsOrganizationsTest()
        {
            // TODO: add unit test for the method 'PostExternalcontactsOrganizations'
            ExternalOrganization body = null; // TODO: replace null with proper value
            
            var response = instance.PostExternalcontactsOrganizations(body);
            Assert.IsInstanceOf<ExternalOrganization> (response, "response is ExternalOrganization"); 
        }
        
        /// <summary>
        /// Test GetExternalcontactsOrganization
        /// </summary>
        [Test]
        public void GetExternalcontactsOrganizationTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsOrganization'
            string externalOrganizationId = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsOrganization(externalOrganizationId);
            Assert.IsInstanceOf<ExternalOrganization> (response, "response is ExternalOrganization"); 
        }
        
        /// <summary>
        /// Test PutExternalcontactsOrganization
        /// </summary>
        [Test]
        public void PutExternalcontactsOrganizationTest()
        {
            // TODO: add unit test for the method 'PutExternalcontactsOrganization'
            string externalOrganizationId = null; // TODO: replace null with proper value
            ExternalOrganization body = null; // TODO: replace null with proper value
            
            var response = instance.PutExternalcontactsOrganization(externalOrganizationId, body);
            Assert.IsInstanceOf<ExternalOrganization> (response, "response is ExternalOrganization"); 
        }
        
        /// <summary>
        /// Test DeleteExternalcontactsOrganization
        /// </summary>
        [Test]
        public void DeleteExternalcontactsOrganizationTest()
        {
            // TODO: add unit test for the method 'DeleteExternalcontactsOrganization'
            string externalOrganizationId = null; // TODO: replace null with proper value
            
            instance.DeleteExternalcontactsOrganization(externalOrganizationId);
             
        }
        
        /// <summary>
        /// Test GetExternalcontactsOrganizationContacts
        /// </summary>
        [Test]
        public void GetExternalcontactsOrganizationContactsTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsOrganizationContacts'
            string externalOrganizationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string q = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsOrganizationContacts(externalOrganizationId, pageSize, pageNumber, q, sortOrder);
            Assert.IsInstanceOf<ContactListing> (response, "response is ContactListing"); 
        }
        
        /// <summary>
        /// Test GetExternalcontactsOrganizationNotes
        /// </summary>
        [Test]
        public void GetExternalcontactsOrganizationNotesTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsOrganizationNotes'
            string externalOrganizationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsOrganizationNotes(externalOrganizationId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<NoteListing> (response, "response is NoteListing"); 
        }
        
        /// <summary>
        /// Test PostExternalcontactsOrganizationNotes
        /// </summary>
        [Test]
        public void PostExternalcontactsOrganizationNotesTest()
        {
            // TODO: add unit test for the method 'PostExternalcontactsOrganizationNotes'
            string externalOrganizationId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PostExternalcontactsOrganizationNotes(externalOrganizationId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test GetExternalcontactsOrganizationNote
        /// </summary>
        [Test]
        public void GetExternalcontactsOrganizationNoteTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsOrganizationNote'
            string externalOrganizationId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsOrganizationNote(externalOrganizationId, noteId);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test PutExternalcontactsOrganizationNote
        /// </summary>
        [Test]
        public void PutExternalcontactsOrganizationNoteTest()
        {
            // TODO: add unit test for the method 'PutExternalcontactsOrganizationNote'
            string externalOrganizationId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            Note body = null; // TODO: replace null with proper value
            
            var response = instance.PutExternalcontactsOrganizationNote(externalOrganizationId, noteId, body);
            Assert.IsInstanceOf<Note> (response, "response is Note"); 
        }
        
        /// <summary>
        /// Test DeleteExternalcontactsOrganizationNote
        /// </summary>
        [Test]
        public void DeleteExternalcontactsOrganizationNoteTest()
        {
            // TODO: add unit test for the method 'DeleteExternalcontactsOrganizationNote'
            string externalOrganizationId = null; // TODO: replace null with proper value
            string noteId = null; // TODO: replace null with proper value
            
            instance.DeleteExternalcontactsOrganizationNote(externalOrganizationId, noteId);
             
        }
        
        /// <summary>
        /// Test GetExternalcontactsOrganizationRelationships
        /// </summary>
        [Test]
        public void GetExternalcontactsOrganizationRelationshipsTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsOrganizationRelationships'
            string externalOrganizationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsOrganizationRelationships(externalOrganizationId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<RelationshipListing> (response, "response is RelationshipListing"); 
        }
        
        /// <summary>
        /// Test PostExternalcontactsRelationships
        /// </summary>
        [Test]
        public void PostExternalcontactsRelationshipsTest()
        {
            // TODO: add unit test for the method 'PostExternalcontactsRelationships'
            Relationship body = null; // TODO: replace null with proper value
            
            var response = instance.PostExternalcontactsRelationships(body);
            Assert.IsInstanceOf<Relationship> (response, "response is Relationship"); 
        }
        
        /// <summary>
        /// Test GetExternalcontactsRelationship
        /// </summary>
        [Test]
        public void GetExternalcontactsRelationshipTest()
        {
            // TODO: add unit test for the method 'GetExternalcontactsRelationship'
            string relationshipId = null; // TODO: replace null with proper value
            
            var response = instance.GetExternalcontactsRelationship(relationshipId);
            Assert.IsInstanceOf<Relationship> (response, "response is Relationship"); 
        }
        
        /// <summary>
        /// Test PutExternalcontactsRelationship
        /// </summary>
        [Test]
        public void PutExternalcontactsRelationshipTest()
        {
            // TODO: add unit test for the method 'PutExternalcontactsRelationship'
            string relationshipId = null; // TODO: replace null with proper value
            Relationship body = null; // TODO: replace null with proper value
            
            var response = instance.PutExternalcontactsRelationship(relationshipId, body);
            Assert.IsInstanceOf<Relationship> (response, "response is Relationship"); 
        }
        
        /// <summary>
        /// Test DeleteExternalcontactsRelationship
        /// </summary>
        [Test]
        public void DeleteExternalcontactsRelationshipTest()
        {
            // TODO: add unit test for the method 'DeleteExternalcontactsRelationship'
            string relationshipId = null; // TODO: replace null with proper value
            
            instance.DeleteExternalcontactsRelationship(relationshipId);
             
        }
        
    }

}
