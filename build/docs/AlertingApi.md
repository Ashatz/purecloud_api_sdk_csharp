# ININ.PureCloudApi.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteInteractionstatsAlertsAlertId**](AlertingApi.md#deleteinteractionstatsalertsalertid) | **DELETE** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteInteractionstatsRulesRuleId**](AlertingApi.md#deleteinteractionstatsrulesruleid) | **DELETE** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule. |
| [**GetInteractionstatsAlerts**](AlertingApi.md#getinteractionstatsalerts) | **GET** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list. |
| [**GetInteractionstatsAlertsAlertId**](AlertingApi.md#getinteractionstatsalertsalertid) | **GET** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetInteractionstatsAlertsUnread**](AlertingApi.md#getinteractionstatsalertsunread) | **GET** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts. |
| [**GetInteractionstatsRules**](AlertingApi.md#getinteractionstatsrules) | **GET** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list. |
| [**GetInteractionstatsRulesRuleId**](AlertingApi.md#getinteractionstatsrulesruleid) | **GET** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule. |
| [**PostInteractionstatsRules**](AlertingApi.md#postinteractionstatsrules) | **POST** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule. |
| [**PutInteractionstatsAlertsAlertId**](AlertingApi.md#putinteractionstatsalertsalertid) | **PUT** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutInteractionstatsRulesRuleId**](AlertingApi.md#putinteractionstatsrulesruleid) | **PUT** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
{: class="table table-striped"}

<a name="DeleteInteractionstatsAlertsAlertId"></a>
## void DeleteInteractionstatsAlertsAlertId (string alertId)

Delete an interaction stats alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteInteractionstatsAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Delete an interaction stats alert
                apiInstance.DeleteInteractionstatsAlertsAlertId(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteInteractionstatsAlertsAlertId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteInteractionstatsRulesRuleId"></a>
## void DeleteInteractionstatsRulesRuleId (string ruleId)

Delete an interaction stats rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteInteractionstatsRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Delete an interaction stats rule.
                apiInstance.DeleteInteractionstatsRulesRuleId(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteInteractionstatsRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetInteractionstatsAlerts"></a>
## [**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.html) GetInteractionstatsAlerts ()

Get interaction stats alert list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetInteractionstatsAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();

            try
            {
                // Get interaction stats alert list.
                InteractionStatsAlertContainer result = apiInstance.GetInteractionstatsAlerts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsAlerts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.md)

<a name="GetInteractionstatsAlertsAlertId"></a>
## [**InteractionStatsAlert**](InteractionStatsAlert.html) GetInteractionstatsAlertsAlertId (string alertId)

Get an interaction stats alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetInteractionstatsAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Get an interaction stats alert
                InteractionStatsAlert result = apiInstance.GetInteractionstatsAlertsAlertId(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsAlertsAlertId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
{: class="table table-striped"}

### Return type

[**InteractionStatsAlert**](InteractionStatsAlert.md)

<a name="GetInteractionstatsAlertsUnread"></a>
## [**UnreadMetric**](UnreadMetric.html) GetInteractionstatsAlertsUnread ()

Gets user unread count of interaction stats alerts.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetInteractionstatsAlertsUnreadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();

            try
            {
                // Gets user unread count of interaction stats alerts.
                UnreadMetric result = apiInstance.GetInteractionstatsAlertsUnread();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsAlertsUnread: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**UnreadMetric**](UnreadMetric.md)

<a name="GetInteractionstatsRules"></a>
## [**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html) GetInteractionstatsRules ()

Get an interaction stats rule list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetInteractionstatsRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();

            try
            {
                // Get an interaction stats rule list.
                InteractionStatsRuleContainer result = apiInstance.GetInteractionstatsRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.md)

<a name="GetInteractionstatsRulesRuleId"></a>
## [**InteractionStatsRule**](InteractionStatsRule.html) GetInteractionstatsRulesRuleId (string ruleId)

Get an interaction stats rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetInteractionstatsRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Get an interaction stats rule.
                InteractionStatsRule result = apiInstance.GetInteractionstatsRulesRuleId(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.md)

<a name="PostInteractionstatsRules"></a>
## [**InteractionStatsRule**](InteractionStatsRule.html) PostInteractionstatsRules (InteractionStatsRule body = null)

Create an interaction stats rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostInteractionstatsRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var body = new InteractionStatsRule(); // InteractionStatsRule | AlertingRule (optional) 

            try
            {
                // Create an interaction stats rule.
                InteractionStatsRule result = apiInstance.PostInteractionstatsRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostInteractionstatsRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**InteractionStatsRule**](InteractionStatsRule.md)| AlertingRule | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.md)

<a name="PutInteractionstatsAlertsAlertId"></a>
## [**UnreadStatus**](UnreadStatus.html) PutInteractionstatsAlertsAlertId (string alertId, UnreadStatus body = null)

Update an interaction stats alert read status



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutInteractionstatsAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID
            var body = new UnreadStatus(); // UnreadStatus | InteractionStatsAlert (optional) 

            try
            {
                // Update an interaction stats alert read status
                UnreadStatus result = apiInstance.PutInteractionstatsAlertsAlertId(alertId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutInteractionstatsAlertsAlertId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **body** | [**UnreadStatus**](UnreadStatus.md)| InteractionStatsAlert | [optional]  |
{: class="table table-striped"}

### Return type

[**UnreadStatus**](UnreadStatus.md)

<a name="PutInteractionstatsRulesRuleId"></a>
## [**InteractionStatsRule**](InteractionStatsRule.html) PutInteractionstatsRulesRuleId (string ruleId, InteractionStatsRule body = null)

Update an interaction stats rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutInteractionstatsRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var body = new InteractionStatsRule(); // InteractionStatsRule | AlertingRule (optional) 

            try
            {
                // Update an interaction stats rule
                InteractionStatsRule result = apiInstance.PutInteractionstatsRulesRuleId(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutInteractionstatsRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**InteractionStatsRule**](InteractionStatsRule.md)| AlertingRule | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.md)

