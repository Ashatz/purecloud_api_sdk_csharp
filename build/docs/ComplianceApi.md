# ININ.PureCloudApi.Api.ComplianceApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**ComplianceHipaaGet**](ComplianceApi.md#compliancehipaaget) | **GET** /api/v1/compliance/hipaa | Get information about HIPAA compliance |
| [**ComplianceHipaaPut**](ComplianceApi.md#compliancehipaaput) | **PUT** /api/v1/compliance/hipaa | Update HIPAA compliance options |
{: class="table table-striped"}

<a name="ComplianceHipaaGet"></a>
## [**HIPAAConfig**](HIPAAConfig.html) ComplianceHipaaGet ()

Get information about HIPAA compliance



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ComplianceHipaaGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ComplianceApi();

            try
            {
                // Get information about HIPAA compliance
                HIPAAConfig result = apiInstance.ComplianceHipaaGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComplianceApi.ComplianceHipaaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**HIPAAConfig**](HIPAAConfig.md)

<a name="ComplianceHipaaPut"></a>
## [**HIPAAConfig**](HIPAAConfig.html) ComplianceHipaaPut (HIPAAConfig body = null)

Update HIPAA compliance options



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ComplianceHipaaPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ComplianceApi();
            var body = new HIPAAConfig(); // HIPAAConfig |  (optional) 

            try
            {
                // Update HIPAA compliance options
                HIPAAConfig result = apiInstance.ComplianceHipaaPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComplianceApi.ComplianceHipaaPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**HIPAAConfig**](HIPAAConfig.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**HIPAAConfig**](HIPAAConfig.md)

