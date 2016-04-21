---
title: Service
---
## ININ.PureCloudApi.Model.Service

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Status** | **string** |  | [optional] |
| **Domains** | **List&lt;string&gt;** | An inbound carrier specific domain (i.e. lb.domain.com) | [optional] |
| **ServiceTypes** | [**List&lt;ServiceType&gt;**](ServiceType.html) |  | [optional] |
| **Gateways** | [**List&lt;Gateway&gt;**](Gateway.html) |  | [optional] |
| **Dns** | [**Dns**](Dns.html) |  | [optional] |
| **Vpn** | [**Vpn**](Vpn.html) |  | [optional] |
| **Carrier** | [**Carrier**](Carrier.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


