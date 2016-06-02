---
title: TransformEndpoint
---
## ININ.PureCloudApi.Model.TransformEndpoint

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **SwaggerUrl** | **string** | The Url to the swagger documentation of the endpoint where parsed entities will be posted | [optional] |
| **Route** | **string** | The swagger route to use | [optional] |
| **Entity** | **string** | The entity type being posted | [optional] |
| **ApiFunction** | **string** | The swagger function being called | [optional] |
| **Ready** | **bool?** | Whether this TransformEndpoint has been configured to work (security groups, permissions, etc) | [default to false]|
| **Active** | **bool?** | Whether this TransformEndpoint is currently active and accepting transformation operations | [optional] [default to false]|
| **BatchSize** | **int?** | The number of entities to send in an array for batch POSTs, or 0 for unbatched POSTs | [optional] |
| **Parallelism** | **int?** | The number of parallel POSTs to allow at once | [optional] |
| **UpdateProgressEvery** | **int?** | The swagger route to use | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


