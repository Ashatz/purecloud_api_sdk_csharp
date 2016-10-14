---
title: ConversationsApi
---
## ININ.PureCloudApi.Api.ConversationsApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCallParticipantConsult**](ConversationsApi.html#deletecallparticipantconsult) | **DELETE** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Cancel the transfer |
| [**DeleteConversationParticipantCodesAddCommunicationCode**](ConversationsApi.html#deleteconversationparticipantcodesaddcommunicationcode) | **DELETE** /api/v2/conversations/{conversationId}/participants/{participantId}/codes/{addCommunicationCode} | Delete a code used to add a communication to this participant |
| [**DeleteEmailMessagesDraftAttachment**](ConversationsApi.html#deleteemailmessagesdraftattachment) | **DELETE** /api/v2/conversations/emails/{emailId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**GetCall**](ConversationsApi.html#getcall) | **GET** /api/v2/conversations/calls/{callId} | Get call conversation |
| [**GetCallParticipantWrapup**](ConversationsApi.html#getcallparticipantwrapup) | **GET** /api/v2/conversations/calls/{callId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetCallParticipantWrapupcodes**](ConversationsApi.html#getcallparticipantwrapupcodes) | **GET** /api/v2/conversations/calls/{callId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetCallback**](ConversationsApi.html#getcallback) | **GET** /api/v2/conversations/callbacks/{callbackId} | Get callback conversation |
| [**GetCallbackParticipantWrapup**](ConversationsApi.html#getcallbackparticipantwrapup) | **GET** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetCallbackParticipantWrapupcodes**](ConversationsApi.html#getcallbackparticipantwrapupcodes) | **GET** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetCallbacks**](ConversationsApi.html#getcallbacks) | **GET** /api/v2/conversations/callbacks | Get callback conversations |
| [**GetCalls**](ConversationsApi.html#getcalls) | **GET** /api/v2/conversations/calls | Get recent conversations |
| [**GetCallsHistory**](ConversationsApi.html#getcallshistory) | **GET** /api/v2/conversations/calls/history | Get call history |
| [**GetCallsMaximumconferenceparties**](ConversationsApi.html#getcallsmaximumconferenceparties) | **GET** /api/v2/conversations/calls/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**GetChat**](ConversationsApi.html#getchat) | **GET** /api/v2/conversations/chats/{chatId} | Get chat conversation |
| [**GetChatParticipantWrapup**](ConversationsApi.html#getchatparticipantwrapup) | **GET** /api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetChatParticipantWrapupcodes**](ConversationsApi.html#getchatparticipantwrapupcodes) | **GET** /api/v2/conversations/chats/{chatId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetChats**](ConversationsApi.html#getchats) | **GET** /api/v2/conversations/chats | Get recent chat conversations |
| [**GetConversation**](ConversationsApi.html#getconversation) | **GET** /api/v2/conversations/{conversationId} | Get conversation |
| [**GetConversationDetails**](ConversationsApi.html#getconversationdetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetConversationParticipantWrapup**](ConversationsApi.html#getconversationparticipantwrapup) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetConversationParticipantWrapupcodes**](ConversationsApi.html#getconversationparticipantwrapupcodes) | **GET** /api/v2/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetConversations**](ConversationsApi.html#getconversations) | **GET** /api/v2/conversations | Get conversations |
| [**GetEmail**](ConversationsApi.html#getemail) | **GET** /api/v2/conversations/emails/{emailId} | Get email conversation |
| [**GetEmailMessage**](ConversationsApi.html#getemailmessage) | **GET** /api/v2/conversations/emails/{emailId}/messages/{messageId} | Get conversation message |
| [**GetEmailMessages**](ConversationsApi.html#getemailmessages) | **GET** /api/v2/conversations/emails/{emailId}/messages | Get conversation messages |
| [**GetEmailMessagesDraft**](ConversationsApi.html#getemailmessagesdraft) | **GET** /api/v2/conversations/emails/{emailId}/messages/draft | Get conversation draft reply |
| [**GetEmailParticipantWrapup**](ConversationsApi.html#getemailparticipantwrapup) | **GET** /api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**GetEmailParticipantWrapupcodes**](ConversationsApi.html#getemailparticipantwrapupcodes) | **GET** /api/v2/conversations/emails/{emailId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**GetEmails**](ConversationsApi.html#getemails) | **GET** /api/v2/conversations/emails | Get recent email conversations |
| [**PatchCall**](ConversationsApi.html#patchcall) | **PATCH** /api/v2/conversations/calls/{callId} | Update a conversation by setting it&#39;s recording state, merging in other conversations to create a conference, or disconnecting all of the participants |
| [**PatchCallParticipant**](ConversationsApi.html#patchcallparticipant) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId} | Update conversation participant |
| [**PatchCallParticipantAttributes**](ConversationsApi.html#patchcallparticipantattributes) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchCallParticipantCommunication**](ConversationsApi.html#patchcallparticipantcommunication) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchCallParticipantConsult**](ConversationsApi.html#patchcallparticipantconsult) | **PATCH** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Change who can speak |
| [**PatchCallback**](ConversationsApi.html#patchcallback) | **PATCH** /api/v2/conversations/callbacks/{callbackId} | Update a conversation by disconnecting all of the participants |
| [**PatchCallbackParticipant**](ConversationsApi.html#patchcallbackparticipant) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId} | Update conversation participant |
| [**PatchCallbackParticipantAttributes**](ConversationsApi.html#patchcallbackparticipantattributes) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchCallbackParticipantCommunication**](ConversationsApi.html#patchcallbackparticipantcommunication) | **PATCH** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchChat**](ConversationsApi.html#patchchat) | **PATCH** /api/v2/conversations/chats/{chatId} | Update a conversation by disconnecting all of the participants |
| [**PatchChatParticipant**](ConversationsApi.html#patchchatparticipant) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId} | Update conversation participant |
| [**PatchChatParticipantAttributes**](ConversationsApi.html#patchchatparticipantattributes) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchChatParticipantCommunication**](ConversationsApi.html#patchchatparticipantcommunication) | **PATCH** /api/v2/conversations/chats/{chatId}/participants/{participantId}/communications/{communicationId} | Update conversation participant&#39;s communication by disconnecting it. |
| [**PatchConversationParticipant**](ConversationsApi.html#patchconversationparticipant) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**PatchConversationParticipantAttributes**](ConversationsApi.html#patchconversationparticipantattributes) | **PATCH** /api/v2/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PatchEmail**](ConversationsApi.html#patchemail) | **PATCH** /api/v2/conversations/emails/{emailId} | Update a conversation by disconnecting all of the participants |
| [**PatchEmailParticipant**](ConversationsApi.html#patchemailparticipant) | **PATCH** /api/v2/conversations/emails/{emailId}/participants/{participantId} | Update conversation participant |
| [**PatchEmailParticipantAttributes**](ConversationsApi.html#patchemailparticipantattributes) | **PATCH** /api/v2/conversations/emails/{emailId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**PostCall**](ConversationsApi.html#postcall) | **POST** /api/v2/conversations/calls/{callId} | Add a new call to a conversation |
| [**PostCallParticipantConsult**](ConversationsApi.html#postcallparticipantconsult) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**PostCallParticipantMonitor**](ConversationsApi.html#postcallparticipantmonitor) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**PostCallParticipantReplace**](ConversationsApi.html#postcallparticipantreplace) | **POST** /api/v2/conversations/calls/{callId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostCallParticipants**](ConversationsApi.html#postcallparticipants) | **POST** /api/v2/conversations/calls/{callId}/participants | Add participants to a conversation |
| [**PostCallbackParticipantReplace**](ConversationsApi.html#postcallbackparticipantreplace) | **POST** /api/v2/conversations/callbacks/{callbackId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostCallbacks**](ConversationsApi.html#postcallbacks) | **POST** /api/v2/conversations/callbacks | Create a Callback |
| [**PostCalls**](ConversationsApi.html#postcalls) | **POST** /api/v2/conversations/calls | Create a call conversation |
| [**PostChatParticipantReplace**](ConversationsApi.html#postchatparticipantreplace) | **POST** /api/v2/conversations/chats/{chatId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationDetailsProperties**](ConversationsApi.html#postconversationdetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostConversationParticipantCallbacks**](ConversationsApi.html#postconversationparticipantcallbacks) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/callbacks | Create a new callback for the specified participant on the conversation. |
| [**PostConversationParticipantReplace**](ConversationsApi.html#postconversationparticipantreplace) | **POST** /api/v2/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostConversationsAggregatesQuery**](ConversationsApi.html#postconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostConversationsDetailsQuery**](ConversationsApi.html#postconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostEmailMessages**](ConversationsApi.html#postemailmessages) | **POST** /api/v2/conversations/emails/{emailId}/messages | Send an email reply |
| [**PostEmailParticipantReplace**](ConversationsApi.html#postemailparticipantreplace) | **POST** /api/v2/conversations/emails/{emailId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**PostFaxes**](ConversationsApi.html#postfaxes) | **POST** /api/v2/conversations/faxes | Create Fax Conversation |
| [**PutEmailMessagesDraft**](ConversationsApi.html#putemailmessagesdraft) | **PUT** /api/v2/conversations/emails/{emailId}/messages/draft | Update conversation draft reply |
{: class="table table-striped"}

<a name="deletecallparticipantconsult"></a>

## **string** DeleteCallParticipantConsult (string callId, string participantId)

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
    public class DeleteCallParticipantConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Cancel the transfer
                string result = apiInstance.DeleteCallParticipantConsult(callId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteCallParticipantConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteconversationparticipantcodesaddcommunicationcode"></a>

## void DeleteConversationParticipantCodesAddCommunicationCode (string conversationId, string participantId, string addCommunicationCode)

Delete a code used to add a communication to this participant



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteConversationParticipantCodesAddCommunicationCodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var addCommunicationCode = addCommunicationCode_example;  // string | addCommunicationCode

            try
            {
                // Delete a code used to add a communication to this participant
                apiInstance.DeleteConversationParticipantCodesAddCommunicationCode(conversationId, participantId, addCommunicationCode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteConversationParticipantCodesAddCommunicationCode: " + e.Message );
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
| **addCommunicationCode** | **string**| addCommunicationCode |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteemailmessagesdraftattachment"></a>

## **string** DeleteEmailMessagesDraftAttachment (string emailId, string attachmentId)

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
    public class DeleteEmailMessagesDraftAttachmentExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var attachmentId = attachmentId_example;  // string | attachmentId

            try
            {
                // Delete attachment from draft
                string result = apiInstance.DeleteEmailMessagesDraftAttachment(emailId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.DeleteEmailMessagesDraftAttachment: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **attachmentId** | **string**| attachmentId |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getcall"></a>

## [**CallConversation**](CallConversation.html) GetCall (string callId)

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
    public class GetCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId

            try
            {
                // Get call conversation
                CallConversation result = apiInstance.GetCall(callId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCall: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
{: class="table table-striped"}

### Return type

[**CallConversation**](CallConversation.html)

<a name="getcallparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetCallParticipantWrapup (string callId, string participantId, bool? provisional = null)

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
    public class GetCallParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetCallParticipantWrapup(callId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getcallparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetCallParticipantWrapupcodes (string callId, string participantId)

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
    public class GetCallParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetCallParticipantWrapupcodes(callId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

<a name="getcallback"></a>

## [**CallbackConversation**](CallbackConversation.html) GetCallback (string callbackId)

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
    public class GetCallbackExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId

            try
            {
                // Get callback conversation
                CallbackConversation result = apiInstance.GetCallback(callbackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallback: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
{: class="table table-striped"}

### Return type

[**CallbackConversation**](CallbackConversation.html)

<a name="getcallbackparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetCallbackParticipantWrapup (string callbackId, string participantId, bool? provisional = null)

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
    public class GetCallbackParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetCallbackParticipantWrapup(callbackId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallbackParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getcallbackparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetCallbackParticipantWrapupcodes (string callbackId, string participantId)

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
    public class GetCallbackParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetCallbackParticipantWrapupcodes(callbackId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallbackParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

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

<a name="getcallshistory"></a>

## [**CallConversationEntityListing**](CallConversationEntityListing.html) GetCallsHistory (int? pageSize = null, int? pageNumber = null, string interval = null)

Get call history



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCallsHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var interval = interval_example;  // string | Interval string; format is ISO-8601. Separate start and end times with forward slash '/' (optional) 

            try
            {
                // Get call history
                CallConversationEntityListing result = apiInstance.GetCallsHistory(pageSize, pageNumber, interval);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetCallsHistory: " + e.Message );
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
| **interval** | **string**| Interval string; format is ISO-8601. Separate start and end times with forward slash &#39;/&#39; | [optional]  |
{: class="table table-striped"}

### Return type

[**CallConversationEntityListing**](CallConversationEntityListing.html)

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

<a name="getchat"></a>

## [**ChatConversation**](ChatConversation.html) GetChat (string chatId)

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
    public class GetChatExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId

            try
            {
                // Get chat conversation
                ChatConversation result = apiInstance.GetChat(chatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChat: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
{: class="table table-striped"}

### Return type

[**ChatConversation**](ChatConversation.html)

<a name="getchatparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetChatParticipantWrapup (string chatId, string participantId, bool? provisional = null)

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
    public class GetChatParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetChatParticipantWrapup(chatId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChatParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getchatparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetChatParticipantWrapupcodes (string chatId, string participantId)

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
    public class GetChatParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetChatParticipantWrapupcodes(chatId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetChatParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

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

<a name="getconversation"></a>

## [**Conversation**](Conversation.html) GetConversation (string conversationId)

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
    public class GetConversationExample
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
                Conversation result = apiInstance.GetConversation(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversation: " + e.Message );
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

<a name="getconversationdetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetConversationDetails (string conversationId)

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
    public class GetConversationDetailsExample
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
                AnalyticsConversation result = apiInstance.GetConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationDetails: " + e.Message );
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

<a name="getconversationparticipantwrapup"></a>

## [**WrapupCode**](WrapupCode.html) GetConversationParticipantWrapup (string conversationId, string participantId, bool? provisional = null)

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
    public class GetConversationParticipantWrapupExample
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
                WrapupCode result = apiInstance.GetConversationParticipantWrapup(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapup: " + e.Message );
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

<a name="getconversationparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetConversationParticipantWrapupcodes (string conversationId, string participantId)

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
    public class GetConversationParticipantWrapupcodesExample
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
                List&lt;WrapupCode&gt; result = apiInstance.GetConversationParticipantWrapupcodes(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetConversationParticipantWrapupcodes: " + e.Message );
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

[**List<WrapupCode>**](WrapupCode.html)

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

<a name="getemail"></a>

## [**EmailConversation**](EmailConversation.html) GetEmail (string emailId)

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
    public class GetEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId

            try
            {
                // Get email conversation
                EmailConversation result = apiInstance.GetEmail(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmail: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
{: class="table table-striped"}

### Return type

[**EmailConversation**](EmailConversation.html)

<a name="getemailmessage"></a>

## [**EmailMessage**](EmailMessage.html) GetEmailMessage (string emailId, string messageId)

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
    public class GetEmailMessageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var messageId = messageId_example;  // string | messageId

            try
            {
                // Get conversation message
                EmailMessage result = apiInstance.GetEmailMessage(emailId, messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailMessage: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **messageId** | **string**| messageId |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getemailmessages"></a>

## [**EmailMessageListing**](EmailMessageListing.html) GetEmailMessages (string emailId)

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
    public class GetEmailMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId

            try
            {
                // Get conversation messages
                EmailMessageListing result = apiInstance.GetEmailMessages(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
{: class="table table-striped"}

### Return type

[**EmailMessageListing**](EmailMessageListing.html)

<a name="getemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) GetEmailMessagesDraft (string emailId)

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
    public class GetEmailMessagesDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId

            try
            {
                // Get conversation draft reply
                EmailMessage result = apiInstance.GetEmailMessagesDraft(emailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="getemailparticipantwrapup"></a>

## [**Wrapup**](Wrapup.html) GetEmailParticipantWrapup (string emailId, string participantId, bool? provisional = null)

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
    public class GetEmailParticipantWrapupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var participantId = participantId_example;  // string | participantId
            var provisional = true;  // bool? | Indicates if the wrap-up code is provisional. (optional)  (default to false)

            try
            {
                // Get the wrap-up for this conversation participant. 
                Wrapup result = apiInstance.GetEmailParticipantWrapup(emailId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailParticipantWrapup: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **participantId** | **string**| participantId |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Wrapup**](Wrapup.html)

<a name="getemailparticipantwrapupcodes"></a>

## [**List&lt;WrapupCode&gt;**](WrapupCode.html) GetEmailParticipantWrapupcodes (string emailId, string participantId)

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
    public class GetEmailParticipantWrapupcodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Get list of wrapup codes for this conversation participant
                List&lt;WrapupCode&gt; result = apiInstance.GetEmailParticipantWrapupcodes(emailId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.GetEmailParticipantWrapupcodes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

[**List<WrapupCode>**](WrapupCode.html)

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

<a name="patchcall"></a>

## [**Conversation**](Conversation.html) PatchCall (string callId, Conversation body)

Update a conversation by setting it's recording state, merging in other conversations to create a conference, or disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by setting it's recording state, merging in other conversations to create a conference, or disconnecting all of the participants
                Conversation result = apiInstance.PatchCall(callId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCall: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchcallparticipant"></a>

## void PatchCallParticipant (string callId, string participantId, MediaParticipantRequest body)

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
    public class PatchCallParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant request

            try
            {
                // Update conversation participant
                apiInstance.PatchCallParticipant(callId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallparticipantattributes"></a>

## void PatchCallParticipantAttributes (string callId, string participantId, ParticipantAttributes body)

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
    public class PatchCallParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchCallParticipantAttributes(callId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallparticipantcommunication"></a>

## void PatchCallParticipantCommunication (string callId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                apiInstance.PatchCallParticipantCommunication(callId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PatchCallParticipantConsult (string callId, string participantId, ConsultTransferUpdate body)

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
    public class PatchCallParticipantConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransferUpdate(); // ConsultTransferUpdate | new speak to

            try
            {
                // Change who can speak
                ConsultTransferResponse result = apiInstance.PatchCallParticipantConsult(callId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallParticipantConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.html)| new speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="patchcallback"></a>

## [**Conversation**](Conversation.html) PatchCallback (string callbackId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallbackExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchCallback(callbackId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallback: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchcallbackparticipant"></a>

## void PatchCallbackParticipant (string callbackId, string participantId, MediaParticipantRequest body)

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
    public class PatchCallbackParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant
                apiInstance.PatchCallbackParticipant(callbackId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallbackParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallbackparticipantattributes"></a>

## void PatchCallbackParticipantAttributes (string callbackId, string participantId, ParticipantAttributes body)

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
    public class PatchCallbackParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchCallbackParticipantAttributes(callbackId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallbackParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchcallbackparticipantcommunication"></a>

## void PatchCallbackParticipantCommunication (string callbackId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchCallbackParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                apiInstance.PatchCallbackParticipantCommunication(callbackId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchCallbackParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchchat"></a>

## [**Conversation**](Conversation.html) PatchChat (string chatId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchChatExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchChat(chatId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchChat: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchchatparticipant"></a>

## void PatchChatParticipant (string chatId, string participantId, MediaParticipantRequest body)

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
    public class PatchChatParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            {
                // Update conversation participant
                apiInstance.PatchChatParticipant(chatId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchChatParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchchatparticipantattributes"></a>

## void PatchChatParticipantAttributes (string chatId, string participantId, ParticipantAttributes body)

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
    public class PatchChatParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchChatParticipantAttributes(chatId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchChatParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchchatparticipantcommunication"></a>

## void PatchChatParticipantCommunication (string chatId, string participantId, string communicationId, MediaParticipantRequest body)

Update conversation participant's communication by disconnecting it.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchChatParticipantCommunicationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var participantId = participantId_example;  // string | participantId
            var communicationId = communicationId_example;  // string | communicationId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Participant

            try
            {
                // Update conversation participant's communication by disconnecting it.
                apiInstance.PatchChatParticipantCommunication(chatId, participantId, communicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchChatParticipantCommunication: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **participantId** | **string**| participantId |  |
| **communicationId** | **string**| communicationId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Participant |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationparticipant"></a>

## void PatchConversationParticipant (string conversationId, string participantId, MediaParticipantRequest body)

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
    public class PatchConversationParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            {
                // Update a participant.
                apiInstance.PatchConversationParticipant(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipant: " + e.Message );
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
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchconversationparticipantattributes"></a>

## void PatchConversationParticipantAttributes (string conversationId, string participantId, ParticipantAttributes body)

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
    public class PatchConversationParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchConversationParticipantAttributes(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchConversationParticipantAttributes: " + e.Message );
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
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchemail"></a>

## [**Conversation**](Conversation.html) PatchEmail (string emailId, Conversation body)

Update a conversation by disconnecting all of the participants



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchEmailExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Update a conversation by disconnecting all of the participants
                Conversation result = apiInstance.PatchEmail(emailId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchEmail: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="patchemailparticipant"></a>

## void PatchEmailParticipant (string emailId, string participantId, MediaParticipantRequest body)

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
    public class PatchEmailParticipantExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var participantId = participantId_example;  // string | participantId
            var body = new MediaParticipantRequest(); // MediaParticipantRequest | Update request

            try
            {
                // Update conversation participant
                apiInstance.PatchEmailParticipant(emailId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchEmailParticipant: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**MediaParticipantRequest**](MediaParticipantRequest.html)| Update request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="patchemailparticipantattributes"></a>

## void PatchEmailParticipantAttributes (string emailId, string participantId, ParticipantAttributes body)

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
    public class PatchEmailParticipantAttributesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var participantId = participantId_example;  // string | participantId
            var body = new ParticipantAttributes(); // ParticipantAttributes | Participant attributes

            try
            {
                // Update the attributes on a conversation participant.
                apiInstance.PatchEmailParticipantAttributes(emailId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PatchEmailParticipantAttributes: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.html)| Participant attributes |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcall"></a>

## [**Conversation**](Conversation.html) PostCall (string callId, CallCommand body)

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
    public class PostCallExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var body = new CallCommand(); // CallCommand | Conversation

            try
            {
                // Add a new call to a conversation
                Conversation result = apiInstance.PostCall(callId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCall: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **body** | [**CallCommand**](CallCommand.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postcallparticipantconsult"></a>

## [**ConsultTransferResponse**](ConsultTransferResponse.html) PostCallParticipantConsult (string callId, string participantId, ConsultTransfer body)

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
    public class PostCallParticipantConsultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var body = new ConsultTransfer(); // ConsultTransfer | Destination address & initial speak to

            try
            {
                // Initiate and update consult transfer
                ConsultTransferResponse result = apiInstance.PostCallParticipantConsult(callId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallParticipantConsult: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**ConsultTransfer**](ConsultTransfer.html)| Destination address &amp; initial speak to |  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.html)

<a name="postcallparticipantmonitor"></a>

## void PostCallParticipantMonitor (string callId, string participantId)

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
    public class PostCallParticipantMonitorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId

            try
            {
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.PostCallParticipantMonitor(callId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallParticipantMonitor: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcallparticipantreplace"></a>

## void PostCallParticipantReplace (string callId, string participantId, TransferRequest body)

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
    public class PostCallParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostCallParticipantReplace(callId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcallparticipants"></a>

## [**Conversation**](Conversation.html) PostCallParticipants (string callId, Conversation body)

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
    public class PostCallParticipantsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callId = callId_example;  // string | callId
            var body = new Conversation(); // Conversation | Conversation

            try
            {
                // Add participants to a conversation
                Conversation result = apiInstance.PostCallParticipants(callId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallParticipants: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callId** | **string**| callId |  |
| **body** | [**Conversation**](Conversation.html)| Conversation |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.html)

<a name="postcallbackparticipantreplace"></a>

## void PostCallbackParticipantReplace (string callbackId, string participantId, TransferRequest body)

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
    public class PostCallbackParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var callbackId = callbackId_example;  // string | callbackId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostCallbackParticipantReplace(callbackId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallbackParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **callbackId** | **string**| callbackId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postcallbacks"></a>

## [**CreateCallbackResponse**](CreateCallbackResponse.html) PostCallbacks (CreateCallbackCommand body)

Create a Callback



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCallbacksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new CreateCallbackCommand(); // CreateCallbackCommand | Callback

            try
            {
                // Create a Callback
                CreateCallbackResponse result = apiInstance.PostCallbacks(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostCallbacks: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CreateCallbackCommand**](CreateCallbackCommand.html)| Callback |  |
{: class="table table-striped"}

### Return type

[**CreateCallbackResponse**](CreateCallbackResponse.html)

<a name="postcalls"></a>

## [**CreateCallResponse**](CreateCallResponse.html) PostCalls (CreateCallRequest body)

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
            var body = new CreateCallRequest(); // CreateCallRequest | Call request

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
| **body** | [**CreateCallRequest**](CreateCallRequest.html)| Call request |  |
{: class="table table-striped"}

### Return type

[**CreateCallResponse**](CreateCallResponse.html)

<a name="postchatparticipantreplace"></a>

## void PostChatParticipantReplace (string chatId, string participantId, TransferRequest body)

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
    public class PostChatParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var chatId = chatId_example;  // string | chatId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostChatParticipantReplace(chatId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostChatParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **chatId** | **string**| chatId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostConversationDetailsProperties (string conversationId, PropertyIndexRequest body)

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
    public class PostConversationDetailsPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request

            try
            {
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostConversationDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationDetailsProperties: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postconversationparticipantcallbacks"></a>

## void PostConversationParticipantCallbacks (string conversationId, string participantId, CreateCallbackCommand body = null)

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
    public class PostConversationParticipantCallbacksExample
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
                apiInstance.PostConversationParticipantCallbacks(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantCallbacks: " + e.Message );
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

<a name="postconversationparticipantreplace"></a>

## void PostConversationParticipantReplace (string conversationId, string participantId, TransferRequest body)

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
    public class PostConversationParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostConversationParticipantReplace(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostConversationParticipantReplace: " + e.Message );
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
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostConversationsAggregatesQuery (AggregationQuery body)

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
            var body = new AggregationQuery(); // AggregationQuery | query

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
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostConversationsDetailsQuery (ConversationQuery body)

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
            var body = new ConversationQuery(); // ConversationQuery | query

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
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postemailmessages"></a>

## [**EmailMessage**](EmailMessage.html) PostEmailMessages (string emailId, EmailMessage body)

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
    public class PostEmailMessagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var body = new EmailMessage(); // EmailMessage | Reply

            try
            {
                // Send an email reply
                EmailMessage result = apiInstance.PostEmailMessages(emailId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostEmailMessages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Reply |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

<a name="postemailparticipantreplace"></a>

## void PostEmailParticipantReplace (string emailId, string participantId, TransferRequest body)

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
    public class PostEmailParticipantReplaceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var participantId = participantId_example;  // string | participantId
            var body = new TransferRequest(); // TransferRequest | Transfer request

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.PostEmailParticipantReplace(emailId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PostEmailParticipantReplace: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **participantId** | **string**| participantId |  |
| **body** | [**TransferRequest**](TransferRequest.html)| Transfer request |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postfaxes"></a>

## [**FaxSendResponse**](FaxSendResponse.html) PostFaxes (FaxSendRequest body)

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
            var body = new FaxSendRequest(); // FaxSendRequest | Fax

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
| **body** | [**FaxSendRequest**](FaxSendRequest.html)| Fax |  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.html)

<a name="putemailmessagesdraft"></a>

## [**EmailMessage**](EmailMessage.html) PutEmailMessagesDraft (string emailId, EmailMessage body)

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
    public class PutEmailMessagesDraftExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var emailId = emailId_example;  // string | emailId
            var body = new EmailMessage(); // EmailMessage | Draft

            try
            {
                // Update conversation draft reply
                EmailMessage result = apiInstance.PutEmailMessagesDraft(emailId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.PutEmailMessagesDraft: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **emailId** | **string**| emailId |  |
| **body** | [**EmailMessage**](EmailMessage.html)| Draft |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.html)

