---
title: FacetRequest
---
## .FacetRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** | name of the facet request that will be returned with the result set | |
| **FacetRequestQueryType** | **string** | Which facet request type | |
| **FieldName** | **string** | The fieldName to perform the facet request on. | |
| **Type** | **string** | the fieldtype of the field to perform the facet request on. | [optional] |
| **RangeFrom** | **string** | For RANGE requests populate this field to specify the beginning of a limit (leave blank for openended).  Note this value is inclusive of the results.  (EG if the value is 1, 1 will be included in the range.) | [optional] |
| **RangeTo** | **string** | For RANGE requests populate this field to specify the end of a limit (leave blank for openended).  Note this value is EXCLUSIVE of the result (EG if this value was 5, only values LESS THAN 5 will be included in the count.) | [optional] |
| **MaxFacetCount** | **int?** | Limits/expands the number of facet entries returned (default 500) | [optional] |
{: class="table table-striped"}


