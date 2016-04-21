---
title: WorkItemCache
---
## ININ.PureCloudApi.Model.WorkItemCache

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **WorkItemExecId** | **string** | The workItem instance ID that owns this cache. | [optional] |
| **SaveTime** | **DateTime?** | The time that the workItem cache was last saved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SaveUser** | [**User**](User.html) | The user that last saved the workItem cache. | [optional] |
| **SaveComment** | **string** | An optional comment made during the last save | [optional] |
| **DataItems** | [**List&lt;DataItem&gt;**](DataItem.html) | The data items that are present within the cache. | [optional] |
{: class="table table-striped"}


