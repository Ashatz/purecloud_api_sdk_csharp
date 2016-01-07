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
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;Template&gt;</returns>
        List<Template> EvaluationsFavoritetemplatesGet ();
  
        /// <summary>
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;Template&gt;</returns>
        ApiResponse<List<Template>> EvaluationsFavoritetemplatesGetWithHttpInfo ();

        /// <summary>
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;Template&gt;</returns>
        System.Threading.Tasks.Task<List<Template>> EvaluationsFavoritetemplatesGetAsync ();

        /// <summary>
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;Template&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Template>>> EvaluationsFavoritetemplatesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template EvaluationsFavoritetemplatesPost (FavoriteTemplateRequestData body = null);
  
        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> EvaluationsFavoritetemplatesPostWithHttpInfo (FavoriteTemplateRequestData body = null);

        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> EvaluationsFavoritetemplatesPostAsync (FavoriteTemplateRequestData body = null);

        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsFavoritetemplatesPostAsyncWithHttpInfo (FavoriteTemplateRequestData body = null);
        
        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>string</returns>
        string EvaluationsFavoritetemplatesTemplateidDelete (string templateId);
  
        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> EvaluationsFavoritetemplatesTemplateidDeleteWithHttpInfo (string templateId);

        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> EvaluationsFavoritetemplatesTemplateidDeleteAsync (string templateId);

        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> EvaluationsFavoritetemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId);
        
        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>TemplateEntityListing</returns>
        TemplateEntityListing EvaluationsTemplatesGet (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);
  
        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>ApiResponse of TemplateEntityListing</returns>
        ApiResponse<TemplateEntityListing> EvaluationsTemplatesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);

        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of TemplateEntityListing</returns>
        System.Threading.Tasks.Task<TemplateEntityListing> EvaluationsTemplatesGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);

        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of ApiResponse (TemplateEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateEntityListing>> EvaluationsTemplatesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);
        
        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template EvaluationsTemplatesPost (Template body = null);
  
        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> EvaluationsTemplatesPostWithHttpInfo (Template body = null);

        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> EvaluationsTemplatesPostAsync (Template body = null);

        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsTemplatesPostAsyncWithHttpInfo (Template body = null);
        
        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Template</returns>
        Template EvaluationsTemplatesTemplateidGet (string templateId);
  
        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> EvaluationsTemplatesTemplateidGetWithHttpInfo (string templateId);

        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> EvaluationsTemplatesTemplateidGetAsync (string templateId);

        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsTemplatesTemplateidGetAsyncWithHttpInfo (string templateId);
        
        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template EvaluationsTemplatesTemplateidPut (string templateId, Template body = null);
  
        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> EvaluationsTemplatesTemplateidPutWithHttpInfo (string templateId, Template body = null);

        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> EvaluationsTemplatesTemplateidPutAsync (string templateId, Template body = null);

        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsTemplatesTemplateidPutAsyncWithHttpInfo (string templateId, Template body = null);
        
        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>string</returns>
        string EvaluationsTemplatesTemplateidDelete (string templateId);
  
        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> EvaluationsTemplatesTemplateidDeleteWithHttpInfo (string templateId);

        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> EvaluationsTemplatesTemplateidDeleteAsync (string templateId);

        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> EvaluationsTemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId);
        
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
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;Template&gt;</returns>
        List<Template> ScripterFavoritetemplatesGet ();
  
        /// <summary>
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;Template&gt;</returns>
        ApiResponse<List<Template>> ScripterFavoritetemplatesGetWithHttpInfo ();

        /// <summary>
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;Template&gt;</returns>
        System.Threading.Tasks.Task<List<Template>> ScripterFavoritetemplatesGetAsync ();

        /// <summary>
        /// Get favorite templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;Template&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Template>>> ScripterFavoritetemplatesGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template ScripterFavoritetemplatesPost (FavoriteTemplateRequestData body = null);
  
        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> ScripterFavoritetemplatesPostWithHttpInfo (FavoriteTemplateRequestData body = null);

        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> ScripterFavoritetemplatesPostAsync (FavoriteTemplateRequestData body = null);

        /// <summary>
        /// Set a favorite template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> ScripterFavoritetemplatesPostAsyncWithHttpInfo (FavoriteTemplateRequestData body = null);
        
        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>string</returns>
        string ScripterFavoritetemplatesTemplateidDelete (string templateId);
  
        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ScripterFavoritetemplatesTemplateidDeleteWithHttpInfo (string templateId);

        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ScripterFavoritetemplatesTemplateidDeleteAsync (string templateId);

        /// <summary>
        /// Unset favority template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ScripterFavoritetemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId);
        
        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>TemplateEntityListing</returns>
        TemplateEntityListing ScripterTemplatesGet (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);
  
        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>ApiResponse of TemplateEntityListing</returns>
        ApiResponse<TemplateEntityListing> ScripterTemplatesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);

        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of TemplateEntityListing</returns>
        System.Threading.Tasks.Task<TemplateEntityListing> ScripterTemplatesGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);

        /// <summary>
        /// Get the list of templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of ApiResponse (TemplateEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateEntityListing>> ScripterTemplatesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null);
        
        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template ScripterTemplatesPost (Template body = null);
  
        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> ScripterTemplatesPostWithHttpInfo (Template body = null);

        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> ScripterTemplatesPostAsync (Template body = null);

        /// <summary>
        /// Create a template.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> ScripterTemplatesPostAsyncWithHttpInfo (Template body = null);
        
        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Template</returns>
        Template ScripterTemplatesTemplateidGet (string templateId);
  
        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> ScripterTemplatesTemplateidGetWithHttpInfo (string templateId);

        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> ScripterTemplatesTemplateidGetAsync (string templateId);

        /// <summary>
        /// Get a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> ScripterTemplatesTemplateidGetAsyncWithHttpInfo (string templateId);
        
        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template ScripterTemplatesTemplateidPut (string templateId, Template body = null);
  
        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> ScripterTemplatesTemplateidPutWithHttpInfo (string templateId, Template body = null);

        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> ScripterTemplatesTemplateidPutAsync (string templateId, Template body = null);

        /// <summary>
        /// Update a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> ScripterTemplatesTemplateidPutAsyncWithHttpInfo (string templateId, Template body = null);
        
        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>string</returns>
        string ScripterTemplatesTemplateidDelete (string templateId);
  
        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ScripterTemplatesTemplateidDeleteWithHttpInfo (string templateId);

        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ScripterTemplatesTemplateidDeleteAsync (string templateId);

        /// <summary>
        /// Delete a composer template
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ScripterTemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId);
        
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
        Script ScriptsPost (Body4 body = null);
  
        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsPostWithHttpInfo (Body4 body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsPostAsync (Body4 body = null);

        /// <summary>
        /// Create a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPostAsyncWithHttpInfo (Body4 body = null);
        
        /// <summary>
        /// Get the published scripts.
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
        ScriptEntityListing ScriptsPublishedGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
  
        /// <summary>
        /// Get the published scripts.
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
        ApiResponse<ScriptEntityListing> ScriptsPublishedGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

        /// <summary>
        /// Get the published scripts.
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
        System.Threading.Tasks.Task<ScriptEntityListing> ScriptsPublishedGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);

        /// <summary>
        /// Get the published scripts.
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
        System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> ScriptsPublishedGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null);
        
        /// <summary>
        /// Publish a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Script</returns>
        Script ScriptsPublishedPost (PublishScriptRequestData body = null);
  
        /// <summary>
        /// Publish a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsPublishedPostWithHttpInfo (PublishScriptRequestData body = null);

        /// <summary>
        /// Publish a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsPublishedPostAsync (PublishScriptRequestData body = null);

        /// <summary>
        /// Publish a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPublishedPostAsyncWithHttpInfo (PublishScriptRequestData body = null);
        
        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        Script ScriptsPublishedScriptidGet (string scriptId);
  
        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsPublishedScriptidGetWithHttpInfo (string scriptId);

        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsPublishedScriptidGetAsync (string scriptId);

        /// <summary>
        /// Get the published script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPublishedScriptidGetAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        List<Page> ScriptsPublishedScriptidPagesGet (string scriptId);
  
        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        ApiResponse<List<Page>> ScriptsPublishedScriptidPagesGetWithHttpInfo (string scriptId);

        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        System.Threading.Tasks.Task<List<Page>> ScriptsPublishedScriptidPagesGetAsync (string scriptId);

        /// <summary>
        /// Get the list of published pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Page>>> ScriptsPublishedScriptidPagesGetAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        Page ScriptsPublishedScriptidPagesPageidGet (string scriptId, string pageId);
  
        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> ScriptsPublishedScriptidPagesPageidGetWithHttpInfo (string scriptId, string pageId);

        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> ScriptsPublishedScriptidPagesPageidGetAsync (string scriptId, string pageId);

        /// <summary>
        /// Get the published page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsPublishedScriptidPagesPageidGetAsyncWithHttpInfo (string scriptId, string pageId);
        
        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 ScriptsPublishedScriptidVariablesGet (string scriptId);
  
        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> ScriptsPublishedScriptidVariablesGetWithHttpInfo (string scriptId);

        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> ScriptsPublishedScriptidVariablesGetAsync (string scriptId);

        /// <summary>
        /// Get the published variables
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> ScriptsPublishedScriptidVariablesGetAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Create a template from a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Template</returns>
        Template ScriptsTemplatesPost (CreateTemplateFromScriptRequestData body = null);
  
        /// <summary>
        /// Create a template from a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Template</returns>
        ApiResponse<Template> ScriptsTemplatesPostWithHttpInfo (CreateTemplateFromScriptRequestData body = null);

        /// <summary>
        /// Create a template from a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        System.Threading.Tasks.Task<Template> ScriptsTemplatesPostAsync (CreateTemplateFromScriptRequestData body = null);

        /// <summary>
        /// Create a template from a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        System.Threading.Tasks.Task<ApiResponse<Template>> ScriptsTemplatesPostAsyncWithHttpInfo (CreateTemplateFromScriptRequestData body = null);
        
        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Script</returns>
        Script ScriptsScriptidGet (string scriptId);
  
        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsScriptidGetWithHttpInfo (string scriptId);

        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsScriptidGetAsync (string scriptId);

        /// <summary>
        /// Get a script
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsScriptidGetAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Update a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Script</returns>
        Script ScriptsScriptidPut (string scriptId, Script body = null);
  
        /// <summary>
        /// Update a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Script</returns>
        ApiResponse<Script> ScriptsScriptidPutWithHttpInfo (string scriptId, Script body = null);

        /// <summary>
        /// Update a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        System.Threading.Tasks.Task<Script> ScriptsScriptidPutAsync (string scriptId, Script body = null);

        /// <summary>
        /// Update a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsScriptidPutAsyncWithHttpInfo (string scriptId, Script body = null);
        
        /// <summary>
        /// Delete a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>string</returns>
        string ScriptsScriptidDelete (string scriptId);
  
        /// <summary>
        /// Delete a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ScriptsScriptidDeleteWithHttpInfo (string scriptId);

        /// <summary>
        /// Delete a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ScriptsScriptidDeleteAsync (string scriptId);

        /// <summary>
        /// Delete a script.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ScriptsScriptidDeleteAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>List&lt;Page&gt;</returns>
        List<Page> ScriptsScriptidPagesGet (string scriptId);
  
        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        ApiResponse<List<Page>> ScriptsScriptidPagesGetWithHttpInfo (string scriptId);

        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        System.Threading.Tasks.Task<List<Page>> ScriptsScriptidPagesGetAsync (string scriptId);

        /// <summary>
        /// Get the list of pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Page>>> ScriptsScriptidPagesGetAsyncWithHttpInfo (string scriptId);
        
        /// <summary>
        /// Create a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Page</returns>
        Page ScriptsScriptidPagesPost (string scriptId, Page body = null);
  
        /// <summary>
        /// Create a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> ScriptsScriptidPagesPostWithHttpInfo (string scriptId, Page body = null);

        /// <summary>
        /// Create a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> ScriptsScriptidPagesPostAsync (string scriptId, Page body = null);

        /// <summary>
        /// Create a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsScriptidPagesPostAsyncWithHttpInfo (string scriptId, Page body = null);
        
        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Page</returns>
        Page ScriptsScriptidPagesPageidGet (string scriptId, string pageId);
  
        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> ScriptsScriptidPagesPageidGetWithHttpInfo (string scriptId, string pageId);

        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> ScriptsScriptidPagesPageidGetAsync (string scriptId, string pageId);

        /// <summary>
        /// Get a page
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsScriptidPagesPageidGetAsyncWithHttpInfo (string scriptId, string pageId);
        
        /// <summary>
        /// Update a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <param name="body"></param>
        /// <returns>Page</returns>
        Page ScriptsScriptidPagesPageidPut (string scriptId, string pageId, Page body = null);
  
        /// <summary>
        /// Update a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Page</returns>
        ApiResponse<Page> ScriptsScriptidPagesPageidPutWithHttpInfo (string scriptId, string pageId, Page body = null);

        /// <summary>
        /// Update a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Page</returns>
        System.Threading.Tasks.Task<Page> ScriptsScriptidPagesPageidPutAsync (string scriptId, string pageId, Page body = null);

        /// <summary>
        /// Update a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Page)</returns>
        System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsScriptidPagesPageidPutAsyncWithHttpInfo (string scriptId, string pageId, Page body = null);
        
        /// <summary>
        /// Delete a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>string</returns>
        string ScriptsScriptidPagesPageidDelete (string scriptId, string pageId);
  
        /// <summary>
        /// Delete a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ScriptsScriptidPagesPageidDeleteWithHttpInfo (string scriptId, string pageId);

        /// <summary>
        /// Delete a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ScriptsScriptidPagesPageidDeleteAsync (string scriptId, string pageId);

        /// <summary>
        /// Delete a page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ScriptsScriptidPagesPageidDeleteAsyncWithHttpInfo (string scriptId, string pageId);
        
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
        /// Get favorite templates 
        /// </summary>
        /// <returns>List&lt;Template&gt;</returns>
        public List<Template> EvaluationsFavoritetemplatesGet ()
        {
             ApiResponse<List<Template>> response = EvaluationsFavoritetemplatesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get favorite templates 
        /// </summary>
        /// <returns>ApiResponse of List&lt;Template&gt;</returns>
        public ApiResponse< List<Template> > EvaluationsFavoritetemplatesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/evaluations/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Template>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Template>) Configuration.ApiClient.Deserialize(response, typeof(List<Template>)));
            
        }
    
        /// <summary>
        /// Get favorite templates 
        /// </summary>
        /// <returns>Task of List&lt;Template&gt;</returns>
        public async System.Threading.Tasks.Task<List<Template>> EvaluationsFavoritetemplatesGetAsync ()
        {
             ApiResponse<List<Template>> response = await EvaluationsFavoritetemplatesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get favorite templates 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;Template&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Template>>> EvaluationsFavoritetemplatesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/evaluations/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Template>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Template>) Configuration.ApiClient.Deserialize(response, typeof(List<Template>)));
            
        }
        
        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template EvaluationsFavoritetemplatesPost (FavoriteTemplateRequestData body = null)
        {
             ApiResponse<Template> response = EvaluationsFavoritetemplatesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > EvaluationsFavoritetemplatesPostWithHttpInfo (FavoriteTemplateRequestData body = null)
        {
            
    
            var path_ = "/api/v1/evaluations/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> EvaluationsFavoritetemplatesPostAsync (FavoriteTemplateRequestData body = null)
        {
             ApiResponse<Template> response = await EvaluationsFavoritetemplatesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsFavoritetemplatesPostAsyncWithHttpInfo (FavoriteTemplateRequestData body = null)
        {
            
    
            var path_ = "/api/v1/evaluations/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param> 
        /// <returns>string</returns>
        public string EvaluationsFavoritetemplatesTemplateidDelete (string templateId)
        {
             ApiResponse<string> response = EvaluationsFavoritetemplatesTemplateidDeleteWithHttpInfo(templateId);
             return response.Data;
        }

        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > EvaluationsFavoritetemplatesTemplateidDeleteWithHttpInfo (string templateId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsFavoritetemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/evaluations/favoritetemplates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> EvaluationsFavoritetemplatesTemplateidDeleteAsync (string templateId)
        {
             ApiResponse<string> response = await EvaluationsFavoritetemplatesTemplateidDeleteAsyncWithHttpInfo(templateId);
             return response.Data;

        }

        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> EvaluationsFavoritetemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsFavoritetemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/evaluations/favoritetemplates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsFavoritetemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="tags">Tags</param> 
        /// <returns>TemplateEntityListing</returns>
        public TemplateEntityListing EvaluationsTemplatesGet (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
             ApiResponse<TemplateEntityListing> response = EvaluationsTemplatesGetWithHttpInfo(pageSize, pageNumber, expand, tags);
             return response.Data;
        }

        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="tags">Tags</param> 
        /// <returns>ApiResponse of TemplateEntityListing</returns>
        public ApiResponse< TemplateEntityListing > EvaluationsTemplatesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
            
    
            var path_ = "/api/v1/evaluations/templates";
    
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
            if (tags != null) queryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TemplateEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of TemplateEntityListing</returns>
        public async System.Threading.Tasks.Task<TemplateEntityListing> EvaluationsTemplatesGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
             ApiResponse<TemplateEntityListing> response = await EvaluationsTemplatesGetAsyncWithHttpInfo(pageSize, pageNumber, expand, tags);
             return response.Data;

        }

        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of ApiResponse (TemplateEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateEntityListing>> EvaluationsTemplatesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
            
    
            var path_ = "/api/v1/evaluations/templates";
    
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
            if (tags != null) queryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TemplateEntityListing)));
            
        }
        
        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template EvaluationsTemplatesPost (Template body = null)
        {
             ApiResponse<Template> response = EvaluationsTemplatesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > EvaluationsTemplatesPostWithHttpInfo (Template body = null)
        {
            
    
            var path_ = "/api/v1/evaluations/templates";
    
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> EvaluationsTemplatesPostAsync (Template body = null)
        {
             ApiResponse<Template> response = await EvaluationsTemplatesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsTemplatesPostAsyncWithHttpInfo (Template body = null)
        {
            
    
            var path_ = "/api/v1/evaluations/templates";
    
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>Template</returns>
        public Template EvaluationsTemplatesTemplateidGet (string templateId)
        {
             ApiResponse<Template> response = EvaluationsTemplatesTemplateidGetWithHttpInfo(templateId);
             return response.Data;
        }

        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > EvaluationsTemplatesTemplateidGetWithHttpInfo (string templateId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsTemplatesTemplateidGet");
            
    
            var path_ = "/api/v1/evaluations/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> EvaluationsTemplatesTemplateidGetAsync (string templateId)
        {
             ApiResponse<Template> response = await EvaluationsTemplatesTemplateidGetAsyncWithHttpInfo(templateId);
             return response.Data;

        }

        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsTemplatesTemplateidGetAsyncWithHttpInfo (string templateId)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsTemplatesTemplateidGet");
            
    
            var path_ = "/api/v1/evaluations/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template EvaluationsTemplatesTemplateidPut (string templateId, Template body = null)
        {
             ApiResponse<Template> response = EvaluationsTemplatesTemplateidPutWithHttpInfo(templateId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > EvaluationsTemplatesTemplateidPutWithHttpInfo (string templateId, Template body = null)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsTemplatesTemplateidPut");
            
    
            var path_ = "/api/v1/evaluations/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> EvaluationsTemplatesTemplateidPutAsync (string templateId, Template body = null)
        {
             ApiResponse<Template> response = await EvaluationsTemplatesTemplateidPutAsyncWithHttpInfo(templateId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> EvaluationsTemplatesTemplateidPutAsyncWithHttpInfo (string templateId, Template body = null)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsTemplatesTemplateidPut");
            
    
            var path_ = "/api/v1/evaluations/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>string</returns>
        public string EvaluationsTemplatesTemplateidDelete (string templateId)
        {
             ApiResponse<string> response = EvaluationsTemplatesTemplateidDeleteWithHttpInfo(templateId);
             return response.Data;
        }

        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > EvaluationsTemplatesTemplateidDeleteWithHttpInfo (string templateId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsTemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/evaluations/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> EvaluationsTemplatesTemplateidDeleteAsync (string templateId)
        {
             ApiResponse<string> response = await EvaluationsTemplatesTemplateidDeleteAsyncWithHttpInfo(templateId);
             return response.Data;

        }

        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> EvaluationsTemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling EvaluationsTemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/evaluations/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EvaluationsTemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
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
        /// Get favorite templates 
        /// </summary>
        /// <returns>List&lt;Template&gt;</returns>
        public List<Template> ScripterFavoritetemplatesGet ()
        {
             ApiResponse<List<Template>> response = ScripterFavoritetemplatesGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get favorite templates 
        /// </summary>
        /// <returns>ApiResponse of List&lt;Template&gt;</returns>
        public ApiResponse< List<Template> > ScripterFavoritetemplatesGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/scripter/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Template>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Template>) Configuration.ApiClient.Deserialize(response, typeof(List<Template>)));
            
        }
    
        /// <summary>
        /// Get favorite templates 
        /// </summary>
        /// <returns>Task of List&lt;Template&gt;</returns>
        public async System.Threading.Tasks.Task<List<Template>> ScripterFavoritetemplatesGetAsync ()
        {
             ApiResponse<List<Template>> response = await ScripterFavoritetemplatesGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get favorite templates 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;Template&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Template>>> ScripterFavoritetemplatesGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/scripter/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Template>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Template>) Configuration.ApiClient.Deserialize(response, typeof(List<Template>)));
            
        }
        
        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template ScripterFavoritetemplatesPost (FavoriteTemplateRequestData body = null)
        {
             ApiResponse<Template> response = ScripterFavoritetemplatesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > ScripterFavoritetemplatesPostWithHttpInfo (FavoriteTemplateRequestData body = null)
        {
            
    
            var path_ = "/api/v1/scripter/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> ScripterFavoritetemplatesPostAsync (FavoriteTemplateRequestData body = null)
        {
             ApiResponse<Template> response = await ScripterFavoritetemplatesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Set a favorite template 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> ScripterFavoritetemplatesPostAsyncWithHttpInfo (FavoriteTemplateRequestData body = null)
        {
            
    
            var path_ = "/api/v1/scripter/favoritetemplates";
    
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
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param> 
        /// <returns>string</returns>
        public string ScripterFavoritetemplatesTemplateidDelete (string templateId)
        {
             ApiResponse<string> response = ScripterFavoritetemplatesTemplateidDeleteWithHttpInfo(templateId);
             return response.Data;
        }

        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ScripterFavoritetemplatesTemplateidDeleteWithHttpInfo (string templateId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterFavoritetemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/scripter/favoritetemplates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ScripterFavoritetemplatesTemplateidDeleteAsync (string templateId)
        {
             ApiResponse<string> response = await ScripterFavoritetemplatesTemplateidDeleteAsyncWithHttpInfo(templateId);
             return response.Data;

        }

        /// <summary>
        /// Unset favority template 
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ScripterFavoritetemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterFavoritetemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/scripter/favoritetemplates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterFavoritetemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="tags">Tags</param> 
        /// <returns>TemplateEntityListing</returns>
        public TemplateEntityListing ScripterTemplatesGet (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
             ApiResponse<TemplateEntityListing> response = ScripterTemplatesGetWithHttpInfo(pageSize, pageNumber, expand, tags);
             return response.Data;
        }

        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="tags">Tags</param> 
        /// <returns>ApiResponse of TemplateEntityListing</returns>
        public ApiResponse< TemplateEntityListing > ScripterTemplatesGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
            
    
            var path_ = "/api/v1/scripter/templates";
    
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
            if (tags != null) queryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TemplateEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of TemplateEntityListing</returns>
        public async System.Threading.Tasks.Task<TemplateEntityListing> ScripterTemplatesGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
             ApiResponse<TemplateEntityListing> response = await ScripterTemplatesGetAsyncWithHttpInfo(pageSize, pageNumber, expand, tags);
             return response.Data;

        }

        /// <summary>
        /// Get the list of templates 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="tags">Tags</param>
        /// <returns>Task of ApiResponse (TemplateEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateEntityListing>> ScripterTemplatesGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string tags = null)
        {
            
    
            var path_ = "/api/v1/scripter/templates";
    
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
            if (tags != null) queryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateEntityListing) Configuration.ApiClient.Deserialize(response, typeof(TemplateEntityListing)));
            
        }
        
        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template ScripterTemplatesPost (Template body = null)
        {
             ApiResponse<Template> response = ScripterTemplatesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > ScripterTemplatesPostWithHttpInfo (Template body = null)
        {
            
    
            var path_ = "/api/v1/scripter/templates";
    
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> ScripterTemplatesPostAsync (Template body = null)
        {
             ApiResponse<Template> response = await ScripterTemplatesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a template. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> ScripterTemplatesPostAsyncWithHttpInfo (Template body = null)
        {
            
    
            var path_ = "/api/v1/scripter/templates";
    
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>Template</returns>
        public Template ScripterTemplatesTemplateidGet (string templateId)
        {
             ApiResponse<Template> response = ScripterTemplatesTemplateidGetWithHttpInfo(templateId);
             return response.Data;
        }

        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > ScripterTemplatesTemplateidGetWithHttpInfo (string templateId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterTemplatesTemplateidGet");
            
    
            var path_ = "/api/v1/scripter/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> ScripterTemplatesTemplateidGetAsync (string templateId)
        {
             ApiResponse<Template> response = await ScripterTemplatesTemplateidGetAsyncWithHttpInfo(templateId);
             return response.Data;

        }

        /// <summary>
        /// Get a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> ScripterTemplatesTemplateidGetAsyncWithHttpInfo (string templateId)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterTemplatesTemplateidGet");
            
    
            var path_ = "/api/v1/scripter/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template ScripterTemplatesTemplateidPut (string templateId, Template body = null)
        {
             ApiResponse<Template> response = ScripterTemplatesTemplateidPutWithHttpInfo(templateId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > ScripterTemplatesTemplateidPutWithHttpInfo (string templateId, Template body = null)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterTemplatesTemplateidPut");
            
    
            var path_ = "/api/v1/scripter/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> ScripterTemplatesTemplateidPutAsync (string templateId, Template body = null)
        {
             ApiResponse<Template> response = await ScripterTemplatesTemplateidPutAsyncWithHttpInfo(templateId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> ScripterTemplatesTemplateidPutAsyncWithHttpInfo (string templateId, Template body = null)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterTemplatesTemplateidPut");
            
    
            var path_ = "/api/v1/scripter/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>string</returns>
        public string ScripterTemplatesTemplateidDelete (string templateId)
        {
             ApiResponse<string> response = ScripterTemplatesTemplateidDeleteWithHttpInfo(templateId);
             return response.Data;
        }

        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ScripterTemplatesTemplateidDeleteWithHttpInfo (string templateId)
        {
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterTemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/scripter/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ScripterTemplatesTemplateidDeleteAsync (string templateId)
        {
             ApiResponse<string> response = await ScripterTemplatesTemplateidDeleteAsyncWithHttpInfo(templateId);
             return response.Data;

        }

        /// <summary>
        /// Delete a composer template 
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ScripterTemplatesTemplateidDeleteAsyncWithHttpInfo (string templateId)
        {
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ScripterTemplatesTemplateidDelete");
            
    
            var path_ = "/api/v1/scripter/templates/{templateId}";
    
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
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScripterTemplatesTemplateidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
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
        public Script ScriptsPost (Body4 body = null)
        {
             ApiResponse<Script> response = ScriptsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsPostWithHttpInfo (Body4 body = null)
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
        public async System.Threading.Tasks.Task<Script> ScriptsPostAsync (Body4 body = null)
        {
             ApiResponse<Script> response = await ScriptsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPostAsyncWithHttpInfo (Body4 body = null)
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
        
        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="name">Name</param> 
        /// <param name="feature">Feature</param> 
        /// <returns>ScriptEntityListing</returns>
        public ScriptEntityListing ScriptsPublishedGet (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> response = ScriptsPublishedGetWithHttpInfo(pageSize, pageNumber, expand, name, feature);
             return response.Data;
        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="expand">Expand</param> 
        /// <param name="name">Name</param> 
        /// <param name="feature">Feature</param> 
        /// <returns>ApiResponse of ScriptEntityListing</returns>
        public ApiResponse< ScriptEntityListing > ScriptsPublishedGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
            
    
            var path_ = "/api/v1/scripts/published";
    
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScriptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScriptEntityListing)));
            
        }
    
        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>Task of ScriptEntityListing</returns>
        public async System.Threading.Tasks.Task<ScriptEntityListing> ScriptsPublishedGetAsync (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
             ApiResponse<ScriptEntityListing> response = await ScriptsPublishedGetAsyncWithHttpInfo(pageSize, pageNumber, expand, name, feature);
             return response.Data;

        }

        /// <summary>
        /// Get the published scripts. 
        /// </summary>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="expand">Expand</param>
        /// <param name="name">Name</param>
        /// <param name="feature">Feature</param>
        /// <returns>Task of ApiResponse (ScriptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScriptEntityListing>> ScriptsPublishedGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string expand = null, string name = null, string feature = null)
        {
            
    
            var path_ = "/api/v1/scripts/published";
    
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScriptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScriptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScriptEntityListing)));
            
        }
        
        /// <summary>
        /// Publish a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Script</returns>
        public Script ScriptsPublishedPost (PublishScriptRequestData body = null)
        {
             ApiResponse<Script> response = ScriptsPublishedPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Publish a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsPublishedPostWithHttpInfo (PublishScriptRequestData body = null)
        {
            
    
            var path_ = "/api/v1/scripts/published";
    
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
    
        /// <summary>
        /// Publish a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsPublishedPostAsync (PublishScriptRequestData body = null)
        {
             ApiResponse<Script> response = await ScriptsPublishedPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Publish a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPublishedPostAsyncWithHttpInfo (PublishScriptRequestData body = null)
        {
            
    
            var path_ = "/api/v1/scripts/published";
    
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
        
        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>Script</returns>
        public Script ScriptsPublishedScriptidGet (string scriptId)
        {
             ApiResponse<Script> response = ScriptsPublishedScriptidGetWithHttpInfo(scriptId);
             return response.Data;
        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsPublishedScriptidGetWithHttpInfo (string scriptId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
    
        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsPublishedScriptidGetAsync (string scriptId)
        {
             ApiResponse<Script> response = await ScriptsPublishedScriptidGetAsyncWithHttpInfo(scriptId);
             return response.Data;

        }

        /// <summary>
        /// Get the published script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsPublishedScriptidGetAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
        
        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>List&lt;Page&gt;</returns>
        public List<Page> ScriptsPublishedScriptidPagesGet (string scriptId)
        {
             ApiResponse<List<Page>> response = ScriptsPublishedScriptidPagesGetWithHttpInfo(scriptId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        public ApiResponse< List<Page> > ScriptsPublishedScriptidPagesGetWithHttpInfo (string scriptId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidPagesGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}/pages";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Page>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(response, typeof(List<Page>)));
            
        }
    
        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        public async System.Threading.Tasks.Task<List<Page>> ScriptsPublishedScriptidPagesGetAsync (string scriptId)
        {
             ApiResponse<List<Page>> response = await ScriptsPublishedScriptidPagesGetAsyncWithHttpInfo(scriptId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of published pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Page>>> ScriptsPublishedScriptidPagesGetAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidPagesGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}/pages";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Page>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(response, typeof(List<Page>)));
            
        }
        
        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <returns>Page</returns>
        public Page ScriptsPublishedScriptidPagesPageidGet (string scriptId, string pageId)
        {
             ApiResponse<Page> response = ScriptsPublishedScriptidPagesPageidGetWithHttpInfo(scriptId, pageId);
             return response.Data;
        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > ScriptsPublishedScriptidPagesPageidGetWithHttpInfo (string scriptId, string pageId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidPagesPageidGet");
            
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsPublishedScriptidPagesPageidGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesPageidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesPageidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
    
        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> ScriptsPublishedScriptidPagesPageidGetAsync (string scriptId, string pageId)
        {
             ApiResponse<Page> response = await ScriptsPublishedScriptidPagesPageidGetAsyncWithHttpInfo(scriptId, pageId);
             return response.Data;

        }

        /// <summary>
        /// Get the published page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsPublishedScriptidPagesPageidGetAsyncWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidPagesPageidGet");
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsPublishedScriptidPagesPageidGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesPageidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidPagesPageidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
        
        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 ScriptsPublishedScriptidVariablesGet (string scriptId)
        {
             ApiResponse<InlineResponse200> response = ScriptsPublishedScriptidVariablesGetWithHttpInfo(scriptId);
             return response.Data;
        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > ScriptsPublishedScriptidVariablesGetWithHttpInfo (string scriptId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidVariablesGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}/variables";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidVariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> ScriptsPublishedScriptidVariablesGetAsync (string scriptId)
        {
             ApiResponse<InlineResponse200> response = await ScriptsPublishedScriptidVariablesGetAsyncWithHttpInfo(scriptId);
             return response.Data;

        }

        /// <summary>
        /// Get the published variables 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> ScriptsPublishedScriptidVariablesGetAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsPublishedScriptidVariablesGet");
            
    
            var path_ = "/api/v1/scripts/published/{scriptId}/variables";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidVariablesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsPublishedScriptidVariablesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
        /// <summary>
        /// Create a template from a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Template</returns>
        public Template ScriptsTemplatesPost (CreateTemplateFromScriptRequestData body = null)
        {
             ApiResponse<Template> response = ScriptsTemplatesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a template from a script. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Template</returns>
        public ApiResponse< Template > ScriptsTemplatesPostWithHttpInfo (CreateTemplateFromScriptRequestData body = null)
        {
            
    
            var path_ = "/api/v1/scripts/templates";
    
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
                throw new ApiException (statusCode, "Error calling ScriptsTemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
    
        /// <summary>
        /// Create a template from a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Template</returns>
        public async System.Threading.Tasks.Task<Template> ScriptsTemplatesPostAsync (CreateTemplateFromScriptRequestData body = null)
        {
             ApiResponse<Template> response = await ScriptsTemplatesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a template from a script. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Template)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Template>> ScriptsTemplatesPostAsyncWithHttpInfo (CreateTemplateFromScriptRequestData body = null)
        {
            
    
            var path_ = "/api/v1/scripts/templates";
    
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
                throw new ApiException (statusCode, "Error calling ScriptsTemplatesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsTemplatesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Template>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Template) Configuration.ApiClient.Deserialize(response, typeof(Template)));
            
        }
        
        /// <summary>
        /// Get a script 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>Script</returns>
        public Script ScriptsScriptidGet (string scriptId)
        {
             ApiResponse<Script> response = ScriptsScriptidGetWithHttpInfo(scriptId);
             return response.Data;
        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsScriptidGetWithHttpInfo (string scriptId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidGet");
            
    
            var path_ = "/api/v1/scripts/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
    
        /// <summary>
        /// Get a script 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsScriptidGetAsync (string scriptId)
        {
             ApiResponse<Script> response = await ScriptsScriptidGetAsyncWithHttpInfo(scriptId);
             return response.Data;

        }

        /// <summary>
        /// Get a script 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsScriptidGetAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidGet");
            
    
            var path_ = "/api/v1/scripts/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
        
        /// <summary>
        /// Update a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="body"></param> 
        /// <returns>Script</returns>
        public Script ScriptsScriptidPut (string scriptId, Script body = null)
        {
             ApiResponse<Script> response = ScriptsScriptidPutWithHttpInfo(scriptId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Script</returns>
        public ApiResponse< Script > ScriptsScriptidPutWithHttpInfo (string scriptId, Script body = null)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPut");
            
    
            var path_ = "/api/v1/scripts/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
    
        /// <summary>
        /// Update a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Script</returns>
        public async System.Threading.Tasks.Task<Script> ScriptsScriptidPutAsync (string scriptId, Script body = null)
        {
             ApiResponse<Script> response = await ScriptsScriptidPutAsyncWithHttpInfo(scriptId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Script)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Script>> ScriptsScriptidPutAsyncWithHttpInfo (string scriptId, Script body = null)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPut");
            
    
            var path_ = "/api/v1/scripts/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Script>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Script) Configuration.ApiClient.Deserialize(response, typeof(Script)));
            
        }
        
        /// <summary>
        /// Delete a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>string</returns>
        public string ScriptsScriptidDelete (string scriptId)
        {
             ApiResponse<string> response = ScriptsScriptidDeleteWithHttpInfo(scriptId);
             return response.Data;
        }

        /// <summary>
        /// Delete a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ScriptsScriptidDeleteWithHttpInfo (string scriptId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidDelete");
            
    
            var path_ = "/api/v1/scripts/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ScriptsScriptidDeleteAsync (string scriptId)
        {
             ApiResponse<string> response = await ScriptsScriptidDeleteAsyncWithHttpInfo(scriptId);
             return response.Data;

        }

        /// <summary>
        /// Delete a script. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ScriptsScriptidDeleteAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidDelete");
            
    
            var path_ = "/api/v1/scripts/{scriptId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>List&lt;Page&gt;</returns>
        public List<Page> ScriptsScriptidPagesGet (string scriptId)
        {
             ApiResponse<List<Page>> response = ScriptsScriptidPagesGetWithHttpInfo(scriptId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <returns>ApiResponse of List&lt;Page&gt;</returns>
        public ApiResponse< List<Page> > ScriptsScriptidPagesGetWithHttpInfo (string scriptId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesGet");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Page>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(response, typeof(List<Page>)));
            
        }
    
        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of List&lt;Page&gt;</returns>
        public async System.Threading.Tasks.Task<List<Page>> ScriptsScriptidPagesGetAsync (string scriptId)
        {
             ApiResponse<List<Page>> response = await ScriptsScriptidPagesGetAsyncWithHttpInfo(scriptId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of pages 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <returns>Task of ApiResponse (List&lt;Page&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Page>>> ScriptsScriptidPagesGetAsyncWithHttpInfo (string scriptId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesGet");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Page>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Page>) Configuration.ApiClient.Deserialize(response, typeof(List<Page>)));
            
        }
        
        /// <summary>
        /// Create a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="body"></param> 
        /// <returns>Page</returns>
        public Page ScriptsScriptidPagesPost (string scriptId, Page body = null)
        {
             ApiResponse<Page> response = ScriptsScriptidPagesPostWithHttpInfo(scriptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > ScriptsScriptidPagesPostWithHttpInfo (string scriptId, Page body = null)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPost");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
    
        /// <summary>
        /// Create a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> ScriptsScriptidPagesPostAsync (string scriptId, Page body = null)
        {
             ApiResponse<Page> response = await ScriptsScriptidPagesPostAsyncWithHttpInfo(scriptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsScriptidPagesPostAsyncWithHttpInfo (string scriptId, Page body = null)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPost");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
        
        /// <summary>
        /// Get a page 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <returns>Page</returns>
        public Page ScriptsScriptidPagesPageidGet (string scriptId, string pageId)
        {
             ApiResponse<Page> response = ScriptsScriptidPagesPageidGetWithHttpInfo(scriptId, pageId);
             return response.Data;
        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > ScriptsScriptidPagesPageidGetWithHttpInfo (string scriptId, string pageId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPageidGet");
            
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsScriptidPagesPageidGet");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
    
        /// <summary>
        /// Get a page 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> ScriptsScriptidPagesPageidGetAsync (string scriptId, string pageId)
        {
             ApiResponse<Page> response = await ScriptsScriptidPagesPageidGetAsyncWithHttpInfo(scriptId, pageId);
             return response.Data;

        }

        /// <summary>
        /// Get a page 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsScriptidPagesPageidGetAsyncWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPageidGet");
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsScriptidPagesPageidGet");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
        
        /// <summary>
        /// Update a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <param name="body"></param> 
        /// <returns>Page</returns>
        public Page ScriptsScriptidPagesPageidPut (string scriptId, string pageId, Page body = null)
        {
             ApiResponse<Page> response = ScriptsScriptidPagesPageidPutWithHttpInfo(scriptId, pageId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Page</returns>
        public ApiResponse< Page > ScriptsScriptidPagesPageidPutWithHttpInfo (string scriptId, string pageId, Page body = null)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPageidPut");
            
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsScriptidPagesPageidPut");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
    
        /// <summary>
        /// Update a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Page</returns>
        public async System.Threading.Tasks.Task<Page> ScriptsScriptidPagesPageidPutAsync (string scriptId, string pageId, Page body = null)
        {
             ApiResponse<Page> response = await ScriptsScriptidPagesPageidPutAsyncWithHttpInfo(scriptId, pageId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Page)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Page>> ScriptsScriptidPagesPageidPutAsyncWithHttpInfo (string scriptId, string pageId, Page body = null)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPageidPut");
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsScriptidPagesPageidPut");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Page>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Page) Configuration.ApiClient.Deserialize(response, typeof(Page)));
            
        }
        
        /// <summary>
        /// Delete a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <returns>string</returns>
        public string ScriptsScriptidPagesPageidDelete (string scriptId, string pageId)
        {
             ApiResponse<string> response = ScriptsScriptidPagesPageidDeleteWithHttpInfo(scriptId, pageId);
             return response.Data;
        }

        /// <summary>
        /// Delete a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param> 
        /// <param name="pageId">Page ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ScriptsScriptidPagesPageidDeleteWithHttpInfo (string scriptId, string pageId)
        {
            
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPageidDelete");
            
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsScriptidPagesPageidDelete");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ScriptsScriptidPagesPageidDeleteAsync (string scriptId, string pageId)
        {
             ApiResponse<string> response = await ScriptsScriptidPagesPageidDeleteAsyncWithHttpInfo(scriptId, pageId);
             return response.Data;

        }

        /// <summary>
        /// Delete a page. 
        /// </summary>
        /// <param name="scriptId">Script ID</param>
        /// <param name="pageId">Page ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ScriptsScriptidPagesPageidDeleteAsyncWithHttpInfo (string scriptId, string pageId)
        {
            // verify the required parameter 'scriptId' is set
            if (scriptId == null) throw new ApiException(400, "Missing required parameter 'scriptId' when calling ScriptsScriptidPagesPageidDelete");
            // verify the required parameter 'pageId' is set
            if (pageId == null) throw new ApiException(400, "Missing required parameter 'pageId' when calling ScriptsScriptidPagesPageidDelete");
            
    
            var path_ = "/api/v1/scripts/{scriptId}/pages/{pageId}";
    
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
            if (scriptId != null) pathParams.Add("scriptId", Configuration.ApiClient.ParameterToString(scriptId)); // path parameter
            if (pageId != null) pathParams.Add("pageId", Configuration.ApiClient.ParameterToString(pageId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ScriptsScriptidPagesPageidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
