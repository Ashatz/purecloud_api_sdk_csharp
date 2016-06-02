---
title: FlowConfigMetaData
---
## ININ.PureCloudApi.Model.FlowConfigMetaData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ConfigState** | **string** | Usability of this flow definition. (output only) | [optional] |
| **FlowType** | **string** | Type of flow this definition describes | |
| **LockedByUser** | [**User**](User.html) | If locked for editing, the user who locked this definition, otherwise null | [optional] |
| **NewestPublishedVersion** | **string** | The most recently published version (output only) | [optional] |
| **NewestVersion** | **string** | The most recent version, regardless of published state (output only) | [optional] |
| **AssociatedWorkspaces** | [**List&lt;Workspace&gt;**](Workspace.html) | Workspaces associated with this flow. | [optional] |
| **Description** | **string** | User notes describing the flow definition. | [optional] |
| **HasDraft** | **bool?** | Flag if this definition has a draft populated. | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


