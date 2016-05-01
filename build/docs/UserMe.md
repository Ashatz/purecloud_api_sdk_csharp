---
title: UserMe
---
## ININ.PureCloudApi.Model.UserMe

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Chat** | [**Chat**](Chat.html) |  | [optional] |
| **Department** | **string** |  | [optional] |
| **Email** | **string** |  | [optional] |
| **PrimaryContactInfo** | [**List&lt;Contact&gt;**](Contact.html) | Auto populated from addresses. | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact.html) | Email addresses and phone numbers for this user | [optional] |
| **State** | **string** | The current state for this user. | [optional] |
| **Title** | **string** |  | [optional] |
| **Username** | **string** |  | [optional] |
| **Images** | [**List&lt;UserImage&gt;**](UserImage.html) |  | [optional] |
| **Version** | **int?** | Required when updating. Version must be the current version. Only the system can assign version. | [optional] |
| **RoutingStatus** | [**RoutingStatus**](RoutingStatus.html) | ACD routing status | [optional] |
| **Presence** | [**UserPresence**](UserPresence.html) | Active presence | [optional] |
| **ConversationSummary** | [**UserConversationSummary**](UserConversationSummary.html) | Summary of conversion statistics for conversation types. | [optional] |
| **OutOfOffice** | [**OutOfOffice**](OutOfOffice.html) | Determine if out of office is enabled | [optional] |
| **Geolocation** | [**Geolocation**](Geolocation.html) | Current geolocation position | [optional] |
| **Station** | [**UserStations**](UserStations.html) | Effective, default, and last station information | [optional] |
| **Authorization** | [**UserAuthorization**](UserAuthorization.html) | Roles and permissions assigned to the user | [optional] |
| **Organization** | [**Organization**](Organization.html) |  Details about the organization the user is a member of | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


