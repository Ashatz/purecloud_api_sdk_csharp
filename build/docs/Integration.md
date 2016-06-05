---
title: Integration
---
## ININ.PureCloudApi.Model.Integration

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the integration, used to distinguish this integration from others of the same type. | |
| **IntegrationType** | [**IntegrationType**](IntegrationType.html) | Type of the integration | [optional] |
| **State** | **string** | Configured state of the integration. | |
| **Config** | [**IntegrationConfiguration**](IntegrationConfiguration.html) | Configuration for the integration. | [optional] |
| **LastStatus** | [**IntegrationStatusInfo**](IntegrationStatusInfo.html) | Last reported status of the integration. | [optional] |
| **Version** | **int?** | Version number required for updates. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


