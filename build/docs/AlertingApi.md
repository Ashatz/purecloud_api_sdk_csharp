---
title: AlertingApi
---
## ININ.PureCloudApi.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteHeartbeatAlertsAlertId**](AlertingApi.html#deleteheartbeatalertsalertid) | **DELETE** /api/v2/alerting/heartbeat/alerts/{alertId} | Delete a heart beat alert |
| [**DeleteHeartbeatRulesRuleId**](AlertingApi.html#deleteheartbeatrulesruleid) | **DELETE** /api/v2/alerting/heartbeat/rules/{ruleId} | Delete a heart beat rule. |
| [**DeleteInteractionstatsAlertsAlertId**](AlertingApi.html#deleteinteractionstatsalertsalertid) | **DELETE** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteInteractionstatsRulesRuleId**](AlertingApi.html#deleteinteractionstatsrulesruleid) | **DELETE** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule. |
| [**GetHeartbeatAlerts**](AlertingApi.html#getheartbeatalerts) | **GET** /api/v2/alerting/heartbeat/alerts | Get heart beat alert list. |
| [**GetHeartbeatAlertsAlertId**](AlertingApi.html#getheartbeatalertsalertid) | **GET** /api/v2/alerting/heartbeat/alerts/{alertId} | Get a heart beat alert |
| [**GetHeartbeatRules**](AlertingApi.html#getheartbeatrules) | **GET** /api/v2/alerting/heartbeat/rules | Get a heart beat rule list. |
| [**GetHeartbeatRulesRuleId**](AlertingApi.html#getheartbeatrulesruleid) | **GET** /api/v2/alerting/heartbeat/rules/{ruleId} | Get a heart beat rule. |
| [**GetInteractionstatsAlerts**](AlertingApi.html#getinteractionstatsalerts) | **GET** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list. |
| [**GetInteractionstatsAlertsAlertId**](AlertingApi.html#getinteractionstatsalertsalertid) | **GET** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetInteractionstatsAlertsUnread**](AlertingApi.html#getinteractionstatsalertsunread) | **GET** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts. |
| [**GetInteractionstatsRules**](AlertingApi.html#getinteractionstatsrules) | **GET** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list. |
| [**GetInteractionstatsRulesRuleId**](AlertingApi.html#getinteractionstatsrulesruleid) | **GET** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule. |
| [**PostHeartbeatRules**](AlertingApi.html#postheartbeatrules) | **POST** /api/v2/alerting/heartbeat/rules | Create a heart beat rule. |
| [**PostInteractionstatsRules**](AlertingApi.html#postinteractionstatsrules) | **POST** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule. |
| [**PutHeartbeatRulesRuleId**](AlertingApi.html#putheartbeatrulesruleid) | **PUT** /api/v2/alerting/heartbeat/rules/{ruleId} | Update a heart beat rule |
| [**PutInteractionstatsAlertsAlertId**](AlertingApi.html#putinteractionstatsalertsalertid) | **PUT** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutInteractionstatsRulesRuleId**](AlertingApi.html#putinteractionstatsrulesruleid) | **PUT** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
{: class="table table-striped"}

<a name="deleteheartbeatalertsalertid"></a>

## void DeleteHeartbeatAlertsAlertId (string alertId)

Delete a heart beat alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteHeartbeatAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Delete a heart beat alert
                apiInstance.DeleteHeartbeatAlertsAlertId(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteHeartbeatAlertsAlertId: " + e.Message );
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

<a name="deleteheartbeatrulesruleid"></a>

## void DeleteHeartbeatRulesRuleId (string ruleId)

Delete a heart beat rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteHeartbeatRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Delete a heart beat rule.
                apiInstance.DeleteHeartbeatRulesRuleId(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteHeartbeatRulesRuleId: " + e.Message );
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

<a name="deleteinteractionstatsalertsalertid"></a>

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

<a name="deleteinteractionstatsrulesruleid"></a>

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

<a name="getheartbeatalerts"></a>

## [**HeartBeatAlertContainer**](HeartBeatAlertContainer.html) GetHeartbeatAlerts ()

Get heart beat alert list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetHeartbeatAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();

            try
            {
                // Get heart beat alert list.
                HeartBeatAlertContainer result = apiInstance.GetHeartbeatAlerts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetHeartbeatAlerts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**HeartBeatAlertContainer**](HeartBeatAlertContainer.html)

<a name="getheartbeatalertsalertid"></a>

## [**HeartBeatAlert**](HeartBeatAlert.html) GetHeartbeatAlertsAlertId (string alertId)

Get a heart beat alert



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetHeartbeatAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Get a heart beat alert
                HeartBeatAlert result = apiInstance.GetHeartbeatAlertsAlertId(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetHeartbeatAlertsAlertId: " + e.Message );
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

[**HeartBeatAlert**](HeartBeatAlert.html)

<a name="getheartbeatrules"></a>

## [**HeartBeatRuleContainer**](HeartBeatRuleContainer.html) GetHeartbeatRules ()

Get a heart beat rule list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetHeartbeatRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();

            try
            {
                // Get a heart beat rule list.
                HeartBeatRuleContainer result = apiInstance.GetHeartbeatRules();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetHeartbeatRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**HeartBeatRuleContainer**](HeartBeatRuleContainer.html)

<a name="getheartbeatrulesruleid"></a>

## [**HeartBeatRule**](HeartBeatRule.html) GetHeartbeatRulesRuleId (string ruleId)

Get a heart beat rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetHeartbeatRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Get a heart beat rule.
                HeartBeatRule result = apiInstance.GetHeartbeatRulesRuleId(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetHeartbeatRulesRuleId: " + e.Message );
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

[**HeartBeatRule**](HeartBeatRule.html)

<a name="getinteractionstatsalerts"></a>

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

[**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.html)

<a name="getinteractionstatsalertsalertid"></a>

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

[**InteractionStatsAlert**](InteractionStatsAlert.html)

<a name="getinteractionstatsalertsunread"></a>

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

[**UnreadMetric**](UnreadMetric.html)

<a name="getinteractionstatsrules"></a>

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

[**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html)

<a name="getinteractionstatsrulesruleid"></a>

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

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="postheartbeatrules"></a>

## [**HeartBeatRule**](HeartBeatRule.html) PostHeartbeatRules (HeartBeatRule body)

Create a heart beat rule.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostHeartbeatRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var body = new HeartBeatRule(); // HeartBeatRule | HeartBeatRule

            try
            {
                // Create a heart beat rule.
                HeartBeatRule result = apiInstance.PostHeartbeatRules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostHeartbeatRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**HeartBeatRule**](HeartBeatRule.html)| HeartBeatRule |  |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

<a name="postinteractionstatsrules"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PostInteractionstatsRules (InteractionStatsRule body)

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
            var body = new InteractionStatsRule(); // InteractionStatsRule | AlertingRule

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
| **body** | [**InteractionStatsRule**](InteractionStatsRule.html)| AlertingRule |  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="putheartbeatrulesruleid"></a>

## [**HeartBeatRule**](HeartBeatRule.html) PutHeartbeatRulesRuleId (string ruleId, HeartBeatRule body)

Update a heart beat rule



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutHeartbeatRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var body = new HeartBeatRule(); // HeartBeatRule | HeartBeatRule

            try
            {
                // Update a heart beat rule
                HeartBeatRule result = apiInstance.PutHeartbeatRulesRuleId(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutHeartbeatRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**HeartBeatRule**](HeartBeatRule.html)| HeartBeatRule |  |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

<a name="putinteractionstatsalertsalertid"></a>

## [**UnreadStatus**](UnreadStatus.html) PutInteractionstatsAlertsAlertId (string alertId, UnreadStatus body)

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
            var body = new UnreadStatus(); // UnreadStatus | InteractionStatsAlert

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
| **body** | [**UnreadStatus**](UnreadStatus.html)| InteractionStatsAlert |  |
{: class="table table-striped"}

### Return type

[**UnreadStatus**](UnreadStatus.html)

<a name="putinteractionstatsrulesruleid"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PutInteractionstatsRulesRuleId (string ruleId, InteractionStatsRule body)

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
            var body = new InteractionStatsRule(); // InteractionStatsRule | AlertingRule

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
| **body** | [**InteractionStatsRule**](InteractionStatsRule.html)| AlertingRule |  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

