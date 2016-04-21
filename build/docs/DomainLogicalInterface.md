---
title: DomainLogicalInterface
---
## .DomainLogicalInterface

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **EdgeUri** | **string** |  | [optional] |
| **EdgeAssignedId** | **string** |  | [optional] |
| **FriendlyName** | **string** |  | [optional] |
| **VlanTagId** | **int?** |  | [optional] |
| **HardwareAddress** | **string** |  | [optional] |
| **PhysicalAdapterId** | **string** |  | [optional] |
| **IpAddress** | **string** |  | [optional] |
| **Gateway** | **string** |  | [optional] |
| **PrimaryDns** | **string** |  | [optional] |
| **SecondaryDns** | **string** |  | [optional] |
| **IfStatus** | **string** |  | [optional] |
| **Routes** | [**List&lt;DomainNetworkRoute&gt;**](DomainNetworkRoute.html) |  | [optional] |
| **Addresses** | [**List&lt;DomainNetworkAddress&gt;**](DomainNetworkAddress.html) |  | [optional] |
| **Ipv4Capabilities** | [**DomainCapabilities**](DomainCapabilities.html) |  | [optional] |
| **Ipv6Capabilities** | [**DomainCapabilities**](DomainCapabilities.html) |  | [optional] |
| **CurrentState** | **string** |  | [optional] |
| **LastModifiedUserId** | **string** |  | [optional] |
| **LastModifiedCorrelationId** | **string** |  | [optional] |
| **CommandResponses** | [**List&lt;DomainNetworkCommandResponse&gt;**](DomainNetworkCommandResponse.html) |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


