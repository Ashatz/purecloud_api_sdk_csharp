---
title: RecordingApi
---
## ININ.PureCloudApi.Api.RecordingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId**](RecordingApi.html#deleteconversationidrecordingsrecordingidannotationsannotationid) | **DELETE** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Delete annotation |
| [**DeleteMediaretentionpolicies**](RecordingApi.html#deletemediaretentionpolicies) | **DELETE** /api/v2/recording/mediaretentionpolicies | Delete media retention policies |
| [**DeleteMediaretentionpoliciesPolicyId**](RecordingApi.html#deletemediaretentionpoliciespolicyid) | **DELETE** /api/v2/recording/mediaretentionpolicies/{policyId} | Delete a media retention policy |
| [**DeleteOrphanId**](RecordingApi.html#deleteorphanid) | **DELETE** /api/v2/orphanrecordings/{orphanId} |  deletes a single orphan recording |
| [**GetConversationIdRecordings**](RecordingApi.html#getconversationidrecordings) | **GET** /api/v2/conversations/{conversationId}/recordings | Get all of a Conversation&#39;s Recordings. |
| [**GetConversationIdRecordingsRecordingId**](RecordingApi.html#getconversationidrecordingsrecordingid) | **GET** /api/v2/conversations/{conversationId}/recordings/{recordingId} | Gets a specific recording. |
| [**GetConversationIdRecordingsRecordingIdAnnotations**](RecordingApi.html#getconversationidrecordingsrecordingidannotations) | **GET** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations | Get annotations for recording |
| [**GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId**](RecordingApi.html#getconversationidrecordingsrecordingidannotationsannotationid) | **GET** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Get annotation |
| [**GetMediaretentionpolicies**](RecordingApi.html#getmediaretentionpolicies) | **GET** /api/v2/recording/mediaretentionpolicies | Gets media retention policy list with query options to filter on name and enabled. |
| [**GetMediaretentionpoliciesPolicyId**](RecordingApi.html#getmediaretentionpoliciespolicyid) | **GET** /api/v2/recording/mediaretentionpolicies/{policyId} | Get a media retention policy |
| [**GetOrphanId**](RecordingApi.html#getorphanid) | **GET** /api/v2/orphanrecordings/{orphanId} | Gets a single orphan recording |
| [**GetOrphanrecordings**](RecordingApi.html#getorphanrecordings) | **GET** /api/v2/orphanrecordings | Gets all orphan recordings |
| [**GetSettings**](RecordingApi.html#getsettings) | **GET** /api/v2/recording/settings | Get the Recording Settings for the Organization |
| [**PatchMediaretentionpoliciesPolicyId**](RecordingApi.html#patchmediaretentionpoliciespolicyid) | **PATCH** /api/v2/recording/mediaretentionpolicies/{policyId} | Patch a media retention policy |
| [**PostConversationIdRecordingsRecordingIdAnnotations**](RecordingApi.html#postconversationidrecordingsrecordingidannotations) | **POST** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations | Create annotation |
| [**PostMediaretentionpolicies**](RecordingApi.html#postmediaretentionpolicies) | **POST** /api/v2/recording/mediaretentionpolicies | Create media retention policy |
| [**PutConversationIdRecordingsRecordingId**](RecordingApi.html#putconversationidrecordingsrecordingid) | **PUT** /api/v2/conversations/{conversationId}/recordings/{recordingId} | Updates the retention records on a recording. |
| [**PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId**](RecordingApi.html#putconversationidrecordingsrecordingidannotationsannotationid) | **PUT** /api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Update annotation |
| [**PutMediaretentionpoliciesPolicyId**](RecordingApi.html#putmediaretentionpoliciespolicyid) | **PUT** /api/v2/recording/mediaretentionpolicies/{policyId} | Update a media retention policy |
| [**PutSettings**](RecordingApi.html#putsettings) | **PUT** /api/v2/recording/settings | Update the Recording Settings for the Organization |
{: class="table table-striped"}

<a name="deleteconversationidrecordingsrecordingidannotationsannotationid"></a>

## void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId)

Delete annotation



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

## string** DeleteMediaretentionpolicies (string ids)

Delete media retention policies

Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.

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

## string** DeleteMediaretentionpoliciesPolicyId (string policyId)

Delete a media retention policy



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

 deletes a single orphan recording



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
                //  deletes a single orphan recording
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
            var maxWaitMs = 56;  // int? | The maximum number of milliseconds to wait for the recording to be ready. (optional)  (default to 5000)
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
| **maxWaitMs** | **int?**| The maximum number of milliseconds to wait for the recording to be ready. | [optional] [default to 5000] |
| **formatId** | **string**| The desired media format | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**List<Recording>**](Recording.html)

<a name="getconversationidrecordingsrecordingid"></a>

## void GetConversationIdRecordingsRecordingId (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null)

Gets a specific recording.



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
                apiInstance.GetConversationIdRecordingsRecordingId(conversationId, recordingId, formatId, download, fileName);
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

void (empty response body)

<a name="getconversationidrecordingsrecordingidannotations"></a>

## [**List&lt;Annotation&gt;**](Annotation.html) GetConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId)

Get annotations for recording



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

<a name="getmediaretentionpolicies"></a>

## [**PolicyEntityListing**](PolicyEntityListing.html) GetMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)

Gets media retention policy list with query options to filter on name and enabled.

for a less verbose response, add summary=true to this endpoint

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
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
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

<a name="getorphanrecordings"></a>

## [**OrphanRecordingListing**](OrphanRecordingListing.html) GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null)

Gets all orphan recordings



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
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 

            try
            {
                // Gets all orphan recordings
                OrphanRecordingListing result = apiInstance.GetOrphanrecordings(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
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
| **expand** | [**List<string>**](string.html)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
{: class="table table-striped"}

### Return type

[**OrphanRecordingListing**](OrphanRecordingListing.html)

<a name="getsettings"></a>

## [**RecordingSettings**](RecordingSettings.html) GetSettings (bool? createDefault = null)

Get the Recording Settings for the Organization



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

<a name="patchmediaretentionpoliciespolicyid"></a>

## [**Policy**](Policy.html) PatchMediaretentionpoliciesPolicyId (string policyId, Policy body = null)

Patch a media retention policy



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
            var body = new Policy(); // Policy | Policy (optional) 

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
| **body** | [**Policy**](Policy.html)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="postconversationidrecordingsrecordingidannotations"></a>

## [**Annotation**](Annotation.html) PostConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId, Annotation body = null)

Create annotation



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
            var body = new Annotation(); // Annotation | annotation (optional) 

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
| **body** | [**Annotation**](Annotation.html)| annotation | [optional]  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="postmediaretentionpolicies"></a>

## [**Policy**](Policy.html) PostMediaretentionpolicies (Policy body = null)

Create media retention policy



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
            var body = new Policy(); // Policy | Policy (optional) 

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
| **body** | [**Policy**](Policy.html)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="putconversationidrecordingsrecordingid"></a>

## void PutConversationIdRecordingsRecordingId (string conversationId, string recordingId, Recording body)

Updates the retention records on a recording.

Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter 'restoreDays' is deprecated and will be removed in the next major version release. If 'restoreDays' is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate's time stamp in the PUT body to 10 days in the future.

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
                apiInstance.PutConversationIdRecordingsRecordingId(conversationId, recordingId, body);
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

void (empty response body)

<a name="putconversationidrecordingsrecordingidannotationsannotationid"></a>

## [**Annotation**](Annotation.html) PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body = null)

Update annotation



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
            var body = new Annotation(); // Annotation | annotation (optional) 

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
| **body** | [**Annotation**](Annotation.html)| annotation | [optional]  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.html)

<a name="putmediaretentionpoliciespolicyid"></a>

## [**Policy**](Policy.html) PutMediaretentionpoliciesPolicyId (string policyId, Policy body = null)

Update a media retention policy



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
            var body = new Policy(); // Policy | Policy (optional) 

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
| **body** | [**Policy**](Policy.html)| Policy | [optional]  |
{: class="table table-striped"}

### Return type

[**Policy**](Policy.html)

<a name="putsettings"></a>

## [**RecordingSettings**](RecordingSettings.html) PutSettings (RecordingSettings body = null)

Update the Recording Settings for the Organization



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
            var body = new RecordingSettings(); // RecordingSettings |  (optional) 

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
| **body** | [**RecordingSettings**](RecordingSettings.html)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**RecordingSettings**](RecordingSettings.html)

