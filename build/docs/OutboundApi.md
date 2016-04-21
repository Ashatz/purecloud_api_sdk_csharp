# ININ.PureCloudApi.Api.OutboundApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**OutboundAuditsPost**](OutboundApi.md#outboundauditspost) | **POST** /api/v1/outbound/audits | Retrieves audits for dialer. |
| [**OutboundCallabletimesetsCallabletimesetidDelete**](OutboundApi.md#outboundcallabletimesetscallabletimesetiddelete) | **DELETE** /api/v1/outbound/callabletimesets/{callableTimeSetId} | Delete callable time set |
| [**OutboundCallabletimesetsCallabletimesetidGet**](OutboundApi.md#outboundcallabletimesetscallabletimesetidget) | **GET** /api/v1/outbound/callabletimesets/{callableTimeSetId} | Get callable time set |
| [**OutboundCallabletimesetsCallabletimesetidPut**](OutboundApi.md#outboundcallabletimesetscallabletimesetidput) | **PUT** /api/v1/outbound/callabletimesets/{callableTimeSetId} | Update callable time set |
| [**OutboundCallabletimesetsGet**](OutboundApi.md#outboundcallabletimesetsget) | **GET** /api/v1/outbound/callabletimesets | Query callable time set list |
| [**OutboundCallabletimesetsPost**](OutboundApi.md#outboundcallabletimesetspost) | **POST** /api/v1/outbound/callabletimesets | Create callable time set |
| [**OutboundCallanalysisresponsesetsCallanalysissetidDelete**](OutboundApi.md#outboundcallanalysisresponsesetscallanalysissetiddelete) | **DELETE** /api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId} | Delete a dialer call analysis response set. |
| [**OutboundCallanalysisresponsesetsCallanalysissetidGet**](OutboundApi.md#outboundcallanalysisresponsesetscallanalysissetidget) | **GET** /api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId} | Get a dialer call analysis response set. |
| [**OutboundCallanalysisresponsesetsCallanalysissetidPut**](OutboundApi.md#outboundcallanalysisresponsesetscallanalysissetidput) | **PUT** /api/v1/outbound/callanalysisresponsesets/{callAnalysisSetId} | Update a dialer call analysis response set. |
| [**OutboundCallanalysisresponsesetsGet**](OutboundApi.md#outboundcallanalysisresponsesetsget) | **GET** /api/v1/outbound/callanalysisresponsesets | Query a list of dialer call analysis response sets. |
| [**OutboundCallanalysisresponsesetsPost**](OutboundApi.md#outboundcallanalysisresponsesetspost) | **POST** /api/v1/outbound/callanalysisresponsesets | Create a dialer call analysis response set. |
| [**OutboundCampaignsCampaignidAgentsUseridPut**](OutboundApi.md#outboundcampaignscampaignidagentsuseridput) | **PUT** /api/v1/outbound/campaigns/{campaignId}/agents/{userId} | Send notification that an agent&#39;s state changed  |
| [**OutboundCampaignsCampaignidCallbackSchedulePost**](OutboundApi.md#outboundcampaignscampaignidcallbackschedulepost) | **POST** /api/v1/outbound/campaigns/{campaignId}/callback/schedule | Schedule a Callback for a Dialer Campaign |
| [**OutboundCampaignsCampaignidDelete**](OutboundApi.md#outboundcampaignscampaigniddelete) | **DELETE** /api/v1/outbound/campaigns/{campaignId} | Delete a campaign. |
| [**OutboundCampaignsCampaignidDiagnosticsGet**](OutboundApi.md#outboundcampaignscampaigniddiagnosticsget) | **GET** /api/v1/outbound/campaigns/{campaignId}/diagnostics | Get campaign diagnostics |
| [**OutboundCampaignsCampaignidGet**](OutboundApi.md#outboundcampaignscampaignidget) | **GET** /api/v1/outbound/campaigns/{campaignId} | Get dialer campaign. |
| [**OutboundCampaignsCampaignidPut**](OutboundApi.md#outboundcampaignscampaignidput) | **PUT** /api/v1/outbound/campaigns/{campaignId} | Update a campaign. |
| [**OutboundCampaignsCampaignidStatsGet**](OutboundApi.md#outboundcampaignscampaignidstatsget) | **GET** /api/v1/outbound/campaigns/{campaignId}/stats | Get statistics about a Dialer Campaign |
| [**OutboundCampaignsGet**](OutboundApi.md#outboundcampaignsget) | **GET** /api/v1/outbound/campaigns | Query a list of dialer campaigns. |
| [**OutboundCampaignsPost**](OutboundApi.md#outboundcampaignspost) | **POST** /api/v1/outbound/campaigns | Create a campaign. |
| [**OutboundContactlistsContactlistidCampaignidPenetrationrateGet**](OutboundApi.md#outboundcontactlistscontactlistidcampaignidpenetrationrateget) | **GET** /api/v1/outbound/contactlists/{contactListId}/{campaignId}/penetrationrate | Get Dialer campaign&#39;s penetration rate |
| [**OutboundContactlistsContactlistidContactsContactidDelete**](OutboundApi.md#outboundcontactlistscontactlistidcontactscontactiddelete) | **DELETE** /api/v1/outbound/contactlists/{contactListId}/contacts/{contactId} | Delete a contact. |
| [**OutboundContactlistsContactlistidContactsContactidGet**](OutboundApi.md#outboundcontactlistscontactlistidcontactscontactidget) | **GET** /api/v1/outbound/contactlists/{contactListId}/contacts/{contactId} | Get dialer contactList. |
| [**OutboundContactlistsContactlistidContactsContactidPut**](OutboundApi.md#outboundcontactlistscontactlistidcontactscontactidput) | **PUT** /api/v1/outbound/contactlists/{contactListId}/contacts/{contactId} | Update a contact. |
| [**OutboundContactlistsContactlistidContactsPost**](OutboundApi.md#outboundcontactlistscontactlistidcontactspost) | **POST** /api/v1/outbound/contactlists/{contactListId}/contacts | Add contacts to a contact list. |
| [**OutboundContactlistsContactlistidDelete**](OutboundApi.md#outboundcontactlistscontactlistiddelete) | **DELETE** /api/v1/outbound/contactlists/{contactListId} | Delete a contact list. |
| [**OutboundContactlistsContactlistidExportPost**](OutboundApi.md#outboundcontactlistscontactlistidexportpost) | **POST** /api/v1/outbound/contactlists/{contactListId}/export | Initiate the export of a contact list. |
| [**OutboundContactlistsContactlistidGet**](OutboundApi.md#outboundcontactlistscontactlistidget) | **GET** /api/v1/outbound/contactlists/{contactListId} | Get dialer contactList. |
| [**OutboundContactlistsContactlistidImportstatusGet**](OutboundApi.md#outboundcontactlistscontactlistidimportstatusget) | **GET** /api/v1/outbound/contactlists/{contactListId}/importstatus | Get dialer contactList import status. |
| [**OutboundContactlistsContactlistidPut**](OutboundApi.md#outboundcontactlistscontactlistidput) | **PUT** /api/v1/outbound/contactlists/{contactListId} | Update a contact list. |
| [**OutboundContactlistsGet**](OutboundApi.md#outboundcontactlistsget) | **GET** /api/v1/outbound/contactlists | Query a list of contact lists. |
| [**OutboundContactlistsPenetrationratesPost**](OutboundApi.md#outboundcontactlistspenetrationratespost) | **POST** /api/v1/outbound/contactlists/penetrationrates | Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id) |
| [**OutboundContactlistsPost**](OutboundApi.md#outboundcontactlistspost) | **POST** /api/v1/outbound/contactlists | Create a contact List. |
| [**OutboundConversationsConversationidDncPost**](OutboundApi.md#outboundconversationsconversationiddncpost) | **POST** /api/v1/outbound/conversations/{conversationId}/dnc | Add phone numbers to a Dialer DNC list. |
| [**OutboundDnclistsDnclistidDelete**](OutboundApi.md#outbounddnclistsdnclistiddelete) | **DELETE** /api/v1/outbound/dnclists/{dncListId} | Delete dialer DNC list |
| [**OutboundDnclistsDnclistidExportPost**](OutboundApi.md#outbounddnclistsdnclistidexportpost) | **POST** /api/v1/outbound/dnclists/{dncListId}/export | Initiate the export of a dnc list. |
| [**OutboundDnclistsDnclistidGet**](OutboundApi.md#outbounddnclistsdnclistidget) | **GET** /api/v1/outbound/dnclists/{dncListId} | Get dialer DNC list |
| [**OutboundDnclistsDnclistidImportstatusGet**](OutboundApi.md#outbounddnclistsdnclistidimportstatusget) | **GET** /api/v1/outbound/dnclists/{dncListId}/importstatus | Get dialer dncList import status. |
| [**OutboundDnclistsDnclistidPhonenumbersPost**](OutboundApi.md#outbounddnclistsdnclistidphonenumberspost) | **POST** /api/v1/outbound/dnclists/{dncListId}/phonenumbers | Add phone numbers to a Dialer DNC list. |
| [**OutboundDnclistsDnclistidPut**](OutboundApi.md#outbounddnclistsdnclistidput) | **PUT** /api/v1/outbound/dnclists/{dncListId} | Update dialer DNC list |
| [**OutboundDnclistsGet**](OutboundApi.md#outbounddnclistsget) | **GET** /api/v1/outbound/dnclists | Query dialer DNC lists |
| [**OutboundDnclistsPost**](OutboundApi.md#outbounddnclistspost) | **POST** /api/v1/outbound/dnclists | Create dialer DNC list |
| [**OutboundPreviewsGet**](OutboundApi.md#outboundpreviewsget) | **GET** /api/v1/outbound/previews | Get dialer preview for user |
| [**OutboundPreviewsPreviewidDispositioncallPost**](OutboundApi.md#outboundpreviewspreviewiddispositioncallpost) | **POST** /api/v1/outbound/previews/{previewId}/dispositioncall | Disposition preview call |
| [**OutboundPreviewsPreviewidGet**](OutboundApi.md#outboundpreviewspreviewidget) | **GET** /api/v1/outbound/previews/{previewId} | Get dialer preview |
| [**OutboundPreviewsPreviewidPlacecallPost**](OutboundApi.md#outboundpreviewspreviewidplacecallpost) | **POST** /api/v1/outbound/previews/{previewId}/placecall | place preview call |
| [**OutboundRulesetsGet**](OutboundApi.md#outboundrulesetsget) | **GET** /api/v1/outbound/rulesets | Query a list of Rule Sets. |
| [**OutboundRulesetsPost**](OutboundApi.md#outboundrulesetspost) | **POST** /api/v1/outbound/rulesets | Create a Dialer Call Analysis Response Set. |
| [**OutboundRulesetsRulesetidDelete**](OutboundApi.md#outboundrulesetsrulesetiddelete) | **DELETE** /api/v1/outbound/rulesets/{ruleSetId} | Delete a Rule set. |
| [**OutboundRulesetsRulesetidGet**](OutboundApi.md#outboundrulesetsrulesetidget) | **GET** /api/v1/outbound/rulesets/{ruleSetId} | Get a Rule Set by ID. |
| [**OutboundRulesetsRulesetidPut**](OutboundApi.md#outboundrulesetsrulesetidput) | **PUT** /api/v1/outbound/rulesets/{ruleSetId} | Update a RuleSet. |
| [**OutboundSchedulesCampaignsCampaignidDelete**](OutboundApi.md#outboundschedulescampaignscampaigniddelete) | **DELETE** /api/v1/outbound/schedules/campaigns/{campaignId} | Delete a dialer campaign schedule. |
| [**OutboundSchedulesCampaignsCampaignidGet**](OutboundApi.md#outboundschedulescampaignscampaignidget) | **GET** /api/v1/outbound/schedules/campaigns/{campaignId} | Get a dialer campaign schedule. |
| [**OutboundSchedulesCampaignsCampaignidPut**](OutboundApi.md#outboundschedulescampaignscampaignidput) | **PUT** /api/v1/outbound/schedules/campaigns/{campaignId} | Update a new campaign schedule. |
| [**OutboundSchedulesCampaignsGet**](OutboundApi.md#outboundschedulescampaignsget) | **GET** /api/v1/outbound/schedules/campaigns | Query for a list of dialer campaign schedules. |
| [**OutboundSchedulesSequencesGet**](OutboundApi.md#outboundschedulessequencesget) | **GET** /api/v1/outbound/schedules/sequences | Query for a list of dialer sequence schedules. |
| [**OutboundSchedulesSequencesSequenceidDelete**](OutboundApi.md#outboundschedulessequencessequenceiddelete) | **DELETE** /api/v1/outbound/schedules/sequences/{sequenceId} | Delete a dialer sequence schedule. |
| [**OutboundSchedulesSequencesSequenceidGet**](OutboundApi.md#outboundschedulessequencessequenceidget) | **GET** /api/v1/outbound/schedules/sequences/{sequenceId} | Get a dialer sequence schedule. |
| [**OutboundSchedulesSequencesSequenceidPut**](OutboundApi.md#outboundschedulessequencessequenceidput) | **PUT** /api/v1/outbound/schedules/sequences/{sequenceId} | Update a new sequence schedule. |
| [**OutboundSequencesGet**](OutboundApi.md#outboundsequencesget) | **GET** /api/v1/outbound/sequences | Query a list of dialer campaign sequences. |
| [**OutboundSequencesPost**](OutboundApi.md#outboundsequencespost) | **POST** /api/v1/outbound/sequences | Create a new campaign sequence. |
| [**OutboundSequencesSequenceidDelete**](OutboundApi.md#outboundsequencessequenceiddelete) | **DELETE** /api/v1/outbound/sequences/{sequenceId} | Delete a dialer campaign sequence. |
| [**OutboundSequencesSequenceidGet**](OutboundApi.md#outboundsequencessequenceidget) | **GET** /api/v1/outbound/sequences/{sequenceId} | Get a dialer campaign sequence. |
| [**OutboundSequencesSequenceidPut**](OutboundApi.md#outboundsequencessequenceidput) | **PUT** /api/v1/outbound/sequences/{sequenceId} | Update a new campaign sequence. |
| [**OutboundWrapupcodemappingsGet**](OutboundApi.md#outboundwrapupcodemappingsget) | **GET** /api/v1/outbound/wrapupcodemappings | Get the Dialer wrap up code mapping. |
| [**OutboundWrapupcodemappingsPut**](OutboundApi.md#outboundwrapupcodemappingsput) | **PUT** /api/v1/outbound/wrapupcodemappings | Update the Dialer wrap up code mapping. |
{: class="table table-striped"}

<a name="OutboundAuditsPost"></a>
## [**AuditSearchResult**](AuditSearchResult.html) OutboundAuditsPost (DialerAuditRequest body = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)

Retrieves audits for dialer.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundAuditsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new DialerAuditRequest(); // DialerAuditRequest | AuditSearch (optional) 
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to entity.name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var facetsOnly = true;  // bool? | Facets only (optional)  (default to false)

            try
            {
                // Retrieves audits for dialer.
                AuditSearchResult result = apiInstance.OutboundAuditsPost(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundAuditsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DialerAuditRequest**](DialerAuditRequest.md)| AuditSearch | [optional]  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to entity.name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending] |
| **facetsOnly** | **bool?**| Facets only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AuditSearchResult**](AuditSearchResult.md)

<a name="OutboundCallabletimesetsCallabletimesetidDelete"></a>
## string** OutboundCallabletimesetsCallabletimesetidDelete (string callableTimeSetId)

Delete callable time set



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallabletimesetsCallabletimesetidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID

            try
            {
                // Delete callable time set
                string result = apiInstance.OutboundCallabletimesetsCallabletimesetidDelete(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallabletimesetsCallabletimesetidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundCallabletimesetsCallabletimesetidGet"></a>
## [**CallableTimeSet**](CallableTimeSet.html) OutboundCallabletimesetsCallabletimesetidGet (string callableTimeSetId)

Get callable time set



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallabletimesetsCallabletimesetidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID

            try
            {
                // Get callable time set
                CallableTimeSet result = apiInstance.OutboundCallabletimesetsCallabletimesetidGet(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallabletimesetsCallabletimesetidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.md)

<a name="OutboundCallabletimesetsCallabletimesetidPut"></a>
## [**CallableTimeSet**](CallableTimeSet.html) OutboundCallabletimesetsCallabletimesetidPut (string callableTimeSetId, CallableTimeSet body = null)

Update callable time set



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallabletimesetsCallabletimesetidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet (optional) 

            try
            {
                // Update callable time set
                CallableTimeSet result = apiInstance.OutboundCallabletimesetsCallabletimesetidPut(callableTimeSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallabletimesetsCallabletimesetidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
| **body** | [**CallableTimeSet**](CallableTimeSet.md)| DialerCallableTimeSet | [optional]  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.md)

<a name="OutboundCallabletimesetsGet"></a>
## [**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html) OutboundCallabletimesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query callable time set list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallabletimesetsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            {
                // Query callable time set list
                CallableTimeSetEntityListing result = apiInstance.OutboundCallabletimesetsGet(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallabletimesetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.md)

<a name="OutboundCallabletimesetsPost"></a>
## [**CallableTimeSet**](CallableTimeSet.html) OutboundCallabletimesetsPost (CallableTimeSet body = null)

Create callable time set



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallabletimesetsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet (optional) 

            try
            {
                // Create callable time set
                CallableTimeSet result = apiInstance.OutboundCallabletimesetsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallabletimesetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CallableTimeSet**](CallableTimeSet.md)| DialerCallableTimeSet | [optional]  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.md)

<a name="OutboundCallanalysisresponsesetsCallanalysissetidDelete"></a>
## string** OutboundCallanalysisresponsesetsCallanalysissetidDelete (string callAnalysisSetId)

Delete a dialer call analysis response set.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallanalysisresponsesetsCallanalysissetidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID

            try
            {
                // Delete a dialer call analysis response set.
                string result = apiInstance.OutboundCallanalysisresponsesetsCallanalysissetidDelete(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallanalysisresponsesetsCallanalysissetidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundCallanalysisresponsesetsCallanalysissetidGet"></a>
## [**ResponseSet**](ResponseSet.html) OutboundCallanalysisresponsesetsCallanalysissetidGet (string callAnalysisSetId)

Get a dialer call analysis response set.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallanalysisresponsesetsCallanalysissetidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID

            try
            {
                // Get a dialer call analysis response set.
                ResponseSet result = apiInstance.OutboundCallanalysisresponsesetsCallanalysissetidGet(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallanalysisresponsesetsCallanalysissetidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.md)

<a name="OutboundCallanalysisresponsesetsCallanalysissetidPut"></a>
## [**ResponseSet**](ResponseSet.html) OutboundCallanalysisresponsesetsCallanalysissetidPut (string callAnalysisSetId, ResponseSet body = null)

Update a dialer call analysis response set.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallanalysisresponsesetsCallanalysissetidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            var body = new ResponseSet(); // ResponseSet | ResponseSet (optional) 

            try
            {
                // Update a dialer call analysis response set.
                ResponseSet result = apiInstance.OutboundCallanalysisresponsesetsCallanalysissetidPut(callAnalysisSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallanalysisresponsesetsCallanalysissetidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
| **body** | [**ResponseSet**](ResponseSet.md)| ResponseSet | [optional]  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.md)

<a name="OutboundCallanalysisresponsesetsGet"></a>
## [**ResponseSetEntityListing**](ResponseSetEntityListing.html) OutboundCallanalysisresponsesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of dialer call analysis response sets.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallanalysisresponsesetsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            {
                // Query a list of dialer call analysis response sets.
                ResponseSetEntityListing result = apiInstance.OutboundCallanalysisresponsesetsGet(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallanalysisresponsesetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**ResponseSetEntityListing**](ResponseSetEntityListing.md)

<a name="OutboundCallanalysisresponsesetsPost"></a>
## [**ResponseSet**](ResponseSet.html) OutboundCallanalysisresponsesetsPost (ResponseSet body = null)

Create a dialer call analysis response set.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCallanalysisresponsesetsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new ResponseSet(); // ResponseSet | ResponseSet (optional) 

            try
            {
                // Create a dialer call analysis response set.
                ResponseSet result = apiInstance.OutboundCallanalysisresponsesetsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCallanalysisresponsesetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseSet**](ResponseSet.md)| ResponseSet | [optional]  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.md)

<a name="OutboundCampaignsCampaignidAgentsUseridPut"></a>
## string** OutboundCampaignsCampaignidAgentsUseridPut (string campaignId, string userId, Agent body = null)

Send notification that an agent's state changed 

New agent state.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidAgentsUseridPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var userId = userId_example;  // string | Agent's user ID
            var body = new Agent(); // Agent | agent (optional) 

            try
            {
                // Send notification that an agent's state changed 
                string result = apiInstance.OutboundCampaignsCampaignidAgentsUseridPut(campaignId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidAgentsUseridPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **userId** | **string**| Agent&#39;s user ID |  |
| **body** | [**Agent**](Agent.md)| agent | [optional]  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundCampaignsCampaignidCallbackSchedulePost"></a>
## [**ContactCallbackRequest**](ContactCallbackRequest.html) OutboundCampaignsCampaignidCallbackSchedulePost (string campaignId, ContactCallbackRequest body = null)

Schedule a Callback for a Dialer Campaign



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidCallbackSchedulePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new ContactCallbackRequest(); // ContactCallbackRequest | ContactCallbackRequest (optional) 

            try
            {
                // Schedule a Callback for a Dialer Campaign
                ContactCallbackRequest result = apiInstance.OutboundCampaignsCampaignidCallbackSchedulePost(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidCallbackSchedulePost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**ContactCallbackRequest**](ContactCallbackRequest.md)| ContactCallbackRequest | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactCallbackRequest**](ContactCallbackRequest.md)

<a name="OutboundCampaignsCampaignidDelete"></a>
## string** OutboundCampaignsCampaignidDelete (string campaignId)

Delete a campaign.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Delete a campaign.
                string result = apiInstance.OutboundCampaignsCampaignidDelete(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundCampaignsCampaignidDiagnosticsGet"></a>
## [**CampaignDiagnostics**](CampaignDiagnostics.html) OutboundCampaignsCampaignidDiagnosticsGet (string campaignId)

Get campaign diagnostics



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidDiagnosticsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get campaign diagnostics
                CampaignDiagnostics result = apiInstance.OutboundCampaignsCampaignidDiagnosticsGet(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidDiagnosticsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignDiagnostics**](CampaignDiagnostics.md)

<a name="OutboundCampaignsCampaignidGet"></a>
## [**Campaign**](Campaign.html) OutboundCampaignsCampaignidGet (string campaignId)

Get dialer campaign.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get dialer campaign.
                Campaign result = apiInstance.OutboundCampaignsCampaignidGet(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.md)

<a name="OutboundCampaignsCampaignidPut"></a>
## [**Campaign**](Campaign.html) OutboundCampaignsCampaignidPut (string campaignId, Campaign body = null)

Update a campaign.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new Campaign(); // Campaign | Campaign (optional) 

            try
            {
                // Update a campaign.
                Campaign result = apiInstance.OutboundCampaignsCampaignidPut(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**Campaign**](Campaign.md)| Campaign | [optional]  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.md)

<a name="OutboundCampaignsCampaignidStatsGet"></a>
## [**CampaignStats**](CampaignStats.html) OutboundCampaignsCampaignidStatsGet (string campaignId)

Get statistics about a Dialer Campaign



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsCampaignidStatsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get statistics about a Dialer Campaign
                CampaignStats result = apiInstance.OutboundCampaignsCampaignidStatsGet(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsCampaignidStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignStats**](CampaignStats.md)

<a name="OutboundCampaignsGet"></a>
## [**CampaignEntityListing**](CampaignEntityListing.html) OutboundCampaignsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)

Query a list of dialer campaigns.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var contactListId = contactListId_example;  // string | Contact List ID (optional) 
            var dncListId = dncListId_example;  // string | DNC list ID (optional) 
            var distributionQueueId = distributionQueueId_example;  // string | Distribution queue ID (optional) 
            var edgeGroupId = edgeGroupId_example;  // string | Edge group ID (optional) 
            var callAnalysisResponseSetId = callAnalysisResponseSetId_example;  // string | Call analysis response set ID (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            {
                // Query a list of dialer campaigns.
                CampaignEntityListing result = apiInstance.OutboundCampaignsGet(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **contactListId** | **string**| Contact List ID | [optional]  |
| **dncListId** | **string**| DNC list ID | [optional]  |
| **distributionQueueId** | **string**| Distribution queue ID | [optional]  |
| **edgeGroupId** | **string**| Edge group ID | [optional]  |
| **callAnalysisResponseSetId** | **string**| Call analysis response set ID | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**CampaignEntityListing**](CampaignEntityListing.md)

<a name="OutboundCampaignsPost"></a>
## [**Campaign**](Campaign.html) OutboundCampaignsPost (Campaign body = null)

Create a campaign.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundCampaignsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new Campaign(); // Campaign | Campaign (optional) 

            try
            {
                // Create a campaign.
                Campaign result = apiInstance.OutboundCampaignsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundCampaignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Campaign**](Campaign.md)| Campaign | [optional]  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.md)

<a name="OutboundContactlistsContactlistidCampaignidPenetrationrateGet"></a>
## [**PenetrationRate**](PenetrationRate.html) OutboundContactlistsContactlistidCampaignidPenetrationrateGet (string contactListId, string campaignId)

Get Dialer campaign's penetration rate

Get dialer campaign's penetration rate.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidCampaignidPenetrationrateGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get Dialer campaign's penetration rate
                PenetrationRate result = apiInstance.OutboundContactlistsContactlistidCampaignidPenetrationrateGet(contactListId, campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidCampaignidPenetrationrateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**PenetrationRate**](PenetrationRate.md)

<a name="OutboundContactlistsContactlistidContactsContactidDelete"></a>
## string** OutboundContactlistsContactlistidContactsContactidDelete (string contactListId, string contactId)

Delete a contact.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidContactsContactidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID

            try
            {
                // Delete a contact.
                string result = apiInstance.OutboundContactlistsContactlistidContactsContactidDelete(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidContactsContactidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundContactlistsContactlistidContactsContactidGet"></a>
## [**Contact**](Contact.html) OutboundContactlistsContactlistidContactsContactidGet (string contactListId, string contactId)

Get dialer contactList.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidContactsContactidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID

            try
            {
                // Get dialer contactList.
                Contact result = apiInstance.OutboundContactlistsContactlistidContactsContactidGet(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidContactsContactidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

[**Contact**](Contact.md)

<a name="OutboundContactlistsContactlistidContactsContactidPut"></a>
## [**Contact**](Contact.html) OutboundContactlistsContactlistidContactsContactidPut (string contactListId, string contactId, Contact body = null)

Update a contact.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidContactsContactidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID
            var body = new Contact(); // Contact | Contact (optional) 

            try
            {
                // Update a contact.
                Contact result = apiInstance.OutboundContactlistsContactlistidContactsContactidPut(contactListId, contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidContactsContactidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
| **body** | [**Contact**](Contact.md)| Contact | [optional]  |
{: class="table table-striped"}

### Return type

[**Contact**](Contact.md)

<a name="OutboundContactlistsContactlistidContactsPost"></a>
## [**Contact**](Contact.html) OutboundContactlistsContactlistidContactsPost (string contactListId, List<Contact> body = null, bool? priority = null)

Add contacts to a contact list.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidContactsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new List<Contact>(); // List<Contact> | Contact (optional) 
            var priority = true;  // bool? |  (optional) 

            try
            {
                // Add contacts to a contact list.
                Contact result = apiInstance.OutboundContactlistsContactlistidContactsPost(contactListId, body, priority);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidContactsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<Contact>**](Contact.md)| Contact | [optional]  |
| **priority** | **bool?**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Contact**](Contact.md)

<a name="OutboundContactlistsContactlistidDelete"></a>
## string** OutboundContactlistsContactlistidDelete (string contactListId)

Delete a contact list.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            {
                // Delete a contact list.
                string result = apiInstance.OutboundContactlistsContactlistidDelete(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundContactlistsContactlistidExportPost"></a>
## string** OutboundContactlistsContactlistidExportPost (string contactListId)

Initiate the export of a contact list.

Returns 200 if received OK.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidExportPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            {
                // Initiate the export of a contact list.
                string result = apiInstance.OutboundContactlistsContactlistidExportPost(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidExportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundContactlistsContactlistidGet"></a>
## [**ContactList**](ContactList.html) OutboundContactlistsContactlistidGet (string contactListId, bool? importStatus = null, bool? includeSize = null)

Get dialer contactList.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var importStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            {
                // Get dialer contactList.
                ContactList result = apiInstance.OutboundContactlistsContactlistidGet(contactListId, importStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **importStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.md)

<a name="OutboundContactlistsContactlistidImportstatusGet"></a>
## [**ImportStatus**](ImportStatus.html) OutboundContactlistsContactlistidImportstatusGet (string contactListId)

Get dialer contactList import status.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidImportstatusGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID

            try
            {
                // Get dialer contactList import status.
                ImportStatus result = apiInstance.OutboundContactlistsContactlistidImportstatusGet(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidImportstatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.md)

<a name="OutboundContactlistsContactlistidPut"></a>
## [**ContactList**](ContactList.html) OutboundContactlistsContactlistidPut (string contactListId, ContactList body = null)

Update a contact list.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsContactlistidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var body = new ContactList(); // ContactList | ContactList (optional) 

            try
            {
                // Update a contact list.
                ContactList result = apiInstance.OutboundContactlistsContactlistidPut(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsContactlistidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactList**](ContactList.md)| ContactList | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.md)

<a name="OutboundContactlistsGet"></a>
## [**ContactListEntityListing**](ContactListEntityListing.html) OutboundContactlistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of contact lists.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var importStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            {
                // Query a list of contact lists.
                ContactListEntityListing result = apiInstance.OutboundContactlistsGet(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**ContactListEntityListing**](ContactListEntityListing.md)

<a name="OutboundContactlistsPenetrationratesPost"></a>
## [**List&lt;PenetrationRate&gt;**](PenetrationRate.html) OutboundContactlistsPenetrationratesPost (List<PenetrationRateId> body = null)

Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsPenetrationratesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new List<PenetrationRateId>(); // List<PenetrationRateId> | PenetrationRateIdentifierList (optional) 

            try
            {
                // Get penetration rates for a list of penetration rate identifiers (contact list id and qualifier id)
                List&lt;PenetrationRate&gt; result = apiInstance.OutboundContactlistsPenetrationratesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsPenetrationratesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**List<PenetrationRateId>**](PenetrationRateId.md)| PenetrationRateIdentifierList | [optional]  |
{: class="table table-striped"}

### Return type

[**List<PenetrationRate>**](PenetrationRate.md)

<a name="OutboundContactlistsPost"></a>
## [**ContactList**](ContactList.html) OutboundContactlistsPost (ContactList body = null)

Create a contact List.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundContactlistsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new ContactList(); // ContactList | ContactList (optional) 

            try
            {
                // Create a contact List.
                ContactList result = apiInstance.OutboundContactlistsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundContactlistsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactList**](ContactList.md)| ContactList | [optional]  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.md)

<a name="OutboundConversationsConversationidDncPost"></a>
## void OutboundConversationsConversationidDncPost (string conversationId)

Add phone numbers to a Dialer DNC list.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundConversationsConversationidDncPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var conversationId = conversationId_example;  // string | Conversation ID

            try
            {
                // Add phone numbers to a Dialer DNC list.
                apiInstance.OutboundConversationsConversationidDncPost(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundConversationsConversationidDncPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="OutboundDnclistsDnclistidDelete"></a>
## string** OutboundDnclistsDnclistidDelete (string dncListId)

Delete dialer DNC list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsDnclistidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            {
                // Delete dialer DNC list
                string result = apiInstance.OutboundDnclistsDnclistidDelete(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsDnclistidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundDnclistsDnclistidExportPost"></a>
## string** OutboundDnclistsDnclistidExportPost (string dncListId)

Initiate the export of a dnc list.

Returns 200 if received OK.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsDnclistidExportPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            {
                // Initiate the export of a dnc list.
                string result = apiInstance.OutboundDnclistsDnclistidExportPost(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsDnclistidExportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundDnclistsDnclistidGet"></a>
## [**DncList**](DncList.html) OutboundDnclistsDnclistidGet (string dncListId, bool? importStatus = null, bool? includeSize = null)

Get dialer DNC list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsDnclistidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var importStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            {
                // Get dialer DNC list
                DncList result = apiInstance.OutboundDnclistsDnclistidGet(dncListId, importStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsDnclistidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **importStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.md)

<a name="OutboundDnclistsDnclistidImportstatusGet"></a>
## [**ImportStatus**](ImportStatus.html) OutboundDnclistsDnclistidImportstatusGet (string dncListId)

Get dialer dncList import status.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsDnclistidImportstatusGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID

            try
            {
                // Get dialer dncList import status.
                ImportStatus result = apiInstance.OutboundDnclistsDnclistidImportstatusGet(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsDnclistidImportstatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.md)

<a name="OutboundDnclistsDnclistidPhonenumbersPost"></a>
## void OutboundDnclistsDnclistidPhonenumbersPost (string dncListId, List<string> body = null)

Add phone numbers to a Dialer DNC list.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsDnclistidPhonenumbersPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = ;  // List<string> | DNC Phone Numbers (optional) 

            try
            {
                // Add phone numbers to a Dialer DNC list.
                apiInstance.OutboundDnclistsDnclistidPhonenumbersPost(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsDnclistidPhonenumbersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | **List<string>**| DNC Phone Numbers | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="OutboundDnclistsDnclistidPut"></a>
## [**DncList**](DncList.html) OutboundDnclistsDnclistidPut (string dncListId, DncList body = null)

Update dialer DNC list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsDnclistidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncList(); // DncList | DncList (optional) 

            try
            {
                // Update dialer DNC list
                DncList result = apiInstance.OutboundDnclistsDnclistidPut(dncListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsDnclistidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncList**](DncList.md)| DncList | [optional]  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.md)

<a name="OutboundDnclistsGet"></a>
## [**DncListEntityListing**](DncListEntityListing.html) OutboundDnclistsGet (bool? importStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query dialer DNC lists



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var importStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional) 

            try
            {
                // Query dialer DNC lists
                DncListEntityListing result = apiInstance.OutboundDnclistsGet(importStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **importStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**DncListEntityListing**](DncListEntityListing.md)

<a name="OutboundDnclistsPost"></a>
## [**DncList**](DncList.html) OutboundDnclistsPost (DncList body = null)

Create dialer DNC list



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundDnclistsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new DncList(); // DncList | DncList (optional) 

            try
            {
                // Create dialer DNC list
                DncList result = apiInstance.OutboundDnclistsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundDnclistsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DncList**](DncList.md)| DncList | [optional]  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.md)

<a name="OutboundPreviewsGet"></a>
## [**List&lt;Preview&gt;**](Preview.html) OutboundPreviewsGet ()

Get dialer preview for user



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundPreviewsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Get dialer preview for user
                List&lt;Preview&gt; result = apiInstance.OutboundPreviewsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundPreviewsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<Preview>**](Preview.md)

<a name="OutboundPreviewsPreviewidDispositioncallPost"></a>
## string** OutboundPreviewsPreviewidDispositioncallPost (string previewId, DialerDispositionCallCommand body = null)

Disposition preview call



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundPreviewsPreviewidDispositioncallPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var previewId = previewId_example;  // string | preview ID
            var body = new DialerDispositionCallCommand(); // DialerDispositionCallCommand |  (optional) 

            try
            {
                // Disposition preview call
                string result = apiInstance.OutboundPreviewsPreviewidDispositioncallPost(previewId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundPreviewsPreviewidDispositioncallPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **previewId** | **string**| preview ID |  |
| **body** | [**DialerDispositionCallCommand**](DialerDispositionCallCommand.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundPreviewsPreviewidGet"></a>
## [**Preview**](Preview.html) OutboundPreviewsPreviewidGet (string previewId)

Get dialer preview



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundPreviewsPreviewidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var previewId = previewId_example;  // string | preview ID

            try
            {
                // Get dialer preview
                Preview result = apiInstance.OutboundPreviewsPreviewidGet(previewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundPreviewsPreviewidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **previewId** | **string**| preview ID |  |
{: class="table table-striped"}

### Return type

[**Preview**](Preview.md)

<a name="OutboundPreviewsPreviewidPlacecallPost"></a>
## [**DialerCall**](DialerCall.html) OutboundPreviewsPreviewidPlacecallPost (string previewId, DialerPlaceCallCommand body = null)

place preview call



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundPreviewsPreviewidPlacecallPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var previewId = previewId_example;  // string | preview ID
            var body = new DialerPlaceCallCommand(); // DialerPlaceCallCommand |  (optional) 

            try
            {
                // place preview call
                DialerCall result = apiInstance.OutboundPreviewsPreviewidPlacecallPost(previewId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundPreviewsPreviewidPlacecallPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **previewId** | **string**| preview ID |  |
| **body** | [**DialerPlaceCallCommand**](DialerPlaceCallCommand.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**DialerCall**](DialerCall.md)

<a name="OutboundRulesetsGet"></a>
## [**RuleSetEntityListing**](RuleSetEntityListing.html) OutboundRulesetsGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of Rule Sets.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundRulesetsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            {
                // Query a list of Rule Sets.
                RuleSetEntityListing result = apiInstance.OutboundRulesetsGet(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundRulesetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**RuleSetEntityListing**](RuleSetEntityListing.md)

<a name="OutboundRulesetsPost"></a>
## [**RuleSet**](RuleSet.html) OutboundRulesetsPost (RuleSet body = null)

Create a Dialer Call Analysis Response Set.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundRulesetsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new RuleSet(); // RuleSet | RuleSet (optional) 

            try
            {
                // Create a Dialer Call Analysis Response Set.
                RuleSet result = apiInstance.OutboundRulesetsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundRulesetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RuleSet**](RuleSet.md)| RuleSet | [optional]  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.md)

<a name="OutboundRulesetsRulesetidDelete"></a>
## string** OutboundRulesetsRulesetidDelete (string ruleSetId)

Delete a Rule set.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundRulesetsRulesetidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID

            try
            {
                // Delete a Rule set.
                string result = apiInstance.OutboundRulesetsRulesetidDelete(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundRulesetsRulesetidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundRulesetsRulesetidGet"></a>
## [**RuleSet**](RuleSet.html) OutboundRulesetsRulesetidGet (string ruleSetId)

Get a Rule Set by ID.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundRulesetsRulesetidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID

            try
            {
                // Get a Rule Set by ID.
                RuleSet result = apiInstance.OutboundRulesetsRulesetidGet(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundRulesetsRulesetidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.md)

<a name="OutboundRulesetsRulesetidPut"></a>
## [**RuleSet**](RuleSet.html) OutboundRulesetsRulesetidPut (string ruleSetId, RuleSet body = null)

Update a RuleSet.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundRulesetsRulesetidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            var body = new RuleSet(); // RuleSet | RuleSet (optional) 

            try
            {
                // Update a RuleSet.
                RuleSet result = apiInstance.OutboundRulesetsRulesetidPut(ruleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundRulesetsRulesetidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
| **body** | [**RuleSet**](RuleSet.md)| RuleSet | [optional]  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.md)

<a name="OutboundSchedulesCampaignsCampaignidDelete"></a>
## string** OutboundSchedulesCampaignsCampaignidDelete (string campaignId)

Delete a dialer campaign schedule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesCampaignsCampaignidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Delete a dialer campaign schedule.
                string result = apiInstance.OutboundSchedulesCampaignsCampaignidDelete(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesCampaignsCampaignidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundSchedulesCampaignsCampaignidGet"></a>
## [**CampaignSchedule**](CampaignSchedule.html) OutboundSchedulesCampaignsCampaignidGet (string campaignId)

Get a dialer campaign schedule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesCampaignsCampaignidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get a dialer campaign schedule.
                CampaignSchedule result = apiInstance.OutboundSchedulesCampaignsCampaignidGet(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesCampaignsCampaignidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.md)

<a name="OutboundSchedulesCampaignsCampaignidPut"></a>
## [**CampaignSchedule**](CampaignSchedule.html) OutboundSchedulesCampaignsCampaignidPut (string campaignId, CampaignSchedule body = null)

Update a new campaign schedule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesCampaignsCampaignidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new CampaignSchedule(); // CampaignSchedule | CampaignSchedule (optional) 

            try
            {
                // Update a new campaign schedule.
                CampaignSchedule result = apiInstance.OutboundSchedulesCampaignsCampaignidPut(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesCampaignsCampaignidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**CampaignSchedule**](CampaignSchedule.md)| CampaignSchedule | [optional]  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.md)

<a name="OutboundSchedulesCampaignsGet"></a>
## [**List&lt;CampaignSchedule&gt;**](CampaignSchedule.html) OutboundSchedulesCampaignsGet ()

Query for a list of dialer campaign schedules.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesCampaignsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Query for a list of dialer campaign schedules.
                List&lt;CampaignSchedule&gt; result = apiInstance.OutboundSchedulesCampaignsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesCampaignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<CampaignSchedule>**](CampaignSchedule.md)

<a name="OutboundSchedulesSequencesGet"></a>
## [**List&lt;SequenceSchedule&gt;**](SequenceSchedule.html) OutboundSchedulesSequencesGet ()

Query for a list of dialer sequence schedules.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesSequencesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Query for a list of dialer sequence schedules.
                List&lt;SequenceSchedule&gt; result = apiInstance.OutboundSchedulesSequencesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesSequencesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<SequenceSchedule>**](SequenceSchedule.md)

<a name="OutboundSchedulesSequencesSequenceidDelete"></a>
## string** OutboundSchedulesSequencesSequenceidDelete (string sequenceId)

Delete a dialer sequence schedule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesSequencesSequenceidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID

            try
            {
                // Delete a dialer sequence schedule.
                string result = apiInstance.OutboundSchedulesSequencesSequenceidDelete(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesSequencesSequenceidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundSchedulesSequencesSequenceidGet"></a>
## [**SequenceSchedule**](SequenceSchedule.html) OutboundSchedulesSequencesSequenceidGet (string sequenceId)

Get a dialer sequence schedule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesSequencesSequenceidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID

            try
            {
                // Get a dialer sequence schedule.
                SequenceSchedule result = apiInstance.OutboundSchedulesSequencesSequenceidGet(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesSequencesSequenceidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.md)

<a name="OutboundSchedulesSequencesSequenceidPut"></a>
## [**SequenceSchedule**](SequenceSchedule.html) OutboundSchedulesSequencesSequenceidPut (string sequenceId, SequenceSchedule body = null)

Update a new sequence schedule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSchedulesSequencesSequenceidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID
            var body = new SequenceSchedule(); // SequenceSchedule | SequenceSchedule (optional) 

            try
            {
                // Update a new sequence schedule.
                SequenceSchedule result = apiInstance.OutboundSchedulesSequencesSequenceidPut(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSchedulesSequencesSequenceidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
| **body** | [**SequenceSchedule**](SequenceSchedule.md)| SequenceSchedule | [optional]  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.md)

<a name="OutboundSequencesGet"></a>
## [**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html) OutboundSequencesGet (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of dialer campaign sequences.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSequencesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var filterType = filterType_example;  // string | Filter type (optional)  (default to PREFIX)
            var name = name_example;  // string | Name (optional) 
            var sortBy = sortBy_example;  // string | Sort by (optional) 
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to a)

            try
            {
                // Query a list of dialer campaign sequences.
                CampaignSequenceEntityListing result = apiInstance.OutboundSequencesGet(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSequencesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.md)

<a name="OutboundSequencesPost"></a>
## [**CampaignSequence**](CampaignSequence.html) OutboundSequencesPost (CampaignSequence body = null)

Create a new campaign sequence.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSequencesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new CampaignSequence(); // CampaignSequence | Organization (optional) 

            try
            {
                // Create a new campaign sequence.
                CampaignSequence result = apiInstance.OutboundSequencesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSequencesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignSequence**](CampaignSequence.md)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.md)

<a name="OutboundSequencesSequenceidDelete"></a>
## string** OutboundSequencesSequenceidDelete (string sequenceId)

Delete a dialer campaign sequence.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSequencesSequenceidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID

            try
            {
                // Delete a dialer campaign sequence.
                string result = apiInstance.OutboundSequencesSequenceidDelete(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSequencesSequenceidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="OutboundSequencesSequenceidGet"></a>
## [**CampaignSequence**](CampaignSequence.html) OutboundSequencesSequenceidGet (string sequenceId)

Get a dialer campaign sequence.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSequencesSequenceidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID

            try
            {
                // Get a dialer campaign sequence.
                CampaignSequence result = apiInstance.OutboundSequencesSequenceidGet(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSequencesSequenceidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.md)

<a name="OutboundSequencesSequenceidPut"></a>
## [**CampaignSequence**](CampaignSequence.html) OutboundSequencesSequenceidPut (string sequenceId, CampaignSequence body = null)

Update a new campaign sequence.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundSequencesSequenceidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            var body = new CampaignSequence(); // CampaignSequence | Organization (optional) 

            try
            {
                // Update a new campaign sequence.
                CampaignSequence result = apiInstance.OutboundSequencesSequenceidPut(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundSequencesSequenceidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
| **body** | [**CampaignSequence**](CampaignSequence.md)| Organization | [optional]  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.md)

<a name="OutboundWrapupcodemappingsGet"></a>
## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) OutboundWrapupcodemappingsGet ()

Get the Dialer wrap up code mapping.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundWrapupcodemappingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Get the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.OutboundWrapupcodemappingsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundWrapupcodemappingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.md)

<a name="OutboundWrapupcodemappingsPut"></a>
## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) OutboundWrapupcodemappingsPut (WrapUpCodeMapping body = null)

Update the Dialer wrap up code mapping.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class OutboundWrapupcodemappingsPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new WrapUpCodeMapping(); // WrapUpCodeMapping | wrapUpCodeMapping (optional) 

            try
            {
                // Update the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.OutboundWrapupcodemappingsPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.OutboundWrapupcodemappingsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapUpCodeMapping**](WrapUpCodeMapping.md)| wrapUpCodeMapping | [optional]  |
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.md)

