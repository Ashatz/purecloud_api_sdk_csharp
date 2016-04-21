# ININ.PureCloudApi.Api.ConversationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ConversationsConversationidGet**](ConversationsApi.md#conversationsconversationidget) | **GET** /api/v1/conversations/{conversationId} | Get conversation |
| [**ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete**](ConversationsApi.md#conversationsconversationidmessagesdraftattachmentsattachmentiddelete) | **DELETE** /api/v1/conversations/{conversationId}/messages/draft/attachments/{attachmentId} | Delete attachment from draft |
| [**ConversationsConversationidMessagesDraftGet**](ConversationsApi.md#conversationsconversationidmessagesdraftget) | **GET** /api/v1/conversations/{conversationId}/messages/draft | Get conversation draft reply |
| [**ConversationsConversationidMessagesDraftPut**](ConversationsApi.md#conversationsconversationidmessagesdraftput) | **PUT** /api/v1/conversations/{conversationId}/messages/draft | Update conversation draft reply |
| [**ConversationsConversationidMessagesGet**](ConversationsApi.md#conversationsconversationidmessagesget) | **GET** /api/v1/conversations/{conversationId}/messages | Get conversation messages |
| [**ConversationsConversationidMessagesIdGet**](ConversationsApi.md#conversationsconversationidmessagesidget) | **GET** /api/v1/conversations/{conversationId}/messages/{id} | Get conversation message |
| [**ConversationsConversationidMessagesPost**](ConversationsApi.md#conversationsconversationidmessagespost) | **POST** /api/v1/conversations/{conversationId}/messages | Send an email reply |
| [**ConversationsConversationidParticipantsParticipantidAttributesPut**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidattributesput) | **PUT** /api/v1/conversations/{conversationId}/participants/{participantId}/attributes | Update the attributes on a conversation participant. |
| [**ConversationsConversationidParticipantsParticipantidConsultDelete**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidconsultdelete) | **DELETE** /api/v1/conversations/{conversationId}/participants/{participantId}/consult | Cancel the transfer |
| [**ConversationsConversationidParticipantsParticipantidConsultPost**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidconsultpost) | **POST** /api/v1/conversations/{conversationId}/participants/{participantId}/consult | Initiate and update consult transfer |
| [**ConversationsConversationidParticipantsParticipantidConsultPut**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidconsultput) | **PUT** /api/v1/conversations/{conversationId}/participants/{participantId}/consult | Change who can speak |
| [**ConversationsConversationidParticipantsParticipantidMonitorPost**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidmonitorpost) | **POST** /api/v1/conversations/{conversationId}/participants/{participantId}/monitor | Listen in on the conversation from the point of view of a given participant. |
| [**ConversationsConversationidParticipantsParticipantidPut**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidput) | **PUT** /api/v1/conversations/{conversationId}/participants/{participantId} | Update a participant. |
| [**ConversationsConversationidParticipantsParticipantidReplacePost**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidreplacepost) | **POST** /api/v1/conversations/{conversationId}/participants/{participantId}/replace | Replace this participant with the specified user and/or address |
| [**ConversationsConversationidParticipantsParticipantidWrapupGet**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidwrapupget) | **GET** /api/v1/conversations/{conversationId}/participants/{participantId}/wrapup | Get the wrap-up for this conversation participant.  |
| [**ConversationsConversationidParticipantsParticipantidWrapupcodesGet**](ConversationsApi.md#conversationsconversationidparticipantsparticipantidwrapupcodesget) | **GET** /api/v1/conversations/{conversationId}/participants/{participantId}/wrapupcodes | Get list of wrapup codes for this conversation participant |
| [**ConversationsConversationidParticipantsPost**](ConversationsApi.md#conversationsconversationidparticipantspost) | **POST** /api/v1/conversations/{conversationId}/participants | Add participants to a conversation |
| [**ConversationsConversationidPut**](ConversationsApi.md#conversationsconversationidput) | **PUT** /api/v1/conversations/{conversationId} | Update conversation |
| [**ConversationsConversationidTagsGet**](ConversationsApi.md#conversationsconversationidtagsget) | **GET** /api/v1/conversations/{conversationId}/tags | Get possible tags for Conversation |
| [**ConversationsConversationidWrapupcodesGet**](ConversationsApi.md#conversationsconversationidwrapupcodesget) | **GET** /api/v1/conversations/{conversationId}/wrapupcodes | Get possible wrap-up codes for Conversation |
| [**ConversationsFaxPost**](ConversationsApi.md#conversationsfaxpost) | **POST** /api/v1/conversations/fax | Create Fax Conversation |
| [**ConversationsGet**](ConversationsApi.md#conversationsget) | **GET** /api/v1/conversations | Get conversations |
| [**ConversationsMaximumconferencepartiesGet**](ConversationsApi.md#conversationsmaximumconferencepartiesget) | **GET** /api/v1/conversations/maximumconferenceparties | Get the maximum number of participants that this user can have on a conference |
| [**ConversationsPost**](ConversationsApi.md#conversationspost) | **POST** /api/v1/conversations | Create conversation |
| [**ConversationsQueryAnchorPost**](ConversationsApi.md#conversationsqueryanchorpost) | **POST** /api/v1/conversations/query/{anchor} | Query historical conversations with a date/time anchor |
| [**ConversationsQueryPost**](ConversationsApi.md#conversationsquerypost) | **POST** /api/v1/conversations/query | Query historical conversations |
{: class="table table-striped"}

<a name="ConversationsConversationidGet"></a>
## [**Conversation**](Conversation.html) ConversationsConversationidGet (string conversationId)

Get conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidGetExample
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
                Conversation result = apiInstance.ConversationsConversationidGet(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.md)

<a name="ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete"></a>
## string** ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete (string conversationId, string attachmentId)

Delete attachment from draft



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidMessagesDraftAttachmentsAttachmentidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var attachmentId = attachmentId_example;  // string | attachment ID

            try
            {
                // Delete attachment from draft
                string result = apiInstance.ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete(conversationId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidMessagesDraftAttachmentsAttachmentidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **attachmentId** | **string**| attachment ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConversationsConversationidMessagesDraftGet"></a>
## [**EmailMessage**](EmailMessage.html) ConversationsConversationidMessagesDraftGet (string conversationId)

Get conversation draft reply



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidMessagesDraftGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            {
                // Get conversation draft reply
                EmailMessage result = apiInstance.ConversationsConversationidMessagesDraftGet(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidMessagesDraftGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.md)

<a name="ConversationsConversationidMessagesDraftPut"></a>
## [**EmailMessage**](EmailMessage.html) ConversationsConversationidMessagesDraftPut (string conversationId, EmailMessage body = null)

Update conversation draft reply



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidMessagesDraftPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new EmailMessage(); // EmailMessage | Draft (optional) 

            try
            {
                // Update conversation draft reply
                EmailMessage result = apiInstance.ConversationsConversationidMessagesDraftPut(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidMessagesDraftPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**EmailMessage**](EmailMessage.md)| Draft | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.md)

<a name="ConversationsConversationidMessagesGet"></a>
## [**EmailMessageListing**](EmailMessageListing.html) ConversationsConversationidMessagesGet (string conversationId)

Get conversation messages



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidMessagesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            {
                // Get conversation messages
                EmailMessageListing result = apiInstance.ConversationsConversationidMessagesGet(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidMessagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**EmailMessageListing**](EmailMessageListing.md)

<a name="ConversationsConversationidMessagesIdGet"></a>
## [**EmailMessage**](EmailMessage.html) ConversationsConversationidMessagesIdGet (string conversationId, string id)

Get conversation message



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidMessagesIdGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var id = id_example;  // string | message ID

            try
            {
                // Get conversation message
                EmailMessage result = apiInstance.ConversationsConversationidMessagesIdGet(conversationId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidMessagesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **id** | **string**| message ID |  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.md)

<a name="ConversationsConversationidMessagesPost"></a>
## [**EmailMessage**](EmailMessage.html) ConversationsConversationidMessagesPost (string conversationId, EmailMessage body = null)

Send an email reply



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidMessagesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new EmailMessage(); // EmailMessage | Reply (optional) 

            try
            {
                // Send an email reply
                EmailMessage result = apiInstance.ConversationsConversationidMessagesPost(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidMessagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**EmailMessage**](EmailMessage.md)| Reply | [optional]  |
{: class="table table-striped"}

### Return type

[**EmailMessage**](EmailMessage.md)

<a name="ConversationsConversationidParticipantsParticipantidAttributesPut"></a>
## void ConversationsConversationidParticipantsParticipantidAttributesPut (string conversationId, string participantId, ParticipantAttributes body = null)

Update the attributes on a conversation participant.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidAttributesPutExample
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
                apiInstance.ConversationsConversationidParticipantsParticipantidAttributesPut(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidAttributesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**ParticipantAttributes**](ParticipantAttributes.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConversationsConversationidParticipantsParticipantidConsultDelete"></a>
## string** ConversationsConversationidParticipantsParticipantidConsultDelete (string conversationId, string participantId)

Cancel the transfer



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidConsultDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | The object of the transfer

            try
            {
                // Cancel the transfer
                string result = apiInstance.ConversationsConversationidParticipantsParticipantidConsultDelete(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidConsultDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| The object of the transfer |  |
{: class="table table-striped"}

### Return type

**string**

<a name="ConversationsConversationidParticipantsParticipantidConsultPost"></a>
## [**ConsultTransferResponse**](ConsultTransferResponse.html) ConversationsConversationidParticipantsParticipantidConsultPost (string conversationId, string participantId, ConsultTransfer body = null)

Initiate and update consult transfer



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidConsultPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | The object of the transfer
            var body = new ConsultTransfer(); // ConsultTransfer | Destination address & initial speak to (optional) 

            try
            {
                // Initiate and update consult transfer
                ConsultTransferResponse result = apiInstance.ConversationsConversationidParticipantsParticipantidConsultPost(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidConsultPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| The object of the transfer |  |
| **body** | [**ConsultTransfer**](ConsultTransfer.md)| Destination address &amp; initial speak to | [optional]  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.md)

<a name="ConversationsConversationidParticipantsParticipantidConsultPut"></a>
## [**ConsultTransferResponse**](ConsultTransferResponse.html) ConversationsConversationidParticipantsParticipantidConsultPut (string conversationId, string participantId, ConsultTransferUpdate body = null)

Change who can speak



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidConsultPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | The object of the transfer
            var body = new ConsultTransferUpdate(); // ConsultTransferUpdate | new speak to (optional) 

            try
            {
                // Change who can speak
                ConsultTransferResponse result = apiInstance.ConversationsConversationidParticipantsParticipantidConsultPut(conversationId, participantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidConsultPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| The object of the transfer |  |
| **body** | [**ConsultTransferUpdate**](ConsultTransferUpdate.md)| new speak to | [optional]  |
{: class="table table-striped"}

### Return type

[**ConsultTransferResponse**](ConsultTransferResponse.md)

<a name="ConversationsConversationidParticipantsParticipantidMonitorPost"></a>
## void ConversationsConversationidParticipantsParticipantidMonitorPost (string conversationId, string participantId)

Listen in on the conversation from the point of view of a given participant.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidMonitorPostExample
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
                // Listen in on the conversation from the point of view of a given participant.
                apiInstance.ConversationsConversationidParticipantsParticipantidMonitorPost(conversationId, participantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidMonitorPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConversationsConversationidParticipantsParticipantidPut"></a>
## void ConversationsConversationidParticipantsParticipantidPut (string conversationId, string participantId, ParticipantRequest body = null)

Update a participant.

Specify the state as CONNECTED, DISCONNECTED. You can specify a wrap-up code.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var body = new ParticipantRequest(); // ParticipantRequest |  (optional) 

            try
            {
                // Update a participant.
                apiInstance.ConversationsConversationidParticipantsParticipantidPut(conversationId, participantId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **body** | [**ParticipantRequest**](ParticipantRequest.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConversationsConversationidParticipantsParticipantidReplacePost"></a>
## void ConversationsConversationidParticipantsParticipantidReplacePost (string conversationId, string participantId, string userId = null, string address = null, string username = null, string queueId = null, bool? voicemail = null)

Replace this participant with the specified user and/or address



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidReplacePostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var participantId = participantId_example;  // string | participant ID
            var userId = userId_example;  // string | The user that will replace this participant.  If address is not supplied then the user's Work address will be used.  This parameter is required when replacing a participant that has an active chat. (optional) 
            var address = address_example;  // string | The address that will be used to contact the new participant (optional) 
            var username = username_example;  // string | The username of the person that will replace this participant.  This field is only used if the userId is blank. (optional) 
            var queueId = queueId_example;  // string | The id of the queue that will replace this participant. (optional) 
            var voicemail = true;  // bool? | Indicates this participant will be replaced by the voicemail inbox of the participant. (optional) 

            try
            {
                // Replace this participant with the specified user and/or address
                apiInstance.ConversationsConversationidParticipantsParticipantidReplacePost(conversationId, participantId, userId, address, username, queueId, voicemail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **userId** | **string**| The user that will replace this participant.  If address is not supplied then the user&#39;s Work address will be used.  This parameter is required when replacing a participant that has an active chat. | [optional]  |
| **address** | **string**| The address that will be used to contact the new participant | [optional]  |
| **username** | **string**| The username of the person that will replace this participant.  This field is only used if the userId is blank. | [optional]  |
| **queueId** | **string**| The id of the queue that will replace this participant. | [optional]  |
| **voicemail** | **bool?**| Indicates this participant will be replaced by the voicemail inbox of the participant. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConversationsConversationidParticipantsParticipantidWrapupGet"></a>
## [**WrapupCode**](WrapupCode.html) ConversationsConversationidParticipantsParticipantidWrapupGet (string conversationId, string participantId, bool? provisional = null)

Get the wrap-up for this conversation participant. 



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidWrapupGetExample
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
                WrapupCode result = apiInstance.ConversationsConversationidParticipantsParticipantidWrapupGet(conversationId, participantId, provisional);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidWrapupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
| **provisional** | **bool?**| Indicates if the wrap-up code is provisional. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="ConversationsConversationidParticipantsParticipantidWrapupcodesGet"></a>
## [**WrapupCode**](WrapupCode.html) ConversationsConversationidParticipantsParticipantidWrapupcodesGet (string conversationId, string participantId)

Get list of wrapup codes for this conversation participant



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsParticipantidWrapupcodesGetExample
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
                WrapupCode result = apiInstance.ConversationsConversationidParticipantsParticipantidWrapupcodesGet(conversationId, participantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsParticipantidWrapupcodesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **participantId** | **string**| participant ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="ConversationsConversationidParticipantsPost"></a>
## [**Conversation**](Conversation.html) ConversationsConversationidParticipantsPost (string conversationId, Conversation body = null)

Add participants to a conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidParticipantsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new Conversation(); // Conversation | Conversation (optional) 

            try
            {
                // Add participants to a conversation
                Conversation result = apiInstance.ConversationsConversationidParticipantsPost(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidParticipantsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**Conversation**](Conversation.md)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.md)

<a name="ConversationsConversationidPut"></a>
## [**Conversation**](Conversation.html) ConversationsConversationidPut (string conversationId, Conversation body = null)

Update conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID
            var body = new Conversation(); // Conversation | Conversation (optional) 

            try
            {
                // Update conversation
                Conversation result = apiInstance.ConversationsConversationidPut(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
| **body** | [**Conversation**](Conversation.md)| Conversation | [optional]  |
{: class="table table-striped"}

### Return type

[**Conversation**](Conversation.md)

<a name="ConversationsConversationidTagsGet"></a>
## [**Tag**](Tag.html) ConversationsConversationidTagsGet (string conversationId)

Get possible tags for Conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidTagsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            {
                // Get possible tags for Conversation
                Tag result = apiInstance.ConversationsConversationidTagsGet(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**Tag**](Tag.md)

<a name="ConversationsConversationidWrapupcodesGet"></a>
## [**WrapupCode**](WrapupCode.html) ConversationsConversationidWrapupcodesGet (string conversationId)

Get possible wrap-up codes for Conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidWrapupcodesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var conversationId = conversationId_example;  // string | conversation ID

            try
            {
                // Get possible wrap-up codes for Conversation
                WrapupCode result = apiInstance.ConversationsConversationidWrapupcodesGet(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsConversationidWrapupcodesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversation ID |  |
{: class="table table-striped"}

### Return type

[**WrapupCode**](WrapupCode.md)

<a name="ConversationsFaxPost"></a>
## [**FaxSendResponse**](FaxSendResponse.html) ConversationsFaxPost (FaxSendRequest body = null)

Create Fax Conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsFaxPostExample
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
                FaxSendResponse result = apiInstance.ConversationsFaxPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsFaxPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**FaxSendRequest**](FaxSendRequest.md)| Fax | [optional]  |
{: class="table table-striped"}

### Return type

[**FaxSendResponse**](FaxSendResponse.md)

<a name="ConversationsGet"></a>
## [**ConversationEntityListing**](ConversationEntityListing.html) ConversationsGet (string communicationType = null)

Get conversations



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsGetExample
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
                ConversationEntityListing result = apiInstance.ConversationsGet(communicationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **communicationType** | **string**| Call or Chat communication filtering | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationEntityListing**](ConversationEntityListing.md)

<a name="ConversationsMaximumconferencepartiesGet"></a>
## [**MaxParticipants**](MaxParticipants.html) ConversationsMaximumconferencepartiesGet ()

Get the maximum number of participants that this user can have on a conference



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsMaximumconferencepartiesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();

            try
            {
                // Get the maximum number of participants that this user can have on a conference
                MaxParticipants result = apiInstance.ConversationsMaximumconferencepartiesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsMaximumconferencepartiesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**MaxParticipants**](MaxParticipants.md)

<a name="ConversationsPost"></a>
## [**ConversationResponse**](ConversationResponse.html) ConversationsPost (string call = null, string callFrom = null, string callQueueId = null, string callUserId = null, int? priority = null, string languageId = null, List<string> skillIds = null, string body = null)

Create conversation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var call = call_example;  // string | Phone number to call (optional) 
            var callFrom = callFrom_example;  // string | Queue id to place the call from (optional) 
            var callQueueId = callQueueId_example;  // string | Queue id to call (optional) 
            var callUserId = callUserId_example;  // string | User id to call (this will call the default number) (optional) 
            var priority = 56;  // int? | Priority level to use for routing when calling a queue (optional) 
            var languageId = languageId_example;  // string | Language id to use for routing when calling a queue (optional) 
            var skillIds = new List<string>(); // List<string> | Skill ids to use for routing when calling a queue (optional) 
            var body = body_example;  // string |  (optional) 

            try
            {
                // Create conversation
                ConversationResponse result = apiInstance.ConversationsPost(call, callFrom, callQueueId, callUserId, priority, languageId, skillIds, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **call** | **string**| Phone number to call | [optional]  |
| **callFrom** | **string**| Queue id to place the call from | [optional]  |
| **callQueueId** | **string**| Queue id to call | [optional]  |
| **callUserId** | **string**| User id to call (this will call the default number) | [optional]  |
| **priority** | **int?**| Priority level to use for routing when calling a queue | [optional]  |
| **languageId** | **string**| Language id to use for routing when calling a queue | [optional]  |
| **skillIds** | [**List<string>**](string.md)| Skill ids to use for routing when calling a queue | [optional]  |
| **body** | **string**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationResponse**](ConversationResponse.md)

<a name="ConversationsQueryAnchorPost"></a>
## [**ConversationQueryResponse**](ConversationQueryResponse.html) ConversationsQueryAnchorPost (string anchor, ConversationHistoricalQueryRequestBody body = null)

Query historical conversations with a date/time anchor



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsQueryAnchorPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var anchor = anchor_example;  // string | Anchor
            var body = new ConversationHistoricalQueryRequestBody(); // ConversationHistoricalQueryRequestBody |  (optional) 

            try
            {
                // Query historical conversations with a date/time anchor
                ConversationQueryResponse result = apiInstance.ConversationsQueryAnchorPost(anchor, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsQueryAnchorPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **anchor** | **string**| Anchor |  |
| **body** | [**ConversationHistoricalQueryRequestBody**](ConversationHistoricalQueryRequestBody.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationQueryResponse**](ConversationQueryResponse.md)

<a name="ConversationsQueryPost"></a>
## [**ConversationQueryResponse**](ConversationQueryResponse.html) ConversationsQueryPost (ConversationHistoricalQueryRequestBody body = null)

Query historical conversations



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsQueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConversationsApi();
            var body = new ConversationHistoricalQueryRequestBody(); // ConversationHistoricalQueryRequestBody |  (optional) 

            try
            {
                // Query historical conversations
                ConversationQueryResponse result = apiInstance.ConversationsQueryPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsQueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationHistoricalQueryRequestBody**](ConversationHistoricalQueryRequestBody.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**ConversationQueryResponse**](ConversationQueryResponse.md)

