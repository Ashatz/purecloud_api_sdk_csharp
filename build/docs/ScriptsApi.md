# ININ.PureCloudApi.Api.ScriptsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**QualityFormsFormidDelete**](ScriptsApi.md#qualityformsformiddelete) | **DELETE** /api/v1/quality/forms/{formId} | Delete an evaluation form. |
| [**QualityFormsFormidGet**](ScriptsApi.md#qualityformsformidget) | **GET** /api/v1/quality/forms/{formId} | Get an evaluation form |
| [**QualityFormsFormidPut**](ScriptsApi.md#qualityformsformidput) | **PUT** /api/v1/quality/forms/{formId} | Update an evaluation form. |
| [**QualityFormsFormidVersionsGet**](ScriptsApi.md#qualityformsformidversionsget) | **GET** /api/v1/quality/forms/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**QualityFormsGet**](ScriptsApi.md#qualityformsget) | **GET** /api/v1/quality/forms | Get the list of evaluation forms |
| [**QualityFormsPost**](ScriptsApi.md#qualityformspost) | **POST** /api/v1/quality/forms | Create an evaluation form. |
| [**QualityPublishedformsFormidGet**](ScriptsApi.md#qualitypublishedformsformidget) | **GET** /api/v1/quality/publishedforms/{formId} | Get the published evaluation forms. |
| [**QualityPublishedformsGet**](ScriptsApi.md#qualitypublishedformsget) | **GET** /api/v1/quality/publishedforms | Get the published evaluation forms. |
| [**QualityPublishedformsPost**](ScriptsApi.md#qualitypublishedformspost) | **POST** /api/v1/quality/publishedforms | Publish an evaluation form. |
| [**ScriptsGet**](ScriptsApi.md#scriptsget) | **GET** /api/v1/scripts | Get the list of scripts |
| [**ScriptsPost**](ScriptsApi.md#scriptspost) | **POST** /api/v1/scripts | Create a script. |
{: class="table table-striped"}

<a name="QualityFormsFormidDelete"></a>
## string** QualityFormsFormidDelete (string formId)

Delete an evaluation form.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityFormsFormidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var formId = formId_example;  // string | Form ID

            try
            {
                // Delete an evaluation form.
                string result = apiInstance.QualityFormsFormidDelete(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityFormsFormidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="QualityFormsFormidGet"></a>
## [**EvaluationForm**](EvaluationForm.html) QualityFormsFormidGet (string formId)

Get an evaluation form



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityFormsFormidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var formId = formId_example;  // string | Form ID

            try
            {
                // Get an evaluation form
                EvaluationForm result = apiInstance.QualityFormsFormidGet(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityFormsFormidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="QualityFormsFormidPut"></a>
## [**EvaluationForm**](EvaluationForm.html) QualityFormsFormidPut (string formId, EvaluationForm body = null)

Update an evaluation form.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityFormsFormidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var formId = formId_example;  // string | Form ID
            var body = new EvaluationForm(); // EvaluationForm |  (optional) 

            try
            {
                // Update an evaluation form.
                EvaluationForm result = apiInstance.QualityFormsFormidPut(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityFormsFormidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**EvaluationForm**](EvaluationForm.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="QualityFormsFormidVersionsGet"></a>
## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) QualityFormsFormidVersionsGet (string formId, int? pageSize = null, int? pageNumber = null)

Gets all the revisions for a specific evaluation.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityFormsFormidVersionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var formId = formId_example;  // string | Form ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Gets all the revisions for a specific evaluation.
                EvaluationFormEntityListing result = apiInstance.QualityFormsFormidVersionsGet(formId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityFormsFormidVersionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.md)

<a name="QualityFormsGet"></a>
## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) QualityFormsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)

Get the list of evaluation forms



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityFormsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get the list of evaluation forms
                EvaluationFormEntityListing result = apiInstance.QualityFormsGet(pageSize, pageNumber, expand, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityFormsGet: " + e.Message );
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
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.md)

<a name="QualityFormsPost"></a>
## [**EvaluationForm**](EvaluationForm.html) QualityFormsPost (EvaluationForm body = null)

Create an evaluation form.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityFormsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var body = new EvaluationForm(); // EvaluationForm |  (optional) 

            try
            {
                // Create an evaluation form.
                EvaluationForm result = apiInstance.QualityFormsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityFormsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="QualityPublishedformsFormidGet"></a>
## [**EvaluationForm**](EvaluationForm.html) QualityPublishedformsFormidGet (string formId)

Get the published evaluation forms.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityPublishedformsFormidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var formId = formId_example;  // string | Form ID

            try
            {
                // Get the published evaluation forms.
                EvaluationForm result = apiInstance.QualityPublishedformsFormidGet(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityPublishedformsFormidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="QualityPublishedformsGet"></a>
## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) QualityPublishedformsGet (int? pageSize = null, int? pageNumber = null, string name = null)

Get the published evaluation forms.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityPublishedformsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get the published evaluation forms.
                EvaluationFormEntityListing result = apiInstance.QualityPublishedformsGet(pageSize, pageNumber, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityPublishedformsGet: " + e.Message );
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
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.md)

<a name="QualityPublishedformsPost"></a>
## [**EvaluationForm**](EvaluationForm.html) QualityPublishedformsPost (EvaluationForm body = null)

Publish an evaluation form.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class QualityPublishedformsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var body = new EvaluationForm(); // EvaluationForm |  (optional) 

            try
            {
                // Publish an evaluation form.
                EvaluationForm result = apiInstance.QualityPublishedformsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.QualityPublishedformsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="ScriptsGet"></a>
## [**ScriptEntityListing**](ScriptEntityListing.html) ScriptsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)

Get the list of scripts



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ScriptsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name (optional) 
            var feature = feature_example;  // string | Feature (optional) 

            try
            {
                // Get the list of scripts
                ScriptEntityListing result = apiInstance.ScriptsGet(pageSize, pageNumber, expand, name, feature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.ScriptsGet: " + e.Message );
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
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name | [optional]  |
| **feature** | **string**| Feature | [optional]  |
{: class="table table-striped"}

### Return type

[**ScriptEntityListing**](ScriptEntityListing.md)

<a name="ScriptsPost"></a>
## [**Script**](Script.html) ScriptsPost (Object body = null)

Create a script.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class ScriptsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ScriptsApi();
            var body = ;  // Object |  (optional) 

            try
            {
                // Create a script.
                Script result = apiInstance.ScriptsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.ScriptsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | **Object**|  | [optional]  |
{: class="table table-striped"}

### Return type

[**Script**](Script.md)

