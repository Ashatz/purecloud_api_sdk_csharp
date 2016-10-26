---
title: ForecastMetadata
---
## ININ.PureCloudApi.Model.ForecastMetadata

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **NumberOfPeriods** | **int?** | The number of periods to be forecasted for | |
| **PeriodFrequency** | **string** | The frequency of the period | |
| **Description** | **string** | The description of the forecast to be created | |
| **Metrics** | **List&lt;string&gt;** | The metrics the forecast is for | |
| **LastModifiedDate** | **DateTime?** | The last modified date time of this object. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LastModifiedBy** | [**User**](User.html) | The person who last modified this object | [optional] |
| **Status** | **string** | The status of the creation of the forecast | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


