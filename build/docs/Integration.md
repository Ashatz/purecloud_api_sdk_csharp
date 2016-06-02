---
title: Integration
---
## ININ.PureCloudApi.Model.Integration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **IntegrationType** | [**IntegrationType**](IntegrationType.html) | Type of the integration. | |
| **State** | **string** | Configured state of the integration. | [optional] |
| **Config** | [**IntegrationConfiguration**](IntegrationConfiguration.html) | Configuration for the integration. | [optional] |
| **LastStatus** | [**IntegrationStatusInfo**](IntegrationStatusInfo.html) | Last reported status of the integration. | [optional] |
| **Version** | **int?** | Version number required for updates. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


