---
title: ConversationQueryResponse
---
## .ConversationQueryResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageSize** | **int?** |  | [optional] |
| **PageNumber** | **int?** |  | [optional] |
| **Total** | **long?** |  | [optional] |
| **Entities** | [**List&lt;Conversation&gt;**](Conversation.html) |  | [optional] |
| **HasMorePrev** | **bool?** |  | [optional] [default to false]|
| **HasMoreNext** | **bool?** |  | [optional] [default to false]|
| **StartQueryTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndQueryTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **NewestResultTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **OldestResultTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **TimeMs** | **long?** |  | [optional] |
| **Iterations** | **int?** |  | [optional] |
| **Anchor** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Sort** | **string** |  | [optional] |
| **Facets** | [**Facets**](Facets.html) |  | [optional] |
| **SelfUri** | **string** |  | [optional] |
| **PreviousUri** | **string** |  | [optional] |
| **NextUri** | **string** |  | [optional] |
| **FirstUri** | **string** |  | [optional] |
| **LastUri** | **string** |  | [optional] |
| **PageCount** | **int?** |  | [optional] |
{: class="table table-striped"}


