---
title: AuditMessage
---
## ININ.PureCloudApi.Model.AuditMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **User** | [**AuditUser**](AuditUser.html) |  | [optional] |
| **CorrelationId** | **string** |  | [optional] |
| **TransactionId** | **string** |  | [optional] |
| **TransactionInitiator** | **bool?** |  | [optional] [default to false]|
| **Application** | **string** |  | [optional] |
| **ServiceName** | **string** |  | [optional] |
| **Level** | **string** |  | [optional] |
| **Timestamp** | **string** |  | [optional] |
| **ReceivedTimestamp** | **string** |  | [optional] |
| **Status** | **string** |  | [optional] |
| **ActionContext** | **string** |  | [optional] |
| **Action** | **string** |  | [optional] |
| **Changes** | [**List&lt;Change&gt;**](Change.html) |  | [optional] |
| **Entity** | [**AuditEntity**](AuditEntity.html) |  | [optional] |
| **ServiceContext** | [**ServiceContext**](ServiceContext.html) |  | [optional] |
{: class="table table-striped"}


