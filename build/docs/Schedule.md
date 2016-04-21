---
title: Schedule
---
## .Schedule

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **Start** | **DateTime?** | The start date for this schedule. If this is set to a value that does not match the rrule, the date portion will be updated to match the date of the next possible recurrence. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **End** | **DateTime?** | The end date for this schedule. This date will also be modifiedif the start date is modified to match the recurrence rule. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Rrule** | **string** | An iCal Recurrence Rule (RRULE) string | [optional] |
| **Keywords** | **List&lt;string&gt;** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


