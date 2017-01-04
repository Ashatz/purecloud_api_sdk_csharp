---
title: GreetingsApi
---
## ININ.PureCloudApi.Api.GreetingsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteGreetingId**](GreetingsApi.html#deletegreetingid) | **DELETE** /api/v2/greetings/{greetingId} | Deletes a Greeting with the given GreetingId |
| [**GetDefaults**](GreetingsApi.html#getdefaults) | **GET** /api/v2/greetings/defaults | Get an Organization&#39;s DefaultGreetingList |
| [**GetGreetingId**](GreetingsApi.html#getgreetingid) | **GET** /api/v2/greetings/{greetingId} | Get a Greeting with the given GreetingId |
| [**GetGreetingIdMedia**](GreetingsApi.html#getgreetingidmedia) | **GET** /api/v2/greetings/{greetingId}/media | Get media playback URI for this greeting |
| [**GetGreetings**](GreetingsApi.html#getgreetings) | **GET** /api/v2/greetings | Gets an Organization&#39;s Greetings |
| [**GetGroupIdGreetings**](GreetingsApi.html#getgroupidgreetings) | **GET** /api/v2/groups/{groupId}/greetings | Get a list of the Group&#39;s Greetings |
| [**GetGroupIdGreetingsDefaults**](GreetingsApi.html#getgroupidgreetingsdefaults) | **GET** /api/v2/groups/{groupId}/greetings/defaults | Grabs the list of Default Greetings given a Group&#39;s ID |
| [**GetUserIdGreetings**](GreetingsApi.html#getuseridgreetings) | **GET** /api/v2/users/{userId}/greetings | Get a list of the User&#39;s Greetings |
| [**GetUserIdGreetingsDefaults**](GreetingsApi.html#getuseridgreetingsdefaults) | **GET** /api/v2/users/{userId}/greetings/defaults | Grabs the list of Default Greetings given a User&#39;s ID |
| [**PostGreetings**](GreetingsApi.html#postgreetings) | **POST** /api/v2/greetings | Create a Greeting for an Organization |
| [**PostGroupIdGreetings**](GreetingsApi.html#postgroupidgreetings) | **POST** /api/v2/groups/{groupId}/greetings | Creates a Greeting for a Group |
| [**PostUserIdGreetings**](GreetingsApi.html#postuseridgreetings) | **POST** /api/v2/users/{userId}/greetings | Creates a Greeting for a User |
| [**PutDefaults**](GreetingsApi.html#putdefaults) | **PUT** /api/v2/greetings/defaults | Update an Organization&#39;s DefaultGreetingList |
| [**PutGreetingId**](GreetingsApi.html#putgreetingid) | **PUT** /api/v2/greetings/{greetingId} | Updates the Greeting with the given GreetingId |
| [**PutGroupIdGreetingsDefaults**](GreetingsApi.html#putgroupidgreetingsdefaults) | **PUT** /api/v2/groups/{groupId}/greetings/defaults | Updates the DefaultGreetingList of the specified Group |
| [**PutUserIdGreetingsDefaults**](GreetingsApi.html#putuseridgreetingsdefaults) | **PUT** /api/v2/users/{userId}/greetings/defaults | Updates the DefaultGreetingList of the specified User |
{: class="table table-striped"}

<a name="deletegreetingid"></a>

## [**Greeting**](Greeting.html) DeleteGreetingId (string greetingId)

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
    public class DeleteGreetingIdExample
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
                Greeting result = apiInstance.DeleteGreetingId(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.DeleteGreetingId: " + e.Message );
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

<a name="getgreetingid"></a>

## [**Greeting**](Greeting.html) GetGreetingId (string greetingId)

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
    public class GetGreetingIdExample
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
                Greeting result = apiInstance.GetGreetingId(greetingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetingId: " + e.Message );
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

<a name="getgreetingidmedia"></a>

## [**GreetingMediaInfo**](GreetingMediaInfo.html) GetGreetingIdMedia (string greetingId, string formatId = null)

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
    public class GetGreetingIdMediaExample
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
                GreetingMediaInfo result = apiInstance.GetGreetingIdMedia(greetingId, formatId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGreetingIdMedia: " + e.Message );
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

<a name="getgroupidgreetings"></a>

## [**GreetingListing**](GreetingListing.html) GetGroupIdGreetings (string groupId, int? pageSize = null, int? pageNumber = null)

Get a list of the Group's Greetings



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupIdGreetingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get a list of the Group's Greetings
                GreetingListing result = apiInstance.GetGroupIdGreetings(groupId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGroupIdGreetings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**GreetingListing**](GreetingListing.html)

<a name="getgroupidgreetingsdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) GetGroupIdGreetingsDefaults (string groupId)

Grabs the list of Default Greetings given a Group's ID



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetGroupIdGreetingsDefaultsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID

            try
            {
                // Grabs the list of Default Greetings given a Group's ID
                DefaultGreetingList result = apiInstance.GetGroupIdGreetingsDefaults(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetGroupIdGreetingsDefaults: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

<a name="getuseridgreetings"></a>

## [**DomainEntityListing**](DomainEntityListing.html) GetUserIdGreetings (string userId, int? pageSize = null, int? pageNumber = null)

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
    public class GetUserIdGreetingsExample
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
                DomainEntityListing result = apiInstance.GetUserIdGreetings(userId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetUserIdGreetings: " + e.Message );
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

<a name="getuseridgreetingsdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) GetUserIdGreetingsDefaults (string userId)

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
    public class GetUserIdGreetingsDefaultsExample
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
                DefaultGreetingList result = apiInstance.GetUserIdGreetingsDefaults(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.GetUserIdGreetingsDefaults: " + e.Message );
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

<a name="postgroupidgreetings"></a>

## [**Greeting**](Greeting.html) PostGroupIdGreetings (string groupId, Greeting body)

Creates a Greeting for a Group



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostGroupIdGreetingsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new Greeting(); // Greeting | The Greeting to create

            try
            {
                // Creates a Greeting for a Group
                Greeting result = apiInstance.PostGroupIdGreetings(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostGroupIdGreetings: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**Greeting**](Greeting.html)| The Greeting to create |  |
{: class="table table-striped"}

### Return type

[**Greeting**](Greeting.html)

<a name="postuseridgreetings"></a>

## [**Greeting**](Greeting.html) PostUserIdGreetings (string userId, Greeting body)

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
    public class PostUserIdGreetingsExample
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
                Greeting result = apiInstance.PostUserIdGreetings(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PostUserIdGreetings: " + e.Message );
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

<a name="putgreetingid"></a>

## [**Greeting**](Greeting.html) PutGreetingId (string greetingId, Greeting body)

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
    public class PutGreetingIdExample
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
                Greeting result = apiInstance.PutGreetingId(greetingId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutGreetingId: " + e.Message );
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

<a name="putgroupidgreetingsdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) PutGroupIdGreetingsDefaults (string groupId, DefaultGreetingList body)

Updates the DefaultGreetingList of the specified Group



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutGroupIdGreetingsDefaultsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new GreetingsApi();
            var groupId = groupId_example;  // string | Group ID
            var body = new DefaultGreetingList(); // DefaultGreetingList | The updated defaultGreetingList

            try
            {
                // Updates the DefaultGreetingList of the specified Group
                DefaultGreetingList result = apiInstance.PutGroupIdGreetingsDefaults(groupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutGroupIdGreetingsDefaults: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **groupId** | **string**| Group ID |  |
| **body** | [**DefaultGreetingList**](DefaultGreetingList.html)| The updated defaultGreetingList |  |
{: class="table table-striped"}

### Return type

[**DefaultGreetingList**](DefaultGreetingList.html)

<a name="putuseridgreetingsdefaults"></a>

## [**DefaultGreetingList**](DefaultGreetingList.html) PutUserIdGreetingsDefaults (string userId, DefaultGreetingList body)

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
    public class PutUserIdGreetingsDefaultsExample
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
                DefaultGreetingList result = apiInstance.PutUserIdGreetingsDefaults(userId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GreetingsApi.PutUserIdGreetingsDefaults: " + e.Message );
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

