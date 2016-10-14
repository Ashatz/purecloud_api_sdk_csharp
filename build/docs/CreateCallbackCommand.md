---
title: CreateCallbackCommand
---
## ININ.PureCloudApi.Model.CreateCallbackCommand

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **ScriptId** | **string** | The identifier of the script to be used for the callback | [optional] |
| **QueueId** | **string** | The identifier of the queue to be used for the callback. Either queueId or routingData is required. | [optional] |
| **RoutingData** | [**RoutingData**](RoutingData.html) | The routing data to be used for the callback. Either queueId or routingData is required. | [optional] |
| **CallbackUserName** | **string** | The name of the party to be called back. | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | A list of phone numbers for the callback. | |
| **CallbackScheduledTime** | **DateTime?** | The scheduled date-time for the callback as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **CountryCode** | **string** | The country code to be associated with the callback numbers. | [optional] |
| **IsAutomated** | **bool?** | Whether or not to automatically place a call for this callback. | [optional] [default to false]|
| **AutomatedCallbackConfigId** | **string** | The id of the configuration to handle the response (e.g. live voice, machine) from automatically placing a call for a callback. | [optional] |
| **Data** | **Dictionary&lt;string, string&gt;** | A map of key-value pairs containing additional data that can be associated to the callback. These could be set up for instance to be used in a customized script shown during the call. Example: { \&quot;notes\&quot;: \&quot;ready to close the deal!\&quot;, \&quot;customerPreferredName\&quot;: \&quot;Doc\&quot; } | [optional] |
{: class="table table-striped"}


