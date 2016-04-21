# ININ.PureCloudApi.Api.NotificationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**NotificationsAvailabletopicsGet**](NotificationsApi.md#notificationsavailabletopicsget) | **GET** /api/v1/notifications/availabletopics | Get available notification topics. |
| [**NotificationsChannelsChannelidSubscriptionsDelete**](NotificationsApi.md#notificationschannelschannelidsubscriptionsdelete) | **DELETE** /api/v1/notifications/channels/{channelId}/subscriptions | Remove all subscriptions |
| [**NotificationsChannelsChannelidSubscriptionsGet**](NotificationsApi.md#notificationschannelschannelidsubscriptionsget) | **GET** /api/v1/notifications/channels/{channelId}/subscriptions | The list of all subscriptions for this channel |
| [**NotificationsChannelsChannelidSubscriptionsPost**](NotificationsApi.md#notificationschannelschannelidsubscriptionspost) | **POST** /api/v1/notifications/channels/{channelId}/subscriptions | Add a list of subscriptions to the existing list of subscriptions |
| [**NotificationsChannelsChannelidSubscriptionsPut**](NotificationsApi.md#notificationschannelschannelidsubscriptionsput) | **PUT** /api/v1/notifications/channels/{channelId}/subscriptions | Replace the current list of subscriptions with a new list. |
| [**NotificationsChannelsGet**](NotificationsApi.md#notificationschannelsget) | **GET** /api/v1/notifications/channels | The list of existing channels |
| [**NotificationsChannelsPost**](NotificationsApi.md#notificationschannelspost) | **POST** /api/v1/notifications/channels | Create a new channel |
{: class="table table-striped"}

<a name="NotificationsAvailabletopicsGet"></a>
## [**TopicEntityListing**](TopicEntityListing.html) NotificationsAvailabletopicsGet ()

Get available notification topics.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsAvailabletopicsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();

            try
            {
                // Get available notification topics.
                TopicEntityListing result = apiInstance.NotificationsAvailabletopicsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsAvailabletopicsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**TopicEntityListing**](TopicEntityListing.md)

<a name="NotificationsChannelsChannelidSubscriptionsDelete"></a>
## string** NotificationsChannelsChannelidSubscriptionsDelete (string channelId)

Remove all subscriptions



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsChannelsChannelidSubscriptionsDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID

            try
            {
                // Remove all subscriptions
                string result = apiInstance.NotificationsChannelsChannelidSubscriptionsDelete(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsChannelsChannelidSubscriptionsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="NotificationsChannelsChannelidSubscriptionsGet"></a>
## [**TopicEntityListing**](TopicEntityListing.html) NotificationsChannelsChannelidSubscriptionsGet (string channelId)

The list of all subscriptions for this channel



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsChannelsChannelidSubscriptionsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID

            try
            {
                // The list of all subscriptions for this channel
                TopicEntityListing result = apiInstance.NotificationsChannelsChannelidSubscriptionsGet(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsChannelsChannelidSubscriptionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
{: class="table table-striped"}

### Return type

[**TopicEntityListing**](TopicEntityListing.md)

<a name="NotificationsChannelsChannelidSubscriptionsPost"></a>
## [**TopicEntityListing**](TopicEntityListing.html) NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null)

Add a list of subscriptions to the existing list of subscriptions



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsChannelsChannelidSubscriptionsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Topic (optional) 

            try
            {
                // Add a list of subscriptions to the existing list of subscriptions
                TopicEntityListing result = apiInstance.NotificationsChannelsChannelidSubscriptionsPost(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsChannelsChannelidSubscriptionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.md)| Topic | [optional]  |
{: class="table table-striped"}

### Return type

[**TopicEntityListing**](TopicEntityListing.md)

<a name="NotificationsChannelsChannelidSubscriptionsPut"></a>
## [**TopicEntityListing**](TopicEntityListing.html) NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null)

Replace the current list of subscriptions with a new list.



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsChannelsChannelidSubscriptionsPutExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Topic (optional) 

            try
            {
                // Replace the current list of subscriptions with a new list.
                TopicEntityListing result = apiInstance.NotificationsChannelsChannelidSubscriptionsPut(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsChannelsChannelidSubscriptionsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.md)| Topic | [optional]  |
{: class="table table-striped"}

### Return type

[**TopicEntityListing**](TopicEntityListing.md)

<a name="NotificationsChannelsGet"></a>
## [**ChannelEntityListing**](ChannelEntityListing.html) NotificationsChannelsGet ()

The list of existing channels



### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsChannelsGetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();

            try
            {
                // The list of existing channels
                ChannelEntityListing result = apiInstance.NotificationsChannelsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsChannelsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ChannelEntityListing**](ChannelEntityListing.md)

<a name="NotificationsChannelsPost"></a>
## [**Channel**](Channel.html) NotificationsChannelsPost ()

Create a new channel

There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.

### Example
```csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class NotificationsChannelsPostExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();

            try
            {
                // Create a new channel
                Channel result = apiInstance.NotificationsChannelsPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.NotificationsChannelsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Channel**](Channel.md)

