# ININ.PureCloudApi.Api.NotificationsApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteChannelsChannelIdSubscriptions**](NotificationsApi.md#deletechannelschannelidsubscriptions) | **DELETE** /api/v2/notifications/channels/{channelId}/subscriptions | Remove all subscriptions |
| [**GetAvailabletopics**](NotificationsApi.md#getavailabletopics) | **GET** /api/v2/notifications/availabletopics | Get available notification topics. |
| [**GetChannels**](NotificationsApi.md#getchannels) | **GET** /api/v2/notifications/channels | The list of existing channels |
| [**GetChannelsChannelIdSubscriptions**](NotificationsApi.md#getchannelschannelidsubscriptions) | **GET** /api/v2/notifications/channels/{channelId}/subscriptions | The list of all subscriptions for this channel |
| [**PostChannels**](NotificationsApi.md#postchannels) | **POST** /api/v2/notifications/channels | Create a new channel |
| [**PostChannelsChannelIdSubscriptions**](NotificationsApi.md#postchannelschannelidsubscriptions) | **POST** /api/v2/notifications/channels/{channelId}/subscriptions | Add a list of subscriptions to the existing list of subscriptions |
| [**PutChannelsChannelIdSubscriptions**](NotificationsApi.md#putchannelschannelidsubscriptions) | **PUT** /api/v2/notifications/channels/{channelId}/subscriptions | Replace the current list of subscriptions with a new list. |
{: class="table table-striped"}

<a name="DeleteChannelsChannelIdSubscriptions"></a>
## string** DeleteChannelsChannelIdSubscriptions (string channelId)

Remove all subscriptions



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteChannelsChannelIdSubscriptionsExample
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
                string result = apiInstance.DeleteChannelsChannelIdSubscriptions(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteChannelsChannelIdSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="GetAvailabletopics"></a>
## [**AvailableTopicEntityListing**](AvailableTopicEntityListing.html) GetAvailabletopics (List<string> expand = null)

Get available notification topics.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetAvailabletopicsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var expand = new List<string>(); // List<string> | Which fields, if any, to expand (optional) 

            try
            {
                // Get available notification topics.
                AvailableTopicEntityListing result = apiInstance.GetAvailabletopics(expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetAvailabletopics: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **expand** | [**List<string>**](string.md)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**AvailableTopicEntityListing**](AvailableTopicEntityListing.md)

<a name="GetChannels"></a>
## [**ChannelEntityListing**](ChannelEntityListing.html) GetChannels ()

The list of existing channels



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetChannelsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();

            try
            {
                // The list of existing channels
                ChannelEntityListing result = apiInstance.GetChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetChannels: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**ChannelEntityListing**](ChannelEntityListing.md)

<a name="GetChannelsChannelIdSubscriptions"></a>
## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) GetChannelsChannelIdSubscriptions (string channelId)

The list of all subscriptions for this channel



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetChannelsChannelIdSubscriptionsExample
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
                ChannelTopicEntityListing result = apiInstance.GetChannelsChannelIdSubscriptions(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetChannelsChannelIdSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.md)

<a name="PostChannels"></a>
## [**Channel**](Channel.html) PostChannels ()

Create a new channel

There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostChannelsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();

            try
            {
                // Create a new channel
                Channel result = apiInstance.PostChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PostChannels: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Channel**](Channel.md)

<a name="PostChannelsChannelIdSubscriptions"></a>
## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) PostChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null)

Add a list of subscriptions to the existing list of subscriptions



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostChannelsChannelIdSubscriptionsExample
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
                ChannelTopicEntityListing result = apiInstance.PostChannelsChannelIdSubscriptions(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PostChannelsChannelIdSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.md)| Topic | [optional]  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.md)

<a name="PutChannelsChannelIdSubscriptions"></a>
## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) PutChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null)

Replace the current list of subscriptions with a new list.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutChannelsChannelIdSubscriptionsExample
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
                ChannelTopicEntityListing result = apiInstance.PutChannelsChannelIdSubscriptions(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PutChannelsChannelIdSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.md)| Topic | [optional]  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.md)

