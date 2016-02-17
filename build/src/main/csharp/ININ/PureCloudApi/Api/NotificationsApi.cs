using System;
using System.IO;
using System.Collections.Generic;
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
        
        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing GetAvailabletopics ();
  
        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> GetAvailabletopicsWithHttpInfo ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> GetAvailabletopicsAsync ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> GetAvailabletopicsAsyncWithHttpInfo ();
        
        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ChannelEntityListing</returns>
        ChannelEntityListing GetChannels ();
  
        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        ApiResponse<ChannelEntityListing> GetChannelsWithHttpInfo ();

        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ChannelEntityListing</returns>
        System.Threading.Tasks.Task<ChannelEntityListing> GetChannelsAsync ();

        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> GetChannelsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Channel</returns>
        Channel CreateChannels ();
  
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>ApiResponse of Channel</returns>
        ApiResponse<Channel> CreateChannelsWithHttpInfo ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Task of Channel</returns>
        System.Threading.Tasks.Task<Channel> CreateChannelsAsync ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Task of ApiResponse (Channel)</returns>
        System.Threading.Tasks.Task<ApiResponse<Channel>> CreateChannelsAsyncWithHttpInfo ();
        
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing GetChannelSubscriptions (string channelId);
  
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> GetChannelSubscriptionsWithHttpInfo (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> GetChannelSubscriptionsAsync (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> GetChannelSubscriptionsAsyncWithHttpInfo (string channelId);
        
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing UpdateChannelSubscriptions (string channelId, List<ChannelTopic> body = null);
  
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> UpdateChannelSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> UpdateChannelSubscriptionsAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> UpdateChannelSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing CreateChannelSubscriptions (string channelId, List<ChannelTopic> body = null);
  
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> CreateChannelSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> CreateChannelSubscriptionsAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> CreateChannelSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        string DeleteChannelSubscriptions (string channelId);
  
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteChannelSubscriptionsWithHttpInfo (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteChannelSubscriptionsAsync (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteChannelSubscriptionsAsyncWithHttpInfo (string channelId);
        
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
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing GetAvailabletopics ()
        {
             ApiResponse<TopicEntityListing> response = GetAvailabletopicsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > GetAvailabletopicsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/availabletopics";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
    
        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> GetAvailabletopicsAsync ()
        {
             ApiResponse<TopicEntityListing> response = await GetAvailabletopicsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> GetAvailabletopicsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/availabletopics";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
        
        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>ChannelEntityListing</returns>
        public ChannelEntityListing GetChannels ()
        {
             ApiResponse<ChannelEntityListing> response = GetChannelsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        public ApiResponse< ChannelEntityListing > GetChannelsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/channels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetChannels: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetChannels: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ChannelEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelEntityListing)));
            
        }
    
        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>Task of ChannelEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelEntityListing> GetChannelsAsync ()
        {
             ApiResponse<ChannelEntityListing> response = await GetChannelsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> GetChannelsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/channels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetChannels: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetChannels: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Channel</returns>
        public Channel CreateChannels ()
        {
             ApiResponse<Channel> response = CreateChannelsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>ApiResponse of Channel</returns>
        public ApiResponse< Channel > CreateChannelsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/channels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateChannels: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateChannels: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Channel>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(response, typeof(Channel)));
            
        }
    
        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Task of Channel</returns>
        public async System.Threading.Tasks.Task<Channel> CreateChannelsAsync ()
        {
             ApiResponse<Channel> response = await CreateChannelsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Task of ApiResponse (Channel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Channel>> CreateChannelsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/channels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateChannels: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateChannels: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Channel>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(response, typeof(Channel)));
            
        }
        
        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing GetChannelSubscriptions (string channelId)
        {
             ApiResponse<TopicEntityListing> response = GetChannelSubscriptionsWithHttpInfo(channelId);
             return response.Data;
        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > GetChannelSubscriptionsWithHttpInfo (string channelId)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling GetChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
    
        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> GetChannelSubscriptionsAsync (string channelId)
        {
             ApiResponse<TopicEntityListing> response = await GetChannelSubscriptionsAsyncWithHttpInfo(channelId);
             return response.Data;

        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> GetChannelSubscriptionsAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling GetChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
        
        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing UpdateChannelSubscriptions (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = UpdateChannelSubscriptionsWithHttpInfo(channelId, body);
             return response.Data;
        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > UpdateChannelSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling UpdateChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
    
        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> UpdateChannelSubscriptionsAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = await UpdateChannelSubscriptionsAsyncWithHttpInfo(channelId, body);
             return response.Data;

        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> UpdateChannelSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling UpdateChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
        
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing CreateChannelSubscriptions (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = CreateChannelSubscriptionsWithHttpInfo(channelId, body);
             return response.Data;
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > CreateChannelSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling CreateChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
    
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> CreateChannelSubscriptionsAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = await CreateChannelSubscriptionsAsyncWithHttpInfo(channelId, body);
             return response.Data;

        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> CreateChannelSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling CreateChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
        
        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>string</returns>
        public string DeleteChannelSubscriptions (string channelId)
        {
             ApiResponse<string> response = DeleteChannelSubscriptionsWithHttpInfo(channelId);
             return response.Data;
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteChannelSubscriptionsWithHttpInfo (string channelId)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling DeleteChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteChannelSubscriptionsAsync (string channelId)
        {
             ApiResponse<string> response = await DeleteChannelSubscriptionsAsyncWithHttpInfo(channelId);
             return response.Data;

        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteChannelSubscriptionsAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling DeleteChannelSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteChannelSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteChannelSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
