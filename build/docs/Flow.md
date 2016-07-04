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
| **System** | **bool?** |  | [optional] [default to false]|
| **Deleted** | **bool?** |  | [optional] [default to false]|
| **PublishedVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **SavedVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **InputSchema** | **Object** |  | [optional] |
| **OutputSchema** | **Object** |  | [optional] |
| **CheckedInVersion** | [**FlowVersion**](FlowVersion.html) |  | [optional] |
| **PublishStatus** | **string** |  | [optional] |
| **PublishedBy** | [**UriReference**](UriReference.html) |  | [optional] |
| **CurrentOperation** | [**Operation**](Operation.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


