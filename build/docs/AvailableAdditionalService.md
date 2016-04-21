---
title: AvailableAdditionalService
---
## ININ.PureCloudApi.Model.AvailableAdditionalService

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | The description of this additional service. | |
| **PartNumber** | **string** | The part number of this additional service. | |
| **RequiredForProducts** | **List&lt;string&gt;** | The list of products which require this additional service. | |
| **AvailableForProducts** | **List&lt;string&gt;** | The list of products for which this additional service is available. | |
| **DefaultForProducts** | **List&lt;string&gt;** | The list of products which have this additional service by default. | |
| **ExclusiveFromProducts** | **List&lt;string&gt;** | The list of additional services which are not compatible with this additional service. | |
| **Rate** | [**Rate**](Rate.html) | The rate of this additional service. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


