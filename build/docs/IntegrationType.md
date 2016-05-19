---
title: IntegrationType
---
## ININ.PureCloudApi.Model.IntegrationType

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** | Localized description of the integration type. | |
| **Provider** | **string** | PureCloud provider of the integration type. | |
| **Images** | [**List&lt;UserImage&gt;**](UserImage.html) | Collection of logos. | |
| **ConfigPropertiesSchemaUri** | **string** | URI of the schema describing the key-value properties needed to configure an integration of this type. | [optional] |
| **ConfigAdvancedSchemaUri** | **string** | URI of the schema describing the advanced JSON document needed to configure an integration of this type. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


