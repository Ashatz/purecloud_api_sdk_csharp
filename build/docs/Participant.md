---
title: Participant
---
## .Participant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **StartTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Name** | **string** |  | [optional] |
| **UserUri** | **string** |  | [optional] |
| **UserId** | **string** |  | [optional] |
| **QueueId** | **string** |  | [optional] |
| **GroupId** | **string** |  | [optional] |
| **QueueName** | **string** |  | [optional] |
| **Purpose** | **string** |  | [optional] |
| **ParticipantType** | **string** |  | [optional] |
| **ConsultParticipantId** | **string** |  | [optional] |
| **Address** | **string** |  | [optional] |
| **Ani** | **string** |  | [optional] |
| **Dnis** | **string** |  | [optional] |
| **Locale** | **string** |  | [optional] |
| **WrapupRequired** | **bool?** |  | [optional] [default to false]|
| **WrapupExpected** | **bool?** |  | [optional] [default to false]|
| **WrapupPrompt** | **string** |  | [optional] |
| **WrapupTimeoutMs** | **int?** |  | [optional] |
| **WrapupSkipped** | **bool?** |  | [optional] [default to false]|
| **Wrapup** | [**Wrapup**](Wrapup.html) |  | [optional] |
| **MonitoredParticipantId** | **string** |  | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** |  | [optional] |
| **Calls** | [**List&lt;Call&gt;**](Call.html) |  | [optional] |
| **Chats** | [**List&lt;Chat&gt;**](Chat.html) |  | [optional] |
| **Emails** | [**List&lt;Email&gt;**](Email.html) |  | [optional] |
| **SocialExpressions** | [**List&lt;SocialExpression&gt;**](SocialExpression.html) |  | [optional] |
| **Videos** | [**List&lt;Video&gt;**](Video.html) |  | [optional] |
| **Evaluations** | [**List&lt;Evaluation&gt;**](Evaluation.html) |  | [optional] |
{: class="table table-striped"}


