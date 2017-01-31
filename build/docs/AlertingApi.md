---
title: AlertingApi
---
## ININ.PureCloudApi.Api.AlertingApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteHeartbeatAlertsAlertId**](AlertingApi.html#deleteheartbeatalertsalertid) | Delete a heart beat alert |
| [**DeleteHeartbeatRulesRuleId**](AlertingApi.html#deleteheartbeatrulesruleid) | Delete a heart beat rule. |
| [**DeleteInteractionstatsAlertsAlertId**](AlertingApi.html#deleteinteractionstatsalertsalertid) | Delete an interaction stats alert |
| [**DeleteInteractionstatsRulesRuleId**](AlertingApi.html#deleteinteractionstatsrulesruleid) | Delete an interaction stats rule. |
| [**DeleteRoutingstatusAlertsAlertId**](AlertingApi.html#deleteroutingstatusalertsalertid) | Delete a routing status alert |
| [**DeleteRoutingstatusRulesRuleId**](AlertingApi.html#deleteroutingstatusrulesruleid) | Delete a routing status rule. |
| [**DeleteUserpresenceAlertsAlertId**](AlertingApi.html#deleteuserpresencealertsalertid) | Delete a user presence alert |
| [**DeleteUserpresenceRulesRuleId**](AlertingApi.html#deleteuserpresencerulesruleid) | Delete a user presence rule. |
| [**GetHeartbeatAlerts**](AlertingApi.html#getheartbeatalerts) | Get heart beat alert list. |
| [**GetHeartbeatAlertsAlertId**](AlertingApi.html#getheartbeatalertsalertid) | Get a heart beat alert |
| [**GetHeartbeatRules**](AlertingApi.html#getheartbeatrules) | Get a heart beat rule list. |
| [**GetHeartbeatRulesRuleId**](AlertingApi.html#getheartbeatrulesruleid) | Get a heart beat rule. |
| [**GetInteractionstatsAlerts**](AlertingApi.html#getinteractionstatsalerts) | Get interaction stats alert list. |
| [**GetInteractionstatsAlertsAlertId**](AlertingApi.html#getinteractionstatsalertsalertid) | Get an interaction stats alert |
| [**GetInteractionstatsAlertsUnread**](AlertingApi.html#getinteractionstatsalertsunread) | Gets user unread count of interaction stats alerts. |
| [**GetInteractionstatsRules**](AlertingApi.html#getinteractionstatsrules) | Get an interaction stats rule list. |
| [**GetInteractionstatsRulesRuleId**](AlertingApi.html#getinteractionstatsrulesruleid) | Get an interaction stats rule. |
| [**GetRoutingstatusAlerts**](AlertingApi.html#getroutingstatusalerts) | Get routing status alert list. |
| [**GetRoutingstatusAlertsAlertId**](AlertingApi.html#getroutingstatusalertsalertid) | Get a routing status alert |
| [**GetRoutingstatusRules**](AlertingApi.html#getroutingstatusrules) | Get a routing status rule list. |
| [**GetRoutingstatusRulesRuleId**](AlertingApi.html#getroutingstatusrulesruleid) | Get a routing status rule. |
| [**GetUserpresenceAlerts**](AlertingApi.html#getuserpresencealerts) | Get user presence alert list. |
| [**GetUserpresenceAlertsAlertId**](AlertingApi.html#getuserpresencealertsalertid) | Get a user presence alert |
| [**GetUserpresenceRules**](AlertingApi.html#getuserpresencerules) | Get a user presence rule list. |
| [**GetUserpresenceRulesRuleId**](AlertingApi.html#getuserpresencerulesruleid) | Get a user presence rule. |
| [**PostHeartbeatRules**](AlertingApi.html#postheartbeatrules) | Create a heart beat rule. |
| [**PostInteractionstatsRules**](AlertingApi.html#postinteractionstatsrules) | Create an interaction stats rule. |
| [**PostRoutingstatusRules**](AlertingApi.html#postroutingstatusrules) | Create a routing status rule. |
| [**PostUserpresenceRules**](AlertingApi.html#postuserpresencerules) | Create a user presence rule. |
| [**PutHeartbeatRulesRuleId**](AlertingApi.html#putheartbeatrulesruleid) | Update a heart beat rule |
| [**PutInteractionstatsAlertsAlertId**](AlertingApi.html#putinteractionstatsalertsalertid) | Update an interaction stats alert read status |
| [**PutInteractionstatsRulesRuleId**](AlertingApi.html#putinteractionstatsrulesruleid) | Update an interaction stats rule |
| [**PutRoutingstatusRulesRuleId**](AlertingApi.html#putroutingstatusrulesruleid) | Update a routing status rule |
| [**PutUserpresenceRulesRuleId**](AlertingApi.html#putuserpresencerulesruleid) | Update a user presence rule |
{: class="table table-striped"}

<a name="deleteheartbeatalertsalertid"></a>

## void DeleteHeartbeatAlertsAlertId (string alertId)

Delete a heart beat alert



Wraps DELETE /api/v2/alerting/heartbeat/alerts/{alertId} 

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



Wraps DELETE /api/v2/alerting/heartbeat/rules/{ruleId} 

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



Wraps DELETE /api/v2/alerting/interactionstats/alerts/{alertId} 

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



Wraps DELETE /api/v2/alerting/interactionstats/rules/{ruleId} 

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

<a name="deleteroutingstatusalertsalertid"></a>

## void DeleteRoutingstatusAlertsAlertId (string alertId)

Delete a routing status alert



Wraps DELETE /api/v2/alerting/routingstatus/alerts/{alertId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteRoutingstatusAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Delete a routing status alert
                apiInstance.DeleteRoutingstatusAlertsAlertId(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteRoutingstatusAlertsAlertId: " + e.Message );
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

<a name="deleteroutingstatusrulesruleid"></a>

## void DeleteRoutingstatusRulesRuleId (string ruleId)

Delete a routing status rule.



Wraps DELETE /api/v2/alerting/routingstatus/rules/{ruleId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteRoutingstatusRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Delete a routing status rule.
                apiInstance.DeleteRoutingstatusRulesRuleId(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteRoutingstatusRulesRuleId: " + e.Message );
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

<a name="deleteuserpresencealertsalertid"></a>

## void DeleteUserpresenceAlertsAlertId (string alertId)

Delete a user presence alert



Wraps DELETE /api/v2/alerting/userpresence/alerts/{alertId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserpresenceAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Delete a user presence alert
                apiInstance.DeleteUserpresenceAlertsAlertId(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteUserpresenceAlertsAlertId: " + e.Message );
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

<a name="deleteuserpresencerulesruleid"></a>

## void DeleteUserpresenceRulesRuleId (string ruleId)

Delete a user presence rule.



Wraps DELETE /api/v2/alerting/userpresence/rules/{ruleId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteUserpresenceRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Delete a user presence rule.
                apiInstance.DeleteUserpresenceRulesRuleId(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteUserpresenceRulesRuleId: " + e.Message );
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

## [**HeartBeatAlertContainer**](HeartBeatAlertContainer.html) GetHeartbeatAlerts (List<string> expand = null)

Get heart beat alert list.



Wraps GET /api/v2/alerting/heartbeat/alerts 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get heart beat alert list.
                HeartBeatAlertContainer result = apiInstance.GetHeartbeatAlerts(expand);
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


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**HeartBeatAlertContainer**](HeartBeatAlertContainer.html)

<a name="getheartbeatalertsalertid"></a>

## [**HeartBeatAlert**](HeartBeatAlert.html) GetHeartbeatAlertsAlertId (string alertId, List<string> expand = null)

Get a heart beat alert



Wraps GET /api/v2/alerting/heartbeat/alerts/{alertId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a heart beat alert
                HeartBeatAlert result = apiInstance.GetHeartbeatAlertsAlertId(alertId, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**HeartBeatAlert**](HeartBeatAlert.html)

<a name="getheartbeatrules"></a>

## [**HeartBeatRuleContainer**](HeartBeatRuleContainer.html) GetHeartbeatRules (List<string> expand = null)

Get a heart beat rule list.



Wraps GET /api/v2/alerting/heartbeat/rules 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a heart beat rule list.
                HeartBeatRuleContainer result = apiInstance.GetHeartbeatRules(expand);
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


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**HeartBeatRuleContainer**](HeartBeatRuleContainer.html)

<a name="getheartbeatrulesruleid"></a>

## [**HeartBeatRule**](HeartBeatRule.html) GetHeartbeatRulesRuleId (string ruleId, List<string> expand = null)

Get a heart beat rule.



Wraps GET /api/v2/alerting/heartbeat/rules/{ruleId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a heart beat rule.
                HeartBeatRule result = apiInstance.GetHeartbeatRulesRuleId(ruleId, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

<a name="getinteractionstatsalerts"></a>

## [**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.html) GetInteractionstatsAlerts (List<string> expand = null)

Get interaction stats alert list.



Wraps GET /api/v2/alerting/interactionstats/alerts 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get interaction stats alert list.
                InteractionStatsAlertContainer result = apiInstance.GetInteractionstatsAlerts(expand);
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


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsAlertContainer**](InteractionStatsAlertContainer.html)

<a name="getinteractionstatsalertsalertid"></a>

## [**InteractionStatsAlert**](InteractionStatsAlert.html) GetInteractionstatsAlertsAlertId (string alertId, List<string> expand = null)

Get an interaction stats alert



Wraps GET /api/v2/alerting/interactionstats/alerts/{alertId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get an interaction stats alert
                InteractionStatsAlert result = apiInstance.GetInteractionstatsAlertsAlertId(alertId, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsAlert**](InteractionStatsAlert.html)

<a name="getinteractionstatsalertsunread"></a>

## [**UnreadMetric**](UnreadMetric.html) GetInteractionstatsAlertsUnread ()

Gets user unread count of interaction stats alerts.



Wraps GET /api/v2/alerting/interactionstats/alerts/unread 

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

## [**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html) GetInteractionstatsRules (List<string> expand = null)

Get an interaction stats rule list.



Wraps GET /api/v2/alerting/interactionstats/rules 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get an interaction stats rule list.
                InteractionStatsRuleContainer result = apiInstance.GetInteractionstatsRules(expand);
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


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRuleContainer**](InteractionStatsRuleContainer.html)

<a name="getinteractionstatsrulesruleid"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) GetInteractionstatsRulesRuleId (string ruleId, List<string> expand = null)

Get an interaction stats rule.



Wraps GET /api/v2/alerting/interactionstats/rules/{ruleId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get an interaction stats rule.
                InteractionStatsRule result = apiInstance.GetInteractionstatsRulesRuleId(ruleId, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="getroutingstatusalerts"></a>

## [**RoutingStatusAlertContainer**](RoutingStatusAlertContainer.html) GetRoutingstatusAlerts (List<string> expand = null)

Get routing status alert list.



Wraps GET /api/v2/alerting/routingstatus/alerts 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRoutingstatusAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get routing status alert list.
                RoutingStatusAlertContainer result = apiInstance.GetRoutingstatusAlerts(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetRoutingstatusAlerts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatusAlertContainer**](RoutingStatusAlertContainer.html)

<a name="getroutingstatusalertsalertid"></a>

## [**RoutingStatusAlert**](RoutingStatusAlert.html) GetRoutingstatusAlertsAlertId (string alertId, List<string> expand = null)

Get a routing status alert



Wraps GET /api/v2/alerting/routingstatus/alerts/{alertId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRoutingstatusAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a routing status alert
                RoutingStatusAlert result = apiInstance.GetRoutingstatusAlertsAlertId(alertId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetRoutingstatusAlertsAlertId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatusAlert**](RoutingStatusAlert.html)

<a name="getroutingstatusrules"></a>

## [**RoutingStatusRuleContainer**](RoutingStatusRuleContainer.html) GetRoutingstatusRules (List<string> expand = null)

Get a routing status rule list.



Wraps GET /api/v2/alerting/routingstatus/rules 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRoutingstatusRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a routing status rule list.
                RoutingStatusRuleContainer result = apiInstance.GetRoutingstatusRules(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetRoutingstatusRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatusRuleContainer**](RoutingStatusRuleContainer.html)

<a name="getroutingstatusrulesruleid"></a>

## [**RoutingStatusRule**](RoutingStatusRule.html) GetRoutingstatusRulesRuleId (string ruleId, List<string> expand = null)

Get a routing status rule.



Wraps GET /api/v2/alerting/routingstatus/rules/{ruleId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRoutingstatusRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a routing status rule.
                RoutingStatusRule result = apiInstance.GetRoutingstatusRulesRuleId(ruleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetRoutingstatusRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatusRule**](RoutingStatusRule.html)

<a name="getuserpresencealerts"></a>

## [**UserPresenceAlertContainer**](UserPresenceAlertContainer.html) GetUserpresenceAlerts (List<string> expand = null)

Get user presence alert list.



Wraps GET /api/v2/alerting/userpresence/alerts 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserpresenceAlertsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get user presence alert list.
                UserPresenceAlertContainer result = apiInstance.GetUserpresenceAlerts(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetUserpresenceAlerts: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresenceAlertContainer**](UserPresenceAlertContainer.html)

<a name="getuserpresencealertsalertid"></a>

## [**UserPresenceAlert**](UserPresenceAlert.html) GetUserpresenceAlertsAlertId (string alertId, List<string> expand = null)

Get a user presence alert



Wraps GET /api/v2/alerting/userpresence/alerts/{alertId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserpresenceAlertsAlertIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var alertId = alertId_example;  // string | Alert ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a user presence alert
                UserPresenceAlert result = apiInstance.GetUserpresenceAlertsAlertId(alertId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetUserpresenceAlertsAlertId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresenceAlert**](UserPresenceAlert.html)

<a name="getuserpresencerules"></a>

## [**UserPresenceRuleContainer**](UserPresenceRuleContainer.html) GetUserpresenceRules (List<string> expand = null)

Get a user presence rule list.



Wraps GET /api/v2/alerting/userpresence/rules 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserpresenceRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a user presence rule list.
                UserPresenceRuleContainer result = apiInstance.GetUserpresenceRules(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetUserpresenceRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresenceRuleContainer**](UserPresenceRuleContainer.html)

<a name="getuserpresencerulesruleid"></a>

## [**UserPresenceRule**](UserPresenceRule.html) GetUserpresenceRulesRuleId (string ruleId, List<string> expand = null)

Get a user presence rule.



Wraps GET /api/v2/alerting/userpresence/rules/{ruleId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserpresenceRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get a user presence rule.
                UserPresenceRule result = apiInstance.GetUserpresenceRulesRuleId(ruleId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetUserpresenceRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresenceRule**](UserPresenceRule.html)

<a name="postheartbeatrules"></a>

## [**HeartBeatRule**](HeartBeatRule.html) PostHeartbeatRules (HeartBeatRule body, List<string> expand = null)

Create a heart beat rule.



Wraps POST /api/v2/alerting/heartbeat/rules 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Create a heart beat rule.
                HeartBeatRule result = apiInstance.PostHeartbeatRules(body, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

<a name="postinteractionstatsrules"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PostInteractionstatsRules (InteractionStatsRule body, List<string> expand = null)

Create an interaction stats rule.



Wraps POST /api/v2/alerting/interactionstats/rules 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Create an interaction stats rule.
                InteractionStatsRule result = apiInstance.PostInteractionstatsRules(body, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="postroutingstatusrules"></a>

## [**RoutingStatusRule**](RoutingStatusRule.html) PostRoutingstatusRules (RoutingStatusRule body, List<string> expand = null)

Create a routing status rule.



Wraps POST /api/v2/alerting/routingstatus/rules 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRoutingstatusRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var body = new RoutingStatusRule(); // RoutingStatusRule | RoutingStatusRule
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Create a routing status rule.
                RoutingStatusRule result = apiInstance.PostRoutingstatusRules(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostRoutingstatusRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**RoutingStatusRule**](RoutingStatusRule.html)| RoutingStatusRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatusRule**](RoutingStatusRule.html)

<a name="postuserpresencerules"></a>

## [**UserPresenceRule**](UserPresenceRule.html) PostUserpresenceRules (UserPresenceRule body, List<string> expand = null)

Create a user presence rule.



Wraps POST /api/v2/alerting/userpresence/rules 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUserpresenceRulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var body = new UserPresenceRule(); // UserPresenceRule | UserPresenceRule
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Create a user presence rule.
                UserPresenceRule result = apiInstance.PostUserpresenceRules(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PostUserpresenceRules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**UserPresenceRule**](UserPresenceRule.html)| UserPresenceRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresenceRule**](UserPresenceRule.html)

<a name="putheartbeatrulesruleid"></a>

## [**HeartBeatRule**](HeartBeatRule.html) PutHeartbeatRulesRuleId (string ruleId, HeartBeatRule body, List<string> expand = null)

Update a heart beat rule



Wraps PUT /api/v2/alerting/heartbeat/rules/{ruleId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Update a heart beat rule
                HeartBeatRule result = apiInstance.PutHeartbeatRulesRuleId(ruleId, body, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**HeartBeatRule**](HeartBeatRule.html)

<a name="putinteractionstatsalertsalertid"></a>

## [**UnreadStatus**](UnreadStatus.html) PutInteractionstatsAlertsAlertId (string alertId, UnreadStatus body, List<string> expand = null)

Update an interaction stats alert read status



Wraps PUT /api/v2/alerting/interactionstats/alerts/{alertId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Update an interaction stats alert read status
                UnreadStatus result = apiInstance.PutInteractionstatsAlertsAlertId(alertId, body, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UnreadStatus**](UnreadStatus.html)

<a name="putinteractionstatsrulesruleid"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PutInteractionstatsRulesRuleId (string ruleId, InteractionStatsRule body, List<string> expand = null)

Update an interaction stats rule



Wraps PUT /api/v2/alerting/interactionstats/rules/{ruleId} 

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
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Update an interaction stats rule
                InteractionStatsRule result = apiInstance.PutInteractionstatsRulesRuleId(ruleId, body, expand);
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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**InteractionStatsRule**](InteractionStatsRule.html)

<a name="putroutingstatusrulesruleid"></a>

## [**RoutingStatusRule**](RoutingStatusRule.html) PutRoutingstatusRulesRuleId (string ruleId, RoutingStatusRule body, List<string> expand = null)

Update a routing status rule



Wraps PUT /api/v2/alerting/routingstatus/rules/{ruleId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRoutingstatusRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var body = new RoutingStatusRule(); // RoutingStatusRule | RoutingStatusRule
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Update a routing status rule
                RoutingStatusRule result = apiInstance.PutRoutingstatusRulesRuleId(ruleId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutRoutingstatusRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**RoutingStatusRule**](RoutingStatusRule.html)| RoutingStatusRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**RoutingStatusRule**](RoutingStatusRule.html)

<a name="putuserpresencerulesruleid"></a>

## [**UserPresenceRule**](UserPresenceRule.html) PutUserpresenceRulesRuleId (string ruleId, UserPresenceRule body, List<string> expand = null)

Update a user presence rule



Wraps PUT /api/v2/alerting/userpresence/rules/{ruleId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserpresenceRulesRuleIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AlertingApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var body = new UserPresenceRule(); // UserPresenceRule | UserPresenceRule
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Update a user presence rule
                UserPresenceRule result = apiInstance.PutUserpresenceRulesRuleId(ruleId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutUserpresenceRulesRuleId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**UserPresenceRule**](UserPresenceRule.html)| UserPresenceRule |  |
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**UserPresenceRule**](UserPresenceRule.html)

