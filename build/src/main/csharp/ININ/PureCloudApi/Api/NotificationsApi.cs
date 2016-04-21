using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsAvailabletopicsGet ();
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        string DeleteChannelsChannelIdSubscriptions (string channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsAvailabletopicsGetWithHttpInfo ();
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteChannelsChannelIdSubscriptionsWithHttpInfo (string channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        string NotificationsChannelsChannelidSubscriptionsDelete (string channelId);
=======
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AvailableTopicEntityListing</returns>
        AvailableTopicEntityListing GetAvailabletopics (List<string> expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo (string channelId);
=======
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AvailableTopicEntityListing</returns>
        ApiResponse<AvailableTopicEntityListing> GetAvailabletopicsWithHttpInfo (List<string> expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsGet (string channelId);
=======
        /// <returns>ChannelEntityListing</returns>
        ChannelEntityListing GetChannels ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo (string channelId);
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
=======
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        ApiResponse<ChannelEntityListing> GetChannelsWithHttpInfo ();
        /// <summary>
        /// The list of all subscriptions for this channel
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
=======
        /// <returns>ChannelTopicEntityListing</returns>
        ChannelTopicEntityListing GetChannelsChannelIdSubscriptions (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo (string channelId, List<ChannelTopic> body = null);
=======
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        ApiResponse<ChannelTopicEntityListing> GetChannelsChannelIdSubscriptionsWithHttpInfo (string channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null);
=======
        /// <returns>Channel</returns>
        Channel PostChannels ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// The list of existing channels
=======
        /// <returns>ApiResponse of Channel</returns>
        ApiResponse<Channel> PostChannelsWithHttpInfo ();
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ChannelEntityListing</returns>
        ChannelEntityListing NotificationsChannelsGet ();

        /// <summary>
        /// The list of existing channels
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ChannelTopicEntityListing</returns>
        ChannelTopicEntityListing PostChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        ApiResponse<ChannelEntityListing> NotificationsChannelsGetWithHttpInfo ();
        /// <summary>
        /// Create a new channel
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        ApiResponse<ChannelTopicEntityListing> PostChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Channel</returns>
        Channel NotificationsChannelsPost ();

        /// <summary>
        /// Create a new channel
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ChannelTopicEntityListing</returns>
        ChannelTopicEntityListing PutChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of Channel</returns>
        ApiResponse<Channel> NotificationsChannelsPostWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get available notification topics.
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        ApiResponse<ChannelTopicEntityListing> PutChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Remove all subscriptions
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsAvailabletopicsGetAsync ();

        /// <summary>
        /// Get available notification topics.
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteChannelsChannelIdSubscriptionsAsync (string channelId);

        /// <summary>
        /// Remove all subscriptions
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsAvailabletopicsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Remove all subscriptions
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId);
        /// <summary>
        /// Get available notification topics.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> NotificationsChannelsChannelidSubscriptionsDeleteAsync (string channelId);

        /// <summary>
        /// Remove all subscriptions
=======
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AvailableTopicEntityListing</returns>
        System.Threading.Tasks.Task<AvailableTopicEntityListing> GetAvailabletopicsAsync (List<string> expand = null);

        /// <summary>
        /// Get available notification topics.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo (string channelId);
        /// <summary>
        /// The list of all subscriptions for this channel
=======
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AvailableTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailableTopicEntityListing>> GetAvailabletopicsAsyncWithHttpInfo (List<string> expand = null);
        /// <summary>
        /// The list of existing channels
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetAsync (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
=======
        /// <returns>Task of ChannelEntityListing</returns>
        System.Threading.Tasks.Task<ChannelEntityListing> GetChannelsAsync ();

        /// <summary>
        /// The list of existing channels
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo (string channelId);
=======
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> GetChannelsAsyncWithHttpInfo ();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostAsync (string channelId, List<ChannelTopic> body = null);
=======
        /// <returns>Task of ChannelTopicEntityListing</returns>
        System.Threading.Tasks.Task<ChannelTopicEntityListing> GetChannelsChannelIdSubscriptionsAsync (string channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
=======
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> GetChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId);
        /// <summary>
        /// Create a new channel
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
=======
        /// <returns>Task of Channel</returns>
        System.Threading.Tasks.Task<Channel> PostChannelsAsync ();

        /// <summary>
        /// Create a new channel
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// The list of existing channels
=======
        /// <returns>Task of ApiResponse (Channel)</returns>
        System.Threading.Tasks.Task<ApiResponse<Channel>> PostChannelsAsyncWithHttpInfo ();
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ChannelEntityListing</returns>
        System.Threading.Tasks.Task<ChannelEntityListing> NotificationsChannelsGetAsync ();

        /// <summary>
        /// The list of existing channels
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        System.Threading.Tasks.Task<ChannelTopicEntityListing> PostChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> NotificationsChannelsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Create a new channel
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PostChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of Channel</returns>
        System.Threading.Tasks.Task<Channel> NotificationsChannelsPostAsync ();

        /// <summary>
        /// Create a new channel
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        System.Threading.Tasks.Task<ChannelTopicEntityListing> PutChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (Channel)</returns>
        System.Threading.Tasks.Task<ApiResponse<Channel>> NotificationsChannelsPostAsyncWithHttpInfo ();
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PutChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationsApi : INotificationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsAvailabletopicsGet ()
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsAvailabletopicsGetWithHttpInfo();
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        public string DeleteChannelsChannelIdSubscriptions (string channelId)
        {
             ApiResponse<string> localVarResponse = DeleteChannelsChannelIdSubscriptionsWithHttpInfo(channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsAvailabletopicsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/availabletopics";
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteChannelsChannelIdSubscriptionsWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->DeleteChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsAvailabletopicsGetAsync ()
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsAvailabletopicsGetAsyncWithHttpInfo();
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteChannelsChannelIdSubscriptionsAsync (string channelId)
        {
             ApiResponse<string> localVarResponse = await DeleteChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsAvailabletopicsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/availabletopics";
=======
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->DeleteChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        public string NotificationsChannelsChannelidSubscriptionsDelete (string channelId)
        {
             ApiResponse<string> localVarResponse = NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo(channelId);
=======
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>AvailableTopicEntityListing</returns>
        public AvailableTopicEntityListing GetAvailabletopics (List<string> expand = null)
        {
             ApiResponse<AvailableTopicEntityListing> localVarResponse = GetAvailabletopicsWithHttpInfo(expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsDelete");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>ApiResponse of AvailableTopicEntityListing</returns>
        public ApiResponse< AvailableTopicEntityListing > GetAvailabletopicsWithHttpInfo (List<string> expand = null)
        {

            var localVarPath = "/api/v2/notifications/availabletopics";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetAvailabletopics: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAvailabletopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvailableTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailableTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> NotificationsChannelsChannelidSubscriptionsDeleteAsync (string channelId)
        {
             ApiResponse<string> localVarResponse = await NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo(channelId);
=======
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of AvailableTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<AvailableTopicEntityListing> GetAvailabletopicsAsync (List<string> expand = null)
        {
             ApiResponse<AvailableTopicEntityListing> localVarResponse = await GetAvailabletopicsAsyncWithHttpInfo(expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsDelete");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand">Which fields, if any, to expand (optional)</param>
        /// <returns>Task of ApiResponse (AvailableTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvailableTopicEntityListing>> GetAvailabletopicsAsyncWithHttpInfo (List<string> expand = null)
        {

            var localVarPath = "/api/v2/notifications/availabletopics";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetAvailabletopics: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAvailabletopics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AvailableTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailableTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AvailableTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsGet (string channelId)
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo(channelId);
=======
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChannelEntityListing</returns>
        public ChannelEntityListing GetChannels ()
        {
             ApiResponse<ChannelEntityListing> localVarResponse = GetChannelsWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsGet");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        public ApiResponse< ChannelEntityListing > GetChannelsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/notifications/channels";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetChannels: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetAsync (string channelId)
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo(channelId);
=======
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChannelEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelEntityListing> GetChannelsAsync ()
        {
             ApiResponse<ChannelEntityListing> localVarResponse = await GetChannelsAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsGet");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> GetChannelsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/notifications/channels";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetChannels: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo(channelId, body);
=======
        /// <returns>ChannelTopicEntityListing</returns>
        public ChannelTopicEntityListing GetChannelsChannelIdSubscriptions (string channelId)
        {
             ApiResponse<ChannelTopicEntityListing> localVarResponse = GetChannelsChannelIdSubscriptionsWithHttpInfo(channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPost");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        public ApiResponse< ChannelTopicEntityListing > GetChannelsChannelIdSubscriptionsWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->GetChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo(channelId, body);
=======
        /// <returns>Task of ChannelTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelTopicEntityListing> GetChannelsChannelIdSubscriptionsAsync (string channelId)
        {
             ApiResponse<ChannelTopicEntityListing> localVarResponse = await GetChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
<<<<<<< HEAD
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPost");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> GetChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->GetChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
<<<<<<< HEAD
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo(channelId, body);
=======
        /// <returns>Channel</returns>
        public Channel PostChannels ()
        {
             ApiResponse<Channel> localVarResponse = PostChannelsWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPut");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// <returns>ApiResponse of Channel</returns>
        public ApiResponse< Channel > PostChannelsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/notifications/channels";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostChannels: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Channel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo(channelId, body);
=======
        /// <returns>Task of Channel</returns>
        public async System.Threading.Tasks.Task<Channel> PostChannelsAsync ()
        {
             ApiResponse<Channel> localVarResponse = await PostChannelsAsyncWithHttpInfo();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPut");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
=======
        /// <returns>Task of ApiResponse (Channel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Channel>> PostChannelsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/notifications/channels";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostChannels: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChannels: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Channel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ChannelEntityListing</returns>
        public ChannelEntityListing NotificationsChannelsGet ()
        {
             ApiResponse<ChannelEntityListing> localVarResponse = NotificationsChannelsGetWithHttpInfo();
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ChannelTopicEntityListing</returns>
        public ChannelTopicEntityListing PostChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> localVarResponse = PostChannelsChannelIdSubscriptionsWithHttpInfo(channelId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        public ApiResponse< ChannelEntityListing > NotificationsChannelsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        public ApiResponse< ChannelTopicEntityListing > PostChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PostChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ChannelEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelEntityListing> NotificationsChannelsGetAsync ()
        {
             ApiResponse<ChannelEntityListing> localVarResponse = await NotificationsChannelsGetAsyncWithHttpInfo();
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelTopicEntityListing> PostChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> localVarResponse = await PostChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> NotificationsChannelsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
=======
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PostChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PostChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Channel</returns>
        public Channel NotificationsChannelsPost ()
        {
             ApiResponse<Channel> localVarResponse = NotificationsChannelsPostWithHttpInfo();
=======
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ChannelTopicEntityListing</returns>
        public ChannelTopicEntityListing PutChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> localVarResponse = PutChannelsChannelIdSubscriptionsWithHttpInfo(channelId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Channel</returns>
        public ApiResponse< Channel > NotificationsChannelsPostWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
=======
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        public ApiResponse< ChannelTopicEntityListing > PutChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PutChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Channel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Channel</returns>
        public async System.Threading.Tasks.Task<Channel> NotificationsChannelsPostAsync ()
        {
             ApiResponse<Channel> localVarResponse = await NotificationsChannelsPostAsyncWithHttpInfo();
=======
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelTopicEntityListing> PutChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> localVarResponse = await PutChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Channel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Channel>> NotificationsChannelsPostAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
=======
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PutChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PutChannelsChannelIdSubscriptions");

            var localVarPath = "/api/v2/notifications/channels/{channelId}/subscriptions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (channelId != null) localVarPathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Channel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutChannelsChannelIdSubscriptions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutChannelsChannelIdSubscriptions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelTopicEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
