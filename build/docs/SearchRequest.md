---
title: SearchRequest
---
## ININ.PureCloudApi.Model.SearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SortOrder** | **string** |  | [optional] |
| **SortBy** | **string** |  | [optional] |
| **PageSize** | **int?** |  | [optional] |
| **PageNumber** | **int?** |  | [optional] |
| **ReturnFields** | **List&lt;string&gt;** |  | [optional] |
| **Expand** | **List&lt;string&gt;** |  | [optional] |
| **Types** | **List&lt;string&gt;** | Resource Domain type | |
| **Query** | [**List&lt;SearchCriteria&gt;**](SearchCriteria.html) |  | [optional] |
| **Aggregations** | [**List&lt;SearchAggregation&gt;**](SearchAggregation.html) |  | [optional] |
{: class="table table-striped"}


