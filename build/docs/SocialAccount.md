---
title: SocialAccount
---
## ININ.PureCloudApi.Model.SocialAccount

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Enabled** | **bool?** | Indicates if this Social Account is available for selection by other entities | [optional] [default to false]|
| **Authorized** | **bool?** | True when successfully completing the third-party authorization process | [optional] [default to false]|
| **SocialHub** | **string** | Which third party Social Media Hub this account will be communicating through | [optional] |
| **AccessToken** | **string** | Credential provided through the Social Hub&#39;s authorization process | [optional] |
| **AccessTokenSecret** | **string** | Credential provided through the Social Hub&#39;s authorization process | [optional] |
| **TwitterId** | **string** | The account ID as provided by Twitter during the authorization process | [optional] |
| **StreamingEnabled** | **bool?** | Indicates if a stream should be opened on behalf of the indicated Social Hub account | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


