---
title: OutboundApi
---
## ININ.PureCloudApi.Api.OutboundApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCallabletimesetsCallabletimesetId**](OutboundApi.html#deletecallabletimesetscallabletimesetid) | **DELETE** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Delete callable time set |
| [**DeleteCallanalysisresponsesetsCallanalysissetId**](OutboundApi.html#deletecallanalysisresponsesetscallanalysissetid) | **DELETE** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Delete a dialer call analysis response set. |
| [**DeleteCampaignsCampaignId**](OutboundApi.html#deletecampaignscampaignid) | **DELETE** /api/v2/outbound/campaigns/{campaignId} | Delete a campaign. |
| [**DeleteCampaignsCampaignIdProgress**](OutboundApi.html#deletecampaignscampaignidprogress) | **DELETE** /api/v2/outbound/campaigns/{campaignId}/progress | Reset campaign progress and recycle the campaign |
| [**DeleteContactlistsContactlistId**](OutboundApi.html#deletecontactlistscontactlistid) | **DELETE** /api/v2/outbound/contactlists/{contactListId} | Delete a contact list. |
| [**DeleteContactlistsContactlistIdContactsContactId**](OutboundApi.html#deletecontactlistscontactlistidcontactscontactid) | **DELETE** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Delete a contact. |
| [**DeleteDnclistsDnclistId**](OutboundApi.html#deletednclistsdnclistid) | **DELETE** /api/v2/outbound/dnclists/{dncListId} | Delete dialer DNC list |
| [**DeleteRulesetsRulesetId**](OutboundApi.html#deleterulesetsrulesetid) | **DELETE** /api/v2/outbound/rulesets/{ruleSetId} | Delete a Rule set. |
| [**DeleteSchedulesCampaignsCampaignId**](OutboundApi.html#deleteschedulescampaignscampaignid) | **DELETE** /api/v2/outbound/schedules/campaigns/{campaignId} | Delete a dialer campaign schedule. |
| [**DeleteSchedulesSequencesSequenceId**](OutboundApi.html#deleteschedulessequencessequenceid) | **DELETE** /api/v2/outbound/schedules/sequences/{sequenceId} | Delete a dialer sequence schedule. |
| [**DeleteSequencesSequenceId**](OutboundApi.html#deletesequencessequenceid) | **DELETE** /api/v2/outbound/sequences/{sequenceId} | Delete a dialer campaign sequence. |
| [**GetCallabletimesets**](OutboundApi.html#getcallabletimesets) | **GET** /api/v2/outbound/callabletimesets | Query callable time set list |
| [**GetCallabletimesetsCallabletimesetId**](OutboundApi.html#getcallabletimesetscallabletimesetid) | **GET** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Get callable time set |
| [**GetCallanalysisresponsesets**](OutboundApi.html#getcallanalysisresponsesets) | **GET** /api/v2/outbound/callanalysisresponsesets | Query a list of dialer call analysis response sets. |
| [**GetCallanalysisresponsesetsCallanalysissetId**](OutboundApi.html#getcallanalysisresponsesetscallanalysissetid) | **GET** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Get a dialer call analysis response set. |
| [**GetCampaigns**](OutboundApi.html#getcampaigns) | **GET** /api/v2/outbound/campaigns | Query a list of dialer campaigns. |
| [**GetCampaignsCampaignId**](OutboundApi.html#getcampaignscampaignid) | **GET** /api/v2/outbound/campaigns/{campaignId} | Get dialer campaign. |
| [**GetCampaignsCampaignIdDiagnostics**](OutboundApi.html#getcampaignscampaigniddiagnostics) | **GET** /api/v2/outbound/campaigns/{campaignId}/diagnostics | Get campaign diagnostics |
| [**GetCampaignsCampaignIdInteractions**](OutboundApi.html#getcampaignscampaignidinteractions) | **GET** /api/v2/outbound/campaigns/{campaignId}/interactions | Get dialer campaign interactions. |
| [**GetCampaignsCampaignIdProgress**](OutboundApi.html#getcampaignscampaignidprogress) | **GET** /api/v2/outbound/campaigns/{campaignId}/progress | Get campaign progress |
| [**GetCampaignsCampaignIdStats**](OutboundApi.html#getcampaignscampaignidstats) | **GET** /api/v2/outbound/campaigns/{campaignId}/stats | Get statistics about a Dialer Campaign |
| [**GetContactlists**](OutboundApi.html#getcontactlists) | **GET** /api/v2/outbound/contactlists | Query a list of contact lists. |
| [**GetContactlistsContactlistId**](OutboundApi.html#getcontactlistscontactlistid) | **GET** /api/v2/outbound/contactlists/{contactListId} | Get a dialer contact list. |
| [**GetContactlistsContactlistIdContactsContactId**](OutboundApi.html#getcontactlistscontactlistidcontactscontactid) | **GET** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Get a contact. |
| [**GetContactlistsContactlistIdExport**](OutboundApi.html#getcontactlistscontactlistidexport) | **GET** /api/v2/outbound/contactlists/{contactListId}/export | Get the URI of a contact list export. |
| [**GetContactlistsContactlistIdImportstatus**](OutboundApi.html#getcontactlistscontactlistidimportstatus) | **GET** /api/v2/outbound/contactlists/{contactListId}/importstatus | Get dialer contactList import status. |
| [**GetDnclists**](OutboundApi.html#getdnclists) | **GET** /api/v2/outbound/dnclists | Query dialer DNC lists |
| [**GetDnclistsDnclistId**](OutboundApi.html#getdnclistsdnclistid) | **GET** /api/v2/outbound/dnclists/{dncListId} | Get dialer DNC list |
| [**GetDnclistsDnclistIdExport**](OutboundApi.html#getdnclistsdnclistidexport) | **GET** /api/v2/outbound/dnclists/{dncListId}/export | Get the URI of a DNC list export. |
| [**GetDnclistsDnclistIdImportstatus**](OutboundApi.html#getdnclistsdnclistidimportstatus) | **GET** /api/v2/outbound/dnclists/{dncListId}/importstatus | Get dialer dncList import status. |
| [**GetRulesets**](OutboundApi.html#getrulesets) | **GET** /api/v2/outbound/rulesets | Query a list of Rule Sets. |
| [**GetRulesetsRulesetId**](OutboundApi.html#getrulesetsrulesetid) | **GET** /api/v2/outbound/rulesets/{ruleSetId} | Get a Rule Set by ID. |
| [**GetSchedulesCampaigns**](OutboundApi.html#getschedulescampaigns) | **GET** /api/v2/outbound/schedules/campaigns | Query for a list of dialer campaign schedules. |
| [**GetSchedulesCampaignsCampaignId**](OutboundApi.html#getschedulescampaignscampaignid) | **GET** /api/v2/outbound/schedules/campaigns/{campaignId} | Get a dialer campaign schedule. |
| [**GetSchedulesSequences**](OutboundApi.html#getschedulessequences) | **GET** /api/v2/outbound/schedules/sequences | Query for a list of dialer sequence schedules. |
| [**GetSchedulesSequencesSequenceId**](OutboundApi.html#getschedulessequencessequenceid) | **GET** /api/v2/outbound/schedules/sequences/{sequenceId} | Get a dialer sequence schedule. |
| [**GetSequences**](OutboundApi.html#getsequences) | **GET** /api/v2/outbound/sequences | Query a list of dialer campaign sequences. |
| [**GetSequencesSequenceId**](OutboundApi.html#getsequencessequenceid) | **GET** /api/v2/outbound/sequences/{sequenceId} | Get a dialer campaign sequence. |
| [**GetWrapupcodemappings**](OutboundApi.html#getwrapupcodemappings) | **GET** /api/v2/outbound/wrapupcodemappings | Get the Dialer wrap up code mapping. |
| [**PostAudits**](OutboundApi.html#postaudits) | **POST** /api/v2/outbound/audits | Retrieves audits for dialer. |
| [**PostCallabletimesets**](OutboundApi.html#postcallabletimesets) | **POST** /api/v2/outbound/callabletimesets | Create callable time set |
| [**PostCallanalysisresponsesets**](OutboundApi.html#postcallanalysisresponsesets) | **POST** /api/v2/outbound/callanalysisresponsesets | Create a dialer call analysis response set. |
| [**PostCampaigns**](OutboundApi.html#postcampaigns) | **POST** /api/v2/outbound/campaigns | Create a campaign. |
| [**PostCampaignsCampaignIdCallbackSchedule**](OutboundApi.html#postcampaignscampaignidcallbackschedule) | **POST** /api/v2/outbound/campaigns/{campaignId}/callback/schedule | Schedule a Callback for a Dialer Campaign |
| [**PostCampaignsProgress**](OutboundApi.html#postcampaignsprogress) | **POST** /api/v2/outbound/campaigns/progress | Get progress for a list of campaigns |
| [**PostContactlists**](OutboundApi.html#postcontactlists) | **POST** /api/v2/outbound/contactlists | Create a contact List. |
| [**PostContactlistsContactlistIdContacts**](OutboundApi.html#postcontactlistscontactlistidcontacts) | **POST** /api/v2/outbound/contactlists/{contactListId}/contacts | Add contacts to a contact list. |
| [**PostContactlistsContactlistIdExport**](OutboundApi.html#postcontactlistscontactlistidexport) | **POST** /api/v2/outbound/contactlists/{contactListId}/export | Initiate the export of a contact list. |
| [**PostConversationsConversationIdDnc**](OutboundApi.html#postconversationsconversationiddnc) | **POST** /api/v2/outbound/conversations/{conversationId}/dnc | Add phone numbers to a Dialer DNC list. |
| [**PostDnclists**](OutboundApi.html#postdnclists) | **POST** /api/v2/outbound/dnclists | Create dialer DNC list |
| [**PostDnclistsDnclistIdExport**](OutboundApi.html#postdnclistsdnclistidexport) | **POST** /api/v2/outbound/dnclists/{dncListId}/export | Initiate the export of a dnc list. |
| [**PostDnclistsDnclistIdPhonenumbers**](OutboundApi.html#postdnclistsdnclistidphonenumbers) | **POST** /api/v2/outbound/dnclists/{dncListId}/phonenumbers | Add phone numbers to a Dialer DNC list. |
| [**PostRulesets**](OutboundApi.html#postrulesets) | **POST** /api/v2/outbound/rulesets | Create a Dialer Call Analysis Response Set. |
| [**PostSequences**](OutboundApi.html#postsequences) | **POST** /api/v2/outbound/sequences | Create a new campaign sequence. |
| [**PutCallabletimesetsCallabletimesetId**](OutboundApi.html#putcallabletimesetscallabletimesetid) | **PUT** /api/v2/outbound/callabletimesets/{callableTimeSetId} | Update callable time set |
| [**PutCallanalysisresponsesetsCallanalysissetId**](OutboundApi.html#putcallanalysisresponsesetscallanalysissetid) | **PUT** /api/v2/outbound/callanalysisresponsesets/{callAnalysisSetId} | Update a dialer call analysis response set. |
| [**PutCampaignsCampaignId**](OutboundApi.html#putcampaignscampaignid) | **PUT** /api/v2/outbound/campaigns/{campaignId} | Update a campaign. |
| [**PutCampaignsCampaignIdAgentsUserId**](OutboundApi.html#putcampaignscampaignidagentsuserid) | **PUT** /api/v2/outbound/campaigns/{campaignId}/agents/{userId} | Send notification that an agent&#39;s state changed  |
| [**PutContactlistsContactlistId**](OutboundApi.html#putcontactlistscontactlistid) | **PUT** /api/v2/outbound/contactlists/{contactListId} | Update a contact list. |
| [**PutContactlistsContactlistIdContactsContactId**](OutboundApi.html#putcontactlistscontactlistidcontactscontactid) | **PUT** /api/v2/outbound/contactlists/{contactListId}/contacts/{contactId} | Update a contact. |
| [**PutDnclistsDnclistId**](OutboundApi.html#putdnclistsdnclistid) | **PUT** /api/v2/outbound/dnclists/{dncListId} | Update dialer DNC list |
| [**PutRulesetsRulesetId**](OutboundApi.html#putrulesetsrulesetid) | **PUT** /api/v2/outbound/rulesets/{ruleSetId} | Update a RuleSet. |
| [**PutSchedulesCampaignsCampaignId**](OutboundApi.html#putschedulescampaignscampaignid) | **PUT** /api/v2/outbound/schedules/campaigns/{campaignId} | Update a new campaign schedule. |
| [**PutSchedulesSequencesSequenceId**](OutboundApi.html#putschedulessequencessequenceid) | **PUT** /api/v2/outbound/schedules/sequences/{sequenceId} | Update a new sequence schedule. |
| [**PutSequencesSequenceId**](OutboundApi.html#putsequencessequenceid) | **PUT** /api/v2/outbound/sequences/{sequenceId} | Update a new campaign sequence. |
| [**PutWrapupcodemappings**](OutboundApi.html#putwrapupcodemappings) | **PUT** /api/v2/outbound/wrapupcodemappings | Update the Dialer wrap up code mapping. |
{: class="table table-striped"}

<a name="deletecallabletimesetscallabletimesetid"></a>

## **string** DeleteCallabletimesetsCallabletimesetId (string callableTimeSetId)

Delete callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCallabletimesetsCallabletimesetIdExample
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
                string result = apiInstance.DeleteCallabletimesetsCallabletimesetId(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteCallabletimesetsCallabletimesetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletecallanalysisresponsesetscallanalysissetid"></a>

## **string** DeleteCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId)

Delete a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCallanalysisresponsesetsCallanalysissetIdExample
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
                string result = apiInstance.DeleteCallanalysisresponsesetsCallanalysissetId(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteCallanalysisresponsesetsCallanalysissetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletecampaignscampaignid"></a>

## **string** DeleteCampaignsCampaignId (string campaignId)

Delete a campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCampaignsCampaignIdExample
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
                string result = apiInstance.DeleteCampaignsCampaignId(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteCampaignsCampaignId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletecampaignscampaignidprogress"></a>

## **string** DeleteCampaignsCampaignIdProgress (string campaignId)

Reset campaign progress and recycle the campaign



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCampaignsCampaignIdProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Reset campaign progress and recycle the campaign
                string result = apiInstance.DeleteCampaignsCampaignIdProgress(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteCampaignsCampaignIdProgress: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletecontactlistscontactlistid"></a>

## **string** DeleteContactlistsContactlistId (string contactListId)

Delete a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteContactlistsContactlistIdExample
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
                string result = apiInstance.DeleteContactlistsContactlistId(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteContactlistsContactlistId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletecontactlistscontactlistidcontactscontactid"></a>

## **string** DeleteContactlistsContactlistIdContactsContactId (string contactListId, string contactId)

Delete a contact.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteContactlistsContactlistIdContactsContactIdExample
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
                string result = apiInstance.DeleteContactlistsContactlistIdContactsContactId(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteContactlistsContactlistIdContactsContactId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletednclistsdnclistid"></a>

## **string** DeleteDnclistsDnclistId (string dncListId)

Delete dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteDnclistsDnclistIdExample
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
                string result = apiInstance.DeleteDnclistsDnclistId(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteDnclistsDnclistId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleterulesetsrulesetid"></a>

## **string** DeleteRulesetsRulesetId (string ruleSetId)

Delete a Rule set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteRulesetsRulesetIdExample
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
                string result = apiInstance.DeleteRulesetsRulesetId(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteRulesetsRulesetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteschedulescampaignscampaignid"></a>

## **string** DeleteSchedulesCampaignsCampaignId (string campaignId)

Delete a dialer campaign schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSchedulesCampaignsCampaignIdExample
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
                string result = apiInstance.DeleteSchedulesCampaignsCampaignId(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteSchedulesCampaignsCampaignId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteschedulessequencessequenceid"></a>

## **string** DeleteSchedulesSequencesSequenceId (string sequenceId)

Delete a dialer sequence schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSchedulesSequencesSequenceIdExample
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
                string result = apiInstance.DeleteSchedulesSequencesSequenceId(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteSchedulesSequencesSequenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletesequencessequenceid"></a>

## **string** DeleteSequencesSequenceId (string sequenceId)

Delete a dialer campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSequencesSequenceIdExample
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
                string result = apiInstance.DeleteSequencesSequenceId(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.DeleteSequencesSequenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getcallabletimesets"></a>

## [**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html) GetCallabletimesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query callable time set list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallabletimesetsExample
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
                CallableTimeSetEntityListing result = apiInstance.GetCallabletimesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCallabletimesets: " + e.Message );
            }
        }
    }
}
~~~

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

[**CallableTimeSetEntityListing**](CallableTimeSetEntityListing.html)

<a name="getcallabletimesetscallabletimesetid"></a>

## [**CallableTimeSet**](CallableTimeSet.html) GetCallabletimesetsCallabletimesetId (string callableTimeSetId)

Get callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallabletimesetsCallabletimesetIdExample
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
                CallableTimeSet result = apiInstance.GetCallabletimesetsCallabletimesetId(callableTimeSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCallabletimesetsCallabletimesetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="getcallanalysisresponsesets"></a>

## [**ResponseSetEntityListing**](ResponseSetEntityListing.html) GetCallanalysisresponsesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of dialer call analysis response sets.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallanalysisresponsesetsExample
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
                ResponseSetEntityListing result = apiInstance.GetCallanalysisresponsesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
~~~

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

[**ResponseSetEntityListing**](ResponseSetEntityListing.html)

<a name="getcallanalysisresponsesetscallanalysissetid"></a>

## [**ResponseSet**](ResponseSet.html) GetCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId)

Get a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallanalysisresponsesetsCallanalysissetIdExample
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
                ResponseSet result = apiInstance.GetCallanalysisresponsesetsCallanalysissetId(callAnalysisSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCallanalysisresponsesetsCallanalysissetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="getcampaigns"></a>

## [**CampaignEntityListing**](CampaignEntityListing.html) GetCampaigns (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, string sortBy = null, string sortOrder = null)

Query a list of dialer campaigns.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCampaignsExample
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
                CampaignEntityListing result = apiInstance.GetCampaigns(pageSize, pageNumber, filterType, name, contactListId, dncListId, distributionQueueId, edgeGroupId, callAnalysisResponseSetId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCampaigns: " + e.Message );
            }
        }
    }
}
~~~

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

[**CampaignEntityListing**](CampaignEntityListing.html)

<a name="getcampaignscampaignid"></a>

## [**Campaign**](Campaign.html) GetCampaignsCampaignId (string campaignId)

Get dialer campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCampaignsCampaignIdExample
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
                Campaign result = apiInstance.GetCampaignsCampaignId(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCampaignsCampaignId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="getcampaignscampaigniddiagnostics"></a>

## [**CampaignDiagnostics**](CampaignDiagnostics.html) GetCampaignsCampaignIdDiagnostics (string campaignId)

Get campaign diagnostics



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCampaignsCampaignIdDiagnosticsExample
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
                CampaignDiagnostics result = apiInstance.GetCampaignsCampaignIdDiagnostics(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCampaignsCampaignIdDiagnostics: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignDiagnostics**](CampaignDiagnostics.html)

<a name="getcampaignscampaignidinteractions"></a>

## [**CampaignInteractions**](CampaignInteractions.html) GetCampaignsCampaignIdInteractions (string campaignId)

Get dialer campaign interactions.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCampaignsCampaignIdInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get dialer campaign interactions.
                CampaignInteractions result = apiInstance.GetCampaignsCampaignIdInteractions(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCampaignsCampaignIdInteractions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignInteractions**](CampaignInteractions.html)

<a name="getcampaignscampaignidprogress"></a>

## [**CampaignProgress**](CampaignProgress.html) GetCampaignsCampaignIdProgress (string campaignId)

Get campaign progress



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCampaignsCampaignIdProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID

            try
            {
                // Get campaign progress
                CampaignProgress result = apiInstance.GetCampaignsCampaignIdProgress(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCampaignsCampaignIdProgress: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignProgress**](CampaignProgress.html)

<a name="getcampaignscampaignidstats"></a>

## [**CampaignStats**](CampaignStats.html) GetCampaignsCampaignIdStats (string campaignId)

Get statistics about a Dialer Campaign



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCampaignsCampaignIdStatsExample
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
                CampaignStats result = apiInstance.GetCampaignsCampaignIdStats(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetCampaignsCampaignIdStats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignStats**](CampaignStats.html)

<a name="getcontactlists"></a>

## [**ContactListEntityListing**](ContactListEntityListing.html) GetContactlists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of contact lists.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactlistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Include import status (optional)  (default to false)
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
                ContactListEntityListing result = apiInstance.GetContactlists(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetContactlists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Include import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional] [default to a] |
{: class="table table-striped"}

### Return type

[**ContactListEntityListing**](ContactListEntityListing.html)

<a name="getcontactlistscontactlistid"></a>

## [**ContactList**](ContactList.html) GetContactlistsContactlistId (string contactListId, bool? includeImportStatus = null, bool? includeSize = null)

Get a dialer contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactlistsContactlistIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            {
                // Get a dialer contact list.
                ContactList result = apiInstance.GetContactlistsContactlistId(contactListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetContactlistsContactlistId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="getcontactlistscontactlistidcontactscontactid"></a>

## [**DialerContact**](DialerContact.html) GetContactlistsContactlistIdContactsContactId (string contactListId, string contactId)

Get a contact.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactlistsContactlistIdContactsContactIdExample
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
                // Get a contact.
                DialerContact result = apiInstance.GetContactlistsContactlistIdContactsContactId(contactListId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetContactlistsContactlistIdContactsContactId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
{: class="table table-striped"}

### Return type

[**DialerContact**](DialerContact.html)

<a name="getcontactlistscontactlistidexport"></a>

## [**ExportUri**](ExportUri.html) GetContactlistsContactlistIdExport (string contactListId, string download = null)

Get the URI of a contact list export.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactlistsContactlistIdExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var download = download_example;  // string | Redirect to download uri (optional)  (default to false)

            try
            {
                // Get the URI of a contact list export.
                ExportUri result = apiInstance.GetContactlistsContactlistIdExport(contactListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetContactlistsContactlistIdExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ExportUri**](ExportUri.html)

<a name="getcontactlistscontactlistidimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetContactlistsContactlistIdImportstatus (string contactListId)

Get dialer contactList import status.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetContactlistsContactlistIdImportstatusExample
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
                ImportStatus result = apiInstance.GetContactlistsContactlistIdImportstatus(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetContactlistsContactlistIdImportstatus: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getdnclists"></a>

## [**DncListEntityListing**](DncListEntityListing.html) GetDnclists (bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query dialer DNC lists



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDnclistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
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
                DncListEntityListing result = apiInstance.GetDnclists(includeImportStatus, includeSize, pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetDnclists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **filterType** | **string**| Filter type | [optional] [default to PREFIX] |
| **name** | **string**| Name | [optional]  |
| **sortBy** | **string**| Sort by | [optional]  |
| **sortOrder** | **string**| Sort order | [optional]  |
{: class="table table-striped"}

### Return type

[**DncListEntityListing**](DncListEntityListing.html)

<a name="getdnclistsdnclistid"></a>

## [**DncList**](DncList.html) GetDnclistsDnclistId (string dncListId, bool? includeImportStatus = null, bool? includeSize = null)

Get dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDnclistsDnclistIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var includeImportStatus = true;  // bool? | Import status (optional)  (default to false)
            var includeSize = true;  // bool? | Include size (optional)  (default to false)

            try
            {
                // Get dialer DNC list
                DncList result = apiInstance.GetDnclistsDnclistId(dncListId, includeImportStatus, includeSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetDnclistsDnclistId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **includeImportStatus** | **bool?**| Import status | [optional] [default to false] |
| **includeSize** | **bool?**| Include size | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="getdnclistsdnclistidexport"></a>

## [**ExportUri**](ExportUri.html) GetDnclistsDnclistIdExport (string dncListId, string download = null)

Get the URI of a DNC list export.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDnclistsDnclistIdExportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var download = download_example;  // string | Redirect to download uri (optional)  (default to false)

            try
            {
                // Get the URI of a DNC list export.
                ExportUri result = apiInstance.GetDnclistsDnclistIdExport(dncListId, download);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetDnclistsDnclistIdExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **download** | **string**| Redirect to download uri | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**ExportUri**](ExportUri.html)

<a name="getdnclistsdnclistidimportstatus"></a>

## [**ImportStatus**](ImportStatus.html) GetDnclistsDnclistIdImportstatus (string dncListId)

Get dialer dncList import status.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDnclistsDnclistIdImportstatusExample
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
                ImportStatus result = apiInstance.GetDnclistsDnclistIdImportstatus(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetDnclistsDnclistIdImportstatus: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

[**ImportStatus**](ImportStatus.html)

<a name="getrulesets"></a>

## [**RuleSetEntityListing**](RuleSetEntityListing.html) GetRulesets (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of Rule Sets.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRulesetsExample
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
                RuleSetEntityListing result = apiInstance.GetRulesets(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetRulesets: " + e.Message );
            }
        }
    }
}
~~~

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

[**RuleSetEntityListing**](RuleSetEntityListing.html)

<a name="getrulesetsrulesetid"></a>

## [**RuleSet**](RuleSet.html) GetRulesetsRulesetId (string ruleSetId)

Get a Rule Set by ID.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRulesetsRulesetIdExample
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
                RuleSet result = apiInstance.GetRulesetsRulesetId(ruleSetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetRulesetsRulesetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="getschedulescampaigns"></a>

## [**List&lt;CampaignSchedule&gt;**](CampaignSchedule.html) GetSchedulesCampaigns ()

Query for a list of dialer campaign schedules.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchedulesCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Query for a list of dialer campaign schedules.
                List&lt;CampaignSchedule&gt; result = apiInstance.GetSchedulesCampaigns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetSchedulesCampaigns: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<CampaignSchedule>**](CampaignSchedule.html)

<a name="getschedulescampaignscampaignid"></a>

## [**CampaignSchedule**](CampaignSchedule.html) GetSchedulesCampaignsCampaignId (string campaignId)

Get a dialer campaign schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchedulesCampaignsCampaignIdExample
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
                CampaignSchedule result = apiInstance.GetSchedulesCampaignsCampaignId(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetSchedulesCampaignsCampaignId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.html)

<a name="getschedulessequences"></a>

## [**List&lt;SequenceSchedule&gt;**](SequenceSchedule.html) GetSchedulesSequences ()

Query for a list of dialer sequence schedules.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchedulesSequencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Query for a list of dialer sequence schedules.
                List&lt;SequenceSchedule&gt; result = apiInstance.GetSchedulesSequences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetSchedulesSequences: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**List<SequenceSchedule>**](SequenceSchedule.html)

<a name="getschedulessequencessequenceid"></a>

## [**SequenceSchedule**](SequenceSchedule.html) GetSchedulesSequencesSequenceId (string sequenceId)

Get a dialer sequence schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSchedulesSequencesSequenceIdExample
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
                SequenceSchedule result = apiInstance.GetSchedulesSequencesSequenceId(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetSchedulesSequencesSequenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.html)

<a name="getsequences"></a>

## [**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html) GetSequences (int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null)

Query a list of dialer campaign sequences.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSequencesExample
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
                CampaignSequenceEntityListing result = apiInstance.GetSequences(pageSize, pageNumber, filterType, name, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetSequences: " + e.Message );
            }
        }
    }
}
~~~

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

[**CampaignSequenceEntityListing**](CampaignSequenceEntityListing.html)

<a name="getsequencessequenceid"></a>

## [**CampaignSequence**](CampaignSequence.html) GetSequencesSequenceId (string sequenceId)

Get a dialer campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSequencesSequenceIdExample
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
                CampaignSequence result = apiInstance.GetSequencesSequenceId(sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetSequencesSequenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="getwrapupcodemappings"></a>

## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) GetWrapupcodemappings ()

Get the Dialer wrap up code mapping.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetWrapupcodemappingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();

            try
            {
                // Get the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.GetWrapupcodemappings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.GetWrapupcodemappings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.html)

<a name="postaudits"></a>

## [**AuditSearchResult**](AuditSearchResult.html) PostAudits (DialerAuditRequest body, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, bool? facetsOnly = null)

Retrieves audits for dialer.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostAuditsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new DialerAuditRequest(); // DialerAuditRequest | AuditSearch
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | Sort by (optional)  (default to entity.name)
            var sortOrder = sortOrder_example;  // string | Sort order (optional)  (default to ascending)
            var facetsOnly = true;  // bool? | Facets only (optional)  (default to false)

            try
            {
                // Retrieves audits for dialer.
                AuditSearchResult result = apiInstance.PostAudits(body, pageSize, pageNumber, sortBy, sortOrder, facetsOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostAudits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DialerAuditRequest**](DialerAuditRequest.html)| AuditSearch |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **sortBy** | **string**| Sort by | [optional] [default to entity.name] |
| **sortOrder** | **string**| Sort order | [optional] [default to ascending] |
| **facetsOnly** | **bool?**| Facets only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**AuditSearchResult**](AuditSearchResult.html)

<a name="postcallabletimesets"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PostCallabletimesets (CallableTimeSet body)

Create callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallabletimesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet

            try
            {
                // Create callable time set
                CallableTimeSet result = apiInstance.PostCallabletimesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostCallabletimesets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CallableTimeSet**](CallableTimeSet.html)| DialerCallableTimeSet |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="postcallanalysisresponsesets"></a>

## [**ResponseSet**](ResponseSet.html) PostCallanalysisresponsesets (ResponseSet body)

Create a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallanalysisresponsesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new ResponseSet(); // ResponseSet | ResponseSet

            try
            {
                // Create a dialer call analysis response set.
                ResponseSet result = apiInstance.PostCallanalysisresponsesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostCallanalysisresponsesets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ResponseSet**](ResponseSet.html)| ResponseSet |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="postcampaigns"></a>

## [**Campaign**](Campaign.html) PostCampaigns (Campaign body)

Create a campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCampaignsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new Campaign(); // Campaign | Campaign

            try
            {
                // Create a campaign.
                Campaign result = apiInstance.PostCampaigns(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostCampaigns: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Campaign**](Campaign.html)| Campaign |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="postcampaignscampaignidcallbackschedule"></a>

## [**ContactCallbackRequest**](ContactCallbackRequest.html) PostCampaignsCampaignIdCallbackSchedule (string campaignId, ContactCallbackRequest body)

Schedule a Callback for a Dialer Campaign



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCampaignsCampaignIdCallbackScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new ContactCallbackRequest(); // ContactCallbackRequest | ContactCallbackRequest

            try
            {
                // Schedule a Callback for a Dialer Campaign
                ContactCallbackRequest result = apiInstance.PostCampaignsCampaignIdCallbackSchedule(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostCampaignsCampaignIdCallbackSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**ContactCallbackRequest**](ContactCallbackRequest.html)| ContactCallbackRequest |  |
{: class="table table-striped"}

### Return type

[**ContactCallbackRequest**](ContactCallbackRequest.html)

<a name="postcampaignsprogress"></a>

## [**List&lt;CampaignProgress&gt;**](CampaignProgress.html) PostCampaignsProgress (List<string> body)

Get progress for a list of campaigns



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCampaignsProgressExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = ;  // List<string> | Campaign IDs

            try
            {
                // Get progress for a list of campaigns
                List&lt;CampaignProgress&gt; result = apiInstance.PostCampaignsProgress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostCampaignsProgress: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **List<string>**| Campaign IDs |  |
{: class="table table-striped"}

### Return type

[**List<CampaignProgress>**](CampaignProgress.html)

<a name="postcontactlists"></a>

## [**ContactList**](ContactList.html) PostContactlists (ContactList body)

Create a contact List.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostContactlistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new ContactList(); // ContactList | ContactList

            try
            {
                // Create a contact List.
                ContactList result = apiInstance.PostContactlists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostContactlists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ContactList**](ContactList.html)| ContactList |  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="postcontactlistscontactlistidcontacts"></a>

## [**List&lt;DialerContact&gt;**](DialerContact.html) PostContactlistsContactlistIdContacts (string contactListId, List<DialerContact> body, bool? priority = null)

Add contacts to a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostContactlistsContactlistIdContactsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var body = new List<DialerContact>(); // List<DialerContact> | Contact
            var priority = true;  // bool? | Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. (optional) 

            try
            {
                // Add contacts to a contact list.
                List&lt;DialerContact&gt; result = apiInstance.PostContactlistsContactlistIdContacts(contactListId, body, priority);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostContactlistsContactlistIdContacts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **body** | [**List<DialerContact>**](DialerContact.html)| Contact |  |
| **priority** | **bool?**| Contact priority.  True means the contact(s) will go to the beginning of the list, false means at the end. | [optional]  |
{: class="table table-striped"}

### Return type

[**List<DialerContact>**](DialerContact.html)

<a name="postcontactlistscontactlistidexport"></a>

## **string** PostContactlistsContactlistIdExport (string contactListId)

Initiate the export of a contact list.

Returns 200 if received OK.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostContactlistsContactlistIdExportExample
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
                string result = apiInstance.PostContactlistsContactlistIdExport(contactListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostContactlistsContactlistIdExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="postconversationsconversationiddnc"></a>

## void PostConversationsConversationIdDnc (string conversationId)

Add phone numbers to a Dialer DNC list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsConversationIdDncExample
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
                apiInstance.PostConversationsConversationIdDnc(conversationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostConversationsConversationIdDnc: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postdnclists"></a>

## [**DncList**](DncList.html) PostDnclists (DncList body)

Create dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDnclistsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new DncList(); // DncList | DncList

            try
            {
                // Create dialer DNC list
                DncList result = apiInstance.PostDnclists(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostDnclists: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DncList**](DncList.html)| DncList |  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="postdnclistsdnclistidexport"></a>

## **string** PostDnclistsDnclistIdExport (string dncListId)

Initiate the export of a dnc list.

Returns 200 if received OK.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDnclistsDnclistIdExportExample
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
                string result = apiInstance.PostDnclistsDnclistIdExport(dncListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostDnclistsDnclistIdExport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="postdnclistsdnclistidphonenumbers"></a>

## void PostDnclistsDnclistIdPhonenumbers (string dncListId, List<string> body)

Add phone numbers to a Dialer DNC list.

Only Internal DNC lists may be appended to

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostDnclistsDnclistIdPhonenumbersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = ;  // List<string> | DNC Phone Numbers

            try
            {
                // Add phone numbers to a Dialer DNC list.
                apiInstance.PostDnclistsDnclistIdPhonenumbers(dncListId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostDnclistsDnclistIdPhonenumbers: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | **List<string>**| DNC Phone Numbers |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postrulesets"></a>

## [**RuleSet**](RuleSet.html) PostRulesets (RuleSet body)

Create a Dialer Call Analysis Response Set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRulesetsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new RuleSet(); // RuleSet | RuleSet

            try
            {
                // Create a Dialer Call Analysis Response Set.
                RuleSet result = apiInstance.PostRulesets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostRulesets: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RuleSet**](RuleSet.html)| RuleSet |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="postsequences"></a>

## [**CampaignSequence**](CampaignSequence.html) PostSequences (CampaignSequence body)

Create a new campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSequencesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new CampaignSequence(); // CampaignSequence | Organization

            try
            {
                // Create a new campaign sequence.
                CampaignSequence result = apiInstance.PostSequences(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PostSequences: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CampaignSequence**](CampaignSequence.html)| Organization |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="putcallabletimesetscallabletimesetid"></a>

## [**CallableTimeSet**](CallableTimeSet.html) PutCallabletimesetsCallabletimesetId (string callableTimeSetId, CallableTimeSet body)

Update callable time set



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutCallabletimesetsCallabletimesetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callableTimeSetId = callableTimeSetId_example;  // string | Callable Time Set ID
            var body = new CallableTimeSet(); // CallableTimeSet | DialerCallableTimeSet

            try
            {
                // Update callable time set
                CallableTimeSet result = apiInstance.PutCallabletimesetsCallabletimesetId(callableTimeSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutCallabletimesetsCallabletimesetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callableTimeSetId** | **string**| Callable Time Set ID |  |
| **body** | [**CallableTimeSet**](CallableTimeSet.html)| DialerCallableTimeSet |  |
{: class="table table-striped"}

### Return type

[**CallableTimeSet**](CallableTimeSet.html)

<a name="putcallanalysisresponsesetscallanalysissetid"></a>

## [**ResponseSet**](ResponseSet.html) PutCallanalysisresponsesetsCallanalysissetId (string callAnalysisSetId, ResponseSet body)

Update a dialer call analysis response set.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutCallanalysisresponsesetsCallanalysissetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var callAnalysisSetId = callAnalysisSetId_example;  // string | Call Analysis Response Set ID
            var body = new ResponseSet(); // ResponseSet | ResponseSet

            try
            {
                // Update a dialer call analysis response set.
                ResponseSet result = apiInstance.PutCallanalysisresponsesetsCallanalysissetId(callAnalysisSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutCallanalysisresponsesetsCallanalysissetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callAnalysisSetId** | **string**| Call Analysis Response Set ID |  |
| **body** | [**ResponseSet**](ResponseSet.html)| ResponseSet |  |
{: class="table table-striped"}

### Return type

[**ResponseSet**](ResponseSet.html)

<a name="putcampaignscampaignid"></a>

## [**Campaign**](Campaign.html) PutCampaignsCampaignId (string campaignId, Campaign body)

Update a campaign.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutCampaignsCampaignIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new Campaign(); // Campaign | Campaign

            try
            {
                // Update a campaign.
                Campaign result = apiInstance.PutCampaignsCampaignId(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutCampaignsCampaignId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**Campaign**](Campaign.html)| Campaign |  |
{: class="table table-striped"}

### Return type

[**Campaign**](Campaign.html)

<a name="putcampaignscampaignidagentsuserid"></a>

## **string** PutCampaignsCampaignIdAgentsUserId (string campaignId, string userId, Agent body)

Send notification that an agent's state changed 

New agent state.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutCampaignsCampaignIdAgentsUserIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var userId = userId_example;  // string | Agent's user ID
            var body = new Agent(); // Agent | agent

            try
            {
                // Send notification that an agent's state changed 
                string result = apiInstance.PutCampaignsCampaignIdAgentsUserId(campaignId, userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutCampaignsCampaignIdAgentsUserId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **userId** | **string**| Agent&#39;s user ID |  |
| **body** | [**Agent**](Agent.html)| agent |  |
{: class="table table-striped"}

### Return type

**string**

<a name="putcontactlistscontactlistid"></a>

## [**ContactList**](ContactList.html) PutContactlistsContactlistId (string contactListId, ContactList body)

Update a contact list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutContactlistsContactlistIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | ContactList ID
            var body = new ContactList(); // ContactList | ContactList

            try
            {
                // Update a contact list.
                ContactList result = apiInstance.PutContactlistsContactlistId(contactListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutContactlistsContactlistId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| ContactList ID |  |
| **body** | [**ContactList**](ContactList.html)| ContactList |  |
{: class="table table-striped"}

### Return type

[**ContactList**](ContactList.html)

<a name="putcontactlistscontactlistidcontactscontactid"></a>

## [**DialerContact**](DialerContact.html) PutContactlistsContactlistIdContactsContactId (string contactListId, string contactId, DialerContact body)

Update a contact.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutContactlistsContactlistIdContactsContactIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var contactListId = contactListId_example;  // string | Contact List ID
            var contactId = contactId_example;  // string | Contact ID
            var body = new DialerContact(); // DialerContact | Contact

            try
            {
                // Update a contact.
                DialerContact result = apiInstance.PutContactlistsContactlistIdContactsContactId(contactListId, contactId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutContactlistsContactlistIdContactsContactId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **contactListId** | **string**| Contact List ID |  |
| **contactId** | **string**| Contact ID |  |
| **body** | [**DialerContact**](DialerContact.html)| Contact |  |
{: class="table table-striped"}

### Return type

[**DialerContact**](DialerContact.html)

<a name="putdnclistsdnclistid"></a>

## [**DncList**](DncList.html) PutDnclistsDnclistId (string dncListId, DncList body)

Update dialer DNC list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutDnclistsDnclistIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var dncListId = dncListId_example;  // string | DncList ID
            var body = new DncList(); // DncList | DncList

            try
            {
                // Update dialer DNC list
                DncList result = apiInstance.PutDnclistsDnclistId(dncListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutDnclistsDnclistId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **dncListId** | **string**| DncList ID |  |
| **body** | [**DncList**](DncList.html)| DncList |  |
{: class="table table-striped"}

### Return type

[**DncList**](DncList.html)

<a name="putrulesetsrulesetid"></a>

## [**RuleSet**](RuleSet.html) PutRulesetsRulesetId (string ruleSetId, RuleSet body)

Update a RuleSet.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRulesetsRulesetIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var ruleSetId = ruleSetId_example;  // string | Rule Set ID
            var body = new RuleSet(); // RuleSet | RuleSet

            try
            {
                // Update a RuleSet.
                RuleSet result = apiInstance.PutRulesetsRulesetId(ruleSetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutRulesetsRulesetId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleSetId** | **string**| Rule Set ID |  |
| **body** | [**RuleSet**](RuleSet.html)| RuleSet |  |
{: class="table table-striped"}

### Return type

[**RuleSet**](RuleSet.html)

<a name="putschedulescampaignscampaignid"></a>

## [**CampaignSchedule**](CampaignSchedule.html) PutSchedulesCampaignsCampaignId (string campaignId, CampaignSchedule body)

Update a new campaign schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutSchedulesCampaignsCampaignIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var campaignId = campaignId_example;  // string | Campaign ID
            var body = new CampaignSchedule(); // CampaignSchedule | CampaignSchedule

            try
            {
                // Update a new campaign schedule.
                CampaignSchedule result = apiInstance.PutSchedulesCampaignsCampaignId(campaignId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutSchedulesCampaignsCampaignId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **campaignId** | **string**| Campaign ID |  |
| **body** | [**CampaignSchedule**](CampaignSchedule.html)| CampaignSchedule |  |
{: class="table table-striped"}

### Return type

[**CampaignSchedule**](CampaignSchedule.html)

<a name="putschedulessequencessequenceid"></a>

## [**SequenceSchedule**](SequenceSchedule.html) PutSchedulesSequencesSequenceId (string sequenceId, SequenceSchedule body)

Update a new sequence schedule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutSchedulesSequencesSequenceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Sequence ID
            var body = new SequenceSchedule(); // SequenceSchedule | SequenceSchedule

            try
            {
                // Update a new sequence schedule.
                SequenceSchedule result = apiInstance.PutSchedulesSequencesSequenceId(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutSchedulesSequencesSequenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Sequence ID |  |
| **body** | [**SequenceSchedule**](SequenceSchedule.html)| SequenceSchedule |  |
{: class="table table-striped"}

### Return type

[**SequenceSchedule**](SequenceSchedule.html)

<a name="putsequencessequenceid"></a>

## [**CampaignSequence**](CampaignSequence.html) PutSequencesSequenceId (string sequenceId, CampaignSequence body)

Update a new campaign sequence.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutSequencesSequenceIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var sequenceId = sequenceId_example;  // string | Campaign Sequence ID
            var body = new CampaignSequence(); // CampaignSequence | Organization

            try
            {
                // Update a new campaign sequence.
                CampaignSequence result = apiInstance.PutSequencesSequenceId(sequenceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutSequencesSequenceId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **sequenceId** | **string**| Campaign Sequence ID |  |
| **body** | [**CampaignSequence**](CampaignSequence.html)| Organization |  |
{: class="table table-striped"}

### Return type

[**CampaignSequence**](CampaignSequence.html)

<a name="putwrapupcodemappings"></a>

## [**WrapUpCodeMapping**](WrapUpCodeMapping.html) PutWrapupcodemappings (WrapUpCodeMapping body)

Update the Dialer wrap up code mapping.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutWrapupcodemappingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OutboundApi();
            var body = new WrapUpCodeMapping(); // WrapUpCodeMapping | wrapUpCodeMapping

            try
            {
                // Update the Dialer wrap up code mapping.
                WrapUpCodeMapping result = apiInstance.PutWrapupcodemappings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundApi.PutWrapupcodemappings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**WrapUpCodeMapping**](WrapUpCodeMapping.html)| wrapUpCodeMapping |  |
{: class="table table-striped"}

### Return type

[**WrapUpCodeMapping**](WrapUpCodeMapping.html)

