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
    public interface IVoicemailApi
    {
        
        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy GetUservoicemailpoliciesUserId (string userId);
  
        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> GetUservoicemailpoliciesUserIdWithHttpInfo (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> GetUservoicemailpoliciesUserIdAsync (string userId);

        /// <summary>
        /// Get a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetUservoicemailpoliciesUserIdAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>VoicemailUserPolicy</returns>
        VoicemailUserPolicy PatchUservoicemailpoliciesUserId (string userId, VoicemailUserPolicy body);
  
        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        ApiResponse<VoicemailUserPolicy> PatchUservoicemailpoliciesUserIdWithHttpInfo (string userId, VoicemailUserPolicy body);

        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        System.Threading.Tasks.Task<VoicemailUserPolicy> PatchUservoicemailpoliciesUserIdAsync (string userId, VoicemailUserPolicy body);

        /// <summary>
        /// Update a user&#39;s voicemail policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchUservoicemailpoliciesUserIdAsyncWithHttpInfo (string userId, VoicemailUserPolicy body);
        
        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy GetVoicemailpolicy ();
  
        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> GetVoicemailpolicyWithHttpInfo ();

        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> GetVoicemailpolicyAsync ();

        /// <summary>
        /// Get a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> GetVoicemailpolicyAsyncWithHttpInfo ();
        
        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>VoicemailOrganizationPolicy</returns>
        VoicemailOrganizationPolicy PutVoicemailpolicy (VoicemailOrganizationPolicy body = null);
  
        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        ApiResponse<VoicemailOrganizationPolicy> PutVoicemailpolicyWithHttpInfo (VoicemailOrganizationPolicy body = null);

        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        System.Threading.Tasks.Task<VoicemailOrganizationPolicy> PutVoicemailpolicyAsync (VoicemailOrganizationPolicy body = null);

        /// <summary>
        /// Update a policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> PutVoicemailpolicyAsyncWithHttpInfo (VoicemailOrganizationPolicy body = null);
        
        /// <summary>
        /// Get mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>VoicemailMailboxInfo</returns>
        VoicemailMailboxInfo GetMailbox ();
  
        /// <summary>
        /// Get mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        ApiResponse<VoicemailMailboxInfo> GetMailboxWithHttpInfo ();

        /// <summary>
        /// Get mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMailboxAsync ();

        /// <summary>
        /// Get mailbox information
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMailboxAsyncWithHttpInfo ();
        
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>VoicemailMessageEntityListing</returns>
        VoicemailMessageEntityListing GetMessages ();
  
        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        ApiResponse<VoicemailMessageEntityListing> GetMessagesWithHttpInfo ();

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMessagesAsync ();

        /// <summary>
        /// List voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMessagesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>string</returns>
        string DeleteMessages ();
  
        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMessagesWithHttpInfo ();

        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMessagesAsync ();

        /// <summary>
        /// Delete all voicemail messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage GetMessagesMessageId (string messageId);
  
        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> GetMessagesMessageIdWithHttpInfo (string messageId);

        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> GetMessagesMessageIdAsync (string messageId);

        /// <summary>
        /// Get message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> GetMessagesMessageIdAsyncWithHttpInfo (string messageId);
        
        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>VoicemailMessage</returns>
        VoicemailMessage PutMessagesMessageId (string messageId, VoicemailMessage body = null);
  
        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>ApiResponse of VoicemailMessage</returns>
        ApiResponse<VoicemailMessage> PutMessagesMessageIdWithHttpInfo (string messageId, VoicemailMessage body = null);

        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of VoicemailMessage</returns>
        System.Threading.Tasks.Task<VoicemailMessage> PutMessagesMessageIdAsync (string messageId, VoicemailMessage body = null);

        /// <summary>
        /// Update a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PutMessagesMessageIdAsyncWithHttpInfo (string messageId, VoicemailMessage body = null);
        
        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>string</returns>
        string DeleteMessagesMessageId (string messageId);
  
        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMessagesMessageIdWithHttpInfo (string messageId);

        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMessagesMessageIdAsync (string messageId);

        /// <summary>
        /// Delete a message.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesMessageIdAsyncWithHttpInfo (string messageId);
        
        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>VoicemailMediaInfo</returns>
        VoicemailMediaInfo GetMessagesMessageIdMedia (string messageId, string formatId = null);
  
        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        ApiResponse<VoicemailMediaInfo> GetMessagesMessageIdMediaWithHttpInfo (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        System.Threading.Tasks.Task<VoicemailMediaInfo> GetMessagesMessageIdMediaAsync (string messageId, string formatId = null);

        /// <summary>
        /// Get media playback URI for this message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> GetMessagesMessageIdMediaAsyncWithHttpInfo (string messageId, string formatId = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VoicemailApi : IVoicemailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoicemailApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VoicemailApi(Configuration configuration = null)
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
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy GetUservoicemailpoliciesUserId (string userId)
        {
             ApiResponse<VoicemailUserPolicy> response = GetUservoicemailpoliciesUserIdWithHttpInfo(userId);
             return response.Data;
        }

        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > GetUservoicemailpoliciesUserIdWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->GetUservoicemailpoliciesUserId");
            
    
            var path_ = "/api/v1/configuration/uservoicemailpolicies/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUservoicemailpoliciesUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUservoicemailpoliciesUserId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailUserPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailUserPolicy)));
            
        }
    
        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> GetUservoicemailpoliciesUserIdAsync (string userId)
        {
             ApiResponse<VoicemailUserPolicy> response = await GetUservoicemailpoliciesUserIdAsyncWithHttpInfo(userId);
             return response.Data;

        }

        /// <summary>
        /// Get a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> GetUservoicemailpoliciesUserIdAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUservoicemailpoliciesUserId");
            
    
            var path_ = "/api/v1/configuration/uservoicemailpolicies/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUservoicemailpoliciesUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUservoicemailpoliciesUserId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailUserPolicy)));
            
        }
        
        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The user&#39;s voicemail policy</param> 
        /// <returns>VoicemailUserPolicy</returns>
        public VoicemailUserPolicy PatchUservoicemailpoliciesUserId (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> response = PatchUservoicemailpoliciesUserIdWithHttpInfo(userId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param> 
        /// <param name="body">The user&#39;s voicemail policy</param> 
        /// <returns>ApiResponse of VoicemailUserPolicy</returns>
        public ApiResponse< VoicemailUserPolicy > PatchUservoicemailpoliciesUserIdWithHttpInfo (string userId, VoicemailUserPolicy body)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling VoicemailApi->PatchUservoicemailpoliciesUserId");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VoicemailApi->PatchUservoicemailpoliciesUserId");
            
    
            var path_ = "/api/v1/configuration/uservoicemailpolicies/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
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
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUservoicemailpoliciesUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUservoicemailpoliciesUserId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailUserPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailUserPolicy)));
            
        }
    
        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of VoicemailUserPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailUserPolicy> PatchUservoicemailpoliciesUserIdAsync (string userId, VoicemailUserPolicy body)
        {
             ApiResponse<VoicemailUserPolicy> response = await PatchUservoicemailpoliciesUserIdAsyncWithHttpInfo(userId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a user&#39;s voicemail policy 
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="body">The user&#39;s voicemail policy</param>
        /// <returns>Task of ApiResponse (VoicemailUserPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailUserPolicy>> PatchUservoicemailpoliciesUserIdAsyncWithHttpInfo (string userId, VoicemailUserPolicy body)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling PatchUservoicemailpoliciesUserId");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PatchUservoicemailpoliciesUserId");
            
    
            var path_ = "/api/v1/configuration/uservoicemailpolicies/{userId}";
    
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
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PatchUservoicemailpoliciesUserId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PatchUservoicemailpoliciesUserId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailUserPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailUserPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailUserPolicy)));
            
        }
        
        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy GetVoicemailpolicy ()
        {
             ApiResponse<VoicemailOrganizationPolicy> response = GetVoicemailpolicyWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > GetVoicemailpolicyWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/voicemailpolicy";
    
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
                throw new ApiException (statusCode, "Error calling GetVoicemailpolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetVoicemailpolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailOrganizationPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailOrganizationPolicy)));
            
        }
    
        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> GetVoicemailpolicyAsync ()
        {
             ApiResponse<VoicemailOrganizationPolicy> response = await GetVoicemailpolicyAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get a policy 
        /// </summary>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> GetVoicemailpolicyAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/configuration/voicemailpolicy";
    
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
                throw new ApiException (statusCode, "Error calling GetVoicemailpolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetVoicemailpolicy: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailOrganizationPolicy)));
            
        }
        
        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>VoicemailOrganizationPolicy</returns>
        public VoicemailOrganizationPolicy PutVoicemailpolicy (VoicemailOrganizationPolicy body = null)
        {
             ApiResponse<VoicemailOrganizationPolicy> response = PutVoicemailpolicyWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of VoicemailOrganizationPolicy</returns>
        public ApiResponse< VoicemailOrganizationPolicy > PutVoicemailpolicyWithHttpInfo (VoicemailOrganizationPolicy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/voicemailpolicy";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutVoicemailpolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutVoicemailpolicy: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailOrganizationPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailOrganizationPolicy)));
            
        }
    
        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of VoicemailOrganizationPolicy</returns>
        public async System.Threading.Tasks.Task<VoicemailOrganizationPolicy> PutVoicemailpolicyAsync (VoicemailOrganizationPolicy body = null)
        {
             ApiResponse<VoicemailOrganizationPolicy> response = await PutVoicemailpolicyAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Update a policy 
        /// </summary>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (VoicemailOrganizationPolicy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailOrganizationPolicy>> PutVoicemailpolicyAsyncWithHttpInfo (VoicemailOrganizationPolicy body = null)
        {
            
    
            var path_ = "/api/v1/configuration/voicemailpolicy";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutVoicemailpolicy: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutVoicemailpolicy: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailOrganizationPolicy>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailOrganizationPolicy) Configuration.ApiClient.Deserialize(response, typeof(VoicemailOrganizationPolicy)));
            
        }
        
        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <returns>VoicemailMailboxInfo</returns>
        public VoicemailMailboxInfo GetMailbox ()
        {
             ApiResponse<VoicemailMailboxInfo> response = GetMailboxWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <returns>ApiResponse of VoicemailMailboxInfo</returns>
        public ApiResponse< VoicemailMailboxInfo > GetMailboxWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/voicemail/mailbox";
    
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
                throw new ApiException (statusCode, "Error calling GetMailbox: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMailbox: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailMailboxInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMailboxInfo)));
            
        }
    
        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <returns>Task of VoicemailMailboxInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMailboxInfo> GetMailboxAsync ()
        {
             ApiResponse<VoicemailMailboxInfo> response = await GetMailboxAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get mailbox information 
        /// </summary>
        /// <returns>Task of ApiResponse (VoicemailMailboxInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMailboxInfo>> GetMailboxAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/voicemail/mailbox";
    
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
                throw new ApiException (statusCode, "Error calling GetMailbox: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMailbox: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailMailboxInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMailboxInfo) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMailboxInfo)));
            
        }
        
        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <returns>VoicemailMessageEntityListing</returns>
        public VoicemailMessageEntityListing GetMessages ()
        {
             ApiResponse<VoicemailMessageEntityListing> response = GetMessagesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <returns>ApiResponse of VoicemailMessageEntityListing</returns>
        public ApiResponse< VoicemailMessageEntityListing > GetMessagesWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/voicemail/messages";
    
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
                throw new ApiException (statusCode, "Error calling GetMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailMessageEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMessageEntityListing)));
            
        }
    
        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <returns>Task of VoicemailMessageEntityListing</returns>
        public async System.Threading.Tasks.Task<VoicemailMessageEntityListing> GetMessagesAsync ()
        {
             ApiResponse<VoicemailMessageEntityListing> response = await GetMessagesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// List voicemail messages 
        /// </summary>
        /// <returns>Task of ApiResponse (VoicemailMessageEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessageEntityListing>> GetMessagesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/voicemail/messages";
    
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
                throw new ApiException (statusCode, "Error calling GetMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMessages: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailMessageEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessageEntityListing) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMessageEntityListing)));
            
        }
        
        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <returns>string</returns>
        public string DeleteMessages ()
        {
             ApiResponse<string> response = DeleteMessagesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMessagesWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/voicemail/messages";
    
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
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMessages: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMessagesAsync ()
        {
             ApiResponse<string> response = await DeleteMessagesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Delete all voicemail messages 
        /// </summary>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/voicemail/messages";
    
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
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteMessages: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMessages: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get message. 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage GetMessagesMessageId (string messageId)
        {
             ApiResponse<VoicemailMessage> response = GetMessagesMessageIdWithHttpInfo(messageId);
             return response.Data;
        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > GetMessagesMessageIdWithHttpInfo (string messageId)
        {
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageId");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetMessagesMessageId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMessagesMessageId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMessage)));
            
        }
    
        /// <summary>
        /// Get message. 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> GetMessagesMessageIdAsync (string messageId)
        {
             ApiResponse<VoicemailMessage> response = await GetMessagesMessageIdAsyncWithHttpInfo(messageId);
             return response.Data;

        }

        /// <summary>
        /// Get message. 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> GetMessagesMessageIdAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling GetMessagesMessageId");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetMessagesMessageId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMessagesMessageId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMessage)));
            
        }
        
        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <param name="body">VoicemailMessage</param> 
        /// <returns>VoicemailMessage</returns>
        public VoicemailMessage PutMessagesMessageId (string messageId, VoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> response = PutMessagesMessageIdWithHttpInfo(messageId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <param name="body">VoicemailMessage</param> 
        /// <returns>ApiResponse of VoicemailMessage</returns>
        public ApiResponse< VoicemailMessage > PutMessagesMessageIdWithHttpInfo (string messageId, VoicemailMessage body = null)
        {
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->PutMessagesMessageId");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutMessagesMessageId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutMessagesMessageId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMessage)));
            
        }
    
        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of VoicemailMessage</returns>
        public async System.Threading.Tasks.Task<VoicemailMessage> PutMessagesMessageIdAsync (string messageId, VoicemailMessage body = null)
        {
             ApiResponse<VoicemailMessage> response = await PutMessagesMessageIdAsyncWithHttpInfo(messageId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <param name="body">VoicemailMessage</param>
        /// <returns>Task of ApiResponse (VoicemailMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMessage>> PutMessagesMessageIdAsyncWithHttpInfo (string messageId, VoicemailMessage body = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling PutMessagesMessageId");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutMessagesMessageId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutMessagesMessageId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailMessage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMessage) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMessage)));
            
        }
        
        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <returns>string</returns>
        public string DeleteMessagesMessageId (string messageId)
        {
             ApiResponse<string> response = DeleteMessagesMessageIdWithHttpInfo(messageId);
             return response.Data;
        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMessagesMessageIdWithHttpInfo (string messageId)
        {
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->DeleteMessagesMessageId");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteMessagesMessageId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMessagesMessageId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMessagesMessageIdAsync (string messageId)
        {
             ApiResponse<string> response = await DeleteMessagesMessageIdAsyncWithHttpInfo(messageId);
             return response.Data;

        }

        /// <summary>
        /// Delete a message. 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMessagesMessageIdAsyncWithHttpInfo (string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling DeleteMessagesMessageId");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteMessagesMessageId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteMessagesMessageId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>VoicemailMediaInfo</returns>
        public VoicemailMediaInfo GetMessagesMessageIdMedia (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> response = GetMessagesMessageIdMediaWithHttpInfo(messageId, formatId);
             return response.Data;
        }

        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <param name="messageId">Message ID</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>ApiResponse of VoicemailMediaInfo</returns>
        public ApiResponse< VoicemailMediaInfo > GetMessagesMessageIdMediaWithHttpInfo (string messageId, string formatId = null)
        {
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling VoicemailApi->GetMessagesMessageIdMedia");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}/media";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetMessagesMessageIdMedia: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMessagesMessageIdMedia: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoicemailMediaInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMediaInfo)));
            
        }
    
        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of VoicemailMediaInfo</returns>
        public async System.Threading.Tasks.Task<VoicemailMediaInfo> GetMessagesMessageIdMediaAsync (string messageId, string formatId = null)
        {
             ApiResponse<VoicemailMediaInfo> response = await GetMessagesMessageIdMediaAsyncWithHttpInfo(messageId, formatId);
             return response.Data;

        }

        /// <summary>
        /// Get media playback URI for this message 
        /// </summary>
        /// <param name="messageId">Message ID</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (VoicemailMediaInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoicemailMediaInfo>> GetMessagesMessageIdMediaAsyncWithHttpInfo (string messageId, string formatId = null)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling GetMessagesMessageIdMedia");
            
    
            var path_ = "/api/v1/voicemail/messages/{messageId}/media";
    
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
            if (messageId != null) pathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetMessagesMessageIdMedia: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetMessagesMessageIdMedia: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoicemailMediaInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoicemailMediaInfo) Configuration.ApiClient.Deserialize(response, typeof(VoicemailMediaInfo)));
            
        }
        
    }
    
}
