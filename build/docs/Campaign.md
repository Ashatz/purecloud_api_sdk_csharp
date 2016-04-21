---
title: Campaign
---
## ININ.PureCloudApi.Model.Campaign

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** |  | [optional] |
| **ContactList** | [**UriReference**](UriReference.html) |  | [optional] |
| **Queue** | [**UriReference**](UriReference.html) |  | [optional] |
| **DialingMode** | **string** |  | [optional] |
| **Script** | [**UriReference**](UriReference.html) |  | [optional] |
| **EdgeGroup** | [**UriReference**](UriReference.html) |  | [optional] |
| **CampaignStatus** | **string** |  | [optional] |
| **PhoneColumns** | [**List&lt;PhoneColumn&gt;**](PhoneColumn.html) |  | [optional] |
| **AbandonRate** | **double?** |  | [optional] |
| **DncLists** | [**List&lt;UriReference&gt;**](UriReference.html) |  | [optional] |
| **CallableTimeSet** | [**UriReference**](UriReference.html) |  | [optional] |
| **CallAnalysisResponseSet** | [**UriReference**](UriReference.html) |  | [optional] |
| **Errors** | [**List&lt;RestErrorDetail&gt;**](RestErrorDetail.html) |  | [optional] |
| **CallerName** | **string** |  | [optional] |
| **CallerAddress** | **string** |  | [optional] |
| **OutboundLineCount** | **int?** |  | [optional] |
| **RuleSets** | [**List&lt;UriReference&gt;**](UriReference.html) |  | [optional] |
| **SkipPreviewDisabled** | **bool?** |  | [optional] [default to false]|
| **PreviewTimeOutSeconds** | **long?** |  | [optional] |
| **SingleNumberPreview** | **bool?** |  | [optional] [default to false]|
| **ContactSort** | [**ContactSort**](ContactSort.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


