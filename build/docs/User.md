---
title: User
---
## .User

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Username** | **string** |  | [optional] |
| **Email** | **string** |  | [optional] |
| **DisplayName** | **string** |  | [optional] |
| **PhoneNumber** | **string** |  | [optional] |
| **UserImages** | [**List&lt;UserImage&gt;**](UserImage.html) |  | [optional] |
| **Chat** | [**Chat**](Chat.html) |  | [optional] |
| **Roles** | [**List&lt;DomainOrganizationRole&gt;**](DomainOrganizationRole.html) |  | [optional] |
| **VoicemailEnabled** | **bool?** |  | [optional] [default to false]|
| **Department** | **string** |  | [optional] |
| **Title** | **string** |  | [optional] |
| **RoutingStatus** | [**RoutingStatus**](RoutingStatus.html) |  | [optional] |
| **Password** | **string** |  | [optional] |
| **PrimaryPresence** | [**UserPresence**](UserPresence.html) |  | [optional] |
| **Conversations** | [**UserConversationSummary**](UserConversationSummary.html) |  | [optional] |
| **ConversationSummary** | [**UserConversationSummary**](UserConversationSummary.html) |  | [optional] |
| **OutOfOffice** | [**OutOfOffice**](OutOfOffice.html) |  | [optional] |
| **Geolocation** | [**Geolocation**](Geolocation.html) |  | [optional] |
| **Permissions** | **List&lt;string&gt;** |  | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **RequestedStatus** | [**UserStatus**](UserStatus.html) |  | [optional] |
| **DefaultStationUri** | **string** |  | [optional] |
| **StationUri** | **string** |  | [optional] |
| **LastStationUri** | **string** |  | [optional] |
{: class="table table-striped"}


