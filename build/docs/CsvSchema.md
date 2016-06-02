---
title: CsvSchema
---
## ININ.PureCloudApi.Model.CsvSchema

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CarrierId** | **string** | Carrier ID associated with this CSV schema. | [optional] |
| **HeaderRow** | **int?** | Row number for the CSV&#39;s headers.  This is zero indexed (i.e. 0 is row 1). | |
| **DataRow** | **int?** | Row number of the first line of data.  This is zero indexed (i.e. 0 is row 1). | |
| **HeaderMappings** | **Dictionary&lt;string, string&gt;** | CSV header name to object name mappings. For example, \&quot;ROUTE_TEL_PREFIX\&quot; to \&quot;Prefix\&quot; might be one such mapping. | |
| **RateType** | **string** | Rate type for the sheet. | |
| **Name** | **string** | Human readable name for schema. | |
| **DateFormat** | **string** | A date format that represents the date time stamp you want to parse. This is based on the reference time of Mon Jan 2 15:04:05 MST 2006. For example, if you had the date 13-OCT-2015, this parameter should be 02-Jan-2006. As another example, if you have the date 2014-09-20, this parameter should be 2006-01-02. | [optional] |
{: class="table table-striped"}


