---
title: CaseType
---
## ININ.PureCloudApi.Model.CaseType

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | Name of the case type | |
| **Description** | **string** | Detailed description of the case type | [optional] |
| **IsActive** | **bool?** | Active/Inactive flag of the case type | [optional] [default to false]|
| **IsDefault** | **bool?** | Default case type. An organization can have a set of default types which cannot be modified | [optional] [default to false]|
| **DateCreated** | **DateTime?** | Date when case type is created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date when case type is updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


