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
| **Version** | **int?** | Required when updating a user, this value should be the current version of the user.  The current version can be obtained with a GET on the user before doing a PATCH. | |
| **RoutingStatus** | [**RoutingStatus**](RoutingStatus.html) | ACD routing status | [optional] |
| **Presence** | [**UserPresence**](UserPresence.html) | Active presence | [optional] |
| **ConversationSummary** | [**UserConversationSummary**](UserConversationSummary.html) | Summary of conversion statistics for conversation types. | [optional] |
| **OutOfOffice** | [**OutOfOffice**](OutOfOffice.html) | Determine if out of office is enabled | [optional] |
| **Geolocation** | [**Geolocation**](Geolocation.html) | Current geolocation position | [optional] |
| **Station** | [**UserStations**](UserStations.html) | Effective, default, and last station information | [optional] |
| **Authorization** | [**UserAuthorization**](UserAuthorization.html) | Roles and permissions assigned to the user | [optional] |
| **ProfileSkills** | **List&lt;string&gt;** | Skills possessed by the user | [optional] |
| **Date** | [**ServerDate**](ServerDate.html) | The PureCloud system date time. | [optional] |
| **GeolocationSettings** | [**GeolocationSettings**](GeolocationSettings.html) | Geolocation settings for user&#39;s organization. | [optional] |
| **Organization** | [**Organization**](Organization.html) | Organization details for this user. | [optional] |
| **PresenceDefinitions** | [**List&lt;OrganizationPresence&gt;**](OrganizationPresence.html) | The first 100 presence definitions for user&#39;s organization. | [optional] |
| **Locations** | [**List&lt;Location&gt;**](Location.html) | The first 100 locations for user&#39;s organization | [optional] |
| **OrgAuthorization** | [**List&lt;DomainOrganizationRole&gt;**](DomainOrganizationRole.html) | The first 100 organization roles, with applicable permission policies, for user&#39;s organization. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


