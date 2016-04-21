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
    public interface IScriptsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>string</returns>
        string QualityFormsFormidDelete (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> QualityFormsFormidDeleteWithHttpInfo (string formId);
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityFormsFormidGet (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityFormsFormidGetWithHttpInfo (string formId);
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityFormsFormidPut (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityFormsFormidPutWithHttpInfo (string formId, EvaluationForm body = null);
        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing QualityFormsFormidVersionsGet (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> QualityFormsFormidVersionsGetWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing QualityFormsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> QualityFormsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityFormsPost (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityFormsPostWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityPublishedformsFormidGet (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityPublishedformsFormidGetWithHttpInfo (string formId);
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing QualityPublishedformsGet (int? pageSize = null, int? pageNumber = null, string name = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> QualityPublishedformsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm QualityPublishedformsPost (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> QualityPublishedformsPostWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        ScriptEntityListing ScriptsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        ApiResponse<ScriptEntityListing> ScriptsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Script</returns>
        Script ScriptsPost (Object body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsPostWithHttpInfo (Object body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> QualityFormsFormidDeleteAsync (string formId);

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> QualityFormsFormidDeleteAsyncWithHttpInfo (string formId);
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidGetAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidGetAsyncWithHttpInfo (string formId);
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidPutAsync (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidPutAsyncWithHttpInfo (string formId, EvaluationForm body = null);
        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsFormidVersionsGetAsync (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsFormidVersionsGetAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null);
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityFormsPostAsync (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsPostAsyncWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsFormidGetAsync (string formId);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsFormidGetAsyncWithHttpInfo (string formId);
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityPublishedformsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityPublishedformsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsPostAsync (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsPostAsyncWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        System.Threading.Tasks.Task<ScriptEntityListing> ScriptsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

        /// <summary>
        /// Get the list of scripts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> ScriptsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsPostAsync (Object body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPostAsyncWithHttpInfo (Object body = null);
        #endregion Asynchronous Operations
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

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>string</returns>
        public string QualityFormsFormidDelete (string formId)
        {
             ApiResponse<string> localVarResponse = QualityFormsFormidDeleteWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > QualityFormsFormidDeleteWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidDelete");

            var localVarPath = "/api/v1/quality/forms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> QualityFormsFormidDeleteAsync (string formId)
        {
             ApiResponse<string> localVarResponse = await QualityFormsFormidDeleteAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> QualityFormsFormidDeleteAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidDelete");

            var localVarPath = "/api/v1/quality/forms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityFormsFormidGet (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = QualityFormsFormidGetWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityFormsFormidGetWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidGet");

            var localVarPath = "/api/v1/quality/forms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidGetAsync (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = await QualityFormsFormidGetAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidGetAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidGet");

            var localVarPath = "/api/v1/quality/forms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityFormsFormidPut (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = QualityFormsFormidPutWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityFormsFormidPutWithHttpInfo (string formId, EvaluationForm body = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidPut");

            var localVarPath = "/api/v1/quality/forms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityFormsFormidPutAsync (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = await QualityFormsFormidPutAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsFormidPutAsyncWithHttpInfo (string formId, EvaluationForm body = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidPut");

            var localVarPath = "/api/v1/quality/forms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing QualityFormsFormidVersionsGet (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = QualityFormsFormidVersionsGetWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > QualityFormsFormidVersionsGetWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidVersionsGet");

            var localVarPath = "/api/v1/quality/forms/{formId}/versions";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidVersionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidVersionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsFormidVersionsGetAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await QualityFormsFormidVersionsGetAsyncWithHttpInfo(formId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsFormidVersionsGetAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityFormsFormidVersionsGet");

            var localVarPath = "/api/v1/quality/forms/{formId}/versions";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidVersionsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsFormidVersionsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing QualityFormsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = QualityFormsGetWithHttpInfo(pageSize, pageNumber, expand, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > QualityFormsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {

            var localVarPath = "/api/v1/quality/forms";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityFormsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await QualityFormsGetAsyncWithHttpInfo(pageSize, pageNumber, expand, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityFormsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null)
        {

            var localVarPath = "/api/v1/quality/forms";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityFormsPost (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = QualityFormsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityFormsPostWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v1/quality/forms";
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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityFormsPostAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = await QualityFormsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityFormsPostAsyncWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v1/quality/forms";
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
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityFormsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityPublishedformsFormidGet (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = QualityPublishedformsFormidGetWithHttpInfo(formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityPublishedformsFormidGetWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityPublishedformsFormidGet");

            var localVarPath = "/api/v1/quality/publishedforms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsFormidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsFormidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsFormidGetAsync (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = await QualityPublishedformsFormidGetAsyncWithHttpInfo(formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsFormidGetAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling ScriptsApi->QualityPublishedformsFormidGet");

            var localVarPath = "/api/v1/quality/publishedforms/{formId}";
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
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsFormidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsFormidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing QualityPublishedformsGet (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = QualityPublishedformsGetWithHttpInfo(pageSize, pageNumber, name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > QualityPublishedformsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
        {

            var localVarPath = "/api/v1/quality/publishedforms";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> QualityPublishedformsGetAsync (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await QualityPublishedformsGetAsyncWithHttpInfo(pageSize, pageNumber, name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> QualityPublishedformsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
        {

            var localVarPath = "/api/v1/quality/publishedforms";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
            
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm QualityPublishedformsPost (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = QualityPublishedformsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > QualityPublishedformsPostWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v1/quality/publishedforms";
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
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> QualityPublishedformsPostAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = await QualityPublishedformsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> QualityPublishedformsPostAsyncWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v1/quality/publishedforms";
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
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityPublishedformsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing ScriptsGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = ScriptsGetWithHttpInfo(pageSize, pageNumber, expand, name, feature);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > ScriptsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {

            var localVarPath = "/api/v1/scripts";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ScriptsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ScriptsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> ScriptsGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> localVarResponse = await ScriptsGetAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of scripts 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="feature">Feature (optional)</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> ScriptsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {

            var localVarPath = "/api/v1/scripts";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (feature != null) localVarQueryParams.Add("feature", Configuration.ApiClient.ParameterToString(feature)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ScriptsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ScriptsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScriptEntityListing)));
            
        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Script</returns>
        public Script ScriptsPost (Object body = null)
        {
             ApiResponse<Script> localVarResponse = ScriptsPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsPostWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/scripts";
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
                throw new ApiException (localVarStatusCode, "Error calling ScriptsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ScriptsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsPostAsync (Object body = null)
        {
             ApiResponse<Script> localVarResponse = await ScriptsPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPostAsyncWithHttpInfo (Object body = null)
        {

            var localVarPath = "/api/v1/scripts";
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
                throw new ApiException (localVarStatusCode, "Error calling ScriptsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ScriptsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Script>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Script)));
            
        }

    }
}
