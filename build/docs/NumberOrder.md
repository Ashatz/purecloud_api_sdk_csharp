---
title: NumberOrder
---
## ININ.PureCloudApi.Model.NumberOrder

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Did** | **string** | DID purchased | [optional] |
| **EffectiveStartDate** | **DateTime?** | Effective date of service for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EffectiveEndDate** | **DateTime?** | Effective disconnection date for this order. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LastUpdated** | **DateTime?** | Date of last update. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **StartAuthUserId** | **string** | UserId authorizing purchase | [optional] |
| **EndAuthUserId** | **string** | UserId authorizing disconnection | [optional] |
| **Status** | **string** | Current status of this DID order | [optional] |
| **PhoneNumberType** | **string** | Class of DID being purchased (eg. us-domestic, toll-free, etc) | [optional] |
| **Porting** | **bool?** | Whether or not the number was ported | [optional] [default to false]|
| **BillingAddress** | [**PortBillingAddress**](PortBillingAddress.html) | Billing address used for a number port | [optional] |
| **ResponsibleContact** | [**PortContact**](PortContact.html) | Company contact for a number port | [optional] |
| **CompanyName** | **string** | Company name for a number port | [optional] |
| **CountryCode** | **string** | Country dial in codes (telephone dialing prefixes) | [optional] |
| **EnvelopeId** | **string** | Id of the terms and conditions envelope for the order. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


