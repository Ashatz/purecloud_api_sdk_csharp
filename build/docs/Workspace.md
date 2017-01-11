---
title: Workspace
---
## ININ.PureCloudApi.Model.Workspace

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The current name of the workspace. | |
| **Type** | **string** |  | [optional] |
| **IsCurrentUserWorkspace** | **bool?** |  | [optional] |
| **User** | [**UriReference**](UriReference.html) |  | [optional] |
| **Bucket** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Summary** | [**WorkspaceSummary**](WorkspaceSummary.html) |  | [optional] |
| **Acl** | **List&lt;string&gt;** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


