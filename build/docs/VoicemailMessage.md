---
title: VoicemailMessage
---
## ININ.PureCloudApi.Model.VoicemailMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Conversation** | [**Conversation**](Conversation.html) | The conversation that the voicemail message is associated with | [optional] |
| **Read** | **bool?** | Whether the voicemail message is marked as read | [optional] [default to false]|
| **AudioRecordingDurationSeconds** | **int?** | The voicemail message&#39;s audio recording duration in seconds | [optional] |
| **AudioRecordingSizeBytes** | **long?** | The voicemail message&#39;s audio recording size in bytes | [optional] |
| **CreatedDate** | **DateTime?** | The date the voicemail message was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedDate** | **DateTime?** | The date the voicemail message was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CallerAddress** | **string** | The caller address | [optional] |
| **CallerName** | **string** | Optionally the name of the caller that left the voicemail message if the caller was a known user | [optional] |
| **CallerUser** | [**User**](User.html) | Optionally the user that left the voicemail message if the caller was a known user | [optional] |
| **Deleted** | **bool?** | Whether the voicemail message has been marked as deleted | [optional] [default to false]|
| **Note** | **string** | An optional note | [optional] |
| **User** | [**User**](User.html) | The user that the voicemail message belongs to or null which means the voicemail message belongs to a group | [optional] |
| **Group** | [**Group**](Group.html) | The group that the voicemail message belongs to or null which means the voicemail message belongs to a user | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


