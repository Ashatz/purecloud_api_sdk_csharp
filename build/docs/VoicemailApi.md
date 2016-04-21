# ININ.PureCloudApi.Api.VoicemailApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMessages**](VoicemailApi.md#deletemessages) | **DELETE** /api/v2/voicemail/messages | Delete all voicemail messages |
| [**DeleteMessagesMessageId**](VoicemailApi.md#deletemessagesmessageid) | **DELETE** /api/v2/voicemail/messages/{messageId} | Delete a message. |
| [**GetMailbox**](VoicemailApi.md#getmailbox) | **GET** /api/v2/voicemail/mailbox | Get mailbox information |
| [**GetMessages**](VoicemailApi.md#getmessages) | **GET** /api/v2/voicemail/messages | List voicemail messages |
| [**GetMessagesMessageId**](VoicemailApi.md#getmessagesmessageid) | **GET** /api/v2/voicemail/messages/{messageId} | Get message. |
| [**GetMessagesMessageIdMedia**](VoicemailApi.md#getmessagesmessageidmedia) | **GET** /api/v2/voicemail/messages/{messageId}/media | Get media playback URI for this message |
| [**GetPolicy**](VoicemailApi.md#getpolicy) | **GET** /api/v2/voicemail/policy | Get a policy |
| [**GetUserpoliciesUserId**](VoicemailApi.md#getuserpoliciesuserid) | **GET** /api/v2/voicemail/userpolicies/{userId} | Get a user&#39;s voicemail policy |
| [**PatchUserpoliciesUserId**](VoicemailApi.md#patchuserpoliciesuserid) | **PATCH** /api/v2/voicemail/userpolicies/{userId} | Update a user&#39;s voicemail policy |
| [**PutMessagesMessageId**](VoicemailApi.md#putmessagesmessageid) | **PUT** /api/v2/voicemail/messages/{messageId} | Update a message. |
| [**PutPolicy**](VoicemailApi.md#putpolicy) | **PUT** /api/v2/voicemail/policy | Update a policy |
{: class="table table-striped"}

<a name="DeleteMessages"></a>
## string** DeleteMessages ()

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

<a name="DeleteMessagesMessageId"></a>
## string** DeleteMessagesMessageId (string messageId)

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

<a name="GetMailbox"></a>
## [**VoicemailMailboxInfo**](VoicemailMailboxInfo.html) GetMailbox ()

Get mailbox information



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
                // Get mailbox information
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

[**VoicemailMailboxInfo**](VoicemailMailboxInfo.md)

<a name="GetMessages"></a>
## [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html) GetMessages ()

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

            try
            {
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.GetMessages();
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
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.md)

<a name="GetMessagesMessageId"></a>
## [**VoicemailMessage**](VoicemailMessage.html) GetMessagesMessageId (string messageId)

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

            try
            {
                // Get message.
                VoicemailMessage result = apiInstance.GetMessagesMessageId(messageId);
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
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.md)

<a name="GetMessagesMessageIdMedia"></a>
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
            var formatId = formatId_example;  // string | The desired media format (WEBM, WAV) (optional)  (default to WEBM)

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
| **formatId** | **string**| The desired media format (WEBM, WAV) | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**VoicemailMediaInfo**](VoicemailMediaInfo.md)

<a name="GetPolicy"></a>
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

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.md)

<a name="GetUserpoliciesUserId"></a>
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

[**VoicemailUserPolicy**](VoicemailUserPolicy.md)

<a name="PatchUserpoliciesUserId"></a>
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
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy.md)| The user&#39;s voicemail policy |  |
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.md)

<a name="PutMessagesMessageId"></a>
## [**VoicemailMessage**](VoicemailMessage.html) PutMessagesMessageId (string messageId, VoicemailMessage body = null)

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
            var body = new VoicemailMessage(); // VoicemailMessage | VoicemailMessage (optional) 

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
| **body** | [**VoicemailMessage**](VoicemailMessage.md)| VoicemailMessage | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.md)

<a name="PutPolicy"></a>
## [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html) PutPolicy (VoicemailOrganizationPolicy body = null)

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
            var body = new VoicemailOrganizationPolicy(); // VoicemailOrganizationPolicy | Policy (optional) 

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
| **body** | [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.md)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.md)

