# ININ.PureCloudApi.Api.QualityApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ConversationsConversationidRecordingsGet**](QualityApi.md#conversationsconversationidrecordingsget) | **GET** /api/v1/conversations/{conversationId}/recordings | Get all of a Conversation&#39;s Recordings. |
| [**ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete**](QualityApi.md#conversationsconversationidrecordingsrecordingidannotationsannotationiddelete) | **DELETE** /api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Delete annotation |
| [**ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet**](QualityApi.md#conversationsconversationidrecordingsrecordingidannotationsannotationidget) | **GET** /api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Get annotation |
| [**ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut**](QualityApi.md#conversationsconversationidrecordingsrecordingidannotationsannotationidput) | **PUT** /api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId} | Update annotation |
| [**ConversationsConversationidRecordingsRecordingidAnnotationsGet**](QualityApi.md#conversationsconversationidrecordingsrecordingidannotationsget) | **GET** /api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations | Get annotations for recording |
| [**ConversationsConversationidRecordingsRecordingidAnnotationsPost**](QualityApi.md#conversationsconversationidrecordingsrecordingidannotationspost) | **POST** /api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations | Create annotation |
| [**ConversationsConversationidRecordingsRecordingidGet**](QualityApi.md#conversationsconversationidrecordingsrecordingidget) | **GET** /api/v1/conversations/{conversationId}/recordings/{recordingId} | Gets a specific recording. |
| [**ConversationsConversationidRecordingsRecordingidPut**](QualityApi.md#conversationsconversationidrecordingsrecordingidput) | **PUT** /api/v1/conversations/{conversationId}/recordings/{recordingId} | Updates the retention records on a recording. |
| [**QualityAgentsActivityGet**](QualityApi.md#qualityagentsactivityget) | **GET** /api/v1/quality/agents/activity | Gets a list of Agent Activities |
| [**QualityCalibrationsCalibrationidDelete**](QualityApi.md#qualitycalibrationscalibrationiddelete) | **DELETE** /api/v1/quality/calibrations/{calibrationId} | Delete a calibration by id. |
| [**QualityCalibrationsCalibrationidGet**](QualityApi.md#qualitycalibrationscalibrationidget) | **GET** /api/v1/quality/calibrations/{calibrationId} | Get a calibration by id. |
| [**QualityCalibrationsCalibrationidPut**](QualityApi.md#qualitycalibrationscalibrationidput) | **PUT** /api/v1/quality/calibrations/{calibrationId} | Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex |
| [**QualityCalibrationsGet**](QualityApi.md#qualitycalibrationsget) | **GET** /api/v1/quality/calibrations | Get the list of calibrations |
| [**QualityCalibrationsPost**](QualityApi.md#qualitycalibrationspost) | **POST** /api/v1/quality/calibrations | Create a calibration |
| [**QualityConversationsConversationidAuditsGet**](QualityApi.md#qualityconversationsconversationidauditsget) | **GET** /api/v1/quality/conversations/{conversationId}/audits | Get audits for conversation or recording |
| [**QualityConversationsConversationidEvaluationsEvaluationidDelete**](QualityApi.md#qualityconversationsconversationidevaluationsevaluationiddelete) | **DELETE** /api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId} | Delete an evaluation |
| [**QualityConversationsConversationidEvaluationsEvaluationidGet**](QualityApi.md#qualityconversationsconversationidevaluationsevaluationidget) | **GET** /api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId} | Get an evaluation |
| [**QualityConversationsConversationidEvaluationsEvaluationidPut**](QualityApi.md#qualityconversationsconversationidevaluationsevaluationidput) | **PUT** /api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId} | Update an evaluation |
| [**QualityConversationsConversationidEvaluationsPost**](QualityApi.md#qualityconversationsconversationidevaluationspost) | **POST** /api/v1/quality/conversations/{conversationId}/evaluations | Create an evaluation |
| [**QualityEvaluationsQueryGet**](QualityApi.md#qualityevaluationsqueryget) | **GET** /api/v1/quality/evaluations/query | Queries Evaluations and returns a paged list |
| [**QualityEvaluationsQueryPost**](QualityApi.md#qualityevaluationsquerypost) | **POST** /api/v1/quality/evaluations/query | Query evaluations |
| [**QualityEvaluationsScoringPost**](QualityApi.md#qualityevaluationsscoringpost) | **POST** /api/v1/quality/evaluations/scoring | Score evaluation |
| [**QualityEvaluatorsActivityGet**](QualityApi.md#qualityevaluatorsactivityget) | **GET** /api/v1/quality/evaluators/activity | Get an evaluator activity |
{: class="table table-striped"}

<a name="ConversationsConversationidRecordingsGet"></a>
## [**List&lt;Recording&gt;**](Recording.html) ConversationsConversationidRecordingsGet (string conversationId, int? maxWaitMs = null, string formatId = null)

Get all of a Conversation's Recordings.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var maxWaitMs = 56;  // int? | The maximum number of milliseconds to wait for the recording to be ready. (optional)  (default to 5000)
            var formatId = formatId_example;  // string | The desired format (WEBM, WAV, etc.) (optional)  (default to WEBM)

            try
            {
                // Get all of a Conversation's Recordings.
                List&lt;Recording&gt; result = apiInstance.ConversationsConversationidRecordingsGet(conversationId, maxWaitMs, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **maxWaitMs** | **int?**| The maximum number of milliseconds to wait for the recording to be ready. | [optional] [default to 5000] |
| **formatId** | **string**| The desired format (WEBM, WAV, etc.) | [optional] [default to WEBM] |
{: class="table table-striped"}

### Return type

[**List<Recording>**](Recording.md)

<a name="ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete"></a>
## void ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete (string conversationId, string recordingId, string annotationId)

Delete annotation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID

            try
            {
                // Delete annotation
                apiInstance.ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete(conversationId, recordingId, annotationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet"></a>
## [**Annotation**](Annotation.html) ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet (string conversationId, string recordingId, string annotationId)

Get annotation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID

            try
            {
                // Get annotation
                Annotation result = apiInstance.ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet(conversationId, recordingId, annotationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.md)

<a name="ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut"></a>
## [**Annotation**](Annotation.html) ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut (string conversationId, string recordingId, string annotationId, Annotation body = null)

Update annotation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var annotationId = annotationId_example;  // string | Annotation ID
            var body = new Annotation(); // Annotation | annotation (optional) 

            try
            {
                // Update annotation
                Annotation result = apiInstance.ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut(conversationId, recordingId, annotationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **annotationId** | **string**| Annotation ID |  |
| **body** | [**Annotation**](Annotation.md)| annotation | [optional]  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.md)

<a name="ConversationsConversationidRecordingsRecordingidAnnotationsGet"></a>
## [**List&lt;Annotation&gt;**](Annotation.html) ConversationsConversationidRecordingsRecordingidAnnotationsGet (string conversationId, string recordingId)

Get annotations for recording



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidAnnotationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID

            try
            {
                // Get annotations for recording
                List&lt;Annotation&gt; result = apiInstance.ConversationsConversationidRecordingsRecordingidAnnotationsGet(conversationId, recordingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
{: class="table table-striped"}

### Return type

[**List<Annotation>**](Annotation.md)

<a name="ConversationsConversationidRecordingsRecordingidAnnotationsPost"></a>
## [**Annotation**](Annotation.html) ConversationsConversationidRecordingsRecordingidAnnotationsPost (string conversationId, string recordingId, Annotation body = null)

Create annotation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidAnnotationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var body = new Annotation(); // Annotation | annotation (optional) 

            try
            {
                // Create annotation
                Annotation result = apiInstance.ConversationsConversationidRecordingsRecordingidAnnotationsPost(conversationId, recordingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **body** | [**Annotation**](Annotation.md)| annotation | [optional]  |
{: class="table table-striped"}

### Return type

[**Annotation**](Annotation.md)

<a name="ConversationsConversationidRecordingsRecordingidGet"></a>
## void ConversationsConversationidRecordingsRecordingidGet (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)

Gets a specific recording.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var maxWaitMs = 56;  // int? | The maximum number of milliseconds to wait for completion. (optional) 
            var formatId = formatId_example;  // string | The desired format (WEBM, WAV, etc.) (optional)  (default to WEBM)
            var download = true;  // bool? | requesting a download format of the recording (optional)  (default to false)
            var fileName = fileName_example;  // string | the name of the downloaded fileName (optional) 

            try
            {
                // Gets a specific recording.
                apiInstance.ConversationsConversationidRecordingsRecordingidGet(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **maxWaitMs** | **int?**| The maximum number of milliseconds to wait for completion. | [optional]  |
| **formatId** | **string**| The desired format (WEBM, WAV, etc.) | [optional] [default to WEBM] |
| **download** | **bool?**| requesting a download format of the recording | [optional] [default to false] |
| **fileName** | **string**| the name of the downloaded fileName | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="ConversationsConversationidRecordingsRecordingidPut"></a>
## void ConversationsConversationidRecordingsRecordingidPut (string conversationId, string recordingId, Recording body, int? restoreDays = null)

Updates the retention records on a recording.

Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter 'restoreDays' is deprecated and will be removed in the next major version release. If 'restoreDays' is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate's time stamp in the PUT body to 10 days in the future.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ConversationsConversationidRecordingsRecordingidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var recordingId = recordingId_example;  // string | Recording ID
            var body = new Recording(); // Recording | recording
            var restoreDays = 56;  // int? | The number of days the recording will be available before it is re-archived. Deprecated. (optional) 

            try
            {
                // Updates the retention records on a recording.
                apiInstance.ConversationsConversationidRecordingsRecordingidPut(conversationId, recordingId, body, restoreDays);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.ConversationsConversationidRecordingsRecordingidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **recordingId** | **string**| Recording ID |  |
| **body** | [**Recording**](Recording.md)| recording |  |
| **restoreDays** | **int?**| The number of days the recording will be available before it is re-archived. Deprecated. | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="QualityAgentsActivityGet"></a>
## [**AgentActivityEntityListing**](AgentActivityEntityListing.html) QualityAgentsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)

Gets a list of Agent Activities

Including the number of evaluations and average evaluation score

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityAgentsActivityGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var agentUserId = new List<string>(); // List<string> | user id of agent requested (optional) 
            var evaluatorUserId = evaluatorUserId_example;  // string | user id of the evaluator (optional) 
            var name = name_example;  // string | name (optional) 
            var group = group_example;  // string | group id (optional) 

            try
            {
                // Gets a list of Agent Activities
                AgentActivityEntityListing result = apiInstance.QualityAgentsActivityGet(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityAgentsActivityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **startTime** | **DateTime?**| Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **agentUserId** | [**List<string>**](string.md)| user id of agent requested | [optional]  |
| **evaluatorUserId** | **string**| user id of the evaluator | [optional]  |
| **name** | **string**| name | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**AgentActivityEntityListing**](AgentActivityEntityListing.md)

<a name="QualityCalibrationsCalibrationidDelete"></a>
## [**Calibration**](Calibration.html) QualityCalibrationsCalibrationidDelete (string calibrationId, string calibratorId = null)

Delete a calibration by id.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityCalibrationsCalibrationidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibrationId = calibrationId_example;  // string | Calibration ID
            var calibratorId = calibratorId_example;  // string | calibratorId (optional) 

            try
            {
                // Delete a calibration by id.
                Calibration result = apiInstance.QualityCalibrationsCalibrationidDelete(calibrationId, calibratorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityCalibrationsCalibrationidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **calibratorId** | **string**| calibratorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="QualityCalibrationsCalibrationidGet"></a>
## [**Calibration**](Calibration.html) QualityCalibrationsCalibrationidGet (string calibrationId, string calibratorId = null)

Get a calibration by id.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityCalibrationsCalibrationidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibrationId = calibrationId_example;  // string | Calibration ID
            var calibratorId = calibratorId_example;  // string | calibratorId (optional) 

            try
            {
                // Get a calibration by id.
                Calibration result = apiInstance.QualityCalibrationsCalibrationidGet(calibrationId, calibratorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityCalibrationsCalibrationidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **calibratorId** | **string**| calibratorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="QualityCalibrationsCalibrationidPut"></a>
## [**Calibration**](Calibration.html) QualityCalibrationsCalibrationidPut (string calibrationId, Calibration body = null)

Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityCalibrationsCalibrationidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibrationId = calibrationId_example;  // string | Calibration ID
            var body = new Calibration(); // Calibration | Calibration (optional) 

            try
            {
                // Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
                Calibration result = apiInstance.QualityCalibrationsCalibrationidPut(calibrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityCalibrationsCalibrationidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **body** | [**Calibration**](Calibration.md)| Calibration | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="QualityCalibrationsGet"></a>
## [**CalibrationEntityListing**](CalibrationEntityListing.html) QualityCalibrationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)

Get the list of calibrations



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityCalibrationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var conversationId = conversationId_example;  // string | conversation id (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var calibratorId = calibratorId_example;  // string | user id of calibrator (optional) 

            try
            {
                // Get the list of calibrations
                CalibrationEntityListing result = apiInstance.QualityCalibrationsGet(pageSize, pageNumber, sortBy, expand, conversationId, startTime, endTime, calibratorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityCalibrationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **conversationId** | **string**| conversation id | [optional]  |
| **startTime** | **DateTime?**| Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **calibratorId** | **string**| user id of calibrator | [optional]  |
{: class="table table-striped"}

### Return type

[**CalibrationEntityListing**](CalibrationEntityListing.md)

<a name="QualityCalibrationsPost"></a>
## [**Calibration**](Calibration.html) QualityCalibrationsPost (Calibration body = null, string expand = null)

Create a calibration



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityCalibrationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new Calibration(); // Calibration | calibration (optional) 
            var expand = expand_example;  // string | calibratorId (optional) 

            try
            {
                // Create a calibration
                Calibration result = apiInstance.QualityCalibrationsPost(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityCalibrationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Calibration**](Calibration.md)| calibration | [optional]  |
| **expand** | **string**| calibratorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="QualityConversationsConversationidAuditsGet"></a>
## [**QualityAuditPage**](QualityAuditPage.html) QualityConversationsConversationidAuditsGet (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)

Get audits for conversation or recording



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityConversationsConversationidAuditsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var recordingId = recordingId_example;  // string | id of the recording (optional) 
            var entityType = entityType_example;  // string | entity type options: Recording, Calibration, Evaluation, Annotation (optional)  (default to RECORDING)

            try
            {
                // Get audits for conversation or recording
                QualityAuditPage result = apiInstance.QualityConversationsConversationidAuditsGet(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityConversationsConversationidAuditsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **recordingId** | **string**| id of the recording | [optional]  |
| **entityType** | **string**| entity type options: Recording, Calibration, Evaluation, Annotation | [optional] [default to RECORDING] |
{: class="table table-striped"}

### Return type

[**QualityAuditPage**](QualityAuditPage.md)

<a name="QualityConversationsConversationidEvaluationsEvaluationidDelete"></a>
## [**Evaluation**](Evaluation.html) QualityConversationsConversationidEvaluationsEvaluationidDelete (string conversationId, string evaluationId, string expand = null)

Delete an evaluation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityConversationsConversationidEvaluationsEvaluationidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var evaluationId = evaluationId_example;  // string | 
            var expand = expand_example;  // string | evaluatorId (optional) 

            try
            {
                // Delete an evaluation
                Evaluation result = apiInstance.QualityConversationsConversationidEvaluationsEvaluationidDelete(conversationId, evaluationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityConversationsConversationidEvaluationsEvaluationidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **evaluationId** | **string**|  |  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="QualityConversationsConversationidEvaluationsEvaluationidGet"></a>
## [**Evaluation**](Evaluation.html) QualityConversationsConversationidEvaluationsEvaluationidGet (string conversationId, string evaluationId, string expand = null)

Get an evaluation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityConversationsConversationidEvaluationsEvaluationidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var evaluationId = evaluationId_example;  // string | 
            var expand = expand_example;  // string | agent, evaluator, evaluationForm (optional) 

            try
            {
                // Get an evaluation
                Evaluation result = apiInstance.QualityConversationsConversationidEvaluationsEvaluationidGet(conversationId, evaluationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityConversationsConversationidEvaluationsEvaluationidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **evaluationId** | **string**|  |  |
| **expand** | **string**| agent, evaluator, evaluationForm | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="QualityConversationsConversationidEvaluationsEvaluationidPut"></a>
## [**Evaluation**](Evaluation.html) QualityConversationsConversationidEvaluationsEvaluationidPut (string conversationId, string evaluationId, Evaluation body = null, string expand = null)

Update an evaluation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityConversationsConversationidEvaluationsEvaluationidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var evaluationId = evaluationId_example;  // string | 
            var body = new Evaluation(); // Evaluation | evaluation (optional) 
            var expand = expand_example;  // string | evaluatorId (optional) 

            try
            {
                // Update an evaluation
                Evaluation result = apiInstance.QualityConversationsConversationidEvaluationsEvaluationidPut(conversationId, evaluationId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityConversationsConversationidEvaluationsEvaluationidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **evaluationId** | **string**|  |  |
| **body** | [**Evaluation**](Evaluation.md)| evaluation | [optional]  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="QualityConversationsConversationidEvaluationsPost"></a>
## [**Evaluation**](Evaluation.html) QualityConversationsConversationidEvaluationsPost (string conversationId, Evaluation body = null, string expand = null)

Create an evaluation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityConversationsConversationidEvaluationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var body = new Evaluation(); // Evaluation | evaluation (optional) 
            var expand = expand_example;  // string | evaluatorId (optional) 

            try
            {
                // Create an evaluation
                Evaluation result = apiInstance.QualityConversationsConversationidEvaluationsPost(conversationId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityConversationsConversationidEvaluationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **body** | [**Evaluation**](Evaluation.md)| evaluation | [optional]  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="QualityEvaluationsQueryGet"></a>
## [**EvaluationEntityListing**](EvaluationEntityListing.html) QualityEvaluationsQueryGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)

Queries Evaluations and returns a paged list

Query params must include one of conversationId, evaluatorUserId, or agentUserId

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityEvaluationsQueryGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var conversationId = conversationId_example;  // string | conversationId specified (optional) 
            var agentUserId = agentUserId_example;  // string | user id of the agent (optional) 
            var evaluatorUserId = evaluatorUserId_example;  // string | evaluator user id (optional) 
            var queueId = queueId_example;  // string | queue id (optional) 
            var startTime = startTime_example;  // string | start time of the evaluation query (optional) 
            var endTime = endTime_example;  // string | end time of the evaluation query (optional) 
            var evaluationState = new List<string>(); // List<string> | evaluation state options: Pending, InProgress, Finished (optional) 
            var isReleased = true;  // bool? | the evaluation has been released (optional) 
            var agentHasRead = true;  // bool? | agent has the evaluation (optional) 
            var expandAnswerTotalScores = true;  // bool? | get the total scores for evaluations (optional) 
            var maximum = 56;  // int? | maximum (optional) 

            try
            {
                // Queries Evaluations and returns a paged list
                EvaluationEntityListing result = apiInstance.QualityEvaluationsQueryGet(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityEvaluationsQueryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **conversationId** | **string**| conversationId specified | [optional]  |
| **agentUserId** | **string**| user id of the agent | [optional]  |
| **evaluatorUserId** | **string**| evaluator user id | [optional]  |
| **queueId** | **string**| queue id | [optional]  |
| **startTime** | **string**| start time of the evaluation query | [optional]  |
| **endTime** | **string**| end time of the evaluation query | [optional]  |
| **evaluationState** | [**List<string>**](string.md)| evaluation state options: Pending, InProgress, Finished | [optional]  |
| **isReleased** | **bool?**| the evaluation has been released | [optional]  |
| **agentHasRead** | **bool?**| agent has the evaluation | [optional]  |
| **expandAnswerTotalScores** | **bool?**| get the total scores for evaluations | [optional]  |
| **maximum** | **int?**| maximum | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationEntityListing**](EvaluationEntityListing.md)

<a name="QualityEvaluationsQueryPost"></a>
## [**EvaluationEntityListing**](EvaluationEntityListing.html) QualityEvaluationsQueryPost (EvaluationQueryRequest body = null, string expand = null)

Query evaluations



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityEvaluationsQueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new EvaluationQueryRequest(); // EvaluationQueryRequest | query (optional) 
            var expand = expand_example;  // string | evaluator,agent (optional) 

            try
            {
                // Query evaluations
                EvaluationEntityListing result = apiInstance.QualityEvaluationsQueryPost(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityEvaluationsQueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationQueryRequest**](EvaluationQueryRequest.md)| query | [optional]  |
| **expand** | **string**| evaluator,agent | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationEntityListing**](EvaluationEntityListing.md)

<a name="QualityEvaluationsScoringPost"></a>
## [**EvaluationScoringSet**](EvaluationScoringSet.html) QualityEvaluationsScoringPost (EvaluationFormAndScoringSet body = null)

Score evaluation



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityEvaluationsScoringPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new EvaluationFormAndScoringSet(); // EvaluationFormAndScoringSet | evaluationAndScoringSet (optional) 

            try
            {
                // Score evaluation
                EvaluationScoringSet result = apiInstance.QualityEvaluationsScoringPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityEvaluationsScoringPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationFormAndScoringSet**](EvaluationFormAndScoringSet.md)| evaluationAndScoringSet | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationScoringSet**](EvaluationScoringSet.md)

<a name="QualityEvaluatorsActivityGet"></a>
## [**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.html) QualityEvaluatorsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)

Get an evaluator activity



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityEvaluatorsActivityGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var name = name_example;  // string | Evaluator name (optional) 
            var permission = new List<string>(); // List<string> | permission strings (optional) 
            var group = group_example;  // string | group id (optional) 

            try
            {
                // Get an evaluator activity
                EvaluatorActivityEntityListing result = apiInstance.QualityEvaluatorsActivityGet(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.QualityEvaluatorsActivityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **startTime** | **DateTime?**| The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **name** | **string**| Evaluator name | [optional]  |
| **permission** | [**List<string>**](string.md)| permission strings | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.md)

