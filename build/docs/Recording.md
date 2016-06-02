---
title: Recording
---
## ININ.PureCloudApi.Model.Recording

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConversationId** | **string** |  | [optional] |
| **Path** | **string** |  | [optional] |
| **StartTime** | **string** |  | [optional] |
| **EndTime** | **string** |  | [optional] |
| **Media** | **string** | The type of media that the recording is. | [optional] |
| **Annotations** | [**List&lt;Annotation&gt;**](Annotation.html) | Annotations that belong to the recording. | [optional] |
| **Transcript** | [**List&lt;ChatMessage&gt;**](ChatMessage.html) | Represents a chat transcript | [optional] |
| **EmailTranscript** | [**List&lt;RecordingEmailMessage&gt;**](RecordingEmailMessage.html) | Represents an email transcript | [optional] |
| **FileState** | **string** | Represents the current file state for a recording. Examples: Uploading, Archived, etc | [optional] |
| **RestoreExpirationTime** | **DateTime?** | The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MediaUris** | [**Dictionary&lt;string, MediaResult&gt;**](MediaResult.html) | The different mediaUris for the recording. | [optional] |
| **EstimatedTranscodeTimeMs** | **long?** |  | [optional] |
| **ActualTranscodeTimeMs** | **long?** |  | [optional] |
| **ArchiveDate** | **DateTime?** | The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ArchiveMedium** | **string** | The type of archive medium used. Example: CloudArchive | [optional] |
| **DeleteDate** | **DateTime?** | The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MaxAllowedRestorationsForOrg** | **int?** | How many archive restorations the organization is allowed to have. | [optional] |
| **RemainingRestorationsAllowedForOrg** | **int?** | The remaining archive restorations the organization has. | [optional] |
| **SessionId** | **string** | The session id represents an external resource id, such as email, call, chat, etc | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


