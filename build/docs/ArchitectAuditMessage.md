---
title: ArchitectAuditMessage
---
## ININ.PureCloudApi.Model.ArchitectAuditMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Action** | **string** | The audit action | [optional] |
| **User** | [**AuditUser**](AuditUser.html) |  | [optional] |
| **Timestamp** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Changes** | [**List&lt;Change&gt;**](Change.html) |  | [optional] |
| **Entity** | [**AuditEntity**](AuditEntity.html) |  | [optional] |
{: class="table table-striped"}


