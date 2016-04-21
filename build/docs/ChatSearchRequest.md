---
title: ChatSearchRequest
---
## .ChatSearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Query** | **string** | Search terms can be AND&#39;d together. Example: foo AND bar | |
| **Order** | **string** | Sort order of results by score or most recent. Default is by score | |
| **TargetJids** | **List&lt;string&gt;** | A list of XMPP JIDs to consider. Default is all permissible JIDs. A permissible JID is defined as any JID of a person with whom you have chatted, or any group in which you are currently a member. | [optional] |
| **PageSize** | **int?** | The maximum number of hits to receive in the response. Default: 10, Maximum: 50] | [optional] |
| **PageNumber** | **int?** | The number of hits to skip before returning results. Default: 0 | [optional] |
| **FromDate** | **DateTime?** | Consider hits after this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ToDate** | **DateTime?** | Consider hits before this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Expand** | **string** | Expand the &#39;to&#39; or &#39;from&#39; user details. | [optional] |
{: class="table table-striped"}


