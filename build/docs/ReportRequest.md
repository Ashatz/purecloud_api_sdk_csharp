---
title: ReportRequest
---
## .ReportRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **PageNumber** | **int?** | The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31 | [optional] |
| **PageSize** | **int?** | Number of entries to return/calculate per page. | [optional] |
| **FacetRequests** | [**List&lt;FacetRequest&gt;**](FacetRequest.html) | List of facet requests to generate summary views from the report result set (if any) | [optional] |
| **Sort** | [**List&lt;SortField&gt;**](SortField.html) | sort the results on a field(s) | [optional] |
| **Filters** | [**List&lt;FilterItem&gt;**](FilterItem.html) | You can also restrict the request to particular field values and ranges | [optional] |
| **GroupBy** | **List&lt;string&gt;** |  | [optional] |
{: class="table table-striped"}


