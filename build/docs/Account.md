---
title: Account
---
## ININ.PureCloudApi.Model.Account

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **OrgLegalName** | **string** | Org legal name | |
| **BillingAddressLine1** | **string** | Billing Address | |
| **BillingAddressLine2** | **string** |  | [optional] |
| **BillingAddressCity** | **string** | Billing City | |
| **BillingAddressState** | **string** | Billing State | |
| **BillingAddressZipCode** | **string** | Billing ZipCode | |
| **BillingAddressCountry** | **string** | Billing Country | |
| **LegalAddressLine1** | **string** |  | [optional] |
| **LegalAddressLine2** | **string** |  | [optional] |
| **LegalAddressCity** | **string** |  | [optional] |
| **LegalAddressState** | **string** |  | [optional] |
| **LegalAddressZipCode** | **string** |  | [optional] |
| **LegalAddressCountry** | **string** |  | [optional] |
| **BillingContactFirstName** | **string** | Billing Contact first name. | |
| **BillingContactLastName** | **string** | Billing Contact last name. | |
| **BillingContactEmail** | **string** | Billing Contact email. | |
| **BillingContactPhone** | **string** | Billing Contact phone | |
| **PurchaseOrderNumber** | **string** |  | [optional] |
| **IsTaxExempt** | **bool?** |  | [optional] [default to false]|
| **Currency** | **string** |  | [optional] |
| **PaymentTerm** | **string** | Payment Term | |
| **ContractTerm** | **int?** | Contract Term | |
| **AutoRenew** | **bool?** |  | [optional] [default to false]|
| **Enabled** | **bool?** |  | [optional] [default to false]|
| **MinCommitQuantities** | **Dictionary&lt;string, int?&gt;** |  | [optional] |
| **EstimatedQuantities** | **Dictionary&lt;string, int?&gt;** |  | [optional] |
| **OneTimeCharges** | **List&lt;string&gt;** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


