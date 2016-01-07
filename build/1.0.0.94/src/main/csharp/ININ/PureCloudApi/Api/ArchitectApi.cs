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
    public interface IArchitectApi
    {
        
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Object name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="consumedResources">Include resources each result item consumes</param>
        /// <param name="consumingResources">Include resources that consume each result item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>DependencyObjectEntityListing</returns>
        DependencyObjectEntityListing ArchitectDependencytrackingGet (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
  
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Object name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="consumedResources">Include resources each result item consumes</param>
        /// <param name="consumingResources">Include resources that consume each result item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        ApiResponse<DependencyObjectEntityListing> ArchitectDependencytrackingGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Object name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="consumedResources">Include resources each result item consumes</param>
        /// <param name="consumingResources">Include resources that consume each result item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        System.Threading.Tasks.Task<DependencyObjectEntityListing> ArchitectDependencytrackingGetAsync (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Object name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="consumedResources">Include resources each result item consumes</param>
        /// <param name="consumingResources">Include resources that consume each result item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> ArchitectDependencytrackingGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>DependencyStatus</returns>
        DependencyStatus ArchitectDependencytrackingBuildGet ();
  
        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of DependencyStatus</returns>
        ApiResponse<DependencyStatus> ArchitectDependencytrackingBuildGetWithHttpInfo ();

        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of DependencyStatus</returns>
        System.Threading.Tasks.Task<DependencyStatus> ArchitectDependencytrackingBuildGetAsync ();

        /// <summary>
        /// Get Dependency Tracking build status for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (DependencyStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyStatus>> ArchitectDependencytrackingBuildGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        void ArchitectDependencytrackingBuildPost ();
  
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ArchitectDependencytrackingBuildPostWithHttpInfo ();

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ArchitectDependencytrackingBuildPostAsync ();

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ArchitectDependencytrackingBuildPostAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type</param>
        /// <param name="resourceType">Types of consumed resources to show</param>
        /// <returns>ConsumedResourcesEntityListing</returns>
        ConsumedResourcesEntityListing ArchitectDependencytrackingConsumedresourcesGet (string id, string version, string objectType, List<string> resourceType = null);
  
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type</param>
        /// <param name="resourceType">Types of consumed resources to show</param>
        /// <returns>ApiResponse of ConsumedResourcesEntityListing</returns>
        ApiResponse<ConsumedResourcesEntityListing> ArchitectDependencytrackingConsumedresourcesGetWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type</param>
        /// <param name="resourceType">Types of consumed resources to show</param>
        /// <returns>Task of ConsumedResourcesEntityListing</returns>
        System.Threading.Tasks.Task<ConsumedResourcesEntityListing> ArchitectDependencytrackingConsumedresourcesGetAsync (string id, string version, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type</param>
        /// <param name="resourceType">Types of consumed resources to show</param>
        /// <returns>Task of ApiResponse (ConsumedResourcesEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsumedResourcesEntityListing>> ArchitectDependencytrackingConsumedresourcesGetAsyncWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null);
        
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show</param>
        /// <returns>ConsumingResourcesEntityListing</returns>
        ConsumingResourcesEntityListing ArchitectDependencytrackingConsumingresourcesGet (string id, string objectType, List<string> resourceType = null);
  
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show</param>
        /// <returns>ApiResponse of ConsumingResourcesEntityListing</returns>
        ApiResponse<ConsumingResourcesEntityListing> ArchitectDependencytrackingConsumingresourcesGetWithHttpInfo (string id, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show</param>
        /// <returns>Task of ConsumingResourcesEntityListing</returns>
        System.Threading.Tasks.Task<ConsumingResourcesEntityListing> ArchitectDependencytrackingConsumingresourcesGetAsync (string id, string objectType, List<string> resourceType = null);

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show</param>
        /// <returns>Task of ApiResponse (ConsumingResourcesEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConsumingResourcesEntityListing>> ArchitectDependencytrackingConsumingresourcesGetAsyncWithHttpInfo (string id, string objectType, List<string> resourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="flowFilter">Show only checkedIn or published flows</param>
        /// <param name="consumedResources">Return consumed resources?</param>
        /// <param name="consumedResourceType">Resource type(s) to return</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>DeletedResourceConsumerEntityListing</returns>
        DeletedResourceConsumerEntityListing ArchitectDependencytrackingDeletedresourceconsumersGet (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="flowFilter">Show only checkedIn or published flows</param>
        /// <param name="consumedResources">Return consumed resources?</param>
        /// <param name="consumedResourceType">Resource type(s) to return</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of DeletedResourceConsumerEntityListing</returns>
        ApiResponse<DeletedResourceConsumerEntityListing> ArchitectDependencytrackingDeletedresourceconsumersGetWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="flowFilter">Show only checkedIn or published flows</param>
        /// <param name="consumedResources">Return consumed resources?</param>
        /// <param name="consumedResourceType">Resource type(s) to return</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of DeletedResourceConsumerEntityListing</returns>
        System.Threading.Tasks.Task<DeletedResourceConsumerEntityListing> ArchitectDependencytrackingDeletedresourceconsumersGetAsync (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="name">Name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="flowFilter">Show only checkedIn or published flows</param>
        /// <param name="consumedResources">Return consumed resources?</param>
        /// <param name="consumedResourceType">Resource type(s) to return</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (DeletedResourceConsumerEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeletedResourceConsumerEntityListing>> ArchitectDependencytrackingDeletedresourceconsumersGetAsyncWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version</param>
        /// <param name="objectType">Object type</param>
        /// <param name="consumedResources">Include resources this item consumes</param>
        /// <param name="consumingResources">Include resources that consume this item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>DependencyObject</returns>
        DependencyObject ArchitectDependencytrackingObjectGet (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
  
        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version</param>
        /// <param name="objectType">Object type</param>
        /// <param name="consumedResources">Include resources this item consumes</param>
        /// <param name="consumingResources">Include resources that consume this item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>ApiResponse of DependencyObject</returns>
        ApiResponse<DependencyObject> ArchitectDependencytrackingObjectGetWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version</param>
        /// <param name="objectType">Object type</param>
        /// <param name="consumedResources">Include resources this item consumes</param>
        /// <param name="consumingResources">Include resources that consume this item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of DependencyObject</returns>
        System.Threading.Tasks.Task<DependencyObject> ArchitectDependencytrackingObjectGetAsync (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);

        /// <summary>
        /// Get a Dependency Tracking object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version</param>
        /// <param name="objectType">Object type</param>
        /// <param name="consumedResources">Include resources this item consumes</param>
        /// <param name="consumingResources">Include resources that consume this item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of ApiResponse (DependencyObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObject>> ArchitectDependencytrackingObjectGetAsyncWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null);
        
        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>DependencyTypeEntityListing</returns>
        DependencyTypeEntityListing ArchitectDependencytrackingTypesGet (int? pageNumber = null, int? pageSize = null);
  
        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ApiResponse of DependencyTypeEntityListing</returns>
        ApiResponse<DependencyTypeEntityListing> ArchitectDependencytrackingTypesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of DependencyTypeEntityListing</returns>
        System.Threading.Tasks.Task<DependencyTypeEntityListing> ArchitectDependencytrackingTypesGetAsync (int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// Get Dependency Tracking types.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (DependencyTypeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyTypeEntityListing>> ArchitectDependencytrackingTypesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="typeId">Type ID</param>
        /// <returns>DependencyObject</returns>
        DependencyObject ArchitectDependencytrackingTypesTypeidGet (string typeId);
  
        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="typeId">Type ID</param>
        /// <returns>ApiResponse of DependencyObject</returns>
        ApiResponse<DependencyObject> ArchitectDependencytrackingTypesTypeidGetWithHttpInfo (string typeId);

        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of DependencyObject</returns>
        System.Threading.Tasks.Task<DependencyObject> ArchitectDependencytrackingTypesTypeidGetAsync (string typeId);

        /// <summary>
        /// Get a Dependency Tracking type.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of ApiResponse (DependencyObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<DependencyObject>> ArchitectDependencytrackingTypesTypeidGetAsyncWithHttpInfo (string typeId);
        
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
        IVREntityListing ArchitectIvrsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<IVREntityListing> ArchitectIvrsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<IVREntityListing> ArchitectIvrsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> ArchitectIvrsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>IVR</returns>
        IVR ArchitectIvrsPost (IVR body = null);
  
        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> ArchitectIvrsPostWithHttpInfo (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> ArchitectIvrsPostAsync (IVR body = null);

        /// <summary>
        /// Create IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsPostAsyncWithHttpInfo (IVR body = null);
        
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>IVR</returns>
        IVR ArchitectIvrsActionsPublishPost (string id);
  
        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> ArchitectIvrsActionsPublishPostWithHttpInfo (string id);

        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> ArchitectIvrsActionsPublishPostAsync (string id);

        /// <summary>
        /// Publish an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsActionsPublishPostAsyncWithHttpInfo (string id);
        
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>IVR</returns>
        IVR ArchitectIvrsIvridGet (string ivrId);
  
        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> ArchitectIvrsIvridGetWithHttpInfo (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> ArchitectIvrsIvridGetAsync (string ivrId);

        /// <summary>
        /// Get an IVR config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsIvridGetAsyncWithHttpInfo (string ivrId);
        
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>IVR</returns>
        IVR ArchitectIvrsIvridPut (string ivrId, IVR body = null);
  
        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of IVR</returns>
        ApiResponse<IVR> ArchitectIvrsIvridPutWithHttpInfo (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        System.Threading.Tasks.Task<IVR> ArchitectIvrsIvridPutAsync (string ivrId, IVR body = null);

        /// <summary>
        /// Update an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsIvridPutAsyncWithHttpInfo (string ivrId, IVR body = null);
        
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>string</returns>
        string ArchitectIvrsIvridDelete (string ivrId);
  
        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectIvrsIvridDeleteWithHttpInfo (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectIvrsIvridDeleteAsync (string ivrId);

        /// <summary>
        /// Delete an IVR Config.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectIvrsIvridDeleteAsyncWithHttpInfo (string ivrId);
        
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
        PromptEntityListing ArchitectPromptsGet (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
  
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
        ApiResponse<PromptEntityListing> ArchitectPromptsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);

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
        System.Threading.Tasks.Task<PromptEntityListing> ArchitectPromptsGetAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);

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
        System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> ArchitectPromptsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Prompt</returns>
        Prompt ArchitectPromptsPost (Prompt body = null);
  
        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> ArchitectPromptsPostWithHttpInfo (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> ArchitectPromptsPostAsync (Prompt body = null);

        /// <summary>
        /// Create a new user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> ArchitectPromptsPostAsyncWithHttpInfo (Prompt body = null);
        
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Prompt</returns>
        Prompt ArchitectPromptsPromptidGet (string promptId);
  
        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> ArchitectPromptsPromptidGetWithHttpInfo (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> ArchitectPromptsPromptidGetAsync (string promptId);

        /// <summary>
        /// Get specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> ArchitectPromptsPromptidGetAsyncWithHttpInfo (string promptId);
        
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Prompt</returns>
        Prompt ArchitectPromptsPromptidPut (string promptId, Prompt body = null);
  
        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Prompt</returns>
        ApiResponse<Prompt> ArchitectPromptsPromptidPutWithHttpInfo (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        System.Threading.Tasks.Task<Prompt> ArchitectPromptsPromptidPutAsync (string promptId, Prompt body = null);

        /// <summary>
        /// Update specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<Prompt>> ArchitectPromptsPromptidPutAsyncWithHttpInfo (string promptId, Prompt body = null);
        
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>string</returns>
        string ArchitectPromptsPromptidDelete (string promptId);
  
        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectPromptsPromptidDeleteWithHttpInfo (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectPromptsPromptidDeleteAsync (string promptId);

        /// <summary>
        /// Delete specified user prompt
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectPromptsPromptidDeleteAsyncWithHttpInfo (string promptId);
        
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
        PromptAssetEntityListing ArchitectPromptsPromptidResourcesGet (string promptId, int? pageNumber = null, int? pageSize = null);
  
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
        ApiResponse<PromptAssetEntityListing> ArchitectPromptsPromptidResourcesGetWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<PromptAssetEntityListing> ArchitectPromptsPromptidResourcesGetAsync (string promptId, int? pageNumber = null, int? pageSize = null);

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
        System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> ArchitectPromptsPromptidResourcesGetAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null);
        
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>PromptAsset</returns>
        PromptAsset ArchitectPromptsPromptidResourcesPost (string promptId, PromptAsset body = null);
  
        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> ArchitectPromptsPromptidResourcesPostWithHttpInfo (string promptId, PromptAsset body = null);

        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> ArchitectPromptsPromptidResourcesPostAsync (string promptId, PromptAsset body = null);

        /// <summary>
        /// Create a new user prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> ArchitectPromptsPromptidResourcesPostAsyncWithHttpInfo (string promptId, PromptAsset body = null);
        
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>PromptAsset</returns>
        PromptAsset ArchitectPromptsPromptidResourcesLanguageGet (string promptId, string language);
  
        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of PromptAsset</returns>
        ApiResponse<PromptAsset> ArchitectPromptsPromptidResourcesLanguageGetWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of PromptAsset</returns>
        System.Threading.Tasks.Task<PromptAsset> ArchitectPromptsPromptidResourcesLanguageGetAsync (string promptId, string language);

        /// <summary>
        /// Get specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> ArchitectPromptsPromptidResourcesLanguageGetAsyncWithHttpInfo (string promptId, string language);
        
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
        PromptAsset ArchitectPromptsPromptidResourcesLanguagePut (string promptId, string language, PromptAsset body = null);
  
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
        ApiResponse<PromptAsset> ArchitectPromptsPromptidResourcesLanguagePutWithHttpInfo (string promptId, string language, PromptAsset body = null);

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
        System.Threading.Tasks.Task<PromptAsset> ArchitectPromptsPromptidResourcesLanguagePutAsync (string promptId, string language, PromptAsset body = null);

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
        System.Threading.Tasks.Task<ApiResponse<PromptAsset>> ArchitectPromptsPromptidResourcesLanguagePutAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null);
        
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>string</returns>
        string ArchitectPromptsPromptidResourcesLanguageDelete (string promptId, string language);
  
        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectPromptsPromptidResourcesLanguageDeleteWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectPromptsPromptidResourcesLanguageDeleteAsync (string promptId, string language);

        /// <summary>
        /// Delete specified user prompt resource
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectPromptsPromptidResourcesLanguageDeleteAsyncWithHttpInfo (string promptId, string language);
        
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
        ScheduleGroupEntityListing ArchitectSchedulegroupsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<ScheduleGroupEntityListing> ArchitectSchedulegroupsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ScheduleGroupEntityListing> ArchitectSchedulegroupsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> ArchitectSchedulegroupsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup ArchitectSchedulegroupsPost (ScheduleGroup body = null);
  
        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> ArchitectSchedulegroupsPostWithHttpInfo (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> ArchitectSchedulegroupsPostAsync (ScheduleGroup body = null);

        /// <summary>
        /// Creates a new schedule group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> ArchitectSchedulegroupsPostAsyncWithHttpInfo (ScheduleGroup body = null);
        
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup ArchitectSchedulegroupsSchedulegroupidGet (string scheduleGroupId);
  
        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> ArchitectSchedulegroupsSchedulegroupidGetWithHttpInfo (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> ArchitectSchedulegroupsSchedulegroupidGetAsync (string scheduleGroupId);

        /// <summary>
        /// Gets a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> ArchitectSchedulegroupsSchedulegroupidGetAsyncWithHttpInfo (string scheduleGroupId);
        
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ScheduleGroup</returns>
        ScheduleGroup ArchitectSchedulegroupsSchedulegroupidPut (string scheduleGroupId, ScheduleGroup body = null);
  
        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of ScheduleGroup</returns>
        ApiResponse<ScheduleGroup> ArchitectSchedulegroupsSchedulegroupidPutWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        System.Threading.Tasks.Task<ScheduleGroup> ArchitectSchedulegroupsSchedulegroupidPutAsync (string scheduleGroupId, ScheduleGroup body = null);

        /// <summary>
        /// Updates a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> ArchitectSchedulegroupsSchedulegroupidPutAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null);
        
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>string</returns>
        string ArchitectSchedulegroupsSchedulegroupidDelete (string scheduleGroupId);
  
        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectSchedulegroupsSchedulegroupidDeleteWithHttpInfo (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectSchedulegroupsSchedulegroupidDeleteAsync (string scheduleGroupId);

        /// <summary>
        /// Deletes a schedule group by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectSchedulegroupsSchedulegroupidDeleteAsyncWithHttpInfo (string scheduleGroupId);
        
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
        ScheduleEntityListing ArchitectSchedulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<ScheduleEntityListing> ArchitectSchedulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ScheduleEntityListing> ArchitectSchedulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> ArchitectSchedulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Schedule</returns>
        Schedule ArchitectSchedulesPost (Schedule body = null);
  
        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> ArchitectSchedulesPostWithHttpInfo (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> ArchitectSchedulesPostAsync (Schedule body = null);

        /// <summary>
        /// Create a new schedule.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> ArchitectSchedulesPostAsyncWithHttpInfo (Schedule body = null);
        
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Schedule</returns>
        Schedule ArchitectSchedulesScheduleidGet (string scheduleId);
  
        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> ArchitectSchedulesScheduleidGetWithHttpInfo (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> ArchitectSchedulesScheduleidGetAsync (string scheduleId);

        /// <summary>
        /// Get a schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> ArchitectSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId);
        
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Schedule</returns>
        Schedule ArchitectSchedulesScheduleidPut (string scheduleId, Schedule body = null);
  
        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Schedule</returns>
        ApiResponse<Schedule> ArchitectSchedulesScheduleidPutWithHttpInfo (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        System.Threading.Tasks.Task<Schedule> ArchitectSchedulesScheduleidPutAsync (string scheduleId, Schedule body = null);

        /// <summary>
        /// Update schedule by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<Schedule>> ArchitectSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, Schedule body = null);
        
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>string</returns>
        string ArchitectSchedulesScheduleidDelete (string scheduleId);
  
        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectSchedulesScheduleidDeleteWithHttpInfo (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectSchedulesScheduleidDeleteAsync (string scheduleId);

        /// <summary>
        /// Delete a schedule by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId);
        
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
        SystemPromptEntityListing ArchitectSystempromptsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);
  
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
        ApiResponse<SystemPromptEntityListing> ArchitectSystempromptsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);

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
        System.Threading.Tasks.Task<SystemPromptEntityListing> ArchitectSystempromptsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);

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
        System.Threading.Tasks.Task<ApiResponse<SystemPromptEntityListing>> ArchitectSystempromptsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null);
        
        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>SystemPrompt</returns>
        SystemPrompt ArchitectSystempromptsPromptidGet (string promptId);
  
        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>ApiResponse of SystemPrompt</returns>
        ApiResponse<SystemPrompt> ArchitectSystempromptsPromptidGetWithHttpInfo (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        System.Threading.Tasks.Task<SystemPrompt> ArchitectSystempromptsPromptidGetAsync (string promptId);

        /// <summary>
        /// Get IVR system prompt.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> ArchitectSystempromptsPromptidGetAsyncWithHttpInfo (string promptId);
        
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
        SystemPromptAssetEntityListing ArchitectSystempromptsPromptidResourcesGet (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
  
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
        ApiResponse<SystemPromptAssetEntityListing> ArchitectSystempromptsPromptidResourcesGetWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<SystemPromptAssetEntityListing> ArchitectSystempromptsPromptidResourcesGetAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);

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
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> ArchitectSystempromptsPromptidResourcesGetAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null);
        
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset ArchitectSystempromptsPromptidResourcesPost (string promptId, SystemPromptAsset body = null);
  
        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> ArchitectSystempromptsPromptidResourcesPostWithHttpInfo (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> ArchitectSystempromptsPromptidResourcesPostAsync (string promptId, SystemPromptAsset body = null);

        /// <summary>
        /// Create system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> ArchitectSystempromptsPromptidResourcesPostAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null);
        
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>SystemPromptAsset</returns>
        SystemPromptAsset ArchitectSystempromptsPromptidResourcesLanguageGet (string promptId, string language);
  
        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        ApiResponse<SystemPromptAsset> ArchitectSystempromptsPromptidResourcesLanguageGetWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of SystemPromptAsset</returns>
        System.Threading.Tasks.Task<SystemPromptAsset> ArchitectSystempromptsPromptidResourcesLanguageGetAsync (string promptId, string language);

        /// <summary>
        /// Get a system prompt resource.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> ArchitectSystempromptsPromptidResourcesLanguageGetAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>string</returns>
        string ArchitectSystempromptsPromptidResourcesLanguageDelete (string promptId, string language);
  
        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectSystempromptsPromptidResourcesLanguageDeleteWithHttpInfo (string promptId, string language);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectSystempromptsPromptidResourcesLanguageDeleteAsync (string promptId, string language);

        /// <summary>
        /// Delete a system prompt resource override.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectSystempromptsPromptidResourcesLanguageDeleteAsyncWithHttpInfo (string promptId, string language);
        
        /// <summary>
        /// Get IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="method">Method</param>
        /// <param name="type">Type</param>
        /// <returns>VoiceXmlOperationEntityListing</returns>
        VoiceXmlOperationEntityListing ArchitectVoicexmloperationsGet (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null);
  
        /// <summary>
        /// Get IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="method">Method</param>
        /// <param name="type">Type</param>
        /// <returns>ApiResponse of VoiceXmlOperationEntityListing</returns>
        ApiResponse<VoiceXmlOperationEntityListing> ArchitectVoicexmloperationsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null);

        /// <summary>
        /// Get IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="method">Method</param>
        /// <param name="type">Type</param>
        /// <returns>Task of VoiceXmlOperationEntityListing</returns>
        System.Threading.Tasks.Task<VoiceXmlOperationEntityListing> ArchitectVoicexmloperationsGetAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null);

        /// <summary>
        /// Get IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="method">Method</param>
        /// <param name="type">Type</param>
        /// <returns>Task of ApiResponse (VoiceXmlOperationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperationEntityListing>> ArchitectVoicexmloperationsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null);
        
        /// <summary>
        /// Create IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>VoiceXmlOperation</returns>
        VoiceXmlOperation ArchitectVoicexmloperationsPost (VoiceXmlOperation body = null);
  
        /// <summary>
        /// Create IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of VoiceXmlOperation</returns>
        ApiResponse<VoiceXmlOperation> ArchitectVoicexmloperationsPostWithHttpInfo (VoiceXmlOperation body = null);

        /// <summary>
        /// Create IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of VoiceXmlOperation</returns>
        System.Threading.Tasks.Task<VoiceXmlOperation> ArchitectVoicexmloperationsPostAsync (VoiceXmlOperation body = null);

        /// <summary>
        /// Create IVR voice XML operations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (VoiceXmlOperation)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperation>> ArchitectVoicexmloperationsPostAsyncWithHttpInfo (VoiceXmlOperation body = null);
        
        /// <summary>
        /// Get IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>VoiceXmlOperation</returns>
        VoiceXmlOperation ArchitectVoicexmloperationsVoicexmloperationidGet (string voiceXmlOperationId);
  
        /// <summary>
        /// Get IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>ApiResponse of VoiceXmlOperation</returns>
        ApiResponse<VoiceXmlOperation> ArchitectVoicexmloperationsVoicexmloperationidGetWithHttpInfo (string voiceXmlOperationId);

        /// <summary>
        /// Get IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of VoiceXmlOperation</returns>
        System.Threading.Tasks.Task<VoiceXmlOperation> ArchitectVoicexmloperationsVoicexmloperationidGetAsync (string voiceXmlOperationId);

        /// <summary>
        /// Get IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of ApiResponse (VoiceXmlOperation)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperation>> ArchitectVoicexmloperationsVoicexmloperationidGetAsyncWithHttpInfo (string voiceXmlOperationId);
        
        /// <summary>
        /// Update IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <param name="body"></param>
        /// <returns>VoiceXmlOperation</returns>
        VoiceXmlOperation ArchitectVoicexmloperationsVoicexmloperationidPut (string voiceXmlOperationId, VoiceXmlOperation body = null);
  
        /// <summary>
        /// Update IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of VoiceXmlOperation</returns>
        ApiResponse<VoiceXmlOperation> ArchitectVoicexmloperationsVoicexmloperationidPutWithHttpInfo (string voiceXmlOperationId, VoiceXmlOperation body = null);

        /// <summary>
        /// Update IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of VoiceXmlOperation</returns>
        System.Threading.Tasks.Task<VoiceXmlOperation> ArchitectVoicexmloperationsVoicexmloperationidPutAsync (string voiceXmlOperationId, VoiceXmlOperation body = null);

        /// <summary>
        /// Update IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (VoiceXmlOperation)</returns>
        System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperation>> ArchitectVoicexmloperationsVoicexmloperationidPutAsyncWithHttpInfo (string voiceXmlOperationId, VoiceXmlOperation body = null);
        
        /// <summary>
        /// Delete IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>string</returns>
        string ArchitectVoicexmloperationsVoicexmloperationidDelete (string voiceXmlOperationId);
  
        /// <summary>
        /// Delete IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ArchitectVoicexmloperationsVoicexmloperationidDeleteWithHttpInfo (string voiceXmlOperationId);

        /// <summary>
        /// Delete IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ArchitectVoicexmloperationsVoicexmloperationidDeleteAsync (string voiceXmlOperationId);

        /// <summary>
        /// Delete IVR voice XML operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ArchitectVoicexmloperationsVoicexmloperationidDeleteAsyncWithHttpInfo (string voiceXmlOperationId);
        
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
        /// <param name="lockedBy">Locked by</param>
        /// <returns>FlowEntityListing</returns>
        FlowEntityListing FlowsGet (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);
  
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
        /// <param name="lockedBy">Locked by</param>
        /// <returns>ApiResponse of FlowEntityListing</returns>
        ApiResponse<FlowEntityListing> FlowsGetWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);

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
        /// <param name="lockedBy">Locked by</param>
        /// <returns>Task of FlowEntityListing</returns>
        System.Threading.Tasks.Task<FlowEntityListing> FlowsGetAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);

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
        /// <param name="lockedBy">Locked by</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> FlowsGetAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null);
        
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow FlowsPost (Flow body = null);
  
        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsPostWithHttpInfo (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsPostAsync (Flow body = null);

        /// <summary>
        /// Create flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsPostAsyncWithHttpInfo (Flow body = null);
        
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow FlowsActionsCheckinPost (string flow = null);
  
        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsActionsCheckinPostWithHttpInfo (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsActionsCheckinPostAsync (string flow = null);

        /// <summary>
        /// Check-in flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsCheckinPostAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow FlowsActionsCheckoutPost (string flow = null);
  
        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsActionsCheckoutPostWithHttpInfo (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsActionsCheckoutPostAsync (string flow = null);

        /// <summary>
        /// Check-out flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsCheckoutPostAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow FlowsActionsDeactivatePost (string flow = null);
  
        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsActionsDeactivatePostWithHttpInfo (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsActionsDeactivatePostAsync (string flow = null);

        /// <summary>
        /// Deactivate flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsDeactivatePostAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns></returns>
        void FlowsActionsDebugPost (string version, string flow = null);
  
        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> FlowsActionsDebugPostWithHttpInfo (string version, string flow = null);

        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task FlowsActionsDebugPostAsync (string version, string flow = null);

        /// <summary>
        /// Debug flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> FlowsActionsDebugPostAsyncWithHttpInfo (string version, string flow = null);
        
        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <param name="version">version</param>
        /// <returns>Flow</returns>
        Flow FlowsActionsPublishPost (string flow = null, string version = null);
  
        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <param name="version">version</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsActionsPublishPostWithHttpInfo (string flow = null, string version = null);

        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <param name="version">version</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsActionsPublishPostAsync (string flow = null, string version = null);

        /// <summary>
        /// Publish flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <param name="version">version</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsPublishPostAsyncWithHttpInfo (string flow = null, string version = null);
        
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Flow</returns>
        Flow FlowsActionsRevertPost (string flow = null);
  
        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsActionsRevertPostWithHttpInfo (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsActionsRevertPostAsync (string flow = null);

        /// <summary>
        /// Revert flow
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsRevertPostAsyncWithHttpInfo (string flow = null);
        
        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Flow</returns>
        Flow FlowsFlowidGet (string flowId, string deleted = null);
  
        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsFlowidGetWithHttpInfo (string flowId, string deleted = null);

        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsFlowidGetAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsFlowidGetAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Flow</returns>
        Flow FlowsFlowidPut (string flowId, Flow body = null);
  
        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Flow</returns>
        ApiResponse<Flow> FlowsFlowidPutWithHttpInfo (string flowId, Flow body = null);

        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        System.Threading.Tasks.Task<Flow> FlowsFlowidPutAsync (string flowId, Flow body = null);

        /// <summary>
        /// Update flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsFlowidPutAsyncWithHttpInfo (string flowId, Flow body = null);
        
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>string</returns>
        string FlowsFlowidDelete (string flowId);
  
        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> FlowsFlowidDeleteWithHttpInfo (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> FlowsFlowidDeleteAsync (string flowId);

        /// <summary>
        /// Delete flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> FlowsFlowidDeleteAsyncWithHttpInfo (string flowId);
        
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 FlowsFlowidLatestconfigurationGet (string flowId, string deleted = null);
  
        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> FlowsFlowidLatestconfigurationGetWithHttpInfo (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> FlowsFlowidLatestconfigurationGetAsync (string flowId, string deleted = null);

        /// <summary>
        /// Get the latest configuration for flow.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> FlowsFlowidLatestconfigurationGetAsyncWithHttpInfo (string flowId, string deleted = null);
        
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>PublishedResult</returns>
        PublishedResult FlowsFlowidPublishedresultsIdGet (string flowId, string id);
  
        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>ApiResponse of PublishedResult</returns>
        ApiResponse<PublishedResult> FlowsFlowidPublishedresultsIdGetWithHttpInfo (string flowId, string id);

        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of PublishedResult</returns>
        System.Threading.Tasks.Task<PublishedResult> FlowsFlowidPublishedresultsIdGetAsync (string flowId, string id);

        /// <summary>
        /// Get generation result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<PublishedResult>> FlowsFlowidPublishedresultsIdGetAsyncWithHttpInfo (string flowId, string id);
        
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
        FlowVersionEntityListing FlowsFlowidVersionsGet (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
  
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
        ApiResponse<FlowVersionEntityListing> FlowsFlowidVersionsGetWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);

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
        System.Threading.Tasks.Task<FlowVersionEntityListing> FlowsFlowidVersionsGetAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> FlowsFlowidVersionsGetAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null);
        
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>FlowVersion</returns>
        FlowVersion FlowsFlowidVersionsPost (string flowId, Body3 body = null);
  
        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlowVersion</returns>
        ApiResponse<FlowVersion> FlowsFlowidVersionsPostWithHttpInfo (string flowId, Body3 body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of FlowVersion</returns>
        System.Threading.Tasks.Task<FlowVersion> FlowsFlowidVersionsPostAsync (string flowId, Body3 body = null);

        /// <summary>
        /// Create flow version
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> FlowsFlowidVersionsPostAsyncWithHttpInfo (string flowId, Body3 body = null);
        
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
        FlowVersion FlowsFlowidVersionsVersionidGet (string flowId, string versionId, string deleted = null);
  
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
        ApiResponse<FlowVersion> FlowsFlowidVersionsVersionidGetWithHttpInfo (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<FlowVersion> FlowsFlowidVersionsVersionidGetAsync (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<FlowVersion>> FlowsFlowidVersionsVersionidGetAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
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
        InlineResponse200 FlowsFlowidVersionsVersionidConfigurationGet (string flowId, string versionId, string deleted = null);
  
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
        ApiResponse<InlineResponse200> FlowsFlowidVersionsVersionidConfigurationGetWithHttpInfo (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<InlineResponse200> FlowsFlowidVersionsVersionidConfigurationGetAsync (string flowId, string versionId, string deleted = null);

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
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> FlowsFlowidVersionsVersionidConfigurationGetAsyncWithHttpInfo (string flowId, string versionId, string deleted = null);
        
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
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Object name to search for</param> 
        /// <param name="objectType">Object type(s) to search for</param> 
        /// <param name="consumedResources">Include resources each result item consumes</param> 
        /// <param name="consumingResources">Include resources that consume each result item</param> 
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param> 
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param> 
        /// <returns>DependencyObjectEntityListing</returns>
        public DependencyObjectEntityListing ArchitectDependencytrackingGet (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObjectEntityListing> response = ArchitectDependencytrackingGetWithHttpInfo(pageNumber, pageSize, name, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return response.Data;
        }

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Object name to search for</param> 
        /// <param name="objectType">Object type(s) to search for</param> 
        /// <param name="consumedResources">Include resources each result item consumes</param> 
        /// <param name="consumingResources">Include resources that consume each result item</param> 
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param> 
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param> 
        /// <returns>ApiResponse of DependencyObjectEntityListing</returns>
        public ApiResponse< DependencyObjectEntityListing > ArchitectDependencytrackingGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (consumedResources != null) queryParams.Add("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)); // query parameter
            if (consumingResources != null) queryParams.Add("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)); // query parameter
            if (consumedResourceType != null) queryParams.Add("consumedResourceType", Configuration.ApiClient.ParameterToString(consumedResourceType)); // query parameter
            if (consumingResourceType != null) queryParams.Add("consumingResourceType", Configuration.ApiClient.ParameterToString(consumingResourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DependencyObjectEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DependencyObjectEntityListing)));
            
        }
    
        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Object name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="consumedResources">Include resources each result item consumes</param>
        /// <param name="consumingResources">Include resources that consume each result item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of DependencyObjectEntityListing</returns>
        public async System.Threading.Tasks.Task<DependencyObjectEntityListing> ArchitectDependencytrackingGetAsync (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObjectEntityListing> response = await ArchitectDependencytrackingGetAsyncWithHttpInfo(pageNumber, pageSize, name, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return response.Data;

        }

        /// <summary>
        /// Get Dependency Tracking objects that have a given display name 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Object name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="consumedResources">Include resources each result item consumes</param>
        /// <param name="consumingResources">Include resources that consume each result item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of ApiResponse (DependencyObjectEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObjectEntityListing>> ArchitectDependencytrackingGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, List<string> objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (consumedResources != null) queryParams.Add("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)); // query parameter
            if (consumingResources != null) queryParams.Add("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)); // query parameter
            if (consumedResourceType != null) queryParams.Add("consumedResourceType", Configuration.ApiClient.ParameterToString(consumedResourceType)); // query parameter
            if (consumingResourceType != null) queryParams.Add("consumingResourceType", Configuration.ApiClient.ParameterToString(consumingResourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DependencyObjectEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyObjectEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DependencyObjectEntityListing)));
            
        }
        
        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <returns>DependencyStatus</returns>
        public DependencyStatus ArchitectDependencytrackingBuildGet ()
        {
             ApiResponse<DependencyStatus> response = ArchitectDependencytrackingBuildGetWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <returns>ApiResponse of DependencyStatus</returns>
        public ApiResponse< DependencyStatus > ArchitectDependencytrackingBuildGetWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/build";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DependencyStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyStatus) Configuration.ApiClient.Deserialize(response, typeof(DependencyStatus)));
            
        }
    
        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <returns>Task of DependencyStatus</returns>
        public async System.Threading.Tasks.Task<DependencyStatus> ArchitectDependencytrackingBuildGetAsync ()
        {
             ApiResponse<DependencyStatus> response = await ArchitectDependencytrackingBuildGetAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Get Dependency Tracking build status for an organization 
        /// </summary>
        /// <returns>Task of ApiResponse (DependencyStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyStatus>> ArchitectDependencytrackingBuildGetAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/build";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DependencyStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyStatus) Configuration.ApiClient.Deserialize(response, typeof(DependencyStatus)));
            
        }
        
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization 
        /// </summary>
        /// <returns></returns>
        public void ArchitectDependencytrackingBuildPost ()
        {
             ArchitectDependencytrackingBuildPostWithHttpInfo();
        }

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization 
        /// </summary>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ArchitectDependencytrackingBuildPostWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/build";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Rebuild Dependency Tracking data for an organization 
        /// </summary>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ArchitectDependencytrackingBuildPostAsync ()
        {
             await ArchitectDependencytrackingBuildPostAsyncWithHttpInfo();

        }

        /// <summary>
        /// Rebuild Dependency Tracking data for an organization 
        /// </summary>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ArchitectDependencytrackingBuildPostAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/build";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingBuildPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consuming object ID</param> 
        /// <param name="version">Consuming object version</param> 
        /// <param name="objectType">Consuming object type</param> 
        /// <param name="resourceType">Types of consumed resources to show</param> 
        /// <returns>ConsumedResourcesEntityListing</returns>
        public ConsumedResourcesEntityListing ArchitectDependencytrackingConsumedresourcesGet (string id, string version, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumedResourcesEntityListing> response = ArchitectDependencytrackingConsumedresourcesGetWithHttpInfo(id, version, objectType, resourceType);
             return response.Data;
        }

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consuming object ID</param> 
        /// <param name="version">Consuming object version</param> 
        /// <param name="objectType">Consuming object type</param> 
        /// <param name="resourceType">Types of consumed resources to show</param> 
        /// <returns>ApiResponse of ConsumedResourcesEntityListing</returns>
        public ApiResponse< ConsumedResourcesEntityListing > ArchitectDependencytrackingConsumedresourcesGetWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectDependencytrackingConsumedresourcesGet");
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectDependencytrackingConsumedresourcesGet");
            
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectDependencytrackingConsumedresourcesGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/consumedresources";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (resourceType != null) queryParams.Add("resourceType", Configuration.ApiClient.ParameterToString(resourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumedresourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumedresourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsumedResourcesEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsumedResourcesEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConsumedResourcesEntityListing)));
            
        }
    
        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type</param>
        /// <param name="resourceType">Types of consumed resources to show</param>
        /// <returns>Task of ConsumedResourcesEntityListing</returns>
        public async System.Threading.Tasks.Task<ConsumedResourcesEntityListing> ArchitectDependencytrackingConsumedresourcesGetAsync (string id, string version, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumedResourcesEntityListing> response = await ArchitectDependencytrackingConsumedresourcesGetAsyncWithHttpInfo(id, version, objectType, resourceType);
             return response.Data;

        }

        /// <summary>
        /// Get resources that are consumed by a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consuming object ID</param>
        /// <param name="version">Consuming object version</param>
        /// <param name="objectType">Consuming object type</param>
        /// <param name="resourceType">Types of consumed resources to show</param>
        /// <returns>Task of ApiResponse (ConsumedResourcesEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsumedResourcesEntityListing>> ArchitectDependencytrackingConsumedresourcesGetAsyncWithHttpInfo (string id, string version, string objectType, List<string> resourceType = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectDependencytrackingConsumedresourcesGet");
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling ArchitectDependencytrackingConsumedresourcesGet");
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectDependencytrackingConsumedresourcesGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/consumedresources";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (resourceType != null) queryParams.Add("resourceType", Configuration.ApiClient.ParameterToString(resourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumedresourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumedresourcesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsumedResourcesEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsumedResourcesEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConsumedResourcesEntityListing)));
            
        }
        
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consumed object ID</param> 
        /// <param name="objectType">Consumed object type</param> 
        /// <param name="resourceType">Types of consuming resources to show</param> 
        /// <returns>ConsumingResourcesEntityListing</returns>
        public ConsumingResourcesEntityListing ArchitectDependencytrackingConsumingresourcesGet (string id, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumingResourcesEntityListing> response = ArchitectDependencytrackingConsumingresourcesGetWithHttpInfo(id, objectType, resourceType);
             return response.Data;
        }

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consumed object ID</param> 
        /// <param name="objectType">Consumed object type</param> 
        /// <param name="resourceType">Types of consuming resources to show</param> 
        /// <returns>ApiResponse of ConsumingResourcesEntityListing</returns>
        public ApiResponse< ConsumingResourcesEntityListing > ArchitectDependencytrackingConsumingresourcesGetWithHttpInfo (string id, string objectType, List<string> resourceType = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectDependencytrackingConsumingresourcesGet");
            
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectDependencytrackingConsumingresourcesGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/consumingresources";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (resourceType != null) queryParams.Add("resourceType", Configuration.ApiClient.ParameterToString(resourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumingresourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumingresourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ConsumingResourcesEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsumingResourcesEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConsumingResourcesEntityListing)));
            
        }
    
        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show</param>
        /// <returns>Task of ConsumingResourcesEntityListing</returns>
        public async System.Threading.Tasks.Task<ConsumingResourcesEntityListing> ArchitectDependencytrackingConsumingresourcesGetAsync (string id, string objectType, List<string> resourceType = null)
        {
             ApiResponse<ConsumingResourcesEntityListing> response = await ArchitectDependencytrackingConsumingresourcesGetAsyncWithHttpInfo(id, objectType, resourceType);
             return response.Data;

        }

        /// <summary>
        /// Get resources that consume a given Dependency Tracking object 
        /// </summary>
        /// <param name="id">Consumed object ID</param>
        /// <param name="objectType">Consumed object type</param>
        /// <param name="resourceType">Types of consuming resources to show</param>
        /// <returns>Task of ApiResponse (ConsumingResourcesEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConsumingResourcesEntityListing>> ArchitectDependencytrackingConsumingresourcesGetAsyncWithHttpInfo (string id, string objectType, List<string> resourceType = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectDependencytrackingConsumingresourcesGet");
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling ArchitectDependencytrackingConsumingresourcesGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/consumingresources";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (resourceType != null) queryParams.Add("resourceType", Configuration.ApiClient.ParameterToString(resourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumingresourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingConsumingresourcesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ConsumingResourcesEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConsumingResourcesEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ConsumingResourcesEntityListing)));
            
        }
        
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <param name="name">Name to search for</param> 
        /// <param name="objectType">Object type(s) to search for</param> 
        /// <param name="flowFilter">Show only checkedIn or published flows</param> 
        /// <param name="consumedResources">Return consumed resources?</param> 
        /// <param name="consumedResourceType">Resource type(s) to return</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>DeletedResourceConsumerEntityListing</returns>
        public DeletedResourceConsumerEntityListing ArchitectDependencytrackingDeletedresourceconsumersGet (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DeletedResourceConsumerEntityListing> response = ArchitectDependencytrackingDeletedresourceconsumersGetWithHttpInfo(name, objectType, flowFilter, consumedResources, consumedResourceType, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <param name="name">Name to search for</param> 
        /// <param name="objectType">Object type(s) to search for</param> 
        /// <param name="flowFilter">Show only checkedIn or published flows</param> 
        /// <param name="consumedResources">Return consumed resources?</param> 
        /// <param name="consumedResourceType">Resource type(s) to return</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of DeletedResourceConsumerEntityListing</returns>
        public ApiResponse< DeletedResourceConsumerEntityListing > ArchitectDependencytrackingDeletedresourceconsumersGetWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/deletedresourceconsumers";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (flowFilter != null) queryParams.Add("flowFilter", Configuration.ApiClient.ParameterToString(flowFilter)); // query parameter
            if (consumedResources != null) queryParams.Add("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)); // query parameter
            if (consumedResourceType != null) queryParams.Add("consumedResourceType", Configuration.ApiClient.ParameterToString(consumedResourceType)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingDeletedresourceconsumersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingDeletedresourceconsumersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DeletedResourceConsumerEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeletedResourceConsumerEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DeletedResourceConsumerEntityListing)));
            
        }
    
        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <param name="name">Name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="flowFilter">Show only checkedIn or published flows</param>
        /// <param name="consumedResources">Return consumed resources?</param>
        /// <param name="consumedResourceType">Resource type(s) to return</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of DeletedResourceConsumerEntityListing</returns>
        public async System.Threading.Tasks.Task<DeletedResourceConsumerEntityListing> ArchitectDependencytrackingDeletedresourceconsumersGetAsync (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DeletedResourceConsumerEntityListing> response = await ArchitectDependencytrackingDeletedresourceconsumersGetAsyncWithHttpInfo(name, objectType, flowFilter, consumedResources, consumedResourceType, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get Dependency Tracking objects that consume deleted resources 
        /// </summary>
        /// <param name="name">Name to search for</param>
        /// <param name="objectType">Object type(s) to search for</param>
        /// <param name="flowFilter">Show only checkedIn or published flows</param>
        /// <param name="consumedResources">Return consumed resources?</param>
        /// <param name="consumedResourceType">Resource type(s) to return</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (DeletedResourceConsumerEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeletedResourceConsumerEntityListing>> ArchitectDependencytrackingDeletedresourceconsumersGetAsyncWithHttpInfo (string name = null, List<string> objectType = null, string flowFilter = null, bool? consumedResources = null, List<string> consumedResourceType = null, int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/deletedresourceconsumers";
    
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
            
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (flowFilter != null) queryParams.Add("flowFilter", Configuration.ApiClient.ParameterToString(flowFilter)); // query parameter
            if (consumedResources != null) queryParams.Add("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)); // query parameter
            if (consumedResourceType != null) queryParams.Add("consumedResourceType", Configuration.ApiClient.ParameterToString(consumedResourceType)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingDeletedresourceconsumersGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingDeletedresourceconsumersGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DeletedResourceConsumerEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeletedResourceConsumerEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DeletedResourceConsumerEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <param name="id">Object ID</param> 
        /// <param name="version">Object version</param> 
        /// <param name="objectType">Object type</param> 
        /// <param name="consumedResources">Include resources this item consumes</param> 
        /// <param name="consumingResources">Include resources that consume this item</param> 
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param> 
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param> 
        /// <returns>DependencyObject</returns>
        public DependencyObject ArchitectDependencytrackingObjectGet (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObject> response = ArchitectDependencytrackingObjectGetWithHttpInfo(id, version, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return response.Data;
        }

        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <param name="id">Object ID</param> 
        /// <param name="version">Object version</param> 
        /// <param name="objectType">Object type</param> 
        /// <param name="consumedResources">Include resources this item consumes</param> 
        /// <param name="consumingResources">Include resources that consume this item</param> 
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param> 
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param> 
        /// <returns>ApiResponse of DependencyObject</returns>
        public ApiResponse< DependencyObject > ArchitectDependencytrackingObjectGetWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectDependencytrackingObjectGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/object";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (consumedResources != null) queryParams.Add("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)); // query parameter
            if (consumingResources != null) queryParams.Add("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)); // query parameter
            if (consumedResourceType != null) queryParams.Add("consumedResourceType", Configuration.ApiClient.ParameterToString(consumedResourceType)); // query parameter
            if (consumingResourceType != null) queryParams.Add("consumingResourceType", Configuration.ApiClient.ParameterToString(consumingResourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingObjectGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingObjectGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DependencyObject>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyObject) Configuration.ApiClient.Deserialize(response, typeof(DependencyObject)));
            
        }
    
        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version</param>
        /// <param name="objectType">Object type</param>
        /// <param name="consumedResources">Include resources this item consumes</param>
        /// <param name="consumingResources">Include resources that consume this item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of DependencyObject</returns>
        public async System.Threading.Tasks.Task<DependencyObject> ArchitectDependencytrackingObjectGetAsync (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
             ApiResponse<DependencyObject> response = await ArchitectDependencytrackingObjectGetAsyncWithHttpInfo(id, version, objectType, consumedResources, consumingResources, consumedResourceType, consumingResourceType);
             return response.Data;

        }

        /// <summary>
        /// Get a Dependency Tracking object 
        /// </summary>
        /// <param name="id">Object ID</param>
        /// <param name="version">Object version</param>
        /// <param name="objectType">Object type</param>
        /// <param name="consumedResources">Include resources this item consumes</param>
        /// <param name="consumingResources">Include resources that consume this item</param>
        /// <param name="consumedResourceType">Types of consumed resources to return, if consumed resources are requested</param>
        /// <param name="consumingResourceType">Types of consuming resources to return, if consuming resources are requested</param>
        /// <returns>Task of ApiResponse (DependencyObject)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObject>> ArchitectDependencytrackingObjectGetAsyncWithHttpInfo (string id, string version = null, string objectType = null, bool? consumedResources = null, bool? consumingResources = null, List<string> consumedResourceType = null, List<string> consumingResourceType = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectDependencytrackingObjectGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/object";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            if (objectType != null) queryParams.Add("objectType", Configuration.ApiClient.ParameterToString(objectType)); // query parameter
            if (consumedResources != null) queryParams.Add("consumedResources", Configuration.ApiClient.ParameterToString(consumedResources)); // query parameter
            if (consumingResources != null) queryParams.Add("consumingResources", Configuration.ApiClient.ParameterToString(consumingResources)); // query parameter
            if (consumedResourceType != null) queryParams.Add("consumedResourceType", Configuration.ApiClient.ParameterToString(consumedResourceType)); // query parameter
            if (consumingResourceType != null) queryParams.Add("consumingResourceType", Configuration.ApiClient.ParameterToString(consumingResourceType)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingObjectGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingObjectGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DependencyObject>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyObject) Configuration.ApiClient.Deserialize(response, typeof(DependencyObject)));
            
        }
        
        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>DependencyTypeEntityListing</returns>
        public DependencyTypeEntityListing ArchitectDependencytrackingTypesGet (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyTypeEntityListing> response = ArchitectDependencytrackingTypesGetWithHttpInfo(pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of DependencyTypeEntityListing</returns>
        public ApiResponse< DependencyTypeEntityListing > ArchitectDependencytrackingTypesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/types";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DependencyTypeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyTypeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DependencyTypeEntityListing)));
            
        }
    
        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of DependencyTypeEntityListing</returns>
        public async System.Threading.Tasks.Task<DependencyTypeEntityListing> ArchitectDependencytrackingTypesGetAsync (int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<DependencyTypeEntityListing> response = await ArchitectDependencytrackingTypesGetAsyncWithHttpInfo(pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get Dependency Tracking types. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (DependencyTypeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyTypeEntityListing>> ArchitectDependencytrackingTypesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null)
        {
            
    
            var path_ = "/api/v1/architect/dependencytracking/types";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DependencyTypeEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyTypeEntityListing) Configuration.ApiClient.Deserialize(response, typeof(DependencyTypeEntityListing)));
            
        }
        
        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <param name="typeId">Type ID</param> 
        /// <returns>DependencyObject</returns>
        public DependencyObject ArchitectDependencytrackingTypesTypeidGet (string typeId)
        {
             ApiResponse<DependencyObject> response = ArchitectDependencytrackingTypesTypeidGetWithHttpInfo(typeId);
             return response.Data;
        }

        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <param name="typeId">Type ID</param> 
        /// <returns>ApiResponse of DependencyObject</returns>
        public ApiResponse< DependencyObject > ArchitectDependencytrackingTypesTypeidGetWithHttpInfo (string typeId)
        {
            
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling ArchitectDependencytrackingTypesTypeidGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/types/{typeId}";
    
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
            if (typeId != null) pathParams.Add("typeId", Configuration.ApiClient.ParameterToString(typeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesTypeidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesTypeidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DependencyObject>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyObject) Configuration.ApiClient.Deserialize(response, typeof(DependencyObject)));
            
        }
    
        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of DependencyObject</returns>
        public async System.Threading.Tasks.Task<DependencyObject> ArchitectDependencytrackingTypesTypeidGetAsync (string typeId)
        {
             ApiResponse<DependencyObject> response = await ArchitectDependencytrackingTypesTypeidGetAsyncWithHttpInfo(typeId);
             return response.Data;

        }

        /// <summary>
        /// Get a Dependency Tracking type. 
        /// </summary>
        /// <param name="typeId">Type ID</param>
        /// <returns>Task of ApiResponse (DependencyObject)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DependencyObject>> ArchitectDependencytrackingTypesTypeidGetAsyncWithHttpInfo (string typeId)
        {
            // verify the required parameter 'typeId' is set
            if (typeId == null) throw new ApiException(400, "Missing required parameter 'typeId' when calling ArchitectDependencytrackingTypesTypeidGet");
            
    
            var path_ = "/api/v1/architect/dependencytracking/types/{typeId}";
    
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
            if (typeId != null) pathParams.Add("typeId", Configuration.ApiClient.ParameterToString(typeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesTypeidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectDependencytrackingTypesTypeidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DependencyObject>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DependencyObject) Configuration.ApiClient.Deserialize(response, typeof(DependencyObject)));
            
        }
        
        /// <summary>
        /// Get IVR configs. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>IVREntityListing</returns>
        public IVREntityListing ArchitectIvrsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<IVREntityListing> response = ArchitectIvrsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< IVREntityListing > ArchitectIvrsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<IVREntityListing> ArchitectIvrsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<IVREntityListing> response = await ArchitectIvrsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<IVREntityListing>> ArchitectIvrsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVREntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVREntityListing) Configuration.ApiClient.Deserialize(response, typeof(IVREntityListing)));
            
        }
        
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>IVR</returns>
        public IVR ArchitectIvrsPost (IVR body = null)
        {
             ApiResponse<IVR> response = ArchitectIvrsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > ArchitectIvrsPostWithHttpInfo (IVR body = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> ArchitectIvrsPostAsync (IVR body = null)
        {
             ApiResponse<IVR> response = await ArchitectIvrsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create IVR config. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsPostAsyncWithHttpInfo (IVR body = null)
        {
            
    
            var path_ = "/api/v1/architect/ivrs";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>IVR</returns>
        public IVR ArchitectIvrsActionsPublishPost (string id)
        {
             ApiResponse<IVR> response = ArchitectIvrsActionsPublishPostWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > ArchitectIvrsActionsPublishPostWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectIvrsActionsPublishPost");
            
    
            var path_ = "/api/v1/architect/ivrs/actions/publish";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsActionsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsActionsPublishPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> ArchitectIvrsActionsPublishPostAsync (string id)
        {
             ApiResponse<IVR> response = await ArchitectIvrsActionsPublishPostAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        /// Publish an IVR config. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsActionsPublishPostAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchitectIvrsActionsPublishPost");
            
    
            var path_ = "/api/v1/architect/ivrs/actions/publish";
    
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
            
            if (id != null) queryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsActionsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsActionsPublishPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>IVR</returns>
        public IVR ArchitectIvrsIvridGet (string ivrId)
        {
             ApiResponse<IVR> response = ArchitectIvrsIvridGetWithHttpInfo(ivrId);
             return response.Data;
        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > ArchitectIvrsIvridGetWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectIvrsIvridGet");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
    
        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of IVR</returns>
        public async System.Threading.Tasks.Task<IVR> ArchitectIvrsIvridGetAsync (string ivrId)
        {
             ApiResponse<IVR> response = await ArchitectIvrsIvridGetAsyncWithHttpInfo(ivrId);
             return response.Data;

        }

        /// <summary>
        /// Get an IVR config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsIvridGetAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectIvrsIvridGet");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public IVR ArchitectIvrsIvridPut (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> response = ArchitectIvrsIvridPutWithHttpInfo(ivrId, body);
             return response.Data;
        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of IVR</returns>
        public ApiResponse< IVR > ArchitectIvrsIvridPutWithHttpInfo (string ivrId, IVR body = null)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectIvrsIvridPut");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<IVR> ArchitectIvrsIvridPutAsync (string ivrId, IVR body = null)
        {
             ApiResponse<IVR> response = await ArchitectIvrsIvridPutAsyncWithHttpInfo(ivrId, body);
             return response.Data;

        }

        /// <summary>
        /// Update an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (IVR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IVR>> ArchitectIvrsIvridPutAsyncWithHttpInfo (string ivrId, IVR body = null)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectIvrsIvridPut");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<IVR>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IVR) Configuration.ApiClient.Deserialize(response, typeof(IVR)));
            
        }
        
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>string</returns>
        public string ArchitectIvrsIvridDelete (string ivrId)
        {
             ApiResponse<string> response = ArchitectIvrsIvridDeleteWithHttpInfo(ivrId);
             return response.Data;
        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectIvrsIvridDeleteWithHttpInfo (string ivrId)
        {
            
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectIvrsIvridDelete");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ArchitectIvrsIvridDeleteAsync (string ivrId)
        {
             ApiResponse<string> response = await ArchitectIvrsIvridDeleteAsyncWithHttpInfo(ivrId);
             return response.Data;

        }

        /// <summary>
        /// Delete an IVR Config. 
        /// </summary>
        /// <param name="ivrId">IVR id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectIvrsIvridDeleteAsyncWithHttpInfo (string ivrId)
        {
            // verify the required parameter 'ivrId' is set
            if (ivrId == null) throw new ApiException(400, "Missing required parameter 'ivrId' when calling ArchitectIvrsIvridDelete");
            
    
            var path_ = "/api/v1/architect/ivrs/{ivrId}";
    
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
            if (ivrId != null) pathParams.Add("ivrId", Configuration.ApiClient.ParameterToString(ivrId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectIvrsIvridDelete: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptEntityListing ArchitectPromptsGet (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> response = ArchitectPromptsGetWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
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
        public ApiResponse< PromptEntityListing > ArchitectPromptsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptEntityListing> ArchitectPromptsGetAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<PromptEntityListing> response = await ArchitectPromptsGetAsyncWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription);
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
        public async System.Threading.Tasks.Task<ApiResponse<PromptEntityListing>> ArchitectPromptsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(PromptEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Prompt</returns>
        public Prompt ArchitectPromptsPost (Prompt body = null)
        {
             ApiResponse<Prompt> response = ArchitectPromptsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > ArchitectPromptsPostWithHttpInfo (Prompt body = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
    
        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> ArchitectPromptsPostAsync (Prompt body = null)
        {
             ApiResponse<Prompt> response = await ArchitectPromptsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new user prompt 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> ArchitectPromptsPostAsyncWithHttpInfo (Prompt body = null)
        {
            
    
            var path_ = "/api/v1/architect/prompts";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>Prompt</returns>
        public Prompt ArchitectPromptsPromptidGet (string promptId)
        {
             ApiResponse<Prompt> response = ArchitectPromptsPromptidGetWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > ArchitectPromptsPromptidGetWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidGet");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
    
        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of Prompt</returns>
        public async System.Threading.Tasks.Task<Prompt> ArchitectPromptsPromptidGetAsync (string promptId)
        {
             ApiResponse<Prompt> response = await ArchitectPromptsPromptidGetAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Get specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> ArchitectPromptsPromptidGetAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidGet");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public Prompt ArchitectPromptsPromptidPut (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> response = ArchitectPromptsPromptidPutWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Prompt</returns>
        public ApiResponse< Prompt > ArchitectPromptsPromptidPutWithHttpInfo (string promptId, Prompt body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidPut");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Prompt> ArchitectPromptsPromptidPutAsync (string promptId, Prompt body = null)
        {
             ApiResponse<Prompt> response = await ArchitectPromptsPromptidPutAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Update specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Prompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Prompt>> ArchitectPromptsPromptidPutAsyncWithHttpInfo (string promptId, Prompt body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidPut");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Prompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Prompt) Configuration.ApiClient.Deserialize(response, typeof(Prompt)));
            
        }
        
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>string</returns>
        public string ArchitectPromptsPromptidDelete (string promptId)
        {
             ApiResponse<string> response = ArchitectPromptsPromptidDeleteWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectPromptsPromptidDeleteWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidDelete");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ArchitectPromptsPromptidDeleteAsync (string promptId)
        {
             ApiResponse<string> response = await ArchitectPromptsPromptidDeleteAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Delete specified user prompt 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectPromptsPromptidDeleteAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidDelete");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>PromptAssetEntityListing</returns>
        public PromptAssetEntityListing ArchitectPromptsPromptidResourcesGet (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> response = ArchitectPromptsPromptidResourcesGetWithHttpInfo(promptId, pageNumber, pageSize);
             return response.Data;
        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <returns>ApiResponse of PromptAssetEntityListing</returns>
        public ApiResponse< PromptAssetEntityListing > ArchitectPromptsPromptidResourcesGetWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesGet");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAssetEntityListing> ArchitectPromptsPromptidResourcesGetAsync (string promptId, int? pageNumber = null, int? pageSize = null)
        {
             ApiResponse<PromptAssetEntityListing> response = await ArchitectPromptsPromptidResourcesGetAsyncWithHttpInfo(promptId, pageNumber, pageSize);
             return response.Data;

        }

        /// <summary>
        /// Get a pageable list of user prompt resources The returned list is pageable, and query paramaters can be used for filtering.
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Task of ApiResponse (PromptAssetEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAssetEntityListing>> ArchitectPromptsPromptidResourcesGetAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesGet");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptAsset ArchitectPromptsPromptidResourcesPost (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = ArchitectPromptsPromptidResourcesPostWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > ArchitectPromptsPromptidResourcesPostWithHttpInfo (string promptId, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesPost");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAsset> ArchitectPromptsPromptidResourcesPostAsync (string promptId, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = await ArchitectPromptsPromptidResourcesPostAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create a new user prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> ArchitectPromptsPromptidResourcesPostAsyncWithHttpInfo (string promptId, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesPost");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesPost: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptAsset ArchitectPromptsPromptidResourcesLanguageGet (string promptId, string language)
        {
             ApiResponse<PromptAsset> response = ArchitectPromptsPromptidResourcesLanguageGetWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > ArchitectPromptsPromptidResourcesLanguageGetWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesLanguageGet");
            
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectPromptsPromptidResourcesLanguageGet");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAsset> ArchitectPromptsPromptidResourcesLanguageGetAsync (string promptId, string language)
        {
             ApiResponse<PromptAsset> response = await ArchitectPromptsPromptidResourcesLanguageGetAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Get specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> ArchitectPromptsPromptidResourcesLanguageGetAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesLanguageGet");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectPromptsPromptidResourcesLanguageGet");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public PromptAsset ArchitectPromptsPromptidResourcesLanguagePut (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = ArchitectPromptsPromptidResourcesLanguagePutWithHttpInfo(promptId, language, body);
             return response.Data;
        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of PromptAsset</returns>
        public ApiResponse< PromptAsset > ArchitectPromptsPromptidResourcesLanguagePutWithHttpInfo (string promptId, string language, PromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesLanguagePut");
            
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectPromptsPromptidResourcesLanguagePut");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguagePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguagePut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PromptAsset> ArchitectPromptsPromptidResourcesLanguagePutAsync (string promptId, string language, PromptAsset body = null)
        {
             ApiResponse<PromptAsset> response = await ArchitectPromptsPromptidResourcesLanguagePutAsyncWithHttpInfo(promptId, language, body);
             return response.Data;

        }

        /// <summary>
        /// Update specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (PromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PromptAsset>> ArchitectPromptsPromptidResourcesLanguagePutAsyncWithHttpInfo (string promptId, string language, PromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesLanguagePut");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectPromptsPromptidResourcesLanguagePut");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguagePut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguagePut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<PromptAsset>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PromptAsset) Configuration.ApiClient.Deserialize(response, typeof(PromptAsset)));
            
        }
        
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>string</returns>
        public string ArchitectPromptsPromptidResourcesLanguageDelete (string promptId, string language)
        {
             ApiResponse<string> response = ArchitectPromptsPromptidResourcesLanguageDeleteWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectPromptsPromptidResourcesLanguageDeleteWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesLanguageDelete");
            
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectPromptsPromptidResourcesLanguageDelete");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ArchitectPromptsPromptidResourcesLanguageDeleteAsync (string promptId, string language)
        {
             ApiResponse<string> response = await ArchitectPromptsPromptidResourcesLanguageDeleteAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Delete specified user prompt resource 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectPromptsPromptidResourcesLanguageDeleteAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectPromptsPromptidResourcesLanguageDelete");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectPromptsPromptidResourcesLanguageDelete");
            
    
            var path_ = "/api/v1/architect/prompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectPromptsPromptidResourcesLanguageDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a list of schedule groups. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <returns>ScheduleGroupEntityListing</returns>
        public ScheduleGroupEntityListing ArchitectSchedulegroupsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleGroupEntityListing> response = ArchitectSchedulegroupsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< ScheduleGroupEntityListing > ArchitectSchedulegroupsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ScheduleGroupEntityListing> ArchitectSchedulegroupsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleGroupEntityListing> response = await ArchitectSchedulegroupsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroupEntityListing>> ArchitectSchedulegroupsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroupEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroupEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroupEntityListing)));
            
        }
        
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup ArchitectSchedulegroupsPost (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = ArchitectSchedulegroupsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > ArchitectSchedulegroupsPostWithHttpInfo (ScheduleGroup body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
    
        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> ArchitectSchedulegroupsPostAsync (ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = await ArchitectSchedulegroupsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Creates a new schedule group 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> ArchitectSchedulegroupsPostAsyncWithHttpInfo (ScheduleGroup body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedulegroups";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ScheduleGroup</returns>
        public ScheduleGroup ArchitectSchedulegroupsSchedulegroupidGet (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> response = ArchitectSchedulegroupsSchedulegroupidGetWithHttpInfo(scheduleGroupId);
             return response.Data;
        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > ArchitectSchedulegroupsSchedulegroupidGetWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectSchedulegroupsSchedulegroupidGet");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
    
        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ScheduleGroup</returns>
        public async System.Threading.Tasks.Task<ScheduleGroup> ArchitectSchedulegroupsSchedulegroupidGetAsync (string scheduleGroupId)
        {
             ApiResponse<ScheduleGroup> response = await ArchitectSchedulegroupsSchedulegroupidGetAsyncWithHttpInfo(scheduleGroupId);
             return response.Data;

        }

        /// <summary>
        /// Gets a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> ArchitectSchedulegroupsSchedulegroupidGetAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectSchedulegroupsSchedulegroupidGet");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public ScheduleGroup ArchitectSchedulegroupsSchedulegroupidPut (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = ArchitectSchedulegroupsSchedulegroupidPutWithHttpInfo(scheduleGroupId, body);
             return response.Data;
        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of ScheduleGroup</returns>
        public ApiResponse< ScheduleGroup > ArchitectSchedulegroupsSchedulegroupidPutWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectSchedulegroupsSchedulegroupidPut");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ScheduleGroup> ArchitectSchedulegroupsSchedulegroupidPutAsync (string scheduleGroupId, ScheduleGroup body = null)
        {
             ApiResponse<ScheduleGroup> response = await ArchitectSchedulegroupsSchedulegroupidPutAsyncWithHttpInfo(scheduleGroupId, body);
             return response.Data;

        }

        /// <summary>
        /// Updates a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (ScheduleGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleGroup>> ArchitectSchedulegroupsSchedulegroupidPutAsyncWithHttpInfo (string scheduleGroupId, ScheduleGroup body = null)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectSchedulegroupsSchedulegroupidPut");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleGroup>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleGroup) Configuration.ApiClient.Deserialize(response, typeof(ScheduleGroup)));
            
        }
        
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>string</returns>
        public string ArchitectSchedulegroupsSchedulegroupidDelete (string scheduleGroupId)
        {
             ApiResponse<string> response = ArchitectSchedulegroupsSchedulegroupidDeleteWithHttpInfo(scheduleGroupId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectSchedulegroupsSchedulegroupidDeleteWithHttpInfo (string scheduleGroupId)
        {
            
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectSchedulegroupsSchedulegroupidDelete");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ArchitectSchedulegroupsSchedulegroupidDeleteAsync (string scheduleGroupId)
        {
             ApiResponse<string> response = await ArchitectSchedulegroupsSchedulegroupidDeleteAsyncWithHttpInfo(scheduleGroupId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a schedule group by ID 
        /// </summary>
        /// <param name="scheduleGroupId">Schedule group ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectSchedulegroupsSchedulegroupidDeleteAsyncWithHttpInfo (string scheduleGroupId)
        {
            // verify the required parameter 'scheduleGroupId' is set
            if (scheduleGroupId == null) throw new ApiException(400, "Missing required parameter 'scheduleGroupId' when calling ArchitectSchedulegroupsSchedulegroupidDelete");
            
    
            var path_ = "/api/v1/architect/schedulegroups/{scheduleGroupId}";
    
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
            if (scheduleGroupId != null) pathParams.Add("scheduleGroupId", Configuration.ApiClient.ParameterToString(scheduleGroupId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulegroupsSchedulegroupidDelete: " + response.ErrorMessage, response.ErrorMessage);

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
        public ScheduleEntityListing ArchitectSchedulesGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleEntityListing> response = ArchitectSchedulesGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< ScheduleEntityListing > ArchitectSchedulesGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<ScheduleEntityListing> ArchitectSchedulesGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<ScheduleEntityListing> response = await ArchitectSchedulesGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<ScheduleEntityListing>> ArchitectSchedulesGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ScheduleEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScheduleEntityListing) Configuration.ApiClient.Deserialize(response, typeof(ScheduleEntityListing)));
            
        }
        
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Schedule</returns>
        public Schedule ArchitectSchedulesPost (Schedule body = null)
        {
             ApiResponse<Schedule> response = ArchitectSchedulesPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > ArchitectSchedulesPostWithHttpInfo (Schedule body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
    
        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> ArchitectSchedulesPostAsync (Schedule body = null)
        {
             ApiResponse<Schedule> response = await ArchitectSchedulesPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create a new schedule. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> ArchitectSchedulesPostAsyncWithHttpInfo (Schedule body = null)
        {
            
    
            var path_ = "/api/v1/architect/schedules";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>Schedule</returns>
        public Schedule ArchitectSchedulesScheduleidGet (string scheduleId)
        {
             ApiResponse<Schedule> response = ArchitectSchedulesScheduleidGetWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > ArchitectSchedulesScheduleidGetWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectSchedulesScheduleidGet");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
    
        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of Schedule</returns>
        public async System.Threading.Tasks.Task<Schedule> ArchitectSchedulesScheduleidGetAsync (string scheduleId)
        {
             ApiResponse<Schedule> response = await ArchitectSchedulesScheduleidGetAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Get a schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> ArchitectSchedulesScheduleidGetAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectSchedulesScheduleidGet");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public Schedule ArchitectSchedulesScheduleidPut (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> response = ArchitectSchedulesScheduleidPutWithHttpInfo(scheduleId, body);
             return response.Data;
        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Schedule</returns>
        public ApiResponse< Schedule > ArchitectSchedulesScheduleidPutWithHttpInfo (string scheduleId, Schedule body = null)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectSchedulesScheduleidPut");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Schedule> ArchitectSchedulesScheduleidPutAsync (string scheduleId, Schedule body = null)
        {
             ApiResponse<Schedule> response = await ArchitectSchedulesScheduleidPutAsyncWithHttpInfo(scheduleId, body);
             return response.Data;

        }

        /// <summary>
        /// Update schedule by ID 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Schedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Schedule>> ArchitectSchedulesScheduleidPutAsyncWithHttpInfo (string scheduleId, Schedule body = null)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectSchedulesScheduleidPut");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Schedule>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Schedule) Configuration.ApiClient.Deserialize(response, typeof(Schedule)));
            
        }
        
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>string</returns>
        public string ArchitectSchedulesScheduleidDelete (string scheduleId)
        {
             ApiResponse<string> response = ArchitectSchedulesScheduleidDeleteWithHttpInfo(scheduleId);
             return response.Data;
        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectSchedulesScheduleidDeleteWithHttpInfo (string scheduleId)
        {
            
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectSchedulesScheduleidDelete");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ArchitectSchedulesScheduleidDeleteAsync (string scheduleId)
        {
             ApiResponse<string> response = await ArchitectSchedulesScheduleidDeleteAsyncWithHttpInfo(scheduleId);
             return response.Data;

        }

        /// <summary>
        /// Delete a schedule by id 
        /// </summary>
        /// <param name="scheduleId">Schedule ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectSchedulesScheduleidDeleteAsyncWithHttpInfo (string scheduleId)
        {
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling ArchitectSchedulesScheduleidDelete");
            
    
            var path_ = "/api/v1/architect/schedules/{scheduleId}";
    
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
            if (scheduleId != null) pathParams.Add("scheduleId", Configuration.ApiClient.ParameterToString(scheduleId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSchedulesScheduleidDelete: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptEntityListing ArchitectSystempromptsGet (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<SystemPromptEntityListing> response = ArchitectSystempromptsGetWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
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
        public ApiResponse< SystemPromptEntityListing > ArchitectSystempromptsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/systemprompts";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptEntityListing> ArchitectSystempromptsGetAsync (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
             ApiResponse<SystemPromptEntityListing> response = await ArchitectSystempromptsGetAsyncWithHttpInfo(pageNumber, pageSize, sortBy, sortOrder, name, description, nameOrDescription);
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
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptEntityListing>> ArchitectSystempromptsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string name = null, string description = null, string nameOrDescription = null)
        {
            
    
            var path_ = "/api/v1/architect/systemprompts";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SystemPromptEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPromptEntityListing) Configuration.ApiClient.Deserialize(response, typeof(SystemPromptEntityListing)));
            
        }
        
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param> 
        /// <returns>SystemPrompt</returns>
        public SystemPrompt ArchitectSystempromptsPromptidGet (string promptId)
        {
             ApiResponse<SystemPrompt> response = ArchitectSystempromptsPromptidGetWithHttpInfo(promptId);
             return response.Data;
        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param> 
        /// <returns>ApiResponse of SystemPrompt</returns>
        public ApiResponse< SystemPrompt > ArchitectSystempromptsPromptidGetWithHttpInfo (string promptId)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidGet");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SystemPrompt>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SystemPrompt) Configuration.ApiClient.Deserialize(response, typeof(SystemPrompt)));
            
        }
    
        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param>
        /// <returns>Task of SystemPrompt</returns>
        public async System.Threading.Tasks.Task<SystemPrompt> ArchitectSystempromptsPromptidGetAsync (string promptId)
        {
             ApiResponse<SystemPrompt> response = await ArchitectSystempromptsPromptidGetAsyncWithHttpInfo(promptId);
             return response.Data;

        }

        /// <summary>
        /// Get IVR system prompt. 
        /// </summary>
        /// <param name="promptId"></param>
        /// <returns>Task of ApiResponse (SystemPrompt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPrompt>> ArchitectSystempromptsPromptidGetAsyncWithHttpInfo (string promptId)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidGet");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptAssetEntityListing ArchitectSystempromptsPromptidResourcesGet (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> response = ArchitectSystempromptsPromptidResourcesGetWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
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
        public ApiResponse< SystemPromptAssetEntityListing > ArchitectSystempromptsPromptidResourcesGetWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesGet");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptAssetEntityListing> ArchitectSystempromptsPromptidResourcesGetAsync (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
             ApiResponse<SystemPromptAssetEntityListing> response = await ArchitectSystempromptsPromptidResourcesGetAsyncWithHttpInfo(promptId, pageNumber, pageSize, sortBy, sortOrder);
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
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAssetEntityListing>> ArchitectSystempromptsPromptidResourcesGetAsyncWithHttpInfo (string promptId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesGet");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptAsset ArchitectSystempromptsPromptidResourcesPost (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> response = ArchitectSystempromptsPromptidResourcesPostWithHttpInfo(promptId, body);
             return response.Data;
        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > ArchitectSystempromptsPromptidResourcesPostWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesPost");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptAsset> ArchitectSystempromptsPromptidResourcesPostAsync (string promptId, SystemPromptAsset body = null)
        {
             ApiResponse<SystemPromptAsset> response = await ArchitectSystempromptsPromptidResourcesPostAsyncWithHttpInfo(promptId, body);
             return response.Data;

        }

        /// <summary>
        /// Create system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> ArchitectSystempromptsPromptidResourcesPostAsyncWithHttpInfo (string promptId, SystemPromptAsset body = null)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesPost");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesPost: " + response.ErrorMessage, response.ErrorMessage);

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
        public SystemPromptAsset ArchitectSystempromptsPromptidResourcesLanguageGet (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> response = ArchitectSystempromptsPromptidResourcesLanguageGetWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of SystemPromptAsset</returns>
        public ApiResponse< SystemPromptAsset > ArchitectSystempromptsPromptidResourcesLanguageGetWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesLanguageGet");
            
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectSystempromptsPromptidResourcesLanguageGet");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<SystemPromptAsset> ArchitectSystempromptsPromptidResourcesLanguageGetAsync (string promptId, string language)
        {
             ApiResponse<SystemPromptAsset> response = await ArchitectSystempromptsPromptidResourcesLanguageGetAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Get a system prompt resource. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (SystemPromptAsset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SystemPromptAsset>> ArchitectSystempromptsPromptidResourcesLanguageGetAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesLanguageGet");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectSystempromptsPromptidResourcesLanguageGet");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public string ArchitectSystempromptsPromptidResourcesLanguageDelete (string promptId, string language)
        {
             ApiResponse<string> response = ArchitectSystempromptsPromptidResourcesLanguageDeleteWithHttpInfo(promptId, language);
             return response.Data;
        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param> 
        /// <param name="language">Language</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectSystempromptsPromptidResourcesLanguageDeleteWithHttpInfo (string promptId, string language)
        {
            
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesLanguageDelete");
            
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectSystempromptsPromptidResourcesLanguageDelete");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageDelete: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<string> ArchitectSystempromptsPromptidResourcesLanguageDeleteAsync (string promptId, string language)
        {
             ApiResponse<string> response = await ArchitectSystempromptsPromptidResourcesLanguageDeleteAsyncWithHttpInfo(promptId, language);
             return response.Data;

        }

        /// <summary>
        /// Delete a system prompt resource override. 
        /// </summary>
        /// <param name="promptId">Prompt ID</param>
        /// <param name="language">Language</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectSystempromptsPromptidResourcesLanguageDeleteAsyncWithHttpInfo (string promptId, string language)
        {
            // verify the required parameter 'promptId' is set
            if (promptId == null) throw new ApiException(400, "Missing required parameter 'promptId' when calling ArchitectSystempromptsPromptidResourcesLanguageDelete");
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ArchitectSystempromptsPromptidResourcesLanguageDelete");
            
    
            var path_ = "/api/v1/architect/systemprompts/{promptId}/resources/{language}";
    
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
            if (promptId != null) pathParams.Add("promptId", Configuration.ApiClient.ParameterToString(promptId)); // path parameter
            if (language != null) pathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectSystempromptsPromptidResourcesLanguageDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get IVR voice XML operations. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <param name="method">Method</param> 
        /// <param name="type">Type</param> 
        /// <returns>VoiceXmlOperationEntityListing</returns>
        public VoiceXmlOperationEntityListing ArchitectVoicexmloperationsGet (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null)
        {
             ApiResponse<VoiceXmlOperationEntityListing> response = ArchitectVoicexmloperationsGetWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription, method, type);
             return response.Data;
        }

        /// <summary>
        /// Get IVR voice XML operations. 
        /// </summary>
        /// <param name="pageNumber">Page number</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="name">Name</param> 
        /// <param name="description">Description</param> 
        /// <param name="nameOrDescription">Name or description</param> 
        /// <param name="method">Method</param> 
        /// <param name="type">Type</param> 
        /// <returns>ApiResponse of VoiceXmlOperationEntityListing</returns>
        public ApiResponse< VoiceXmlOperationEntityListing > ArchitectVoicexmloperationsGetWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null)
        {
            
    
            var path_ = "/api/v1/architect/voicexmloperations";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (method != null) queryParams.Add("method", Configuration.ApiClient.ParameterToString(method)); // query parameter
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceXmlOperationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperationEntityListing)));
            
        }
    
        /// <summary>
        /// Get IVR voice XML operations. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="method">Method</param>
        /// <param name="type">Type</param>
        /// <returns>Task of VoiceXmlOperationEntityListing</returns>
        public async System.Threading.Tasks.Task<VoiceXmlOperationEntityListing> ArchitectVoicexmloperationsGetAsync (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null)
        {
             ApiResponse<VoiceXmlOperationEntityListing> response = await ArchitectVoicexmloperationsGetAsyncWithHttpInfo(pageNumber, pageSize, name, description, nameOrDescription, method, type);
             return response.Data;

        }

        /// <summary>
        /// Get IVR voice XML operations. 
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="nameOrDescription">Name or description</param>
        /// <param name="method">Method</param>
        /// <param name="type">Type</param>
        /// <returns>Task of ApiResponse (VoiceXmlOperationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperationEntityListing>> ArchitectVoicexmloperationsGetAsyncWithHttpInfo (int? pageNumber = null, int? pageSize = null, string name = null, string description = null, string nameOrDescription = null, string method = null, string type = null)
        {
            
    
            var path_ = "/api/v1/architect/voicexmloperations";
    
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
            
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (description != null) queryParams.Add("description", Configuration.ApiClient.ParameterToString(description)); // query parameter
            if (nameOrDescription != null) queryParams.Add("nameOrDescription", Configuration.ApiClient.ParameterToString(nameOrDescription)); // query parameter
            if (method != null) queryParams.Add("method", Configuration.ApiClient.ParameterToString(method)); // query parameter
            if (type != null) queryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceXmlOperationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperationEntityListing)));
            
        }
        
        /// <summary>
        /// Create IVR voice XML operations. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>VoiceXmlOperation</returns>
        public VoiceXmlOperation ArchitectVoicexmloperationsPost (VoiceXmlOperation body = null)
        {
             ApiResponse<VoiceXmlOperation> response = ArchitectVoicexmloperationsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create IVR voice XML operations. 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of VoiceXmlOperation</returns>
        public ApiResponse< VoiceXmlOperation > ArchitectVoicexmloperationsPostWithHttpInfo (VoiceXmlOperation body = null)
        {
            
    
            var path_ = "/api/v1/architect/voicexmloperations";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceXmlOperation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperation) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperation)));
            
        }
    
        /// <summary>
        /// Create IVR voice XML operations. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of VoiceXmlOperation</returns>
        public async System.Threading.Tasks.Task<VoiceXmlOperation> ArchitectVoicexmloperationsPostAsync (VoiceXmlOperation body = null)
        {
             ApiResponse<VoiceXmlOperation> response = await ArchitectVoicexmloperationsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create IVR voice XML operations. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (VoiceXmlOperation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperation>> ArchitectVoicexmloperationsPostAsyncWithHttpInfo (VoiceXmlOperation body = null)
        {
            
    
            var path_ = "/api/v1/architect/voicexmloperations";
    
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceXmlOperation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperation) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperation)));
            
        }
        
        /// <summary>
        /// Get IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param> 
        /// <returns>VoiceXmlOperation</returns>
        public VoiceXmlOperation ArchitectVoicexmloperationsVoicexmloperationidGet (string voiceXmlOperationId)
        {
             ApiResponse<VoiceXmlOperation> response = ArchitectVoicexmloperationsVoicexmloperationidGetWithHttpInfo(voiceXmlOperationId);
             return response.Data;
        }

        /// <summary>
        /// Get IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param> 
        /// <returns>ApiResponse of VoiceXmlOperation</returns>
        public ApiResponse< VoiceXmlOperation > ArchitectVoicexmloperationsVoicexmloperationidGetWithHttpInfo (string voiceXmlOperationId)
        {
            
            // verify the required parameter 'voiceXmlOperationId' is set
            if (voiceXmlOperationId == null) throw new ApiException(400, "Missing required parameter 'voiceXmlOperationId' when calling ArchitectVoicexmloperationsVoicexmloperationidGet");
            
    
            var path_ = "/api/v1/architect/voicexmloperations/{voiceXmlOperationId}";
    
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
            if (voiceXmlOperationId != null) pathParams.Add("voiceXmlOperationId", Configuration.ApiClient.ParameterToString(voiceXmlOperationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceXmlOperation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperation) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperation)));
            
        }
    
        /// <summary>
        /// Get IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of VoiceXmlOperation</returns>
        public async System.Threading.Tasks.Task<VoiceXmlOperation> ArchitectVoicexmloperationsVoicexmloperationidGetAsync (string voiceXmlOperationId)
        {
             ApiResponse<VoiceXmlOperation> response = await ArchitectVoicexmloperationsVoicexmloperationidGetAsyncWithHttpInfo(voiceXmlOperationId);
             return response.Data;

        }

        /// <summary>
        /// Get IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of ApiResponse (VoiceXmlOperation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperation>> ArchitectVoicexmloperationsVoicexmloperationidGetAsyncWithHttpInfo (string voiceXmlOperationId)
        {
            // verify the required parameter 'voiceXmlOperationId' is set
            if (voiceXmlOperationId == null) throw new ApiException(400, "Missing required parameter 'voiceXmlOperationId' when calling ArchitectVoicexmloperationsVoicexmloperationidGet");
            
    
            var path_ = "/api/v1/architect/voicexmloperations/{voiceXmlOperationId}";
    
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
            if (voiceXmlOperationId != null) pathParams.Add("voiceXmlOperationId", Configuration.ApiClient.ParameterToString(voiceXmlOperationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceXmlOperation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperation) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperation)));
            
        }
        
        /// <summary>
        /// Update IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param> 
        /// <param name="body"></param> 
        /// <returns>VoiceXmlOperation</returns>
        public VoiceXmlOperation ArchitectVoicexmloperationsVoicexmloperationidPut (string voiceXmlOperationId, VoiceXmlOperation body = null)
        {
             ApiResponse<VoiceXmlOperation> response = ArchitectVoicexmloperationsVoicexmloperationidPutWithHttpInfo(voiceXmlOperationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of VoiceXmlOperation</returns>
        public ApiResponse< VoiceXmlOperation > ArchitectVoicexmloperationsVoicexmloperationidPutWithHttpInfo (string voiceXmlOperationId, VoiceXmlOperation body = null)
        {
            
            // verify the required parameter 'voiceXmlOperationId' is set
            if (voiceXmlOperationId == null) throw new ApiException(400, "Missing required parameter 'voiceXmlOperationId' when calling ArchitectVoicexmloperationsVoicexmloperationidPut");
            
    
            var path_ = "/api/v1/architect/voicexmloperations/{voiceXmlOperationId}";
    
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
            if (voiceXmlOperationId != null) pathParams.Add("voiceXmlOperationId", Configuration.ApiClient.ParameterToString(voiceXmlOperationId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<VoiceXmlOperation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperation) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperation)));
            
        }
    
        /// <summary>
        /// Update IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of VoiceXmlOperation</returns>
        public async System.Threading.Tasks.Task<VoiceXmlOperation> ArchitectVoicexmloperationsVoicexmloperationidPutAsync (string voiceXmlOperationId, VoiceXmlOperation body = null)
        {
             ApiResponse<VoiceXmlOperation> response = await ArchitectVoicexmloperationsVoicexmloperationidPutAsyncWithHttpInfo(voiceXmlOperationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (VoiceXmlOperation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VoiceXmlOperation>> ArchitectVoicexmloperationsVoicexmloperationidPutAsyncWithHttpInfo (string voiceXmlOperationId, VoiceXmlOperation body = null)
        {
            // verify the required parameter 'voiceXmlOperationId' is set
            if (voiceXmlOperationId == null) throw new ApiException(400, "Missing required parameter 'voiceXmlOperationId' when calling ArchitectVoicexmloperationsVoicexmloperationidPut");
            
    
            var path_ = "/api/v1/architect/voicexmloperations/{voiceXmlOperationId}";
    
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
            if (voiceXmlOperationId != null) pathParams.Add("voiceXmlOperationId", Configuration.ApiClient.ParameterToString(voiceXmlOperationId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<VoiceXmlOperation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VoiceXmlOperation) Configuration.ApiClient.Deserialize(response, typeof(VoiceXmlOperation)));
            
        }
        
        /// <summary>
        /// Delete IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param> 
        /// <returns>string</returns>
        public string ArchitectVoicexmloperationsVoicexmloperationidDelete (string voiceXmlOperationId)
        {
             ApiResponse<string> response = ArchitectVoicexmloperationsVoicexmloperationidDeleteWithHttpInfo(voiceXmlOperationId);
             return response.Data;
        }

        /// <summary>
        /// Delete IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ArchitectVoicexmloperationsVoicexmloperationidDeleteWithHttpInfo (string voiceXmlOperationId)
        {
            
            // verify the required parameter 'voiceXmlOperationId' is set
            if (voiceXmlOperationId == null) throw new ApiException(400, "Missing required parameter 'voiceXmlOperationId' when calling ArchitectVoicexmloperationsVoicexmloperationidDelete");
            
    
            var path_ = "/api/v1/architect/voicexmloperations/{voiceXmlOperationId}";
    
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
            if (voiceXmlOperationId != null) pathParams.Add("voiceXmlOperationId", Configuration.ApiClient.ParameterToString(voiceXmlOperationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ArchitectVoicexmloperationsVoicexmloperationidDeleteAsync (string voiceXmlOperationId)
        {
             ApiResponse<string> response = await ArchitectVoicexmloperationsVoicexmloperationidDeleteAsyncWithHttpInfo(voiceXmlOperationId);
             return response.Data;

        }

        /// <summary>
        /// Delete IVR voice XML operation. 
        /// </summary>
        /// <param name="voiceXmlOperationId">Voice XML operation ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ArchitectVoicexmloperationsVoicexmloperationidDeleteAsyncWithHttpInfo (string voiceXmlOperationId)
        {
            // verify the required parameter 'voiceXmlOperationId' is set
            if (voiceXmlOperationId == null) throw new ApiException(400, "Missing required parameter 'voiceXmlOperationId' when calling ArchitectVoicexmloperationsVoicexmloperationidDelete");
            
    
            var path_ = "/api/v1/architect/voicexmloperations/{voiceXmlOperationId}";
    
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
            if (voiceXmlOperationId != null) pathParams.Add("voiceXmlOperationId", Configuration.ApiClient.ParameterToString(voiceXmlOperationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ArchitectVoicexmloperationsVoicexmloperationidDelete: " + response.ErrorMessage, response.ErrorMessage);

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
        /// <param name="lockedBy">Locked by</param> 
        /// <returns>FlowEntityListing</returns>
        public FlowEntityListing FlowsGet (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {
             ApiResponse<FlowEntityListing> response = FlowsGetWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, lockedBy);
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
        /// <param name="lockedBy">Locked by</param> 
        /// <returns>ApiResponse of FlowEntityListing</returns>
        public ApiResponse< FlowEntityListing > FlowsGetWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
            if (lockedBy != null) queryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <param name="lockedBy">Locked by</param>
        /// <returns>Task of FlowEntityListing</returns>
        public async System.Threading.Tasks.Task<FlowEntityListing> FlowsGetAsync (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {
             ApiResponse<FlowEntityListing> response = await FlowsGetAsyncWithHttpInfo(type, pageNumber, pageSize, sortBy, sortOrder, id, name, description, nameOrDescription, publishVersionId, lockedBy);
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
        /// <param name="lockedBy">Locked by</param>
        /// <returns>Task of ApiResponse (FlowEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowEntityListing>> FlowsGetAsyncWithHttpInfo (string type = null, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, List<string> id = null, string name = null, string description = null, string nameOrDescription = null, string publishVersionId = null, string lockedBy = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
            if (lockedBy != null) queryParams.Add("lockedBy", Configuration.ApiClient.ParameterToString(lockedBy)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FlowEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlowEntityListing) Configuration.ApiClient.Deserialize(response, typeof(FlowEntityListing)));
            
        }
        
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>Flow</returns>
        public Flow FlowsPost (Flow body = null)
        {
             ApiResponse<Flow> response = FlowsPostWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsPostWithHttpInfo (Flow body = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
                throw new ApiException (statusCode, "Error calling FlowsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsPostAsync (Flow body = null)
        {
             ApiResponse<Flow> response = await FlowsPostAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Create flow 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsPostAsyncWithHttpInfo (Flow body = null)
        {
            
    
            var path_ = "/api/v1/flows";
    
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
                throw new ApiException (statusCode, "Error calling FlowsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow FlowsActionsCheckinPost (string flow = null)
        {
             ApiResponse<Flow> response = FlowsActionsCheckinPostWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsActionsCheckinPostWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkin";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckinPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckinPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsActionsCheckinPostAsync (string flow = null)
        {
             ApiResponse<Flow> response = await FlowsActionsCheckinPostAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Check-in flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsCheckinPostAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkin";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckinPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckinPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow FlowsActionsCheckoutPost (string flow = null)
        {
             ApiResponse<Flow> response = FlowsActionsCheckoutPostWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsActionsCheckoutPostWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkout";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckoutPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckoutPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsActionsCheckoutPostAsync (string flow = null)
        {
             ApiResponse<Flow> response = await FlowsActionsCheckoutPostAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Check-out flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsCheckoutPostAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/checkout";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckoutPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsCheckoutPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow FlowsActionsDeactivatePost (string flow = null)
        {
             ApiResponse<Flow> response = FlowsActionsDeactivatePostWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsActionsDeactivatePostWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/deactivate";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsDeactivatePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsDeactivatePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsActionsDeactivatePostAsync (string flow = null)
        {
             ApiResponse<Flow> response = await FlowsActionsDeactivatePostAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Deactivate flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsDeactivatePostAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/deactivate";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsDeactivatePost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsDeactivatePost: " + response.ErrorMessage, response.ErrorMessage);

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
        public void FlowsActionsDebugPost (string version, string flow = null)
        {
             FlowsActionsDebugPostWithHttpInfo(version, flow);
        }

        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param> 
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> FlowsActionsDebugPostWithHttpInfo (string version, string flow = null)
        {
            
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling FlowsActionsDebugPost");
            
    
            var path_ = "/api/v1/flows/actions/debug";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsDebugPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsDebugPost: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task FlowsActionsDebugPostAsync (string version, string flow = null)
        {
             await FlowsActionsDebugPostAsyncWithHttpInfo(version, flow);

        }

        /// <summary>
        /// Debug flow 
        /// </summary>
        /// <param name="version"></param>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> FlowsActionsDebugPostAsyncWithHttpInfo (string version, string flow = null)
        {
            // verify the required parameter 'version' is set
            if (version == null) throw new ApiException(400, "Missing required parameter 'version' when calling FlowsActionsDebugPost");
            
    
            var path_ = "/api/v1/flows/actions/debug";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsDebugPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsDebugPost: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Publish flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <param name="version">version</param> 
        /// <returns>Flow</returns>
        public Flow FlowsActionsPublishPost (string flow = null, string version = null)
        {
             ApiResponse<Flow> response = FlowsActionsPublishPostWithHttpInfo(flow, version);
             return response.Data;
        }

        /// <summary>
        /// Publish flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <param name="version">version</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsActionsPublishPostWithHttpInfo (string flow = null, string version = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/publish";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsPublishPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Publish flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <param name="version">version</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsActionsPublishPostAsync (string flow = null, string version = null)
        {
             ApiResponse<Flow> response = await FlowsActionsPublishPostAsyncWithHttpInfo(flow, version);
             return response.Data;

        }

        /// <summary>
        /// Publish flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <param name="version">version</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsPublishPostAsyncWithHttpInfo (string flow = null, string version = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/publish";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            if (version != null) queryParams.Add("version", Configuration.ApiClient.ParameterToString(version)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsPublishPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsPublishPost: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>Flow</returns>
        public Flow FlowsActionsRevertPost (string flow = null)
        {
             ApiResponse<Flow> response = FlowsActionsRevertPostWithHttpInfo(flow);
             return response.Data;
        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsActionsRevertPostWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/revert";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsRevertPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsRevertPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
    
        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of Flow</returns>
        public async System.Threading.Tasks.Task<Flow> FlowsActionsRevertPostAsync (string flow = null)
        {
             ApiResponse<Flow> response = await FlowsActionsRevertPostAsyncWithHttpInfo(flow);
             return response.Data;

        }

        /// <summary>
        /// Revert flow 
        /// </summary>
        /// <param name="flow">Flow</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsActionsRevertPostAsyncWithHttpInfo (string flow = null)
        {
            
    
            var path_ = "/api/v1/flows/actions/revert";
    
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
            
            if (flow != null) queryParams.Add("flow", Configuration.ApiClient.ParameterToString(flow)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsActionsRevertPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsActionsRevertPost: " + response.ErrorMessage, response.ErrorMessage);

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
        public Flow FlowsFlowidGet (string flowId, string deleted = null)
        {
             ApiResponse<Flow> response = FlowsFlowidGetWithHttpInfo(flowId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsFlowidGetWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidGet");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Flow> FlowsFlowidGetAsync (string flowId, string deleted = null)
        {
             ApiResponse<Flow> response = await FlowsFlowidGetAsyncWithHttpInfo(flowId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsFlowidGetAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidGet");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public Flow FlowsFlowidPut (string flowId, Flow body = null)
        {
             ApiResponse<Flow> response = FlowsFlowidPutWithHttpInfo(flowId, body);
             return response.Data;
        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Flow</returns>
        public ApiResponse< Flow > FlowsFlowidPutWithHttpInfo (string flowId, Flow body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidPut");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidPut: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Flow> FlowsFlowidPutAsync (string flowId, Flow body = null)
        {
             ApiResponse<Flow> response = await FlowsFlowidPutAsyncWithHttpInfo(flowId, body);
             return response.Data;

        }

        /// <summary>
        /// Update flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Flow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Flow>> FlowsFlowidPutAsyncWithHttpInfo (string flowId, Flow body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidPut");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidPut: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidPut: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Flow>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Flow) Configuration.ApiClient.Deserialize(response, typeof(Flow)));
            
        }
        
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <returns>string</returns>
        public string FlowsFlowidDelete (string flowId)
        {
             ApiResponse<string> response = FlowsFlowidDeleteWithHttpInfo(flowId);
             return response.Data;
        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > FlowsFlowidDeleteWithHttpInfo (string flowId)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidDelete");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> FlowsFlowidDeleteAsync (string flowId)
        {
             ApiResponse<string> response = await FlowsFlowidDeleteAsyncWithHttpInfo(flowId);
             return response.Data;

        }

        /// <summary>
        /// Delete flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> FlowsFlowidDeleteAsyncWithHttpInfo (string flowId)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidDelete");
            
    
            var path_ = "/api/v1/flows/{flowId}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidDelete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidDelete: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 FlowsFlowidLatestconfigurationGet (string flowId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = FlowsFlowidLatestconfigurationGetWithHttpInfo(flowId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > FlowsFlowidLatestconfigurationGetWithHttpInfo (string flowId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidLatestconfigurationGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/latestconfiguration";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidLatestconfigurationGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidLatestconfigurationGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InlineResponse200> FlowsFlowidLatestconfigurationGetAsync (string flowId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = await FlowsFlowidLatestconfigurationGetAsyncWithHttpInfo(flowId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get the latest configuration for flow. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> FlowsFlowidLatestconfigurationGetAsyncWithHttpInfo (string flowId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidLatestconfigurationGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/latestconfiguration";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            if (deleted != null) queryParams.Add("deleted", Configuration.ApiClient.ParameterToString(deleted)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidLatestconfigurationGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidLatestconfigurationGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public PublishedResult FlowsFlowidPublishedresultsIdGet (string flowId, string id)
        {
             ApiResponse<PublishedResult> response = FlowsFlowidPublishedresultsIdGetWithHttpInfo(flowId, id);
             return response.Data;
        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="id">Publish Result ID</param> 
        /// <returns>ApiResponse of PublishedResult</returns>
        public ApiResponse< PublishedResult > FlowsFlowidPublishedresultsIdGetWithHttpInfo (string flowId, string id)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidPublishedresultsIdGet");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FlowsFlowidPublishedresultsIdGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/publishedresults/{id}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidPublishedresultsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidPublishedresultsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PublishedResult> FlowsFlowidPublishedresultsIdGetAsync (string flowId, string id)
        {
             ApiResponse<PublishedResult> response = await FlowsFlowidPublishedresultsIdGetAsyncWithHttpInfo(flowId, id);
             return response.Data;

        }

        /// <summary>
        /// Get generation result. 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="id">Publish Result ID</param>
        /// <returns>Task of ApiResponse (PublishedResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PublishedResult>> FlowsFlowidPublishedresultsIdGetAsyncWithHttpInfo (string flowId, string id)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidPublishedresultsIdGet");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FlowsFlowidPublishedresultsIdGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/publishedresults/{id}";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidPublishedresultsIdGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidPublishedresultsIdGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowVersionEntityListing FlowsFlowidVersionsGet (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> response = FlowsFlowidVersionsGetWithHttpInfo(flowId, pageNumber, pageSize, deleted);
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
        public ApiResponse< FlowVersionEntityListing > FlowsFlowidVersionsGetWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowVersionEntityListing> FlowsFlowidVersionsGetAsync (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
             ApiResponse<FlowVersionEntityListing> response = await FlowsFlowidVersionsGetAsyncWithHttpInfo(flowId, pageNumber, pageSize, deleted);
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
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersionEntityListing>> FlowsFlowidVersionsGetAsyncWithHttpInfo (string flowId, int? pageNumber = null, int? pageSize = null, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowVersion FlowsFlowidVersionsPost (string flowId, Body3 body = null)
        {
             ApiResponse<FlowVersion> response = FlowsFlowidVersionsPostWithHttpInfo(flowId, body);
             return response.Data;
        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > FlowsFlowidVersionsPostWithHttpInfo (string flowId, Body3 body = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsPost");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsPost: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowVersion> FlowsFlowidVersionsPostAsync (string flowId, Body3 body = null)
        {
             ApiResponse<FlowVersion> response = await FlowsFlowidVersionsPostAsyncWithHttpInfo(flowId, body);
             return response.Data;

        }

        /// <summary>
        /// Create flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> FlowsFlowidVersionsPostAsyncWithHttpInfo (string flowId, Body3 body = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsPost");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions";
    
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
            if (flowId != null) pathParams.Add("flowId", Configuration.ApiClient.ParameterToString(flowId)); // path parameter
            
            
            
            
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
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsPost: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsPost: " + response.ErrorMessage, response.ErrorMessage);

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
        public FlowVersion FlowsFlowidVersionsVersionidGet (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> response = FlowsFlowidVersionsVersionidGetWithHttpInfo(flowId, versionId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of FlowVersion</returns>
        public ApiResponse< FlowVersion > FlowsFlowidVersionsVersionidGetWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsVersionidGet");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling FlowsFlowidVersionsVersionidGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<FlowVersion> FlowsFlowidVersionsVersionidGetAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<FlowVersion> response = await FlowsFlowidVersionsVersionidGetAsyncWithHttpInfo(flowId, versionId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Get flow version 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (FlowVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlowVersion>> FlowsFlowidVersionsVersionidGetAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsVersionidGet");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling FlowsFlowidVersionsVersionidGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidGet: " + response.ErrorMessage, response.ErrorMessage);

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
        public InlineResponse200 FlowsFlowidVersionsVersionidConfigurationGet (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = FlowsFlowidVersionsVersionidConfigurationGetWithHttpInfo(flowId, versionId, deleted);
             return response.Data;
        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param> 
        /// <param name="versionId">Version ID</param> 
        /// <param name="deleted">Deleted</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > FlowsFlowidVersionsVersionidConfigurationGetWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsVersionidConfigurationGet");
            
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling FlowsFlowidVersionsVersionidConfigurationGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}/configuration";
    
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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidConfigurationGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidConfigurationGet: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<InlineResponse200> FlowsFlowidVersionsVersionidConfigurationGetAsync (string flowId, string versionId, string deleted = null)
        {
             ApiResponse<InlineResponse200> response = await FlowsFlowidVersionsVersionidConfigurationGetAsyncWithHttpInfo(flowId, versionId, deleted);
             return response.Data;

        }

        /// <summary>
        /// Create flow version configuration 
        /// </summary>
        /// <param name="flowId">Flow ID</param>
        /// <param name="versionId">Version ID</param>
        /// <param name="deleted">Deleted</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> FlowsFlowidVersionsVersionidConfigurationGetAsyncWithHttpInfo (string flowId, string versionId, string deleted = null)
        {
            // verify the required parameter 'flowId' is set
            if (flowId == null) throw new ApiException(400, "Missing required parameter 'flowId' when calling FlowsFlowidVersionsVersionidConfigurationGet");
            // verify the required parameter 'versionId' is set
            if (versionId == null) throw new ApiException(400, "Missing required parameter 'versionId' when calling FlowsFlowidVersionsVersionidConfigurationGet");
            
    
            var path_ = "/api/v1/flows/{flowId}/versions/{versionId}/configuration";
    
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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidConfigurationGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FlowsFlowidVersionsVersionidConfigurationGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
    }
    
}
