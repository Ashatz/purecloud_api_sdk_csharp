---
title: WorkItemDetails
---
## ININ.PureCloudApi.Model.WorkItemDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **WorkItemDefinition** | [**WorkItemDefinition**](WorkItemDefinition.html) |  | [optional] |
| **FlowExecId** | [**FlowExecId**](FlowExecId.html) | The flow instance ID that created this WorkItem | |
| **FlowConfigId** | [**FlowConfigId**](FlowConfigId.html) | The flow config ID that this workitem was created from. | |
| **FlowCreateTime** | **DateTime?** | The time the flow was started. (that created this workitem). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **CreateTime** | **DateTime?** | The time this workitem was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **Owner** | [**User**](User.html) | The user currently working on/has responsibility for this WorkItem.  May be null if no owner. | [optional] |
| **OfferedToUsers** | [**List&lt;User&gt;**](User.html) | List of users that this workItem is offered to.  May be null if only offered to queues. | [optional] |
| **OfferedToQueues** | [**List&lt;Queue&gt;**](Queue.html) | List of queues that this workItem is offered to.  May be null if only offered to users. | [optional] |
| **Title** | **string** | The work item title | [optional] |
| **Subtitle** | **string** | The work item&#39;s subtitle - 2nd line/description | [optional] |
| **AssociatedDocuments** | [**List&lt;AssociatedDocument&gt;**](AssociatedDocument.html) | The documents associated with this workitem | [optional] |
| **AvailableActions** | [**WorkItemActions**](WorkItemActions.html) | The actions that the user can take on this workitem (submit, transfer, etc). | [optional] |
| **DataValueInfo** | [**DataValueInfo**](DataValueInfo.html) | The data items that provide values for any work item form elements, if applicable. | [optional] |
| **WorkItemCache** | [**WorkItemCache**](WorkItemCache.html) | The data items in the current work item cache, if one exists. | [optional] |
| **LastOfferedTime** | **DateTime?** | The time this work item was last offered to a user or queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LastOwnershipUpdateTime** | **DateTime?** | The most recent time a user assumed ownership of a work item. This may be blank if the work item has no owner. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CurrentTaskStartTime** | **DateTime?** | This is the time when the current task that started the work item was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


