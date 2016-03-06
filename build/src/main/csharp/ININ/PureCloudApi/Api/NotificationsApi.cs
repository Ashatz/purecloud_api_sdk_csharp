using System;
using System.IO;
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
        
        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>AvailableTopicEntityListing</returns>
        AvailableTopicEntityListing GetAvailabletopics ();
  
        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of AvailableTopicEntityListing</returns>
        ApiResponse<AvailableTopicEntityListing> GetAvailabletopicsWithHttpInfo ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of AvailableTopicEntityListing</returns>
        System.Threading.Tasks.Task<AvailableTopicEntityListing> GetAvailabletopicsAsync ();

        /// <summary>
        /// Get available notification topics.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (AvailableTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailableTopicEntityListing>> GetAvailabletopicsAsyncWithHttpInfo ();
        
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
        Channel PostChannels ();
  
        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>ApiResponse of Channel</returns>
        ApiResponse<Channel> PostChannelsWithHttpInfo ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Task of Channel</returns>
        System.Threading.Tasks.Task<Channel> PostChannelsAsync ();

        /// <summary>
        /// Create a new channel
        /// </summary>
        /// <remarks>
        /// There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </remarks>
        /// <returns>Task of ApiResponse (Channel)</returns>
        System.Threading.Tasks.Task<ApiResponse<Channel>> PostChannelsAsyncWithHttpInfo ();
        
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ChannelTopicEntityListing</returns>
        ChannelTopicEntityListing GetChannelsChannelIdSubscriptions (string channelId);
  
        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        ApiResponse<ChannelTopicEntityListing> GetChannelsChannelIdSubscriptionsWithHttpInfo (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        System.Threading.Tasks.Task<ChannelTopicEntityListing> GetChannelsChannelIdSubscriptionsAsync (string channelId);

        /// <summary>
        /// The list of all subscriptions for this channel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> GetChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId);
        
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ChannelTopicEntityListing</returns>
        ChannelTopicEntityListing PutChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null);
  
        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        ApiResponse<ChannelTopicEntityListing> PutChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        System.Threading.Tasks.Task<ChannelTopicEntityListing> PutChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Replace the current list of subscriptions with a new list.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PutChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ChannelTopicEntityListing</returns>
        ChannelTopicEntityListing PostChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null);
  
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        ApiResponse<ChannelTopicEntityListing> PostChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        System.Threading.Tasks.Task<ChannelTopicEntityListing> PostChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null);

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PostChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null);
        
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>string</returns>
        string DeleteChannelsChannelIdSubscriptions (string channelId);
  
        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteChannelsChannelIdSubscriptionsWithHttpInfo (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteChannelsChannelIdSubscriptionsAsync (string channelId);

        /// <summary>
        /// Remove all subscriptions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId);
        
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
        /// <returns>AvailableTopicEntityListing</returns>
        public AvailableTopicEntityListing GetAvailabletopics ()
        {
             ApiResponse<AvailableTopicEntityListing> response = GetAvailabletopicsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>ApiResponse of AvailableTopicEntityListing</returns>
        public ApiResponse< AvailableTopicEntityListing > GetAvailabletopicsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/availabletopics";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AvailableTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailableTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AvailableTopicEntityListing)));
            
        }
    
        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>Task of AvailableTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<AvailableTopicEntityListing> GetAvailabletopicsAsync ()
        {
             ApiResponse<AvailableTopicEntityListing> response = await GetAvailabletopicsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get available notification topics. 
        /// </summary>
        /// <returns>Task of ApiResponse (AvailableTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AvailableTopicEntityListing>> GetAvailabletopicsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/availabletopics";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAvailabletopics: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AvailableTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AvailableTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AvailableTopicEntityListing)));
            
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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public Channel PostChannels ()
        {
             ApiResponse<Channel> response = PostChannelsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>ApiResponse of Channel</returns>
        public ApiResponse< Channel > PostChannelsWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/channels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostChannels: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostChannels: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Channel>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(response, typeof(Channel)));
            
        }
    
        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Task of Channel</returns>
        public async System.Threading.Tasks.Task<Channel> PostChannelsAsync ()
        {
             ApiResponse<Channel> response = await PostChannelsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Create a new channel There is a limit of 10 channels. Creating an 11th channel will remove the channel with oldest last used date.
        /// </summary>
        /// <returns>Task of ApiResponse (Channel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Channel>> PostChannelsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/notifications/channels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostChannels: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostChannels: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Channel>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Channel) Configuration.ApiClient.Deserialize(response, typeof(Channel)));
            
        }
        
        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ChannelTopicEntityListing</returns>
        public ChannelTopicEntityListing GetChannelsChannelIdSubscriptions (string channelId)
        {
             ApiResponse<ChannelTopicEntityListing> response = GetChannelsChannelIdSubscriptionsWithHttpInfo(channelId);
             return response.Data;
        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        public ApiResponse< ChannelTopicEntityListing > GetChannelsChannelIdSubscriptionsWithHttpInfo (string channelId)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->GetChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ChannelTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelTopicEntityListing)));
            
        }
    
        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelTopicEntityListing> GetChannelsChannelIdSubscriptionsAsync (string channelId)
        {
             ApiResponse<ChannelTopicEntityListing> response = await GetChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId);
             return response.Data;

        }

        /// <summary>
        /// The list of all subscriptions for this channel 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> GetChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling GetChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelTopicEntityListing)));
            
        }
        
        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ChannelTopicEntityListing</returns>
        public ChannelTopicEntityListing PutChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> response = PutChannelsChannelIdSubscriptionsWithHttpInfo(channelId, body);
             return response.Data;
        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        public ApiResponse< ChannelTopicEntityListing > PutChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PutChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ChannelTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelTopicEntityListing)));
            
        }
    
        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelTopicEntityListing> PutChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> response = await PutChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId, body);
             return response.Data;

        }

        /// <summary>
        /// Replace the current list of subscriptions with a new list. 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PutChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling PutChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelTopicEntityListing)));
            
        }
        
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ChannelTopicEntityListing</returns>
        public ChannelTopicEntityListing PostChannelsChannelIdSubscriptions (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> response = PostChannelsChannelIdSubscriptionsWithHttpInfo(channelId, body);
             return response.Data;
        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <param name="body">Topic</param> 
        /// <returns>ApiResponse of ChannelTopicEntityListing</returns>
        public ApiResponse< ChannelTopicEntityListing > PostChannelsChannelIdSubscriptionsWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->PostChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (channelId != null) pathParams.Add("channelId", Configuration.ApiClient.ParameterToString(channelId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ChannelTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelTopicEntityListing)));
            
        }
    
        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ChannelTopicEntityListing</returns>
        public async System.Threading.Tasks.Task<ChannelTopicEntityListing> PostChannelsChannelIdSubscriptionsAsync (string channelId, List<ChannelTopic> body = null)
        {
             ApiResponse<ChannelTopicEntityListing> response = await PostChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId, body);
             return response.Data;

        }

        /// <summary>
        /// Add a list of subscriptions to the existing list of subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <param name="body">Topic</param>
        /// <returns>Task of ApiResponse (ChannelTopicEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChannelTopicEntityListing>> PostChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId, List<ChannelTopic> body = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling PostChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ChannelTopicEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChannelTopicEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ChannelTopicEntityListing)));
            
        }
        
        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>string</returns>
        public string DeleteChannelsChannelIdSubscriptions (string channelId)
        {
             ApiResponse<string> response = DeleteChannelsChannelIdSubscriptionsWithHttpInfo(channelId);
             return response.Data;
        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteChannelsChannelIdSubscriptionsWithHttpInfo (string channelId)
        {
            
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling NotificationsApi->DeleteChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteChannelsChannelIdSubscriptionsAsync (string channelId)
        {
             ApiResponse<string> response = await DeleteChannelsChannelIdSubscriptionsAsyncWithHttpInfo(channelId);
             return response.Data;

        }

        /// <summary>
        /// Remove all subscriptions 
        /// </summary>
        /// <param name="channelId">Channel ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteChannelsChannelIdSubscriptionsAsyncWithHttpInfo (string channelId)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null) throw new ApiException(400, "Missing required parameter 'channelId' when calling DeleteChannelsChannelIdSubscriptions");
            
    
            var path_ = "/api/v1/notifications/channels/{channelId}/subscriptions";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteChannelsChannelIdSubscriptions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
