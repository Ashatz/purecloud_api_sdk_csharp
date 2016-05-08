---
title: DncList
---
## ININ.PureCloudApi.Model.DncList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **PhoneNumberColumns** | **List&lt;string&gt;** | the name of the columns containing the numbers not to be called | |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) | the status of the import process | [optional] |
| **Size** | **long?** | the number of phone numbers in the do not call list | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


