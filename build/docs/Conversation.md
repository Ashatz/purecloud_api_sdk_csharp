---
title: Conversation
---
## .Conversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **StartTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Participants** | [**List&lt;Participant&gt;**](Participant.html) |  | [optional] |
| **ConversationIds** | **List&lt;string&gt;** |  | [optional] |
| **MaxParticipants** | **int?** |  | [optional] |
| **RecordingState** | **string** | On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings; otherwise indicates state of conversation recording | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


