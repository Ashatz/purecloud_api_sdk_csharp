---
title: FlowDetails
---
## .FlowDetails

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **FlowConfigId** | [**FlowConfigId**](FlowConfigId.html) | The FlowConfigId that was used to launch this flow. | |
| **LaunchTime** | **DateTime?** | The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **LaunchType** | **string** | The launch mode for this flow instance. | |
| **LaunchedBy** | [**User**](User.html) | The user who launched the flow, if the flow was launched as the result of that user&#39;s action. | [optional] |
| **Status** | **string** | The flow&#39;s running status, which indicates whether the flow is running normally or completed, etc. | [optional] |
| **AssociatedDocuments** | [**List&lt;AssociatedDocument&gt;**](AssociatedDocument.html) | The documents associated with this flow. | [optional] |
| **FlowCompletionTime** | **DateTime?** | The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **FlowCompletionReason** | **string** | The completion reason set at the flow completion time, if applicable. | [optional] |
| **FlowErrorInfo** | [**ErrorBody**](ErrorBody.html) | Additional information if the flow is in error | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


