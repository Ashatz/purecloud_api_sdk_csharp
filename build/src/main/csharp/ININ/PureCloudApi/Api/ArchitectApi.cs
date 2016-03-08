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
        #region Synchronous Operations
        
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns></returns>
        void DeleteFlowId (string flowId);
  
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFlowIdWithHttpInfo (string flowId);
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>string</returns>
        string DeleteIvrsIvrId (string ivrId);
  
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteIvrsIvrIdWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptsWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns></returns>
        void DeletePromptsPromptId (string promptId);
  
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptsPromptIdWithHttpInfo (string promptId);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>string</returns>
        string DeleteSchedulegroupsSchedulegroupId (string scheduleGroupId);
  
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string DeleteSchedulesScheduleId (string scheduleId);
  
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSchedulesScheduleIdWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSystempromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> GetFlowIdWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Object</returns>
        Object GetFlowIdLatestconfiguration (string flowId, string deleted = null);
  
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetFlowIdLatestconfigurationWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>ApiResponse of PublishedResult</returns>
        ApiResponse<PublishedResult> GetFlowIdPublishedresultsIdWithHttpInfo (string flowId, string id);
        
        /// <summary>
        /// Get flow version list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of FlowVersionEntityListing</returns>
        ApiResponse<FlowVersionEntityListing> GetFlowIdVersionsWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
        
        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> GetFlowIdVersionsVersionIdWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Object</returns>
        Object GetFlowIdVersionsVersionIdConfiguration (string flowId, string versionId, string deleted = null);
  
        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> GetFlowIdVersionsVersionIdConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of IVREntityListing</returns>
        ApiResponse<IVREntityListing> GetIvrsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>IVR</returns>
        IVR GetIvrsIvrId (string ivrId);
  
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> GetIvrsIvrIdWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>ApiResponse of PromptEntityListing</returns>
        ApiResponse<PromptEntityListing> GetPromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Prompt</returns>
        Prompt GetPromptsPromptId (string promptId);
  
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> GetPromptsPromptIdWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query paramaters can be used for filtering.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        ApiResponse<PromptAssetEntityListing> GetPromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> GetPromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ScheduleGroupEntityListing</returns>
        ApiResponse<ScheduleGroupEntityListing> GetSchedulegroupsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup GetSchedulegroupsSchedulegroupId (string scheduleGroupId);
  
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> GetSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of ScheduleEntityListing</returns>
        ApiResponse<ScheduleEntityListing> GetSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Schedule</returns>
        Schedule GetSchedulesScheduleId (string scheduleId);
  
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> GetSchedulesScheduleIdWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Get System Prompts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param>
        /// <returns>SystemPrompt</returns>
        SystemPrompt GetSystempromptsPromptId (string promptId);
  
        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param>
        /// <returns>ApiResponse of SystemPrompt</returns>
        ApiResponse<SystemPrompt> GetSystempromptsPromptIdWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get IVR System Prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>ApiResponse of SystemPromptAssetEntityListing</returns>
        ApiResponse<SystemPromptAssetEntityListing> GetSystempromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> GetSystempromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow Post (Flow body = null);
  
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsCheckin (string flow = null);
  
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsCheckinWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsCheckout (string flow = null);
  
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsCheckoutWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsDeactivate (string flow = null);
  
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsDeactivateWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostActionsDebugWithHttpInfo (string version, string flow = null);
        
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow PostActionsRevert (string flow = null);
  
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PostActionsRevertWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>AuditSearchResult</returns>
        AuditSearchResult PostAudits (CommonAuditRequest body = null);
  
        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>ApiResponse of AuditSearchResult</returns>
        ApiResponse<AuditSearchResult> PostAuditsWithHttpInfo (CommonAuditRequest body = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>FlowVersion</returns>
        FlowVersion PostFlowIdVersions (string flowId, Object body = null);
  
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> PostFlowIdVersionsWithHttpInfo (string flowId, Object body = null);
        
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>IVR</returns>
        IVR PostIvrs (IVR body = null);
  
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PostIvrsWithHttpInfo (IVR body = null);
        
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>IVR</returns>
        IVR PostIvrsActionsPublish (string id);
  
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PostIvrsActionsPublishWithHttpInfo (string id);
        
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Prompt</returns>
        Prompt PostPrompts (Prompt body = null);
  
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PostPromptsWithHttpInfo (Prompt body = null);
        
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PostPromptsPromptIdResourcesWithHttpInfo (string promptId, PromptAsset body = null);
        
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup PostSchedulegroups (ScheduleGroup body = null);
  
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PostSchedulegroupsWithHttpInfo (ScheduleGroup body = null);
        
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Schedule</returns>
        Schedule PostSchedules (Schedule body = null);
  
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PostSchedulesWithHttpInfo (Schedule body = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> PostSystempromptsPromptIdResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> PutFlowIdWithHttpInfo (string flowId, Flow body = null);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> PutIvrsIvrIdWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> PutPromptsPromptIdWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> PutPromptsPromptIdResourcesLanguageWithHttpInfo (string promptId, string language, PromptAsset body = null);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> PutSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> PutSchedulesScheduleIdWithHttpInfo (string scheduleId, Schedule body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Batch-delete a list of flows
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFlowIdAsync (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowIdAsyncWithHttpInfo (string flowId);
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteIvrsIvrIdAsync (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteIvrsIvrIdAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Batch-delete a list of prompts
        /// </summary>
        /// <remarks>
        /// Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePromptsPromptIdAsync (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowIdAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetFlowIdLatestconfigurationAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowIdLatestconfigurationAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowIdVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
        
        /// <summary>
        /// Get flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> GetFlowIdVersionsVersionIdConfigurationAsync (string flowId, string versionId, string deleted = null);

        /// <summary>
        /// Create flow version configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowIdVersionsVersionIdConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
        /// <summary>
        /// Get IVR configs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (IVREntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> GetIvrsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> GetIvrsIvrIdAsync (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> GetIvrsIvrIdAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Get a pageable list of user prompts
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of ApiResponse (PromptEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> GetPromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> GetPromptsPromptIdAsync (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> GetPromptsPromptIdAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get a pageable list of user prompt resources
        /// </summary>
        /// <remarks>
        /// The returned list is pageable, and query paramaters can be used for filtering.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Get a list of schedule groups.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleGroupEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> GetSchedulegroupsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> GetSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Get a list of schedules.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> GetSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> GetSchedulesScheduleIdAsync (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> GetSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Get System Prompts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        System.Threading.Tasks.Task<SystemPrompt> GetSystempromptsPromptIdAsync (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetSystempromptsPromptIdAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Get IVR System Prompt resources.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (SystemPromptAssetEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> GetSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostAsync (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostAsyncWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsCheckinAsync (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckinAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsCheckoutAsync (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckoutAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsDeactivateAsync (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsDeactivateAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> PostActionsRevertAsync (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsRevertAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of AuditSearchResult</returns>
        System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (CommonAuditRequest body = null);

        /// <summary>
        /// Gets architect-data-service audit entries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (CommonAuditRequest body = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> PostFlowIdVersionsAsync (string flowId, Object body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowIdVersionsAsyncWithHttpInfo (string flowId, Object body = null);
        
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PostIvrsAsync (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsAsyncWithHttpInfo (IVR body = null);
        
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> PostIvrsActionsPublishAsync (string id);

        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsActionsPublishAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> PostPromptsAsync (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PostPromptsAsyncWithHttpInfo (Prompt body = null);
        
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, PromptAsset body = null);
        
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> PostSchedulegroupsAsync (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PostSchedulegroupsAsyncWithHttpInfo (ScheduleGroup body = null);
        
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> PostSchedulesAsync (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PostSchedulesAsyncWithHttpInfo (Schedule body = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowIdAsyncWithHttpInfo (string flowId, Flow body = null);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> PutIvrsIvrIdAsyncWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> PutPromptsPromptIdAsyncWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Update specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PutPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> PutSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, Schedule body = null);
        
        #endregion Asynchronous Operations
        
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
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->Delete");
            
    
            var localVarPath = "/api/v1/flows";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) localVarQueryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling Delete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Delete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Batch-delete a list of flows Multiple IDs can be specified, in which case all specified flows will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Flow IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Delete");
            
    
            var localVarPath = "/api/v1/flows";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) localVarQueryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling Delete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Delete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <returns></returns>
        public void DeleteFlowId (string flowId)
        {
             DeleteFlowIdWithHttpInfo(flowId);
        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFlowIdWithHttpInfo (string flowId)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->DeleteFlowId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlowId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlowId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFlowIdAsync (string flowId)
        {
             await DeleteFlowIdAsyncWithHttpInfo(flowId);

        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFlowIdAsyncWithHttpInfo (string flowId)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling DeleteFlowId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlowId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFlowId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>string</returns>
        public string DeleteIvrsIvrId (string ivrId)
        {
             ApiResponse<string> localVarResponse = DeleteIvrsIvrIdWithHttpInfo(ivrId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteIvrsIvrIdWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->DeleteIvrsIvrId");
            
    
            var localVarPath = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIvrsIvrId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIvrsIvrId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteIvrsIvrIdAsync (string ivrId)
        {
             ApiResponse<string> localVarResponse = await DeleteIvrsIvrIdAsyncWithHttpInfo(ivrId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteIvrsIvrIdAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling DeleteIvrsIvrId");
            
    
            var localVarPath = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteIvrsIvrId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteIvrsIvrId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param> 
        /// <param name="ignoreDependencies">Ignore Dependencies</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptsWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->DeletePrompts");
            
    
            var localVarPath = "/api/v1/architect/prompts";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) localVarQueryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePrompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Batch-delete a list of prompts Multiple IDs can be specified, in which case all specified prompts will be deleted.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">List of Prompt IDs</param>
        /// <param name="ignoreDependencies">Ignore Dependencies</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsAsyncWithHttpInfo (List<string> id, bool? ignoreDependencies = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePrompts");
            
    
            var localVarPath = "/api/v1/architect/prompts";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (ignoreDependencies != null) localVarQueryParams.Add("ignoreDependencies", Configuration.ApiClient.ParameterToString(ignoreDependencies)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePrompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns></returns>
        public void DeletePromptsPromptId (string promptId)
        {
             DeletePromptsPromptIdWithHttpInfo(promptId);
        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePromptsPromptIdWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->DeletePromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePromptsPromptIdAsync (string promptId)
        {
             await DeletePromptsPromptIdAsyncWithHttpInfo(promptId);

        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeletePromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeletePromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling DeletePromptsPromptIdResourcesLanguage");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulegroupsSchedulegroupId (string scheduleGroupId)
        {
             ApiResponse<string> localVarResponse = DeleteSchedulegroupsSchedulegroupIdWithHttpInfo(scheduleGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->DeleteSchedulegroupsSchedulegroupId");
            
    
            var localVarPath = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId)
        {
             ApiResponse<string> localVarResponse = await DeleteSchedulegroupsSchedulegroupIdAsyncWithHttpInfo(scheduleGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling DeleteSchedulegroupsSchedulegroupId");
            
    
            var localVarPath = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulegroupsSchedulegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>string</returns>
        public string DeleteSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<string> localVarResponse = DeleteSchedulesScheduleIdWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->DeleteSchedulesScheduleId");
            
    
            var localVarPath = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<string> localVarResponse = await DeleteSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling DeleteSchedulesScheduleId");
            
    
            var localVarPath = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>string</returns>
        public string DeleteSystempromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             ApiResponse<string> localVarResponse = DeleteSystempromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSystempromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             ApiResponse<string> localVarResponse = await DeleteSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling DeleteSystempromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling DeleteSystempromptsPromptIdResourcesLanguage");
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSystempromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
             ApiResponse<FlowEntityListing> localVarResponse = GetWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/flows";
    
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
            
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (publishVersionId != null) localVarQueryParams.Add("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)); // query parameter
            if (editableBy != null) localVarQueryParams.Add("editableBy", Configuration.ApiClient.ParameterToString(editableBy)); // query parameter
            if (lockedBy != null) localVarQueryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FlowEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowEntityListing)));
            
        }

        
        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
             ApiResponse<FlowEntityListing> localVarResponse = await GetAsyncWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, editableBy, lockedBy, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of flows, filtered by query parameters Multiple IDs can be specified, in which case all matching flows will be returned, and no other parameters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/flows";
    
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
            
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (publishVersionId != null) localVarQueryParams.Add("publishVersionId", Configuration.ApiClient.ParameterToString(publishVersionId)); // query parameter
            if (editableBy != null) localVarQueryParams.Add("editableBy", Configuration.ApiClient.ParameterToString(editableBy)); // query parameter
            if (lockedBy != null) localVarQueryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowEntityListing)));
            
        }
        
        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>Flow</returns>
        public Flow GetFlowId (string flowId, string deleted = null)
        {
             ApiResponse<Flow> localVarResponse = GetFlowIdWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > GetFlowIdWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> GetFlowIdAsync (string flowId, string deleted = null)
        {
             ApiResponse<Flow> localVarResponse = await GetFlowIdAsyncWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> GetFlowIdAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>Object</returns>
        public Object GetFlowIdLatestconfiguration (string flowId, string deleted = null)
        {
             ApiResponse<Object> localVarResponse = GetFlowIdLatestconfigurationWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetFlowIdLatestconfigurationWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdLatestconfiguration");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/latestconfiguration";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdLatestconfiguration: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdLatestconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetFlowIdLatestconfigurationAsync (string flowId, string deleted = null)
        {
             ApiResponse<Object> localVarResponse = await GetFlowIdLatestconfigurationAsyncWithHttpInfo(flowId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowIdLatestconfigurationAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdLatestconfiguration");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/latestconfiguration";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdLatestconfiguration: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdLatestconfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="id">Publish Result ID</param> 
        /// <returns>PublishedResult</returns>
        public PublishedResult GetFlowIdPublishedresultsId (string flowId, string id)
        {
             ApiResponse<PublishedResult> localVarResponse = GetFlowIdPublishedresultsIdWithHttpInfo(flowId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/flows/{flowId}/publishedresults/{id}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdPublishedresultsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdPublishedresultsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PublishedResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedResult)));
            
        }

        
        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of PublishedResult</returns>
        public async System.Threading.Tasks.Task<PublishedResult> GetFlowIdPublishedresultsIdAsync (string flowId, string id)
        {
             ApiResponse<PublishedResult> localVarResponse = await GetFlowIdPublishedresultsIdAsyncWithHttpInfo(flowId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedResult>> GetFlowIdPublishedresultsIdAsyncWithHttpInfo (string flowId, string id)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdPublishedresultsId");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetFlowIdPublishedresultsId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/publishedresults/{id}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdPublishedresultsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdPublishedresultsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PublishedResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PublishedResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PublishedResult)));
            
        }
        
        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>FlowVersionEntityListing</returns>
        public FlowVersionEntityListing GetFlowIdVersions (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> localVarResponse = GetFlowIdVersionsWithHttpInfo(flowId, pageNumber, pageSize, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FlowVersionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersionEntityListing)));
            
        }

        
        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of FlowVersionEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowVersionEntityListing> GetFlowIdVersionsAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> localVarResponse = await GetFlowIdVersionsAsyncWithHttpInfo(flowId, pageNumber, pageSize, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get flow version list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> GetFlowIdVersionsAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdVersions");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersionEntityListing)));
            
        }
        
        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>FlowVersion</returns>
        public FlowVersion GetFlowIdVersionsVersionId (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> localVarResponse = GetFlowIdVersionsVersionIdWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions/{versionId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }

        
        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of FlowVersion</returns>
        public async System.Threading.Tasks.Task<FlowVersion> GetFlowIdVersionsVersionIdAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> localVarResponse = await GetFlowIdVersionsVersionIdAsyncWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions/{versionId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }
        
        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>Object</returns>
        public Object GetFlowIdVersionsVersionIdConfiguration (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<Object> localVarResponse = GetFlowIdVersionsVersionIdConfigurationWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > GetFlowIdVersionsVersionIdConfigurationWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->GetFlowIdVersionsVersionIdConfiguration");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null)
                throw new ApiException(400, "Missing required parameter 'versionId' when calling ArchitectApi->GetFlowIdVersionsVersionIdConfiguration");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions/{versionId}/configuration";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> GetFlowIdVersionsVersionIdConfigurationAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<Object> localVarResponse = await GetFlowIdVersionsVersionIdConfigurationAsyncWithHttpInfo(flowId, versionId, deleted);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetFlowIdVersionsVersionIdConfigurationAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling GetFlowIdVersionsVersionIdConfiguration");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling GetFlowIdVersionsVersionIdConfiguration");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions/{versionId}/configuration";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (versionId != null) localVarPathParams.Add("versionId", Configuration.ApiClient.ParameterToString(versionId)); // path parameter
            
            if (deleted != null) localVarQueryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFlowIdVersionsVersionIdConfiguration: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>IVREntityListing</returns>
        public IVREntityListing GetIvrs (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<IVREntityListing> localVarResponse = GetIvrsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of IVREntityListing</returns>
        public ApiResponse< IVREntityListing > GetIvrsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var localVarPath = "/api/v1/architect/ivrs";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetIvrs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IVREntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVREntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVREntityListing)));
            
        }

        
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of IVREntityListing</returns>
        public async System.Threading.Tasks.Task<IVREntityListing> GetIvrsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<IVREntityListing> localVarResponse = await GetIvrsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (IVREntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> GetIvrsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var localVarPath = "/api/v1/architect/ivrs";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetIvrs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVREntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVREntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVREntityListing)));
            
        }
        
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>IVR</returns>
        public IVR GetIvrsIvrId (string ivrId)
        {
             ApiResponse<IVR> localVarResponse = GetIvrsIvrIdWithHttpInfo(ivrId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > GetIvrsIvrIdWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->GetIvrsIvrId");
            
    
            var localVarPath = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetIvrsIvrId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIvrsIvrId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> GetIvrsIvrIdAsync (string ivrId)
        {
             ApiResponse<IVR> localVarResponse = await GetIvrsIvrIdAsyncWithHttpInfo(ivrId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> GetIvrsIvrIdAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling GetIvrsIvrId");
            
    
            var localVarPath = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetIvrsIvrId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetIvrsIvrId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <returns>PromptEntityListing</returns>
        public PromptEntityListing GetPrompts (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> localVarResponse = GetPromptsWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <returns>ApiResponse of PromptEntityListing</returns>
        public ApiResponse< PromptEntityListing > GetPromptsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var localVarPath = "/api/v1/architect/prompts";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPrompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PromptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptEntityListing)));
            
        }

        
        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of PromptEntityListing</returns>
        public async System.Threading.Tasks.Task<PromptEntityListing> GetPromptsAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> localVarResponse = await GetPromptsAsyncWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompts The returned list is pageable, and query parameters can be used for filtering.  Multiple names can be specified, in which case all matching prompts will be returned, and no other filters will be evaluated.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <returns>Task of ApiResponse (PromptEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> GetPromptsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var localVarPath = "/api/v1/architect/prompts";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPrompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptEntityListing)));
            
        }
        
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>Prompt</returns>
        public Prompt GetPromptsPromptId (string promptId)
        {
             ApiResponse<Prompt> localVarResponse = GetPromptsPromptIdWithHttpInfo(promptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > GetPromptsPromptIdWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> GetPromptsPromptIdAsync (string promptId)
        {
             ApiResponse<Prompt> localVarResponse = await GetPromptsPromptIdAsyncWithHttpInfo(promptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> GetPromptsPromptIdAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>PromptAssetEntityListing</returns>
        public PromptAssetEntityListing GetPromptsPromptIdResources (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> localVarResponse = GetPromptsPromptIdResourcesWithHttpInfo(promptId, pageNumber, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        public ApiResponse< PromptAssetEntityListing > GetPromptsPromptIdResourcesWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetPromptsPromptIdResources");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PromptAssetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAssetEntityListing)));
            
        }

        
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of PromptAssetEntityListing</returns>
        public async System.Threading.Tasks.Task<PromptAssetEntityListing> GetPromptsPromptIdResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> localVarResponse = await GetPromptsPromptIdResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> GetPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptsPromptIdResources");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAssetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAssetEntityListing)));
            
        }
        
        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>PromptAsset</returns>
        public PromptAsset GetPromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             ApiResponse<PromptAsset> localVarResponse = GetPromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> GetPromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             ApiResponse<PromptAsset> localVarResponse = await GetPromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> GetPromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetPromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling GetPromptsPromptIdResourcesLanguage");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ScheduleGroupEntityListing</returns>
        public ScheduleGroupEntityListing GetSchedulegroups (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleGroupEntityListing> localVarResponse = GetSchedulegroupsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ScheduleGroupEntityListing</returns>
        public ApiResponse< ScheduleGroupEntityListing > GetSchedulegroupsWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedulegroups";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduleGroupEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroupEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ScheduleGroupEntityListing</returns>
        public async System.Threading.Tasks.Task<ScheduleGroupEntityListing> GetSchedulegroupsAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleGroupEntityListing> localVarResponse = await GetSchedulegroupsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleGroupEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> GetSchedulegroupsAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedulegroups";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroupEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroupEntityListing)));
            
        }
        
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup GetSchedulegroupsSchedulegroupId (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> localVarResponse = GetSchedulegroupsSchedulegroupIdWithHttpInfo(scheduleGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > GetSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->GetSchedulegroupsSchedulegroupId");
            
    
            var localVarPath = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> GetSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> localVarResponse = await GetSchedulegroupsSchedulegroupIdAsyncWithHttpInfo(scheduleGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> GetSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling GetSchedulegroupsSchedulegroupId");
            
    
            var localVarPath = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulegroupsSchedulegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ScheduleEntityListing</returns>
        public ScheduleEntityListing GetSchedules (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleEntityListing> localVarResponse = GetSchedulesWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ApiResponse of ScheduleEntityListing</returns>
        public ApiResponse< ScheduleEntityListing > GetSchedulesWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedules";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleEntityListing)));
            
        }

        
        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ScheduleEntityListing</returns>
        public async System.Threading.Tasks.Task<ScheduleEntityListing> GetSchedulesAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleEntityListing> localVarResponse = await GetSchedulesAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of schedules. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of ApiResponse (ScheduleEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> GetSchedulesAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedules";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleEntityListing)));
            
        }
        
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>Schedule</returns>
        public Schedule GetSchedulesScheduleId (string scheduleId)
        {
             ApiResponse<Schedule> localVarResponse = GetSchedulesScheduleIdWithHttpInfo(scheduleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > GetSchedulesScheduleIdWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->GetSchedulesScheduleId");
            
    
            var localVarPath = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> GetSchedulesScheduleIdAsync (string scheduleId)
        {
             ApiResponse<Schedule> localVarResponse = await GetSchedulesScheduleIdAsyncWithHttpInfo(scheduleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> GetSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling GetSchedulesScheduleId");
            
    
            var localVarPath = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
             ApiResponse<SystemPromptEntityListing> localVarResponse = GetSystempromptsWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/systemprompts";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSystemprompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystemprompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SystemPromptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptEntityListing)));
            
        }

        
        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
             ApiResponse<SystemPromptEntityListing> localVarResponse = await GetSystempromptsAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get System Prompts. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/systemprompts";
    
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
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) localVarQueryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) localVarQueryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSystemprompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystemprompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptEntityListing)));
            
        }
        
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param> 
        /// <returns>SystemPrompt</returns>
        public SystemPrompt GetSystempromptsPromptId (string promptId)
        {
             ApiResponse<SystemPrompt> localVarResponse = GetSystempromptsPromptIdWithHttpInfo(promptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param> 
        /// <returns>ApiResponse of SystemPrompt</returns>
        public ApiResponse< SystemPrompt > GetSystempromptsPromptIdWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->GetSystempromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SystemPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPrompt)));
            
        }

        
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        public async System.Threading.Tasks.Task<SystemPrompt> GetSystempromptsPromptIdAsync (string promptId)
        {
             ApiResponse<SystemPrompt> localVarResponse = await GetSystempromptsPromptIdAsyncWithHttpInfo(promptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> GetSystempromptsPromptIdAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPrompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPrompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPrompt)));
            
        }
        
        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>SystemPromptAssetEntityListing</returns>
        public SystemPromptAssetEntityListing GetSystempromptsPromptIdResources (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> localVarResponse = GetSystempromptsPromptIdResourcesWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SystemPromptAssetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAssetEntityListing)));
            
        }

        
        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <returns>Task of SystemPromptAssetEntityListing</returns>
        public async System.Threading.Tasks.Task<SystemPromptAssetEntityListing> GetSystempromptsPromptIdResourcesAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> localVarResponse = await GetSystempromptsPromptIdResourcesAsyncWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IVR System Prompt resources. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAssetEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAssetEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAssetEntityListing)));
            
        }
        
        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset GetSystempromptsPromptIdResourcesLanguage (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = GetSystempromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> GetSystempromptsPromptIdResourcesLanguageAsync (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = await GetSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> GetSystempromptsPromptIdResourcesLanguageAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling GetSystempromptsPromptIdResourcesLanguage");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling GetSystempromptsPromptIdResourcesLanguage");
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSystempromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }
        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>Flow</returns>
        public Flow Post (Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = PostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostWithHttpInfo (Flow body = null)
        {
            
    
            var localVarPath = "/api/v1/flows";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostAsync (Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = await PostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostAsyncWithHttpInfo (Flow body = null)
        {
            
    
            var localVarPath = "/api/v1/flows";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsCheckin (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = PostActionsCheckinWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsCheckinWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/checkin";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsCheckinAsync (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = await PostActionsCheckinAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckinAsyncWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/checkin";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckin: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckin: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsCheckout (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = PostActionsCheckoutWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsCheckoutWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/checkout";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckout: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckout: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsCheckoutAsync (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = await PostActionsCheckoutAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsCheckoutAsyncWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/checkout";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckout: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsCheckout: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsDeactivate (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = PostActionsDeactivateWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsDeactivateWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/deactivate";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDeactivate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDeactivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsDeactivateAsync (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = await PostActionsDeactivateAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsDeactivateAsyncWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/deactivate";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDeactivate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDeactivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param> 
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostActionsDebugWithHttpInfo (string version, string flow = null)
        {
            
            // verify the required parameter 'version' is set
            if (version == null)
                throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectApi->PostActionsDebug");
            
    
            var localVarPath = "/api/v1/flows/actions/debug";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) localVarQueryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDebug: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDebug: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostActionsDebugAsyncWithHttpInfo (string version, string flow = null)
        {
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling PostActionsDebug");
            
    
            var localVarPath = "/api/v1/flows/actions/debug";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) localVarQueryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDebug: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsDebug: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow PostActionsRevert (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = PostActionsRevertWithHttpInfo(flow);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PostActionsRevertWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/revert";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsRevert: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsRevert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PostActionsRevertAsync (string flow = null)
        {
             ApiResponse<Flow> localVarResponse = await PostActionsRevertAsyncWithHttpInfo(flow);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PostActionsRevertAsyncWithHttpInfo (string flow = null)
        {
            
    
            var localVarPath = "/api/v1/flows/actions/revert";
    
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
            
            if (flow != null) localVarQueryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostActionsRevert: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostActionsRevert: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param> 
        /// <returns>AuditSearchResult</returns>
        public AuditSearchResult PostAudits (CommonAuditRequest body = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = PostAuditsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param> 
        /// <returns>ApiResponse of AuditSearchResult</returns>
        public ApiResponse< AuditSearchResult > PostAuditsWithHttpInfo (CommonAuditRequest body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/audits";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }

        
        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of AuditSearchResult</returns>
        public async System.Threading.Tasks.Task<AuditSearchResult> PostAuditsAsync (CommonAuditRequest body = null)
        {
             ApiResponse<AuditSearchResult> localVarResponse = await PostAuditsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets architect-data-service audit entries. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AuditSearchRequest</param>
        /// <returns>Task of ApiResponse (AuditSearchResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuditSearchResult>> PostAuditsAsyncWithHttpInfo (CommonAuditRequest body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/audits";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AuditSearchResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuditSearchResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuditSearchResult)));
            
        }
        
        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>FlowVersion</returns>
        public FlowVersion PostFlowIdVersions (string flowId, Object body = null)
        {
             ApiResponse<FlowVersion> localVarResponse = PostFlowIdVersionsWithHttpInfo(flowId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > PostFlowIdVersionsWithHttpInfo (string flowId, Object body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PostFlowIdVersions");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowIdVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }

        
        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersion</returns>
        public async System.Threading.Tasks.Task<FlowVersion> PostFlowIdVersionsAsync (string flowId, Object body = null)
        {
             ApiResponse<FlowVersion> localVarResponse = await PostFlowIdVersionsAsyncWithHttpInfo(flowId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> PostFlowIdVersionsAsyncWithHttpInfo (string flowId, Object body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling PostFlowIdVersions");
            
    
            var localVarPath = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostFlowIdVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostFlowIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FlowVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowVersion) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlowVersion)));
            
        }
        
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>IVR</returns>
        public IVR PostIvrs (IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = PostIvrsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PostIvrsWithHttpInfo (IVR body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/ivrs";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostIvrs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PostIvrsAsync (IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = await PostIvrsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsAsyncWithHttpInfo (IVR body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/ivrs";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostIvrs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIvrs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param> 
        /// <returns>IVR</returns>
        public IVR PostIvrsActionsPublish (string id)
        {
             ApiResponse<IVR> localVarResponse = PostIvrsActionsPublishWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PostIvrsActionsPublishWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectApi->PostIvrsActionsPublish");
            
    
            var localVarPath = "/api/v1/architect/ivrs/actions/publish";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling PostIvrsActionsPublish: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIvrsActionsPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PostIvrsActionsPublishAsync (string id)
        {
             ApiResponse<IVR> localVarResponse = await PostIvrsActionsPublishAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PostIvrsActionsPublishAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PostIvrsActionsPublish");
            
    
            var localVarPath = "/api/v1/architect/ivrs/actions/publish";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling PostIvrsActionsPublish: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostIvrsActionsPublish: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>Prompt</returns>
        public Prompt PostPrompts (Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = PostPromptsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PostPromptsWithHttpInfo (Prompt body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/prompts";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostPrompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> PostPromptsAsync (Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = await PostPromptsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PostPromptsAsyncWithHttpInfo (Prompt body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/prompts";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostPrompts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPrompts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>PromptAsset</returns>
        public PromptAsset PostPromptsPromptIdResources (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = PostPromptsPromptIdResourcesWithHttpInfo(promptId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > PostPromptsPromptIdResourcesWithHttpInfo (string promptId, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostPromptsPromptIdResources");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostPromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> PostPromptsPromptIdResourcesAsync (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = await PostPromptsPromptIdResourcesAsyncWithHttpInfo(promptId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> PostPromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PostPromptsPromptIdResources");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostPromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup PostSchedulegroups (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = PostSchedulegroupsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PostSchedulegroupsWithHttpInfo (ScheduleGroup body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedulegroups";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostSchedulegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> PostSchedulegroupsAsync (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = await PostSchedulegroupsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PostSchedulegroupsAsyncWithHttpInfo (ScheduleGroup body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedulegroups";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostSchedulegroups: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSchedulegroups: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>Schedule</returns>
        public Schedule PostSchedules (Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = PostSchedulesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PostSchedulesWithHttpInfo (Schedule body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedules";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> PostSchedulesAsync (Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = await PostSchedulesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PostSchedulesAsyncWithHttpInfo (Schedule body = null)
        {
            
    
            var localVarPath = "/api/v1/architect/schedules";
    
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
                throw new ApiException (localVarStatusCode, "Error calling PostSchedules: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSchedules: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>SystemPromptAsset</returns>
        public SystemPromptAsset PostSystempromptsPromptIdResources (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = PostSystempromptsPromptIdResourcesWithHttpInfo(promptId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > PostSystempromptsPromptIdResourcesWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PostSystempromptsPromptIdResources");
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostSystempromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSystempromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }

        
        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SystemPromptAsset</returns>
        public async System.Threading.Tasks.Task<SystemPromptAsset> PostSystempromptsPromptIdResourcesAsync (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> localVarResponse = await PostSystempromptsPromptIdResourcesAsyncWithHttpInfo(promptId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> PostSystempromptsPromptIdResourcesAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PostSystempromptsPromptIdResources");
            
    
            var localVarPath = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PostSystempromptsPromptIdResources: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSystempromptsPromptIdResources: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SystemPromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SystemPromptAsset)));
            
        }
        
        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>Flow</returns>
        public Flow PutFlowId (string flowId, Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = PutFlowIdWithHttpInfo(flowId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > PutFlowIdWithHttpInfo (string flowId, Flow body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null)
                throw new ApiException(400, "Missing required parameter 'flowId' when calling ArchitectApi->PutFlowId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutFlowId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutFlowId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }

        
        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> PutFlowIdAsync (string flowId, Flow body = null)
        {
             ApiResponse<Flow> localVarResponse = await PutFlowIdAsyncWithHttpInfo(flowId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> PutFlowIdAsyncWithHttpInfo (string flowId, Flow body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling PutFlowId");
            
    
            var localVarPath = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) localVarPathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutFlowId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutFlowId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Flow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param> 
        /// <param name="body"></param> 
        /// <returns>IVR</returns>
        public IVR PutIvrsIvrId (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = PutIvrsIvrIdWithHttpInfo(ivrId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > PutIvrsIvrIdWithHttpInfo (string ivrId, IVR body = null)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null)
                throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectApi->PutIvrsIvrId");
            
    
            var localVarPath = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutIvrsIvrId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIvrsIvrId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }

        
        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> PutIvrsIvrIdAsync (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> localVarResponse = await PutIvrsIvrIdAsyncWithHttpInfo(ivrId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> PutIvrsIvrIdAsyncWithHttpInfo (string ivrId, IVR body = null)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling PutIvrsIvrId");
            
    
            var localVarPath = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) localVarPathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutIvrsIvrId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutIvrsIvrId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IVR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>Prompt</returns>
        public Prompt PutPromptsPromptId (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = PutPromptsPromptIdWithHttpInfo(promptId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > PutPromptsPromptIdWithHttpInfo (string promptId, Prompt body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null)
                throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectApi->PutPromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }

        
        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> PutPromptsPromptIdAsync (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> localVarResponse = await PutPromptsPromptIdAsyncWithHttpInfo(promptId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> PutPromptsPromptIdAsyncWithHttpInfo (string promptId, Prompt body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling PutPromptsPromptId");
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Prompt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <param name="body"></param> 
        /// <returns>PromptAsset</returns>
        public PromptAsset PutPromptsPromptIdResourcesLanguage (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = PutPromptsPromptIdResourcesLanguageWithHttpInfo(promptId, language, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }

        
        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        public async System.Threading.Tasks.Task<PromptAsset> PutPromptsPromptIdResourcesLanguageAsync (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> localVarResponse = await PutPromptsPromptIdResourcesLanguageAsyncWithHttpInfo(promptId, language, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            
    
            var localVarPath = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) localVarPathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutPromptsPromptIdResourcesLanguage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PromptAsset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <param name="body"></param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup PutSchedulegroupsSchedulegroupId (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = PutSchedulegroupsSchedulegroupIdWithHttpInfo(scheduleGroupId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > PutSchedulegroupsSchedulegroupIdWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectApi->PutSchedulegroupsSchedulegroupId");
            
    
            var localVarPath = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }

        
        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> PutSchedulegroupsSchedulegroupIdAsync (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> localVarResponse = await PutSchedulegroupsSchedulegroupIdAsyncWithHttpInfo(scheduleGroupId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> PutSchedulegroupsSchedulegroupIdAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling PutSchedulegroupsSchedulegroupId");
            
    
            var localVarPath = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) localVarPathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulegroupsSchedulegroupId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body"></param> 
        /// <returns>Schedule</returns>
        public Schedule PutSchedulesScheduleId (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = PutSchedulesScheduleIdWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > PutSchedulesScheduleIdWithHttpInfo (string scheduleId, Schedule body = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null)
                throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectApi->PutSchedulesScheduleId");
            
    
            var localVarPath = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }

        
        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> PutSchedulesScheduleIdAsync (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> localVarResponse = await PutSchedulesScheduleIdAsyncWithHttpInfo(scheduleId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> PutSchedulesScheduleIdAsyncWithHttpInfo (string scheduleId, Schedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling PutSchedulesScheduleId");
            
    
            var localVarPath = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) localVarPathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesScheduleId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSchedulesScheduleId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Schedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Schedule)));
            
        }
        
    }
    
}
