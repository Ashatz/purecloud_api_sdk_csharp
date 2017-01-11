---
title: VoicemailApi
---
## ININ.PureCloudApi.Api.VoicemailApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMessages**](VoicemailApi.html#deletemessages) | **DELETE** /api/v2/voicemail/messages | Delete all voicemail messages |
| [**DeleteMessagesMessageId**](VoicemailApi.html#deletemessagesmessageid) | **DELETE** /api/v2/voicemail/messages/{messageId} | Delete a message. |
| [**GetGroupsGroupIdMailbox**](VoicemailApi.html#getgroupsgroupidmailbox) | **GET** /api/v2/voicemail/groups/{groupId}/mailbox | Get the group&#39;s mailbox information |
| [**GetGroupsGroupIdMessages**](VoicemailApi.html#getgroupsgroupidmessages) | **GET** /api/v2/voicemail/groups/{groupId}/messages | List voicemail messages |
| [**GetGroupsGroupIdPolicy**](VoicemailApi.html#getgroupsgroupidpolicy) | **GET** /api/v2/voicemail/groups/{groupId}/policy | Get a group&#39;s voicemail policy |
| [**GetMailbox**](VoicemailApi.html#getmailbox) | **GET** /api/v2/voicemail/mailbox | Get the current user&#39;s mailbox information |
| [**GetMeMailbox**](VoicemailApi.html#getmemailbox) | **GET** /api/v2/voicemail/me/mailbox | Get the current user&#39;s mailbox information |
| [**GetMeMessages**](VoicemailApi.html#getmemessages) | **GET** /api/v2/voicemail/me/messages | List voicemail messages |
| [**GetMePolicy**](VoicemailApi.html#getmepolicy) | **GET** /api/v2/voicemail/me/policy | Get the current user&#39;s voicemail policy |
| [**GetMessages**](VoicemailApi.html#getmessages) | **GET** /api/v2/voicemail/messages | List voicemail messages |
| [**GetMessagesMessageId**](VoicemailApi.html#getmessagesmessageid) | **GET** /api/v2/voicemail/messages/{messageId} | Get message. |
| [**GetMessagesMessageIdMedia**](VoicemailApi.html#getmessagesmessageidmedia) | **GET** /api/v2/voicemail/messages/{messageId}/media | Get media playback URI for this message |
| [**GetPolicy**](VoicemailApi.html#getpolicy) | **GET** /api/v2/voicemail/policy | Get a policy |
| [**GetSearch**](VoicemailApi.html#getsearch) | **GET** /api/v2/voicemail/search | Search voicemails using the q64 value returned from a previous search |
| [**GetUserpoliciesUserId**](VoicemailApi.html#getuserpoliciesuserid) | **GET** /api/v2/voicemail/userpolicies/{userId} | Get a user&#39;s voicemail policy |
| [**PatchGroupsGroupIdPolicy**](VoicemailApi.html#patchgroupsgroupidpolicy) | **PATCH** /api/v2/voicemail/groups/{groupId}/policy | Update a group&#39;s voicemail policy |
| [**PatchMePolicy**](VoicemailApi.html#patchmepolicy) | **PATCH** /api/v2/voicemail/me/policy | Update the current user&#39;s voicemail policy |
| [**PatchUserpoliciesUserId**](VoicemailApi.html#patchuserpoliciesuserid) | **PATCH** /api/v2/voicemail/userpolicies/{userId} | Update a user&#39;s voicemail policy |
| [**PostMessages**](VoicemailApi.html#postmessages) | **POST** /api/v2/voicemail/messages | Copy a voicemail message to a user or group |
| [**PostSearch**](VoicemailApi.html#postsearch) | **POST** /api/v2/voicemail/search | Search voicemails |
| [**PutMessagesMessageId**](VoicemailApi.html#putmessagesmessageid) | **PUT** /api/v2/voicemail/messages/{messageId} | Update a message. |
| [**PutPolicy**](VoicemailApi.html#putpolicy) | **PUT** /api/v2/voicemail/policy | Update a policy |
{: class="table table-striped"}

<a name="deletemessages"></a>

## **string** DeleteMessages ()

Delete all voicemail messages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Delete all voicemail messages
                string result = apiInstance.DeleteMessages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.DeleteMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**string**

<a name="deletemessagesmessageid"></a>

## **string** DeleteMessagesMessageId (string messageId)

Delete a message.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteMessagesMessageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID

            try
            {
                // Delete a message.
                string result = apiInstance.DeleteMessagesMessageId(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.DeleteMessagesMessageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getgroupsgroupidmailbox"></a>

## [**VoicemailMailboxInfo**](VoicemailMailboxInfo.html) GetGroupsGroupIdMailbox (string groupId)

Get the group's mailbox information



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupsGroupIdMailboxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | groupId

            try
            {
                // Get the group's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetGroupsGroupIdMailbox(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetGroupsGroupIdMailbox: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| groupId |  |
{: class="table table-striped"}

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo.html)

<a name="getgroupsgroupidmessages"></a>

## [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html) GetGroupsGroupIdMessages (string groupId, int? pageSize = null, int? pageNumber = null)

List voicemail messages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupsGroupIdMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetGroupsGroupIdMessages(groupId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetGroupsGroupIdMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html)

<a name="getgroupsgroupidpolicy"></a>

## [**VoicemailGroupPolicy**](VoicemailGroupPolicy.html) GetGroupsGroupIdPolicy (string groupId)

Get a group's voicemail policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupsGroupIdPolicyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | Group ID

            try
            {
                // Get a group's voicemail policy
                VoicemailGroupPolicy result = apiInstance.GetGroupsGroupIdPolicy(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetGroupsGroupIdPolicy: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**VoicemailGroupPolicy**](VoicemailGroupPolicy.html)

<a name="getmailbox"></a>

## [**VoicemailMailboxInfo**](VoicemailMailboxInfo.html) GetMailbox ()

Get the current user's mailbox information



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMailboxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Get the current user's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetMailbox();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMailbox: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo.html)

<a name="getmemailbox"></a>

## [**VoicemailMailboxInfo**](VoicemailMailboxInfo.html) GetMeMailbox ()

Get the current user's mailbox information



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMeMailboxExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Get the current user's mailbox information
                VoicemailMailboxInfo result = apiInstance.GetMeMailbox();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMeMailbox: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo.html)

<a name="getmemessages"></a>

## [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html) GetMeMessages (int? pageSize = null, int? pageNumber = null)

List voicemail messages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMeMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetMeMessages(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMeMessages: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html)

<a name="getmepolicy"></a>

## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) GetMePolicy ()

Get the current user's voicemail policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMePolicyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Get the current user's voicemail policy
                VoicemailUserPolicy result = apiInstance.GetMePolicy();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMePolicy: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.html)

<a name="getmessages"></a>

## [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html) GetMessages (string ids = null, List<string> expand = null)

List voicemail messages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var ids = ids_example;  // string | An optional comma separated list of VoicemailMessage ids (optional) 
            var expand = new List<string>(); // List<string> | If the caller is a known user, which fields, if any, to expand (optional) 

            try
            {
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetMessages(ids, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**| An optional comma separated list of VoicemailMessage ids | [optional]  |
| **expand** | [**List<string>**](string.html)| If the caller is a known user, which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html)

<a name="getmessagesmessageid"></a>

## [**VoicemailMessage**](VoicemailMessage.html) GetMessagesMessageId (string messageId, List<string> expand = null)

Get message.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMessagesMessageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var expand = new List<string>(); // List<string> | If the caller is a known user, which fields, if any, to expand (optional) 

            try
            {
                // Get message.
                VoicemailMessage result = apiInstance.GetMessagesMessageId(messageId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMessagesMessageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **expand** | [**List<string>**](string.html)| If the caller is a known user, which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.html)

<a name="getmessagesmessageidmedia"></a>

## [**VoicemailMediaInfo**](VoicemailMediaInfo.html) GetMessagesMessageIdMedia (string messageId, string formatId = null)

Get media playback URI for this message



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMessagesMessageIdMediaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)

            try
            {
                // Get media playback URI for this message
                VoicemailMediaInfo result = apiInstance.GetMessagesMessageIdMedia(messageId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMessagesMessageIdMedia: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**VoicemailMediaInfo**](VoicemailMediaInfo.html)

<a name="getpolicy"></a>

## [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html) GetPolicy ()

Get a policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPolicyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Get a policy
                VoicemailOrganizationPolicy result = apiInstance.GetPolicy();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetPolicy: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html)

<a name="getsearch"></a>

## [**VoicemailsSearchResponse**](VoicemailsSearchResponse.html) GetSearch (string q64, List<string> expand = null)

Search voicemails using the q64 value returned from a previous search



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var q64 = q64_example;  // string | q64
            var expand = new List<string>(); // List<string> | expand (optional) 

            try
            {
                // Search voicemails using the q64 value returned from a previous search
                VoicemailsSearchResponse result = apiInstance.GetSearch(q64, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **q64** | **string**| q64 |  |
| **expand** | [**List<string>**](string.html)| expand | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse.html)

<a name="getuserpoliciesuserid"></a>

## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) GetUserpoliciesUserId (string userId)

Get a user's voicemail policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserpoliciesUserIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Get a user's voicemail policy
                VoicemailUserPolicy result = apiInstance.GetUserpoliciesUserId(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetUserpoliciesUserId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.html)

<a name="patchgroupsgroupidpolicy"></a>

## [**VoicemailGroupPolicy**](VoicemailGroupPolicy.html) PatchGroupsGroupIdPolicy (string groupId, VoicemailGroupPolicy body)

Update a group's voicemail policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchGroupsGroupIdPolicyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new VoicemailGroupPolicy(); // VoicemailGroupPolicy | The group's voicemail policy

            try
            {
                // Update a group's voicemail policy
                VoicemailGroupPolicy result = apiInstance.PatchGroupsGroupIdPolicy(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchGroupsGroupIdPolicy: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**VoicemailGroupPolicy**](VoicemailGroupPolicy.html)| The group&#39;s voicemail policy |  |
{: class="table table-striped"}

### Return type

[**VoicemailGroupPolicy**](VoicemailGroupPolicy.html)

<a name="patchmepolicy"></a>

## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) PatchMePolicy (VoicemailUserPolicy body)

Update the current user's voicemail policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchMePolicyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var body = new VoicemailUserPolicy(); // VoicemailUserPolicy | The user's voicemail policy

            try
            {
                // Update the current user's voicemail policy
                VoicemailUserPolicy result = apiInstance.PatchMePolicy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchMePolicy: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy.html)| The user&#39;s voicemail policy |  |
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.html)

<a name="patchuserpoliciesuserid"></a>

## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) PatchUserpoliciesUserId (string userId, VoicemailUserPolicy body)

Update a user's voicemail policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchUserpoliciesUserIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var userId = userId_example;  // string | User ID
            var body = new VoicemailUserPolicy(); // VoicemailUserPolicy | The user's voicemail policy

            try
            {
                // Update a user's voicemail policy
                VoicemailUserPolicy result = apiInstance.PatchUserpoliciesUserId(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchUserpoliciesUserId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy.html)| The user&#39;s voicemail policy |  |
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.html)

<a name="postmessages"></a>

## [**VoicemailMessage**](VoicemailMessage.html) PostMessages (CopyVoicemailMessage body = null)

Copy a voicemail message to a user or group



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var body = new CopyVoicemailMessage(); // CopyVoicemailMessage |  (optional) 

            try
            {
                // Copy a voicemail message to a user or group
                VoicemailMessage result = apiInstance.PostMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PostMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CopyVoicemailMessage**](CopyVoicemailMessage.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.html)

<a name="postsearch"></a>

## [**VoicemailsSearchResponse**](VoicemailsSearchResponse.html) PostSearch (VoicemailSearchRequest body)

Search voicemails



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostSearchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var body = new VoicemailSearchRequest(); // VoicemailSearchRequest | Search request options

            try
            {
                // Search voicemails
                VoicemailsSearchResponse result = apiInstance.PostSearch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PostSearch: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailSearchRequest**](VoicemailSearchRequest.html)| Search request options |  |
{: class="table table-striped"}

### Return type

[**VoicemailsSearchResponse**](VoicemailsSearchResponse.html)

<a name="putmessagesmessageid"></a>

## [**VoicemailMessage**](VoicemailMessage.html) PutMessagesMessageId (string messageId, VoicemailMessage body)

Update a message.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutMessagesMessageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var body = new VoicemailMessage(); // VoicemailMessage | VoicemailMessage

            try
            {
                // Update a message.
                VoicemailMessage result = apiInstance.PutMessagesMessageId(messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PutMessagesMessageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **body** | [**VoicemailMessage**](VoicemailMessage.html)| VoicemailMessage |  |
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.html)

<a name="putpolicy"></a>

## [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html) PutPolicy (VoicemailOrganizationPolicy body)

Update a policy



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutPolicyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var body = new VoicemailOrganizationPolicy(); // VoicemailOrganizationPolicy | Policy

            try
            {
                // Update a policy
                VoicemailOrganizationPolicy result = apiInstance.PutPolicy(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PutPolicy: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html)

