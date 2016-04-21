---
title: VoicemailMessage
---
## ININ.PureCloudApi.Model.VoicemailMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Conversation** | [**Conversation**](Conversation.html) |  | [optional] |
| **Read** | **bool?** |  | [optional] [default to false]|
| **AudioRecordingDurationSeconds** | **int?** |  | [optional] |
| **AudioRecordingSizeBytes** | **long?** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **CallerName** | **string** |  | [optional] |
| **CallerUser** | [**User**](User.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


