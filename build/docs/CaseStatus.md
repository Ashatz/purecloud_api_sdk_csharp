---
title: CaseStatus
---
## ININ.PureCloudApi.Model.CaseStatus

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the case status | |
| **Description** | **string** | Detailed description of the case status | [optional] |
| **Order** | **int?** | Display order of the case status. Possible values 1 - 1000. | [optional] |
| **IsActive** | **bool?** | Active/Inactive flag of the case status | [optional] [default to false]|
| **IsDefault** | **bool?** | Default case status. An organization can have a set of default statuses which cannot be delete or modified. Only custom cases can be modified | [optional] [default to false]|
| **DateCreated** | **DateTime?** | Date when case status is created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date when case status is updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


