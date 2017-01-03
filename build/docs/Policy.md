---
title: Policy
---
## ININ.PureCloudApi.Model.Policy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Order** | **int?** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] |
| **MediaPolicies** | [**MediaPolicies**](MediaPolicies.html) | Conditions and actions per media type | [optional] |
| **Conditions** | [**PolicyConditions**](PolicyConditions.html) | Conditions | [optional] |
| **Actions** | [**PolicyActions**](PolicyActions.html) | Actions | [optional] |
| **PolicyErrors** | [**PolicyErrors**](PolicyErrors.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


