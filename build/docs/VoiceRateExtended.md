---
title: VoiceRateExtended
---
## .VoiceRateExtended

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Currency** | **string** | The ISO 4217 currency code of the voice rate. | |
| **AmendmentId** | **string** | The amendment Id of the voice rate. | |
| **Type** | **string** | The voice rate type. | |
| **EffectiveDate** | **DateTime?** | The effective date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **GroupName** | **string** | The group containing this area code. | |
| **AreaCode** | **string** | The area code. | |
| **DeletionMarker** | **bool?** | The deletion marker. | [default to false]|
| **OutboundRate** | **double?** | The outbound extended rate. | |
| **OutboundDurationMinimumSeconds** | **int?** | The minimum duration charged in seconds. | |
| **OutboundDurationIncrementSeconds** | **int?** | The billing duration increment in seconds. | |
| **InboundTolledRate** | **double?** | The inbound tolled rate. | |
| **InboundTolledDurationMinimumSeconds** | **int?** | The minimum duration charged in seconds. | |
| **InboundTolledDurationIncrementSeconds** | **int?** | The billing duration increment in seconds. | |
| **InboundTollFreeRate** | **double?** | The inbound toll-free rate. | |
| **InboundTollFreeDurationMinimumSeconds** | **int?** | The minimum duration charged in seconds. | |
| **InboundTollFreeDurationIncrementSeconds** | **int?** | The billing duration increment in seconds. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


