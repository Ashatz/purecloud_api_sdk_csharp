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
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsAvailabletopicsGet ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsAvailabletopicsGetWithHttpInfo ();
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        string NotificationsChannelsChannelidSubscriptionsDelete (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo (string channelId);
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsGet (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo (string channelId);
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChannelEntityListing</returns>
        ChannelEntityListing NotificationsChannelsGet ();

        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        ApiResponse<ChannelEntityListing> NotificationsChannelsGetWithHttpInfo ();
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Channel</returns>
        Channel NotificationsChannelsPost ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Channel</returns>
        ApiResponse<Channel> NotificationsChannelsPostWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsAvailabletopicsGetAsync ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsAvailabletopicsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> NotificationsChannelsChannelidSubscriptionsDeleteAsync (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo (string channelId);
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetAsync (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo (string channelId);
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChannelEntityListing</returns>
        System.Threading.Tasks.Task<ChannelEntityListing> NotificationsChannelsGetAsync ();

        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> NotificationsChannelsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Channel</returns>
        System.Threading.Tasks.Task<Channel> NotificationsChannelsPostAsync ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Channel)</returns>
        System.Threading.Tasks.Task<ApiResponse<Channel>> NotificationsChannelsPostAsyncWithHttpInfo ();
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
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsAvailabletopicsGet ()
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsAvailabletopicsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsAvailabletopicsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/availabletopics";
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
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsAvailabletopicsGetAsync ()
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsAvailabletopicsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsAvailabletopicsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/availabletopics";
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
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsAvailabletopicsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        public string NotificationsChannelsChannelidSubscriptionsDelete (string channelId)
        {
             ApiResponse<string> localVarResponse = NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo(channelId);
             return localVarResponse.Data;
        }

        /// <summary>
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

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> NotificationsChannelsChannelidSubscriptionsDeleteAsync (string channelId)
        {
             ApiResponse<string> localVarResponse = await NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo(channelId);
             return localVarResponse.Data;

        }

        /// <summary>
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

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsGet (string channelId)
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo(channelId);
             return localVarResponse.Data;
        }

        /// <summary>
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
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetAsync (string channelId)
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo(channelId);
             return localVarResponse.Data;

        }

        /// <summary>
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
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo(channelId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPost");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo(channelId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPost");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo(channelId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPut");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> localVarResponse = await NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo(channelId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic (optional)</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->NotificationsChannelsChannelidSubscriptionsPut");

            var localVarPath = "/api/v1/notifications/channels/{channelId}/subscriptions";
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
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TopicEntityListing)));
            
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ChannelEntityListing</returns>
        public ChannelEntityListing NotificationsChannelsGet ()
        {
             ApiResponse<ChannelEntityListing> localVarResponse = NotificationsChannelsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        public ApiResponse< ChannelEntityListing > NotificationsChannelsGetWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
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
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)));
            
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChannelEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelEntityListing> NotificationsChannelsGetAsync ()
        {
             ApiResponse<ChannelEntityListing> localVarResponse = await NotificationsChannelsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> NotificationsChannelsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
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
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChannelEntityListing)));
            
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Channel</returns>
        public Channel NotificationsChannelsPost ()
        {
             ApiResponse<Channel> localVarResponse = NotificationsChannelsPostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Channel</returns>
        public ApiResponse< Channel > NotificationsChannelsPostWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
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

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Channel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)));
            
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Channel</returns>
        public async System.Threading.Tasks.Task<Channel> NotificationsChannelsPostAsync ()
        {
             ApiResponse<Channel> localVarResponse = await NotificationsChannelsPostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Channel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Channel>> NotificationsChannelsPostAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/notifications/channels";
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

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling NotificationsChannelsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Channel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Channel)));
            
        }

    }
}
