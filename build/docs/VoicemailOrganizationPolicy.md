---
title: VoicemailOrganizationPolicy
---
## ININ.PureCloudApi.Model.VoicemailOrganizationPolicy

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Enabled** | **bool?** |  | [optional] [default to false]|
| **RetentionTimeDays** | **int?** |  | [optional] |
| **AlertTimeoutSeconds** | **int?** |  | [optional] |
| **MinimumRecordingTimeSeconds** | **int?** |  | [optional] |
| **MaximumRecordingTimeSeconds** | **int?** |  | [optional] |
| **UnavailableMessageUri** | **string** |  | [optional] |
| **NamePromptMessageUri** | **string** |  | [optional] |
| **FullMessageUri** | **string** |  | [optional] |
| **CompressSilence** | **bool?** |  | [optional] [default to false]|
| **PinConfiguration** | [**PINConfiguration**](PINConfiguration.html) |  | [optional] |
| **QuotaSizeBytes** | **long?** |  | [optional] |
| **CreatedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **VoicemailExtension** | **string** | The extension for voicemail retrieval.  The default value is *86. | [optional] |
| **PinRequired** | **bool?** | If this is true, a PIN is required when accessing a user&#39;s voicemail from a phone. | [optional] [default to false]|
{: class="table table-striped"}


