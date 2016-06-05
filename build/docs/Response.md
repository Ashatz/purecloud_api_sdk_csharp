---
title: Response
---
## ININ.PureCloudApi.Model.Response

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | Version number required for updates. | [optional] |
| **Libraries** | [**List&lt;UriReference&gt;**](UriReference.html) | One or more libraries response is associated with. | |
| **Texts** | [**List&lt;ResponseText&gt;**](ResponseText.html) | One or more texts associated with the response. | |
| **CreatedBy** | [**User**](User.html) | User that created the response | [optional] |
| **DateCreated** | **DateTime?** | The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **InteractionType** | **string** | The interaction type for this response. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


