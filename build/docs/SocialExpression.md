---
title: SocialExpression
---
## ININ.PureCloudApi.Model.SocialExpression

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **SocialMediaId** | **string** | A globally unique identifier for the social media. | [optional] |
| **SocialMediaHub** | **string** | The social network of the communication | [optional] |
| **SocialUserName** | **string** | The user name for the communication. | [optional] |
| **PreviewText** | **string** | The text preview of the communication contents | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this chat. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) | The time line of the participant&#39;s chat, divided into activity segments. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Provider** | **string** | The source provider for the social expression. | [optional] |
{: class="table table-striped"}


