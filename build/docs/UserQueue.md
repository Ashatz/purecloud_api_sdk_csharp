---
title: UserQueue
---
## ININ.PureCloudApi.Model.UserQueue

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **MediaSettings** | [**Dictionary&lt;string, MediaSetting&gt;**](MediaSetting.html) |  | [optional] |
| **Bullseye** | [**Bullseye**](Bullseye.html) |  | [optional] |
| **AcwSettings** | [**AcwSettings**](AcwSettings.html) |  | [optional] |
| **SkillEvaluationMethod** | **string** |  | [optional] |
| **QueueFlow** | [**UriReference**](UriReference.html) |  | [optional] |
| **CallingPartyName** | **string** |  | [optional] |
| **CallingPartyNumber** | **string** |  | [optional] |
| **Joined** | **bool?** |  | [optional] [default to false]|
| **MemberCount** | **int?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


