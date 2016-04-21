# ININ.PureCloudApi.Api.VoicemailApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ConfigurationUservoicemailpoliciesUseridGet**](VoicemailApi.md#configurationuservoicemailpoliciesuseridget) | **GET** /api/v1/configuration/uservoicemailpolicies/{userId} | Get a user&#39;s voicemail policy |
| [**ConfigurationUservoicemailpoliciesUseridPatch**](VoicemailApi.md#configurationuservoicemailpoliciesuseridpatch) | **PATCH** /api/v1/configuration/uservoicemailpolicies/{userId} | Update a user&#39;s voicemail policy |
| [**ConfigurationVoicemailpolicyGet**](VoicemailApi.md#configurationvoicemailpolicyget) | **GET** /api/v1/configuration/voicemailpolicy | Get a policy |
| [**ConfigurationVoicemailpolicyPut**](VoicemailApi.md#configurationvoicemailpolicyput) | **PUT** /api/v1/configuration/voicemailpolicy | Update a policy |
| [**VoicemailMailboxGet**](VoicemailApi.md#voicemailmailboxget) | **GET** /api/v1/voicemail/mailbox | Get mailbox information |
| [**VoicemailMessagesDelete**](VoicemailApi.md#voicemailmessagesdelete) | **DELETE** /api/v1/voicemail/messages | Delete all voicemail messages |
| [**VoicemailMessagesGet**](VoicemailApi.md#voicemailmessagesget) | **GET** /api/v1/voicemail/messages | List voicemail messages |
| [**VoicemailMessagesMessageidDelete**](VoicemailApi.md#voicemailmessagesmessageiddelete) | **DELETE** /api/v1/voicemail/messages/{messageId} | Delete a message. |
| [**VoicemailMessagesMessageidGet**](VoicemailApi.md#voicemailmessagesmessageidget) | **GET** /api/v1/voicemail/messages/{messageId} | Get message. |
| [**VoicemailMessagesMessageidMediaGet**](VoicemailApi.md#voicemailmessagesmessageidmediaget) | **GET** /api/v1/voicemail/messages/{messageId}/media | Get media playback URI for this message |
| [**VoicemailMessagesMessageidPut**](VoicemailApi.md#voicemailmessagesmessageidput) | **PUT** /api/v1/voicemail/messages/{messageId} | Update a message. |
{: class="table table-striped"}

<a name="ConfigurationUservoicemailpoliciesUseridGet"></a>
## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) ConfigurationUservoicemailpoliciesUseridGet (string userId)

Get a user's voicemail policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationUservoicemailpoliciesUseridGetExample
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
                VoicemailUserPolicy result = apiInstance.ConfigurationUservoicemailpoliciesUseridGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.ConfigurationUservoicemailpoliciesUseridGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.md)

<a name="ConfigurationUservoicemailpoliciesUseridPatch"></a>
## [**VoicemailUserPolicy**](VoicemailUserPolicy.html) ConfigurationUservoicemailpoliciesUseridPatch (string userId, VoicemailUserPolicy body)

Update a user's voicemail policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationUservoicemailpoliciesUseridPatchExample
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
                VoicemailUserPolicy result = apiInstance.ConfigurationUservoicemailpoliciesUseridPatch(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.ConfigurationUservoicemailpoliciesUseridPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**VoicemailUserPolicy**](VoicemailUserPolicy.md)| The user&#39;s voicemail policy |  |
{: class="table table-striped"}

### Return type

[**VoicemailUserPolicy**](VoicemailUserPolicy.md)

<a name="ConfigurationVoicemailpolicyGet"></a>
## [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html) ConfigurationVoicemailpolicyGet ()

Get a policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationVoicemailpolicyGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Get a policy
                VoicemailOrganizationPolicy result = apiInstance.ConfigurationVoicemailpolicyGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.ConfigurationVoicemailpolicyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.md)

<a name="ConfigurationVoicemailpolicyPut"></a>
## [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.html) ConfigurationVoicemailpolicyPut (VoicemailOrganizationPolicy body = null)

Update a policy



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConfigurationVoicemailpolicyPutExample
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
                VoicemailOrganizationPolicy result = apiInstance.ConfigurationVoicemailpolicyPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.ConfigurationVoicemailpolicyPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.md)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailOrganizationPolicy**](VoicemailOrganizationPolicy.md)

<a name="VoicemailMailboxGet"></a>
## [**VoicemailMailboxInfo**](VoicemailMailboxInfo.html) VoicemailMailboxGet ()

Get mailbox information



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMailboxGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Get mailbox information
                VoicemailMailboxInfo result = apiInstance.VoicemailMailboxGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMailboxGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailMailboxInfo**](VoicemailMailboxInfo.md)

<a name="VoicemailMessagesDelete"></a>
## string** VoicemailMessagesDelete ()

Delete all voicemail messages



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMessagesDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // Delete all voicemail messages
                string result = apiInstance.VoicemailMessagesDelete();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMessagesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**string**

<a name="VoicemailMessagesGet"></a>
## [**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.html) VoicemailMessagesGet ()

List voicemail messages



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMessagesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();

            try
            {
                // List voicemail messages
                VoicemailMessageEntityListing result = apiInstance.VoicemailMessagesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMessagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**VoicemailMessageEntityListing**](VoicemailMessageEntityListing.md)

<a name="VoicemailMessagesMessageidDelete"></a>
## string** VoicemailMessagesMessageidDelete (string messageId)

Delete a message.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMessagesMessageidDeleteExample
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
                string result = apiInstance.VoicemailMessagesMessageidDelete(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMessagesMessageidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="VoicemailMessagesMessageidGet"></a>
## [**VoicemailMessage**](VoicemailMessage.html) VoicemailMessagesMessageidGet (string messageId)

Get message.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMessagesMessageidGetExample
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
                VoicemailMessage result = apiInstance.VoicemailMessagesMessageidGet(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMessagesMessageidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.md)

<a name="VoicemailMessagesMessageidMediaGet"></a>
## [**VoicemailMediaInfo**](VoicemailMediaInfo.html) VoicemailMessagesMessageidMediaGet (string messageId, string formatId = null)

Get media playback URI for this message



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMessagesMessageidMediaGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new VoicemailApi();
            var messageId = messageId_example;  // string | Message ID
            var formatId = formatId_example;  // string | The desired format (WEBM, WAV, etc.) (optional)  (default to WEBM)

            try
            {
                // Get media playback URI for this message
                VoicemailMediaInfo result = apiInstance.VoicemailMessagesMessageidMediaGet(messageId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMessagesMessageidMediaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **formatId** | **string**| The desired format (WEBM, WAV, etc.) | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**VoicemailMediaInfo**](VoicemailMediaInfo.md)

<a name="VoicemailMessagesMessageidPut"></a>
## [**VoicemailMessage**](VoicemailMessage.html) VoicemailMessagesMessageidPut (string messageId, VoicemailMessage body = null)

Update a message.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class VoicemailMessagesMessageidPutExample
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
                VoicemailMessage result = apiInstance.VoicemailMessagesMessageidPut(messageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicemailApi.VoicemailMessagesMessageidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **messageId** | **string**| Message ID |  |
| **body** | [**VoicemailMessage**](VoicemailMessage.md)| VoicemailMessage | [optional]  |
{: class="table table-striped"}

### Return type

[**VoicemailMessage**](VoicemailMessage.md)

