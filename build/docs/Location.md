---
title: Location
---
## ININ.PureCloudApi.Model.Location

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Address** | **string** |  | [optional] |
| **AddressFields** | [**LocationAddressFields**](LocationAddressFields.html) |  | [optional] |
| **AddressVerified** | **bool?** |  | [optional] [default to false]|
| **EmergencyNumber** | [**LocationEmergencyNumber**](LocationEmergencyNumber.html) |  | [optional] |
| **Notes** | **string** |  | [optional] |
| **Path** | **List&lt;string&gt;** |  | [optional] |
| **State** | **string** | Current activity status of the location. | [optional] |
| **SublocationOrder** | **List&lt;string&gt;** |  | [optional] |
| **Version** | **double?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


