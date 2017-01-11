---
title: Call
---
## ININ.PureCloudApi.Model.Call

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Direction** | **string** | The direction of the call | [optional] |
| **Recording** | **bool?** | True if this call is being recorded. | [optional] |
| **RecordingState** | **string** | State of recording on this call. | [optional] |
| **Muted** | **bool?** | True if this call is muted so that remote participants can&#39;t hear any audio from this end. | [optional] |
| **Confined** | **bool?** | True if this call is held and the person on this side hears hold music. | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] |
| **RecordingId** | **string** | A globally unique identifier for the recording associated with this call. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) | The time line of the participant&#39;s call, divided into activity segments. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) |  | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DocumentId** | **string** | If call is an outbound fax of a document from content management, then this is the id in content management. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectReasons** | [**List&lt;DisconnectReason&gt;**](DisconnectReason.html) | List of reasons that this call was disconnected. This will be set once the call disconnects. | [optional] |
| **FaxStatus** | [**FaxStatus**](FaxStatus.html) | Extra information on fax transmission. | [optional] |
| **Provider** | **string** | The source provider for the call. | [optional] |
{: class="table table-striped"}


