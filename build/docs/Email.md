---
title: Email
---
## ININ.PureCloudApi.Model.Email

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** |  | [optional] |
| **Id** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] [default to false]|
| **Subject** | **string** |  | [optional] |
| **MessagesSent** | **int?** |  | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **RecordingId** | **string** |  | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) |  | [optional] |
| **DisconnectType** | **string** |  | [optional] |
| **StartHoldTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


