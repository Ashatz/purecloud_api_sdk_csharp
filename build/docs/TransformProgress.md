---
title: TransformProgress
---
## .TransformProgress

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Service** | **string** | Name of this service | [optional] |
| **User** | [**User**](User.html) | User unique identifier | [optional] |
| **UploadTime** | **DateTime?** | Time when file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Filename** | **string** | Name of the file being parsed | [optional] |
| **Tags** | [**List&lt;TagModel&gt;**](TagModel.html) | Tag matching for searching transformation schemas in use | [optional] |
| **Progress** | [**ProgressModel**](ProgressModel.html) | State of parsing progress for this upload transformation | [optional] |
| **Model** | [**TransformModel**](TransformModel.html) | ID of the ratesheet | [optional] |
| **Errors** | [**List&lt;ErrorBody&gt;**](ErrorBody.html) | Errors encountered during parsing | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


