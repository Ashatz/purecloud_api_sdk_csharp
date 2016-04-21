---
title: SequenceSchedule
---
## ININ.PureCloudApi.Model.SequenceSchedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** |  | [optional] |
| **Intervals** | [**List&lt;CampaignScheduleIntervals&gt;**](CampaignScheduleIntervals.html) |  | [optional] |
| **TimeZone** | **string** |  | [optional] |
| **Sequence** | [**UriReference**](UriReference.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


