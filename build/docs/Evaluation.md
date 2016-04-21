---
title: Evaluation
---
## ININ.PureCloudApi.Model.Evaluation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**Conversation**](Conversation.html) |  | [optional] |
| **EvaluationForm** | [**EvaluationForm**](EvaluationForm.html) | Evaluation form used for evaluation. | [optional] |
| **Evaluator** | [**User**](User.html) |  | [optional] |
| **Agent** | [**User**](User.html) |  | [optional] |
| **Calibration** | [**Calibration**](Calibration.html) |  | [optional] |
| **Status** | **string** |  | [optional] |
| **Answers** | [**EvaluationScoringSet**](EvaluationScoringSet.html) |  | [optional] |
| **AgentHasRead** | **bool?** |  | [optional] [default to false]|
| **ReleaseDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **AssignedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ChangedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Queue** | [**Queue**](Queue.html) |  | [optional] |
| **ResourceId** | **string** | Only used for email evaluations. Will be null for all other evaluations. | [optional] |
| **ResourceType** | **string** | The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources. | [optional] |
| **Redacted** | **bool?** | Is only true when the user making the request does not have sufficient permissions to see evaluation | [optional] [default to false]|
| **IsScoringIndex** | **bool?** |  | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


