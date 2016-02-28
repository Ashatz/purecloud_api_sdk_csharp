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
        IVR GetIvr (string ivrId);
  
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> GetIvrWithHttpInfo (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> GetIvrAsync (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> GetIvrAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>IVR</returns>
        IVR PutIvr (string ivrId, IVR body = null);
  
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PutIvrWithHttpInfo (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PutIvrAsync (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PutIvrAsyncWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>string</returns>
        string DeleteIvr (string ivrId);
  
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteIvrWithHttpInfo (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteIvrAsync (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteIvrAsyncWithHttpInfo (string ivrId);
        
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
        Prompt GetPrompt (string promptId);
  
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> GetPromptWithHttpInfo (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> GetPromptAsync (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> GetPromptAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Prompt</returns>
        Prompt PutPrompt (string promptId, Prompt body = null);
  
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PutPromptWithHttpInfo (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> PutPromptAsync (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PutPromptAsyncWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns></returns>
        void DeletePrompt (string promptId);
  
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptWithHttpInfo (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePromptAsync (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptAsyncWithHttpInfo (string promptId);
        
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
        PromptAssetEntityListing GetPromptResources (string promptId, int? pageNumber = null, int? pageSize = null);
  
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
        ApiResponse<PromptAssetEntityListing> GetPromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<PromptAssetEntityListing> GetPromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetPromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>PromptAsset</returns>
        PromptAsset PostPromptResources (string promptId, PromptAsset body = null);
  
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PostPromptResourcesWithHttpInfo (string promptId, PromptAsset body = null);

        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> PostPromptResourcesAsync (string promptId, PromptAsset body = null);

        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostPromptResourcesAsyncWithHttpInfo (string promptId, PromptAsset body = null);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>PromptAsset</returns>
        PromptAsset GetPromptResources_0 (string promptId, string language);
  
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> GetPromptResources_0WithHttpInfo (string promptId, string language);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> GetPromptResources_0Async (string promptId, string language);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetPromptResources_0AsyncWithHttpInfo (string promptId, string language);
        
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
        PromptAsset PutPromptResources (string promptId, string language, PromptAsset body = null);
  
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
        ApiResponse<PromptAsset> PutPromptResourcesWithHttpInfo (string promptId, string language, PromptAsset body = null);

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
        System.Threading.Tasks.Task<PromptAsset> PutPromptResourcesAsync (string promptId, string language, PromptAsset body = null);

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
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutPromptResourcesAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns></returns>
        void DeletePromptResources (string promptId, string language);
  
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptResourcesWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePromptResourcesAsync (string promptId, string language);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptResourcesAsyncWithHttpInfo (string promptId, string language);
        
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
        ScheduleGroup GetSchedulegroup (string scheduleGroupId);
  
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> GetSchedulegroupWithHttpInfo (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> GetSchedulegroupAsync (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetSchedulegroupAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup PutSchedulegroup (string scheduleGroupId, ScheduleGroup body = null);
  
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PutSchedulegroupWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> PutSchedulegroupAsync (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutSchedulegroupAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>string</returns>
        string DeleteSchedulegroup (string scheduleGroupId);
  
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulegroupWithHttpInfo (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulegroupAsync (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulegroupAsyncWithHttpInfo (string scheduleGroupId);
        
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
        Schedule GetSchedule (string scheduleId);
  
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> GetScheduleWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> GetScheduleAsync (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> GetScheduleAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Schedule</returns>
        Schedule PutSchedule (string scheduleId, Schedule body = null);
  
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PutScheduleWithHttpInfo (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> PutScheduleAsync (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PutScheduleAsyncWithHttpInfo (string scheduleId, Schedule body = null);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string DeleteSchedule (string scheduleId);
  
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteScheduleWithHttpInfo (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteScheduleAsync (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteScheduleAsyncWithHttpInfo (string scheduleId);
        
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
        SystemPrompt GetSystemprompt (string promptId);
  
        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>ApiResponse of SystemPrompt</returns>
        ApiResponse<SystemPrompt> GetSystempromptWithHttpInfo (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        System.Threading.Tasks.Task<SystemPrompt> GetSystempromptAsync (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetSystempromptAsyncWithHttpInfo (string promptId);
        
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
        SystemPromptAssetEntityListing GetSystempromptResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<SystemPromptAssetEntityListing> GetSystempromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetSystempromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetSystempromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset PostSystempromptResources (string promptId, SystemPromptAsset body = null);
  
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> PostSystempromptResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> PostSystempromptResourcesAsync (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostSystempromptResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset GetSystempromptResources_0 (string promptId, string language);
  
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> GetSystempromptResources_0WithHttpInfo (string promptId, string language);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> GetSystempromptResources_0Async (string promptId, string language);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetSystempromptResources_0AsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>string</returns>
        string DeleteSystempromptResources (string promptId, string language);
  
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSystempromptResourcesWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSystempromptResourcesAsync (string promptId, string language);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSystempromptResourcesAsyncWithHttpInfo (string promptId, string language);
        
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
        FlowEntityListing GetFlows (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);
  
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
        ApiResponse<FlowEntityListing> GetFlowsWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);

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
        System.Threading.Tasks.Task<FlowEntityListing> GetFlowsAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> GetFlowsAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow PostFlows (Flow body = null);
  
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsWithHttpInfo (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsAsync (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsAsyncWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns></returns>
        void DeleteFlows (List<string> id, bool? ignoreDependencies = null);
  
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFlowsWithHttpInfo (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFlowsAsync (List<string> id, bool? ignoreDependencies = null);

        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowsAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsCheckin (string flow = null);
  
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsCheckinWithHttpInfo (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckinAsync (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckinAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsCheckout (string flow = null);
  
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsCheckoutWithHttpInfo (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckoutAsync (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckoutAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsDeactivate (string flow = null);
  
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsDeactivateWithHttpInfo (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsDeactivateAsync (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsDeactivateAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns></returns>
        void PostFlowsActionsDebug (string version, string flow = null);
  
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostFlowsActionsDebugWithHttpInfo (string version, string flow = null);

        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostFlowsActionsDebugAsync (string version, string flow = null);

        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostFlowsActionsDebugAsyncWithHttpInfo (string version, string flow = null);
        
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostFlowsActionsRevert (string flow = null);
  
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostFlowsActionsRevertWithHttpInfo (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostFlowsActionsRevertAsync (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsRevertAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Flow</returns>
        Flow GetFlow (string flowId, string deleted = null);
  
        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> GetFlowWithHttpInfo (string flowId, string deleted = null);

        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> GetFlowAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow PutFlow (string flowId, Flow body = null);
  
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PutFlowWithHttpInfo (string flowId, Flow body = null);

        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PutFlowAsync (string flowId, Flow body = null);

        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowAsyncWithHttpInfo (string flowId, Flow body = null);
        
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns></returns>
        void DeleteFlow (string flowId);
  
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFlowWithHttpInfo (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFlowAsync (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowAsyncWithHttpInfo (string flowId);
        
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetFlowLatestconfiguration (string flowId, string deleted = null);
  
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetFlowLatestconfigurationWithHttpInfo (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetFlowLatestconfigurationAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowLatestconfigurationAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>PublishedResult</returns>
        PublishedResult GetFlowPublishedresults (string flowId, string id);
  
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>ApiResponse of PublishedResult</returns>
        ApiResponse<PublishedResult> GetFlowPublishedresultsWithHttpInfo (string flowId, string id);

        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of PublishedResult</returns>
        System.Threading.Tasks.Task<PublishedResult> GetFlowPublishedresultsAsync (string flowId, string id);

        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedResult>> GetFlowPublishedresultsAsyncWithHttpInfo (string flowId, string id);
        
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
        FlowVersionEntityListing GetFlowVersions (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
  
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
        ApiResponse<FlowVersionEntityListing> GetFlowVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);

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
        System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>FlowVersion</returns>
        FlowVersion PostFlowVersions (string flowId, Body2 body = null);
  
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> PostFlowVersionsWithHttpInfo (string flowId, Body2 body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> PostFlowVersionsAsync (string flowId, Body2 body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowVersionsAsyncWithHttpInfo (string flowId, Body2 body = null);
        
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
        FlowVersion GetFlowVersion (string flowId, string versionId, string deleted = null);
  
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
        ApiResponse<FlowVersion> GetFlowVersionWithHttpInfo (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<FlowVersion> GetFlowVersionAsync (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> GetFlowVersionAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
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
        InlineResponse200 GetFlowVersionConfiguration (string flowId, string versionId, string deleted = null);
  
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
        ApiResponse<InlineResponse200> GetFlowVersionConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<InlineResponse200> GetFlowVersionConfigurationAsync (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowVersionConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
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
        public IVR GetIvr (string ivrId)
        {
             ApiResponse<IVR> response = GetIvrWithHttpInfo(ivrId);
             return response.Data;
        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > GetIvrWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->GetIvr");
            
    
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
                throw new ApiException (statusCode, "Error calling GetIvr: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetIvr: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> GetIvrAsync (string ivrId)
        {
             ApiResponse<IVR> response = await GetIvrAsyncWithHttpInfo(ivrId);
             return response.Data;

        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> GetIvrAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling GetIvr");
            
    
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
                throw new ApiException (statusCode, "Error calling GetIvr: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetIvr: " + response.ErrorMessage, response.ErrorMessage);

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
        public IVR PutIvr (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> response = PutIvrWithHttpInfo(ivrId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PutIvrWithHttpInfo (string ivrId, IVR body = null)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->PutIvr");
            
    
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
                throw new ApiException (statusCode, "Error calling PutIvr: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutIvr: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<IVR> PutIvrAsync (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> response = await PutIvrAsyncWithHttpInfo(ivrId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PutIvrAsyncWithHttpInfo (string ivrId, IVR body = null)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling PutIvr");
            
    
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
                throw new ApiException (statusCode, "Error calling PutIvr: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutIvr: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>string</returns>
        public string DeleteIvr (string ivrId)
        {
             ApiResponse<string> response = DeleteIvrWithHttpInfo(ivrId);
             return response.Data;
        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteIvrWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->DeleteIvr");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteIvr: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteIvr: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteIvrAsync (string ivrId)
        {
             ApiResponse<string> response = await DeleteIvrAsyncWithHttpInfo(ivrId);
             return response.Data;

        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteIvrAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling DeleteIvr");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteIvr: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteIvr: " + response.ErrorMessage, response.ErrorMessage);

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
        public Prompt GetPrompt (string promptId)
        {
             ApiResponse<Prompt> response = GetPromptWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > GetPromptWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPrompt");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPrompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPrompt: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
    
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> GetPromptAsync (string promptId)
        {
             ApiResponse<Prompt> response = await GetPromptAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> GetPromptAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPrompt");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPrompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPrompt: " + response.ErrorMessage, response.ErrorMessage);

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
        public Prompt PutPrompt (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> response = PutPromptWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PutPromptWithHttpInfo (string promptId, Prompt body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutPrompt");
            
    
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
                throw new ApiException (statusCode, "Error calling PutPrompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPrompt: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Prompt> PutPromptAsync (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> response = await PutPromptAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PutPromptAsyncWithHttpInfo (string promptId, Prompt body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PutPrompt");
            
    
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
                throw new ApiException (statusCode, "Error calling PutPrompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPrompt: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns></returns>
        public void DeletePrompt (string promptId)
        {
             DeletePromptWithHttpInfo(promptId);
        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeletePrompt");
            
    
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
                throw new ApiException (statusCode, "Error calling DeletePrompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePrompt: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePromptAsync (string promptId)
        {
             await DeletePromptAsyncWithHttpInfo(promptId);

        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeletePrompt");
            
    
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
                throw new ApiException (statusCode, "Error calling DeletePrompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePrompt: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public PromptAssetEntityListing GetPromptResources (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> response = GetPromptResourcesWithHttpInfo(promptId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        public ApiResponse< PromptAssetEntityListing > GetPromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAssetEntityListing> GetPromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> response = await GetPromptResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetPromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptResources: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptAsset PostPromptResources (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = PostPromptResourcesWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PostPromptResourcesWithHttpInfo (string promptId, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostPromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling PostPromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAsset> PostPromptResourcesAsync (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = await PostPromptResourcesAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostPromptResourcesAsyncWithHttpInfo (string promptId, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PostPromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling PostPromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostPromptResources: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptAsset GetPromptResources_0 (string promptId, string language)
        {
             ApiResponse<PromptAsset> response = GetPromptResources_0WithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > GetPromptResources_0WithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptResources_0");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->GetPromptResources_0");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPromptResources_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptResources_0: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAsset> GetPromptResources_0Async (string promptId, string language)
        {
             ApiResponse<PromptAsset> response = await GetPromptResources_0AsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetPromptResources_0AsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptResources_0");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling GetPromptResources_0");
            
    
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
                throw new ApiException (statusCode, "Error calling GetPromptResources_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetPromptResources_0: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptAsset PutPromptResources (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = PutPromptResourcesWithHttpInfo(promptId, language, body);
             return response.Data;
        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PutPromptResourcesWithHttpInfo (string promptId, string language, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutPromptResources");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->PutPromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling PutPromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAsset> PutPromptResourcesAsync (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = await PutPromptResourcesAsyncWithHttpInfo(promptId, language, body);
             return response.Data;

        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutPromptResourcesAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PutPromptResources");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling PutPromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling PutPromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutPromptResources: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeletePromptResources (string promptId, string language)
        {
             DeletePromptResourcesWithHttpInfo(promptId, language);
        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptResourcesWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeletePromptResources");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->DeletePromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling DeletePromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeletePromptResourcesAsync (string promptId, string language)
        {
             await DeletePromptResourcesAsyncWithHttpInfo(promptId, language);

        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptResourcesAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeletePromptResources");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling DeletePromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling DeletePromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeletePromptResources: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public ScheduleGroup GetSchedulegroup (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> response = GetSchedulegroupWithHttpInfo(scheduleGroupId);
             return response.Data;
        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > GetSchedulegroupWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->GetSchedulegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchedulegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulegroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
    
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> GetSchedulegroupAsync (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> response = await GetSchedulegroupAsyncWithHttpInfo(scheduleGroupId);
             return response.Data;

        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetSchedulegroupAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling GetSchedulegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchedulegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedulegroup: " + response.ErrorMessage, response.ErrorMessage);

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
        public ScheduleGroup PutSchedulegroup (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = PutSchedulegroupWithHttpInfo(scheduleGroupId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PutSchedulegroupWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->PutSchedulegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSchedulegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulegroup: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ScheduleGroup> PutSchedulegroupAsync (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = await PutSchedulegroupAsyncWithHttpInfo(scheduleGroupId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutSchedulegroupAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling PutSchedulegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSchedulegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedulegroup: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulegroup (string scheduleGroupId)
        {
             ApiResponse<string> response = DeleteSchedulegroupWithHttpInfo(scheduleGroupId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulegroupWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->DeleteSchedulegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulegroupAsync (string scheduleGroupId)
        {
             ApiResponse<string> response = await DeleteSchedulegroupAsyncWithHttpInfo(scheduleGroupId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulegroupAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling DeleteSchedulegroup");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroup: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedulegroup: " + response.ErrorMessage, response.ErrorMessage);

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
        public Schedule GetSchedule (string scheduleId)
        {
             ApiResponse<Schedule> response = GetScheduleWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > GetScheduleWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->GetSchedule");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
    
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> GetScheduleAsync (string scheduleId)
        {
             ApiResponse<Schedule> response = await GetScheduleAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> GetScheduleAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetSchedule");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSchedule: " + response.ErrorMessage, response.ErrorMessage);

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
        public Schedule PutSchedule (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> response = PutScheduleWithHttpInfo(scheduleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PutScheduleWithHttpInfo (string scheduleId, Schedule body = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->PutSchedule");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Schedule> PutScheduleAsync (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> response = await PutScheduleAsyncWithHttpInfo(scheduleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PutScheduleAsyncWithHttpInfo (string scheduleId, Schedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling PutSchedule");
            
    
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
                throw new ApiException (statusCode, "Error calling PutSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutSchedule: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedule (string scheduleId)
        {
             ApiResponse<string> response = DeleteScheduleWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteScheduleWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->DeleteSchedule");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedule: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteScheduleAsync (string scheduleId)
        {
             ApiResponse<string> response = await DeleteScheduleAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteScheduleAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling DeleteSchedule");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSchedule: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSchedule: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPrompt GetSystemprompt (string promptId)
        {
             ApiResponse<SystemPrompt> response = GetSystempromptWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param> 
        /// <returns>ApiResponse of SystemPrompt</returns>
        public ApiResponse< SystemPrompt > GetSystempromptWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystemprompt");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSystemprompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystemprompt: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPrompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPrompt) Configuration.ApiClient.Deserialize(response, typeof(SystemPrompt)));
            
        }
    
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        public async System.Threading.Tasks.Task<SystemPrompt> GetSystempromptAsync (string promptId)
        {
             ApiResponse<SystemPrompt> response = await GetSystempromptAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetSystempromptAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystemprompt");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSystemprompt: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystemprompt: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptAssetEntityListing GetSystempromptResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> response = GetSystempromptResourcesWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< SystemPromptAssetEntityListing > GetSystempromptResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystempromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSystempromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetSystempromptResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> response = await GetSystempromptResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetSystempromptResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSystempromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptResources: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptAsset PostSystempromptResources (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> response = PostSystempromptResourcesWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > PostSystempromptResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostSystempromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling PostSystempromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSystempromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptAsset> PostSystempromptResourcesAsync (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> response = await PostSystempromptResourcesAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostSystempromptResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PostSystempromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling PostSystempromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostSystempromptResources: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptAsset GetSystempromptResources_0 (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> response = GetSystempromptResources_0WithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > GetSystempromptResources_0WithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystempromptResources_0");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->GetSystempromptResources_0");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSystempromptResources_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptResources_0: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptAsset> GetSystempromptResources_0Async (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> response = await GetSystempromptResources_0AsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetSystempromptResources_0AsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptResources_0");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling GetSystempromptResources_0");
            
    
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
                throw new ApiException (statusCode, "Error calling GetSystempromptResources_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSystempromptResources_0: " + response.ErrorMessage, response.ErrorMessage);

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
        public string DeleteSystempromptResources (string promptId, string language)
        {
             ApiResponse<string> response = DeleteSystempromptResourcesWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSystempromptResourcesWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeleteSystempromptResources");
            
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectApi->DeleteSystempromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSystempromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSystempromptResources: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> DeleteSystempromptResourcesAsync (string promptId, string language)
        {
             ApiResponse<string> response = await DeleteSystempromptResourcesAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSystempromptResourcesAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeleteSystempromptResources");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling DeleteSystempromptResources");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteSystempromptResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSystempromptResources: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowEntityListing GetFlows (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
        {
             ApiResponse<FlowEntityListing> response = GetFlowsWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
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
        public ApiResponse< FlowEntityListing > GetFlowsWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
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
                throw new ApiException (statusCode, "Error calling GetFlows: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlows: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowEntityListing> GetFlowsAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
        {
             ApiResponse<FlowEntityListing> response = await GetFlowsAsyncWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
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
        public async System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> GetFlowsAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string editableBy = null, string lockedBy = null, bool? deleted = null)
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
                throw new ApiException (statusCode, "Error calling GetFlows: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlows: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowEntityListing)));
            
        }
        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Flow</returns>
        public Flow PostFlows (Flow body = null)
        {
             ApiResponse<Flow> response = PostFlowsWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsWithHttpInfo (Flow body = null)
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
                throw new ApiException (statusCode, "Error calling PostFlows: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlows: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsAsync (Flow body = null)
        {
             ApiResponse<Flow> response = await PostFlowsAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsAsyncWithHttpInfo (Flow body = null)
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
                throw new ApiException (statusCode, "Error calling PostFlows: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlows: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteFlows (List<string> id, bool? ignoreDependencies = null)
        {
             DeleteFlowsWithHttpInfo(id, ignoreDependencies);
        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <param name="id">List of Flow IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFlowsWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeleteFlows");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteFlows: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteFlows: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteFlowsAsync (List<string> id, bool? ignoreDependencies = null)
        {
             await DeleteFlowsAsyncWithHttpInfo(id, ignoreDependencies);

        }

        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowsAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteFlows");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteFlows: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteFlows: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsCheckin (string flow = null)
        {
             ApiResponse<Flow> response = PostFlowsActionsCheckinWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsCheckinWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckin: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckinAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostFlowsActionsCheckinAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckinAsyncWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckin: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckin: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsCheckout (string flow = null)
        {
             ApiResponse<Flow> response = PostFlowsActionsCheckoutWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsCheckoutWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckout: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsCheckoutAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostFlowsActionsCheckoutAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsCheckoutAsyncWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckout: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsCheckout: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsDeactivate (string flow = null)
        {
             ApiResponse<Flow> response = PostFlowsActionsDeactivateWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsDeactivateWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDeactivate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDeactivate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsDeactivateAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostFlowsActionsDeactivateAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsDeactivateAsyncWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDeactivate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDeactivate: " + response.ErrorMessage, response.ErrorMessage);

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
        public void PostFlowsActionsDebug (string version, string flow = null)
        {
             PostFlowsActionsDebugWithHttpInfo(version, flow);
        }

        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param> 
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostFlowsActionsDebugWithHttpInfo (string version, string flow = null)
        {
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectApi->PostFlowsActionsDebug");
            
    
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDebug: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDebug: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PostFlowsActionsDebugAsync (string version, string flow = null)
        {
             await PostFlowsActionsDebugAsyncWithHttpInfo(version, flow);

        }

        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostFlowsActionsDebugAsyncWithHttpInfo (string version, string flow = null)
        {
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling PostFlowsActionsDebug");
            
    
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDebug: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsDebug: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostFlowsActionsRevert (string flow = null)
        {
             ApiResponse<Flow> response = PostFlowsActionsRevertWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostFlowsActionsRevertWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsRevert: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsRevert: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostFlowsActionsRevertAsync (string flow = null)
        {
             ApiResponse<Flow> response = await PostFlowsActionsRevertAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostFlowsActionsRevertAsyncWithHttpInfo (string flow = null)
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
                throw new ApiException (statusCode, "Error calling PostFlowsActionsRevert: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowsActionsRevert: " + response.ErrorMessage, response.ErrorMessage);

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
        public Flow GetFlow (string flowId, string deleted = null)
        {
             ApiResponse<Flow> response = GetFlowWithHttpInfo(flowId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > GetFlowWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlow");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlow: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlow: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Flow> GetFlowAsync (string flowId, string deleted = null)
        {
             ApiResponse<Flow> response = await GetFlowAsyncWithHttpInfo(flowId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlow");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlow: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlow: " + response.ErrorMessage, response.ErrorMessage);

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
        public Flow PutFlow (string flowId, Flow body = null)
        {
             ApiResponse<Flow> response = PutFlowWithHttpInfo(flowId, body);
             return response.Data;
        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PutFlowWithHttpInfo (string flowId, Flow body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PutFlow");
            
    
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
                throw new ApiException (statusCode, "Error calling PutFlow: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutFlow: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Flow> PutFlowAsync (string flowId, Flow body = null)
        {
             ApiResponse<Flow> response = await PutFlowAsyncWithHttpInfo(flowId, body);
             return response.Data;

        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowAsyncWithHttpInfo (string flowId, Flow body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling PutFlow");
            
    
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
                throw new ApiException (statusCode, "Error calling PutFlow: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutFlow: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <returns></returns>
        public void DeleteFlow (string flowId)
        {
             DeleteFlowWithHttpInfo(flowId);
        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFlowWithHttpInfo (string flowId)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->DeleteFlow");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteFlow: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteFlow: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFlowAsync (string flowId)
        {
             await DeleteFlowAsyncWithHttpInfo(flowId);

        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowAsyncWithHttpInfo (string flowId)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling DeleteFlow");
            
    
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
                throw new ApiException (statusCode, "Error calling DeleteFlow: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteFlow: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public InlineResponse200 GetFlowLatestconfiguration (string flowId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = GetFlowLatestconfigurationWithHttpInfo(flowId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetFlowLatestconfigurationWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowLatestconfiguration");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowLatestconfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowLatestconfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InlineResponse200> GetFlowLatestconfigurationAsync (string flowId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = await GetFlowLatestconfigurationAsyncWithHttpInfo(flowId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowLatestconfigurationAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowLatestconfiguration");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowLatestconfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowLatestconfiguration: " + response.ErrorMessage, response.ErrorMessage);

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
        public PublishedResult GetFlowPublishedresults (string flowId, string id)
        {
             ApiResponse<PublishedResult> response = GetFlowPublishedresultsWithHttpInfo(flowId, id);
             return response.Data;
        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="id">Publish Result ID</param> 
        /// <returns>ApiResponse of PublishedResult</returns>
        public ApiResponse< PublishedResult > GetFlowPublishedresultsWithHttpInfo (string flowId, string id)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowPublishedresults");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->GetFlowPublishedresults");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowPublishedresults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowPublishedresults: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PublishedResult> GetFlowPublishedresultsAsync (string flowId, string id)
        {
             ApiResponse<PublishedResult> response = await GetFlowPublishedresultsAsyncWithHttpInfo(flowId, id);
             return response.Data;

        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedResult>> GetFlowPublishedresultsAsyncWithHttpInfo (string flowId, string id)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowPublishedresults");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFlowPublishedresults");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowPublishedresults: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowPublishedresults: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowVersionEntityListing GetFlowVersions (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> response = GetFlowVersionsWithHttpInfo(flowId, pageNumber, pageSize, deleted);
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
        public ApiResponse< FlowVersionEntityListing > GetFlowVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersions");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowVersions: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> response = await GetFlowVersionsAsyncWithHttpInfo(flowId, pageNumber, pageSize, deleted);
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
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowVersions");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowVersions: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowVersion PostFlowVersions (string flowId, Body2 body = null)
        {
             ApiResponse<FlowVersion> response = PostFlowVersionsWithHttpInfo(flowId, body);
             return response.Data;
        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > PostFlowVersionsWithHttpInfo (string flowId, Body2 body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PostFlowVersions");
            
    
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
                throw new ApiException (statusCode, "Error calling PostFlowVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowVersions: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowVersion> PostFlowVersionsAsync (string flowId, Body2 body = null)
        {
             ApiResponse<FlowVersion> response = await PostFlowVersionsAsyncWithHttpInfo(flowId, body);
             return response.Data;

        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowVersionsAsyncWithHttpInfo (string flowId, Body2 body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling PostFlowVersions");
            
    
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
                throw new ApiException (statusCode, "Error calling PostFlowVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostFlowVersions: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowVersion GetFlowVersion (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> response = GetFlowVersionWithHttpInfo(flowId, versionId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > GetFlowVersionWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersion");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowVersion");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowVersion: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowVersion: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowVersion> GetFlowVersionAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> response = await GetFlowVersionAsyncWithHttpInfo(flowId, versionId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> GetFlowVersionAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowVersion");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling GetFlowVersion");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowVersion: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowVersion: " + response.ErrorMessage, response.ErrorMessage);

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
        public InlineResponse200 GetFlowVersionConfiguration (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = GetFlowVersionConfigurationWithHttpInfo(flowId, versionId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetFlowVersionConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowVersionConfiguration");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowVersionConfiguration");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowVersionConfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowVersionConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InlineResponse200> GetFlowVersionConfigurationAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = await GetFlowVersionConfigurationAsyncWithHttpInfo(flowId, versionId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetFlowVersionConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowVersionConfiguration");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling GetFlowVersionConfiguration");
            
    
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
                throw new ApiException (statusCode, "Error calling GetFlowVersionConfiguration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetFlowVersionConfiguration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
    }
    
}
