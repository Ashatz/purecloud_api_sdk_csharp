---
title: OutboundRoute
---
## ININ.PureCloudApi.Model.OutboundRoute

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the entity. | |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **Site** | [**Site**](Site.html) | The site associated to the outbound route. | |
| **ClassificationTypes** | **List&lt;string&gt;** |  | [optional] |
| **Enabled** | **bool?** |  | [optional] [default to false]|
| **Distribution** | **string** |  | [optional] |
| **Managed** | **bool?** |  | [optional] [default to false]|
| **ExternalTrunkBases** | [**List&lt;UriReference&gt;**](UriReference.html) | Trunk base settings of trunkType \&quot;EXTERNAL\&quot;.  This base must also be set on an edge logical interface for correct routing. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


