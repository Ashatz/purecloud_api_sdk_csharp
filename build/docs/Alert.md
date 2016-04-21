---
title: Alert
---
## .Alert

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Title** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Unread** | **bool?** |  | [optional] [default to false]|
| **Entity** | [**Entity**](Entity.html) |  | [optional] |
| **Metric** | **string** |  | [optional] |
| **MetricThresholds** | [**List&lt;MetricThreshold&gt;**](MetricThreshold.html) |  | [optional] |
| **MetricValue** | **double?** |  | [optional] |
| **StartTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MediaType** | **string** |  | [optional] |
| **Statistic** | **string** |  | [optional] |
| **RuleUri** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


