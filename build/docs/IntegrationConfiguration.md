---
title: IntegrationConfiguration
---
## ININ.PureCloudApi.Model.IntegrationConfiguration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Version** | **int?** | Version number required for updates. | [optional] |
| **PropertiesSchemaUri** | **string** | URI for the JSON Schema describing the configuration properties in the properties field. | [optional] |
| **AdvancedSchemaUri** | **string** | URI for the JSON Schema describing the advanced configuration | [optional] |
| **Properties** | **Object** | Key-value configuration settings described by the schema in the propertiesSchemaUri field. | [optional] |
| **Advanced** | **Object** | Advanced configuration described by the schema in the advancedSchemaUri field. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


