---
title: GreetingsApi
---
## ININ.PureCloudApi.Api.GreetingsApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGreeting**](GreetingsApi.html#deletegreeting) | **DELETE** /api/v2/greetings/{greetingId} | Deletes a Greeting with the given GreetingId |
| [**GetDefaults**](GreetingsApi.html#getdefaults) | **GET** /api/v2/greetings/defaults | Get an Organization&#39;s DefaultGreetingList |
| [**GetGreeting**](GreetingsApi.html#getgreeting) | **GET** /api/v2/greetings/{greetingId} | Get a Greeting with the given GreetingId |
| [**GetGreetingMedia**](GreetingsApi.html#getgreetingmedia) | **GET** /api/v2/greetings/{greetingId}/media | Get media playback URI for this greeting |
| [**GetGreetings**](GreetingsApi.html#getgreetings) | **GET** /api/v2/greetings | Gets an Organization&#39;s Greetings |
| [**GetUserGreetings**](GreetingsApi.html#getusergreetings) | **GET** /api/v2/users/{userId}/greetings | Get a list of the User&#39;s Greetings |
| [**GetUserGreetingsDefaults**](GreetingsApi.html#getusergreetingsdefaults) | **GET** /api/v2/users/{userId}/greetings/defaults | Grabs the list of Default Greetings given a User&#39;s ID |
| [**PostGreetings**](GreetingsApi.html#postgreetings) | **POST** /api/v2/greetings | Create a Greeting for an Organization |
| [**PostUserGreetings**](GreetingsApi.html#postusergreetings) | **POST** /api/v2/users/{userId}/greetings | Creates a Greeting for a User |
| [**PutDefaults**](GreetingsApi.html#putdefaults) | **PUT** /api/v2/greetings/defaults | Update an Organization&#39;s DefaultGreetingList |
| [**PutGreeting**](GreetingsApi.html#putgreeting) | **PUT** /api/v2/greetings/{greetingId} | Updates the Greeting with the given GreetingId |
| [**PutUserGreetingsDefaults**](GreetingsApi.html#putusergreetingsdefaults) | **PUT** /api/v2/users/{userId}/greetings/defaults | Updates the DefaultGreetingList of the specified User |
{: class="table table-striped"}

<a name="deletegreeting"></a>

## [**Greeting**](Greeting.html) DeleteGreeting (string greetingId)

Deletes a Greeting with the given GreetingId



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteGreetingExample
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
                Greeting result = apiInstance.DeleteGreeting(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.DeleteGreeting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.html)

<a name="getdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) GetDefaults ()

Get an Organization's DefaultGreetingList



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetDefaultsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();

            try
            {
                // Get an Organization's DefaultGreetingList
                DefaultGreetingList result = apiInstance.GetDefaults();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetDefaults: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

<a name="getgreeting"></a>

## [**Greeting**](Greeting.html) GetGreeting (string greetingId)

Get a Greeting with the given GreetingId



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGreetingExample
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
                Greeting result = apiInstance.GetGreeting(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreeting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.html)

<a name="getgreetingmedia"></a>

## [**GreetingMediaInfo**](GreetingMediaInfo.html) GetGreetingMedia (string greetingId, string formatId = null)

Get media playback URI for this greeting



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGreetingMediaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var greetingId = greetingId_example;  // string | Greeting ID
            var formatId = formatId_example;  // string | The desired media format. (optional)  (default to WAV)

            try
            {
                // Get media playback URI for this greeting
                GreetingMediaInfo result = apiInstance.GetGreetingMedia(greetingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetingMedia: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
| **formatId** | **string**| The desired media format. | [optional] [default to WAV] |
{: class="table table-striped"}

### Return type

[**GreetingMediaInfo**](GreetingMediaInfo.html)

<a name="getgreetings"></a>

## [**DomainEntityListing**](DomainEntityListing.html) GetGreetings (int? pageSize = null, int? pageNumber = null)

Gets an Organization's Greetings



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGreetingsExample
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
                DomainEntityListing result = apiInstance.GetGreetings(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetings: " + e.Message );
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
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.html)

<a name="getusergreetings"></a>

## [**DomainEntityListing**](DomainEntityListing.html) GetUserGreetings (string userId, int? pageSize = null, int? pageNumber = null)

Get a list of the User's Greetings



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserGreetingsExample
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
                DomainEntityListing result = apiInstance.GetUserGreetings(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetUserGreetings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**DomainEntityListing**](DomainEntityListing.html)

<a name="getusergreetingsdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) GetUserGreetingsDefaults (string userId)

Grabs the list of Default Greetings given a User's ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetUserGreetingsDefaultsExample
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
                DefaultGreetingList result = apiInstance.GetUserGreetingsDefaults(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetUserGreetingsDefaults: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

<a name="postgreetings"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) PostGreetings (Greeting body)

Create a Greeting for an Organization



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostGreetingsExample
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
                DefaultGreetingList result = apiInstance.PostGreetings(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostGreetings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Greeting**](Greeting.html)| The Greeting to create |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

<a name="postusergreetings"></a>

## [**Greeting**](Greeting.html) PostUserGreetings (string userId, Greeting body)

Creates a Greeting for a User



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostUserGreetingsExample
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
                Greeting result = apiInstance.PostUserGreetings(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostUserGreetings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**Greeting**](Greeting.html)| The Greeting to create |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.html)

<a name="putdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) PutDefaults (DefaultGreetingList body)

Update an Organization's DefaultGreetingList



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutDefaultsExample
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
                DefaultGreetingList result = apiInstance.PutDefaults(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutDefaults: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**DefaultGreetingList**](DefaultGreetingList.html)| The updated defaultGreetingList |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

<a name="putgreeting"></a>

## [**Greeting**](Greeting.html) PutGreeting (string greetingId, Greeting body)

Updates the Greeting with the given GreetingId



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutGreetingExample
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
                Greeting result = apiInstance.PutGreeting(greetingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutGreeting: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **greetingId** | **string**| Greeting ID |  |
| **body** | [**Greeting**](Greeting.html)| The updated Greeting |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.html)

<a name="putusergreetingsdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) PutUserGreetingsDefaults (string userId, DefaultGreetingList body)

Updates the DefaultGreetingList of the specified User



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutUserGreetingsDefaultsExample
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
                DefaultGreetingList result = apiInstance.PutUserGreetingsDefaults(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutUserGreetingsDefaults: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **userId** | **string**| User ID |  |
| **body** | [**DefaultGreetingList**](DefaultGreetingList.html)| The updated defaultGreetingList |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

