# ININ.PureCloudApi.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCallsCallIdParticipantsParticipantIdConsult**](ConversationsApi.md#deletecallscallidparticipantsparticipantidconsult) | **DELETE** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId**](ConversationsApi.md#deleteemailsemailidmessagesdraftattachmentsattachmentid) | **DELETE** /api/v2/conversations/emails/{emailId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**GetCallbacks**](ConversationsApi.md#getcallbacks) | **GET** /api/v2/conversations/callbacks | Get callback conversations |
| [**GetCallbacksCallbackId**](ConversationsApi.md#getcallbackscallbackid) | **GET** /api/v2/conversations/callbacks/{callbackId} | Get callback conversation |
| [**GetCallbacksCallbackIdParticipantsParticipantIdWrapup**](ConversationsApi.md#getcallbackscallbackidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.md#getcallbackscallbackidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetCalls**](ConversationsApi.md#getcalls) | **GET** /api/v2/conversations/calls | Get recent conversations |
| [**GetCallsCallId**](ConversationsApi.md#getcallscallid) | **GET** /api/v2/conversations/calls/{callId} | Get call conversation |
| [**GetCallsCallIdParticipantsParticipantIdWrapup**](ConversationsApi.md#getcallscallidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/calls/{callId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetCallsCallIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.md#getcallscallidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/calls/{callId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetCallsMaximumconferenceparties**](ConversationsApi.md#getcallsmaximumconferenceparties) | **GET** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetChats**](ConversationsApi.md#getchats) | **GET** /api/v2/conversations/chats | Get recent chat conversations |
| [**GetChatsChatId**](ConversationsApi.md#getchatschatid) | **GET** /api/v2/conversations/chats/{chatId} | Get chat conversation |
| [**GetChatsChatIdParticipantsParticipantIdWrapup**](ConversationsApi.md#getchatschatidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetChatsChatIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.md#getchatschatidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversationId**](ConversationsApi.md#getconversationid) | **GET** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationIdParticipantsParticipantIdWrapup**](ConversationsApi.md#getconversationidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.md#getconversationidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversations**](ConversationsApi.md#getconversations) | **GET** /api/v2/conversations | Get conversations |
| [**GetConversationsConversationIdDetails**](ConversationsApi.md#getconversationsconversationiddetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetEmails**](ConversationsApi.md#getemails) | **GET** /api/v2/conversations/emails | Get recent email conversations |
| [**GetEmailsEmailId**](ConversationsApi.md#getemailsemailid) | **GET** /api/v2/conversations/emails/{emailId} | Get email conversation |
| [**GetEmailsEmailIdMessages**](ConversationsApi.md#getemailsemailidmessages) | **GET** /api/v2/conversations/emails/{emailId}/messages | Get conversation messages |
| [**GetEmailsEmailIdMessagesDraft**](ConversationsApi.md#getemailsemailidmessagesdraft) | **GET** /api/v2/conversations/emails/{emailId}/messages/draft | Get conversation draft reply |
| [**GetEmailsEmailIdMessagesMessageId**](ConversationsApi.md#getemailsemailidmessagesmessageid) | **GET** /api/v2/conversations/emails/{emailId}/messages/{messageId} | Get conversation message |
| [**GetEmailsEmailIdParticipantsParticipantIdWrapup**](ConversationsApi.md#getemailsemailidparticipantsparticipantidwrapup) | **GET** /api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetEmailsEmailIdParticipantsParticipantIdWrapupcodes**](ConversationsApi.md#getemailsemailidparticipantsparticipantidwrapupcodes) | **GET** /api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**PatchCallbacksCallbackIdParticipantsParticipantId**](ConversationsApi.md#patchcallbackscallbackidparticipantsparticipantid) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId} | Update conversation participant |
| [**PatchCallbacksCallbackIdParticipantsParticipantIdAttributes**](ConversationsApi.md#patchcallbackscallbackidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchCallsCallId**](ConversationsApi.md#patchcallscallid) | **PATCH** /api/v2/conversations/calls/{callId} | Update conversation |
| [**PatchCallsCallIdParticipantsParticipantId**](ConversationsApi.md#patchcallscallidparticipantsparticipantid) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId} | Update conversation participant |
| [**PatchCallsCallIdParticipantsParticipantIdAttributes**](ConversationsApi.md#patchcallscallidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchCallsCallIdParticipantsParticipantIdConsult**](ConversationsApi.md#patchcallscallidparticipantsparticipantidconsult) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Change who can speak |
| [**PatchChatsChatIdParticipantsParticipantId**](ConversationsApi.md#patchchatschatidparticipantsparticipantid) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId} | Update conversation participant |
| [**PatchChatsChatIdParticipantsParticipantIdAttributes**](ConversationsApi.md#patchchatschatidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchConversationIdParticipantsParticipantId**](ConversationsApi.md#patchconversationidparticipantsparticipantid) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationIdParticipantsParticipantIdAttributes**](ConversationsApi.md#patchconversationidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchEmailsEmailIdParticipantsParticipantId**](ConversationsApi.md#patchemailsemailidparticipantsparticipantid) | **PATCH** /api/v2/conversations/emails/{emailId}/participants/{participantId} | Update conversation participant |
| [**PatchEmailsEmailIdParticipantsParticipantIdAttributes**](ConversationsApi.md#patchemailsemailidparticipantsparticipantidattributes) | **PATCH** /api/v2/conversations/emails/{emailId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PostCallbacksCallbackIdParticipantsParticipantIdReplace**](ConversationsApi.md#postcallbackscallbackidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostCalls**](ConversationsApi.md#postcalls) | **POST** /api/v2/conversations/calls | Create a call conversation |
| [**PostCallsCallId**](ConversationsApi.md#postcallscallid) | **POST** /api/v2/conversations/calls/{callId} | Add a new call to a conversation |
| [**PostCallsCallIdParticipants**](ConversationsApi.md#postcallscallidparticipants) | **POST** /api/v2/conversations/calls/{callId}/participants | Add participants to a conversation |
| [**PostCallsCallIdParticipantsParticipantIdConsult**](ConversationsApi.md#postcallscallidparticipantsparticipantidconsult) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostCallsCallIdParticipantsParticipantIdMonitor**](ConversationsApi.md#postcallscallidparticipantsparticipantidmonitor) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostCallsCallIdParticipantsParticipantIdReplace**](ConversationsApi.md#postcallscallidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostChatsChatIdParticipantsParticipantIdReplace**](ConversationsApi.md#postchatschatidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/chats/{chatId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationIdParticipantsParticipantIdCallbacks**](ConversationsApi.md#postconversationidparticipantsparticipantidcallbacks) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationIdParticipantsParticipantIdReplace**](ConversationsApi.md#postconversationidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsAggregatesQuery**](ConversationsApi.md#postconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostConversationsConversationIdDetailsProperties**](ConversationsApi.md#postconversationsconversationiddetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostConversationsDetailsQuery**](ConversationsApi.md#postconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostEmailsEmailIdMessages**](ConversationsApi.md#postemailsemailidmessages) | **POST** /api/v2/conversations/emails/{emailId}/messages | Send an email reply |
| [**PostEmailsEmailIdParticipantsParticipantIdReplace**](ConversationsApi.md#postemailsemailidparticipantsparticipantidreplace) | **POST** /api/v2/conversations/emails/{emailId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostFaxes**](ConversationsApi.md#postfaxes) | **POST** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PutEmailsEmailIdMessagesDraft**](ConversationsApi.md#putemailsemailidmessagesdraft) | **PUT** /api/v2/conversations/emails/{emailId}/messages/draft | Update conversation draft reply |
{: class="table table-striped"}

<a name="DeleteCallsCallIdParticipantsParticipantIdConsult"></a>
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

<a name="DeleteEmailsEmailIdMessagesDraftAttachmentsAttachmentId"></a>
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

<a name="GetCallbacks"></a>
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

[**CallbackConversationEntityListing**](CallbackConversationEntityListing.md)

<a name="GetCallbacksCallbackId"></a>
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

[**CallbackConversation**](CallbackConversation.md)

<a name="GetCallbacksCallbackIdParticipantsParticipantIdWrapup"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetCallbacksCallbackIdParticipantsParticipantIdWrapupcodes"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetCalls"></a>
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

[**CallConversationEntityListing**](CallConversationEntityListing.md)

<a name="GetCallsCallId"></a>
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

[**CallConversation**](CallConversation.md)

<a name="GetCallsCallIdParticipantsParticipantIdWrapup"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetCallsCallIdParticipantsParticipantIdWrapupcodes"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetCallsMaximumconferenceparties"></a>
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

[**MaxParticipants**](MaxParticipants.md)

<a name="GetChats"></a>
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

[**ChatConversationEntityListing**](ChatConversationEntityListing.md)

<a name="GetChatsChatId"></a>
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

[**ChatConversation**](ChatConversation.md)

<a name="GetChatsChatIdParticipantsParticipantIdWrapup"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetChatsChatIdParticipantsParticipantIdWrapupcodes"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetConversationId"></a>
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

[**Conversation**](Conversation.md)

<a name="GetConversationIdParticipantsParticipantIdWrapup"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetConversationIdParticipantsParticipantIdWrapupcodes"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetConversations"></a>
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

[**ConversationEntityListing**](ConversationEntityListing.md)

<a name="GetConversationsConversationIdDetails"></a>
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

[**AnalyticsConversation**](AnalyticsConversation.md)

<a name="GetEmails"></a>
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

[**EmailConversationEntityListing**](EmailConversationEntityListing.md)

<a name="GetEmailsEmailId"></a>
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

[**EmailConversation**](EmailConversation.md)

<a name="GetEmailsEmailIdMessages"></a>
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

[**EmailMessageListing**](EmailMessageListing.md)

<a name="GetEmailsEmailIdMessagesDraft"></a>
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

[**EmailMessage**](EmailMessage.md)

<a name="GetEmailsEmailIdMessagesMessageId"></a>
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

[**EmailMessage**](EmailMessage.md)

<a name="GetEmailsEmailIdParticipantsParticipantIdWrapup"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="GetEmailsEmailIdParticipantsParticipantIdWrapupcodes"></a>
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

[**WrapupCode**](WrapupCode.md)

<a name="PatchCallbacksCallbackIdParticipantsParticipantId"></a>
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchCallbacksCallbackIdParticipantsParticipantIdAttributes"></a>
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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchCallsCallId"></a>
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
| **body** | [**Conversation**](Conversation.md)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.md)

<a name="PatchCallsCallIdParticipantsParticipantId"></a>
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchCallsCallIdParticipantsParticipantIdAttributes"></a>
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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchCallsCallIdParticipantsParticipantIdConsult"></a>
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
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.md)| new speak to | [optional]  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.md)

<a name="PatchChatsChatIdParticipantsParticipantId"></a>
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchChatsChatIdParticipantsParticipantIdAttributes"></a>
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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchConversationIdParticipantsParticipantId"></a>
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchConversationIdParticipantsParticipantIdAttributes"></a>
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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchEmailsEmailIdParticipantsParticipantId"></a>
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PatchEmailsEmailIdParticipantsParticipantIdAttributes"></a>
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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostCallbacksCallbackIdParticipantsParticipantIdReplace"></a>
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
| **body** | [**TransferRequest**](TransferRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostCalls"></a>
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
| **body** | [**CreateCallRequest**](CreateCallRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**CreateCallResponse**](CreateCallResponse.md)

<a name="PostCallsCallId"></a>
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
| **body** | [**CallCommand**](CallCommand.md)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.md)

<a name="PostCallsCallIdParticipants"></a>
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
| **body** | [**Conversation**](Conversation.md)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.md)

<a name="PostCallsCallIdParticipantsParticipantIdConsult"></a>
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
| **body** | [**ConsultTransfer**](ConsultTransfer.md)| Destination address &amp; initial speak to | [optional]  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.md)

<a name="PostCallsCallIdParticipantsParticipantIdMonitor"></a>
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

<a name="PostCallsCallIdParticipantsParticipantIdReplace"></a>
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
| **body** | [**TransferRequest**](TransferRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostChatsChatIdParticipantsParticipantIdReplace"></a>
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
| **body** | [**TransferRequest**](TransferRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostConversationIdParticipantsParticipantIdCallbacks"></a>
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
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostConversationIdParticipantsParticipantIdReplace"></a>
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
| **body** | [**TransferRequest**](TransferRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostConversationsAggregatesQuery"></a>
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
| **body** | [**AggregationQuery**](AggregationQuery.md)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.md)

<a name="PostConversationsConversationIdDetailsProperties"></a>
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
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.md)| request | [optional]  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.md)

<a name="PostConversationsDetailsQuery"></a>
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
| **body** | [**ConversationQuery**](ConversationQuery.md)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.md)

<a name="PostEmailsEmailIdMessages"></a>
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
| **body** | [**EmailMessage**](EmailMessage.md)| Reply | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.md)

<a name="PostEmailsEmailIdParticipantsParticipantIdReplace"></a>
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
| **body** | [**TransferRequest**](TransferRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PostFaxes"></a>
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
| **body** | [**FaxSendRequest**](FaxSendRequest.md)| Fax | [optional]  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.md)

<a name="PutEmailsEmailIdMessagesDraft"></a>
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
| **body** | [**EmailMessage**](EmailMessage.md)| Draft | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.md)

