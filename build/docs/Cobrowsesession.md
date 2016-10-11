---
title: Cobrowsesession
---
## ININ.PureCloudApi.Model.Cobrowsesession

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **Self** | [**Address**](Address.html) | Address and name data for a call endpoint. | [optional] |
| **CobrowseSessionId** | **string** | The co-browse session ID. | [optional] |
| **CobrowseRole** | **string** | This value identifies the role of the co-browse client within the co-browse session (a client is a sharer or a viewer). | [optional] |
| **Controlling** | **List&lt;string&gt;** | ID of co-browse participants for which this client has been granted control (list is empty if this client cannot control any shared pages). | [optional] |
| **ViewerUrl** | **string** | The URL that can be used to open co-browse session in web browser. | [optional] |
| **ProviderEventTime** | **DateTime?** | The time when the provider event which triggered this conversation update happened in the corrected provider clock (milliseconds since 1970-01-01 00:00:00 UTC). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Provider** | **string** | The source provider for the co-browse session. | [optional] |
{: class="table table-striped"}


