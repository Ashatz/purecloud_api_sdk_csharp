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
        TopicEntityListing NotificationsAvailabletopicsGet ();
  
        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsAvailabletopicsGetWithHttpInfo ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsAvailabletopicsGetAsync ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsAvailabletopicsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ChannelEntityListing</returns>
        ChannelEntityListing NotificationsChannelsGet ();
  
        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        ApiResponse<ChannelEntityListing> NotificationsChannelsGetWithHttpInfo ();

        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ChannelEntityListing</returns>
        System.Threading.Tasks.Task<ChannelEntityListing> NotificationsChannelsGetAsync ();

        /// <summary>
        /// The list of existing channels
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> NotificationsChannelsGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Channel</returns>
        Channel NotificationsChannelsPost ();
  
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>ApiResponse of Channel</returns>
        ApiResponse<Channel> NotificationsChannelsPostWithHttpInfo ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Task of Channel</returns>
        System.Threading.Tasks.Task<Channel> NotificationsChannelsPostAsync ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Task of ApiResponse (Channel)</returns>
        System.Threading.Tasks.Task<ApiResponse<Channel>> NotificationsChannelsPostAsyncWithHttpInfo ();
        
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsGet (string channelId);
  
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetAsync (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo (string channelId);
        
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null);
  
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>TopicEntityListing</returns>
        TopicEntityListing NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null);
  
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        ApiResponse<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of TopicEntityListing</returns>
        System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        string NotificationsChannelsChannelidSubscriptionsDelete (string channelId);
  
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> NotificationsChannelsChannelidSubscriptionsDeleteAsync (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo (string channelId);
        
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
        public TopicEntityListing NotificationsAvailabletopicsGet ()
        {
             ApiResponse<TopicEntityListing> response = NotificationsAvailabletopicsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsAvailabletopicsGetWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling NotificationsAvailabletopicsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsAvailabletopicsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
    
        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsAvailabletopicsGetAsync ()
        {
             ApiResponse<TopicEntityListing> response = await NotificationsAvailabletopicsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsAvailabletopicsGetAsyncWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling NotificationsAvailabletopicsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsAvailabletopicsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
        
        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>ChannelEntityListing</returns>
        public ChannelEntityListing NotificationsChannelsGet ()
        {
             ApiResponse<ChannelEntityListing> response = NotificationsChannelsGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>ApiResponse of ChannelEntityListing</returns>
        public ApiResponse< ChannelEntityListing > NotificationsChannelsGetWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ChannelEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelEntityListing)));
            
        }
    
        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>Task of ChannelEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelEntityListing> NotificationsChannelsGetAsync ()
        {
             ApiResponse<ChannelEntityListing> response = await NotificationsChannelsGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// The list of existing channels 
        /// </summary>
        /// <returns>Task of ApiResponse (ChannelEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelEntityListing>> NotificationsChannelsGetAsyncWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ChannelEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Channel</returns>
        public Channel NotificationsChannelsPost ()
        {
             ApiResponse<Channel> response = NotificationsChannelsPostWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>ApiResponse of Channel</returns>
        public ApiResponse< Channel > NotificationsChannelsPostWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Channel>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(response, typeof(Channel)));
            
        }
    
        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Task of Channel</returns>
        public async System.Threading.Tasks.Task<Channel> NotificationsChannelsPostAsync ()
        {
             ApiResponse<Channel> response = await NotificationsChannelsPostAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Task of ApiResponse (Channel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Channel>> NotificationsChannelsPostAsyncWithHttpInfo ()
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Channel>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(response, typeof(Channel)));
            
        }
        
        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>TopicEntityListing</returns>
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsGet (string channelId)
        {
             ApiResponse<TopicEntityListing> response = NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo(channelId);
             return response.Data;
        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsGetWithHttpInfo (string channelId)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
    
        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of TopicEntityListing</returns>
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsGetAsync (string channelId)
        {
             ApiResponse<TopicEntityListing> response = await NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo(channelId);
             return response.Data;

        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsGetAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsPut (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo(channelId, body);
             return response.Data;
        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsPutWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsPut");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPutAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = await NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo(channelId, body);
             return response.Data;

        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPutAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsPut");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPut: " + response.ErrorMessage, response.ErrorMessage);

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
        public TopicEntityListing NotificationsChannelsChannelidSubscriptionsPost (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo(channelId, body);
             return response.Data;
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ApiResponse of TopicEntityListing</returns>
        public ApiResponse< TopicEntityListing > NotificationsChannelsChannelidSubscriptionsPostWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsPost");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TopicEntityListing> NotificationsChannelsChannelidSubscriptionsPostAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<TopicEntityListing> response = await NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo(channelId, body);
             return response.Data;

        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (TopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TopicEntityListing>> NotificationsChannelsChannelidSubscriptionsPostAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsPost");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TopicEntityListing)));
            
        }
        
        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>string</returns>
        public string NotificationsChannelsChannelidSubscriptionsDelete (string channelId)
        {
             ApiResponse<string> response = NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo(channelId);
             return response.Data;
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > NotificationsChannelsChannelidSubscriptionsDeleteWithHttpInfo (string channelId)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsDelete");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> NotificationsChannelsChannelidSubscriptionsDeleteAsync (string channelId)
        {
             ApiResponse<string> response = await NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo(channelId);
             return response.Data;

        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> NotificationsChannelsChannelidSubscriptionsDeleteAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsChannelsChannelidSubscriptionsDelete");
            
    
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
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling NotificationsChannelsChannelidSubscriptionsDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
