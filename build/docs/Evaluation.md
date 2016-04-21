---
title: Evaluation
---
## .Evaluation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**Conversation**](Conversation.html) |  | [optional] |
| **EvaluationForm** | [**EvaluationForm**](EvaluationForm.html) |  | [optional] |
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
| **Redacted** | **bool?** |  | [optional] [default to false]|
| **IsScoringIndex** | **bool?** |  | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


