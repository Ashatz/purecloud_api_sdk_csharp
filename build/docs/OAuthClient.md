---
title: OAuthClient
---
## .OAuthClient

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the OAuth client. | |
| **AccessTokenValiditySeconds** | **long?** | The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied. | [optional] |
| **AuthorizedGrantTypes** | **List&lt;string&gt;** | One or more OAuth Grant/Client types supported by this client. | |
| **Description** | **string** |  | [optional] |
| **RegisteredRedirectUri** | **List&lt;string&gt;** | List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback | |
| **Secret** | **string** | System created secret assigned to this client. Secrets are required for code authorization grants. | [optional] |
| **RoleIds** | **List&lt;string&gt;** | Roles assigned to this client. Roles only apply to clients using the client_credential grant | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


