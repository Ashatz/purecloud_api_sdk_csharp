---
title: DomainLogicalInterface
---
## ININ.PureCloudApi.Model.DomainLogicalInterface

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
| **FriendlyName** | **string** | Friendly Name | |
| **VlanTagId** | **int?** |  | [optional] |
| **HardwareAddress** | **string** | Hardware Address | |
| **PhysicalAdapterId** | **string** | Physical Adapter Id | |
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
| **InheritPhoneTrunkBases** | **bool?** | Phone trunk base assignment will be inherited from the Edge Group. | [optional] [default to false]|
| **InheritPhoneTrunkBasesIPv4** | **bool?** | The IPv4 phone trunk base assignment will be inherited from the Edge Group. | [optional] [default to false]|
| **InheritPhoneTrunkBasesIPv6** | **bool?** | The IPv6 phone trunk base assignment will be inherited from the Edge Group. | [optional] [default to false]|
| **UseForInternalEdgeCommunication** | **bool?** | This interface will be used for all internal edge-to-edge communication using settings from the edgeTrunkBaseAssignment on the Edge Group. | [optional] [default to false]|
| **ExternalTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | External trunk base settings to use for external communication from this interface. | [optional] |
| **PhoneTrunkBaseAssignments** | [**List&lt;TrunkBaseAssignment&gt;**](TrunkBaseAssignment.html) | Phone trunk base settings to use for phone communication from this interface.  These settings will be ignored when \&quot;inheritPhoneTrunkBases\&quot; is true. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


