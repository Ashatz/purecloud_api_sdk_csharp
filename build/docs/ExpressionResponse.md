---
title: ExpressionResponse
---
## ININ.PureCloudApi.Model.ExpressionResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SocialHub** | **string** | The name of the social hub. | [optional] |
| **Conversation** | [**Conversation**](Conversation.html) | The conversation that this response is a part of. | [optional] |
| **TwitterExpression** | [**TwitterExpression**](TwitterExpression.html) | The twitter expression that this is in response to. | [optional] |
| **RawResponseText** | **string** | The raw text of the response. | [optional] |
| **SocialAccount** | [**SocialAccount**](SocialAccount.html) | The Social Account used to publish this expression | [optional] |
| **SocialHubResponseId** | **string** | The id given to this response from the social hub | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


