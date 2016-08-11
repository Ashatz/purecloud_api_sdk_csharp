---
title: Keyword
---
## ININ.PureCloudApi.Model.Keyword

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** |  | [optional] |
| **Name** | **string** |  | [optional] |
| **Phrase** | **string** | The word or phrase which is being looked for with speech recognition. | |
| **Confidence** | **int?** | A sensitivity threshold that can be increased to lower false positives or decreased to reduce false negatives. | |
| **AgentScoreModifier** | **int?** | A modifier to the evaluation score when the phrase is spotted in the agent channel | |
| **CustomerScoreModifier** | **int?** | A modifier to the evaluation score when the phrase is spotted in the customer channel | |
| **AlternateSpellings** | **List&lt;string&gt;** |  | [optional] |
| **SpotabilityIndex** | **double?** | A prediction of how easy it is to unambiguously spot the keyword within its language based on spelling. | [optional] |
| **MarginOfError** | **double?** |  | [optional] |
| **Pronunciation** | **string** |  | [optional] |
{: class="table table-striped"}


