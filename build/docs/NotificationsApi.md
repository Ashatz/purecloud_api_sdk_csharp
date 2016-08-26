---
title: NotificationsApi
---
## ININ.PureCloudApi.Api.NotificationsApi

All URIs are relative to *https://api.inindca.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteChannelSubscriptions**](NotificationsApi.html#deletechannelsubscriptions) | **DELETE** /api/v2/notifications/channels/{channelId}/subscriptions | Remove all subscriptions |
| [**GetAvailabletopics**](NotificationsApi.html#getavailabletopics) | **GET** /api/v2/notifications/availabletopics | Get available notification topics. |
| [**GetChannelSubscriptions**](NotificationsApi.html#getchannelsubscriptions) | **GET** /api/v2/notifications/channels/{channelId}/subscriptions | The list of all subscriptions for this channel |
| [**GetChannels**](NotificationsApi.html#getchannels) | **GET** /api/v2/notifications/channels | The list of existing channels |
| [**PostChannelSubscriptions**](NotificationsApi.html#postchannelsubscriptions) | **POST** /api/v2/notifications/channels/{channelId}/subscriptions | Add a list of subscriptions to the existing list of subscriptions |
| [**PostChannels**](NotificationsApi.html#postchannels) | **POST** /api/v2/notifications/channels | Create a new channel |
| [**PutChannelSubscriptions**](NotificationsApi.html#putchannelsubscriptions) | **PUT** /api/v2/notifications/channels/{channelId}/subscriptions | Replace the current list of subscriptions with a new list. |
{: class="table table-striped"}

<a name="deletechannelsubscriptions"></a>

## **string** DeleteChannelSubscriptions (string channelId)

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
    public class DeleteChannelSubscriptionsExample
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
                string result = apiInstance.DeleteChannelSubscriptions(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteChannelSubscriptions: " + e.Message );
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

<a name="getavailabletopics"></a>

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
| **expand** | [**List<string>**](string.html)| Which fields, if any, to expand | [optional]  |
{: class="table table-striped"}

### Return type

[**AvailableTopicEntityListing**](AvailableTopicEntityListing.html)

<a name="getchannelsubscriptions"></a>

## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) GetChannelSubscriptions (string channelId)

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
    public class GetChannelSubscriptionsExample
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
                ChannelTopicEntityListing result = apiInstance.GetChannelSubscriptions(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetChannelSubscriptions: " + e.Message );
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

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.html)

<a name="getchannels"></a>

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

[**ChannelEntityListing**](ChannelEntityListing.html)

<a name="postchannelsubscriptions"></a>

## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) PostChannelSubscriptions (string channelId, List<ChannelTopic> body)

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
    public class PostChannelSubscriptionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Topic

            try
            {
                // Add a list of subscriptions to the existing list of subscriptions
                ChannelTopicEntityListing result = apiInstance.PostChannelSubscriptions(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PostChannelSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.html)| Topic |  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.html)

<a name="postchannels"></a>

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

[**Channel**](Channel.html)

<a name="putchannelsubscriptions"></a>

## [**ChannelTopicEntityListing**](ChannelTopicEntityListing.html) PutChannelSubscriptions (string channelId, List<ChannelTopic> body)

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
    public class PutChannelSubscriptionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new NotificationsApi();
            var channelId = channelId_example;  // string | Channel ID
            var body = new List<ChannelTopic>(); // List<ChannelTopic> | Topic

            try
            {
                // Replace the current list of subscriptions with a new list.
                ChannelTopicEntityListing result = apiInstance.PutChannelSubscriptions(channelId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.PutChannelSubscriptions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **channelId** | **string**| Channel ID |  |
| **body** | [**List<ChannelTopic>**](ChannelTopic.html)| Topic |  |
{: class="table table-striped"}

### Return type

[**ChannelTopicEntityListing**](ChannelTopicEntityListing.html)

