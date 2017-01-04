---
title: DomainOrganizationRole
---
## ININ.PureCloudApi.Model.DomainOrganizationRole

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **DefaultRoleId** | **string** |  | [optional] |
| **Permissions** | **List&lt;string&gt;** |  | [optional] |
| **PermissionPolicies** | [**List&lt;DomainPermissionPolicy&gt;**](DomainPermissionPolicy.html) |  | [optional] |
| **UserCount** | **int?** |  | [optional] |
| **RoleNeedsUpdate** | **bool?** | Optional unless patch operation. | [optional] [default to false]|
| **_Default** | **bool?** |  | [optional] [default to false]|
| **_Base** | **bool?** |  | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


