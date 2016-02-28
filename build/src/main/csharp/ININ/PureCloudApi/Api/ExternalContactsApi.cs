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
        ContactListing GetExternalcontactsContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
  
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
        ApiResponse<ContactListing> GetExternalcontactsContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ContactListing> GetExternalcontactsContactsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
        
        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        ExternalContact PostExternalcontactsContacts (ExternalContact body = null);
  
        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> PostExternalcontactsContactsWithHttpInfo (ExternalContact body = null);

        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactsAsync (ExternalContact body = null);

        /// <summary>
        /// Create an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactsAsyncWithHttpInfo (ExternalContact body = null);
        
        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ExternalContact</returns>
        ExternalContact GetExternalcontactsContact (string contactId);
  
        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> GetExternalcontactsContactWithHttpInfo (string contactId);

        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> GetExternalcontactsContactAsync (string contactId);

        /// <summary>
        /// Fetch a ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetExternalcontactsContactAsyncWithHttpInfo (string contactId);
        
        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ExternalContact</returns>
        ExternalContact PutExternalcontactsContact (string contactId, ExternalContact body = null);
  
        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of ExternalContact</returns>
        ApiResponse<ExternalContact> PutExternalcontactsContactWithHttpInfo (string contactId, ExternalContact body = null);

        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        System.Threading.Tasks.Task<ExternalContact> PutExternalcontactsContactAsync (string contactId, ExternalContact body = null);

        /// <summary>
        /// Update a externalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutExternalcontactsContactAsyncWithHttpInfo (string contactId, ExternalContact body = null);
        
        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns></returns>
        void DeleteExternalcontactsContact (string contactId);
  
        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalcontactsContactWithHttpInfo (string contactId);

        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsContactAsync (string contactId);

        /// <summary>
        /// Delete a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactAsyncWithHttpInfo (string contactId);
        
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
        NoteListing GetExternalcontactsContactNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
  
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
        ApiResponse<NoteListing> GetExternalcontactsContactNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<NoteListing> GetExternalcontactsContactNotesAsync (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        Note PostExternalcontactsContactNotes (string contactId, Note body = null);
  
        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PostExternalcontactsContactNotesWithHttpInfo (string contactId, Note body = null);

        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PostExternalcontactsContactNotesAsync (string contactId, Note body = null);

        /// <summary>
        /// Create a Note for an ExternalContact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, Note body = null);
        
        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Note</returns>
        Note GetExternalcontactsContactNote (string contactId, string noteId);
  
        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> GetExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId);

        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> GetExternalcontactsContactNoteAsync (string contactId, string noteId);

        /// <summary>
        /// Fetch a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId);
        
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
        Note PutExternalcontactsContactNote (string contactId, string noteId, Note body = null);
  
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
        ApiResponse<Note> PutExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, Note body = null);

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
        System.Threading.Tasks.Task<Note> PutExternalcontactsContactNoteAsync (string contactId, string noteId, Note body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, Note body = null);
        
        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns></returns>
        void DeleteExternalcontactsContactNote (string contactId, string noteId);
  
        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId);

        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsContactNoteAsync (string contactId, string noteId);

        /// <summary>
        /// Delete a note for a contact
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId);
        
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
        ExternalOrganizationListing GetExternalcontactsOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
  
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
        ApiResponse<ExternalOrganizationListing> GetExternalcontactsOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ExternalOrganizationListing> GetExternalcontactsOrganizationsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetExternalcontactsOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
        
        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PostExternalcontactsOrganizations (ExternalOrganization body = null);
  
        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PostExternalcontactsOrganizationsWithHttpInfo (ExternalOrganization body = null);

        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PostExternalcontactsOrganizationsAsync (ExternalOrganization body = null);

        /// <summary>
        /// Create an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostExternalcontactsOrganizationsAsyncWithHttpInfo (ExternalOrganization body = null);
        
        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization GetExternalcontactsOrganization (string externalOrganizationId);
  
        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> GetExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> GetExternalcontactsOrganizationAsync (string externalOrganizationId);

        /// <summary>
        /// Fetch an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> GetExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId);
        
        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ExternalOrganization</returns>
        ExternalOrganization PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body = null);
  
        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>ApiResponse of ExternalOrganization</returns>
        ApiResponse<ExternalOrganization> PutExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null);

        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationAsync (string externalOrganizationId, ExternalOrganization body = null);

        /// <summary>
        /// Update an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null);
        
        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns></returns>
        void DeleteExternalcontactsOrganization (string externalOrganizationId);
  
        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId);

        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsOrganizationAsync (string externalOrganizationId);

        /// <summary>
        /// Delete an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId);
        
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
        ContactListing GetExternalcontactsOrganizationContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
  
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
        ApiResponse<ContactListing> GetExternalcontactsOrganizationContactsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ContactListing> GetExternalcontactsOrganizationContactsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsOrganizationContactsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null);
        
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
        NoteListing GetExternalcontactsOrganizationNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
  
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
        ApiResponse<NoteListing> GetExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<NoteListing> GetExternalcontactsOrganizationNotesAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        
        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Note</returns>
        Note PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body = null);
  
        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> PostExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, Note body = null);

        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> PostExternalcontactsOrganizationNotesAsync (string externalOrganizationId, Note body = null);

        /// <summary>
        /// Create a Note for an External Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, Note body = null);
        
        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Note</returns>
        Note GetExternalcontactsOrganizationNote (string externalOrganizationId, string noteId);
  
        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Note</returns>
        ApiResponse<Note> GetExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId);

        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of Note</returns>
        System.Threading.Tasks.Task<Note> GetExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId);

        /// <summary>
        /// Fetch a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId);
        
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
        Note PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body = null);
  
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
        ApiResponse<Note> PutExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, Note body = null);

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
        System.Threading.Tasks.Task<Note> PutExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, Note body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body = null);
        
        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns></returns>
        void DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId);
  
        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId);

        /// <summary>
        /// Delete a note
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId);
        
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
        RelationshipListing GetExternalcontactsOrganizationRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
  
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
        ApiResponse<RelationshipListing> GetExternalcontactsOrganizationRelationshipsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<RelationshipListing> GetExternalcontactsOrganizationRelationshipsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<RelationshipListing>> GetExternalcontactsOrganizationRelationshipsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null);
        
        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        Relationship PostExternalcontactsRelationships (Relationship body = null);
  
        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> PostExternalcontactsRelationshipsWithHttpInfo (Relationship body = null);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> PostExternalcontactsRelationshipsAsync (Relationship body = null);

        /// <summary>
        /// Create a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PostExternalcontactsRelationshipsAsyncWithHttpInfo (Relationship body = null);
        
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Relationship</returns>
        Relationship GetExternalcontactsRelationship (string relationshipId);
  
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> GetExternalcontactsRelationshipWithHttpInfo (string relationshipId);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> GetExternalcontactsRelationshipAsync (string relationshipId);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> GetExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId);
        
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Relationship</returns>
        Relationship PutExternalcontactsRelationship (string relationshipId, Relationship body = null);
  
        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>ApiResponse of Relationship</returns>
        ApiResponse<Relationship> PutExternalcontactsRelationshipWithHttpInfo (string relationshipId, Relationship body = null);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        System.Threading.Tasks.Task<Relationship> PutExternalcontactsRelationshipAsync (string relationshipId, Relationship body = null);

        /// <summary>
        /// Fetch a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        System.Threading.Tasks.Task<ApiResponse<Relationship>> PutExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, Relationship body = null);
        
        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns></returns>
        void DeleteExternalcontactsRelationship (string relationshipId);
  
        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExternalcontactsRelationshipWithHttpInfo (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExternalcontactsRelationshipAsync (string relationshipId);

        /// <summary>
        /// Delete a relationship
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId);
        
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
        public ContactListing GetExternalcontactsContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = GetExternalcontactsContactsWithHttpInfo(pageSize, pageNumber, q, sortOrder);
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
        public ApiResponse< ContactListing > GetExternalcontactsContactsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContacts: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ContactListing> GetExternalcontactsContactsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = await GetExternalcontactsContactsAsyncWithHttpInfo(pageSize, pageNumber, q, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsContactsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContacts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ContactListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContactListing) Configuration.ApiClient.Deserialize(response, typeof(ContactListing)));
            
        }
        
        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param> 
        /// <returns>ExternalContact</returns>
        public ExternalContact PostExternalcontactsContacts (ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = PostExternalcontactsContactsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > PostExternalcontactsContactsWithHttpInfo (ExternalContact body = null)
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
    
        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> PostExternalcontactsContactsAsync (ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = await PostExternalcontactsContactsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an ExternalContact 
        /// </summary>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PostExternalcontactsContactsAsyncWithHttpInfo (ExternalContact body = null)
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContacts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
        
        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns>ExternalContact</returns>
        public ExternalContact GetExternalcontactsContact (string contactId)
        {
             ApiResponse<ExternalContact> response = GetExternalcontactsContactWithHttpInfo(contactId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > GetExternalcontactsContactWithHttpInfo (string contactId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContact");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContact: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
    
        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ExternalContact</returns>
        public async System.Threading.Tasks.Task<ExternalContact> GetExternalcontactsContactAsync (string contactId)
        {
             ApiResponse<ExternalContact> response = await GetExternalcontactsContactAsyncWithHttpInfo(contactId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> GetExternalcontactsContactAsyncWithHttpInfo (string contactId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetExternalcontactsContact");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContact: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContact: " + response.ErrorMessage, response.ErrorMessage);

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
        public ExternalContact PutExternalcontactsContact (string contactId, ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = PutExternalcontactsContactWithHttpInfo(contactId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a externalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of ExternalContact</returns>
        public ApiResponse< ExternalContact > PutExternalcontactsContactWithHttpInfo (string contactId, ExternalContact body = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContact");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContact: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContact: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ExternalContact> PutExternalcontactsContactAsync (string contactId, ExternalContact body = null)
        {
             ApiResponse<ExternalContact> response = await PutExternalcontactsContactAsyncWithHttpInfo(contactId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a externalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (ExternalContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalContact>> PutExternalcontactsContactAsyncWithHttpInfo (string contactId, ExternalContact body = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PutExternalcontactsContact");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContact: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContact: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalContact>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalContact) Configuration.ApiClient.Deserialize(response, typeof(ExternalContact)));
            
        }
        
        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns></returns>
        public void DeleteExternalcontactsContact (string contactId)
        {
             DeleteExternalcontactsContactWithHttpInfo(contactId);
        }

        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsContactWithHttpInfo (string contactId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteExternalcontactsContact");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContact: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContact: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsContactAsync (string contactId)
        {
             await DeleteExternalcontactsContactAsyncWithHttpInfo(contactId);

        }

        /// <summary>
        /// Delete a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactAsyncWithHttpInfo (string contactId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling DeleteExternalcontactsContact");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContact: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContact: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public NoteListing GetExternalcontactsContactNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = GetExternalcontactsContactNotesWithHttpInfo(contactId, pageSize, pageNumber, sortOrder);
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
        public ApiResponse< NoteListing > GetExternalcontactsContactNotesWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNotes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<NoteListing> GetExternalcontactsContactNotesAsync (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = await GetExternalcontactsContactNotesAsyncWithHttpInfo(contactId, pageSize, pageNumber, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetExternalcontactsContactNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNotes: " + response.ErrorMessage, response.ErrorMessage);

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
        public Note PostExternalcontactsContactNotes (string contactId, Note body = null)
        {
             ApiResponse<Note> response = PostExternalcontactsContactNotesWithHttpInfo(contactId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a Note for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PostExternalcontactsContactNotesWithHttpInfo (string contactId, Note body = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PostExternalcontactsContactNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContactNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContactNotes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Note> PostExternalcontactsContactNotesAsync (string contactId, Note body = null)
        {
             ApiResponse<Note> response = await PostExternalcontactsContactNotesAsyncWithHttpInfo(contactId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a Note for an ExternalContact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsContactNotesAsyncWithHttpInfo (string contactId, Note body = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PostExternalcontactsContactNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContactNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsContactNotes: " + response.ErrorMessage, response.ErrorMessage);

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
        public Note GetExternalcontactsContactNote (string contactId, string noteId)
        {
             ApiResponse<Note> response = GetExternalcontactsContactNoteWithHttpInfo(contactId, noteId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > GetExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->GetExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetExternalcontactsContactNote");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNote: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Note> GetExternalcontactsContactNoteAsync (string contactId, string noteId)
        {
             ApiResponse<Note> response = await GetExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling GetExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling GetExternalcontactsContactNote");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsContactNote: " + response.ErrorMessage, response.ErrorMessage);

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
        public Note PutExternalcontactsContactNote (string contactId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = PutExternalcontactsContactNoteWithHttpInfo(contactId, noteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <param name="body">Note</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PutExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId, Note body = null)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsContactNote");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContactNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContactNote: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Note> PutExternalcontactsContactNoteAsync (string contactId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = await PutExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId, Note body = null)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling PutExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling PutExternalcontactsContactNote");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContactNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsContactNote: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteExternalcontactsContactNote (string contactId, string noteId)
        {
             DeleteExternalcontactsContactNoteWithHttpInfo(contactId, noteId);
        }

        /// <summary>
        /// Delete a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsContactNoteWithHttpInfo (string contactId, string noteId)
        {
            
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ExternalContactsApi->DeleteExternalcontactsContactNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteExternalcontactsContactNote");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContactNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContactNote: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteExternalcontactsContactNoteAsync (string contactId, string noteId)
        {
             await DeleteExternalcontactsContactNoteAsyncWithHttpInfo(contactId, noteId);

        }

        /// <summary>
        /// Delete a note for a contact 
        /// </summary>
        /// <param name="contactId">ExternalContact Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsContactNoteAsyncWithHttpInfo (string contactId, string noteId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null) throw new ApiException(400, "Missing required parameter 'contactId' when calling DeleteExternalcontactsContactNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling DeleteExternalcontactsContactNote");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContactNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsContactNote: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ExternalOrganizationListing GetExternalcontactsOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ExternalOrganizationListing> response = GetExternalcontactsOrganizationsWithHttpInfo(pageSize, pageNumber, q, sortOrder);
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
        public ApiResponse< ExternalOrganizationListing > GetExternalcontactsOrganizationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ExternalOrganizationListing> GetExternalcontactsOrganizationsAsync (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ExternalOrganizationListing> response = await GetExternalcontactsOrganizationsAsyncWithHttpInfo(pageSize, pageNumber, q, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganizationListing>> GetExternalcontactsOrganizationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganizationListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganizationListing) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganizationListing)));
            
        }
        
        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization PostExternalcontactsOrganizations (ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = PostExternalcontactsOrganizationsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PostExternalcontactsOrganizationsWithHttpInfo (ExternalOrganization body = null)
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
    
        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> PostExternalcontactsOrganizationsAsync (ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = await PostExternalcontactsOrganizationsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an External Organization 
        /// </summary>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PostExternalcontactsOrganizationsAsyncWithHttpInfo (ExternalOrganization body = null)
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
        
        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns>ExternalOrganization</returns>
        public ExternalOrganization GetExternalcontactsOrganization (string externalOrganizationId)
        {
             ApiResponse<ExternalOrganization> response = GetExternalcontactsOrganizationWithHttpInfo(externalOrganizationId);
             return response.Data;
        }

        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > GetExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganization");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
    
        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ExternalOrganization</returns>
        public async System.Threading.Tasks.Task<ExternalOrganization> GetExternalcontactsOrganizationAsync (string externalOrganizationId)
        {
             ApiResponse<ExternalOrganization> response = await GetExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId);
             return response.Data;

        }

        /// <summary>
        /// Fetch an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> GetExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetExternalcontactsOrganization");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganization: " + response.ErrorMessage, response.ErrorMessage);

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
        public ExternalOrganization PutExternalcontactsOrganization (string externalOrganizationId, ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = PutExternalcontactsOrganizationWithHttpInfo(externalOrganizationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <param name="body">ExternalOrganization</param> 
        /// <returns>ApiResponse of ExternalOrganization</returns>
        public ApiResponse< ExternalOrganization > PutExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganization");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ExternalOrganization> PutExternalcontactsOrganizationAsync (string externalOrganizationId, ExternalOrganization body = null)
        {
             ApiResponse<ExternalOrganization> response = await PutExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <param name="body">ExternalOrganization</param>
        /// <returns>Task of ApiResponse (ExternalOrganization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalOrganization>> PutExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId, ExternalOrganization body = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling PutExternalcontactsOrganization");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ExternalOrganization>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalOrganization) Configuration.ApiClient.Deserialize(response, typeof(ExternalOrganization)));
            
        }
        
        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns></returns>
        public void DeleteExternalcontactsOrganization (string externalOrganizationId)
        {
             DeleteExternalcontactsOrganizationWithHttpInfo(externalOrganizationId);
        }

        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsOrganizationWithHttpInfo (string externalOrganizationId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganization");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsOrganizationAsync (string externalOrganizationId)
        {
             await DeleteExternalcontactsOrganizationAsyncWithHttpInfo(externalOrganizationId);

        }

        /// <summary>
        /// Delete an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationAsyncWithHttpInfo (string externalOrganizationId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling DeleteExternalcontactsOrganization");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganization: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ContactListing GetExternalcontactsOrganizationContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = GetExternalcontactsOrganizationContactsWithHttpInfo(externalOrganizationId, pageSize, pageNumber, q, sortOrder);
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
        public ApiResponse< ContactListing > GetExternalcontactsOrganizationContactsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationContacts");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationContacts: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ContactListing> GetExternalcontactsOrganizationContactsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
             ApiResponse<ContactListing> response = await GetExternalcontactsOrganizationContactsAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, q, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ContactListing>> GetExternalcontactsOrganizationContactsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetExternalcontactsOrganizationContacts");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationContacts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationContacts: " + response.ErrorMessage, response.ErrorMessage);

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
        public NoteListing GetExternalcontactsOrganizationNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = GetExternalcontactsOrganizationNotesWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
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
        public ApiResponse< NoteListing > GetExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNotes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<NoteListing> GetExternalcontactsOrganizationNotesAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<NoteListing> response = await GetExternalcontactsOrganizationNotesAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<NoteListing>> GetExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetExternalcontactsOrganizationNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNotes: " + response.ErrorMessage, response.ErrorMessage);

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
        public Note PostExternalcontactsOrganizationNotes (string externalOrganizationId, Note body = null)
        {
             ApiResponse<Note> response = PostExternalcontactsOrganizationNotesWithHttpInfo(externalOrganizationId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a Note for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="body">ExternalContact</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PostExternalcontactsOrganizationNotesWithHttpInfo (string externalOrganizationId, Note body = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PostExternalcontactsOrganizationNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizationNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizationNotes: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Note> PostExternalcontactsOrganizationNotesAsync (string externalOrganizationId, Note body = null)
        {
             ApiResponse<Note> response = await PostExternalcontactsOrganizationNotesAsyncWithHttpInfo(externalOrganizationId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a Note for an External Organization 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="body">ExternalContact</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PostExternalcontactsOrganizationNotesAsyncWithHttpInfo (string externalOrganizationId, Note body = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling PostExternalcontactsOrganizationNotes");
            
    
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizationNotes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsOrganizationNotes: " + response.ErrorMessage, response.ErrorMessage);

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
        public Note GetExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)
        {
             ApiResponse<Note> response = GetExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > GetExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->GetExternalcontactsOrganizationNote");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNote: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Note> GetExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId)
        {
             ApiResponse<Note> response = await GetExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> GetExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling GetExternalcontactsOrganizationNote");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationNote: " + response.ErrorMessage, response.ErrorMessage);

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
        public Note PutExternalcontactsOrganizationNote (string externalOrganizationId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = PutExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <param name="body">Note</param> 
        /// <returns>ApiResponse of Note</returns>
        public ApiResponse< Note > PutExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId, Note body = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->PutExternalcontactsOrganizationNote");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganizationNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganizationNote: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Note> PutExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId, Note body = null)
        {
             ApiResponse<Note> response = await PutExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <param name="body">Note</param>
        /// <returns>Task of ApiResponse (Note)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Note>> PutExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId, Note body = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling PutExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling PutExternalcontactsOrganizationNote");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganizationNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsOrganizationNote: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteExternalcontactsOrganizationNote (string externalOrganizationId, string noteId)
        {
             DeleteExternalcontactsOrganizationNoteWithHttpInfo(externalOrganizationId, noteId);
        }

        /// <summary>
        /// Delete a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param> 
        /// <param name="noteId">Note Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsOrganizationNoteWithHttpInfo (string externalOrganizationId, string noteId)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationNote");
            
            // verify the required parameter 'noteId' is set
            if (noteId == null)
                throw new ApiException(400, "Missing required parameter 'noteId' when calling ExternalContactsApi->DeleteExternalcontactsOrganizationNote");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteExternalcontactsOrganizationNoteAsync (string externalOrganizationId, string noteId)
        {
             await DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo(externalOrganizationId, noteId);

        }

        /// <summary>
        /// Delete a note 
        /// </summary>
        /// <param name="externalOrganizationId">External Organization Id</param>
        /// <param name="noteId">Note Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsOrganizationNoteAsyncWithHttpInfo (string externalOrganizationId, string noteId)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling DeleteExternalcontactsOrganizationNote");
            // verify the required parameter 'noteId' is set
            if (noteId == null) throw new ApiException(400, "Missing required parameter 'noteId' when calling DeleteExternalcontactsOrganizationNote");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsOrganizationNote: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public RelationshipListing GetExternalcontactsOrganizationRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<RelationshipListing> response = GetExternalcontactsOrganizationRelationshipsWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
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
        public ApiResponse< RelationshipListing > GetExternalcontactsOrganizationRelationshipsWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null)
                throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling ExternalContactsApi->GetExternalcontactsOrganizationRelationships");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<RelationshipListing> GetExternalcontactsOrganizationRelationshipsAsync (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
             ApiResponse<RelationshipListing> response = await GetExternalcontactsOrganizationRelationshipsAsyncWithHttpInfo(externalOrganizationId, pageSize, pageNumber, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<RelationshipListing>> GetExternalcontactsOrganizationRelationshipsAsyncWithHttpInfo (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)
        {
            // verify the required parameter 'externalOrganizationId' is set
            if (externalOrganizationId == null) throw new ApiException(400, "Missing required parameter 'externalOrganizationId' when calling GetExternalcontactsOrganizationRelationships");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsOrganizationRelationships: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RelationshipListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RelationshipListing) Configuration.ApiClient.Deserialize(response, typeof(RelationshipListing)));
            
        }
        
        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param> 
        /// <returns>Relationship</returns>
        public Relationship PostExternalcontactsRelationships (Relationship body = null)
        {
             ApiResponse<Relationship> response = PostExternalcontactsRelationshipsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param> 
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > PostExternalcontactsRelationshipsWithHttpInfo (Relationship body = null)
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsRelationships: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
    
        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> PostExternalcontactsRelationshipsAsync (Relationship body = null)
        {
             ApiResponse<Relationship> response = await PostExternalcontactsRelationshipsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a relationship 
        /// </summary>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PostExternalcontactsRelationshipsAsyncWithHttpInfo (Relationship body = null)
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
                throw new ApiException (statusCode, "Error calling PostExternalcontactsRelationships: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostExternalcontactsRelationships: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
        
        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns>Relationship</returns>
        public Relationship GetExternalcontactsRelationship (string relationshipId)
        {
             ApiResponse<Relationship> response = GetExternalcontactsRelationshipWithHttpInfo(relationshipId);
             return response.Data;
        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > GetExternalcontactsRelationshipWithHttpInfo (string relationshipId)
        {
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->GetExternalcontactsRelationship");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsRelationship: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
    
        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of Relationship</returns>
        public async System.Threading.Tasks.Task<Relationship> GetExternalcontactsRelationshipAsync (string relationshipId)
        {
             ApiResponse<Relationship> response = await GetExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId);
             return response.Data;

        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> GetExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId)
        {
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling GetExternalcontactsRelationship");
            
    
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
                throw new ApiException (statusCode, "Error calling GetExternalcontactsRelationship: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetExternalcontactsRelationship: " + response.ErrorMessage, response.ErrorMessage);

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
        public Relationship PutExternalcontactsRelationship (string relationshipId, Relationship body = null)
        {
             ApiResponse<Relationship> response = PutExternalcontactsRelationshipWithHttpInfo(relationshipId, body);
             return response.Data;
        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <param name="body">Relationship</param> 
        /// <returns>ApiResponse of Relationship</returns>
        public ApiResponse< Relationship > PutExternalcontactsRelationshipWithHttpInfo (string relationshipId, Relationship body = null)
        {
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->PutExternalcontactsRelationship");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsRelationship: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Relationship> PutExternalcontactsRelationshipAsync (string relationshipId, Relationship body = null)
        {
             ApiResponse<Relationship> response = await PutExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId, body);
             return response.Data;

        }

        /// <summary>
        /// Fetch a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <param name="body">Relationship</param>
        /// <returns>Task of ApiResponse (Relationship)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Relationship>> PutExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId, Relationship body = null)
        {
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling PutExternalcontactsRelationship");
            
    
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
                throw new ApiException (statusCode, "Error calling PutExternalcontactsRelationship: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutExternalcontactsRelationship: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Relationship>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Relationship) Configuration.ApiClient.Deserialize(response, typeof(Relationship)));
            
        }
        
        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns></returns>
        public void DeleteExternalcontactsRelationship (string relationshipId)
        {
             DeleteExternalcontactsRelationshipWithHttpInfo(relationshipId);
        }

        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExternalcontactsRelationshipWithHttpInfo (string relationshipId)
        {
            
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null)
                throw new ApiException(400, "Missing required parameter 'relationshipId' when calling ExternalContactsApi->DeleteExternalcontactsRelationship");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsRelationship: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsRelationship: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExternalcontactsRelationshipAsync (string relationshipId)
        {
             await DeleteExternalcontactsRelationshipAsyncWithHttpInfo(relationshipId);

        }

        /// <summary>
        /// Delete a relationship 
        /// </summary>
        /// <param name="relationshipId">Relationship Id</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExternalcontactsRelationshipAsyncWithHttpInfo (string relationshipId)
        {
            // verify the required parameter 'relationshipId' is set
            if (relationshipId == null) throw new ApiException(400, "Missing required parameter 'relationshipId' when calling DeleteExternalcontactsRelationship");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsRelationship: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteExternalcontactsRelationship: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
