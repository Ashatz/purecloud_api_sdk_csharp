# ININ.PureCloudApi.Api.AnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**AnalyticsAlertingAlertsAlertidDelete**](AnalyticsApi.md#analyticsalertingalertsalertiddelete) | **DELETE** /api/v1/analytics/alerting/alerts/{alertId} | Delete an alert. |
| [**AnalyticsAlertingAlertsAlertidGet**](AnalyticsApi.md#analyticsalertingalertsalertidget) | **GET** /api/v1/analytics/alerting/alerts/{alertId} | Get an alert. |
| [**AnalyticsAlertingAlertsAlertidPut**](AnalyticsApi.md#analyticsalertingalertsalertidput) | **PUT** /api/v1/analytics/alerting/alerts/{alertId} | Update an alerts unread status. |
| [**AnalyticsAlertingAlertsGet**](AnalyticsApi.md#analyticsalertingalertsget) | **GET** /api/v1/analytics/alerting/alerts | Get a list of alerts. |
| [**AnalyticsAlertingAlertsUnreadGet**](AnalyticsApi.md#analyticsalertingalertsunreadget) | **GET** /api/v1/analytics/alerting/alerts/unread | A count of unread alerts. |
| [**AnalyticsAlertingRulesGet**](AnalyticsApi.md#analyticsalertingrulesget) | **GET** /api/v1/analytics/alerting/rules | Get a list of rules. |
| [**AnalyticsAlertingRulesPost**](AnalyticsApi.md#analyticsalertingrulespost) | **POST** /api/v1/analytics/alerting/rules | Create an alerting rule. |
| [**AnalyticsAlertingRulesRuleidDelete**](AnalyticsApi.md#analyticsalertingrulesruleiddelete) | **DELETE** /api/v1/analytics/alerting/rules/{ruleId} | Delete an alerting rule. |
| [**AnalyticsAlertingRulesRuleidGet**](AnalyticsApi.md#analyticsalertingrulesruleidget) | **GET** /api/v1/analytics/alerting/rules/{ruleId} | Get an alerting rule. |
| [**AnalyticsAlertingRulesRuleidPut**](AnalyticsApi.md#analyticsalertingrulesruleidput) | **PUT** /api/v1/analytics/alerting/rules/{ruleId} | Update an alerting rule. |
| [**AnalyticsMetricsQueryPost**](AnalyticsApi.md#analyticsmetricsquerypost) | **POST** /api/v1/analytics/metrics/query | Executes a metrics query against the analytics service |
| [**AnalyticsReportingMetadataGet**](AnalyticsApi.md#analyticsreportingmetadataget) | **GET** /api/v1/analytics/reporting/metadata | Get list of reporting metadata. |
| [**AnalyticsReportingReportformatsGet**](AnalyticsApi.md#analyticsreportingreportformatsget) | **GET** /api/v1/analytics/reporting/reportformats | Get a list of report formats |
| [**AnalyticsReportingReportidMetadataGet**](AnalyticsApi.md#analyticsreportingreportidmetadataget) | **GET** /api/v1/analytics/reporting/{reportId}/metadata | Get a reporting metadata. |
| [**AnalyticsReportingSchedulesGet**](AnalyticsApi.md#analyticsreportingschedulesget) | **GET** /api/v1/analytics/reporting/schedules | Get a list of scheduled report jobs |
| [**AnalyticsReportingSchedulesPost**](AnalyticsApi.md#analyticsreportingschedulespost) | **POST** /api/v1/analytics/reporting/schedules | Create a scheduled report job |
| [**AnalyticsReportingSchedulesScheduleidDelete**](AnalyticsApi.md#analyticsreportingschedulesscheduleiddelete) | **DELETE** /api/v1/analytics/reporting/schedules/{scheduleId} | Delete a scheduled report job. |
| [**AnalyticsReportingSchedulesScheduleidGet**](AnalyticsApi.md#analyticsreportingschedulesscheduleidget) | **GET** /api/v1/analytics/reporting/schedules/{scheduleId} | Get a scheduled report job. |
| [**AnalyticsReportingSchedulesScheduleidHistoryGet**](AnalyticsApi.md#analyticsreportingschedulesscheduleidhistoryget) | **GET** /api/v1/analytics/reporting/schedules/{scheduleId}/history | Get list of completed scheduled report jobs. |
| [**AnalyticsReportingSchedulesScheduleidHistoryLatestGet**](AnalyticsApi.md#analyticsreportingschedulesscheduleidhistorylatestget) | **GET** /api/v1/analytics/reporting/schedules/{scheduleId}/history/latest | Get most recently completed scheduled report job. |
| [**AnalyticsReportingSchedulesScheduleidHistoryRunidGet**](AnalyticsApi.md#analyticsreportingschedulesscheduleidhistoryrunidget) | **GET** /api/v1/analytics/reporting/schedules/{scheduleId}/history/{runId} | A completed scheduled report job |
| [**AnalyticsReportingSchedulesScheduleidPut**](AnalyticsApi.md#analyticsreportingschedulesscheduleidput) | **PUT** /api/v1/analytics/reporting/schedules/{scheduleId} | Update a scheduled report job. |
| [**AnalyticsReportingSchedulesScheduleidRunreportPost**](AnalyticsApi.md#analyticsreportingschedulesscheduleidrunreportpost) | **POST** /api/v1/analytics/reporting/schedules/{scheduleId}/runreport | Place a scheduled report immediately into the reporting queue |
| [**AnalyticsReportingTimeperiodsGet**](AnalyticsApi.md#analyticsreportingtimeperiodsget) | **GET** /api/v1/analytics/reporting/timeperiods | Get a list of report time periods. |
| [**AnalyticsSegmentsQueryPost**](AnalyticsApi.md#analyticssegmentsquerypost) | **POST** /api/v1/analytics/segments/query | Executes a segments query against the analytics service |
{: class="table table-striped"}

<a name="AnalyticsAlertingAlertsAlertidDelete"></a>
## void AnalyticsAlertingAlertsAlertidDelete (string alertId)

Delete an alert.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingAlertsAlertidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Delete an alert.
                apiInstance.AnalyticsAlertingAlertsAlertidDelete(alertId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingAlertsAlertidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="AnalyticsAlertingAlertsAlertidGet"></a>
## [**Alert**](Alert.html) AnalyticsAlertingAlertsAlertidGet (string alertId)

Get an alert.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingAlertsAlertidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var alertId = alertId_example;  // string | Alert ID

            try
            {
                // Get an alert.
                Alert result = apiInstance.AnalyticsAlertingAlertsAlertidGet(alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingAlertsAlertidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
{: class="table table-striped"}

### Return type

[**Alert**](Alert.md)

<a name="AnalyticsAlertingAlertsAlertidPut"></a>
## [**Alert**](Alert.html) AnalyticsAlertingAlertsAlertidPut (string alertId, Alert body = null)

Update an alerts unread status.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingAlertsAlertidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var alertId = alertId_example;  // string | Alert ID
            var body = new Alert(); // Alert | Alert (optional) 

            try
            {
                // Update an alerts unread status.
                Alert result = apiInstance.AnalyticsAlertingAlertsAlertidPut(alertId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingAlertsAlertidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **alertId** | **string**| Alert ID |  |
| **body** | [**Alert**](Alert.md)| Alert | [optional]  |
{: class="table table-striped"}

### Return type

[**Alert**](Alert.md)

<a name="AnalyticsAlertingAlertsGet"></a>
## [**AlertEntityListing**](AlertEntityListing.html) AnalyticsAlertingAlertsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a list of alerts.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingAlertsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | title, startTime, endTime, description or unread (optional)  (default to startTime)
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to ascending)

            try
            {
                // Get a list of alerts.
                AlertEntityListing result = apiInstance.AnalyticsAlertingAlertsGet(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingAlertsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| title, startTime, endTime, description or unread | [optional] [default to startTime] |
| **sortOrder** | **string**| ascending or descending | [optional] [default to ascending] |
{: class="table table-striped"}

### Return type

[**AlertEntityListing**](AlertEntityListing.md)

<a name="AnalyticsAlertingAlertsUnreadGet"></a>
## [**UnreadMetric**](UnreadMetric.html) AnalyticsAlertingAlertsUnreadGet ()

A count of unread alerts.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingAlertsUnreadGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();

            try
            {
                // A count of unread alerts.
                UnreadMetric result = apiInstance.AnalyticsAlertingAlertsUnreadGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingAlertsUnreadGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**UnreadMetric**](UnreadMetric.md)

<a name="AnalyticsAlertingRulesGet"></a>
## [**RuleEntityListing**](RuleEntityListing.html) AnalyticsAlertingRulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)

Get a list of rules.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingRulesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | title, description, inAlarm or enabled (optional)  (default to title)
            var sortOrder = sortOrder_example;  // string | ascending or descending (optional)  (default to ascending)

            try
            {
                // Get a list of rules.
                RuleEntityListing result = apiInstance.AnalyticsAlertingRulesGet(pageNumber, pageSize, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingRulesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **sortBy** | **string**| title, description, inAlarm or enabled | [optional] [default to title] |
| **sortOrder** | **string**| ascending or descending | [optional] [default to ascending] |
{: class="table table-striped"}

### Return type

[**RuleEntityListing**](RuleEntityListing.md)

<a name="AnalyticsAlertingRulesPost"></a>
## [**Rule**](Rule.html) AnalyticsAlertingRulesPost (Rule body = null)

Create an alerting rule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingRulesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new Rule(); // Rule | Rule (optional) 

            try
            {
                // Create an alerting rule.
                Rule result = apiInstance.AnalyticsAlertingRulesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingRulesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Rule**](Rule.md)| Rule | [optional]  |
{: class="table table-striped"}

### Return type

[**Rule**](Rule.md)

<a name="AnalyticsAlertingRulesRuleidDelete"></a>
## void AnalyticsAlertingRulesRuleidDelete (string ruleId)

Delete an alerting rule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingRulesRuleidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Delete an alerting rule.
                apiInstance.AnalyticsAlertingRulesRuleidDelete(ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingRulesRuleidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="AnalyticsAlertingRulesRuleidGet"></a>
## [**Rule**](Rule.html) AnalyticsAlertingRulesRuleidGet (string ruleId)

Get an alerting rule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingRulesRuleidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var ruleId = ruleId_example;  // string | Rule ID

            try
            {
                // Get an alerting rule.
                Rule result = apiInstance.AnalyticsAlertingRulesRuleidGet(ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingRulesRuleidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
{: class="table table-striped"}

### Return type

[**Rule**](Rule.md)

<a name="AnalyticsAlertingRulesRuleidPut"></a>
## [**Rule**](Rule.html) AnalyticsAlertingRulesRuleidPut (string ruleId, Rule body = null)

Update an alerting rule.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsAlertingRulesRuleidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var ruleId = ruleId_example;  // string | Rule ID
            var body = new Rule(); // Rule | Rule (optional) 

            try
            {
                // Update an alerting rule.
                Rule result = apiInstance.AnalyticsAlertingRulesRuleidPut(ruleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsAlertingRulesRuleidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **ruleId** | **string**| Rule ID |  |
| **body** | [**Rule**](Rule.md)| Rule | [optional]  |
{: class="table table-striped"}

### Return type

[**Rule**](Rule.md)

<a name="AnalyticsMetricsQueryPost"></a>
## void AnalyticsMetricsQueryPost (Object body = null)

Executes a metrics query against the analytics service



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsMetricsQueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = ;  // Object | queryObject (optional) 

            try
            {
                // Executes a metrics query against the analytics service
                apiInstance.AnalyticsMetricsQueryPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsMetricsQueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **Object**| queryObject | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="AnalyticsReportingMetadataGet"></a>
## [**ReportMetaDataEntityListing**](ReportMetaDataEntityListing.html) AnalyticsReportingMetadataGet (int? pageNumber = null, int? pageSize = null, string acceptLanguage = null, string locale = null)

Get list of reporting metadata.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingMetadataGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var acceptLanguage = acceptLanguage_example;  // string | Accepted language (optional) 
            var locale = locale_example;  // string | Locale (optional) 

            try
            {
                // Get list of reporting metadata.
                ReportMetaDataEntityListing result = apiInstance.AnalyticsReportingMetadataGet(pageNumber, pageSize, acceptLanguage, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingMetadataGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **acceptLanguage** | **string**| Accepted language | [optional]  |
| **locale** | **string**| Locale | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportMetaDataEntityListing**](ReportMetaDataEntityListing.md)

<a name="AnalyticsReportingReportformatsGet"></a>
## List&lt;string&gt;** AnalyticsReportingReportformatsGet ()

Get a list of report formats

Get a list of report formats.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingReportformatsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();

            try
            {
                // Get a list of report formats
                List&lt;string&gt; result = apiInstance.AnalyticsReportingReportformatsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingReportformatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**List<string>**

<a name="AnalyticsReportingReportidMetadataGet"></a>
## [**ReportMetaData**](ReportMetaData.html) AnalyticsReportingReportidMetadataGet (string reportId, string acceptLanguage = null, string locale = null)

Get a reporting metadata.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingReportidMetadataGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var reportId = reportId_example;  // string | Report ID
            var acceptLanguage = acceptLanguage_example;  // string | Accepted language (optional) 
            var locale = locale_example;  // string | Locale (optional) 

            try
            {
                // Get a reporting metadata.
                ReportMetaData result = apiInstance.AnalyticsReportingReportidMetadataGet(reportId, acceptLanguage, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingReportidMetadataGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **reportId** | **string**| Report ID |  |
| **acceptLanguage** | **string**| Accepted language | [optional]  |
| **locale** | **string**| Locale | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportMetaData**](ReportMetaData.md)

<a name="AnalyticsReportingSchedulesGet"></a>
## [**ReportScheduleEntityListing**](ReportScheduleEntityListing.html) AnalyticsReportingSchedulesGet (int? pageNumber = null, int? pageSize = null)

Get a list of scheduled report jobs

Get a list of scheduled report jobs.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Get a list of scheduled report jobs
                ReportScheduleEntityListing result = apiInstance.AnalyticsReportingSchedulesGet(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportScheduleEntityListing**](ReportScheduleEntityListing.md)

<a name="AnalyticsReportingSchedulesPost"></a>
## [**ReportSchedule**](ReportSchedule.html) AnalyticsReportingSchedulesPost (ReportSchedule body = null)

Create a scheduled report job

Create a scheduled report job.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new ReportSchedule(); // ReportSchedule | ReportSchedule (optional) 

            try
            {
                // Create a scheduled report job
                ReportSchedule result = apiInstance.AnalyticsReportingSchedulesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ReportSchedule**](ReportSchedule.md)| ReportSchedule | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.md)

<a name="AnalyticsReportingSchedulesScheduleidDelete"></a>
## string** AnalyticsReportingSchedulesScheduleidDelete (string scheduleId)

Delete a scheduled report job.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            {
                // Delete a scheduled report job.
                string result = apiInstance.AnalyticsReportingSchedulesScheduleidDelete(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="AnalyticsReportingSchedulesScheduleidGet"></a>
## [**ReportSchedule**](ReportSchedule.html) AnalyticsReportingSchedulesScheduleidGet (string scheduleId)

Get a scheduled report job.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            {
                // Get a scheduled report job.
                ReportSchedule result = apiInstance.AnalyticsReportingSchedulesScheduleidGet(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.md)

<a name="AnalyticsReportingSchedulesScheduleidHistoryGet"></a>
## [**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.html) AnalyticsReportingSchedulesScheduleidHistoryGet (string scheduleId, int? pageNumber = null, int? pageSize = null)

Get list of completed scheduled report jobs.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidHistoryGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID
            var pageNumber = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)

            try
            {
                // Get list of completed scheduled report jobs.
                ReportRunEntryEntityDomainListing result = apiInstance.AnalyticsReportingSchedulesScheduleidHistoryGet(scheduleId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.md)

<a name="AnalyticsReportingSchedulesScheduleidHistoryLatestGet"></a>
## [**ReportRunEntry**](ReportRunEntry.html) AnalyticsReportingSchedulesScheduleidHistoryLatestGet (string scheduleId)

Get most recently completed scheduled report job.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidHistoryLatestGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            {
                // Get most recently completed scheduled report job.
                ReportRunEntry result = apiInstance.AnalyticsReportingSchedulesScheduleidHistoryLatestGet(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidHistoryLatestGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportRunEntry**](ReportRunEntry.md)

<a name="AnalyticsReportingSchedulesScheduleidHistoryRunidGet"></a>
## [**ReportRunEntry**](ReportRunEntry.html) AnalyticsReportingSchedulesScheduleidHistoryRunidGet (string runId, string scheduleId)

A completed scheduled report job

A completed scheduled report job.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidHistoryRunidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var runId = runId_example;  // string | Run ID
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            {
                // A completed scheduled report job
                ReportRunEntry result = apiInstance.AnalyticsReportingSchedulesScheduleidHistoryRunidGet(runId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidHistoryRunidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **runId** | **string**| Run ID |  |
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportRunEntry**](ReportRunEntry.md)

<a name="AnalyticsReportingSchedulesScheduleidPut"></a>
## [**ReportSchedule**](ReportSchedule.html) AnalyticsReportingSchedulesScheduleidPut (string scheduleId, ReportSchedule body = null)

Update a scheduled report job.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID
            var body = new ReportSchedule(); // ReportSchedule | ReportSchedule (optional) 

            try
            {
                // Update a scheduled report job.
                ReportSchedule result = apiInstance.AnalyticsReportingSchedulesScheduleidPut(scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **body** | [**ReportSchedule**](ReportSchedule.md)| ReportSchedule | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.md)

<a name="AnalyticsReportingSchedulesScheduleidRunreportPost"></a>
## [**RunNowResponse**](RunNowResponse.html) AnalyticsReportingSchedulesScheduleidRunreportPost (string scheduleId)

Place a scheduled report immediately into the reporting queue



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingSchedulesScheduleidRunreportPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID

            try
            {
                // Place a scheduled report immediately into the reporting queue
                RunNowResponse result = apiInstance.AnalyticsReportingSchedulesScheduleidRunreportPost(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingSchedulesScheduleidRunreportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**RunNowResponse**](RunNowResponse.md)

<a name="AnalyticsReportingTimeperiodsGet"></a>
## List&lt;string&gt;** AnalyticsReportingTimeperiodsGet ()

Get a list of report time periods.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsReportingTimeperiodsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();

            try
            {
                // Get a list of report time periods.
                List&lt;string&gt; result = apiInstance.AnalyticsReportingTimeperiodsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsReportingTimeperiodsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**List<string>**

<a name="AnalyticsSegmentsQueryPost"></a>
## void AnalyticsSegmentsQueryPost (Object body = null)

Executes a segments query against the analytics service



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class AnalyticsSegmentsQueryPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = ;  // Object | queryObject (optional) 

            try
            {
                // Executes a segments query against the analytics service
                apiInstance.AnalyticsSegmentsQueryPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.AnalyticsSegmentsQueryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **Object**| queryObject | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

