---
title: ForecastModificationCreation
---
## ININ.PureCloudApi.Model.ForecastModificationCreation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ForecastId** | **string** | The id of the associated forecast | |
| **Priority** | **int?** | The priority in which the modification is applied | |
| **Metric** | **string** | The metric the modification is appied to | |
| **ModificationType** | **string** | The type of modification | |
| **ModificationValue** | **double?** | The value of the modification | |
| **StartDate** | **DateTime?** | The start of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **EndDate** | **DateTime?** | The end of the modified time period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **Attributes** | [**ForecastFilterAttributes**](ForecastFilterAttributes.html) | The filters for the modification | |
| **Enabled** | **bool?** | Determined if the modification is currently applied | [default to false]|
| **Notes** | **string** | Any notes associated with the modification | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


