---
title: DomainEdgeSoftwareUpdateDto
---
## ININ.PureCloudApi.Model.DomainEdgeSoftwareUpdateDto

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Version** | [**DomainEdgeSoftwareVersionDto**](DomainEdgeSoftwareVersionDto.html) |  | [optional] |
| **MaxDownloadRate** | **int?** |  | [optional] |
| **DownloadStartTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ExecuteStartTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ExecuteStopTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ExecuteOnIdle** | **bool?** |  | [optional] [default to false]|
| **Status** | **string** |  | [optional] |
| **EdgeUri** | **string** |  | [optional] |
| **Current** | **bool?** |  | [optional] [default to false]|
{: class="table table-striped"}


