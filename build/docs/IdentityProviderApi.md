---
title: IdentityProviderApi
---
## ININ.PureCloudApi.Api.IdentityProviderApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | Description |
| ------------- | ------------- |
| [**DeleteAdfs**](IdentityProviderApi.html#deleteadfs) | Delete ADFS Identity Provider |
| [**DeleteCic**](IdentityProviderApi.html#deletecic) | Delete Customer Interaction Center (CIC) Identity Provider |
| [**DeleteOkta**](IdentityProviderApi.html#deleteokta) | Delete Okta Identity Provider |
| [**DeleteOnelogin**](IdentityProviderApi.html#deleteonelogin) | Delete OneLogin Identity Provider |
| [**DeleteProviderId**](IdentityProviderApi.html#deleteproviderid) | Delete an identity provider |
| [**DeletePurecloud**](IdentityProviderApi.html#deletepurecloud) | Delete PureCloud Identity Provider |
| [**DeleteSalesforce**](IdentityProviderApi.html#deletesalesforce) | Delete Salesforce Identity Provider |
| [**GetAdfs**](IdentityProviderApi.html#getadfs) | Get ADFS Identity Provider |
| [**GetCic**](IdentityProviderApi.html#getcic) | Get Customer Interaction Center (CIC) Identity Provider |
| [**GetIdentityproviders**](IdentityProviderApi.html#getidentityproviders) | The list of identity providers |
| [**GetOkta**](IdentityProviderApi.html#getokta) | Get Okta Identity Provider |
| [**GetOnelogin**](IdentityProviderApi.html#getonelogin) | Get OneLogin Identity Provider |
| [**GetProviderId**](IdentityProviderApi.html#getproviderid) | Get an identity provider |
| [**GetPurecloud**](IdentityProviderApi.html#getpurecloud) | Get PureCloud Identity Provider |
| [**GetSalesforce**](IdentityProviderApi.html#getsalesforce) | Get Salesforce Identity Provider |
| [**PutAdfs**](IdentityProviderApi.html#putadfs) | Update/Create ADFS Identity Provider |
| [**PutCic**](IdentityProviderApi.html#putcic) | Update/Create Customer Interaction Center (CIC) Identity Provider |
| [**PutOkta**](IdentityProviderApi.html#putokta) | Update/Create Okta Identity Provider |
| [**PutOnelogin**](IdentityProviderApi.html#putonelogin) | Update/Create OneLogin Identity Provider |
| [**PutProviderId**](IdentityProviderApi.html#putproviderid) | Update an identity provider |
| [**PutPurecloud**](IdentityProviderApi.html#putpurecloud) | Update/Create PureCloud Identity Provider |
| [**PutSalesforce**](IdentityProviderApi.html#putsalesforce) | Update/Create Salesforce Identity Provider |
{: class="table table-striped"}

<a name="deleteadfs"></a>

## void DeleteAdfs ()

Delete ADFS Identity Provider



Wraps DELETE /api/v2/identityproviders/adfs 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteAdfsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete ADFS Identity Provider
                apiInstance.DeleteAdfs();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteAdfs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletecic"></a>

## void DeleteCic ()

Delete Customer Interaction Center (CIC) Identity Provider



Wraps DELETE /api/v2/identityproviders/cic 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCicExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete Customer Interaction Center (CIC) Identity Provider
                apiInstance.DeleteCic();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteCic: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteokta"></a>

## void DeleteOkta ()

Delete Okta Identity Provider



Wraps DELETE /api/v2/identityproviders/okta 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOktaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete Okta Identity Provider
                apiInstance.DeleteOkta();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteOkta: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteonelogin"></a>

## void DeleteOnelogin ()

Delete OneLogin Identity Provider



Wraps DELETE /api/v2/identityproviders/onelogin 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOneloginExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete OneLogin Identity Provider
                apiInstance.DeleteOnelogin();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteOnelogin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deleteproviderid"></a>

## void DeleteProviderId ()

Delete an identity provider



Wraps DELETE /api/v2/identityproviders/{providerId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProviderIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete an identity provider
                apiInstance.DeleteProviderId();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteProviderId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletepurecloud"></a>

## void DeletePurecloud ()

Delete PureCloud Identity Provider



Wraps DELETE /api/v2/identityproviders/purecloud 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeletePurecloudExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete PureCloud Identity Provider
                apiInstance.DeletePurecloud();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeletePurecloud: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="deletesalesforce"></a>

## void DeleteSalesforce ()

Delete Salesforce Identity Provider



Wraps DELETE /api/v2/identityproviders/salesforce 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSalesforceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Delete Salesforce Identity Provider
                apiInstance.DeleteSalesforce();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.DeleteSalesforce: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="getadfs"></a>

## [**ADFS**](ADFS.html) GetAdfs ()

Get ADFS Identity Provider



Wraps GET /api/v2/identityproviders/adfs 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetAdfsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get ADFS Identity Provider
                ADFS result = apiInstance.GetAdfs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetAdfs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ADFS**](ADFS.html)

<a name="getcic"></a>

## [**CustomerInteractionCenter**](CustomerInteractionCenter.html) GetCic ()

Get Customer Interaction Center (CIC) Identity Provider



Wraps GET /api/v2/identityproviders/cic 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCicExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get Customer Interaction Center (CIC) Identity Provider
                CustomerInteractionCenter result = apiInstance.GetCic();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetCic: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**CustomerInteractionCenter**](CustomerInteractionCenter.html)

<a name="getidentityproviders"></a>

## [**OAuthProviderEntityListing**](OAuthProviderEntityListing.html) GetIdentityproviders ()

The list of identity providers



Wraps GET /api/v2/identityproviders 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetIdentityprovidersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // The list of identity providers
                OAuthProviderEntityListing result = apiInstance.GetIdentityproviders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetIdentityproviders: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthProviderEntityListing**](OAuthProviderEntityListing.html)

<a name="getokta"></a>

## [**Okta**](Okta.html) GetOkta ()

Get Okta Identity Provider



Wraps GET /api/v2/identityproviders/okta 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOktaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get Okta Identity Provider
                Okta result = apiInstance.GetOkta();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetOkta: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Okta**](Okta.html)

<a name="getonelogin"></a>

## [**OneLogin**](OneLogin.html) GetOnelogin ()

Get OneLogin Identity Provider



Wraps GET /api/v2/identityproviders/onelogin 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOneloginExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get OneLogin Identity Provider
                OneLogin result = apiInstance.GetOnelogin();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetOnelogin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OneLogin**](OneLogin.html)

<a name="getproviderid"></a>

## [**OAuthProvider**](OAuthProvider.html) GetProviderId ()

Get an identity provider



Wraps GET /api/v2/identityproviders/{providerId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProviderIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get an identity provider
                OAuthProvider result = apiInstance.GetProviderId();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetProviderId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.html)

<a name="getpurecloud"></a>

## [**PureCloud**](PureCloud.html) GetPurecloud ()

Get PureCloud Identity Provider



Wraps GET /api/v2/identityproviders/purecloud 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPurecloudExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get PureCloud Identity Provider
                PureCloud result = apiInstance.GetPurecloud();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetPurecloud: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**PureCloud**](PureCloud.html)

<a name="getsalesforce"></a>

## [**Salesforce**](Salesforce.html) GetSalesforce ()

Get Salesforce Identity Provider



Wraps GET /api/v2/identityproviders/salesforce 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSalesforceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();

            try
            {
                // Get Salesforce Identity Provider
                Salesforce result = apiInstance.GetSalesforce();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.GetSalesforce: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Salesforce**](Salesforce.html)

<a name="putadfs"></a>

## void PutAdfs (ADFS body)

Update/Create ADFS Identity Provider



Wraps PUT /api/v2/identityproviders/adfs 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutAdfsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new ADFS(); // ADFS | Provider

            try
            {
                // Update/Create ADFS Identity Provider
                apiInstance.PutAdfs(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutAdfs: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**ADFS**](ADFS.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putcic"></a>

## void PutCic (CustomerInteractionCenter body)

Update/Create Customer Interaction Center (CIC) Identity Provider



Wraps PUT /api/v2/identityproviders/cic 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutCicExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new CustomerInteractionCenter(); // CustomerInteractionCenter | Provider

            try
            {
                // Update/Create Customer Interaction Center (CIC) Identity Provider
                apiInstance.PutCic(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutCic: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**CustomerInteractionCenter**](CustomerInteractionCenter.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putokta"></a>

## void PutOkta (Okta body)

Update/Create Okta Identity Provider



Wraps PUT /api/v2/identityproviders/okta 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOktaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new Okta(); // Okta | Provider

            try
            {
                // Update/Create Okta Identity Provider
                apiInstance.PutOkta(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutOkta: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Okta**](Okta.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putonelogin"></a>

## void PutOnelogin (OneLogin body)

Update/Create OneLogin Identity Provider



Wraps PUT /api/v2/identityproviders/onelogin 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOneloginExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new OneLogin(); // OneLogin | Provider

            try
            {
                // Update/Create OneLogin Identity Provider
                apiInstance.PutOnelogin(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutOnelogin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OneLogin**](OneLogin.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putproviderid"></a>

## void PutProviderId (OAuthProvider body)

Update an identity provider



Wraps PUT /api/v2/identityproviders/{providerId} 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProviderIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new OAuthProvider(); // OAuthProvider | Provider

            try
            {
                // Update an identity provider
                apiInstance.PutProviderId(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutProviderId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthProvider**](OAuthProvider.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putpurecloud"></a>

## void PutPurecloud (PureCloud body)

Update/Create PureCloud Identity Provider



Wraps PUT /api/v2/identityproviders/purecloud 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutPurecloudExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new PureCloud(); // PureCloud | Provider

            try
            {
                // Update/Create PureCloud Identity Provider
                apiInstance.PutPurecloud(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutPurecloud: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PureCloud**](PureCloud.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="putsalesforce"></a>

## void PutSalesforce (Salesforce body)

Update/Create Salesforce Identity Provider



Wraps PUT /api/v2/identityproviders/salesforce 

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutSalesforceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new IdentityProviderApi();
            var body = new Salesforce(); // Salesforce | Provider

            try
            {
                // Update/Create Salesforce Identity Provider
                apiInstance.PutSalesforce(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.PutSalesforce: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Salesforce**](Salesforce.html)| Provider |  |
{: class="table table-striped"}

### Return type

void (empty response body)

