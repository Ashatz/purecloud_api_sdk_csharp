---
title: PublishedExpression
---
## .PublishedExpression

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SocialHub** | **string** | The name of the social hub. | [optional] |
| **TwitterExpression** | [**TwitterExpression**](TwitterExpression.html) | Once this expression is published, the Social Hub returns a resulting twitterExpression object. | [optional] |
| **PublicationParentId** | **string** | When this expression is used by the Direct Publishing feature, this is our internal id of the Publication that generated this published expression | [optional] |
| **ScheduleDate** | **DateTime?** | Used by the Scheduling feature:  The date that this expression should be published through the Social Hub. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **PublishedDate** | **DateTime?** | The date this expression was published through the Social Hub. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SocialAccount** | [**SocialAccount**](SocialAccount.html) | The Social Account used to publish this expression | [optional] |
| **TwitterId** | **string** | When replying to an existing tweet:  Twitter&#39;s id of the tweet that this expression was replying to | [optional] |
| **Retweets** | **int?** | The number of times this published expression has been retweeted. | [optional] |
| **Replies** | **List&lt;string&gt;** | A collection of Twitter Tweet Id&#39;s that have replied to this published expression | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


