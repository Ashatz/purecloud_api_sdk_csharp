---
title: Video
---
## ININ.PureCloudApi.Model.Video

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Context** | **string** | The room id context (xmpp jid) for the conference session. | [optional] |
| **AudioMuted** | **bool?** | Indicates whether this participant has muted their outgoing audio. | [optional] |
| **VideoMuted** | **bool?** | Indicates whether this participant has muted/paused their outgoing video. | [optional] |
| **SharingScreen** | **bool?** | Indicates whether this participant is sharing their screen to the session. | [optional] |
| **PeerCount** | **int?** | The number of peer participants from the perspective of the participant in the conference. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Provider** | **string** | The source provider for the video. | [optional] |
{: class="table table-striped"}


