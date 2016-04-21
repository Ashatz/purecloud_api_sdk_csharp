---
title: Policy
---
## .Policy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Order** | **int?** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] [default to false]|
| **Conditions** | [**PolicyConditions**](PolicyConditions.html) |  | [optional] |
| **Actions** | [**PolicyActions**](PolicyActions.html) |  | [optional] |
| **PolicyErrors** | [**PolicyErrors**](PolicyErrors.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


