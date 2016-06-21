---
title: TimeOffRequest
---
## ININ.PureCloudApi.Model.TimeOffRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **User** | [**User**](User.html) |  | [optional] |
| **IsFullDayRequest** | **bool?** |  | [optional] [default to false]|
| **MarkedAsRead** | **bool?** |  | [optional] [default to false]|
| **ActivityCodeId** | **string** |  | [optional] |
| **Status** | **string** |  | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** |  | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** |  | [optional] |
| **DailyDurationMinutes** | **int?** |  | [optional] |
| **Notes** | **string** |  | [optional] |
| **SubmittedBy** | [**User**](User.html) |  | [optional] |
| **SubmittedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ReviewedBy** | [**User**](User.html) |  | [optional] |
| **ReviewedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | [**User**](User.html) |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Name** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


