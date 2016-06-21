---
title: Phone
---
## ININ.PureCloudApi.Model.Phone

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **Version** | **int?** |  | [optional] |
| **DateCreated** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ModifiedBy** | **string** |  | [optional] |
| **CreatedBy** | **string** |  | [optional] |
| **State** | **string** |  | [optional] |
| **ModifiedByApp** | **string** |  | [optional] |
| **CreatedByApp** | **string** |  | [optional] |
| **EdgeGroup** | [**UriReference**](UriReference.html) |  | [optional] |
| **Site** | [**UriReference**](UriReference.html) | Site | |
| **PhoneBaseSettings** | [**UriReference**](UriReference.html) | Phone Base Settings | |
| **LineBaseSettings** | [**UriReference**](UriReference.html) |  | [optional] |
| **PhoneMetaBase** | [**UriReference**](UriReference.html) |  | [optional] |
| **Lines** | [**List&lt;Line&gt;**](Line.html) | Lines | |
| **Status** | [**PhoneStatus**](PhoneStatus.html) | The status of the phone and lines from the primary Edge. | [optional] |
| **SecondaryStatus** | [**PhoneStatus**](PhoneStatus.html) | The status of the phone and lines from the secondary Edge. | [optional] |
| **Properties** | **Dictionary&lt;string, Object&gt;** |  | [optional] |
| **Capabilities** | [**PhoneCapabilities**](PhoneCapabilities.html) |  | [optional] |
| **WebRtcUser** | [**UriReference**](UriReference.html) | This is the user associated with a WebRTC type phone.  It is required for all WebRTC phones. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


