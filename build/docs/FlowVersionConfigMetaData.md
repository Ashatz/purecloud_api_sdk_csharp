---
title: FlowVersionConfigMetaData
---
## .FlowVersionConfigMetaData

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **VersionSpecificComment** | **string** | Checkin comment for this specific flow version. | [optional] |
| **FlowDefinitionUri** | **string** | Uri location for the flow definition contents. | |
| **FlowDefinitionUploaded** | **bool?** | true if the version has its definition properly uploaded. | [default to false]|
| **CreatedByUser** | [**User**](User.html) | If known, the user who created this flow version. | [optional] |
| **CreatedDate** | **DateTime?** | The date and time that the version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **Version** | **string** | Version of this flow config. | [optional] |
{: class="table table-striped"}


