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
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing QualityFormsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
  
        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> QualityFormsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
        
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityFormsPost (EvaluationForm body = null);
  
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityFormsPostWithHttpInfo (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityFormsPostAsync (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsPostAsyncWithHttpInfo (EvaluationForm body = null);
        
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityFormsFormidGet (string formId);
  
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityFormsFormidGetWithHttpInfo (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidGetAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidGetAsyncWithHttpInfo (string formId);
        
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityFormsFormidPut (string formId, EvaluationForm body = null);
  
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityFormsFormidPutWithHttpInfo (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidPutAsync (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidPutAsyncWithHttpInfo (string formId, EvaluationForm body = null);
        
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>string</returns>
        string QualityFormsFormidDelete (string formId);
  
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> QualityFormsFormidDeleteWithHttpInfo (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> QualityFormsFormidDeleteAsync (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> QualityFormsFormidDeleteAsyncWithHttpInfo (string formId);
        
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
        EvaluationFormEntityListing QualityFormsFormidVersionsGet (string formId, int? pageSize = null, int? pageNumber = null);
  
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
        ApiResponse<EvaluationFormEntityListing> QualityFormsFormidVersionsGetWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsFormidVersionsGetAsync (string formId, int? pageSize = null, int? pageNumber = null);

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
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsFormidVersionsGetAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        
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
        EvaluationFormEntityListing QualityPublishedformsGet (int? pageSize = null, int? pageNumber = null, string name = null);
  
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
        ApiResponse<EvaluationFormEntityListing> QualityPublishedformsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);

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
        System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityPublishedformsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null);

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
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityPublishedformsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityPublishedformsPost (EvaluationForm body = null);
  
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityPublishedformsPostWithHttpInfo (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsPostAsync (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsPostAsyncWithHttpInfo (EvaluationForm body = null);
        
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityPublishedformsFormidGet (string formId);
  
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityPublishedformsFormidGetWithHttpInfo (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsFormidGetAsync (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsFormidGetAsyncWithHttpInfo (string formId);
        
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
        ScriptEntityListing ScriptsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
  
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
        ApiResponse<ScriptEntityListing> ScriptsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

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
        System.Threading.Tasks.Task<ScriptEntityListing> ScriptsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

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
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> ScriptsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
        
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Script</returns>
        Script ScriptsPost (Body2 body = null);
  
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsPostWithHttpInfo (Body2 body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsPostAsync (Body2 body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPostAsyncWithHttpInfo (Body2 body = null);
        
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
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="name">Name</param> 
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing QualityFormsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = QualityFormsGetWithHttpInfo(pageSize, pageNumber, expand, name);
             return response.Data;
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="name">Name</param> 
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > QualityFormsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
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
                throw new ApiException (statusCode, "Error calling QualityFormsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = await QualityFormsGetAsyncWithHttpInfo(pageSize, pageNumber, expand, name);
             return response.Data;

        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
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
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
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
                throw new ApiException (statusCode, "Error calling QualityFormsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
        
        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityFormsPost (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = QualityFormsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityFormsPostWithHttpInfo (EvaluationForm body = null)
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
                throw new ApiException (statusCode, "Error calling QualityFormsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityFormsPostAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = await QualityFormsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsPostAsyncWithHttpInfo (EvaluationForm body = null)
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
                throw new ApiException (statusCode, "Error calling QualityFormsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityFormsFormidGet (string formId)
        {
             ApiResponse<EvaluationForm> response = QualityFormsFormidGetWithHttpInfo(formId);
             return response.Data;
        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityFormsFormidGetWithHttpInfo (string formId)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidGet");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidGetAsync (string formId)
        {
             ApiResponse<EvaluationForm> response = await QualityFormsFormidGetAsyncWithHttpInfo(formId);
             return response.Data;

        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidGetAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidGet");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public EvaluationForm QualityFormsFormidPut (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = QualityFormsFormidPutWithHttpInfo(formId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityFormsFormidPutWithHttpInfo (string formId, EvaluationForm body = null)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidPut");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidPutAsync (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = await QualityFormsFormidPutAsyncWithHttpInfo(formId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidPutAsyncWithHttpInfo (string formId, EvaluationForm body = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidPut");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>string</returns>
        public string QualityFormsFormidDelete (string formId)
        {
             ApiResponse<string> response = QualityFormsFormidDeleteWithHttpInfo(formId);
             return response.Data;
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > QualityFormsFormidDeleteWithHttpInfo (string formId)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidDelete");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> QualityFormsFormidDeleteAsync (string formId)
        {
             ApiResponse<string> response = await QualityFormsFormidDeleteAsyncWithHttpInfo(formId);
             return response.Data;

        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> QualityFormsFormidDeleteAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidDelete");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidDelete: " + response.ErrorMessage, response.ErrorMessage);

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
        public EvaluationFormEntityListing QualityFormsFormidVersionsGet (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = QualityFormsFormidVersionsGetWithHttpInfo(formId, pageSize, pageNumber);
             return response.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > QualityFormsFormidVersionsGetWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidVersionsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidVersionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidVersionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsFormidVersionsGetAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = await QualityFormsFormidVersionsGetAsyncWithHttpInfo(formId, pageSize, pageNumber);
             return response.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsFormidVersionsGetAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityFormsFormidVersionsGet");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityFormsFormidVersionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityFormsFormidVersionsGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public EvaluationFormEntityListing QualityPublishedformsGet (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = QualityPublishedformsGetWithHttpInfo(pageSize, pageNumber, name);
             return response.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > QualityPublishedformsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
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
                throw new ApiException (statusCode, "Error calling QualityPublishedformsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityPublishedformsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityPublishedformsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> response = await QualityPublishedformsGetAsyncWithHttpInfo(pageSize, pageNumber, name);
             return response.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityPublishedformsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
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
                throw new ApiException (statusCode, "Error calling QualityPublishedformsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityPublishedformsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationFormEntityListing)));
            
        }
        
        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityPublishedformsPost (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = QualityPublishedformsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityPublishedformsPostWithHttpInfo (EvaluationForm body = null)
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
                throw new ApiException (statusCode, "Error calling QualityPublishedformsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityPublishedformsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsPostAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> response = await QualityPublishedformsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsPostAsyncWithHttpInfo (EvaluationForm body = null)
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
                throw new ApiException (statusCode, "Error calling QualityPublishedformsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityPublishedformsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
        
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityPublishedformsFormidGet (string formId)
        {
             ApiResponse<EvaluationForm> response = QualityPublishedformsFormidGetWithHttpInfo(formId);
             return response.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param> 
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityPublishedformsFormidGetWithHttpInfo (string formId)
        {
            
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityPublishedformsFormidGet");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityPublishedformsFormidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityPublishedformsFormidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationForm>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(response, typeof(EvaluationForm)));
            
        }
    
        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsFormidGetAsync (string formId)
        {
             ApiResponse<EvaluationForm> response = await QualityPublishedformsFormidGetAsyncWithHttpInfo(formId);
             return response.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsFormidGetAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null) throw new ApiException(400, "Missing required parameter 'formId' when calling QualityPublishedformsFormidGet");
            
    
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
                throw new ApiException (statusCode, "Error calling QualityPublishedformsFormidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling QualityPublishedformsFormidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public ScriptEntityListing ScriptsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> response = ScriptsGetWithHttpInfo(pageSize, pageNumber, expand, name, feature);
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
        public ApiResponse< ScriptEntityListing > ScriptsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
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
                throw new ApiException (statusCode, "Error calling ScriptsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ScriptEntityListing> ScriptsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> response = await ScriptsGetAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature);
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
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> ScriptsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
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
                throw new ApiException (statusCode, "Error calling ScriptsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScriptEntityListing)));
            
        }
        
        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Script</returns>
        public Script ScriptsPost (Body2 body = null)
        {
             ApiResponse<Script> response = ScriptsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsPostWithHttpInfo (Body2 body = null)
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
                throw new ApiException (statusCode, "Error calling ScriptsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
    
        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsPostAsync (Body2 body = null)
        {
             ApiResponse<Script> response = await ScriptsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPostAsyncWithHttpInfo (Body2 body = null)
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
                throw new ApiException (statusCode, "Error calling ScriptsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
        
    }
    
}
