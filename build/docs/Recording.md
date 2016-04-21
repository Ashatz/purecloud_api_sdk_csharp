---
title: Recording
---
## .Recording

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConversationId** | **string** |  | [optional] |
| **Path** | **string** |  | [optional] |
| **StartTime** | **string** |  | [optional] |
| **EndTime** | **string** |  | [optional] |
| **Media** | **string** |  | [optional] |
| **MediaUri** | **string** |  | [optional] |
| **WaveUri** | **string** |  | [optional] |
| **Annotations** | [**List&lt;Annotation&gt;**](Annotation.html) |  | [optional] |
| **Transcript** | [**List&lt;ChatMessage&gt;**](ChatMessage.html) |  | [optional] |
| **EmailTranscript** | [**List&lt;EmailMessage&gt;**](EmailMessage.html) |  | [optional] |
| **FileState** | **string** |  | [optional] |
| **RestoreExpirationTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MediaUris** | [**Dictionary&lt;string, MediaResult&gt;**](MediaResult.html) |  | [optional] |
| **EstimatedTranscodeTimeMs** | **long?** |  | [optional] |
| **ActualTranscodeTimeMs** | **long?** |  | [optional] |
| **ArchiveDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ArchiveMedium** | **string** |  | [optional] |
| **DeleteDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MaxAllowedRestorationsForOrg** | **int?** |  | [optional] |
| **RemainingRestorationsAllowedForOrg** | **int?** |  | [optional] |
| **RecordingId** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


