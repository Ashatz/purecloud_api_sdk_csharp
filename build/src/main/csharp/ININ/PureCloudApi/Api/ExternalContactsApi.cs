using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExternalContactsApi
    {
        
        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ContactListing</returns>
        ContactListing GetContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
  
        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ContactListing</returns>
        ApiResponse<ContactListing> GetContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListing</returns>
        System.Threading.Tasks.Task<ContactListing> GetContactsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
        
        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        ExternalContact PostContacts (ExternalContact body = null);
  
        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> PostContactsWithHttpInfo (ExternalContact body = null);

        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> PostContactsAsync (ExternalContact body = null);

        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostContactsAsyncWithHttpInfo (ExternalContact body = null);
        
        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ExternalContact</returns>
        ExternalContact GetContactsContactId (string contactId);
  
        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> GetContactsContactIdWithHttpInfo (string contactId);

        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> GetContactsContactIdAsync (string contactId);

        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetContactsContactIdAsyncWithHttpInfo (string contactId);
        
        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        ExternalContact PutContactsContactId (string contactId, ExternalContact body = null);
  
        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> PutContactsContactIdWithHttpInfo (string contactId, ExternalContact body = null);

        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> PutContactsContactIdAsync (string contactId, ExternalContact body = null);

        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutContactsContactIdAsyncWithHttpInfo (string contactId, ExternalContact body = null);
        
        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns></returns>
        void DeleteContactsContactId (string contactId);
  
        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteContactsContactIdWithHttpInfo (string contactId);

        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteContactsContactIdAsync (string contactId);

        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteContactsContactIdAsyncWithHttpInfo (string contactId);
        
        /// <summary>
        /// List Notes for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>NoteListing</returns>
        NoteListing GetContactsContactIdNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
  
        /// <summary>
        /// List Notes for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of NoteListing</returns>
        ApiResponse<NoteListing> GetContactsContactIdNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List Notes for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of NoteListing</returns>
        System.Threading.Tasks.Task<NoteListing> GetContactsContactIdNotesAsync (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List Notes for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetContactsContactIdNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        Note PostContactsContactIdNotes (string contactId, Note body = null);
  
        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PostContactsContactIdNotesWithHttpInfo (string contactId, Note body = null);

        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PostContactsContactIdNotesAsync (string contactId, Note body = null);

        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PostContactsContactIdNotesAsyncWithHttpInfo (string contactId, Note body = null);
        
        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Note</returns>
        Note GetContactsContactIdNotesNoteId (string contactId, string noteId);
  
        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> GetContactsContactIdNotesNoteIdWithHttpInfo (string contactId, string noteId);

        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> GetContactsContactIdNotesNoteIdAsync (string contactId, string noteId);

        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> GetContactsContactIdNotesNoteIdAsyncWithHttpInfo (string contactId, string noteId);
        
        /// <summary>
        /// Update a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Note</returns>
        Note PutContactsContactIdNotesNoteId (string contactId, string noteId, Note body = null);
  
        /// <summary>
        /// Update a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PutContactsContactIdNotesNoteIdWithHttpInfo (string contactId, string noteId, Note body = null);

        /// <summary>
        /// Update a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PutContactsContactIdNotesNoteIdAsync (string contactId, string noteId, Note body = null);

        /// <summary>
        /// Update a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PutContactsContactIdNotesNoteIdAsyncWithHttpInfo (string contactId, string noteId, Note body = null);
        
        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns></returns>
        void DeleteContactsContactIdNotesNoteId (string contactId, string noteId);
  
        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteContactsContactIdNotesNoteIdWithHttpInfo (string contactId, string noteId);

        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteContactsContactIdNotesNoteIdAsync (string contactId, string noteId);

        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteContactsContactIdNotesNoteIdAsyncWithHttpInfo (string contactId, string noteId);
        
        /// <summary>
        /// Search for External Organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">Search query</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ExternalOrganizationListing</returns>
        ExternalOrganizationListing GetOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
  
        /// <summary>
        /// Search for External Organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">Search query</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ExternalOrganizationListing</returns>
        ApiResponse<ExternalOrganizationListing> GetOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

        /// <summary>
        /// Search for External Organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">Search query</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ExternalOrganizationListing</returns>
        System.Threading.Tasks.Task<ExternalOrganizationListing> GetOrganizationsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

        /// <summary>
        /// Search for External Organizations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">Search query</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
        
        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PostOrganizations (ExternalOrganization body = null);
  
        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PostOrganizationsWithHttpInfo (ExternalOrganization body = null);

        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PostOrganizationsAsync (ExternalOrganization body = null);

        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostOrganizationsAsyncWithHttpInfo (ExternalOrganization body = null);
        
        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization GetOrganizationsExternalorganizationId (string externalOrganizationId);
  
        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> GetOrganizationsExternalorganizationIdWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> GetOrganizationsExternalorganizationIdAsync (string externalOrganizationId);

        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> GetOrganizationsExternalorganizationIdAsyncWithHttpInfo (string externalOrganizationId);
        
        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PutOrganizationsExternalorganizationId (string externalOrganizationId, ExternalOrganization body = null);
  
        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PutOrganizationsExternalorganizationIdWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null);

        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PutOrganizationsExternalorganizationIdAsync (string externalOrganizationId, ExternalOrganization body = null);

        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutOrganizationsExternalorganizationIdAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null);
        
        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns></returns>
        void DeleteOrganizationsExternalorganizationId (string externalOrganizationId);
  
        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrganizationsExternalorganizationIdWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrganizationsExternalorganizationIdAsync (string externalOrganizationId);

        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrganizationsExternalorganizationIdAsyncWithHttpInfo (string externalOrganizationId);
        
        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ContactListing</returns>
        ContactListing GetOrganizationsExternalorganizationIdContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
  
        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ContactListing</returns>
        ApiResponse<ContactListing> GetOrganizationsExternalorganizationIdContactsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListing</returns>
        System.Threading.Tasks.Task<ContactListing> GetOrganizationsExternalorganizationIdContactsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

        /// <summary>
        /// Search for External Contacts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetOrganizationsExternalorganizationIdContactsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
        
        /// <summary>
        /// List Notes for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>NoteListing</returns>
        NoteListing GetOrganizationsExternalorganizationIdNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
  
        /// <summary>
        /// List Notes for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of NoteListing</returns>
        ApiResponse<NoteListing> GetOrganizationsExternalorganizationIdNotesWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List Notes for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of NoteListing</returns>
        System.Threading.Tasks.Task<NoteListing> GetOrganizationsExternalorganizationIdNotesAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// List Notes for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetOrganizationsExternalorganizationIdNotesAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        Note PostOrganizationsExternalorganizationIdNotes (string externalOrganizationId, Note body = null);
  
        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PostOrganizationsExternalorganizationIdNotesWithHttpInfo (string externalOrganizationId, Note body = null);

        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PostOrganizationsExternalorganizationIdNotesAsync (string externalOrganizationId, Note body = null);

        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PostOrganizationsExternalorganizationIdNotesAsyncWithHttpInfo (string externalOrganizationId, Note body = null);
        
        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Note</returns>
        Note GetOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId);
  
        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> GetOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo (string externalOrganizationId, string noteId);

        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> GetOrganizationsExternalorganizationIdNotesNoteIdAsync (string externalOrganizationId, string noteId);

        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> GetOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo (string externalOrganizationId, string noteId);
        
        /// <summary>
        /// Update a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Note</returns>
        Note PutOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId, Note body = null);
  
        /// <summary>
        /// Update a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PutOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo (string externalOrganizationId, string noteId, Note body = null);

        /// <summary>
        /// Update a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PutOrganizationsExternalorganizationIdNotesNoteIdAsync (string externalOrganizationId, string noteId, Note body = null);

        /// <summary>
        /// Update a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PutOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body = null);
        
        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns></returns>
        void DeleteOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId);
  
        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrganizationsExternalorganizationIdNotesNoteIdAsync (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo (string externalOrganizationId, string noteId);
        
        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>RelationshipListing</returns>
        RelationshipListing GetOrganizationsExternalorganizationIdRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
  
        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of RelationshipListing</returns>
        ApiResponse<RelationshipListing> GetOrganizationsExternalorganizationIdRelationshipsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of RelationshipListing</returns>
        System.Threading.Tasks.Task<RelationshipListing> GetOrganizationsExternalorganizationIdRelationshipsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (RelationshipListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<RelationshipListing>> GetOrganizationsExternalorganizationIdRelationshipsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        
        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        Relationship PostRelationships (Relationship body = null);
  
        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> PostRelationshipsWithHttpInfo (Relationship body = null);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> PostRelationshipsAsync (Relationship body = null);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PostRelationshipsAsyncWithHttpInfo (Relationship body = null);
        
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Relationship</returns>
        Relationship GetRelationshipsRelationshipId (string relationshipId);
  
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> GetRelationshipsRelationshipIdWithHttpInfo (string relationshipId);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> GetRelationshipsRelationshipIdAsync (string relationshipId);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> GetRelationshipsRelationshipIdAsyncWithHttpInfo (string relationshipId);
        
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        Relationship PutRelationshipsRelationshipId (string relationshipId, Relationship body = null);
  
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> PutRelationshipsRelationshipIdWithHttpInfo (string relationshipId, Relationship body = null);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> PutRelationshipsRelationshipIdAsync (string relationshipId, Relationship body = null);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PutRelationshipsRelationshipIdAsyncWithHttpInfo (string relationshipId, Relationship body = null);
        
        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns></returns>
        void DeleteRelationshipsRelationshipId (string relationshipId);
  
        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRelationshipsRelationshipIdWithHttpInfo (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteRelationshipsRelationshipIdAsync (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRelationshipsRelationshipIdAsyncWithHttpInfo (string relationshipId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExternalContactsApi : IExternalContactsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExternalContactsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExternalContactsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ContactListing</returns>
        public ContactListing GetContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = GetContactsWithHttpInfo(pageSize, pageNumber, q, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ContactListing</returns>
        public ApiResponse< ContactListing > GetContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (q != null) queryParams.Add("q", Configuration.ApiClient.ParameterToString(q)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListing)));
            
        }
    
        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListing</returns>
        public async System.Threading.Tasks.Task<ContactListing> GetContactsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = await GetContactsAsyncWithHttpInfo(pageSize, pageNumber, q, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (q != null) queryParams.Add("q", Configuration.ApiClient.ParameterToString(q)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContacts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListing)));
            
        }
        
        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param> 
        /// <returns>ExternalContact</returns>
        public ExternalContact PostContacts (ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = PostContactsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > PostContactsWithHttpInfo (ExternalContact body = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
    
        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> PostContactsAsync (ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = await PostContactsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostContactsAsyncWithHttpInfo (ExternalContact body = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContacts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
        
        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns>ExternalContact</returns>
        public ExternalContact GetContactsContactId (string contactId)
        {
             ApiResponse<ExternalContact> response = GetContactsContactIdWithHttpInfo(contactId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > GetContactsContactIdWithHttpInfo (string contactId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetContactsContactId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactsContactId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
    
        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> GetContactsContactIdAsync (string contactId)
        {
             ApiResponse<ExternalContact> response = await GetContactsContactIdAsyncWithHttpInfo(contactId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetContactsContactIdAsyncWithHttpInfo (string contactId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetContactsContactId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactsContactId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
        
        /// <summary>
        /// Update a externalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ExternalContact</returns>
        public ExternalContact PutContactsContactId (string contactId, ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = PutContactsContactIdWithHttpInfo(contactId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a externalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > PutContactsContactIdWithHttpInfo (string contactId, ExternalContact body = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutContactsContactId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactsContactId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
    
        /// <summary>
        /// Update a externalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> PutContactsContactIdAsync (string contactId, ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = await PutContactsContactIdAsyncWithHttpInfo(contactId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a externalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutContactsContactIdAsyncWithHttpInfo (string contactId, ExternalContact body = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PutContactsContactId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactsContactId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
        
        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns></returns>
        public void DeleteContactsContactId (string contactId)
        {
             DeleteContactsContactIdWithHttpInfo(contactId);
        }

        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteContactsContactIdWithHttpInfo (string contactId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteContactsContactId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteContactsContactIdAsync (string contactId)
        {
             await DeleteContactsContactIdAsyncWithHttpInfo(contactId);

        }

        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteContactsContactIdAsyncWithHttpInfo (string contactId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling DeleteContactsContactId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// List Notes for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>NoteListing</returns>
        public NoteListing GetContactsContactIdNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = GetContactsContactIdNotesWithHttpInfo(contactId, pageSize, pageNumber, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// List Notes for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of NoteListing</returns>
        public ApiResponse< NoteListing > GetContactsContactIdNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetContactsContactIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<NoteListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NoteListing) Configuration.ApiClient.Deserialize(response, typeof(NoteListing)));
            
        }
    
        /// <summary>
        /// List Notes for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of NoteListing</returns>
        public async System.Threading.Tasks.Task<NoteListing> GetContactsContactIdNotesAsync (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = await GetContactsContactIdNotesAsyncWithHttpInfo(contactId, pageSize, pageNumber, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// List Notes for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetContactsContactIdNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetContactsContactIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<NoteListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NoteListing) Configuration.ApiClient.Deserialize(response, typeof(NoteListing)));
            
        }
        
        /// <summary>
        /// Create a Note for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>Note</returns>
        public Note PostContactsContactIdNotes (string contactId, Note body = null)
        {
             ApiResponse<Note> response = PostContactsContactIdNotesWithHttpInfo(contactId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a Note for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PostContactsContactIdNotesWithHttpInfo (string contactId, Note body = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostContactsContactIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContactsContactIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactsContactIdNotes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
    
        /// <summary>
        /// Create a Note for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PostContactsContactIdNotesAsync (string contactId, Note body = null)
        {
             ApiResponse<Note> response = await PostContactsContactIdNotesAsyncWithHttpInfo(contactId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a Note for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostContactsContactIdNotesAsyncWithHttpInfo (string contactId, Note body = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PostContactsContactIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostContactsContactIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostContactsContactIdNotes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
        
        /// <summary>
        /// Fetch a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>Note</returns>
        public Note GetContactsContactIdNotesNoteId (string contactId, string noteId)
        {
             ApiResponse<Note> response = GetContactsContactIdNotesNoteIdWithHttpInfo(contactId, noteId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > GetContactsContactIdNotesNoteIdWithHttpInfo (string contactId, string noteId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetContactsContactIdNotesNoteId");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetContactsContactIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
    
        /// <summary>
        /// Fetch a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> GetContactsContactIdNotesNoteIdAsync (string contactId, string noteId)
        {
             ApiResponse<Note> response = await GetContactsContactIdNotesNoteIdAsyncWithHttpInfo(contactId, noteId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> GetContactsContactIdNotesNoteIdAsyncWithHttpInfo (string contactId, string noteId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetContactsContactIdNotesNoteId");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling GetContactsContactIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetContactsContactIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
        
        /// <summary>
        /// Update a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <param name="body">Note</param> 
        /// <returns>Note</returns>
        public Note PutContactsContactIdNotesNoteId (string contactId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = PutContactsContactIdNotesNoteIdWithHttpInfo(contactId, noteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <param name="body">Note</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PutContactsContactIdNotesNoteIdWithHttpInfo (string contactId, string noteId, Note body = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutContactsContactIdNotesNoteId");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutContactsContactIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutContactsContactIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactsContactIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
    
        /// <summary>
        /// Update a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PutContactsContactIdNotesNoteIdAsync (string contactId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = await PutContactsContactIdNotesNoteIdAsyncWithHttpInfo(contactId, noteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutContactsContactIdNotesNoteIdAsyncWithHttpInfo (string contactId, string noteId, Note body = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PutContactsContactIdNotesNoteId");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling PutContactsContactIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutContactsContactIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutContactsContactIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
        
        /// <summary>
        /// Delete a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns></returns>
        public void DeleteContactsContactIdNotesNoteId (string contactId, string noteId)
        {
             DeleteContactsContactIdNotesNoteIdWithHttpInfo(contactId, noteId);
        }

        /// <summary>
        /// Delete a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteContactsContactIdNotesNoteIdWithHttpInfo (string contactId, string noteId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteContactsContactIdNotesNoteId");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteContactsContactIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteContactsContactIdNotesNoteIdAsync (string contactId, string noteId)
        {
             await DeleteContactsContactIdNotesNoteIdAsyncWithHttpInfo(contactId, noteId);

        }

        /// <summary>
        /// Delete a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteContactsContactIdNotesNoteIdAsyncWithHttpInfo (string contactId, string noteId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling DeleteContactsContactIdNotesNoteId");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling DeleteContactsContactIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/contacts/{contactId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (contactId != null) pathParams.Add("contactId", Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteContactsContactIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search for External Organizations 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="q">Search query</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ExternalOrganizationListing</returns>
        public ExternalOrganizationListing GetOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ExternalOrganizationListing> response = GetOrganizationsWithHttpInfo(pageSize, pageNumber, q, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Search for External Organizations 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="q">Search query</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ExternalOrganizationListing</returns>
        public ApiResponse< ExternalOrganizationListing > GetOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/organizations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (q != null) queryParams.Add("q", Configuration.ApiClient.ParameterToString(q)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalOrganizationListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganizationListing) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganizationListing)));
            
        }
    
        /// <summary>
        /// Search for External Organizations 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">Search query</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ExternalOrganizationListing</returns>
        public async System.Threading.Tasks.Task<ExternalOrganizationListing> GetOrganizationsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ExternalOrganizationListing> response = await GetOrganizationsAsyncWithHttpInfo(pageSize, pageNumber, q, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Search for External Organizations 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">Search query</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ExternalOrganizationListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/organizations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (q != null) queryParams.Add("q", Configuration.ApiClient.ParameterToString(q)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganizationListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganizationListing) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganizationListing)));
            
        }
        
        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization PostOrganizations (ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = PostOrganizationsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PostOrganizationsWithHttpInfo (ExternalOrganization body = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/organizations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
    
        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> PostOrganizationsAsync (ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = await PostOrganizationsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostOrganizationsAsyncWithHttpInfo (ExternalOrganization body = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/organizations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
        
        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization GetOrganizationsExternalorganizationId (string externalOrganizationId)
        {
             ApiResponse<ExternalOrganization> response = GetOrganizationsExternalorganizationIdWithHttpInfo(externalOrganizationId);
             return response.Data;
        }

        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > GetOrganizationsExternalorganizationIdWithHttpInfo (string externalOrganizationId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetOrganizationsExternalorganizationId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
    
        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> GetOrganizationsExternalorganizationIdAsync (string externalOrganizationId)
        {
             ApiResponse<ExternalOrganization> response = await GetOrganizationsExternalorganizationIdAsyncWithHttpInfo(externalOrganizationId);
             return response.Data;

        }

        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> GetOrganizationsExternalorganizationIdAsyncWithHttpInfo (string externalOrganizationId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetOrganizationsExternalorganizationId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
        
        /// <summary>
        /// Update an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization PutOrganizationsExternalorganizationId (string externalOrganizationId, ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = PutOrganizationsExternalorganizationIdWithHttpInfo(externalOrganizationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PutOrganizationsExternalorganizationIdWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutOrganizationsExternalorganizationId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
    
        /// <summary>
        /// Update an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> PutOrganizationsExternalorganizationIdAsync (string externalOrganizationId, ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = await PutOrganizationsExternalorganizationIdAsyncWithHttpInfo(externalOrganizationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutOrganizationsExternalorganizationIdAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling PutOrganizationsExternalorganizationId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
        
        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns></returns>
        public void DeleteOrganizationsExternalorganizationId (string externalOrganizationId)
        {
             DeleteOrganizationsExternalorganizationIdWithHttpInfo(externalOrganizationId);
        }

        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrganizationsExternalorganizationIdWithHttpInfo (string externalOrganizationId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteOrganizationsExternalorganizationId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrganizationsExternalorganizationIdAsync (string externalOrganizationId)
        {
             await DeleteOrganizationsExternalorganizationIdAsyncWithHttpInfo(externalOrganizationId);

        }

        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrganizationsExternalorganizationIdAsyncWithHttpInfo (string externalOrganizationId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling DeleteOrganizationsExternalorganizationId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ContactListing</returns>
        public ContactListing GetOrganizationsExternalorganizationIdContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = GetOrganizationsExternalorganizationIdContactsWithHttpInfo(externalOrganizationId, pageSize, pageNumber, q, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ContactListing</returns>
        public ApiResponse< ContactListing > GetOrganizationsExternalorganizationIdContactsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetOrganizationsExternalorganizationIdContacts");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (q != null) queryParams.Add("q", Configuration.ApiClient.ParameterToString(q)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ContactListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListing)));
            
        }
    
        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ContactListing</returns>
        public async System.Threading.Tasks.Task<ContactListing> GetOrganizationsExternalorganizationIdContactsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = await GetOrganizationsExternalorganizationIdContactsAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, q, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Search for External Contacts 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="q">User supplied search keywords (no special syntax is currently supported)</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ContactListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetOrganizationsExternalorganizationIdContactsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetOrganizationsExternalorganizationIdContacts");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/contacts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (q != null) queryParams.Add("q", Configuration.ApiClient.ParameterToString(q)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdContacts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListing)));
            
        }
        
        /// <summary>
        /// List Notes for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>NoteListing</returns>
        public NoteListing GetOrganizationsExternalorganizationIdNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = GetOrganizationsExternalorganizationIdNotesWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// List Notes for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of NoteListing</returns>
        public ApiResponse< NoteListing > GetOrganizationsExternalorganizationIdNotesWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetOrganizationsExternalorganizationIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<NoteListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NoteListing) Configuration.ApiClient.Deserialize(response, typeof(NoteListing)));
            
        }
    
        /// <summary>
        /// List Notes for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of NoteListing</returns>
        public async System.Threading.Tasks.Task<NoteListing> GetOrganizationsExternalorganizationIdNotesAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = await GetOrganizationsExternalorganizationIdNotesAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// List Notes for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (NoteListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetOrganizationsExternalorganizationIdNotesAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetOrganizationsExternalorganizationIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<NoteListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NoteListing) Configuration.ApiClient.Deserialize(response, typeof(NoteListing)));
            
        }
        
        /// <summary>
        /// Create a Note for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>Note</returns>
        public Note PostOrganizationsExternalorganizationIdNotes (string externalOrganizationId, Note body = null)
        {
             ApiResponse<Note> response = PostOrganizationsExternalorganizationIdNotesWithHttpInfo(externalOrganizationId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a Note for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PostOrganizationsExternalorganizationIdNotesWithHttpInfo (string externalOrganizationId, Note body = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PostOrganizationsExternalorganizationIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostOrganizationsExternalorganizationIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostOrganizationsExternalorganizationIdNotes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
    
        /// <summary>
        /// Create a Note for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PostOrganizationsExternalorganizationIdNotesAsync (string externalOrganizationId, Note body = null)
        {
             ApiResponse<Note> response = await PostOrganizationsExternalorganizationIdNotesAsyncWithHttpInfo(externalOrganizationId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a Note for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostOrganizationsExternalorganizationIdNotesAsyncWithHttpInfo (string externalOrganizationId, Note body = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling PostOrganizationsExternalorganizationIdNotes");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostOrganizationsExternalorganizationIdNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostOrganizationsExternalorganizationIdNotes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
        
        /// <summary>
        /// Fetch a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>Note</returns>
        public Note GetOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId)
        {
             ApiResponse<Note> response = GetOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo(externalOrganizationId, noteId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > GetOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo (string externalOrganizationId, string noteId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetOrganizationsExternalorganizationIdNotesNoteId");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetOrganizationsExternalorganizationIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
    
        /// <summary>
        /// Fetch a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> GetOrganizationsExternalorganizationIdNotesNoteIdAsync (string externalOrganizationId, string noteId)
        {
             ApiResponse<Note> response = await GetOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo(externalOrganizationId, noteId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> GetOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo (string externalOrganizationId, string noteId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetOrganizationsExternalorganizationIdNotesNoteId");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling GetOrganizationsExternalorganizationIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
        
        /// <summary>
        /// Update a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <param name="body">Note</param> 
        /// <returns>Note</returns>
        public Note PutOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = PutOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo(externalOrganizationId, noteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <param name="body">Note</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PutOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo (string externalOrganizationId, string noteId, Note body = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutOrganizationsExternalorganizationIdNotesNoteId");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutOrganizationsExternalorganizationIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
    
        /// <summary>
        /// Update a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of Note</returns>
        public async System.Threading.Tasks.Task<Note> PutOrganizationsExternalorganizationIdNotesNoteIdAsync (string externalOrganizationId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = await PutOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo(externalOrganizationId, noteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling PutOrganizationsExternalorganizationIdNotesNoteId");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling PutOrganizationsExternalorganizationIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutOrganizationsExternalorganizationIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Note>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Note) Configuration.ApiClient.Deserialize(response, typeof(Note)));
            
        }
        
        /// <summary>
        /// Delete a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns></returns>
        public void DeleteOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId)
        {
             DeleteOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo(externalOrganizationId, noteId);
        }

        /// <summary>
        /// Delete a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrganizationsExternalorganizationIdNotesNoteIdWithHttpInfo (string externalOrganizationId, string noteId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteOrganizationsExternalorganizationIdNotesNoteId");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteOrganizationsExternalorganizationIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrganizationsExternalorganizationIdNotesNoteIdAsync (string externalOrganizationId, string noteId)
        {
             await DeleteOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo(externalOrganizationId, noteId);

        }

        /// <summary>
        /// Delete a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrganizationsExternalorganizationIdNotesNoteIdAsyncWithHttpInfo (string externalOrganizationId, string noteId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling DeleteOrganizationsExternalorganizationIdNotesNoteId");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling DeleteOrganizationsExternalorganizationIdNotesNoteId");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            if (noteId != null) pathParams.Add("noteId", Configuration.ApiClient.ParameterToString(noteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationIdNotesNoteId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteOrganizationsExternalorganizationIdNotesNoteId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>RelationshipListing</returns>
        public RelationshipListing GetOrganizationsExternalorganizationIdRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<RelationshipListing> response = GetOrganizationsExternalorganizationIdRelationshipsWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of RelationshipListing</returns>
        public ApiResponse< RelationshipListing > GetOrganizationsExternalorganizationIdRelationshipsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetOrganizationsExternalorganizationIdRelationships");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/relationships";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RelationshipListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RelationshipListing) Configuration.ApiClient.Deserialize(response, typeof(RelationshipListing)));
            
        }
    
        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of RelationshipListing</returns>
        public async System.Threading.Tasks.Task<RelationshipListing> GetOrganizationsExternalorganizationIdRelationshipsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<RelationshipListing> response = await GetOrganizationsExternalorganizationIdRelationshipsAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (RelationshipListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RelationshipListing>> GetOrganizationsExternalorganizationIdRelationshipsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetOrganizationsExternalorganizationIdRelationships");
            
    
            var path_ = "/api/v1/externalcontacts/organizations/{externalOrganizationId}/relationships";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (externalOrganizationId != null) pathParams.Add("externalOrganizationId", Configuration.ApiClient.ParameterToString(externalOrganizationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOrganizationsExternalorganizationIdRelationships: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RelationshipListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RelationshipListing) Configuration.ApiClient.Deserialize(response, typeof(RelationshipListing)));
            
        }
        
        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param> 
        /// <returns>Relationship</returns>
        public Relationship PostRelationships (Relationship body = null)
        {
             ApiResponse<Relationship> response = PostRelationshipsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param> 
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > PostRelationshipsWithHttpInfo (Relationship body = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/relationships";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
    
        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> PostRelationshipsAsync (Relationship body = null)
        {
             ApiResponse<Relationship> response = await PostRelationshipsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PostRelationshipsAsyncWithHttpInfo (Relationship body = null)
        {
            
    
            var path_ = "/api/v1/externalcontacts/relationships";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostRelationships: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
        
        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns>Relationship</returns>
        public Relationship GetRelationshipsRelationshipId (string relationshipId)
        {
             ApiResponse<Relationship> response = GetRelationshipsRelationshipIdWithHttpInfo(relationshipId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > GetRelationshipsRelationshipIdWithHttpInfo (string relationshipId)
        {
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->GetRelationshipsRelationshipId");
            
    
            var path_ = "/api/v1/externalcontacts/relationships/{relationshipId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (relationshipId != null) pathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRelationshipsRelationshipId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRelationshipsRelationshipId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
    
        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> GetRelationshipsRelationshipIdAsync (string relationshipId)
        {
             ApiResponse<Relationship> response = await GetRelationshipsRelationshipIdAsyncWithHttpInfo(relationshipId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> GetRelationshipsRelationshipIdAsyncWithHttpInfo (string relationshipId)
        {
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling GetRelationshipsRelationshipId");
            
    
            var path_ = "/api/v1/externalcontacts/relationships/{relationshipId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (relationshipId != null) pathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRelationshipsRelationshipId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRelationshipsRelationshipId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
        
        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <param name="body">Relationship</param> 
        /// <returns>Relationship</returns>
        public Relationship PutRelationshipsRelationshipId (string relationshipId, Relationship body = null)
        {
             ApiResponse<Relationship> response = PutRelationshipsRelationshipIdWithHttpInfo(relationshipId, body);
             return response.Data;
        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <param name="body">Relationship</param> 
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > PutRelationshipsRelationshipIdWithHttpInfo (string relationshipId, Relationship body = null)
        {
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->PutRelationshipsRelationshipId");
            
    
            var path_ = "/api/v1/externalcontacts/relationships/{relationshipId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (relationshipId != null) pathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutRelationshipsRelationshipId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRelationshipsRelationshipId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
    
        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> PutRelationshipsRelationshipIdAsync (string relationshipId, Relationship body = null)
        {
             ApiResponse<Relationship> response = await PutRelationshipsRelationshipIdAsyncWithHttpInfo(relationshipId, body);
             return response.Data;

        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PutRelationshipsRelationshipIdAsyncWithHttpInfo (string relationshipId, Relationship body = null)
        {
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling PutRelationshipsRelationshipId");
            
    
            var path_ = "/api/v1/externalcontacts/relationships/{relationshipId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (relationshipId != null) pathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutRelationshipsRelationshipId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutRelationshipsRelationshipId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
        
        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns></returns>
        public void DeleteRelationshipsRelationshipId (string relationshipId)
        {
             DeleteRelationshipsRelationshipIdWithHttpInfo(relationshipId);
        }

        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRelationshipsRelationshipIdWithHttpInfo (string relationshipId)
        {
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->DeleteRelationshipsRelationshipId");
            
    
            var path_ = "/api/v1/externalcontacts/relationships/{relationshipId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (relationshipId != null) pathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRelationshipsRelationshipId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRelationshipsRelationshipId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRelationshipsRelationshipIdAsync (string relationshipId)
        {
             await DeleteRelationshipsRelationshipIdAsyncWithHttpInfo(relationshipId);

        }

        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRelationshipsRelationshipIdAsyncWithHttpInfo (string relationshipId)
        {
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling DeleteRelationshipsRelationshipId");
            
    
            var path_ = "/api/v1/externalcontacts/relationships/{relationshipId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (relationshipId != null) pathParams.Add("relationshipId", Configuration.ApiClient.ParameterToString(relationshipId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRelationshipsRelationshipId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRelationshipsRelationshipId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
