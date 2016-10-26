---
title: Forecast
---
## ININ.PureCloudApi.Model.Forecast

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metadata** | [**ForecastMetadata**](ForecastMetadata.html) | The metadata of the forecast | [optional] |
| **StartDate** | **DateTime?** | The start date time of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ForecastEntries** | [**List&lt;ForecastEntry&gt;**](ForecastEntry.html) | The entries of forecasted values and their dimensions | [optional] |
| **ErrorMessage** | **string** | The error happening when producing the forecasts | [optional] |
{: class="table table-striped"}


