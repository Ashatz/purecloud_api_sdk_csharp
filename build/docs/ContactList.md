---
title: ContactList
---
## ININ.PureCloudApi.Model.ContactList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | required for updates, must match the version number of the most recent update | [optional] |
| **ColumnNames** | **List&lt;string&gt;** |  | [optional] |
| **PhoneColumns** | [**List&lt;ContactPhoneNumberColumn&gt;**](ContactPhoneNumberColumn.html) |  | [optional] |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) |  | [optional] |
| **PreviewModeColumnName** | **string** |  | [optional] |
| **PreviewModeAcceptedValues** | **List&lt;string&gt;** |  | [optional] |
| **Size** | **long?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


