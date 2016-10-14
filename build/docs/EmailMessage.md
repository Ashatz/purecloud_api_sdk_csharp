---
title: EmailMessage
---
## ININ.PureCloudApi.Model.EmailMessage

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **To** | [**List&lt;EmailAddress&gt;**](EmailAddress.html) | The recipients of the email message. | |
| **Cc** | [**List&lt;EmailAddress&gt;**](EmailAddress.html) | The recipients that were copied on the email message. | [optional] |
| **Bcc** | [**List&lt;EmailAddress&gt;**](EmailAddress.html) | The recipients that were blind copied on the email message. | [optional] |
| **From** | [**EmailAddress**](EmailAddress.html) | The sender of the email message. | |
| **Subject** | **string** | The subject of the email message. | [optional] |
| **Attachments** | [**List&lt;Attachment&gt;**](Attachment.html) | The attachments of the email message. | [optional] |
| **TextBody** | **string** | The text body of the email message. | |
| **HtmlBody** | **string** | The html body of the email message. | [optional] |
| **Time** | **DateTime?** | The time when the message was received or sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


