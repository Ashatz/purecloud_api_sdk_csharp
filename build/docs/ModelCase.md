---
title: ModelCase
---
## ININ.PureCloudApi.Model.ModelCase

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Title** | **string** | Brief title for the Case | |
| **Status** | [**CaseStatus**](CaseStatus.html) | Predefined status to be assigned to a case. A list of case statuses will be managed by Case Admin | |
| **Type** | [**CaseType**](CaseType.html) | Predefined type to be assigned to a case. A list of case types will be managed by Case Admin | |
| **Description** | **string** | Detailed description of the case | |
| **DateCreated** | **DateTime?** | Date when case is created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date when case is updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


