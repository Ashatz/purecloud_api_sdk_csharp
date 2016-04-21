---
title: QuoteCharge
---
## .QuoteCharge

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The quote charge Id. | |
| **Sku** | **string** | The quote charge SKU. | |
| **Name** | **string** | The quote charge name. | |
| **ChargeType** | **string** | The quote charge type. | |
| **Quantity** | **int?** | The quote charge quantity. | |
| **ListTotal** | **string** | The quote charge total price before discounts. | |
| **Total** | **string** | The quote charge total price after discounts. | |
| **ListPriceDisplay** | **string** | The quote charge list price before discounts. | |
| **Discount** | **string** | The quote charge discount percent. | |
| **EffectivePrice** | **string** | The quote charge list price after discounts. | |
| **ProductShippable** | **bool?** | Indicates whether the product can be shipped. | [default to false]|
| **ShippingAddress** | [**Address**](Address.html) | The quote shipping address. | |
| **ForRelatedPart** | **string** | The part number of a part related to the quote charge. | [optional] |
{: class="table table-striped"}


