---
title: UploadProgress
---
## ININ.PureCloudApi.Model.UploadProgress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **CarrierId** | **string** | Carrier id associated with the ratesheet that was uploaded. | [optional] |
| **SchemaName** | **string** | Human readable name for the schema that was used to parse the ratesheet. | [optional] |
| **Status** | **string** | Human readable status for progress of the ratesheet upload. This may be an error, the number of rates upload, or a completion message. | [optional] |
| **Filename** | **string** | Filename of the ratesheet that was uploaded by the user. | [optional] |
| **Filetype** | **string** | Media type of the file. | [optional] |
| **Created** | **DateTime?** | Time at which the uploaded ratesheet was started to be parsed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Updated** | **DateTime?** | Time at which the progress of the upload was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


