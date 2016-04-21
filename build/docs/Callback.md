---
title: Callback
---
## ININ.PureCloudApi.Model.Callback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** |  | [optional] |
| **Id** | **string** |  | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) |  | [optional] |
| **Direction** | **string** |  | [optional] |
| **Held** | **bool?** |  | [optional] [default to false]|
| **DisconnectType** | **string** |  | [optional] |
| **StartHoldTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DialerPreview** | [**DialerPreview**](DialerPreview.html) |  | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** |  | [optional] |
| **CallbackUserName** | **string** |  | [optional] |
| **ScriptId** | **string** |  | [optional] |
| **SkipEnabled** | **bool?** |  | [optional] [default to false]|
| **TimeoutSeconds** | **int?** |  | [optional] |
| **ConnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


