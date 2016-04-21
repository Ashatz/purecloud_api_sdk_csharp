---
title: FlowLaunchRequest
---
## .FlowLaunchRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **FlowConfigId** | [**FlowConfigId**](FlowConfigId.html) | ID of the flow to launch, will launch the most recently published version if a specific version is not specified. | |
| **FlowInstanceName** | **string** | The displayable instance name to assign to the new flow instance (or omit to have one automatically generated) | [optional] |
| **InputData** | [**FlowInputData**](FlowInputData.html) | contains launch parameters or initializations for variables in the flow. | [optional] |
| **LaunchType** | **string** | launch type of the flow - NORMAL or TEST | |
{: class="table table-striped"}


