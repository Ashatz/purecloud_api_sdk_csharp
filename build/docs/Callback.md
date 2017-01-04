---
title: Callback
---
## ININ.PureCloudApi.Model.Callback

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) | The time line of the participant&#39;s callback, divided into activity segments. | [optional] |
| **Direction** | **string** | The direction of the call | [optional] |
| **Held** | **bool?** | True if this call is held and the person on this side hears silence. | [optional] [default to false]|
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartHoldTime** | **DateTime?** | The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DialerPreview** | [**DialerPreview**](DialerPreview.html) | The preview data to be used when this callback is a Preview. | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | The phone number(s) to use to place the callback. | [optional] |
| **CallbackUserName** | **string** | The name of the user requesting a callback. | [optional] |
| **ScriptId** | **string** | The UUID of the script to use. | [optional] |
| **SkipEnabled** | **bool?** | True if the ability to skip a callback should be enabled. | [optional] [default to false]|
| **TimeoutSeconds** | **int?** | The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled. | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CallbackScheduledTime** | **DateTime?** | The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Provider** | **string** | The source provider for the callback. | [optional] |
{: class="table table-striped"}


