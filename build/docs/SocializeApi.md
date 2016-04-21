# ININ.PureCloudApi.Api.SocializeApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**SocializeExpressionsPublishedGet**](SocializeApi.md#socializeexpressionspublishedget) | **GET** /api/v1/socialize/expressions/published | Get all published expressions. |
| [**SocializeExpressionsPublishedPost**](SocializeApi.md#socializeexpressionspublishedpost) | **POST** /api/v1/socialize/expressions/published | Create published expression. |
| [**SocializeExpressionsPublishedPublishedexpressionidDelete**](SocializeApi.md#socializeexpressionspublishedpublishedexpressioniddelete) | **DELETE** /api/v1/socialize/expressions/published/{publishedExpressionId} | Delete published expression. |
| [**SocializeExpressionsPublishedPublishedexpressionidGet**](SocializeApi.md#socializeexpressionspublishedpublishedexpressionidget) | **GET** /api/v1/socialize/expressions/published/{publishedExpressionId} | Get published expression |
| [**SocializeExpressionsPublishedPublishedexpressionidPut**](SocializeApi.md#socializeexpressionspublishedpublishedexpressionidput) | **PUT** /api/v1/socialize/expressions/published/{publishedExpressionId} | Update published expression. |
| [**SocializeExpressionsTwitterExpressionidDelete**](SocializeApi.md#socializeexpressionstwitterexpressioniddelete) | **DELETE** /api/v1/socialize/expressions/twitter/{expressionId} | Delete TwitterExpression. |
| [**SocializeExpressionsTwitterExpressionidGet**](SocializeApi.md#socializeexpressionstwitterexpressionidget) | **GET** /api/v1/socialize/expressions/twitter/{expressionId} | Get TwitterExpression. |
| [**SocializeExpressionsTwitterExpressionidPut**](SocializeApi.md#socializeexpressionstwitterexpressionidput) | **PUT** /api/v1/socialize/expressions/twitter/{expressionId} | Update TwitterExpression. |
| [**SocializeExpressionsTwitterGet**](SocializeApi.md#socializeexpressionstwitterget) | **GET** /api/v1/socialize/expressions/twitter | Get all configured expressions. |
| [**SocializeExpressionsTwitterPost**](SocializeApi.md#socializeexpressionstwitterpost) | **POST** /api/v1/socialize/expressions/twitter | Create twitter expression. |
| [**SocializeGistenersGet**](SocializeApi.md#socializegistenersget) | **GET** /api/v1/socialize/gisteners | Get all configured gisteners. |
| [**SocializeGistenersGisteneridDelete**](SocializeApi.md#socializegistenersgisteneriddelete) | **DELETE** /api/v1/socialize/gisteners/{gistenerId} | Delete gistener. |
| [**SocializeGistenersGisteneridGet**](SocializeApi.md#socializegistenersgisteneridget) | **GET** /api/v1/socialize/gisteners/{gistenerId} | Get gistener. |
| [**SocializeGistenersGisteneridPut**](SocializeApi.md#socializegistenersgisteneridput) | **PUT** /api/v1/socialize/gisteners/{gistenerId} | Update gistener. |
| [**SocializeGistenersPost**](SocializeApi.md#socializegistenerspost) | **POST** /api/v1/socialize/gisteners | Create gistener. |
| [**SocializeGrouptagsGet**](SocializeApi.md#socializegrouptagsget) | **GET** /api/v1/socialize/grouptags | Get all configured groupTags. |
| [**SocializeGrouptagsGrouptagidDelete**](SocializeApi.md#socializegrouptagsgrouptagiddelete) | **DELETE** /api/v1/socialize/grouptags/{groupTagId} | Delete grouptag. |
| [**SocializeGrouptagsGrouptagidGet**](SocializeApi.md#socializegrouptagsgrouptagidget) | **GET** /api/v1/socialize/grouptags/{groupTagId} | Get grouptag. |
| [**SocializeGrouptagsGrouptagidPut**](SocializeApi.md#socializegrouptagsgrouptagidput) | **PUT** /api/v1/socialize/grouptags/{groupTagId} | Update grouptag. |
| [**SocializeGrouptagsPost**](SocializeApi.md#socializegrouptagspost) | **POST** /api/v1/socialize/grouptags | Create grouptag. |
| [**SocializePublicationsGet**](SocializeApi.md#socializepublicationsget) | **GET** /api/v1/socialize/publications | Get all configured publications. |
| [**SocializePublicationsPost**](SocializeApi.md#socializepublicationspost) | **POST** /api/v1/socialize/publications | Create publication. |
| [**SocializePublicationsPublicationidDelete**](SocializeApi.md#socializepublicationspublicationiddelete) | **DELETE** /api/v1/socialize/publications/{publicationId} | Delete publication. |
| [**SocializePublicationsPublicationidGet**](SocializeApi.md#socializepublicationspublicationidget) | **GET** /api/v1/socialize/publications/{publicationId} | Get publication. |
| [**SocializePublicationsPublicationidPut**](SocializeApi.md#socializepublicationspublicationidput) | **PUT** /api/v1/socialize/publications/{publicationId} | Update publication. |
| [**SocializeSocialaccountsGet**](SocializeApi.md#socializesocialaccountsget) | **GET** /api/v1/socialize/socialaccounts | Get all social accounts. |
| [**SocializeSocialaccountsPost**](SocializeApi.md#socializesocialaccountspost) | **POST** /api/v1/socialize/socialaccounts | Create social account. |
| [**SocializeSocialaccountsSocialaccountidDelete**](SocializeApi.md#socializesocialaccountssocialaccountiddelete) | **DELETE** /api/v1/socialize/socialaccounts/{socialAccountId} | Delete social account. |
| [**SocializeSocialaccountsSocialaccountidGet**](SocializeApi.md#socializesocialaccountssocialaccountidget) | **GET** /api/v1/socialize/socialaccounts/{socialAccountId} | Get social account |
| [**SocializeSocialaccountsSocialaccountidPatch**](SocializeApi.md#socializesocialaccountssocialaccountidpatch) | **PATCH** /api/v1/socialize/socialaccounts/{socialAccountId} | Enabled/Disable feed for social account. |
| [**SocializeSocialaccountsSocialaccountidPut**](SocializeApi.md#socializesocialaccountssocialaccountidput) | **PUT** /api/v1/socialize/socialaccounts/{socialAccountId} | Update social account. |
{: class="table table-striped"}

<a name="SocializeExpressionsPublishedGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) SocializeExpressionsPublishedGet (int? pageSize = null, int? pageNumber = null)

Get all published expressions.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsPublishedGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get all published expressions.
                DomainEntityListing result = apiInstance.SocializeExpressionsPublishedGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsPublishedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="SocializeExpressionsPublishedPost"></a>
## [**PublishedExpression**](PublishedExpression.html) SocializeExpressionsPublishedPost (PublishedExpression body = null)

Create published expression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsPublishedPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var body = new PublishedExpression(); // PublishedExpression | PublishedExpression (optional) 

            try
            {
                // Create published expression.
                PublishedExpression result = apiInstance.SocializeExpressionsPublishedPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsPublishedPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PublishedExpression**](PublishedExpression.md)| PublishedExpression | [optional]  |
{: class="table table-striped"}

### Return type

[**PublishedExpression**](PublishedExpression.md)

<a name="SocializeExpressionsPublishedPublishedexpressionidDelete"></a>
## string** SocializeExpressionsPublishedPublishedexpressionidDelete (string publishedExpressionId)

Delete published expression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsPublishedPublishedexpressionidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var publishedExpressionId = publishedExpressionId_example;  // string | Published TwitterExpression ID

            try
            {
                // Delete published expression.
                string result = apiInstance.SocializeExpressionsPublishedPublishedexpressionidDelete(publishedExpressionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsPublishedPublishedexpressionidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **publishedExpressionId** | **string**| Published TwitterExpression ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="SocializeExpressionsPublishedPublishedexpressionidGet"></a>
## [**PublishedExpression**](PublishedExpression.html) SocializeExpressionsPublishedPublishedexpressionidGet (string publishedExpressionId)

Get published expression



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsPublishedPublishedexpressionidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var publishedExpressionId = publishedExpressionId_example;  // string | Published TwitterExpression ID

            try
            {
                // Get published expression
                PublishedExpression result = apiInstance.SocializeExpressionsPublishedPublishedexpressionidGet(publishedExpressionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsPublishedPublishedexpressionidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **publishedExpressionId** | **string**| Published TwitterExpression ID |  |
{: class="table table-striped"}

### Return type

[**PublishedExpression**](PublishedExpression.md)

<a name="SocializeExpressionsPublishedPublishedexpressionidPut"></a>
## [**PublishedExpression**](PublishedExpression.html) SocializeExpressionsPublishedPublishedexpressionidPut (string publishedExpressionId, PublishedExpression body = null)

Update published expression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsPublishedPublishedexpressionidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var publishedExpressionId = publishedExpressionId_example;  // string | Published TwitterExpression ID
            var body = new PublishedExpression(); // PublishedExpression | PublishedExpression (optional) 

            try
            {
                // Update published expression.
                PublishedExpression result = apiInstance.SocializeExpressionsPublishedPublishedexpressionidPut(publishedExpressionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsPublishedPublishedexpressionidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **publishedExpressionId** | **string**| Published TwitterExpression ID |  |
| **body** | [**PublishedExpression**](PublishedExpression.md)| PublishedExpression | [optional]  |
{: class="table table-striped"}

### Return type

[**PublishedExpression**](PublishedExpression.md)

<a name="SocializeExpressionsTwitterExpressionidDelete"></a>
## string** SocializeExpressionsTwitterExpressionidDelete (string expressionId)

Delete TwitterExpression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsTwitterExpressionidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var expressionId = expressionId_example;  // string | TwitterExpression ID

            try
            {
                // Delete TwitterExpression.
                string result = apiInstance.SocializeExpressionsTwitterExpressionidDelete(expressionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsTwitterExpressionidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expressionId** | **string**| TwitterExpression ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="SocializeExpressionsTwitterExpressionidGet"></a>
## [**TwitterExpression**](TwitterExpression.html) SocializeExpressionsTwitterExpressionidGet (string expressionId)

Get TwitterExpression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsTwitterExpressionidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var expressionId = expressionId_example;  // string | TwitterExpression ID

            try
            {
                // Get TwitterExpression.
                TwitterExpression result = apiInstance.SocializeExpressionsTwitterExpressionidGet(expressionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsTwitterExpressionidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expressionId** | **string**| TwitterExpression ID |  |
{: class="table table-striped"}

### Return type

[**TwitterExpression**](TwitterExpression.md)

<a name="SocializeExpressionsTwitterExpressionidPut"></a>
## [**TwitterExpression**](TwitterExpression.html) SocializeExpressionsTwitterExpressionidPut (string expressionId, TwitterExpression body = null)

Update TwitterExpression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsTwitterExpressionidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var expressionId = expressionId_example;  // string | TwitterExpression ID
            var body = new TwitterExpression(); // TwitterExpression | TwitterExpression (optional) 

            try
            {
                // Update TwitterExpression.
                TwitterExpression result = apiInstance.SocializeExpressionsTwitterExpressionidPut(expressionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsTwitterExpressionidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expressionId** | **string**| TwitterExpression ID |  |
| **body** | [**TwitterExpression**](TwitterExpression.md)| TwitterExpression | [optional]  |
{: class="table table-striped"}

### Return type

[**TwitterExpression**](TwitterExpression.md)

<a name="SocializeExpressionsTwitterGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) SocializeExpressionsTwitterGet (int? pageSize = null, int? pageNumber = null)

Get all configured expressions.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsTwitterGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get all configured expressions.
                DomainEntityListing result = apiInstance.SocializeExpressionsTwitterGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsTwitterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="SocializeExpressionsTwitterPost"></a>
## [**TwitterExpression**](TwitterExpression.html) SocializeExpressionsTwitterPost (TwitterExpression body = null)

Create twitter expression.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeExpressionsTwitterPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var body = new TwitterExpression(); // TwitterExpression | TwitterExpression (optional) 

            try
            {
                // Create twitter expression.
                TwitterExpression result = apiInstance.SocializeExpressionsTwitterPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeExpressionsTwitterPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**TwitterExpression**](TwitterExpression.md)| TwitterExpression | [optional]  |
{: class="table table-striped"}

### Return type

[**TwitterExpression**](TwitterExpression.md)

<a name="SocializeGistenersGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) SocializeGistenersGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)

Get all configured gisteners.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGistenersGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var enabled = true;  // bool? | Enabled Only (optional)  (default to false)

            try
            {
                // Get all configured gisteners.
                DomainEntityListing result = apiInstance.SocializeGistenersGet(pageSize, pageNumber, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGistenersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **enabled** | **bool?**| Enabled Only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="SocializeGistenersGisteneridDelete"></a>
## string** SocializeGistenersGisteneridDelete (string gistenerId)

Delete gistener.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGistenersGisteneridDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var gistenerId = gistenerId_example;  // string | Gistener ID

            try
            {
                // Delete gistener.
                string result = apiInstance.SocializeGistenersGisteneridDelete(gistenerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGistenersGisteneridDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **gistenerId** | **string**| Gistener ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="SocializeGistenersGisteneridGet"></a>
## [**Gistener**](Gistener.html) SocializeGistenersGisteneridGet (string gistenerId)

Get gistener.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGistenersGisteneridGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var gistenerId = gistenerId_example;  // string | Gistener ID

            try
            {
                // Get gistener.
                Gistener result = apiInstance.SocializeGistenersGisteneridGet(gistenerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGistenersGisteneridGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **gistenerId** | **string**| Gistener ID |  |
{: class="table table-striped"}

### Return type

[**Gistener**](Gistener.md)

<a name="SocializeGistenersGisteneridPut"></a>
## [**Gistener**](Gistener.html) SocializeGistenersGisteneridPut (string gistenerId, Gistener body = null)

Update gistener.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGistenersGisteneridPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var gistenerId = gistenerId_example;  // string | Gistener ID
            var body = new Gistener(); // Gistener | Gistener (optional) 

            try
            {
                // Update gistener.
                Gistener result = apiInstance.SocializeGistenersGisteneridPut(gistenerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGistenersGisteneridPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **gistenerId** | **string**| Gistener ID |  |
| **body** | [**Gistener**](Gistener.md)| Gistener | [optional]  |
{: class="table table-striped"}

### Return type

[**Gistener**](Gistener.md)

<a name="SocializeGistenersPost"></a>
## [**Gistener**](Gistener.html) SocializeGistenersPost (Gistener body = null, bool? preview = null)

Create gistener.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGistenersPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var body = new Gistener(); // Gistener | Gistener (optional) 
            var preview = true;  // bool? | Preview Only (optional)  (default to false)

            try
            {
                // Create gistener.
                Gistener result = apiInstance.SocializeGistenersPost(body, preview);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGistenersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Gistener**](Gistener.md)| Gistener | [optional]  |
| **preview** | **bool?**| Preview Only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**Gistener**](Gistener.md)

<a name="SocializeGrouptagsGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) SocializeGrouptagsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)

Get all configured groupTags.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGrouptagsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var enabled = true;  // bool? | Enabled Only (optional)  (default to false)

            try
            {
                // Get all configured groupTags.
                DomainEntityListing result = apiInstance.SocializeGrouptagsGet(pageSize, pageNumber, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGrouptagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **enabled** | **bool?**| Enabled Only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="SocializeGrouptagsGrouptagidDelete"></a>
## string** SocializeGrouptagsGrouptagidDelete (string groupTagId)

Delete grouptag.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGrouptagsGrouptagidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var groupTagId = groupTagId_example;  // string | grouptag ID

            try
            {
                // Delete grouptag.
                string result = apiInstance.SocializeGrouptagsGrouptagidDelete(groupTagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGrouptagsGrouptagidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupTagId** | **string**| grouptag ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="SocializeGrouptagsGrouptagidGet"></a>
## [**GroupTag**](GroupTag.html) SocializeGrouptagsGrouptagidGet (string groupTagId)

Get grouptag.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGrouptagsGrouptagidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var groupTagId = groupTagId_example;  // string | grouptag ID

            try
            {
                // Get grouptag.
                GroupTag result = apiInstance.SocializeGrouptagsGrouptagidGet(groupTagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGrouptagsGrouptagidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupTagId** | **string**| grouptag ID |  |
{: class="table table-striped"}

### Return type

[**GroupTag**](GroupTag.md)

<a name="SocializeGrouptagsGrouptagidPut"></a>
## [**Gistener**](Gistener.html) SocializeGrouptagsGrouptagidPut (string groupTagId, GroupTag body = null)

Update grouptag.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGrouptagsGrouptagidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var groupTagId = groupTagId_example;  // string | grouptag ID
            var body = new GroupTag(); // GroupTag | grouptag (optional) 

            try
            {
                // Update grouptag.
                Gistener result = apiInstance.SocializeGrouptagsGrouptagidPut(groupTagId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGrouptagsGrouptagidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupTagId** | **string**| grouptag ID |  |
| **body** | [**GroupTag**](GroupTag.md)| grouptag | [optional]  |
{: class="table table-striped"}

### Return type

[**Gistener**](Gistener.md)

<a name="SocializeGrouptagsPost"></a>
## [**GroupTag**](GroupTag.html) SocializeGrouptagsPost (GroupTag body = null)

Create grouptag.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeGrouptagsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var body = new GroupTag(); // GroupTag | grouptag (optional) 

            try
            {
                // Create grouptag.
                GroupTag result = apiInstance.SocializeGrouptagsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeGrouptagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**GroupTag**](GroupTag.md)| grouptag | [optional]  |
{: class="table table-striped"}

### Return type

[**GroupTag**](GroupTag.md)

<a name="SocializePublicationsGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) SocializePublicationsGet (int? pageSize = null, int? pageNumber = null)

Get all configured publications.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializePublicationsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get all configured publications.
                DomainEntityListing result = apiInstance.SocializePublicationsGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializePublicationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="SocializePublicationsPost"></a>
## [**Publication**](Publication.html) SocializePublicationsPost (Publication body = null)

Create publication.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializePublicationsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var body = new Publication(); // Publication | Publication (optional) 

            try
            {
                // Create publication.
                Publication result = apiInstance.SocializePublicationsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializePublicationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Publication**](Publication.md)| Publication | [optional]  |
{: class="table table-striped"}

### Return type

[**Publication**](Publication.md)

<a name="SocializePublicationsPublicationidDelete"></a>
## string** SocializePublicationsPublicationidDelete (string publicationId)

Delete publication.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializePublicationsPublicationidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var publicationId = publicationId_example;  // string | Publication ID

            try
            {
                // Delete publication.
                string result = apiInstance.SocializePublicationsPublicationidDelete(publicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializePublicationsPublicationidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **publicationId** | **string**| Publication ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="SocializePublicationsPublicationidGet"></a>
## [**Publication**](Publication.html) SocializePublicationsPublicationidGet (string publicationId)

Get publication.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializePublicationsPublicationidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var publicationId = publicationId_example;  // string | Publication ID

            try
            {
                // Get publication.
                Publication result = apiInstance.SocializePublicationsPublicationidGet(publicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializePublicationsPublicationidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **publicationId** | **string**| Publication ID |  |
{: class="table table-striped"}

### Return type

[**Publication**](Publication.md)

<a name="SocializePublicationsPublicationidPut"></a>
## [**Gistener**](Gistener.html) SocializePublicationsPublicationidPut (string publicationId, Publication body = null)

Update publication.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializePublicationsPublicationidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var publicationId = publicationId_example;  // string | Publication ID
            var body = new Publication(); // Publication | Publication (optional) 

            try
            {
                // Update publication.
                Gistener result = apiInstance.SocializePublicationsPublicationidPut(publicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializePublicationsPublicationidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **publicationId** | **string**| Publication ID |  |
| **body** | [**Publication**](Publication.md)| Publication | [optional]  |
{: class="table table-striped"}

### Return type

[**Gistener**](Gistener.md)

<a name="SocializeSocialaccountsGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) SocializeSocialaccountsGet (int? pageSize = null, int? pageNumber = null, bool? enabled = null)

Get all social accounts.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeSocialaccountsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var enabled = true;  // bool? | Enabled Only (optional)  (default to false)

            try
            {
                // Get all social accounts.
                DomainEntityListing result = apiInstance.SocializeSocialaccountsGet(pageSize, pageNumber, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeSocialaccountsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
| **enabled** | **bool?**| Enabled Only | [optional] [default to false] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="SocializeSocialaccountsPost"></a>
## [**SocialAccount**](SocialAccount.html) SocializeSocialaccountsPost (SocialAccount body = null)

Create social account.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeSocialaccountsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var body = new SocialAccount(); // SocialAccount | SocialAccount (optional) 

            try
            {
                // Create social account.
                SocialAccount result = apiInstance.SocializeSocialaccountsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeSocialaccountsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**SocialAccount**](SocialAccount.md)| SocialAccount | [optional]  |
{: class="table table-striped"}

### Return type

[**SocialAccount**](SocialAccount.md)

<a name="SocializeSocialaccountsSocialaccountidDelete"></a>
## string** SocializeSocialaccountsSocialaccountidDelete (string socialAccountId, bool? enabled)

Delete social account.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeSocialaccountsSocialaccountidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var socialAccountId = socialAccountId_example;  // string | Social Account ID
            var enabled = true;  // bool? | Streaming Enabled

            try
            {
                // Delete social account.
                string result = apiInstance.SocializeSocialaccountsSocialaccountidDelete(socialAccountId, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeSocialaccountsSocialaccountidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **socialAccountId** | **string**| Social Account ID |  |
| **enabled** | **bool?**| Streaming Enabled |  |
{: class="table table-striped"}

### Return type

**string**

<a name="SocializeSocialaccountsSocialaccountidGet"></a>
## [**SocialAccount**](SocialAccount.html) SocializeSocialaccountsSocialaccountidGet (string socialAccountId, bool? enabled)

Get social account



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeSocialaccountsSocialaccountidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var socialAccountId = socialAccountId_example;  // string | Social Account ID
            var enabled = true;  // bool? | Streaming Enabled

            try
            {
                // Get social account
                SocialAccount result = apiInstance.SocializeSocialaccountsSocialaccountidGet(socialAccountId, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeSocialaccountsSocialaccountidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **socialAccountId** | **string**| Social Account ID |  |
| **enabled** | **bool?**| Streaming Enabled |  |
{: class="table table-striped"}

### Return type

[**SocialAccount**](SocialAccount.md)

<a name="SocializeSocialaccountsSocialaccountidPatch"></a>
## bool?** SocializeSocialaccountsSocialaccountidPatch (string socialAccountId, bool? enabled)

Enabled/Disable feed for social account.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeSocialaccountsSocialaccountidPatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var socialAccountId = socialAccountId_example;  // string | Social Account ID
            var enabled = true;  // bool? | Streaming Enabled

            try
            {
                // Enabled/Disable feed for social account.
                bool? result = apiInstance.SocializeSocialaccountsSocialaccountidPatch(socialAccountId, enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeSocialaccountsSocialaccountidPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **socialAccountId** | **string**| Social Account ID |  |
| **enabled** | **bool?**| Streaming Enabled |  |
{: class="table table-striped"}

### Return type

**bool?**

<a name="SocializeSocialaccountsSocialaccountidPut"></a>
## [**SocialAccount**](SocialAccount.html) SocializeSocialaccountsSocialaccountidPut (string socialAccountId, bool? enabled, SocialAccount body = null)

Update social account.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class SocializeSocialaccountsSocialaccountidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new SocializeApi();
            var socialAccountId = socialAccountId_example;  // string | Social Account ID
            var enabled = true;  // bool? | Streaming Enabled
            var body = new SocialAccount(); // SocialAccount | SocialAccount (optional) 

            try
            {
                // Update social account.
                SocialAccount result = apiInstance.SocializeSocialaccountsSocialaccountidPut(socialAccountId, enabled, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocializeApi.SocializeSocialaccountsSocialaccountidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **socialAccountId** | **string**| Social Account ID |  |
| **enabled** | **bool?**| Streaming Enabled |  |
| **body** | [**SocialAccount**](SocialAccount.md)| SocialAccount | [optional]  |
{: class="table table-striped"}

### Return type

[**SocialAccount**](SocialAccount.md)

