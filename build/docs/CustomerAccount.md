---
title: CustomerAccount
---
## .CustomerAccount

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **IsFrozen** | **bool?** | Indicates whether the account is currently frozen for review. | [default to false]|
| **OrgLegalName** | **string** | The organization legal name. | |
| **OrgPhone** | **string** | The organization phone number. | |
| **IsTaxExempt** | **bool?** | Indicates whether the account is tax exempt. | [default to false]|
| **BillingAddress** | [**Address**](Address.html) | The account billing address. | |
| **Currency** | **string** | The account currency. | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


