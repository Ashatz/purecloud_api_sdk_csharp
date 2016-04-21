---
title: DncList
---
## ININ.PureCloudApi.Model.DncList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | required for updates, must match the version number of the most recent update | [optional] |
| **PhoneNumberColumns** | **List&lt;string&gt;** |  | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) |  | [optional] |
| **FileKey** | **string** |  | [optional] |
| **Size** | **long?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


