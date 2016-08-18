---
title: CasesApi
---
## ININ.PureCloudApi.Api.CasesApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetCases**](CasesApi.html#getcases) | **GET** /api/v2/cases | Gets a list of existing cases. |
| [**PostCases**](CasesApi.html#postcases) | **POST** /api/v2/cases | Create a new case |
{: class="table table-striped"}

<a name="getcases"></a>

## [**CaseEntityListing**](CaseEntityListing.html) GetCases (int? pageNumber = null, int? pageSize = null)

Gets a list of existing cases.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCasesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CasesApi();
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)

            try
            {
                // Gets a list of existing cases.
                CaseEntityListing result = apiInstance.GetCases(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.GetCases: " + e.Message );
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

[**CaseEntityListing**](CaseEntityListing.html)

<a name="postcases"></a>

## [**ModelCase**](ModelCase.html) PostCases (ModelCase body)

Create a new case



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCasesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new CasesApi();
            var body = new ModelCase(); // ModelCase | CaseCreate

            try
            {
                // Create a new case
                ModelCase result = apiInstance.PostCases(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CasesApi.PostCases: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ModelCase**](ModelCase.html)| CaseCreate |  |
{: class="table table-striped"}

### Return type

[**ModelCase**](ModelCase.html)

