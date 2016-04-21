---
title: UserPresence
---
## ININ.PureCloudApi.Model.UserPresence

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Source** | **string** | Represents the source where the Presence was set. Some examples are: PURECLOUD, LYNC, OUTLOOK, etc. | [optional] |
| **Primary** | **bool?** | A boolean used to tell whether or not to set this presence source as the primary on a PATCH | [optional] [default to false]|
| **PresenceDefinition** | [**OrganizationPresence**](OrganizationPresence.html) |  | [optional] |
| **Message** | **string** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


