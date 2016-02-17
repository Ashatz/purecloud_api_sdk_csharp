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
    public interface IScriptsApi
    {
        
        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="expand2">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null);
  
        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="expand2">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="expand2">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="expand2">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null);
        
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm CreateForms (EvaluationForm body = null);
  
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> CreateFormsWithHttpInfo (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> CreateFormsAsync (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> CreateFormsAsyncWithHttpInfo (EvaluationForm body = null);
        
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm GetForm (string formId);
  
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> GetFormWithHttpInfo (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> GetFormAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetFormAsyncWithHttpInfo (string formId);
        
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm UpdateForm (string formId, EvaluationForm body = null);
  
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> UpdateFormWithHttpInfo (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> UpdateFormAsync (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> UpdateFormAsyncWithHttpInfo (string formId, EvaluationForm body = null);
        
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>string</returns>
        string DeleteForm (string formId);
  
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteFormWithHttpInfo (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteFormAsync (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteFormAsyncWithHttpInfo (string formId);
        
        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetFormVersions (string formId, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetFormVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null);
  
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm CreatePublishedforms (EvaluationForm body = null);
  
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> CreatePublishedformsWithHttpInfo (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> CreatePublishedformsAsync (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> CreatePublishedformsAsyncWithHttpInfo (EvaluationForm body = null);
        
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm GetPublishedformsForm (string formId);
  
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> GetPublishedformsFormWithHttpInfo (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> GetPublishedformsFormAsync (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetPublishedformsFormAsyncWithHttpInfo (string formId);
        
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>ScriptEntityListing</returns>
        ScriptEntityListing Get (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
  
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        ApiResponse<ScriptEntityListing> GetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>Task of ScriptEntityListing</returns>
        System.Threading.Tasks.Task<ScriptEntityListing> GetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
        
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Script</returns>
        Script Create (Body2 body = null);
  
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> CreateWithHttpInfo (Body2 body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> CreateAsync (Body2 body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> CreateAsyncWithHttpInfo (Body2 body = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScriptsApi : IScriptsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScriptsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScriptsApi(Configuration configuration = null)
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
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="expand2">Expand</param> 
        /// <param name="name">Name</param> 
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = GetFormsWithHttpInfo(pageSize, pageNumber, sortBy, expand, expand2, name);
             return response.Data;
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="expand2">Expand</param> 
        /// <param name="name">Name</param> 
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null)
        {
            
    
            var path_ = "/api/v1/quality/forms";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (expand2 != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand2)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetForms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetForms: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="expand2">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = await GetFormsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, expand2, name);
             return response.Data;

        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="expand2">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string expand2 = null, string name = null)
        {
            
    
            var path_ = "/api/v1/quality/forms";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (expand2 != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand2)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetForms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetForms: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
        
        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm CreateForms (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = CreateFormsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > CreateFormsWithHttpInfo (EvaluationForm body = null)
        {
            
    
            var path_ = "/api/v1/quality/forms";
    
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
                throw new ApiException (statusCode, "Error calling CreateForms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateForms: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> CreateFormsAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = await CreateFormsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> CreateFormsAsyncWithHttpInfo (EvaluationForm body = null)
        {
            
    
            var path_ = "/api/v1/quality/forms";
    
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
                throw new ApiException (statusCode, "Error calling CreateForms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateForms: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm GetForm (string formId)
        {
             ApiResponse<EvaluationForm> response = GetFormWithHttpInfo(formId);
             return response.Data;
        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > GetFormWithHttpInfo (string formId)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling GetForm");
            
    
            var path_ = "/api/v1/quality/forms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetForm: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> GetFormAsync (string formId)
        {
             ApiResponse<EvaluationForm> response = await GetFormAsyncWithHttpInfo(formId);
             return response.Data;

        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetFormAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling GetForm");
            
    
            var path_ = "/api/v1/quality/forms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetForm: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <param name="body"></param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm UpdateForm (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = UpdateFormWithHttpInfo(formId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > UpdateFormWithHttpInfo (string formId, EvaluationForm body = null)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling UpdateForm");
            
    
            var path_ = "/api/v1/quality/forms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateForm: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> UpdateFormAsync (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = await UpdateFormAsyncWithHttpInfo(formId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> UpdateFormAsyncWithHttpInfo (string formId, EvaluationForm body = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling UpdateForm");
            
    
            var path_ = "/api/v1/quality/forms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling UpdateForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateForm: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>string</returns>
        public string DeleteForm (string formId)
        {
             ApiResponse<string> response = DeleteFormWithHttpInfo(formId);
             return response.Data;
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteFormWithHttpInfo (string formId)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling DeleteForm");
            
    
            var path_ = "/api/v1/quality/forms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteForm: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteFormAsync (string formId)
        {
             ApiResponse<string> response = await DeleteFormAsyncWithHttpInfo(formId);
             return response.Data;

        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteFormAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling DeleteForm");
            
    
            var path_ = "/api/v1/quality/forms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteForm: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetFormVersions (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = GetFormVersionsWithHttpInfo(formId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetFormVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling GetFormVersions");
            
    
            var path_ = "/api/v1/quality/forms/{formId}/versions";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFormVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFormVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
    
        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = await GetFormVersionsAsyncWithHttpInfo(formId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling GetFormVersions");
            
    
            var path_ = "/api/v1/quality/forms/{formId}/versions";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFormVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFormVersions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = GetPublishedformsWithHttpInfo(pageSize, pageNumber, name);
             return response.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
        {
            
    
            var path_ = "/api/v1/quality/publishedforms";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPublishedforms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPublishedforms: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
    
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = await GetPublishedformsAsyncWithHttpInfo(pageSize, pageNumber, name);
             return response.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
        {
            
    
            var path_ = "/api/v1/quality/publishedforms";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPublishedforms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPublishedforms: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
        
        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm CreatePublishedforms (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = CreatePublishedformsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > CreatePublishedformsWithHttpInfo (EvaluationForm body = null)
        {
            
    
            var path_ = "/api/v1/quality/publishedforms";
    
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
                throw new ApiException (statusCode, "Error calling CreatePublishedforms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreatePublishedforms: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> CreatePublishedformsAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = await CreatePublishedformsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> CreatePublishedformsAsyncWithHttpInfo (EvaluationForm body = null)
        {
            
    
            var path_ = "/api/v1/quality/publishedforms";
    
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
                throw new ApiException (statusCode, "Error calling CreatePublishedforms: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreatePublishedforms: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm GetPublishedformsForm (string formId)
        {
             ApiResponse<EvaluationForm> response = GetPublishedformsFormWithHttpInfo(formId);
             return response.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > GetPublishedformsFormWithHttpInfo (string formId)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling GetPublishedformsForm");
            
    
            var path_ = "/api/v1/quality/publishedforms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPublishedformsForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPublishedformsForm: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> GetPublishedformsFormAsync (string formId)
        {
             ApiResponse<EvaluationForm> response = await GetPublishedformsFormAsyncWithHttpInfo(formId);
             return response.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetPublishedformsFormAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling GetPublishedformsForm");
            
    
            var path_ = "/api/v1/quality/publishedforms/{formId}";
    
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
            if (formId != null) pathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPublishedformsForm: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPublishedformsForm: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="name">Name</param> 
        /// <param name="feature">Feature</param> 
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing Get (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> response = GetWithHttpInfo(pageSize, pageNumber, expand, name, feature);
             return response.Data;
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="name">Name</param> 
        /// <param name="feature">Feature</param> 
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > GetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
            
    
            var path_ = "/api/v1/scripts";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) queryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScriptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScriptEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> GetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> response = await GetAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature);
             return response.Data;

        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> GetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
            
    
            var path_ = "/api/v1/scripts";
    
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
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) queryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScriptEntityListing)));
            
        }
        
        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Script</returns>
        public Script Create (Body2 body = null)
        {
             ApiResponse<Script> response = CreateWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > CreateWithHttpInfo (Body2 body = null)
        {
            
    
            var path_ = "/api/v1/scripts";
    
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
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
    
        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> CreateAsync (Body2 body = null)
        {
             ApiResponse<Script> response = await CreateAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> CreateAsyncWithHttpInfo (Body2 body = null)
        {
            
    
            var path_ = "/api/v1/scripts";
    
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
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
        
    }
    
}
