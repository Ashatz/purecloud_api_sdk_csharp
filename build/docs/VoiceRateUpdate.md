---
title: VoiceRateUpdate
---
## .VoiceRateUpdate

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Currency** | **string** | The ISO 4217 currency code of the voice rate. | |
| **InboundTollFree** | [**VoiceRate**](VoiceRate.html) | The inbound toll free rate. | [optional] |
| **Extended** | [**List&lt;VoiceRateExtended&gt;**](VoiceRateExtended.html) | The domestic extended rates. | [optional] |
| **InboundTolled** | [**VoiceRate**](VoiceRate.html) | The inbound tolled rate. | [optional] |
| **OutboundLocal** | [**VoiceRate**](VoiceRate.html) | The outbound local rate. | [optional] |
| **OutboundIntraState** | [**VoiceRate**](VoiceRate.html) | The outbound intra-state rate. | [optional] |
| **OutboundInterState** | [**VoiceRate**](VoiceRate.html) | The outbound inter-state rate. | [optional] |
| **OutboundInternational** | [**List&lt;VoiceRateInternational&gt;**](VoiceRateInternational.html) | The outbound international rates. | [optional] |
| **AmendmentDate** | **DateTime?** | The date of the rate amendment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **EffectiveDate** | **DateTime?** | The effective date of the rate amendment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


