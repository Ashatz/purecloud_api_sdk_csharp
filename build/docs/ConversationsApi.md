---
title: ConversationsApi
---
## ININ.PureCloudApi.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCallsCallIdParticipantsParticipantIdConsult**](ConversationsApi.html#deletecallscallidparticipantsparticipantidconsult) | **DELETE** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId**](ConversationsApi.html#deleteemailsemailidmessagesdraftattachmentsattachmentid) | **DELETE** /api/v2/conversations/emails/{emailId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**GetCallbacks**](ConversationsApi.html#getcallbacks) | **GET** /api/v2/conversations/callbacks | Get callback conversations |
| [**GetCallbacksCallbackId**](ConversationsApi.html#getcallbackscallbackid) | **GET** /api/v2/conversations/callbacks/{callbackId} | Get callback conversation |
| [**GetCallbacksCallbackIdParticipantsParticipantIdWrapup**](ConversationsApi.html#getcallbackscallbackidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.html#getcallbackscallbackidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetCalls**](ConversationsApi.html#getcalls) | **GET** /api/v2/conversations/calls | Get recent conversations |
| [**GetCallsCallId**](ConversationsApi.html#getcallscallid) | **GET** /api/v2/conversations/calls/{callId} | Get call conversation |
| [**GetCallsCallIdParticipantsParticipantIdWrapup**](ConversationsApi.html#getcallscallidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/calls/{callId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetCallsCallIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.html#getcallscallidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/calls/{callId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetCallsMaximumconferenceparties**](ConversationsApi.html#getcallsmaximumconferenceparties) | **GET** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetChats**](ConversationsApi.html#getchats) | **GET** /api/v2/conversations/chats | Get recent chat conversations |
| [**GetChatsChatId**](ConversationsApi.html#getchatschatid) | **GET** /api/v2/conversations/chats/{chatId} | Get chat conversation |
| [**GetChatsChatIdParticipantsParticipantIdWrapup**](ConversationsApi.html#getchatschatidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetChatsChatIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.html#getchatschatidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationId**](ConversationsApi.html#getconversationid) | **GET** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationIdParticipantsParticipantIdWrapup**](ConversationsApi.html#getconversationidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.html#getconversationidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversations**](ConversationsApi.html#getconversations) | **GET** /api/v2/conversations | Get conversations |
| [**GetConversationsConversationIdDetails**](ConversationsApi.html#getconversationsconversationiddetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetEmails**](ConversationsApi.html#getemails) | **GET** /api/v2/conversations/emails | Get recent email conversations |
| [**GetEmailsEmailId**](ConversationsApi.html#getemailsemailid) | **GET** /api/v2/conversations/emails/{emailId} | Get email conversation |
| [**GetEmailsEmailIdMessages**](ConversationsApi.html#getemailsemailidmessages) | **GET** /api/v2/conversations/emails/{emailId}/messages | Get conversation messages |
| [**GetEmailsEmailIdMessagesDraft**](ConversationsApi.html#getemailsemailidmessagesdraft) | **GET** /api/v2/conversations/emails/{emailId}/messages/draft | Get conversation draft reply |
| [**GetEmailsEmailIdMessagesMessageId**](ConversationsApi.html#getemailsemailidmessagesmessageid) | **GET** /api/v2/conversations/emails/{emailId}/messages/{messageId} | Get conversation message |
| [**GetEmailsEmailIdParticipantsParticipantIdWrapup**](ConversationsApi.html#getemailsemailidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetEmailsEmailIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.html#getemailsemailidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**PatchCallbacksCallbackIdParticipantsParticipantId**](ConversationsApi.html#patchcallbackscallbackidparticipantsparticipantid) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId} | Update conversation participant |
| [**PatchCallbacksCallbackIdParticipantsParticipantIdAttributes**](ConversationsApi.html#patchcallbackscallbackidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchCallsCallId**](ConversationsApi.html#patchcallscallid) | **PATCH** /api/v2/conversations/calls/{callId} | Update conversation |
| [**PatchCallsCallIdParticipantsParticipantId**](ConversationsApi.html#patchcallscallidparticipantsparticipantid) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId} | Update conversation participant |
| [**PatchCallsCallIdParticipantsParticipantIdAttributes**](ConversationsApi.html#patchcallscallidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchCallsCallIdParticipantsParticipantIdConsult**](ConversationsApi.html#patchcallscallidparticipantsparticipantidconsult) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Change who can speak |
| [**PatchChatsChatIdParticipantsParticipantId**](ConversationsApi.html#patchchatschatidparticipantsparticipantid) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId} | Update conversation participant |
| [**PatchChatsChatIdParticipantsParticipantIdAttributes**](ConversationsApi.html#patchchatschatidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationIdParticipantsParticipantId**](ConversationsApi.html#patchconversationidparticipantsparticipantid) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationIdParticipantsParticipantIdAttributes**](ConversationsApi.html#patchconversationidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchEmailsEmailIdParticipantsParticipantId**](ConversationsApi.html#patchemailsemailidparticipantsparticipantid) | **PATCH** /api/v2/conversations/emails/{emailId}/participants/{participantId} | Update conversation participant |
| [**PatchEmailsEmailIdParticipantsParticipantIdAttributes**](ConversationsApi.html#patchemailsemailidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/emails/{emailId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PostCallbacksCallbackIdParticipantsParticipantIdReplace**](ConversationsApi.html#postcallbackscallbackidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostCalls**](ConversationsApi.html#postcalls) | **POST** /api/v2/conversations/calls | Create a call conversation |
| [**PostCallsCallId**](ConversationsApi.html#postcallscallid) | **POST** /api/v2/conversations/calls/{callId} | Add a new call to a conversation |
| [**PostCallsCallIdParticipants**](ConversationsApi.html#postcallscallidparticipants) | **POST** /api/v2/conversations/calls/{callId}/participants | Add participants to a conversation |
| [**PostCallsCallIdParticipantsParticipantIdConsult**](ConversationsApi.html#postcallscallidparticipantsparticipantidconsult) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostCallsCallIdParticipantsParticipantIdMonitor**](ConversationsApi.html#postcallscallidparticipantsparticipantidmonitor) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostCallsCallIdParticipantsParticipantIdReplace**](ConversationsApi.html#postcallscallidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostChatsChatIdParticipantsParticipantIdReplace**](ConversationsApi.html#postchatschatidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/chats/{chatId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationIdParticipantsParticipantIdCallbacks**](ConversationsApi.html#postconversationidparticipantsparticipantidcallbacks) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationIdParticipantsParticipantIdReplace**](ConversationsApi.html#postconversationidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsAggregatesQuery**](ConversationsApi.html#postconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostConversationsConversationIdDetailsProperties**](ConversationsApi.html#postconversationsconversationiddetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostConversationsDetailsQuery**](ConversationsApi.html#postconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostEmailsEmailIdMessages**](ConversationsApi.html#postemailsemailidmessages) | **POST** /api/v2/conversations/emails/{emailId}/messages | Send an email reply |
| [**PostEmailsEmailIdParticipantsParticipantIdReplace**](ConversationsApi.html#postemailsemailidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/emails/{emailId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostFaxes**](ConversationsApi.html#postfaxes) | **POST** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PutEmailsEmailIdMessagesDraft**](ConversationsApi.html#putemailsemailidmessagesdraft) | **PUT** /api/v2/conversations/emails/{emailId}/messages/draft | Update conversation draft reply |
{: class="table table-striped"}

<a name="deletecallscallidparticipantsparticipantidconsult"></a>

## string** DeleteCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId)

Cancel the transfer



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCallsCallIdParticipantsParticipantIdConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 

            try
            {
                // Cancel the transfer
                string result = apiInstance.DeleteCallsCallIdParticipantsParticipantIdConsult(callId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteCallsCallIdParticipantsParticipantIdConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteemailsemailidmessagesdraftattachmentsattachmentid"></a>

## string** DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId (string emailId, string attachmentId)

Delete attachment from draft



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var attachmentId = attachmentId_example;  // string | 

            try
            {
                // Delete attachment from draft
                string result = apiInstance.DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId(emailId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **attachmentId** | **string**|  |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getcallbacks"></a>

## [**CallbackConversationEntityListing**](CallbackConversationEntityListing.html) GetCallbacks ()

Get callback conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallbacksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get callback conversations
                CallbackConversationEntityListing result = apiInstance.GetCallbacks();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallbacks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CallbackConversationEntityListing**](CallbackConversationEntityListing.html)

<a name="getcallbackscallbackid"></a>

## [**CallbackConversation**](CallbackConversation.html) GetCallbacksCallbackId (string callbackId)

Get callback conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallbacksCallbackIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | 

            try
            {
                // Get callback conversation
                CallbackConversation result = apiInstance.GetCallbacksCallbackId(callbackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallbacksCallbackId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**CallbackConversation**](CallbackConversation.html)

<a name="getcallbackscallbackidparticipantsparticipantidwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetCallbacksCallbackIdParticipantsParticipantIdWrapup (string callbackId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallbacksCallbackIdParticipantsParticipantIdWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                WrapupCode result = apiInstance.GetCallbacksCallbackIdParticipantsParticipantIdWrapup(callbackId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallbacksCallbackIdParticipantsParticipantIdWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getcallbackscallbackidparticipantsparticipantidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes (string callbackId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | 
            var participantId = participantId_example;  // string | 

            try
            {
                // Get list of wrapup codes for this conversation participant
                WrapupCode result = apiInstance.GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes(callbackId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**|  |  |
| **participantId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getcalls"></a>

## [**CallConversationEntityListing**](CallConversationEntityListing.html) GetCalls ()

Get recent conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent conversations
                CallConversationEntityListing result = apiInstance.GetCalls();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCalls: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CallConversationEntityListing**](CallConversationEntityListing.html)

<a name="getcallscallid"></a>

## [**CallConversation**](CallConversation.html) GetCallsCallId (string callId)

Get call conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallsCallIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 

            try
            {
                // Get call conversation
                CallConversation result = apiInstance.GetCallsCallId(callId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallsCallId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**CallConversation**](CallConversation.html)

<a name="getcallscallidparticipantsparticipantidwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetCallsCallIdParticipantsParticipantIdWrapup (string callId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallsCallIdParticipantsParticipantIdWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                WrapupCode result = apiInstance.GetCallsCallIdParticipantsParticipantIdWrapup(callId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallsCallIdParticipantsParticipantIdWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getcallscallidparticipantsparticipantidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) GetCallsCallIdParticipantsParticipantIdWrapupcodes (string callId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallsCallIdParticipantsParticipantIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 

            try
            {
                // Get list of wrapup codes for this conversation participant
                WrapupCode result = apiInstance.GetCallsCallIdParticipantsParticipantIdWrapupcodes(callId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallsCallIdParticipantsParticipantIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getcallsmaximumconferenceparties"></a>

## [**MaxParticipants**](MaxParticipants.html) GetCallsMaximumconferenceparties ()

Get the maximum number of participants that this user can have on a conference



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallsMaximumconferencepartiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get the maximum number of participants that this user can have on a conference
                MaxParticipants result = apiInstance.GetCallsMaximumconferenceparties();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallsMaximumconferenceparties: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**MaxParticipants**](MaxParticipants.html)

<a name="getchats"></a>

## [**ChatConversationEntityListing**](ChatConversationEntityListing.html) GetChats ()

Get recent chat conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetChatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent chat conversations
                ChatConversationEntityListing result = apiInstance.GetChats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ChatConversationEntityListing**](ChatConversationEntityListing.html)

<a name="getchatschatid"></a>

## [**ChatConversation**](ChatConversation.html) GetChatsChatId (string chatId)

Get chat conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetChatsChatIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | 

            try
            {
                // Get chat conversation
                ChatConversation result = apiInstance.GetChatsChatId(chatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChatsChatId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="getchatschatidparticipantsparticipantidwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetChatsChatIdParticipantsParticipantIdWrapup (string chatId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetChatsChatIdParticipantsParticipantIdWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                WrapupCode result = apiInstance.GetChatsChatIdParticipantsParticipantIdWrapup(chatId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChatsChatIdParticipantsParticipantIdWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getchatschatidparticipantsparticipantidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) GetChatsChatIdParticipantsParticipantIdWrapupcodes (string chatId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetChatsChatIdParticipantsParticipantIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | 
            var participantId = participantId_example;  // string | 

            try
            {
                // Get list of wrapup codes for this conversation participant
                WrapupCode result = apiInstance.GetChatsChatIdParticipantsParticipantIdWrapupcodes(chatId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChatsChatIdParticipantsParticipantIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**|  |  |
| **participantId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getconversationid"></a>

## [**Conversation**](Conversation.html) GetConversationId (string conversationId)

Get conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            {
                // Get conversation
                Conversation result = apiInstance.GetConversationId(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="getconversationidparticipantsparticipantidwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetConversationIdParticipantsParticipantIdWrapup (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdParticipantsParticipantIdWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                WrapupCode result = apiInstance.GetConversationIdParticipantsParticipantIdWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationIdParticipantsParticipantIdWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getconversationidparticipantsparticipantidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) GetConversationIdParticipantsParticipantIdWrapupcodes (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdParticipantsParticipantIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID

            try
            {
                // Get list of wrapup codes for this conversation participant
                WrapupCode result = apiInstance.GetConversationIdParticipantsParticipantIdWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationIdParticipantsParticipantIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getconversations"></a>

## [**ConversationEntityListing**](ConversationEntityListing.html) GetConversations (string communicationType = null)

Get conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var communicationType = communicationType_example;  // string | Call or Chat communication filtering (optional) 

            try
            {
                // Get conversations
                ConversationEntityListing result = apiInstance.GetConversations(communicationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **communicationType** | **string**| Call or Chat communication filtering | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationEntityListing**](ConversationEntityListing.html)

<a name="getconversationsconversationiddetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetConversationsConversationIdDetails (string conversationId)

Get a conversation by id



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationsConversationIdDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get a conversation by id
                AnalyticsConversation result = apiInstance.GetConversationsConversationIdDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationsConversationIdDetails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversation**](AnalyticsConversation.html)

<a name="getemails"></a>

## [**EmailConversationEntityListing**](EmailConversationEntityListing.html) GetEmails ()

Get recent email conversations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get recent email conversations
                EmailConversationEntityListing result = apiInstance.GetEmails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EmailConversationEntityListing**](EmailConversationEntityListing.html)

<a name="getemailsemailid"></a>

## [**EmailConversation**](EmailConversation.html) GetEmailsEmailId (string emailId)

Get email conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsEmailIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 

            try
            {
                // Get email conversation
                EmailConversation result = apiInstance.GetEmailsEmailId(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailsEmailId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="getemailsemailidmessages"></a>

## [**EmailMessageListing**](EmailMessageListing.html) GetEmailsEmailIdMessages (string emailId)

Get conversation messages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsEmailIdMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 

            try
            {
                // Get conversation messages
                EmailMessageListing result = apiInstance.GetEmailsEmailIdMessages(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailsEmailIdMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**EmailMessageListing**](EmailMessageListing.html)

<a name="getemailsemailidmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) GetEmailsEmailIdMessagesDraft (string emailId)

Get conversation draft reply



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsEmailIdMessagesDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 

            try
            {
                // Get conversation draft reply
                EmailMessage result = apiInstance.GetEmailsEmailIdMessagesDraft(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailsEmailIdMessagesDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getemailsemailidmessagesmessageid"></a>

## [**EmailMessage**](EmailMessage.html) GetEmailsEmailIdMessagesMessageId (string emailId, string messageId)

Get conversation message



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsEmailIdMessagesMessageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var messageId = messageId_example;  // string | 

            try
            {
                // Get conversation message
                EmailMessage result = apiInstance.GetEmailsEmailIdMessagesMessageId(emailId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailsEmailIdMessagesMessageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **messageId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getemailsemailidparticipantsparticipantidwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetEmailsEmailIdParticipantsParticipantIdWrapup (string emailId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsEmailIdParticipantsParticipantIdWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                WrapupCode result = apiInstance.GetEmailsEmailIdParticipantsParticipantIdWrapup(emailId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailsEmailIdParticipantsParticipantIdWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="getemailsemailidparticipantsparticipantidwrapupcodes"></a>

## [**WrapupCode**](WrapupCode.html) GetEmailsEmailIdParticipantsParticipantIdWrapupcodes (string emailId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEmailsEmailIdParticipantsParticipantIdWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var participantId = participantId_example;  // string | 

            try
            {
                // Get list of wrapup codes for this conversation participant
                WrapupCode result = apiInstance.GetEmailsEmailIdParticipantsParticipantIdWrapupcodes(emailId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailsEmailIdParticipantsParticipantIdWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **participantId** | **string**|  |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.html)

<a name="patchcallbackscallbackidparticipantsparticipantid"></a>

## void PatchCallbacksCallbackIdParticipantsParticipantId (string callbackId, string participantId, MediaParticipantRequest body = null)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallbacksCallbackIdParticipantsParticipantIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            {
                // Update conversation participant
                apiInstance.PatchCallbacksCallbackIdParticipantsParticipantId(callbackId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallbacksCallbackIdParticipantsParticipantId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallbackscallbackidparticipantsparticipantidattributes"></a>

## void PatchCallbacksCallbackIdParticipantsParticipantIdAttributes (string callbackId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallbacksCallbackIdParticipantsParticipantIdAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchCallbacksCallbackIdParticipantsParticipantIdAttributes(callbackId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallbacksCallbackIdParticipantsParticipantIdAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallscallid"></a>

## [**Conversation**](Conversation.html) PatchCallsCallId (string callId, Conversation body = null)

Update conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallsCallIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var body = new Conversation(); // Conversation | Conversation (optional) 

            try
            {
                // Update conversation
                Conversation result = apiInstance.PatchCallsCallId(callId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallsCallId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **body** | [**Conversation**](Conversation.html)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchcallscallidparticipantsparticipantid"></a>

## void PatchCallsCallIdParticipantsParticipantId (string callId, string participantId, MediaParticipantRequest body = null)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallsCallIdParticipantsParticipantIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            {
                // Update conversation participant
                apiInstance.PatchCallsCallIdParticipantsParticipantId(callId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallsCallIdParticipantsParticipantId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallscallidparticipantsparticipantidattributes"></a>

## void PatchCallsCallIdParticipantsParticipantIdAttributes (string callId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallsCallIdParticipantsParticipantIdAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchCallsCallIdParticipantsParticipantIdAttributes(callId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallsCallIdParticipantsParticipantIdAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallscallidparticipantsparticipantidconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PatchCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransferUpdate body = null)

Change who can speak



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallsCallIdParticipantsParticipantIdConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new ConsultTransferUpdate(); // ConsultTransferUpdate | new speak to (optional) 

            try
            {
                // Change who can speak
                ConsultTransferResponse result = apiInstance.PatchCallsCallIdParticipantsParticipantIdConsult(callId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallsCallIdParticipantsParticipantIdConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.html)| new speak to | [optional]  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="patchchatschatidparticipantsparticipantid"></a>

## void PatchChatsChatIdParticipantsParticipantId (string chatId, string participantId, MediaParticipantRequest body = null)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchChatsChatIdParticipantsParticipantIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            {
                // Update conversation participant
                apiInstance.PatchChatsChatIdParticipantsParticipantId(chatId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchChatsChatIdParticipantsParticipantId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchchatschatidparticipantsparticipantidattributes"></a>

## void PatchChatsChatIdParticipantsParticipantIdAttributes (string chatId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchChatsChatIdParticipantsParticipantIdAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchChatsChatIdParticipantsParticipantIdAttributes(chatId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchChatsChatIdParticipantsParticipantIdAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationidparticipantsparticipantid"></a>

## void PatchConversationIdParticipantsParticipantId (string conversationId, string participantId, MediaParticipantRequest body = null)

Update a participant.

Update conversation participant.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchConversationIdParticipantsParticipantIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            {
                // Update a participant.
                apiInstance.PatchConversationIdParticipantsParticipantId(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationIdParticipantsParticipantId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationidparticipantsparticipantidattributes"></a>

## void PatchConversationIdParticipantsParticipantIdAttributes (string conversationId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchConversationIdParticipantsParticipantIdAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationIdParticipantsParticipantIdAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationIdParticipantsParticipantIdAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchemailsemailidparticipantsparticipantid"></a>

## void PatchEmailsEmailIdParticipantsParticipantId (string emailId, string participantId, MediaParticipantRequest body = null)

Update conversation participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchEmailsEmailIdParticipantsParticipantIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new MediaParticipantRequest(); // MediaParticipantRequest |  (optional) 

            try
            {
                // Update conversation participant
                apiInstance.PatchEmailsEmailIdParticipantsParticipantId(emailId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchEmailsEmailIdParticipantsParticipantId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchemailsemailidparticipantsparticipantidattributes"></a>

## void PatchEmailsEmailIdParticipantsParticipantIdAttributes (string emailId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchEmailsEmailIdParticipantsParticipantIdAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new ParticipantAttributes(); // ParticipantAttributes |  (optional) 

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchEmailsEmailIdParticipantsParticipantIdAttributes(emailId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchEmailsEmailIdParticipantsParticipantIdAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcallbackscallbackidparticipantsparticipantidreplace"></a>

## void PostCallbacksCallbackIdParticipantsParticipantIdReplace (string callbackId, string participantId, TransferRequest body = null)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallbacksCallbackIdParticipantsParticipantIdReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostCallbacksCallbackIdParticipantsParticipantIdReplace(callbackId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallbacksCallbackIdParticipantsParticipantIdReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcalls"></a>

## [**CreateCallResponse**](CreateCallResponse.html) PostCalls (CreateCallRequest body = null)

Create a call conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new CreateCallRequest(); // CreateCallRequest |  (optional) 

            try
            {
                // Create a call conversation
                CreateCallResponse result = apiInstance.PostCalls(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCalls: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallRequest**](CreateCallRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CreateCallResponse**](CreateCallResponse.html)

<a name="postcallscallid"></a>

## [**Conversation**](Conversation.html) PostCallsCallId (string callId, CallCommand body = null)

Add a new call to a conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallsCallIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var body = new CallCommand(); // CallCommand | Conversation (optional) 

            try
            {
                // Add a new call to a conversation
                Conversation result = apiInstance.PostCallsCallId(callId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallsCallId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **body** | [**CallCommand**](CallCommand.html)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postcallscallidparticipants"></a>

## [**Conversation**](Conversation.html) PostCallsCallIdParticipants (string callId, Conversation body = null)

Add participants to a conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallsCallIdParticipantsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var body = new Conversation(); // Conversation | Conversation (optional) 

            try
            {
                // Add participants to a conversation
                Conversation result = apiInstance.PostCallsCallIdParticipants(callId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallsCallIdParticipants: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **body** | [**Conversation**](Conversation.html)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postcallscallidparticipantsparticipantidconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostCallsCallIdParticipantsParticipantIdConsult (string callId, string participantId, ConsultTransfer body = null)

Initiate and update consult transfer



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallsCallIdParticipantsParticipantIdConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new ConsultTransfer(); // ConsultTransfer | Destination address & initial speak to (optional) 

            try
            {
                // Initiate and update consult transfer
                ConsultTransferResponse result = apiInstance.PostCallsCallIdParticipantsParticipantIdConsult(callId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallsCallIdParticipantsParticipantIdConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**ConsultTransfer**](ConsultTransfer.html)| Destination address &amp; initial speak to | [optional]  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postcallscallidparticipantsparticipantidmonitor"></a>

## void PostCallsCallIdParticipantsParticipantIdMonitor (string callId, string participantId)

Listen in on the conversation from the point of view of a given participant.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallsCallIdParticipantsParticipantIdMonitorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 

            try
            {
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.PostCallsCallIdParticipantsParticipantIdMonitor(callId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallsCallIdParticipantsParticipantIdMonitor: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcallscallidparticipantsparticipantidreplace"></a>

## void PostCallsCallIdParticipantsParticipantIdReplace (string callId, string participantId, TransferRequest body = null)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallsCallIdParticipantsParticipantIdReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostCallsCallIdParticipantsParticipantIdReplace(callId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallsCallIdParticipantsParticipantIdReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postchatschatidparticipantsparticipantidreplace"></a>

## void PostChatsChatIdParticipantsParticipantIdReplace (string chatId, string participantId, TransferRequest body = null)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostChatsChatIdParticipantsParticipantIdReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostChatsChatIdParticipantsParticipantIdReplace(chatId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostChatsChatIdParticipantsParticipantIdReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationidparticipantsparticipantidcallbacks"></a>

## void PostConversationIdParticipantsParticipantIdCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null)

Create a new callback for the specified participant on the conversation.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationIdParticipantsParticipantIdCallbacksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new CreateCallbackCommand(); // CreateCallbackCommand |  (optional) 

            try
            {
                // Create a new callback for the specified participant on the conversation.
                apiInstance.PostConversationIdParticipantsParticipantIdCallbacks(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationIdParticipantsParticipantIdCallbacks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationidparticipantsparticipantidreplace"></a>

## void PostConversationIdParticipantsParticipantIdReplace (string conversationId, string participantId, TransferRequest body = null)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationIdParticipantsParticipantIdReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationIdParticipantsParticipantIdReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationIdParticipantsParticipantIdReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostConversationsAggregatesQuery (AggregationQuery body = null)

Query for conversation aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new AggregationQuery(); // AggregationQuery | query (optional) 

            try
            {
                // Query for conversation aggregates
                AggregateQueryResponse result = apiInstance.PostConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postconversationsconversationiddetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body = null)

Index conversation properties



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsConversationIdDetailsPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request (optional) 

            try
            {
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostConversationsConversationIdDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsConversationIdDetailsProperties: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request | [optional]  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostConversationsDetailsQuery (ConversationQuery body = null)

Query for conversation details



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsDetailsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new ConversationQuery(); // ConversationQuery | query (optional) 

            try
            {
                // Query for conversation details
                AnalyticsConversationQueryResponse result = apiInstance.PostConversationsDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationsDetailsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery.html)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postemailsemailidmessages"></a>

## [**EmailMessage**](EmailMessage.html) PostEmailsEmailIdMessages (string emailId, EmailMessage body = null)

Send an email reply



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEmailsEmailIdMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var body = new EmailMessage(); // EmailMessage | Reply (optional) 

            try
            {
                // Send an email reply
                EmailMessage result = apiInstance.PostEmailsEmailIdMessages(emailId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostEmailsEmailIdMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Reply | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="postemailsemailidparticipantsparticipantidreplace"></a>

## void PostEmailsEmailIdParticipantsParticipantIdReplace (string emailId, string participantId, TransferRequest body = null)

Replace this participant with the specified user and/or address



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEmailsEmailIdParticipantsParticipantIdReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var participantId = participantId_example;  // string | 
            var body = new TransferRequest(); // TransferRequest |  (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostEmailsEmailIdParticipantsParticipantIdReplace(emailId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostEmailsEmailIdParticipantsParticipantIdReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **participantId** | **string**|  |  |
| **body** | [**TransferRequest**](TransferRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postfaxes"></a>

## [**FaxSendResponse**](FaxSendResponse.html) PostFaxes (FaxSendRequest body = null)

Create Fax Conversation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostFaxesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new FaxSendRequest(); // FaxSendRequest | Fax (optional) 

            try
            {
                // Create Fax Conversation
                FaxSendResponse result = apiInstance.PostFaxes(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostFaxes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FaxSendRequest**](FaxSendRequest.html)| Fax | [optional]  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.html)

<a name="putemailsemailidmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) PutEmailsEmailIdMessagesDraft (string emailId, EmailMessage body = null)

Update conversation draft reply



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutEmailsEmailIdMessagesDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | 
            var body = new EmailMessage(); // EmailMessage | Draft (optional) 

            try
            {
                // Update conversation draft reply
                EmailMessage result = apiInstance.PutEmailsEmailIdMessagesDraft(emailId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutEmailsEmailIdMessagesDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**|  |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Draft | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)
