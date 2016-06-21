---
title: TwitterExpression
---
## ININ.PureCloudApi.Model.TwitterExpression

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation date for the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date the entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **IsDispositioned** | **bool?** | True once the expression has been dispositioned by an agent through the ACD process | [optional] [default to false]|
| **IsNoise** | **bool?** | Indicates if a user/agent found this expression to be undesirable | [optional] [default to false]|
| **Gistener** | [**Gistener**](Gistener.html) | The Gistener that generated this expression | |
| **TweetId** | **string** | Twitter: the tweet&#39;s unique id | |
| **Text** | **string** | Twitter: the tweets full text | |
| **TweetCreated** | **DateTime?** | Twitter: the date the tweet was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **IsReply** | **bool?** | Twitter: indicates this tweet as a reply to another tweet | [optional] [default to false]|
| **IsRetweet** | **bool?** | Twitter: indicates this tweet as a &#39;retweet&#39; of another tweet | [optional] [default to false]|
| **RetweetParentId** | **string** | Twitter: when the expression is a retweet, this is Twitter&#39;s id of the original tweet | [optional] |
| **RetweetCount** | **int?** | Twitter: the number of times the parent tweet was retweeted - at the time this expression was created | [optional] |
| **IsQuotedTweet** | **bool?** | Twitter: indicates this expression as a quoted tweet (a tweet with an addendum as the primary text) | [optional] [default to false]|
| **QuotedParentId** | **string** | Twitter: when the expression is a quoted tweet, this is Twitter&#39;s id of the original tweet (may not be immediately functional) | [optional] |
| **UserId** | **string** | Twitter: the expressing user&#39;s Twitter id | [optional] |
| **UserName** | **string** | Twitter: the user&#39;s account name for the core service | |
| **UserScreenName** | **string** | Twitter: the user&#39;s custom &#39;branding&#39; name (allowed to change over time) | [optional] |
| **UserTweetCount** | **int?** | Twitter: the number of times this user has tweeted (includes all forms of expression replies/quotes/retweets) | [optional] |
| **UserFollowersCount** | **int?** | Twitter: the number of followers this user has at the time of this expression | [optional] |
| **GroupTags** | [**List&lt;GroupTag&gt;**](GroupTag.html) | The Group Tags applied by the generating Gistener | [optional] |
| **Routed** | **bool?** |  | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


