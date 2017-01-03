---
title: ScriptsApi
---
## ININ.PureCloudApi.Api.ScriptsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**Get**](ScriptsApi.html#get) | **GET** /api/v2/scripts | Get the list of scripts |
| [**GetPublished**](ScriptsApi.html#getpublished) | **GET** /api/v2/scripts/published | Get the published scripts. |
| [**GetPublishedScriptId**](ScriptsApi.html#getpublishedscriptid) | **GET** /api/v2/scripts/published/{scriptId} | Get the published script. |
| [**GetPublishedScriptIdPages**](ScriptsApi.html#getpublishedscriptidpages) | **GET** /api/v2/scripts/published/{scriptId}/pages | Get the list of published pages |
| [**GetPublishedScriptIdPagesPageId**](ScriptsApi.html#getpublishedscriptidpagespageid) | **GET** /api/v2/scripts/published/{scriptId}/pages/{pageId} | Get the published page. |
| [**GetPublishedScriptIdVariables**](ScriptsApi.html#getpublishedscriptidvariables) | **GET** /api/v2/scripts/published/{scriptId}/variables | Get the published variables |
| [**GetScriptId**](ScriptsApi.html#getscriptid) | **GET** /api/v2/scripts/{scriptId} | Get a script |
| [**GetScriptIdPages**](ScriptsApi.html#getscriptidpages) | **GET** /api/v2/scripts/{scriptId}/pages | Get the list of pages |
| [**GetScriptIdPagesPageId**](ScriptsApi.html#getscriptidpagespageid) | **GET** /api/v2/scripts/{scriptId}/pages/{pageId} | Get a page |
{: class="table table-striped"}

<a name="get"></a>

## [**ScriptEntityListing**](ScriptEntityListing.html) Get (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null, string sortBy = null, string sortOrder = null)

Get the list of scripts



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name filter (optional) 
            var feature = feature_example;  // string | Feature filter (optional) 
            var flowId = flowId_example;  // string | Secure flow id filter (optional) 
            var sortBy = sortBy_example;  // string | SortBy (optional) 
            var sortOrder = sortOrder_example;  // string | SortOrder (optional) 

            try
            {
                // Get the list of scripts
                ScriptEntityListing result = apiInstance.Get(pageSize, pageNumber, expand, name, feature, flowId, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.Get: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name filter | [optional]  |
| **feature** | **string**| Feature filter | [optional]  |
| **flowId** | **string**| Secure flow id filter | [optional]  |
| **sortBy** | **string**| SortBy | [optional]  |
| **sortOrder** | **string**| SortOrder | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.html)

<a name="getpublished"></a>

## [**ScriptEntityListing**](ScriptEntityListing.html) GetPublished (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null, string flowId = null)

Get the published scripts.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name filter (optional) 
            var feature = feature_example;  // string | Feature filter (optional) 
            var flowId = flowId_example;  // string | Secure flow id filter (optional) 

            try
            {
                // Get the published scripts.
                ScriptEntityListing result = apiInstance.GetPublished(pageSize, pageNumber, expand, name, feature, flowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetPublished: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name filter | [optional]  |
| **feature** | **string**| Feature filter | [optional]  |
| **flowId** | **string**| Secure flow id filter | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.html)

<a name="getpublishedscriptid"></a>

## [**Script**](Script.html) GetPublishedScriptId (string scriptId)

Get the published script.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedScriptIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the published script.
                Script result = apiInstance.GetPublishedScriptId(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetPublishedScriptId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**Script**](Script.html)

<a name="getpublishedscriptidpages"></a>

## [**List&lt;Page&gt;**](Page.html) GetPublishedScriptIdPages (string scriptId)

Get the list of published pages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedScriptIdPagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the list of published pages
                List&lt;Page&gt; result = apiInstance.GetPublishedScriptIdPages(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetPublishedScriptIdPages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**List<Page>**](Page.html)

<a name="getpublishedscriptidpagespageid"></a>

## [**Page**](Page.html) GetPublishedScriptIdPagesPageId (string scriptId, string pageId)

Get the published page.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedScriptIdPagesPageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var pageId = pageId_example;  // string | Page ID

            try
            {
                // Get the published page.
                Page result = apiInstance.GetPublishedScriptIdPagesPageId(scriptId, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetPublishedScriptIdPagesPageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **pageId** | **string**| Page ID |  |
{: class="table table-striped"}

### Return type

[**Page**](Page.html)

<a name="getpublishedscriptidvariables"></a>

## **Object** GetPublishedScriptIdVariables (string scriptId)

Get the published variables



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedScriptIdVariablesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the published variables
                Object result = apiInstance.GetPublishedScriptIdVariables(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetPublishedScriptIdVariables: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

**Object**

<a name="getscriptid"></a>

## [**Script**](Script.html) GetScriptId (string scriptId)

Get a script



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetScriptIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get a script
                Script result = apiInstance.GetScriptId(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**Script**](Script.html)

<a name="getscriptidpages"></a>

## [**List&lt;Page&gt;**](Page.html) GetScriptIdPages (string scriptId)

Get the list of pages



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetScriptIdPagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID

            try
            {
                // Get the list of pages
                List&lt;Page&gt; result = apiInstance.GetScriptIdPages(scriptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptIdPages: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
{: class="table table-striped"}

### Return type

[**List<Page>**](Page.html)

<a name="getscriptidpagespageid"></a>

## [**Page**](Page.html) GetScriptIdPagesPageId (string scriptId, string pageId)

Get a page



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetScriptIdPagesPageIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var scriptId = scriptId_example;  // string | Script ID
            var pageId = pageId_example;  // string | Page ID

            try
            {
                // Get a page
                Page result = apiInstance.GetScriptIdPagesPageId(scriptId, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptIdPagesPageId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **scriptId** | **string**| Script ID |  |
| **pageId** | **string**| Page ID |  |
{: class="table table-striped"}

### Return type

[**Page**](Page.html)

