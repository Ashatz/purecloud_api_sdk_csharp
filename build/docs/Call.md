---
title: Call
---
## ININ.PureCloudApi.Model.Call

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** |  | [optional] |
| **Id** | **string** |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **Recording** | **bool?** |  | [optional] [default to false]|
| **RecordingState** | **string** |  | [optional] |
| **Muted** | **bool?** |  | [optional] [default to false]|
| **Confined** | **bool?** |  | [optional] [default to false]|
| **Held** | **bool?** |  | [optional] [default to false]|
| **RecordingId** | **string** |  | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) |  | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **StartHoldTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DocumentId** | **string** |  | [optional] |
| **ConnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectReasons** | [**List&lt;DisconnectReason&gt;**](DisconnectReason.html) |  | [optional] |
| **FaxStatus** | [**FaxStatus**](FaxStatus.html) |  | [optional] |
{: class="table table-striped"}


