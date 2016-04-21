---
title: Gistener
---
## .Gistener

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Enabled** | **bool?** | Indicates if this Gistener may be utilized on another entity | [optional] [default to false]|
| **AnyWords** | **string** | A tweet must contain any one of these words | [optional] |
| **AllWords** | **string** | A tweet must contain every one of these words in any order | [optional] |
| **ExcludeWords** | **string** | If a tweet contains any one of these words, it is thrown out | [optional] |
| **ExactPhrase** | **string** | A tweet must contain this exact quoted phrase | [optional] |
| **GroupTags** | [**List&lt;GroupTag&gt;**](GroupTag.html) | The group tags associated with this Gistener | [optional] |
| **SocialAccount** | [**SocialAccount**](SocialAccount.html) | The social account associated with this Gistener | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


