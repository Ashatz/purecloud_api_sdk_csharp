---
title: AnalyticsApi
---
## ININ.PureCloudApi.Api.AnalyticsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteReportingSchedulesScheduleId**](AnalyticsApi.html#deletereportingschedulesscheduleid) | **DELETE** /api/v2/analytics/reporting/schedules/{scheduleId} | Delete a scheduled report job. |
| [**GetConversationsConversationIdDetails**](AnalyticsApi.html#getconversationsconversationiddetails) | **GET** /api/v2/analytics/conversations/{conversationId}/details | Get a conversation by id |
| [**GetReportingMetadata**](AnalyticsApi.html#getreportingmetadata) | **GET** /api/v2/analytics/reporting/metadata | Get list of reporting metadata. |
| [**GetReportingReportIdMetadata**](AnalyticsApi.html#getreportingreportidmetadata) | **GET** /api/v2/analytics/reporting/{reportId}/metadata | Get a reporting metadata. |
| [**GetReportingReportformats**](AnalyticsApi.html#getreportingreportformats) | **GET** /api/v2/analytics/reporting/reportformats | Get a list of report formats |
| [**GetReportingSchedules**](AnalyticsApi.html#getreportingschedules) | **GET** /api/v2/analytics/reporting/schedules | Get a list of scheduled report jobs |
| [**GetReportingSchedulesScheduleId**](AnalyticsApi.html#getreportingschedulesscheduleid) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId} | Get a scheduled report job. |
| [**GetReportingSchedulesScheduleIdHistory**](AnalyticsApi.html#getreportingschedulesscheduleidhistory) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history | Get list of completed scheduled report jobs. |
| [**GetReportingSchedulesScheduleIdHistoryLatest**](AnalyticsApi.html#getreportingschedulesscheduleidhistorylatest) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history/latest | Get most recently completed scheduled report job. |
| [**GetReportingSchedulesScheduleIdHistoryRunId**](AnalyticsApi.html#getreportingschedulesscheduleidhistoryrunid) | **GET** /api/v2/analytics/reporting/schedules/{scheduleId}/history/{runId} | A completed scheduled report job |
| [**GetReportingTimeperiods**](AnalyticsApi.html#getreportingtimeperiods) | **GET** /api/v2/analytics/reporting/timeperiods | Get a list of report time periods. |
| [**PostConversationsAggregatesQuery**](AnalyticsApi.html#postconversationsaggregatesquery) | **POST** /api/v2/analytics/conversations/aggregates/query | Query for conversation aggregates |
| [**PostConversationsConversationIdDetailsProperties**](AnalyticsApi.html#postconversationsconversationiddetailsproperties) | **POST** /api/v2/analytics/conversations/{conversationId}/details/properties | Index conversation properties |
| [**PostConversationsDetailsQuery**](AnalyticsApi.html#postconversationsdetailsquery) | **POST** /api/v2/analytics/conversations/details/query | Query for conversation details |
| [**PostEvaluationsAggregatesQuery**](AnalyticsApi.html#postevaluationsaggregatesquery) | **POST** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostQueuesObservationsQuery**](AnalyticsApi.html#postqueuesobservationsquery) | **POST** /api/v2/analytics/queues/observations/query | Query for queue observations |
| [**PostReportingSchedules**](AnalyticsApi.html#postreportingschedules) | **POST** /api/v2/analytics/reporting/schedules | Create a scheduled report job |
| [**PostReportingSchedulesScheduleIdRunreport**](AnalyticsApi.html#postreportingschedulesscheduleidrunreport) | **POST** /api/v2/analytics/reporting/schedules/{scheduleId}/runreport | Place a scheduled report immediately into the reporting queue |
| [**PostUsersAggregatesQuery**](AnalyticsApi.html#postusersaggregatesquery) | **POST** /api/v2/analytics/users/aggregates/query | Query for user aggregates |
| [**PostUsersObservationsQuery**](AnalyticsApi.html#postusersobservationsquery) | **POST** /api/v2/analytics/users/observations/query | Query for user observations |
| [**PutReportingSchedulesScheduleId**](AnalyticsApi.html#putreportingschedulesscheduleid) | **PUT** /api/v2/analytics/reporting/schedules/{scheduleId} | Update a scheduled report job. |
{: class="table table-striped"}

<a name="deletereportingschedulesscheduleid"></a>

## **string** DeleteReportingSchedulesScheduleId (string scheduleId)

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
    public class DeleteReportingSchedulesScheduleIdExample
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
                string result = apiInstance.DeleteReportingSchedulesScheduleId(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.DeleteReportingSchedulesScheduleId: " + e.Message );
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

<a name="getconversationsconversationiddetails"></a>

## [**AnalyticsConversation**](AnalyticsConversation.html) GetConversationsConversationIdDetails (string conversationId)

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
    public class GetConversationsConversationIdDetailsExample
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
                AnalyticsConversation result = apiInstance.GetConversationsConversationIdDetails(conversationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetConversationsConversationIdDetails: " + e.Message );
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

<a name="getreportingschedulesscheduleid"></a>

## [**ReportSchedule**](ReportSchedule.html) GetReportingSchedulesScheduleId (string scheduleId)

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
    public class GetReportingSchedulesScheduleIdExample
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
                ReportSchedule result = apiInstance.GetReportingSchedulesScheduleId(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingSchedulesScheduleId: " + e.Message );
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

<a name="getreportingschedulesscheduleidhistory"></a>

## [**ReportRunEntryEntityDomainListing**](ReportRunEntryEntityDomainListing.html) GetReportingSchedulesScheduleIdHistory (string scheduleId, int? pageNumber = null, int? pageSize = null)

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
    public class GetReportingSchedulesScheduleIdHistoryExample
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
                ReportRunEntryEntityDomainListing result = apiInstance.GetReportingSchedulesScheduleIdHistory(scheduleId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingSchedulesScheduleIdHistory: " + e.Message );
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

<a name="getreportingschedulesscheduleidhistorylatest"></a>

## [**ReportRunEntry**](ReportRunEntry.html) GetReportingSchedulesScheduleIdHistoryLatest (string scheduleId)

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
    public class GetReportingSchedulesScheduleIdHistoryLatestExample
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
                ReportRunEntry result = apiInstance.GetReportingSchedulesScheduleIdHistoryLatest(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingSchedulesScheduleIdHistoryLatest: " + e.Message );
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

<a name="getreportingschedulesscheduleidhistoryrunid"></a>

## [**ReportRunEntry**](ReportRunEntry.html) GetReportingSchedulesScheduleIdHistoryRunId (string runId, string scheduleId)

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
    public class GetReportingSchedulesScheduleIdHistoryRunIdExample
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
                ReportRunEntry result = apiInstance.GetReportingSchedulesScheduleIdHistoryRunId(runId, scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.GetReportingSchedulesScheduleIdHistoryRunId: " + e.Message );
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

<a name="postconversationsconversationiddetailsproperties"></a>

## [**PropertyIndexRequest**](PropertyIndexRequest.html) PostConversationsConversationIdDetailsProperties (string conversationId, PropertyIndexRequest body)

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
    public class PostConversationsConversationIdDetailsPropertiesExample
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
                PropertyIndexRequest result = apiInstance.PostConversationsConversationIdDetailsProperties(conversationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostConversationsConversationIdDetailsProperties: " + e.Message );
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

<a name="postreportingschedulesscheduleidrunreport"></a>

## [**RunNowResponse**](RunNowResponse.html) PostReportingSchedulesScheduleIdRunreport (string scheduleId)

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
    public class PostReportingSchedulesScheduleIdRunreportExample
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
                RunNowResponse result = apiInstance.PostReportingSchedulesScheduleIdRunreport(scheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PostReportingSchedulesScheduleIdRunreport: " + e.Message );
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

<a name="putreportingschedulesscheduleid"></a>

## [**ReportSchedule**](ReportSchedule.html) PutReportingSchedulesScheduleId (string scheduleId, ReportSchedule body)

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
    public class PutReportingSchedulesScheduleIdExample
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
                ReportSchedule result = apiInstance.PutReportingSchedulesScheduleId(scheduleId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsApi.PutReportingSchedulesScheduleId: " + e.Message );
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

