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
    public interface IArchitectApi
    {
        
        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>AuditSearchResult</returns>
        AuditSearchResult PostAudits (CommonAuditRequest body = null);
  
        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        ApiResponse<AuditSearchResult> PostAuditsWithHttpInfo (CommonAuditRequest body = null);

        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of AuditSearchResult</returns>
        System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (CommonAuditRequest body = null);

        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (CommonAuditRequest body = null);
        
        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>IVREntityListing</returns>
        IVREntityListing GetIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of IVREntityListing</returns>
        ApiResponse<IVREntityListing> GetIvrsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of IVREntityListing</returns>
        System.Threading.Tasks.Task<IVREntityListing> GetIvrsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (IVREntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> GetIvrsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>IVR</returns>
        IVR PostIvrs (IVR body = null);
  
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PostIvrsWithHttpInfo (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PostIvrsAsync (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsAsyncWithHttpInfo (IVR body = null);
        
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>IVR</returns>
        IVR PostIvrsActionsPublish (string id);
  
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PostIvrsActionsPublishWithHttpInfo (string id);

        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PostIvrsActionsPublishAsync (string id);

        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsActionsPublishAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>IVR</returns>
        IVR GetIvrsIvrId (string ivrId);
  
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> GetIvrsIvrIdWithHttpInfo (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> GetIvrsIvrIdAsync (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> GetIvrsIvrIdAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>IVR</returns>
        IVR PutIvrsIvrId (string ivrId, IVR body = null);
  
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PutIvrsIvrIdWithHttpInfo (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PutIvrsIvrIdAsync (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PutIvrsIvrIdAsyncWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>string</returns>
        string DeleteIvrsIvrId (string ivrId);
  
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteIvrsIvrIdWithHttpInfo (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteIvrsIvrIdAsync (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteIvrsIvrIdAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>PromptEntityListing</returns>
        PromptEntityListing GetPrompts (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
  
        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>ApiResponse of PromptEntityListing</returns>
        ApiResponse<PromptEntityListing> GetPromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of PromptEntityListing</returns>
        System.Threading.Tasks.Task<PromptEntityListing> GetPromptsAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of ApiResponse (PromptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> GetPromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Prompt</returns>
        Prompt PostPrompts (Prompt body = null);
  
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PostPromptsWithHttpInfo (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> PostPromptsAsync (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PostPromptsAsyncWithHttpInfo (Prompt body = null);
        
        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </remarks>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns></returns>
        void DeletePrompts (List<string> id, bool? ignoreDependencies = null);
  
        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </remarks>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptsWithHttpInfo (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </remarks>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePromptsAsync (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </remarks>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Prompt</returns>
        Prompt GetPromptsPromptId (string promptId);
  
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> GetPromptsPromptIdWithHttpInfo (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> GetPromptsPromptIdAsync (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> GetPromptsPromptIdAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Prompt</returns>
        Prompt PutPromptsPromptId (string promptId, Prompt body = null);
  
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PutPromptsPromptIdWithHttpInfo (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> PutPromptsPromptIdAsync (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PutPromptsPromptIdAsyncWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns></returns>
        void DeletePromptsPromptId (string promptId);
  
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptsPromptIdWithHttpInfo (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePromptsPromptIdAsync (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query paramaters can be used for filtering.
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>PromptAssetEntityListing</returns>
        PromptAssetEntityListing GetPromptsPromptIdResources (string promptId, int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query paramaters can be used for filtering.
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        ApiResponse<PromptAssetEntityListing> GetPromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query paramaters can be used for filtering.
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of PromptAssetEntityListing</returns>
        System.Threading.Tasks.Task<PromptAssetEntityListing> GetPromptsPromptIdResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query paramaters can be used for filtering.
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>PromptAsset</returns>
        PromptAsset PostPromptsPromptIdResources (string promptId, PromptAsset body = null);
  
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PostPromptsPromptIdResourcesWithHttpInfo (string promptId, PromptAsset body = null);

        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> PostPromptsPromptIdResourcesAsync (string promptId, PromptAsset body = null);

        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, PromptAsset body = null);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>PromptAsset</returns>
        PromptAsset GetPromptsPromptIdResourcesLanguage (string promptId, string language);
  
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> GetPromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> GetPromptsPromptIdResourcesLanguageAsync (string promptId, string language);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>PromptAsset</returns>
        PromptAsset PutPromptsPromptIdResourcesLanguage (string promptId, string language, PromptAsset body = null);
  
        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PutPromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language, PromptAsset body = null);

        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> PutPromptsPromptIdResourcesLanguageAsync (string promptId, string language, PromptAsset body = null);

        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns></returns>
        void DeletePromptsPromptIdResourcesLanguage (string promptId, string language);
  
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePromptsPromptIdResourcesLanguageAsync (string promptId, string language);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ScheduleGroupEntityListing</returns>
        ScheduleGroupEntityListing GetSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ScheduleGroupEntityListing</returns>
        ApiResponse<ScheduleGroupEntityListing> GetSchedulegroupsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ScheduleGroupEntityListing</returns>
        System.Threading.Tasks.Task<ScheduleGroupEntityListing> GetSchedulegroupsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleGroupEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> GetSchedulegroupsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup PostSchedulegroups (ScheduleGroup body = null);
  
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PostSchedulegroupsWithHttpInfo (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> PostSchedulegroupsAsync (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PostSchedulegroupsAsyncWithHttpInfo (ScheduleGroup body = null);
        
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup GetSchedulegroupsSchedulegroupId (string scheduleGroupId);
  
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> GetSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> GetSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup PutSchedulegroupsSchedulegroupId (string scheduleGroupId, ScheduleGroup body = null);
  
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PutSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> PutSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>string</returns>
        string DeleteSchedulegroupsSchedulegroupId (string scheduleGroupId);
  
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ScheduleEntityListing</returns>
        ScheduleEntityListing GetSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ScheduleEntityListing</returns>
        ApiResponse<ScheduleEntityListing> GetSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ScheduleEntityListing</returns>
        System.Threading.Tasks.Task<ScheduleEntityListing> GetSchedulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> GetSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Schedule</returns>
        Schedule PostSchedules (Schedule body = null);
  
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PostSchedulesWithHttpInfo (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> PostSchedulesAsync (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PostSchedulesAsyncWithHttpInfo (Schedule body = null);
        
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Schedule</returns>
        Schedule GetSchedulesScheduleId (string scheduleId);
  
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> GetSchedulesScheduleIdWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> GetSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> GetSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Schedule</returns>
        Schedule PutSchedulesScheduleId (string scheduleId, Schedule body = null);
  
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PutSchedulesScheduleIdWithHttpInfo (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> PutSchedulesScheduleIdAsync (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PutSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, Schedule body = null);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesScheduleId (string scheduleId);
  
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesScheduleIdWithHttpInfo (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Get System Prompts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>SystemPromptEntityListing</returns>
        SystemPromptEntityListing GetSystemprompts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);
  
        /// <summary>
        /// Get System Prompts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>ApiResponse of SystemPromptEntityListing</returns>
        ApiResponse<SystemPromptEntityListing> GetSystempromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get System Prompts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of SystemPromptEntityListing</returns>
        System.Threading.Tasks.Task<SystemPromptEntityListing> GetSystempromptsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);

        /// <summary>
        /// Get System Prompts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of ApiResponse (SystemPromptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptEntityListing>> GetSystempromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>SystemPrompt</returns>
        SystemPrompt GetSystempromptsPromptId (string promptId);
  
        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>ApiResponse of SystemPrompt</returns>
        ApiResponse<SystemPrompt> GetSystempromptsPromptIdWithHttpInfo (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        System.Threading.Tasks.Task<SystemPrompt> GetSystempromptsPromptIdAsync (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetSystempromptsPromptIdAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get IVR System Prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>SystemPromptAssetEntityListing</returns>
        SystemPromptAssetEntityListing GetSystempromptsPromptIdResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
        /// <summary>
        /// Get IVR System Prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of SystemPromptAssetEntityListing</returns>
        ApiResponse<SystemPromptAssetEntityListing> GetSystempromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get IVR System Prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of SystemPromptAssetEntityListing</returns>
        System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetSystempromptsPromptIdResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

        /// <summary>
        /// Get IVR System Prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (SystemPromptAssetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset PostSystempromptsPromptIdResources (string promptId, SystemPromptAsset body = null);
  
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> PostSystempromptsPromptIdResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> PostSystempromptsPromptIdResourcesAsync (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset GetSystempromptsPromptIdResourcesLanguage (string promptId, string language);
  
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> GetSystempromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> GetSystempromptsPromptIdResourcesLanguageAsync (string promptId, string language);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>string</returns>
        string DeleteSystempromptsPromptIdResourcesLanguage (string promptId, string language);
  
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSystempromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSystempromptsPromptIdResourcesLanguageAsync (string promptId, string language);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="publishVersionId">Publish version ID</param>
        /// <param name="editableBy">Editable by</param>
        /// <param name="lockedBy">Locked by</param>
        /// <param name="deleted">Include deleted</param>
        /// <returns>FlowEntityListing</returns>
        FlowEntityListing Get (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);
  
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="publishVersionId">Publish version ID</param>
        /// <param name="editableBy">Editable by</param>
        /// <param name="lockedBy">Locked by</param>
        /// <param name="deleted">Include deleted</param>
        /// <returns>ApiResponse of FlowEntityListing</returns>
        ApiResponse<FlowEntityListing> GetWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="publishVersionId">Publish version ID</param>
        /// <param name="editableBy">Editable by</param>
        /// <param name="lockedBy">Locked by</param>
        /// <param name="deleted">Include deleted</param>
        /// <returns>Task of FlowEntityListing</returns>
        System.Threading.Tasks.Task<FlowEntityListing> GetAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="publishVersionId">Publish version ID</param>
        /// <param name="editableBy">Editable by</param>
        /// <param name="lockedBy">Locked by</param>
        /// <param name="deleted">Include deleted</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> GetAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow Post (Flow body = null);
  
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostWithHttpInfo (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostAsync (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostAsyncWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns></returns>
        void Delete (List<string> id, bool? ignoreDependencies = null);
  
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsCheckin (string flow = null);
  
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsCheckinWithHttpInfo (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsCheckinAsync (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckinAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsCheckout (string flow = null);
  
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsCheckoutWithHttpInfo (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsCheckoutAsync (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckoutAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsDeactivate (string flow = null);
  
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsDeactivateWithHttpInfo (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsDeactivateAsync (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsDeactivateAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns></returns>
        void PostActionsDebug (string version, string flow = null);
  
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostActionsDebugWithHttpInfo (string version, string flow = null);

        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostActionsDebugAsync (string version, string flow = null);

        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostActionsDebugAsyncWithHttpInfo (string version, string flow = null);
        
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsRevert (string flow = null);
  
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsRevertWithHttpInfo (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsRevertAsync (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsRevertAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Flow</returns>
        Flow GetFlowId (string flowId, string deleted = null);
  
        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> GetFlowIdWithHttpInfo (string flowId, string deleted = null);

        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> GetFlowIdAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowIdAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow PutFlowId (string flowId, Flow body = null);
  
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PutFlowIdWithHttpInfo (string flowId, Flow body = null);

        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PutFlowIdAsync (string flowId, Flow body = null);

        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowIdAsyncWithHttpInfo (string flowId, Flow body = null);
        
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns></returns>
        void DeleteFlowId (string flowId);
  
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFlowIdWithHttpInfo (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFlowIdAsync (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowIdAsyncWithHttpInfo (string flowId);
        
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetFlowIdLatestconfiguration (string flowId, string deleted = null);
  
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetFlowIdLatestconfigurationWithHttpInfo (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetFlowIdLatestconfigurationAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowIdLatestconfigurationAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>PublishedResult</returns>
        PublishedResult GetFlowIdPublishedresultsId (string flowId, string id);
  
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>ApiResponse of PublishedResult</returns>
        ApiResponse<PublishedResult> GetFlowIdPublishedresultsIdWithHttpInfo (string flowId, string id);

        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of PublishedResult</returns>
        System.Threading.Tasks.Task<PublishedResult> GetFlowIdPublishedresultsIdAsync (string flowId, string id);

        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedResult>> GetFlowIdPublishedresultsIdAsyncWithHttpInfo (string flowId, string id);
        
        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>FlowVersionEntityListing</returns>
        FlowVersionEntityListing GetFlowIdVersions (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
  
        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of FlowVersionEntityListing</returns>
        ApiResponse<FlowVersionEntityListing> GetFlowIdVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);

        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of FlowVersionEntityListing</returns>
        System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowIdVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);

        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowIdVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>FlowVersion</returns>
        FlowVersion PostFlowIdVersions (string flowId, Body2 body = null);
  
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> PostFlowIdVersionsWithHttpInfo (string flowId, Body2 body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> PostFlowIdVersionsAsync (string flowId, Body2 body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowIdVersionsAsyncWithHttpInfo (string flowId, Body2 body = null);
        
        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>FlowVersion</returns>
        FlowVersion GetFlowIdVersionsVersionId (string flowId, string versionId, string deleted = null);
  
        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> GetFlowIdVersionsVersionIdWithHttpInfo (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> GetFlowIdVersionsVersionIdAsync (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> GetFlowIdVersionsVersionIdAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetFlowIdVersionsVersionIdConfiguration (string flowId, string versionId, string deleted = null);
  
        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetFlowIdVersionsVersionIdConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetFlowIdVersionsVersionIdConfigurationAsync (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowIdVersionsVersionIdConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArchitectApi : IArchitectApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArchitectApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ArchitectApi(Configuration configuration = null)
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
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <param name="body">AuditSearchRequest</param> 
        /// <returns>AuditSearchResult</returns>
        public AuditSearchResult PostAudits (CommonAuditRequest body = null)
        {
             ApiResponse<AuditSearchResult> response = PostAuditsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <param name="body">AuditSearchRequest</param> 
        /// <returns>ApiResponse of AuditSearchResult</returns>
        public ApiResponse< AuditSearchResult > PostAuditsWithHttpInfo (CommonAuditRequest body = null)
        {
            
    
            var path_ = "/api/v1/architect/audits";
    
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
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AuditSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(response, typeof(AuditSearchResult)));
            
        }
    
        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of AuditSearchResult</returns>
        public async System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (CommonAuditRequest body = null)
        {
             ApiResponse<AuditSearchResult> response = await PostAuditsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (CommonAuditRequest body = null)
        {
            
    
            var path_ = "/api/v1/architect/audits";
    
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
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostAudits: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(response, typeof(AuditSearchResult)));
            
        }
        
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>IVREntityListing</returns>
        public IVREntityListing GetIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<IVREntityListing> response = GetIvrsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of IVREntityListing</returns>
        public ApiResponse< IVREntityListing > GetIvrsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetIvrs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetIvrs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVREntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVREntityListing) Configuration.ApiClient.Deserialize(response, typeof(IVREntityListing)));
            
        }
    
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of IVREntityListing</returns>
        public async System.Threading.Tasks.Task<IVREntityListing> GetIvrsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<IVREntityListing> response = await GetIvrsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (IVREntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> GetIvrsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetIvrs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetIvrs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVREntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVREntityListing) Configuration.ApiClient.Deserialize(response, typeof(IVREntityListing)));
            
        }
        
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>IVR</returns>
        public IVR PostIvrs (IVR body = null)
        {
             ApiResponse<IVR> response = PostIvrsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PostIvrsWithHttpInfo (IVR body = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
                throw new ApiException (statusCode, "Error calling PostIvrs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostIvrs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PostIvrsAsync (IVR body = null)
        {
             ApiResponse<IVR> response = await PostIvrsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsAsyncWithHttpInfo (IVR body = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
                throw new ApiException (statusCode, "Error calling PostIvrs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostIvrs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>IVR</returns>
        public IVR PostIvrsActionsPublish (string id)
        {
             ApiResponse<IVR> response = PostIvrsActionsPublishWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PostIvrsActionsPublishWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->PostIvrsActionsPublish");
            
    
            var path_ = "/api/v1/architect/ivrs/actions/publish";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostIvrsActionsPublish: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostIvrsActionsPublish: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PostIvrsActionsPublishAsync (string id)
        {
             ApiResponse<IVR> response = await PostIvrsActionsPublishAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsActionsPublishAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostIvrsActionsPublish");
            
    
            var path_ = "/api/v1/architect/ivrs/actions/publish";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostIvrsActionsPublish: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostIvrsActionsPublish: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>IVR</returns>
        public IVR GetIvrsIvrId (string ivrId)
        {
             ApiResponse<IVR> response = GetIvrsIvrIdWithHttpInfo(ivrId);
             return response.Data;
        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > GetIvrsIvrIdWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->GetIvrsIvrId");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetIvrsIvrId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetIvrsIvrId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> GetIvrsIvrIdAsync (string ivrId)
        {
             ApiResponse<IVR> response = await GetIvrsIvrIdAsyncWithHttpInfo(ivrId);
             return response.Data;

        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> GetIvrsIvrIdAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling GetIvrsIvrId");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetIvrsIvrId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetIvrsIvrId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <param name="body"></param> 
        /// <returns>IVR</returns>
        public IVR PutIvrsIvrId (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> response = PutIvrsIvrIdWithHttpInfo(ivrId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PutIvrsIvrIdWithHttpInfo (string ivrId, IVR body = null)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->PutIvrsIvrId");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutIvrsIvrId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutIvrsIvrId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PutIvrsIvrIdAsync (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> response = await PutIvrsIvrIdAsyncWithHttpInfo(ivrId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PutIvrsIvrIdAsyncWithHttpInfo (string ivrId, IVR body = null)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling PutIvrsIvrId");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutIvrsIvrId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutIvrsIvrId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>string</returns>
        public string DeleteIvrsIvrId (string ivrId)
        {
             ApiResponse<string> response = DeleteIvrsIvrIdWithHttpInfo(ivrId);
             return response.Data;
        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteIvrsIvrIdWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->DeleteIvrsIvrId");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteIvrsIvrId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteIvrsIvrId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteIvrsIvrIdAsync (string ivrId)
        {
             ApiResponse<string> response = await DeleteIvrsIvrIdAsyncWithHttpInfo(ivrId);
             return response.Data;

        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteIvrsIvrIdAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling DeleteIvrsIvrId");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteIvrsIvrId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteIvrsIvrId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <returns>PromptEntityListing</returns>
        public PromptEntityListing GetPrompts (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> response = GetPromptsWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
             return response.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <returns>ApiResponse of PromptEntityListing</returns>
        public ApiResponse< PromptEntityListing > GetPromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetPrompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPrompts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PromptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PromptEntityListing)));
            
        }
    
        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of PromptEntityListing</returns>
        public async System.Threading.Tasks.Task<PromptEntityListing> GetPromptsAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> response = await GetPromptsAsyncWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
             return response.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of ApiResponse (PromptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> GetPromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPrompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPrompts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PromptEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Prompt</returns>
        public Prompt PostPrompts (Prompt body = null)
        {
             ApiResponse<Prompt> response = PostPromptsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PostPromptsWithHttpInfo (Prompt body = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
                throw new ApiException (statusCode, "Error calling PostPrompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPrompts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
    
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> PostPromptsAsync (Prompt body = null)
        {
             ApiResponse<Prompt> response = await PostPromptsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PostPromptsAsyncWithHttpInfo (Prompt body = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
                throw new ApiException (statusCode, "Error calling PostPrompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPrompts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </summary>
        /// <param name="id">List of Prompt IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns></returns>
        public void DeletePrompts (List<string> id, bool? ignoreDependencies = null)
        {
             DeletePromptsWithHttpInfo(id, ignoreDependencies);
        }

        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </summary>
        /// <param name="id">List of Prompt IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptsWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeletePrompts");
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) queryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeletePrompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePrompts: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </summary>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePromptsAsync (List<string> id, bool? ignoreDependencies = null)
        {
             await DeletePromptsAsyncWithHttpInfo(id, ignoreDependencies);

        }

        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </summary>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePrompts");
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) queryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeletePrompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePrompts: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>Prompt</returns>
        public Prompt GetPromptsPromptId (string promptId)
        {
             ApiResponse<Prompt> response = GetPromptsPromptIdWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > GetPromptsPromptIdWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptsPromptId");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetPromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
    
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> GetPromptsPromptIdAsync (string promptId)
        {
             ApiResponse<Prompt> response = await GetPromptsPromptIdAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> GetPromptsPromptIdAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptsPromptId");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>Prompt</returns>
        public Prompt PutPromptsPromptId (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> response = PutPromptsPromptIdWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PutPromptsPromptIdWithHttpInfo (string promptId, Prompt body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutPromptsPromptId");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutPromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
    
        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> PutPromptsPromptIdAsync (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> response = await PutPromptsPromptIdAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PutPromptsPromptIdAsyncWithHttpInfo (string promptId, Prompt body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PutPromptsPromptId");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutPromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns></returns>
        public void DeletePromptsPromptId (string promptId)
        {
             DeletePromptsPromptIdWithHttpInfo(promptId);
        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptsPromptIdWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeletePromptsPromptId");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePromptsPromptIdAsync (string promptId)
        {
             await DeletePromptsPromptIdAsyncWithHttpInfo(promptId);

        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeletePromptsPromptId");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>PromptAssetEntityListing</returns>
        public PromptAssetEntityListing GetPromptsPromptIdResources (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> response = GetPromptsPromptIdResourcesWithHttpInfo(promptId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        public ApiResponse< PromptAssetEntityListing > GetPromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PromptAssetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAssetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PromptAssetEntityListing)));
            
        }
    
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of PromptAssetEntityListing</returns>
        public async System.Threading.Tasks.Task<PromptAssetEntityListing> GetPromptsPromptIdResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> response = await GetPromptsPromptIdResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptAssetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAssetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PromptAssetEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>PromptAsset</returns>
        public PromptAsset PostPromptsPromptIdResources (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = PostPromptsPromptIdResourcesWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PostPromptsPromptIdResourcesWithHttpInfo (string promptId, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostPromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostPromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
    
        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> PostPromptsPromptIdResourcesAsync (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = await PostPromptsPromptIdResourcesAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PostPromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostPromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>PromptAsset</returns>
        public PromptAsset GetPromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             ApiResponse<PromptAsset> response = GetPromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > GetPromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptsPromptIdResourcesLanguage");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->GetPromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
    
        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> GetPromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             ApiResponse<PromptAsset> response = await GetPromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling GetPromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <param name="body"></param> 
        /// <returns>PromptAsset</returns>
        public PromptAsset PutPromptsPromptIdResourcesLanguage (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = PutPromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language, body);
             return response.Data;
        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PutPromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutPromptsPromptIdResourcesLanguage");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->PutPromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
    
        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> PutPromptsPromptIdResourcesLanguageAsync (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = await PutPromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language, body);
             return response.Data;

        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PutPromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling PutPromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns></returns>
        public void DeletePromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             DeletePromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeletePromptsPromptIdResourcesLanguage");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->DeletePromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             await DeletePromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);

        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeletePromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling DeletePromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ScheduleGroupEntityListing</returns>
        public ScheduleGroupEntityListing GetSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleGroupEntityListing> response = GetSchedulegroupsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ScheduleGroupEntityListing</returns>
        public ApiResponse< ScheduleGroupEntityListing > GetSchedulegroupsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSchedulegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulegroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroupEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroupEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ScheduleGroupEntityListing</returns>
        public async System.Threading.Tasks.Task<ScheduleGroupEntityListing> GetSchedulegroupsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleGroupEntityListing> response = await GetSchedulegroupsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleGroupEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> GetSchedulegroupsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchedulegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroupEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroupEntityListing)));
            
        }
        
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup PostSchedulegroups (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = PostSchedulegroupsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PostSchedulegroupsWithHttpInfo (ScheduleGroup body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
                throw new ApiException (statusCode, "Error calling PostSchedulegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSchedulegroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
    
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> PostSchedulegroupsAsync (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = await PostSchedulegroupsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PostSchedulegroupsAsyncWithHttpInfo (ScheduleGroup body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
                throw new ApiException (statusCode, "Error calling PostSchedulegroups: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSchedulegroups: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup GetSchedulegroupsSchedulegroupId (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> response = GetSchedulegroupsSchedulegroupIdWithHttpInfo(scheduleGroupId);
             return response.Data;
        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > GetSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->GetSchedulegroupsSchedulegroupId");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
    
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> GetSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> response = await GetSchedulegroupsSchedulegroupIdAsyncWithHttpInfo(scheduleGroupId);
             return response.Data;

        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling GetSchedulegroupsSchedulegroupId");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <param name="body"></param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup PutSchedulegroupsSchedulegroupId (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = PutSchedulegroupsSchedulegroupIdWithHttpInfo(scheduleGroupId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PutSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->PutSchedulegroupsSchedulegroupId");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
    
        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> PutSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = await PutSchedulegroupsSchedulegroupIdAsyncWithHttpInfo(scheduleGroupId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling PutSchedulegroupsSchedulegroupId");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulegroupsSchedulegroupId (string scheduleGroupId)
        {
             ApiResponse<string> response = DeleteSchedulegroupsSchedulegroupIdWithHttpInfo(scheduleGroupId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->DeleteSchedulegroupsSchedulegroupId");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId)
        {
             ApiResponse<string> response = await DeleteSchedulegroupsSchedulegroupIdAsyncWithHttpInfo(scheduleGroupId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling DeleteSchedulegroupsSchedulegroupId");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ScheduleEntityListing</returns>
        public ScheduleEntityListing GetSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleEntityListing> response = GetSchedulesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ScheduleEntityListing</returns>
        public ApiResponse< ScheduleEntityListing > GetSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedules: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScheduleEntityListing)));
            
        }
    
        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ScheduleEntityListing</returns>
        public async System.Threading.Tasks.Task<ScheduleEntityListing> GetSchedulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleEntityListing> response = await GetSchedulesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> GetSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedules: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScheduleEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Schedule</returns>
        public Schedule PostSchedules (Schedule body = null)
        {
             ApiResponse<Schedule> response = PostSchedulesWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PostSchedulesWithHttpInfo (Schedule body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
                throw new ApiException (statusCode, "Error calling PostSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSchedules: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
    
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> PostSchedulesAsync (Schedule body = null)
        {
             ApiResponse<Schedule> response = await PostSchedulesAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PostSchedulesAsyncWithHttpInfo (Schedule body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
                throw new ApiException (statusCode, "Error calling PostSchedules: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSchedules: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>Schedule</returns>
        public Schedule GetSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<Schedule> response = GetSchedulesScheduleIdWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > GetSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->GetSchedulesScheduleId");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
    
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> GetSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<Schedule> response = await GetSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> GetSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetSchedulesScheduleId");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body"></param> 
        /// <returns>Schedule</returns>
        public Schedule PutSchedulesScheduleId (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> response = PutSchedulesScheduleIdWithHttpInfo(scheduleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PutSchedulesScheduleIdWithHttpInfo (string scheduleId, Schedule body = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->PutSchedulesScheduleId");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
    
        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> PutSchedulesScheduleIdAsync (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> response = await PutSchedulesScheduleIdAsyncWithHttpInfo(scheduleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PutSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, Schedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling PutSchedulesScheduleId");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<string> response = DeleteSchedulesScheduleIdWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->DeleteSchedulesScheduleId");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<string> response = await DeleteSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling DeleteSchedulesScheduleId");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteSchedulesScheduleId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulesScheduleId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <returns>SystemPromptEntityListing</returns>
        public SystemPromptEntityListing GetSystemprompts (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<SystemPromptEntityListing> response = GetSystempromptsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
             return response.Data;
        }

        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <returns>ApiResponse of SystemPromptEntityListing</returns>
        public ApiResponse< SystemPromptEntityListing > GetSystempromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/systemprompts";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSystemprompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystemprompts: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPromptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptEntityListing)));
            
        }
    
        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of SystemPromptEntityListing</returns>
        public async System.Threading.Tasks.Task<SystemPromptEntityListing> GetSystempromptsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<SystemPromptEntityListing> response = await GetSystempromptsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
             return response.Data;

        }

        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of ApiResponse (SystemPromptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptEntityListing>> GetSystempromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/systemprompts";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSystemprompts: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystemprompts: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SystemPromptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptEntityListing)));
            
        }
        
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param> 
        /// <returns>SystemPrompt</returns>
        public SystemPrompt GetSystempromptsPromptId (string promptId)
        {
             ApiResponse<SystemPrompt> response = GetSystempromptsPromptIdWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param> 
        /// <returns>ApiResponse of SystemPrompt</returns>
        public ApiResponse< SystemPrompt > GetSystempromptsPromptIdWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystempromptsPromptId");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPrompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPrompt) Configuration.ApiClient.Deserialize(response, typeof(SystemPrompt)));
            
        }
    
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        public async System.Threading.Tasks.Task<SystemPrompt> GetSystempromptsPromptIdAsync (string promptId)
        {
             ApiResponse<SystemPrompt> response = await GetSystempromptsPromptIdAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetSystempromptsPromptIdAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptsPromptId");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SystemPrompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPrompt) Configuration.ApiClient.Deserialize(response, typeof(SystemPrompt)));
            
        }
        
        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>SystemPromptAssetEntityListing</returns>
        public SystemPromptAssetEntityListing GetSystempromptsPromptIdResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> response = GetSystempromptsPromptIdResourcesWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;
        }

        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of SystemPromptAssetEntityListing</returns>
        public ApiResponse< SystemPromptAssetEntityListing > GetSystempromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystempromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPromptAssetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAssetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptAssetEntityListing)));
            
        }
    
        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of SystemPromptAssetEntityListing</returns>
        public async System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetSystempromptsPromptIdResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> response = await GetSystempromptsPromptIdResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
             return response.Data;

        }

        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (SystemPromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SystemPromptAssetEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAssetEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptAssetEntityListing)));
            
        }
        
        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset PostSystempromptsPromptIdResources (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> response = PostSystempromptsPromptIdResourcesWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > PostSystempromptsPromptIdResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostSystempromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostSystempromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSystempromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptAsset)));
            
        }
    
        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> PostSystempromptsPromptIdResourcesAsync (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> response = await PostSystempromptsPromptIdResourcesAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PostSystempromptsPromptIdResources");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostSystempromptsPromptIdResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSystempromptsPromptIdResources: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptAsset)));
            
        }
        
        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset GetSystempromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> response = GetSystempromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > GetSystempromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystempromptsPromptIdResourcesLanguage");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->GetSystempromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptAsset)));
            
        }
    
        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> GetSystempromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> response = await GetSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling GetSystempromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptAsset)));
            
        }
        
        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>string</returns>
        public string DeleteSystempromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             ApiResponse<string> response = DeleteSystempromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSystempromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteSystempromptsPromptIdResourcesLanguage");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->DeleteSystempromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSystempromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             ApiResponse<string> response = await DeleteSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeleteSystempromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling DeleteSystempromptsPromptIdResourcesLanguage");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <param name="type">Type</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="id">ID</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <param name="publishVersionId">Publish version ID</param> 
        /// <param name="editableBy">Editable by</param> 
        /// <param name="lockedBy">Locked by</param> 
        /// <param name="deleted">Include deleted</param> 
        /// <returns>FlowEntityListing</returns>
        public FlowEntityListing Get (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
        {
             ApiResponse<FlowEntityListing> response = GetWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <param name="type">Type</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="id">ID</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <param name="publishVersionId">Publish version ID</param> 
        /// <param name="editableBy">Editable by</param> 
        /// <param name="lockedBy">Locked by</param> 
        /// <param name="deleted">Include deleted</param> 
        /// <returns>ApiResponse of FlowEntityListing</returns>
        public ApiResponse< FlowEntityListing > GetWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
            
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (publishVersionId != null) queryParams.Add("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)); // query parameter
            if (editableBy != null) queryParams.Add("editableBy", Configuration.ApiClient.ParameterToString(editableBy)); // query parameter
            if (lockedBy != null) queryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowEntityListing)));
            
        }
    
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="publishVersionId">Publish version ID</param>
        /// <param name="editableBy">Editable by</param>
        /// <param name="lockedBy">Locked by</param>
        /// <param name="deleted">Include deleted</param>
        /// <returns>Task of FlowEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowEntityListing> GetAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
        {
             ApiResponse<FlowEntityListing> response = await GetAsyncWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="publishVersionId">Publish version ID</param>
        /// <param name="editableBy">Editable by</param>
        /// <param name="lockedBy">Locked by</param>
        /// <param name="deleted">Include deleted</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> GetAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
            
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (publishVersionId != null) queryParams.Add("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)); // query parameter
            if (editableBy != null) queryParams.Add("editableBy", Configuration.ApiClient.ParameterToString(editableBy)); // query parameter
            if (lockedBy != null) queryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowEntityListing)));
            
        }
        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Flow</returns>
        public Flow Post (Flow body = null)
        {
             ApiResponse<Flow> response = PostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostWithHttpInfo (Flow body = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
                throw new ApiException (statusCode, "Error calling Post: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostAsync (Flow body = null)
        {
             ApiResponse<Flow> response = await PostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostAsyncWithHttpInfo (Flow body = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
                throw new ApiException (statusCode, "Error calling Post: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Post: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <param name="id">List of Flow IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns></returns>
        public void Delete (List<string> id, bool? ignoreDependencies = null)
        {
             DeleteWithHttpInfo(id, ignoreDependencies);
        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <param name="id">List of Flow IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->Delete");
            
    
            var path_ = "/api/v1/flows";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) queryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync (List<string> id, bool? ignoreDependencies = null)
        {
             await DeleteAsyncWithHttpInfo(id, ignoreDependencies);

        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Delete");
            
    
            var path_ = "/api/v1/flows";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) queryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsCheckin (string flow = null)
        {
             ApiResponse<Flow> response = PostActionsCheckinWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsCheckinWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkin";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostActionsCheckin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsCheckin: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsCheckinAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostActionsCheckinAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckinAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkin";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostActionsCheckin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsCheckin: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsCheckout (string flow = null)
        {
             ApiResponse<Flow> response = PostActionsCheckoutWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsCheckoutWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkout";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostActionsCheckout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsCheckout: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsCheckoutAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostActionsCheckoutAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckoutAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkout";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostActionsCheckout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsCheckout: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsDeactivate (string flow = null)
        {
             ApiResponse<Flow> response = PostActionsDeactivateWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsDeactivateWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/deactivate";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostActionsDeactivate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsDeactivate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsDeactivateAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostActionsDeactivateAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsDeactivateAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/deactivate";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostActionsDeactivate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsDeactivate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param> 
        /// <param name="flow">Flow</param> 
        /// <returns></returns>
        public void PostActionsDebug (string version, string flow = null)
        {
             PostActionsDebugWithHttpInfo(version, flow);
        }

        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param> 
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostActionsDebugWithHttpInfo (string version, string flow = null)
        {
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectApi->PostActionsDebug");
            
    
            var path_ = "/api/v1/flows/actions/debug";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostActionsDebug: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsDebug: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostActionsDebugAsync (string version, string flow = null)
        {
             await PostActionsDebugAsyncWithHttpInfo(version, flow);

        }

        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostActionsDebugAsyncWithHttpInfo (string version, string flow = null)
        {
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling PostActionsDebug");
            
    
            var path_ = "/api/v1/flows/actions/debug";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostActionsDebug: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsDebug: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsRevert (string flow = null)
        {
             ApiResponse<Flow> response = PostActionsRevertWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsRevertWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/revert";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling PostActionsRevert: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsRevert: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsRevertAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostActionsRevertAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsRevertAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/revert";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling PostActionsRevert: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostActionsRevert: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>Flow</returns>
        public Flow GetFlowId (string flowId, string deleted = null)
        {
             ApiResponse<Flow> response = GetFlowIdWithHttpInfo(flowId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > GetFlowIdWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowId");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetFlowId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> GetFlowIdAsync (string flowId, string deleted = null)
        {
             ApiResponse<Flow> response = await GetFlowIdAsyncWithHttpInfo(flowId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowIdAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowId");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFlowId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>Flow</returns>
        public Flow PutFlowId (string flowId, Flow body = null)
        {
             ApiResponse<Flow> response = PutFlowIdWithHttpInfo(flowId, body);
             return response.Data;
        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PutFlowIdWithHttpInfo (string flowId, Flow body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PutFlowId");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutFlowId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutFlowId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PutFlowIdAsync (string flowId, Flow body = null)
        {
             ApiResponse<Flow> response = await PutFlowIdAsyncWithHttpInfo(flowId, body);
             return response.Data;

        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowIdAsyncWithHttpInfo (string flowId, Flow body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling PutFlowId");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PutFlowId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutFlowId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <returns></returns>
        public void DeleteFlowId (string flowId)
        {
             DeleteFlowIdWithHttpInfo(flowId);
        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFlowIdWithHttpInfo (string flowId)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->DeleteFlowId");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteFlowId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteFlowId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFlowIdAsync (string flowId)
        {
             await DeleteFlowIdAsyncWithHttpInfo(flowId);

        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowIdAsyncWithHttpInfo (string flowId)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling DeleteFlowId");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteFlowId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteFlowId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetFlowIdLatestconfiguration (string flowId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = GetFlowIdLatestconfigurationWithHttpInfo(flowId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetFlowIdLatestconfigurationWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdLatestconfiguration");
            
    
            var path_ = "/api/v1/flows/{flowId}/latestconfiguration";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetFlowIdLatestconfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdLatestconfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetFlowIdLatestconfigurationAsync (string flowId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = await GetFlowIdLatestconfigurationAsyncWithHttpInfo(flowId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowIdLatestconfigurationAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdLatestconfiguration");
            
    
            var path_ = "/api/v1/flows/{flowId}/latestconfiguration";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFlowIdLatestconfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdLatestconfiguration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="id">Publish Result ID</param> 
        /// <returns>PublishedResult</returns>
        public PublishedResult GetFlowIdPublishedresultsId (string flowId, string id)
        {
             ApiResponse<PublishedResult> response = GetFlowIdPublishedresultsIdWithHttpInfo(flowId, id);
             return response.Data;
        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="id">Publish Result ID</param> 
        /// <returns>ApiResponse of PublishedResult</returns>
        public ApiResponse< PublishedResult > GetFlowIdPublishedresultsIdWithHttpInfo (string flowId, string id)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdPublishedresultsId");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetFlowIdPublishedresultsId");
            
    
            var path_ = "/api/v1/flows/{flowId}/publishedresults/{id}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetFlowIdPublishedresultsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdPublishedresultsId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<PublishedResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedResult) Configuration.ApiClient.Deserialize(response, typeof(PublishedResult)));
            
        }
    
        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of PublishedResult</returns>
        public async System.Threading.Tasks.Task<PublishedResult> GetFlowIdPublishedresultsIdAsync (string flowId, string id)
        {
             ApiResponse<PublishedResult> response = await GetFlowIdPublishedresultsIdAsyncWithHttpInfo(flowId, id);
             return response.Data;

        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedResult>> GetFlowIdPublishedresultsIdAsyncWithHttpInfo (string flowId, string id)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdPublishedresultsId");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFlowIdPublishedresultsId");
            
    
            var path_ = "/api/v1/flows/{flowId}/publishedresults/{id}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFlowIdPublishedresultsId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdPublishedresultsId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PublishedResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedResult) Configuration.ApiClient.Deserialize(response, typeof(PublishedResult)));
            
        }
        
        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>FlowVersionEntityListing</returns>
        public FlowVersionEntityListing GetFlowIdVersions (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> response = GetFlowIdVersionsWithHttpInfo(flowId, pageNumber, pageSize, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of FlowVersionEntityListing</returns>
        public ApiResponse< FlowVersionEntityListing > GetFlowIdVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdVersions");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetFlowIdVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionEntityListing)));
            
        }
    
        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of FlowVersionEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowIdVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> response = await GetFlowIdVersionsAsyncWithHttpInfo(flowId, pageNumber, pageSize, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowIdVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdVersions");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFlowIdVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdVersions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersionEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowVersionEntityListing)));
            
        }
        
        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>FlowVersion</returns>
        public FlowVersion PostFlowIdVersions (string flowId, Body2 body = null)
        {
             ApiResponse<FlowVersion> response = PostFlowIdVersionsWithHttpInfo(flowId, body);
             return response.Data;
        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > PostFlowIdVersionsWithHttpInfo (string flowId, Body2 body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PostFlowIdVersions");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostFlowIdVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowIdVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersion>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(response, typeof(FlowVersion)));
            
        }
    
        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersion</returns>
        public async System.Threading.Tasks.Task<FlowVersion> PostFlowIdVersionsAsync (string flowId, Body2 body = null)
        {
             ApiResponse<FlowVersion> response = await PostFlowIdVersionsAsyncWithHttpInfo(flowId, body);
             return response.Data;

        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowIdVersionsAsyncWithHttpInfo (string flowId, Body2 body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling PostFlowIdVersions");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling PostFlowIdVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowIdVersions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersion>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(response, typeof(FlowVersion)));
            
        }
        
        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>FlowVersion</returns>
        public FlowVersion GetFlowIdVersionsVersionId (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> response = GetFlowIdVersionsVersionIdWithHttpInfo(flowId, versionId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > GetFlowIdVersionsVersionIdWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdVersionsVersionId");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowIdVersionsVersionId");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) pathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FlowVersion>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(response, typeof(FlowVersion)));
            
        }
    
        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of FlowVersion</returns>
        public async System.Threading.Tasks.Task<FlowVersion> GetFlowIdVersionsVersionIdAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> response = await GetFlowIdVersionsVersionIdAsyncWithHttpInfo(flowId, versionId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> GetFlowIdVersionsVersionIdAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdVersionsVersionId");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling GetFlowIdVersionsVersionId");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) pathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowVersion>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(response, typeof(FlowVersion)));
            
        }
        
        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetFlowIdVersionsVersionIdConfiguration (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = GetFlowIdVersionsVersionIdConfigurationWithHttpInfo(flowId, versionId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetFlowIdVersionsVersionIdConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdVersionsVersionIdConfiguration");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowIdVersionsVersionIdConfiguration");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}/configuration";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) pathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetFlowIdVersionsVersionIdConfigurationAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = await GetFlowIdVersionsVersionIdConfigurationAsyncWithHttpInfo(flowId, versionId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowIdVersionsVersionIdConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdVersionsVersionIdConfiguration");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling GetFlowIdVersionsVersionIdConfiguration");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}/configuration";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) pathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
    }
    
}
