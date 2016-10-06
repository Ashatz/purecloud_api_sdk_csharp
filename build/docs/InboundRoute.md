---
title: InboundRoute
---
## ININ.PureCloudApi.Model.InboundRoute

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Pattern** | **string** | The search pattern that the mailbox name should match. | |
| **Queue** | [**UriReference**](UriReference.html) | The queue to route the emails to. | [optional] |
| **Priority** | **int?** | The priority to use for routing. | [optional] |
| **Skills** | [**List&lt;UriReference&gt;**](UriReference.html) | The skills to use for routing. | [optional] |
| **Language** | [**UriReference**](UriReference.html) | The language to use for routing. | [optional] |
| **FromName** | **string** | The sender name to use for outgoing replies. | |
| **FromEmail** | **string** | The sender email to use for outgoing replies. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


