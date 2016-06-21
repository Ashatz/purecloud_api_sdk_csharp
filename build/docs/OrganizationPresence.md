---
title: OrganizationPresence
---
## ININ.PureCloudApi.Model.OrganizationPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **LanguageLabels** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **SystemPresence** | **string** |  | [optional] |
| **Deactivated** | **bool?** |  | [optional] [default to false]|
| **Primary** | **bool?** |  | [optional] [default to false]|
| **CreatedBy** | [**User**](User.html) |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | [**User**](User.html) |  | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


