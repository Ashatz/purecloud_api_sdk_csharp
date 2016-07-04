---
title: Quote
---
## ININ.PureCloudApi.Model.Quote

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **PurchaseOrder** | **string** | Purchase order | |
| **Type** | **string** | Quote type | |
| **Status** | **string** | Quote Status | |
| **Currency** | **string** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **LastUpdatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **BillingContactEmail** | **string** |  | [optional] |
| **BillingContactFirstName** | **string** |  | [optional] |
| **BillingContactLastName** | **string** |  | [optional] |
| **BillingContactPhone** | **string** |  | [optional] |
| **IncludeVoiceCharges** | **bool?** |  | [optional] [default to false]|
| **Charges** | [**List&lt;QuoteCharge&gt;**](QuoteCharge.html) |  | [optional] |
| **EdgeControlModel** | **string** |  | [optional] |
| **ReferralCodes** | **List&lt;string&gt;** |  | [optional] |
| **DiscountCodes** | **List&lt;string&gt;** |  | [optional] |
| **SalesPartnerCode** | **string** |  | [optional] |
| **IsAnnualPrepay** | **bool?** |  | [optional] [default to false]|
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


