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
    public interface ISearchApi
    {
        
        /// <summary>
        /// Search chat history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Search request options</param>
        /// <returns>ChatSearchListing</returns>
        ChatSearchListing PostChats (ChatSearchRequest body = null);
  
        /// <summary>
        /// Search chat history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Search request options</param>
        /// <returns>ApiResponse of ChatSearchListing</returns>
        ApiResponse<ChatSearchListing> PostChatsWithHttpInfo (ChatSearchRequest body = null);

        /// <summary>
        /// Search chat history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ChatSearchListing</returns>
        System.Threading.Tasks.Task<ChatSearchListing> PostChatsAsync (ChatSearchRequest body = null);

        /// <summary>
        /// Search chat history
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (ChatSearchListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ChatSearchListing>> PostChatsAsyncWithHttpInfo (ChatSearchRequest body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(Configuration configuration = null)
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
        /// Search chat history 
        /// </summary>
        /// <param name="body">Search request options</param> 
        /// <returns>ChatSearchListing</returns>
        public ChatSearchListing PostChats (ChatSearchRequest body = null)
        {
             ApiResponse<ChatSearchListing> response = PostChatsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Search chat history 
        /// </summary>
        /// <param name="body">Search request options</param> 
        /// <returns>ApiResponse of ChatSearchListing</returns>
        public ApiResponse< ChatSearchListing > PostChatsWithHttpInfo (ChatSearchRequest body = null)
        {
            
    
            var path_ = "/api/v1/search/chats";
    
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
                throw new ApiException (statusCode, "Error calling PostChats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostChats: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ChatSearchListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChatSearchListing) Configuration.ApiClient.Deserialize(response, typeof(ChatSearchListing)));
            
        }
    
        /// <summary>
        /// Search chat history 
        /// </summary>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ChatSearchListing</returns>
        public async System.Threading.Tasks.Task<ChatSearchListing> PostChatsAsync (ChatSearchRequest body = null)
        {
             ApiResponse<ChatSearchListing> response = await PostChatsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Search chat history 
        /// </summary>
        /// <param name="body">Search request options</param>
        /// <returns>Task of ApiResponse (ChatSearchListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ChatSearchListing>> PostChatsAsyncWithHttpInfo (ChatSearchRequest body = null)
        {
            
    
            var path_ = "/api/v1/search/chats";
    
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
                throw new ApiException (statusCode, "Error calling PostChats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostChats: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ChatSearchListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ChatSearchListing) Configuration.ApiClient.Deserialize(response, typeof(ChatSearchListing)));
            
        }
        
    }
    
}
