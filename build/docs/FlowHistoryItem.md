---
title: FlowHistoryItem
---
## ININ.PureCloudApi.Model.FlowHistoryItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **HistoryEventTime** | **DateTime?** | The time when the history item occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **State** | [**FlowState**](FlowState.html) | The State sequence that applies to the history event, if applicable. | [optional] |
| **WorkItem** | [**WorkItem**](WorkItem.html) | Information about the work item associated with the history event, if applicable. | [optional] |
| **User** | [**User**](User.html) | The user associated with this history event, if applicable. | [optional] |
| **Queue** | [**Queue**](Queue.html) | The queue associated with this history event, if applicable. | [optional] |
| **HistoryEventData** | [**List&lt;DataItem&gt;**](DataItem.html) | Data elements associated with this history event. | [optional] |
| **HistoryEventType** | **string** | The type of the history event being reported. | |
| **Success** | **bool?** | Whether or not the flow item was successful (if a &#39;notification&#39; event this will default to true) | [default to false]|
{: class="table table-striped"}


