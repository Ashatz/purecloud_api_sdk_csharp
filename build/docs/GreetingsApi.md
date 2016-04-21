# ININ.PureCloudApi.Api.GreetingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GreetingsDefaultsGet**](GreetingsApi.md#greetingsdefaultsget) | **GET** /api/v1/greetings/defaults | Get an Organization&#39;s DefaultGreetingList |
| [**GreetingsDefaultsPut**](GreetingsApi.md#greetingsdefaultsput) | **PUT** /api/v1/greetings/defaults | Update an Organization&#39;s DefaultGreetingList |
| [**GreetingsGet**](GreetingsApi.md#greetingsget) | **GET** /api/v1/greetings | Gets an Organization&#39;s Greetings |
| [**GreetingsGreetingidDelete**](GreetingsApi.md#greetingsgreetingiddelete) | **DELETE** /api/v1/greetings/{greetingId} | Deletes a Greeting with the given GreetingId |
| [**GreetingsGreetingidGet**](GreetingsApi.md#greetingsgreetingidget) | **GET** /api/v1/greetings/{greetingId} | Get a Greeting with the given GreetingId |
| [**GreetingsGreetingidMediaGet**](GreetingsApi.md#greetingsgreetingidmediaget) | **GET** /api/v1/greetings/{greetingId}/media | Get media playback URI for this greeting |
| [**GreetingsGreetingidPut**](GreetingsApi.md#greetingsgreetingidput) | **PUT** /api/v1/greetings/{greetingId} | Updates the Greeting with the given GreetingId |
| [**GreetingsPost**](GreetingsApi.md#greetingspost) | **POST** /api/v1/greetings | Create a Greeting for an Organization |
| [**UsersUseridGreetingsDefaultsGet**](GreetingsApi.md#usersuseridgreetingsdefaultsget) | **GET** /api/v1/users/{userId}/greetings/defaults | Grabs the list of Default Greetings given a User&#39;s ID |
| [**UsersUseridGreetingsDefaultsPut**](GreetingsApi.md#usersuseridgreetingsdefaultsput) | **PUT** /api/v1/users/{userId}/greetings/defaults | Updates the DefaultGreetingList of the specified User |
| [**UsersUseridGreetingsGet**](GreetingsApi.md#usersuseridgreetingsget) | **GET** /api/v1/users/{userId}/greetings | Get a list of the User&#39;s Greetings |
| [**UsersUseridGreetingsPost**](GreetingsApi.md#usersuseridgreetingspost) | **POST** /api/v1/users/{userId}/greetings | Creates a Greeting for a User |
{: class="table table-striped"}

<a name="GreetingsDefaultsGet"></a>
## [**DefaultGreetingList**](DefaultGreetingList.html) GreetingsDefaultsGet ()

Get an Organization's DefaultGreetingList



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsDefaultsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();

            try
            {
                // Get an Organization's DefaultGreetingList
                DefaultGreetingList result = apiInstance.GreetingsDefaultsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsDefaultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.md)

<a name="GreetingsDefaultsPut"></a>
## [**DefaultGreetingList**](DefaultGreetingList.html) GreetingsDefaultsPut (DefaultGreetingList body)

Update an Organization's DefaultGreetingList



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsDefaultsPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var body = new DefaultGreetingList(); // DefaultGreetingList | The updated defaultGreetingList

            try
            {
                // Update an Organization's DefaultGreetingList
                DefaultGreetingList result = apiInstance.GreetingsDefaultsPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsDefaultsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DefaultGreetingList**](DefaultGreetingList.md)| The updated defaultGreetingList |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.md)

<a name="GreetingsGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) GreetingsGet (int? pageSize = null, int? pageNumber = null)

Gets an Organization's Greetings



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Gets an Organization's Greetings
                DomainEntityListing result = apiInstance.GreetingsGet(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsGet: " + e.Message );
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

<a name="GreetingsGreetingidDelete"></a>
## [**Greeting**](Greeting.html) GreetingsGreetingidDelete (string greetingId)

Deletes a Greeting with the given GreetingId



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsGreetingidDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID

            try
            {
                // Deletes a Greeting with the given GreetingId
                Greeting result = apiInstance.GreetingsGreetingidDelete(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsGreetingidDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.md)

<a name="GreetingsGreetingidGet"></a>
## [**Greeting**](Greeting.html) GreetingsGreetingidGet (string greetingId)

Get a Greeting with the given GreetingId



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsGreetingidGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID

            try
            {
                // Get a Greeting with the given GreetingId
                Greeting result = apiInstance.GreetingsGreetingidGet(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsGreetingidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.md)

<a name="GreetingsGreetingidMediaGet"></a>
## [**GreetingMediaInfo**](GreetingMediaInfo.html) GreetingsGreetingidMediaGet (string greetingId, string formatId = null)

Get media playback URI for this greeting



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsGreetingidMediaGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID
            var formatId = formatId_example;  // string | The desired format (WAV, etc.) (optional)  (default to WAV)

            try
            {
                // Get media playback URI for this greeting
                GreetingMediaInfo result = apiInstance.GreetingsGreetingidMediaGet(greetingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsGreetingidMediaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
| **formatId** | **string**| The desired format (WAV, etc.) | [optional] [default to WAV] |
{: class="table table-striped"}

### Return type

[**GreetingMediaInfo**](GreetingMediaInfo.md)

<a name="GreetingsGreetingidPut"></a>
## [**Greeting**](Greeting.html) GreetingsGreetingidPut (string greetingId, Greeting body)

Updates the Greeting with the given GreetingId



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsGreetingidPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID
            var body = new Greeting(); // Greeting | The updated Greeting

            try
            {
                // Updates the Greeting with the given GreetingId
                Greeting result = apiInstance.GreetingsGreetingidPut(greetingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsGreetingidPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
| **body** | [**Greeting**](Greeting.md)| The updated Greeting |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.md)

<a name="GreetingsPost"></a>
## [**DefaultGreetingList**](DefaultGreetingList.html) GreetingsPost (Greeting body)

Create a Greeting for an Organization



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GreetingsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var body = new Greeting(); // Greeting | The Greeting to create

            try
            {
                // Create a Greeting for an Organization
                DefaultGreetingList result = apiInstance.GreetingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GreetingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Greeting**](Greeting.md)| The Greeting to create |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.md)

<a name="UsersUseridGreetingsDefaultsGet"></a>
## [**DefaultGreetingList**](DefaultGreetingList.html) UsersUseridGreetingsDefaultsGet (string userId)

Grabs the list of Default Greetings given a User's ID



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGreetingsDefaultsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID

            try
            {
                // Grabs the list of Default Greetings given a User's ID
                DefaultGreetingList result = apiInstance.UsersUseridGreetingsDefaultsGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.UsersUseridGreetingsDefaultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.md)

<a name="UsersUseridGreetingsDefaultsPut"></a>
## [**DefaultGreetingList**](DefaultGreetingList.html) UsersUseridGreetingsDefaultsPut (string userId, DefaultGreetingList body)

Updates the DefaultGreetingList of the specified User



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGreetingsDefaultsPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID
            var body = new DefaultGreetingList(); // DefaultGreetingList | The updated defaultGreetingList

            try
            {
                // Updates the DefaultGreetingList of the specified User
                DefaultGreetingList result = apiInstance.UsersUseridGreetingsDefaultsPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.UsersUseridGreetingsDefaultsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**DefaultGreetingList**](DefaultGreetingList.md)| The updated defaultGreetingList |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.md)

<a name="UsersUseridGreetingsGet"></a>
## [**DomainEntityListing**](DomainEntityListing.html) UsersUseridGreetingsGet (string userId, int? pageSize = null, int? pageNumber = null)

Get a list of the User's Greetings



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGreetingsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of the User's Greetings
                DomainEntityListing result = apiInstance.UsersUseridGreetingsGet(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.UsersUseridGreetingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.md)

<a name="UsersUseridGreetingsPost"></a>
## [**Greeting**](Greeting.html) UsersUseridGreetingsPost (string userId, Greeting body)

Creates a Greeting for a User



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class UsersUseridGreetingsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var userId = userId_example;  // string | User ID
            var body = new Greeting(); // Greeting | The Greeting to create

            try
            {
                // Creates a Greeting for a User
                Greeting result = apiInstance.UsersUseridGreetingsPost(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.UsersUseridGreetingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**Greeting**](Greeting.md)| The Greeting to create |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.md)

