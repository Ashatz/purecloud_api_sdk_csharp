---
title: Flow
---
## ININ.PureCloudApi.Model.Flow

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **LockedUser** | [**UriReference**](UriReference.html) |  | [optional] |
| **Active** | **bool?** |  | [optional] [default to false]|
| **Deleted** | **bool?** |  | [optional] [default to false]|
| **PublishedVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **CheckedInVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **SavedVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **System** | **bool?** |  | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


