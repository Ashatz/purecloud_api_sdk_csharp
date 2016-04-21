# ININ.PureCloudApi.Api.ExternalContactsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteContactsContactId**](ExternalContactsApi.md#deletecontactscontactid) | **DELETE** /api/v2/externalcontacts/contacts/{contactId} | Delete a contact |
| [**DeleteContactsContactIdNotesNoteId**](ExternalContactsApi.md#deletecontactscontactidnotesnoteid) | **DELETE** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Delete a note for a contact |
| [**DeleteOrganizationsExternalorganizationId**](ExternalContactsApi.md#deleteorganizationsexternalorganizationid) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Delete an External Organization |
| [**DeleteOrganizationsExternalorganizationIdNotesNoteId**](ExternalContactsApi.md#deleteorganizationsexternalorganizationidnotesnoteid) | **DELETE** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Delete a note |
| [**DeleteRelationshipsRelationshipId**](ExternalContactsApi.md#deleterelationshipsrelationshipid) | **DELETE** /api/v2/externalcontacts/relationships/{relationshipId} | Delete a relationship |
| [**GetContacts**](ExternalContactsApi.md#getcontacts) | **GET** /api/v2/externalcontacts/contacts | Search for External Contacts |
| [**GetContactsContactId**](ExternalContactsApi.md#getcontactscontactid) | **GET** /api/v2/externalcontacts/contacts/{contactId} | Fetch a ExternalContact |
| [**GetContactsContactIdNotes**](ExternalContactsApi.md#getcontactscontactidnotes) | **GET** /api/v2/externalcontacts/contacts/{contactId}/notes | List Notes for an ExternalContact |
| [**GetContactsContactIdNotesNoteId**](ExternalContactsApi.md#getcontactscontactidnotesnoteid) | **GET** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Fetch a note for a contact |
| [**GetOrganizations**](ExternalContactsApi.md#getorganizations) | **GET** /api/v2/externalcontacts/organizations | Search for External Organizations |
| [**GetOrganizationsExternalorganizationId**](ExternalContactsApi.md#getorganizationsexternalorganizationid) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Fetch an External Organization |
| [**GetOrganizationsExternalorganizationIdContacts**](ExternalContactsApi.md#getorganizationsexternalorganizationidcontacts) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/contacts | Search for External Contacts |
| [**GetOrganizationsExternalorganizationIdNotes**](ExternalContactsApi.md#getorganizationsexternalorganizationidnotes) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | List Notes for an External Organization |
| [**GetOrganizationsExternalorganizationIdNotesNoteId**](ExternalContactsApi.md#getorganizationsexternalorganizationidnotesnoteid) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Fetch a note |
| [**GetOrganizationsExternalorganizationIdRelationships**](ExternalContactsApi.md#getorganizationsexternalorganizationidrelationships) | **GET** /api/v2/externalcontacts/organizations/{externalOrganizationId}/relationships | Fetch an External Organization |
| [**GetRelationshipsRelationshipId**](ExternalContactsApi.md#getrelationshipsrelationshipid) | **GET** /api/v2/externalcontacts/relationships/{relationshipId} | Fetch a relationship |
| [**PostContacts**](ExternalContactsApi.md#postcontacts) | **POST** /api/v2/externalcontacts/contacts | Create an ExternalContact |
| [**PostContactsContactIdNotes**](ExternalContactsApi.md#postcontactscontactidnotes) | **POST** /api/v2/externalcontacts/contacts/{contactId}/notes | Create a Note for an ExternalContact |
| [**PostOrganizations**](ExternalContactsApi.md#postorganizations) | **POST** /api/v2/externalcontacts/organizations | Create an External Organization |
| [**PostOrganizationsExternalorganizationIdNotes**](ExternalContactsApi.md#postorganizationsexternalorganizationidnotes) | **POST** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes | Create a Note for an External Organization |
| [**PostRelationships**](ExternalContactsApi.md#postrelationships) | **POST** /api/v2/externalcontacts/relationships | Create a relationship |
| [**PutContactsContactId**](ExternalContactsApi.md#putcontactscontactid) | **PUT** /api/v2/externalcontacts/contacts/{contactId} | Update a externalContact |
| [**PutContactsContactIdNotesNoteId**](ExternalContactsApi.md#putcontactscontactidnotesnoteid) | **PUT** /api/v2/externalcontacts/contacts/{contactId}/notes/{noteId} | Update a note for a contact |
| [**PutOrganizationsExternalorganizationId**](ExternalContactsApi.md#putorganizationsexternalorganizationid) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId} | Update an External Organization |
| [**PutOrganizationsExternalorganizationIdNotesNoteId**](ExternalContactsApi.md#putorganizationsexternalorganizationidnotesnoteid) | **PUT** /api/v2/externalcontacts/organizations/{externalOrganizationId}/notes/{noteId} | Update a note |
| [**PutRelationshipsRelationshipId**](ExternalContactsApi.md#putrelationshipsrelationshipid) | **PUT** /api/v2/externalcontacts/relationships/{relationshipId} | Update a relationship |
{: class="table table-striped"}

<a name="DeleteContactsContactId"></a>
## void DeleteContactsContactId (string contactId)

Delete a contact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteContactsContactIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID

            try
            {
                // Delete a contact
                apiInstance.DeleteContactsContactId(contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteContactsContactId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteContactsContactIdNotesNoteId"></a>
## void DeleteContactsContactIdNotesNoteId (string contactId, string noteId)

Delete a note for a contact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteContactsContactIdNotesNoteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id

            try
            {
                // Delete a note for a contact
                apiInstance.DeleteContactsContactIdNotesNoteId(contactId, noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteContactsContactIdNotesNoteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **noteId** | **string**| Note Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteOrganizationsExternalorganizationId"></a>
## void DeleteOrganizationsExternalorganizationId (string externalOrganizationId)

Delete an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOrganizationsExternalorganizationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID

            try
            {
                // Delete an External Organization
                apiInstance.DeleteOrganizationsExternalorganizationId(externalOrganizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteOrganizationsExternalorganizationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteOrganizationsExternalorganizationIdNotesNoteId"></a>
## void DeleteOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId)

Delete a note



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOrganizationsExternalorganizationIdNotesNoteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id

            try
            {
                // Delete a note
                apiInstance.DeleteOrganizationsExternalorganizationIdNotesNoteId(externalOrganizationId, noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteOrganizationsExternalorganizationIdNotesNoteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **noteId** | **string**| Note Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteRelationshipsRelationshipId"></a>
## void DeleteRelationshipsRelationshipId (string relationshipId)

Delete a relationship



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteRelationshipsRelationshipIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id

            try
            {
                // Delete a relationship
                apiInstance.DeleteRelationshipsRelationshipId(relationshipId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteRelationshipsRelationshipId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **relationshipId** | **string**| Relationship Id |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetContacts"></a>
## [**ContactListing**](ContactListing.html) GetContacts (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)

Search for External Contacts



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var q = q_example;  // string | User supplied search keywords (no special syntax is currently supported) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            {
                // Search for External Contacts
                ContactListing result = apiInstance.GetContacts(pageSize, pageNumber, q, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetContacts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **q** | **string**| User supplied search keywords (no special syntax is currently supported) | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.md)| which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactListing**](ContactListing.md)

<a name="GetContactsContactId"></a>
## [**ExternalContact**](ExternalContact.html) GetContactsContactId (string contactId, List<string> expand = null)

Fetch a ExternalContact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactsContactIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            {
                // Fetch a ExternalContact
                ExternalContact result = apiInstance.GetContactsContactId(contactId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetContactsContactId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **expand** | [**List<string>**](string.md)| which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalContact**](ExternalContact.md)

<a name="GetContactsContactIdNotes"></a>
## [**NoteListing**](NoteListing.html) GetContactsContactIdNotes (string contactId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)

List Notes for an ExternalContact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactsContactIdNotesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var pageSize = 56;  // int? | Page size (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            {
                // List Notes for an ExternalContact
                NoteListing result = apiInstance.GetContactsContactIdNotes(contactId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetContactsContactIdNotes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **pageSize** | **int?**| Page size | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**NoteListing**](NoteListing.md)

<a name="GetContactsContactIdNotesNoteId"></a>
## [**Note**](Note.html) GetContactsContactIdNotesNoteId (string contactId, string noteId)

Fetch a note for a contact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactsContactIdNotesNoteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id

            try
            {
                // Fetch a note for a contact
                Note result = apiInstance.GetContactsContactIdNotesNoteId(contactId, noteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetContactsContactIdNotesNoteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **noteId** | **string**| Note Id |  |
{: class="table table-striped"}

### Return type

[**Note**](Note.md)

<a name="GetOrganizations"></a>
## [**ExternalOrganizationListing**](ExternalOrganizationListing.html) GetOrganizations (int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null)

Search for External Organizations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrganizationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var q = q_example;  // string | Search query (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            {
                // Search for External Organizations
                ExternalOrganizationListing result = apiInstance.GetOrganizations(pageSize, pageNumber, q, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetOrganizations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **q** | **string**| Search query | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalOrganizationListing**](ExternalOrganizationListing.md)

<a name="GetOrganizationsExternalorganizationId"></a>
## [**ExternalOrganization**](ExternalOrganization.html) GetOrganizationsExternalorganizationId (string externalOrganizationId)

Fetch an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrganizationsExternalorganizationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID

            try
            {
                // Fetch an External Organization
                ExternalOrganization result = apiInstance.GetOrganizationsExternalorganizationId(externalOrganizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetOrganizationsExternalorganizationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.md)

<a name="GetOrganizationsExternalorganizationIdContacts"></a>
## [**ContactListing**](ContactListing.html) GetOrganizationsExternalorganizationIdContacts (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string q = null, string sortOrder = null, List<string> expand = null)

Search for External Contacts



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrganizationsExternalorganizationIdContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var q = q_example;  // string | User supplied search keywords (no special syntax is currently supported) (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 
            var expand = new List<string>(); // List<string> | which fields, if any, to expand (optional) 

            try
            {
                // Search for External Contacts
                ContactListing result = apiInstance.GetOrganizationsExternalorganizationIdContacts(externalOrganizationId, pageSize, pageNumber, q, sortOrder, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetOrganizationsExternalorganizationIdContacts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **q** | **string**| User supplied search keywords (no special syntax is currently supported) | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
| **expand** | [**List<string>**](string.md)| which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactListing**](ContactListing.md)

<a name="GetOrganizationsExternalorganizationIdNotes"></a>
## [**NoteListing**](NoteListing.html) GetOrganizationsExternalorganizationIdNotes (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)

List Notes for an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrganizationsExternalorganizationIdNotesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var pageSize = 56;  // int? | Page size (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            {
                // List Notes for an External Organization
                NoteListing result = apiInstance.GetOrganizationsExternalorganizationIdNotes(externalOrganizationId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetOrganizationsExternalorganizationIdNotes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **pageSize** | **int?**| Page size | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**NoteListing**](NoteListing.md)

<a name="GetOrganizationsExternalorganizationIdNotesNoteId"></a>
## [**Note**](Note.html) GetOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId)

Fetch a note



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrganizationsExternalorganizationIdNotesNoteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id

            try
            {
                // Fetch a note
                Note result = apiInstance.GetOrganizationsExternalorganizationIdNotesNoteId(externalOrganizationId, noteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetOrganizationsExternalorganizationIdNotesNoteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **noteId** | **string**| Note Id |  |
{: class="table table-striped"}

### Return type

[**Note**](Note.md)

<a name="GetOrganizationsExternalorganizationIdRelationships"></a>
## [**RelationshipListing**](RelationshipListing.html) GetOrganizationsExternalorganizationIdRelationships (string externalOrganizationId, int? pageSize = null, int? pageNumber = null, string sortOrder = null)

Fetch an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrganizationsExternalorganizationIdRelationshipsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 20)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            {
                // Fetch an External Organization
                RelationshipListing result = apiInstance.GetOrganizationsExternalorganizationIdRelationships(externalOrganizationId, pageSize, pageNumber, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetOrganizationsExternalorganizationIdRelationships: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 20] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**RelationshipListing**](RelationshipListing.md)

<a name="GetRelationshipsRelationshipId"></a>
## [**Relationship**](Relationship.html) GetRelationshipsRelationshipId (string relationshipId)

Fetch a relationship



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRelationshipsRelationshipIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id

            try
            {
                // Fetch a relationship
                Relationship result = apiInstance.GetRelationshipsRelationshipId(relationshipId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetRelationshipsRelationshipId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **relationshipId** | **string**| Relationship Id |  |
{: class="table table-striped"}

### Return type

[**Relationship**](Relationship.md)

<a name="PostContacts"></a>
## [**ExternalContact**](ExternalContact.html) PostContacts (ExternalContact body = null)

Create an ExternalContact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var body = new ExternalContact(); // ExternalContact | ExternalContact (optional) 

            try
            {
                // Create an ExternalContact
                ExternalContact result = apiInstance.PostContacts(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostContacts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalContact**](ExternalContact.md)| ExternalContact | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalContact**](ExternalContact.md)

<a name="PostContactsContactIdNotes"></a>
## [**Note**](Note.html) PostContactsContactIdNotes (string contactId, Note body = null)

Create a Note for an ExternalContact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostContactsContactIdNotesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var body = new Note(); // Note | ExternalContact (optional) 

            try
            {
                // Create a Note for an ExternalContact
                Note result = apiInstance.PostContactsContactIdNotes(contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostContactsContactIdNotes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **body** | [**Note**](Note.md)| ExternalContact | [optional]  |
{: class="table table-striped"}

### Return type

[**Note**](Note.md)

<a name="PostOrganizations"></a>
## [**ExternalOrganization**](ExternalOrganization.html) PostOrganizations (ExternalOrganization body = null)

Create an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostOrganizationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var body = new ExternalOrganization(); // ExternalOrganization | ExternalOrganization (optional) 

            try
            {
                // Create an External Organization
                ExternalOrganization result = apiInstance.PostOrganizations(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostOrganizations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ExternalOrganization**](ExternalOrganization.md)| ExternalOrganization | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.md)

<a name="PostOrganizationsExternalorganizationIdNotes"></a>
## [**Note**](Note.html) PostOrganizationsExternalorganizationIdNotes (string externalOrganizationId, Note body = null)

Create a Note for an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostOrganizationsExternalorganizationIdNotesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var body = new Note(); // Note | ExternalContact (optional) 

            try
            {
                // Create a Note for an External Organization
                Note result = apiInstance.PostOrganizationsExternalorganizationIdNotes(externalOrganizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostOrganizationsExternalorganizationIdNotes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **body** | [**Note**](Note.md)| ExternalContact | [optional]  |
{: class="table table-striped"}

### Return type

[**Note**](Note.md)

<a name="PostRelationships"></a>
## [**Relationship**](Relationship.html) PostRelationships (Relationship body = null)

Create a relationship



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRelationshipsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var body = new Relationship(); // Relationship | Relationship (optional) 

            try
            {
                // Create a relationship
                Relationship result = apiInstance.PostRelationships(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PostRelationships: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Relationship**](Relationship.md)| Relationship | [optional]  |
{: class="table table-striped"}

### Return type

[**Relationship**](Relationship.md)

<a name="PutContactsContactId"></a>
## [**ExternalContact**](ExternalContact.html) PutContactsContactId (string contactId, ExternalContact body = null)

Update a externalContact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutContactsContactIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact ID
            var body = new ExternalContact(); // ExternalContact | ExternalContact (optional) 

            try
            {
                // Update a externalContact
                ExternalContact result = apiInstance.PutContactsContactId(contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutContactsContactId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact ID |  |
| **body** | [**ExternalContact**](ExternalContact.md)| ExternalContact | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalContact**](ExternalContact.md)

<a name="PutContactsContactIdNotesNoteId"></a>
## [**Note**](Note.html) PutContactsContactIdNotesNoteId (string contactId, string noteId, Note body = null)

Update a note for a contact



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutContactsContactIdNotesNoteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var contactId = contactId_example;  // string | ExternalContact Id
            var noteId = noteId_example;  // string | Note Id
            var body = new Note(); // Note | Note (optional) 

            try
            {
                // Update a note for a contact
                Note result = apiInstance.PutContactsContactIdNotesNoteId(contactId, noteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutContactsContactIdNotesNoteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactId** | **string**| ExternalContact Id |  |
| **noteId** | **string**| Note Id |  |
| **body** | [**Note**](Note.md)| Note | [optional]  |
{: class="table table-striped"}

### Return type

[**Note**](Note.md)

<a name="PutOrganizationsExternalorganizationId"></a>
## [**ExternalOrganization**](ExternalOrganization.html) PutOrganizationsExternalorganizationId (string externalOrganizationId, ExternalOrganization body = null)

Update an External Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOrganizationsExternalorganizationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization ID
            var body = new ExternalOrganization(); // ExternalOrganization | ExternalOrganization (optional) 

            try
            {
                // Update an External Organization
                ExternalOrganization result = apiInstance.PutOrganizationsExternalorganizationId(externalOrganizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutOrganizationsExternalorganizationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization ID |  |
| **body** | [**ExternalOrganization**](ExternalOrganization.md)| ExternalOrganization | [optional]  |
{: class="table table-striped"}

### Return type

[**ExternalOrganization**](ExternalOrganization.md)

<a name="PutOrganizationsExternalorganizationIdNotesNoteId"></a>
## [**Note**](Note.html) PutOrganizationsExternalorganizationIdNotesNoteId (string externalOrganizationId, string noteId, Note body = null)

Update a note



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOrganizationsExternalorganizationIdNotesNoteIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var externalOrganizationId = externalOrganizationId_example;  // string | External Organization Id
            var noteId = noteId_example;  // string | Note Id
            var body = new Note(); // Note | Note (optional) 

            try
            {
                // Update a note
                Note result = apiInstance.PutOrganizationsExternalorganizationIdNotesNoteId(externalOrganizationId, noteId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutOrganizationsExternalorganizationIdNotesNoteId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **externalOrganizationId** | **string**| External Organization Id |  |
| **noteId** | **string**| Note Id |  |
| **body** | [**Note**](Note.md)| Note | [optional]  |
{: class="table table-striped"}

### Return type

[**Note**](Note.md)

<a name="PutRelationshipsRelationshipId"></a>
## [**Relationship**](Relationship.html) PutRelationshipsRelationshipId (string relationshipId, Relationship body = null)

Update a relationship



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRelationshipsRelationshipIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ExternalContactsApi();
            var relationshipId = relationshipId_example;  // string | Relationship Id
            var body = new Relationship(); // Relationship | Relationship (optional) 

            try
            {
                // Update a relationship
                Relationship result = apiInstance.PutRelationshipsRelationshipId(relationshipId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.PutRelationshipsRelationshipId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **relationshipId** | **string**| Relationship Id |  |
| **body** | [**Relationship**](Relationship.md)| Relationship | [optional]  |
{: class="table table-striped"}

### Return type

[**Relationship**](Relationship.md)

