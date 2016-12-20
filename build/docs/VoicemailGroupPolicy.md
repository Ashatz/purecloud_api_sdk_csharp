---
title: VoicemailGroupPolicy
---
## ININ.PureCloudApi.Model.VoicemailGroupPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Name** | **string** |  | [optional] |
| **Group** | [**Group**](Group.html) | The group associated with the policy | [optional] |
| **Enabled** | **bool?** | Whether voicemail is enabled for the group | [optional] [default to false]|
| **SendEmailNotifications** | **bool?** | Whether email notifications are sent to group members when a new voicemail is received | [optional] [default to false]|
{: class="table table-striped"}


