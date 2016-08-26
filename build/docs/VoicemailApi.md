---
title: VoicemailApi
---
## ININ.PureCloudApi.Api.VoicemailApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteMessage**](VoicemailApi.html#deletemessage) | **DELETE** /api/v2/voicemail/messages/{messageId} | Delete a message. |
| [**DeleteMessages**](VoicemailApi.html#deletemessages) | **DELETE** /api/v2/voicemail/messages | Delete all voicemail messages |
| [**GetMailbox**](VoicemailApi.html#getmailbox) | **GET** /api/v2/voicemail/mailbox | Get mailbox information |
| [**GetMessage**](VoicemailApi.html#getmessage) | **GET** /api/v2/voicemail/messages/{messageId} | Get message. |
| [**GetMessageMedia**](VoicemailApi.html#getmessagemedia) | **GET** /api/v2/voicemail/messages/{messageId}/media | Get media playback URI for this message |
| [**GetMessages**](VoicemailApi.html#getmessages) | **GET** /api/v2/voicemail/messages | List voicemail messages |
| [**GetPolicy**](VoicemailApi.html#getpolicy) | **GET** /api/v2/voicemail/policy | Get a policy |
| [**GetUserpolicy**](VoicemailApi.html#getuserpolicy) | **GET** /api/v2/voicemail/userpolicies/{userId} | Get a user&#39;s voicemail policy |
| [**PatchUserpolicy**](VoicemailApi.html#patchuserpolicy) | **PATCH** /api/v2/voicemail/userpolicies/{userId} | Update a user&#39;s voicemail policy |
| [**PutMessage**](VoicemailApi.html#putmessage) | **PUT** /api/v2/voicemail/messages/{messageId} | Update a message. |
| [**PutPolicy**](VoicemailApi.html#putpolicy) | **PUT** /api/v2/voicemail/policy | Update a policy |
{: class="table table-striped"}

<a name="deletemessage"></a>

## **string** DeleteMessage (string messageId)

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
    public class DeleteMessageExample
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
                string result = apiInstance.DeleteMessage(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.DeleteMessage: " + e.Message );
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

<a name="getmailbox"></a>

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

[**VoicemailMailboxInfo**](VoicemailMailboxInfo.html)

<a name="getmessage"></a>

## [**VoicemailMessage**](VoicemailMessage.html) GetMessage (string messageId)

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
    public class GetMessageExample
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
                VoicemailMessage result = apiInstance.GetMessage(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMessage: " + e.Message );
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

[**VoicemailMessage**](VoicemailMessage.html)

<a name="getmessagemedia"></a>

## [**VoicemailMediaInfo**](VoicemailMediaInfo.html) GetMessageMedia (string messageId, string formatId = null)

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
    public class GetMessageMediaExample
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
                VoicemailMediaInfo result = apiInstance.GetMessageMedia(messageId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetMessageMedia: " + e.Message );
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

<a name="getmessages"></a>

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

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html)

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

<a name="getuserpolicy"></a>

## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) GetUserpolicy (string userId)

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
    public class GetUserpolicyExample
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
                VoicemailUserPolicy result = apiInstance.GetUserpolicy(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetUserpolicy: " + e.Message );
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

<a name="patchuserpolicy"></a>

## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) PatchUserpolicy (string userId, VoicemailUserPolicy body)

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
    public class PatchUserpolicyExample
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
                VoicemailUserPolicy result = apiInstance.PatchUserpolicy(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PatchUserpolicy: " + e.Message );
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

<a name="putmessage"></a>

## [**VoicemailMessage**](VoicemailMessage.html) PutMessage (string messageId, VoicemailMessage body)

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
    public class PutMessageExample
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
                VoicemailMessage result = apiInstance.PutMessage(messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.PutMessage: " + e.Message );
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

