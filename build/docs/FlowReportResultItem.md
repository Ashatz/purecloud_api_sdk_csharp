---
title: FlowReportResultItem
---
## ININ.PureCloudApi.Model.FlowReportResultItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FlowExecId** | [**FlowExecId**](FlowExecId.html) | The flow instance ID for this process | |
| **FlowConfigId** | [**FlowConfigId**](FlowConfigId.html) | The flow config ID that this workitem was created from. | |
| **FlowInstanceName** | **string** | The instance name for this flow in relation to its primary document.  If the flow is not a document-centric type, this value will be empty. | [optional] |
| **AssociatedDocument** | [**AssociatedDocument**](AssociatedDocument.html) | the document for this flow (if this flow was launched via a document) | [optional] |
| **FlowStatus** | **string** | The flow&#39;s running status, which indicates whether the flow is running normally or in error, etc; | [optional] |
| **CurrentState** | **string** | The current state of the flow (EG what action is being processed) | |
| **StartDateTime** | **DateTime?** | The time the flow was started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **EndDateTime** | **DateTime?** | The time the flow ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **WorkItemUserAssignees** | [**List&lt;User&gt;**](User.html) | List of users currently assigned to a workItem | [optional] |
| **CompletedUser** | [**User**](User.html) | User that completed the flow | [optional] |
| **CompletionReason** | **string** | Reason for completion | [optional] |
| **FlowErrorInfo** | [**ErrorBody**](ErrorBody.html) | Additional information if the flow is in error | [optional] |
{: class="table table-striped"}


