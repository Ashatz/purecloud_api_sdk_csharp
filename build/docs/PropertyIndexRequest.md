---
title: PropertyIndexRequest
---
## ININ.PureCloudApi.Model.PropertyIndexRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **SessionId** | **string** | Attach properties to a segment in the indicated session. Also requires a timestamp. | [optional] |
| **Timestamp** | **long?** | Attach properties to a segment covering a specific point in time. Also requries a sessionId. | [optional] |
| **Properties** | [**List&lt;AnalyticsProperty&gt;**](AnalyticsProperty.html) | The list of properties to index | |
{: class="table table-striped"}


