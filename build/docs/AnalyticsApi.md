---
title: AnalyticsApi
---
## ININ.PureCloudApi.Api.AnalyticsApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteReportingSchedule**](AnalyticsApi.html#deletereportingschedule) | **DELETE** /api/v2/analytics/reporting/schedules/{scheduleId} | Delete a scheduled report job. |
| [**GetConversationDetails**](AnalyticsApi.html#getconversationdetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetReportingMetadata**](AnalyticsApi.html#getreportingmetadata) | **GET** /api/v2/analytics/reporting/metadata | Get list of reporting metadata. |
| [**GetReportingReportIdMetadata**](AnalyticsApi.html#getreportingreportidmetadata) | **GET** /api/v2/analytics/reporting/{reportId}/metadata | Get a reporting metadata. |
| [**GetReportingReportformats**](AnalyticsApi.html#getreportingreportformats) | **GET** /api/v2/analytics/reporting/reportformats | Get a list of report formats |
| [**GetReportingSchedule**](AnalyticsApi.html#getreportingschedule) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId} | Get a scheduled report job. |
| [**GetReportingScheduleHistory**](AnalyticsApi.html#getreportingschedulehistory) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history | Get list of completed scheduled report jobs. |
| [**GetReportingScheduleHistoryLatest**](AnalyticsApi.html#getreportingschedulehistorylatest) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history/latest | Get most recently completed scheduled report job. |
| [**GetReportingScheduleHistoryRunId**](AnalyticsApi.html#getreportingschedulehistoryrunid) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history/{runId} | A completed scheduled report job |
| [**GetReportingSchedules**](AnalyticsApi.html#getreportingschedules) | **GET** /api/v2/analytics/reporting/schedules | Get a list of scheduled report jobs |
| [**GetReportingTimeperiods**](AnalyticsApi.html#getreportingtimeperiods) | **GET** /api/v2/analytics/reporting/timeperiods | Get a list of report time periods. |
| [**PostConversationDetailsProperties**](AnalyticsApi.html#postconversationdetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostConversationsAggregatesQuery**](AnalyticsApi.html#postconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostConversationsDetailsQuery**](AnalyticsApi.html#postconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostEvaluationsAggregatesQuery**](AnalyticsApi.html#postevaluationsaggregatesquery) | **POST** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostQueuesObservationsQuery**](AnalyticsApi.html#postqueuesobservationsquery) | **POST** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostReportingScheduleRunreport**](AnalyticsApi.html#postreportingschedulerunreport) | **POST** /api/v2/analytics/reporting/schedules/{scheduleId}/runreport | Place a scheduled report immediately into the reporting queue |
| [**PostReportingSchedules**](AnalyticsApi.html#postreportingschedules) | **POST** /api/v2/analytics/reporting/schedules | Create a scheduled report job |
| [**PostUsersAggregatesQuery**](AnalyticsApi.html#postusersaggregatesquery) | **POST** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostUsersObservationsQuery**](AnalyticsApi.html#postusersobservationsquery) | **POST** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PutReportingSchedule**](AnalyticsApi.html#putreportingschedule) | **PUT** /api/v2/analytics/reporting/schedules/{scheduleId} | Update a scheduled report job. |
{: class="table table-striped"}

<a name="deletereportingschedule"></a>

## **string** DeleteReportingSchedule (string scheduleId)

Delete a scheduled report job.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteReportingScheduleExample
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
                string result = apiInstance.DeleteReportingSchedule(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteReportingSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="getconversationdetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetConversationDetails (string conversationId)

Get a conversation by id



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationDetailsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var conversationId = conversationId_example;  // string | conversationId

            try
            {
                // Get a conversation by id
                AnalyticsConversation result = apiInstance.GetConversationDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetConversationDetails: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversation**](AnalyticsConversation.html)

<a name="getreportingmetadata"></a>

## [**ReportMetaDataEntityListing**](ReportMetaDataEntityListing.html) GetReportingMetadata (int? pageNumber = null, int? pageSize = null, string locale = null)

Get list of reporting metadata.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var locale = locale_example;  // string | Locale (optional) 

            try
            {
                // Get list of reporting metadata.
                ReportMetaDataEntityListing result = apiInstance.GetReportingMetadata(pageNumber, pageSize, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingMetadata: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **locale** | **string**| Locale | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportMetaDataEntityListing**](ReportMetaDataEntityListing.html)

<a name="getreportingreportidmetadata"></a>

## [**ReportMetaData**](ReportMetaData.html) GetReportingReportIdMetadata (string reportId, string locale = null)

Get a reporting metadata.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingReportIdMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var reportId = reportId_example;  // string | Report ID
            var locale = locale_example;  // string | Locale (optional) 

            try
            {
                // Get a reporting metadata.
                ReportMetaData result = apiInstance.GetReportingReportIdMetadata(reportId, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingReportIdMetadata: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **reportId** | **string**| Report ID |  |
| **locale** | **string**| Locale | [optional]  |
{: class="table table-striped"}

### Return type

[**ReportMetaData**](ReportMetaData.html)

<a name="getreportingreportformats"></a>

## **List&lt;string&gt;** GetReportingReportformats ()

Get a list of report formats

Get a list of report formats.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingReportformatsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();

            try
            {
                // Get a list of report formats
                List&lt;string&gt; result = apiInstance.GetReportingReportformats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingReportformats: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**List<string>**

<a name="getreportingschedule"></a>

## [**ReportSchedule**](ReportSchedule.html) GetReportingSchedule (string scheduleId)

Get a scheduled report job.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingScheduleExample
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
                ReportSchedule result = apiInstance.GetReportingSchedule(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.html)

<a name="getreportingschedulehistory"></a>

## [**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.html) GetReportingScheduleHistory (string scheduleId, int? pageNumber = null, int? pageSize = null)

Get list of completed scheduled report jobs.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingScheduleHistoryExample
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
                ReportRunEntryEntityDomainListing result = apiInstance.GetReportingScheduleHistory(scheduleId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingScheduleHistory: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **pageNumber** | **int?**|  | [optional] [default to 1] |
| **pageSize** | **int?**|  | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.html)

<a name="getreportingschedulehistorylatest"></a>

## [**ReportRunEntry**](ReportRunEntry.html) GetReportingScheduleHistoryLatest (string scheduleId)

Get most recently completed scheduled report job.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingScheduleHistoryLatestExample
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
                ReportRunEntry result = apiInstance.GetReportingScheduleHistoryLatest(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingScheduleHistoryLatest: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportRunEntry**](ReportRunEntry.html)

<a name="getreportingschedulehistoryrunid"></a>

## [**ReportRunEntry**](ReportRunEntry.html) GetReportingScheduleHistoryRunId (string runId, string scheduleId)

A completed scheduled report job

A completed scheduled report job.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingScheduleHistoryRunIdExample
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
                ReportRunEntry result = apiInstance.GetReportingScheduleHistoryRunId(runId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingScheduleHistoryRunId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **runId** | **string**| Run ID |  |
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**ReportRunEntry**](ReportRunEntry.html)

<a name="getreportingschedules"></a>

## [**ReportScheduleEntityListing**](ReportScheduleEntityListing.html) GetReportingSchedules (int? pageNumber = null, int? pageSize = null)

Get a list of scheduled report jobs

Get a list of scheduled report jobs.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingSchedulesExample
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
                ReportScheduleEntityListing result = apiInstance.GetReportingSchedules(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingSchedules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
{: class="table table-striped"}

### Return type

[**ReportScheduleEntityListing**](ReportScheduleEntityListing.html)

<a name="getreportingtimeperiods"></a>

## **List&lt;string&gt;** GetReportingTimeperiods ()

Get a list of report time periods.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetReportingTimeperiodsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();

            try
            {
                // Get a list of report time periods.
                List&lt;string&gt; result = apiInstance.GetReportingTimeperiods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingTimeperiods: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

**List<string>**

<a name="postconversationdetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostConversationDetailsProperties (string conversationId, PropertyIndexRequest body)

Index conversation properties



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationDetailsPropertiesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var conversationId = conversationId_example;  // string | conversationId
            var body = new PropertyIndexRequest(); // PropertyIndexRequest | request

            try
            {
                // Index conversation properties
                PropertyIndexRequest result = apiInstance.PostConversationDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostConversationDetailsProperties: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| conversationId |  |
| **body** | [**PropertyIndexRequest**](PropertyIndexRequest.html)| request |  |
{: class="table table-striped"}

### Return type

[**PropertyIndexRequest**](PropertyIndexRequest.html)

<a name="postconversationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostConversationsAggregatesQuery (AggregationQuery body)

Query for conversation aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new AggregationQuery(); // AggregationQuery | query

            try
            {
                // Query for conversation aggregates
                AggregateQueryResponse result = apiInstance.PostConversationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostConversationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postconversationsdetailsquery"></a>

## [**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html) PostConversationsDetailsQuery (ConversationQuery body)

Query for conversation details



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsDetailsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new ConversationQuery(); // ConversationQuery | query

            try
            {
                // Query for conversation details
                AnalyticsConversationQueryResponse result = apiInstance.PostConversationsDetailsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostConversationsDetailsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ConversationQuery**](ConversationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AnalyticsConversationQueryResponse**](AnalyticsConversationQueryResponse.html)

<a name="postevaluationsaggregatesquery"></a>

## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostEvaluationsAggregatesQuery (AggregationQuery body)

Query for evaluation aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEvaluationsAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new AggregationQuery(); // AggregationQuery | query

            try
            {
                // Query for evaluation aggregates
                AggregateQueryResponse result = apiInstance.PostEvaluationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostEvaluationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.html)

<a name="postqueuesobservationsquery"></a>

## [**QualifierMappingObservationQueryResponse**](QualifierMappingObservationQueryResponse.html) PostQueuesObservationsQuery (ObservationQuery body)

Query for queue observations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostQueuesObservationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new ObservationQuery(); // ObservationQuery | query

            try
            {
                // Query for queue observations
                QualifierMappingObservationQueryResponse result = apiInstance.PostQueuesObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostQueuesObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**QualifierMappingObservationQueryResponse**](QualifierMappingObservationQueryResponse.html)

<a name="postreportingschedulerunreport"></a>

## [**RunNowResponse**](RunNowResponse.html) PostReportingScheduleRunreport (string scheduleId)

Place a scheduled report immediately into the reporting queue



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostReportingScheduleRunreportExample
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
                RunNowResponse result = apiInstance.PostReportingScheduleRunreport(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostReportingScheduleRunreport: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
{: class="table table-striped"}

### Return type

[**RunNowResponse**](RunNowResponse.html)

<a name="postreportingschedules"></a>

## [**ReportSchedule**](ReportSchedule.html) PostReportingSchedules (ReportSchedule body)

Create a scheduled report job

Create a scheduled report job.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostReportingSchedulesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new ReportSchedule(); // ReportSchedule | ReportSchedule

            try
            {
                // Create a scheduled report job
                ReportSchedule result = apiInstance.PostReportingSchedules(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostReportingSchedules: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ReportSchedule**](ReportSchedule.html)| ReportSchedule |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.html)

<a name="postusersaggregatesquery"></a>

## [**PresenceQueryResponse**](PresenceQueryResponse.html) PostUsersAggregatesQuery (AggregationQuery body)

Query for user aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUsersAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new AggregationQuery(); // AggregationQuery | query

            try
            {
                // Query for user aggregates
                PresenceQueryResponse result = apiInstance.PostUsersAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostUsersAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**PresenceQueryResponse**](PresenceQueryResponse.html)

<a name="postusersobservationsquery"></a>

## [**ObservationQueryResponse**](ObservationQueryResponse.html) PostUsersObservationsQuery (ObservationQuery body)

Query for user observations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUsersObservationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var body = new ObservationQuery(); // ObservationQuery | query

            try
            {
                // Query for user observations
                ObservationQueryResponse result = apiInstance.PostUsersObservationsQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostUsersObservationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ObservationQuery**](ObservationQuery.html)| query |  |
{: class="table table-striped"}

### Return type

[**ObservationQueryResponse**](ObservationQueryResponse.html)

<a name="putreportingschedule"></a>

## [**ReportSchedule**](ReportSchedule.html) PutReportingSchedule (string scheduleId, ReportSchedule body)

Update a scheduled report job.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutReportingScheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new AnalyticsApi();
            var scheduleId = scheduleId_example;  // string | Schedule ID
            var body = new ReportSchedule(); // ReportSchedule | ReportSchedule

            try
            {
                // Update a scheduled report job.
                ReportSchedule result = apiInstance.PutReportingSchedule(scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PutReportingSchedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scheduleId** | **string**| Schedule ID |  |
| **body** | [**ReportSchedule**](ReportSchedule.html)| ReportSchedule |  |
{: class="table table-striped"}

### Return type

[**ReportSchedule**](ReportSchedule.html)

