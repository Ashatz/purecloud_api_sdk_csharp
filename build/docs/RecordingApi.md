---
title: RecordingApi
---
## ININ.PureCloudApi.Api.RecordingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId**](RecordingApi.html#deleteconversationidrecordingsrecordingidannotationsannotationid) | Delete annotation |
| [**DeleteMediaretentionpolicies**](RecordingApi.html#deletemediaretentionpolicies) | Delete media retention policies |
| [**DeleteMediaretentionpoliciesPolicyId**](RecordingApi.html#deletemediaretentionpoliciespolicyid) | Delete a media retention policy |
| [**DeleteOrphanId**](RecordingApi.html#deleteorphanid) | Deletes a single orphan recording |
| [**GetConversationIdRecordings**](RecordingApi.html#getconversationidrecordings) | Get all of a Conversation&#39;s Recordings. |
| [**GetConversationIdRecordingsRecordingId**](RecordingApi.html#getconversationidrecordingsrecordingid) | Gets a specific recording. |
| [**GetConversationIdRecordingsRecordingIdAnnotations**](RecordingApi.html#getconversationidrecordingsrecordingidannotations) | Get annotations for recording |
| [**GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId**](RecordingApi.html#getconversationidrecordingsrecordingidannotationsannotationid) | Get annotation |
| [**GetLocalkeysSettings**](RecordingApi.html#getlocalkeyssettings) | gets a list local key settings data |
| [**GetLocalkeysSettingsSettingsId**](RecordingApi.html#getlocalkeyssettingssettingsid) | Get the local encryption settings |
| [**GetMediaretentionpolicies**](RecordingApi.html#getmediaretentionpolicies) | Gets media retention policy list with query options to filter on name and enabled. |
| [**GetMediaretentionpoliciesPolicyId**](RecordingApi.html#getmediaretentionpoliciespolicyid) | Get a media retention policy |
| [**GetOrphanId**](RecordingApi.html#getorphanid) | Gets a single orphan recording |
| [**GetOrphanIdMedia**](RecordingApi.html#getorphanidmedia) | Gets the media of a single orphan recording |
| [**GetOrphanrecordings**](RecordingApi.html#getorphanrecordings) | Gets all orphan recordings |
| [**GetRecordingkeys**](RecordingApi.html#getrecordingkeys) | Get encryption key list |
| [**GetRecordingkeysRotationschedule**](RecordingApi.html#getrecordingkeysrotationschedule) | Get key rotation schedule |
| [**GetSettings**](RecordingApi.html#getsettings) | Get the Recording Settings for the Organization |
| [**GetsScreensessions**](RecordingApi.html#getsscreensessions) | Retrieves a paged listing of screen recording sessions |
| [**PatchMediaretentionpoliciesPolicyId**](RecordingApi.html#patchmediaretentionpoliciespolicyid) | Patch a media retention policy |
| [**PatchsScreensessionsRecordingsessionId**](RecordingApi.html#patchsscreensessionsrecordingsessionid) | Update a screen recording session |
| [**PostConversationIdRecordingsRecordingIdAnnotations**](RecordingApi.html#postconversationidrecordingsrecordingidannotations) | Create annotation |
| [**PostLocalkeys**](RecordingApi.html#postlocalkeys) | create a local recording key |
| [**PostLocalkeysSettings**](RecordingApi.html#postlocalkeyssettings) | create settings for local key creation |
| [**PostMediaretentionpolicies**](RecordingApi.html#postmediaretentionpolicies) | Create media retention policy |
| [**PostRecordingkeys**](RecordingApi.html#postrecordingkeys) | Create encryption key |
| [**PutConversationIdRecordingsRecordingId**](RecordingApi.html#putconversationidrecordingsrecordingid) | Updates the retention records on a recording. |
| [**PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId**](RecordingApi.html#putconversationidrecordingsrecordingidannotationsannotationid) | Update annotation |
| [**PutLocalkeysSettingsSettingsId**](RecordingApi.html#putlocalkeyssettingssettingsid) | Update the local encryption settings |
| [**PutMediaretentionpoliciesPolicyId**](RecordingApi.html#putmediaretentionpoliciespolicyid) | Update a media retention policy |
| [**PutOrphanId**](RecordingApi.html#putorphanid) | Updates an orphan recording to a regular recording with retention values |
| [**PutRecordingkeysRotationschedule**](RecordingApi.html#putrecordingkeysrotationschedule) | Update key rotation schedule |
| [**PutSettings**](RecordingApi.html#putsettings) | Update the Recording Settings for the Organization |
{: class="table table-striped"}

<a name="deleteconversationidrecordingsrecordingidannotationsannotationid"></a>

## void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId)

Delete annotation



Wraps DELETE /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID

            try
            {
                // Delete annotation
                apiInstance.DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletemediaretentionpolicies"></a>

## **string** DeleteMediaretentionpolicies (string ids)

Delete media retention policies

Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.

Wraps DELETE /api/v2/recording/mediaretentionpolicies 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteMediaretentionpoliciesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var ids = ids_example;  // string | 

            try
            {
                // Delete media retention policies
                string result = apiInstance.DeleteMediaretentionpolicies(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ids** | **string**|  |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deletemediaretentionpoliciespolicyid"></a>

## **string** DeleteMediaretentionpoliciesPolicyId (string policyId)

Delete a media retention policy



Wraps DELETE /api/v2/recording/mediaretentionpolicies/{policyId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteMediaretentionpoliciesPolicyIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            {
                // Delete a media retention policy
                string result = apiInstance.DeleteMediaretentionpoliciesPolicyId(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteMediaretentionpoliciesPolicyId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="deleteorphanid"></a>

## [**OrphanRecording**](OrphanRecording.html) DeleteOrphanId (string orphanId)

Deletes a single orphan recording



Wraps DELETE /api/v2/orphanrecordings/{orphanId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOrphanIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID

            try
            {
                // Deletes a single orphan recording
                OrphanRecording result = apiInstance.DeleteOrphanId(orphanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.DeleteOrphanId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
{: class="table table-striped"}

### Return type

[**OrphanRecording**](OrphanRecording.html)

<a name="getconversationidrecordings"></a>

## [**List&lt;Recording&gt;**](Recording.html) GetConversationIdRecordings (string conversationId, int? maxWaitMs = null, string formatId = null)

Get all of a Conversation's Recordings.



Wraps GET /api/v2/conversations/{conversationId}/recordings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdRecordingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var maxWaitMs = 56;  // int? | The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional)  (default to 5000)
            var formatId = formatId_example;  // string | The desired media format (optional)  (default to WEBM)

            try
            {
                // Get all of a Conversation's Recordings.
                List&lt;Recording&gt; result = apiInstance.GetConversationIdRecordings(conversationId, maxWaitMs, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationIdRecordings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **maxWaitMs** | **int?**| The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. | [optional] [default to 5000] |
| **formatId** | **string**| The desired media format | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**List<Recording>**](Recording.html)

<a name="getconversationidrecordingsrecordingid"></a>

## [**Recording**](Recording.html) GetConversationIdRecordingsRecordingId (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null)

Gets a specific recording.



Wraps GET /api/v2/conversations/{conversationId}/recordings/{recordingId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdRecordingsRecordingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)
            var download = true;  // bool? | requesting a download format of the recording (optional)  (default to false)
            var fileName = fileName_example;  // string | the name of the downloaded fileName (optional) 

            try
            {
                // Gets a specific recording.
                Recording result = apiInstance.GetConversationIdRecordingsRecordingId(conversationId, recordingId, formatId, download, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationIdRecordingsRecordingId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM] |
| **download** | **bool?**| requesting a download format of the recording | [optional] [default to false] |
| **fileName** | **string**| the name of the downloaded fileName | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="getconversationidrecordingsrecordingidannotations"></a>

## [**List&lt;Annotation&gt;**](Annotation.html) GetConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId)

Get annotations for recording



Wraps GET /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdRecordingsRecordingIdAnnotationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID

            try
            {
                // Get annotations for recording
                List&lt;Annotation&gt; result = apiInstance.GetConversationIdRecordingsRecordingIdAnnotations(conversationId, recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationIdRecordingsRecordingIdAnnotations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
{: class="table table-striped"}

### Return type

[**List<Annotation>**](Annotation.html)

<a name="getconversationidrecordingsrecordingidannotationsannotationid"></a>

## [**Annotation**](Annotation.html) GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId)

Get annotation



Wraps GET /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID

            try
            {
                // Get annotation
                Annotation result = apiInstance.GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="getlocalkeyssettings"></a>

## [**LocalEncryptionConfigurationListing**](LocalEncryptionConfigurationListing.html) GetLocalkeysSettings ()

gets a list local key settings data



Wraps GET /api/v2/recording/localkeys/settings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLocalkeysSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();

            try
            {
                // gets a list local key settings data
                LocalEncryptionConfigurationListing result = apiInstance.GetLocalkeysSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetLocalkeysSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**LocalEncryptionConfigurationListing**](LocalEncryptionConfigurationListing.html)

<a name="getlocalkeyssettingssettingsid"></a>

## [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html) GetLocalkeysSettingsSettingsId (string settingsId)

Get the local encryption settings



Wraps GET /api/v2/recording/localkeys/settings/{settingsId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetLocalkeysSettingsSettingsIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var settingsId = settingsId_example;  // string | Settings Id

            try
            {
                // Get the local encryption settings
                LocalEncryptionConfiguration result = apiInstance.GetLocalkeysSettingsSettingsId(settingsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetLocalkeysSettingsSettingsId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings Id |  |
{: class="table table-striped"}

### Return type

[**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html)

<a name="getmediaretentionpolicies"></a>

## [**PolicyEntityListing**](PolicyEntityListing.html) GetMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)

Gets media retention policy list with query options to filter on name and enabled.

for a less verbose response, add summary=true to this endpoint

Wraps GET /api/v2/recording/mediaretentionpolicies 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMediaretentionpoliciesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var name = name_example;  // string | the policy name - used for filtering results in searches. (optional) 
            var enabled = true;  // bool? | checks to see if policy is enabled - use enabled = true or enabled = false (optional) 
            var summary = true;  // bool? | provides a less verbose response of policy lists. (optional)  (default to false)
            var hasErrors = true;  // bool? | provides a way to fetch all policies with errors or policies that do not have errors (optional) 

            try
            {
                // Gets media retention policy list with query options to filter on name and enabled.
                PolicyEntityListing result = apiInstance.GetMediaretentionpolicies(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **name** | **string**| the policy name - used for filtering results in searches. | [optional]  |
| **enabled** | **bool?**| checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false | [optional]  |
| **summary** | **bool?**| provides a less verbose response of policy lists. | [optional] [default to false] |
| **hasErrors** | **bool?**| provides a way to fetch all policies with errors or policies that do not have errors | [optional]  |
{: class="table table-striped"}

### Return type

[**PolicyEntityListing**](PolicyEntityListing.html)

<a name="getmediaretentionpoliciespolicyid"></a>

## [**Policy**](Policy.html) GetMediaretentionpoliciesPolicyId (string policyId)

Get a media retention policy



Wraps GET /api/v2/recording/mediaretentionpolicies/{policyId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetMediaretentionpoliciesPolicyIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID

            try
            {
                // Get a media retention policy
                Policy result = apiInstance.GetMediaretentionpoliciesPolicyId(policyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetMediaretentionpoliciesPolicyId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="getorphanid"></a>

## [**OrphanRecording**](OrphanRecording.html) GetOrphanId (string orphanId)

Gets a single orphan recording



Wraps GET /api/v2/orphanrecordings/{orphanId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrphanIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID

            try
            {
                // Gets a single orphan recording
                OrphanRecording result = apiInstance.GetOrphanId(orphanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetOrphanId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
{: class="table table-striped"}

### Return type

[**OrphanRecording**](OrphanRecording.html)

<a name="getorphanidmedia"></a>

## [**Recording**](Recording.html) GetOrphanIdMedia (string orphanId, string formatId = null, bool? download = null, string fileName = null)

Gets the media of a single orphan recording

A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.

Wraps GET /api/v2/orphanrecordings/{orphanId}/media 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrphanIdMediaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WEBM)
            var download = true;  // bool? | requesting a download format of the recording (optional)  (default to false)
            var fileName = fileName_example;  // string | the name of the downloaded fileName (optional) 

            try
            {
                // Gets the media of a single orphan recording
                Recording result = apiInstance.GetOrphanIdMedia(orphanId, formatId, download, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetOrphanIdMedia: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WEBM] |
| **download** | **bool?**| requesting a download format of the recording | [optional] [default to false] |
| **fileName** | **string**| the name of the downloaded fileName | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="getorphanrecordings"></a>

## [**OrphanRecordingListing**](OrphanRecordingListing.html) GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null)

Gets all orphan recordings



Wraps GET /api/v2/orphanrecordings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOrphanrecordingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<Object>(); // List<Object> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var hasConversation = true;  // bool? | Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional)  (default to false)

            try
            {
                // Gets all orphan recordings
                OrphanRecordingListing result = apiInstance.GetOrphanrecordings(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, hasConversation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetOrphanrecordings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<Object>**](Object.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **hasConversation** | **bool?**| Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**OrphanRecordingListing**](OrphanRecordingListing.html)

<a name="getrecordingkeys"></a>

## [**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.html) GetRecordingkeys (int? pageSize = null, int? pageNumber = null)

Get encryption key list



Wraps GET /api/v2/recording/recordingkeys 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRecordingkeysExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get encryption key list
                EncryptionKeyEntityListing result = apiInstance.GetRecordingkeys(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingkeys: " + e.Message );
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

[**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.html)

<a name="getrecordingkeysrotationschedule"></a>

## [**KeyRotationSchedule**](KeyRotationSchedule.html) GetRecordingkeysRotationschedule ()

Get key rotation schedule



Wraps GET /api/v2/recording/recordingkeys/rotationschedule 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRecordingkeysRotationscheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();

            try
            {
                // Get key rotation schedule
                KeyRotationSchedule result = apiInstance.GetRecordingkeysRotationschedule();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetRecordingkeysRotationschedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.html)

<a name="getsettings"></a>

## [**RecordingSettings**](RecordingSettings.html) GetSettings (bool? createDefault = null)

Get the Recording Settings for the Organization



Wraps GET /api/v2/recording/settings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var createDefault = true;  // bool? | If no settings are found, a new one is created with default values (optional)  (default to false)

            try
            {
                // Get the Recording Settings for the Organization
                RecordingSettings result = apiInstance.GetSettings(createDefault);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **createDefault** | **bool?**| If no settings are found, a new one is created with default values | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**RecordingSettings**](RecordingSettings.html)

<a name="getsscreensessions"></a>

## [**ScreenRecordingSessionListing**](ScreenRecordingSessionListing.html) GetsScreensessions (int? pageSize = null, int? pageNumber = null)

Retrieves a paged listing of screen recording sessions



Wraps GET /api/v2/recordings/screensessions 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetsScreensessionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Retrieves a paged listing of screen recording sessions
                ScreenRecordingSessionListing result = apiInstance.GetsScreensessions(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.GetsScreensessions: " + e.Message );
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

[**ScreenRecordingSessionListing**](ScreenRecordingSessionListing.html)

<a name="patchmediaretentionpoliciespolicyid"></a>

## [**Policy**](Policy.html) PatchMediaretentionpoliciesPolicyId (string policyId, Policy body)

Patch a media retention policy



Wraps PATCH /api/v2/recording/mediaretentionpolicies/{policyId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchMediaretentionpoliciesPolicyIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new Policy(); // Policy | Policy

            try
            {
                // Patch a media retention policy
                Policy result = apiInstance.PatchMediaretentionpoliciesPolicyId(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PatchMediaretentionpoliciesPolicyId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**Policy**](Policy.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="patchsscreensessionsrecordingsessionid"></a>

## void PatchsScreensessionsRecordingsessionId (string recordingSessionId, ScreenRecordingSessionRequest body = null)

Update a screen recording session



Wraps PATCH /api/v2/recordings/screensessions/{recordingSessionId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PatchsScreensessionsRecordingsessionIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var recordingSessionId = recordingSessionId_example;  // string | Screen recording session ID
            var body = new ScreenRecordingSessionRequest(); // ScreenRecordingSessionRequest |  (optional) 

            try
            {
                // Update a screen recording session
                apiInstance.PatchsScreensessionsRecordingsessionId(recordingSessionId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PatchsScreensessionsRecordingsessionId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **recordingSessionId** | **string**| Screen recording session ID |  |
| **body** | [**ScreenRecordingSessionRequest**](ScreenRecordingSessionRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="postconversationidrecordingsrecordingidannotations"></a>

## [**Annotation**](Annotation.html) PostConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId, Annotation body)

Create annotation



Wraps POST /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationIdRecordingsRecordingIdAnnotationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var body = new Annotation(); // Annotation | annotation

            try
            {
                // Create annotation
                Annotation result = apiInstance.PostConversationIdRecordingsRecordingIdAnnotations(conversationId, recordingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostConversationIdRecordingsRecordingIdAnnotations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **body** | [**Annotation**](Annotation.html)| annotation |  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="postlocalkeys"></a>

## [**EncryptionKey**](EncryptionKey.html) PostLocalkeys (LocalEncryptionKeyRequest body)

create a local recording key



Wraps POST /api/v2/recording/localkeys 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLocalkeysExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var body = new LocalEncryptionKeyRequest(); // LocalEncryptionKeyRequest | Local Encryption body

            try
            {
                // create a local recording key
                EncryptionKey result = apiInstance.PostLocalkeys(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostLocalkeys: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocalEncryptionKeyRequest**](LocalEncryptionKeyRequest.html)| Local Encryption body |  |
{: class="table table-striped"}

### Return type

[**EncryptionKey**](EncryptionKey.html)

<a name="postlocalkeyssettings"></a>

## [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html) PostLocalkeysSettings (LocalEncryptionConfiguration body)

create settings for local key creation



Wraps POST /api/v2/recording/localkeys/settings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostLocalkeysSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var body = new LocalEncryptionConfiguration(); // LocalEncryptionConfiguration | Local Encryption Configuration

            try
            {
                // create settings for local key creation
                LocalEncryptionConfiguration result = apiInstance.PostLocalkeysSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostLocalkeysSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html)| Local Encryption Configuration |  |
{: class="table table-striped"}

### Return type

[**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html)

<a name="postmediaretentionpolicies"></a>

## [**Policy**](Policy.html) PostMediaretentionpolicies (PolicyCreate body)

Create media retention policy



Wraps POST /api/v2/recording/mediaretentionpolicies 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostMediaretentionpoliciesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var body = new PolicyCreate(); // PolicyCreate | Policy

            try
            {
                // Create media retention policy
                Policy result = apiInstance.PostMediaretentionpolicies(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostMediaretentionpolicies: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PolicyCreate**](PolicyCreate.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="postrecordingkeys"></a>

## [**EncryptionKey**](EncryptionKey.html) PostRecordingkeys ()

Create encryption key



Wraps POST /api/v2/recording/recordingkeys 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRecordingkeysExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();

            try
            {
                // Create encryption key
                EncryptionKey result = apiInstance.PostRecordingkeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PostRecordingkeys: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EncryptionKey**](EncryptionKey.html)

<a name="putconversationidrecordingsrecordingid"></a>

## [**Recording**](Recording.html) PutConversationIdRecordingsRecordingId (string conversationId, string recordingId, Recording body)

Updates the retention records on a recording.

Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 

Wraps PUT /api/v2/conversations/{conversationId}/recordings/{recordingId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutConversationIdRecordingsRecordingIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var body = new Recording(); // Recording | recording

            try
            {
                // Updates the retention records on a recording.
                Recording result = apiInstance.PutConversationIdRecordingsRecordingId(conversationId, recordingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutConversationIdRecordingsRecordingId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **body** | [**Recording**](Recording.html)| recording |  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="putconversationidrecordingsrecordingidannotationsannotationid"></a>

## [**Annotation**](Annotation.html) PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body)

Update annotation



Wraps PUT /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID
            var body = new Annotation(); // Annotation | annotation

            try
            {
                // Update annotation
                Annotation result = apiInstance.PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
| **body** | [**Annotation**](Annotation.html)| annotation |  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="putlocalkeyssettingssettingsid"></a>

## [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html) PutLocalkeysSettingsSettingsId (string settingsId, LocalEncryptionConfiguration body)

Update the local encryption settings



Wraps PUT /api/v2/recording/localkeys/settings/{settingsId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutLocalkeysSettingsSettingsIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var settingsId = settingsId_example;  // string | Settings Id
            var body = new LocalEncryptionConfiguration(); // LocalEncryptionConfiguration | Local Encryption metadata

            try
            {
                // Update the local encryption settings
                LocalEncryptionConfiguration result = apiInstance.PutLocalkeysSettingsSettingsId(settingsId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutLocalkeysSettingsSettingsId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **settingsId** | **string**| Settings Id |  |
| **body** | [**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html)| Local Encryption metadata |  |
{: class="table table-striped"}

### Return type

[**LocalEncryptionConfiguration**](LocalEncryptionConfiguration.html)

<a name="putmediaretentionpoliciespolicyid"></a>

## [**Policy**](Policy.html) PutMediaretentionpoliciesPolicyId (string policyId, Policy body)

Update a media retention policy



Wraps PUT /api/v2/recording/mediaretentionpolicies/{policyId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutMediaretentionpoliciesPolicyIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var policyId = policyId_example;  // string | Policy ID
            var body = new Policy(); // Policy | Policy

            try
            {
                // Update a media retention policy
                Policy result = apiInstance.PutMediaretentionpoliciesPolicyId(policyId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutMediaretentionpoliciesPolicyId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **policyId** | **string**| Policy ID |  |
| **body** | [**Policy**](Policy.html)| Policy |  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="putorphanid"></a>

## [**Recording**](Recording.html) PutOrphanId (string orphanId, OrphanUpdateRequest body = null)

Updates an orphan recording to a regular recording with retention values

If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.

Wraps PUT /api/v2/orphanrecordings/{orphanId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOrphanIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var orphanId = orphanId_example;  // string | Orphan ID
            var body = new OrphanUpdateRequest(); // OrphanUpdateRequest |  (optional) 

            try
            {
                // Updates an orphan recording to a regular recording with retention values
                Recording result = apiInstance.PutOrphanId(orphanId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutOrphanId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **orphanId** | **string**| Orphan ID |  |
| **body** | [**OrphanUpdateRequest**](OrphanUpdateRequest.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Recording**](Recording.html)

<a name="putrecordingkeysrotationschedule"></a>

## [**KeyRotationSchedule**](KeyRotationSchedule.html) PutRecordingkeysRotationschedule (KeyRotationSchedule body)

Update key rotation schedule



Wraps PUT /api/v2/recording/recordingkeys/rotationschedule 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRecordingkeysRotationscheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var body = new KeyRotationSchedule(); // KeyRotationSchedule | KeyRotationSchedule

            try
            {
                // Update key rotation schedule
                KeyRotationSchedule result = apiInstance.PutRecordingkeysRotationschedule(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutRecordingkeysRotationschedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KeyRotationSchedule**](KeyRotationSchedule.html)| KeyRotationSchedule |  |
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.html)

<a name="putsettings"></a>

## [**RecordingSettings**](RecordingSettings.html) PutSettings (RecordingSettings body)

Update the Recording Settings for the Organization



Wraps PUT /api/v2/recording/settings 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutSettingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new RecordingApi();
            var body = new RecordingSettings(); // RecordingSettings | Recording settings

            try
            {
                // Update the Recording Settings for the Organization
                RecordingSettings result = apiInstance.PutSettings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecordingApi.PutSettings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RecordingSettings**](RecordingSettings.html)| Recording settings |  |
{: class="table table-striped"}

### Return type

[**RecordingSettings**](RecordingSettings.html)

