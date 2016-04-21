---
title: EdgeGroup
---
## .EdgeGroup

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
| **Managed** | **bool?** | Is this edge group being managed remotely. | [optional] [default to false]|
| **EdgeTrunkBaseAssignment** | [**TrunkBaseAssignment**](TrunkBaseAssignment.html) | A trunk base settings assignment of trunkType \&quot;EDGE\&quot; to use for edge-to-edge communication. | [optional] |
| **PhoneTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | Trunk base settings assignments of trunkType \&quot;PHONE\&quot; to inherit to edge logical interfaces for phone communication. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


