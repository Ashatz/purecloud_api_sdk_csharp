---
title: AlertingApi
---
## ININ.PureCloudApi.Api.AlertingApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteInteractionstatsAlert**](AlertingApi.html#deleteinteractionstatsalert) | **DELETE** /api/v2/alerting/interactionstats/alerts/{alertId} | Delete an interaction stats alert |
| [**DeleteInteractionstatsRule**](AlertingApi.html#deleteinteractionstatsrule) | **DELETE** /api/v2/alerting/interactionstats/rules/{ruleId} | Delete an interaction stats rule. |
| [**GetInteractionstatsAlert**](AlertingApi.html#getinteractionstatsalert) | **GET** /api/v2/alerting/interactionstats/alerts/{alertId} | Get an interaction stats alert |
| [**GetInteractionstatsAlerts**](AlertingApi.html#getinteractionstatsalerts) | **GET** /api/v2/alerting/interactionstats/alerts | Get interaction stats alert list. |
| [**GetInteractionstatsAlertsUnread**](AlertingApi.html#getinteractionstatsalertsunread) | **GET** /api/v2/alerting/interactionstats/alerts/unread | Gets user unread count of interaction stats alerts. |
| [**GetInteractionstatsRule**](AlertingApi.html#getinteractionstatsrule) | **GET** /api/v2/alerting/interactionstats/rules/{ruleId} | Get an interaction stats rule. |
| [**GetInteractionstatsRules**](AlertingApi.html#getinteractionstatsrules) | **GET** /api/v2/alerting/interactionstats/rules | Get an interaction stats rule list. |
| [**PostInteractionstatsRules**](AlertingApi.html#postinteractionstatsrules) | **POST** /api/v2/alerting/interactionstats/rules | Create an interaction stats rule. |
| [**PutInteractionstatsAlert**](AlertingApi.html#putinteractionstatsalert) | **PUT** /api/v2/alerting/interactionstats/alerts/{alertId} | Update an interaction stats alert read status |
| [**PutInteractionstatsRule**](AlertingApi.html#putinteractionstatsrule) | **PUT** /api/v2/alerting/interactionstats/rules/{ruleId} | Update an interaction stats rule |
{: class="table table-striped"}

<a name="deleteinteractionstatsalert"></a>

## void DeleteInteractionstatsAlert (string alertId)

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
    public class DeleteInteractionstatsAlertExample
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
                apiInstance.DeleteInteractionstatsAlert(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteInteractionstatsAlert: " + e.Message );
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

<a name="deleteinteractionstatsrule"></a>

## void DeleteInteractionstatsRule (string ruleId)

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
    public class DeleteInteractionstatsRuleExample
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
                apiInstance.DeleteInteractionstatsRule(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.DeleteInteractionstatsRule: " + e.Message );
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

<a name="getinteractionstatsalert"></a>

## [**InteractionStatsAlert**](InteractionStatsAlert.html) GetInteractionstatsAlert (string alertId)

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
    public class GetInteractionstatsAlertExample
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
                InteractionStatsAlert result = apiInstance.GetInteractionstatsAlert(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsAlert: " + e.Message );
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

<a name="getinteractionstatsrule"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) GetInteractionstatsRule (string ruleId)

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
    public class GetInteractionstatsRuleExample
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
                InteractionStatsRule result = apiInstance.GetInteractionstatsRule(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.GetInteractionstatsRule: " + e.Message );
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

<a name="putinteractionstatsalert"></a>

## [**UnreadStatus**](UnreadStatus.html) PutInteractionstatsAlert (string alertId, UnreadStatus body)

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
    public class PutInteractionstatsAlertExample
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
                UnreadStatus result = apiInstance.PutInteractionstatsAlert(alertId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutInteractionstatsAlert: " + e.Message );
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

<a name="putinteractionstatsrule"></a>

## [**InteractionStatsRule**](InteractionStatsRule.html) PutInteractionstatsRule (string ruleId, InteractionStatsRule body)

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
    public class PutInteractionstatsRuleExample
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
                InteractionStatsRule result = apiInstance.PutInteractionstatsRule(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertingApi.PutInteractionstatsRule: " + e.Message );
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

