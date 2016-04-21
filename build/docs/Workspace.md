---
title: Workspace
---
## .Workspace

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Type** | **string** |  | [optional] |
| **IsCurrentUserWorkspace** | **bool?** |  | [optional] [default to false]|
| **User** | [**UriReference**](UriReference.html) |  | [optional] |
| **Bucket** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Summary** | [**WorkspaceSummary**](WorkspaceSummary.html) |  | [optional] |
| **Acl** | **List&lt;string&gt;** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


