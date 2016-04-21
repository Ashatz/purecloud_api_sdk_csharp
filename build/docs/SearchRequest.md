---
title: SearchRequest
---
## .SearchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SearchPhrase** | **string** | The search text to look for | [optional] |
| **PageNumber** | **int?** | The pageNumber to get results from (EG If there are 100 results with a pageSize of 10 and pageNumber is 3 then 10 results will be returned starting with index #31 | [optional] |
| **PageSize** | **int?** | Number of entries to return/calculate per page. | [optional] |
| **SearchFields** | **List&lt;string&gt;** | The fields to limit the searchPhrase search to | [optional] |
| **FacetRequests** | [**List&lt;FacetRequest&gt;**](FacetRequest.html) | List of facet requests to generate summary views from the search result set (if any) | [optional] |
| **Sort** | [**List&lt;SortField&gt;**](SortField.html) | sort the results on a field(s) | [optional] |
| **Filters** | [**List&lt;FilterItem&gt;**](FilterItem.html) | You can also restrict the search to particular field values and ranges | [optional] |
{: class="table table-striped"}


