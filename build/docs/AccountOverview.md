---
title: AccountOverview
---
## ININ.PureCloudApi.Model.AccountOverview

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **IsSuperUser** | **bool?** |  | [optional] [default to false]|
| **HasAccountNumber** | **bool?** |  | [optional] [default to false]|
| **UsageCharges** | [**List&lt;Charge&gt;**](Charge.html) |  | [optional] |
| **DomesticChargesTotal** | **int?** |  | [optional] |
| **InternationalChargesTotal** | **int?** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


